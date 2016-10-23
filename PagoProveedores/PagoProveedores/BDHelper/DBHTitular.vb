Imports System.Data.SqlClient
Imports PagoProveedores.QB
Public Class DBHTitular

    Public Shared Function getTitulares() As DataTable
        Dim p As New QB.QueryBuilder
        p.table("Titulares").seleccionar({"id_titular Id", "@(nombre + ' ' + apellido) as Nombre", "cuit Cuit"})
        Return DBConn.executeSQL(p.build)
    End Function

    Public Shared Function modifyTitular(id_titular As Integer, nombre As String, apellido As String, cuit As Long, calle As String, altura As Integer) As Boolean
        Dim q As New QB.QueryBuilder
        'Verifico si el Cuit es -1 o un cuit valido.
        Dim c As String
        If cuit = -1 Then
            c = "@null"
        Else
            c = cuit
        End If

        'Otra vez. El where tiene que ir con @ el nombre del campo.
        'Cree la variable c arriba para ingresar null cunado me pasan -1... usar esa variable no cuit
        q.table("Titulares").update({
                                    {"apellido", apellido},
                                    {"nombre", nombre},
                                    {"cuit", c},
                                    {"calle", calle},
                                    {"altura", altura}
                                }).
                            where("@id_titular", id_titular)
        Return DBConn.executeOnlySQL(q.build)
    End Function


    Public Shared Function addTitular(nombre As String, apellido As String, cuit As Long, calle As String, altura As Integer) As Boolean
        Dim q As New QB.QueryBuilder

        'Verifico si el Cuit es -1 o un cuit valido.
        Dim c As String
        If cuit = -1 Then
            c = "@null"
        Else
            c = cuit
        End If
        q.table("Titulares").insert({
                                    {"nombre", nombre},
                                    {"apellido", apellido},
                                    {"cuit", c},
                                    {"calle", calle},
                                    {"altura", altura}
                                })
        Return DBConn.executeOnlySQL(q.build)
    End Function

    Public Shared Function getCuentas(id_titular As Integer)
        Dim q As New QB.QueryBuilder
        q.table("Cuentas").seleccionar({"nro_cuenta", "cbu"}).join("Bancos", "nro_banco", {"nombre Banco"}).where("@id_titular", id_titular)
        Return DBConn.executeSQL(q.build)
    End Function

    Public Shared Function getTitular(id_titular As Integer) As Titular


        Dim q As New QB.QueryBuilder
        'Corrijo Tabla Titulares no Titular
        'Corrijo, Si en el where alguno de ambos lados es una exprecion va con @
        q.table("Titulares").seleccionar.where("@id_titular", id_titular)
        Dim b As DataTable = DBConn.executeSQL(q.build)

        'Saco toda la transformacion de tabla a objecto a una funcion para poder llamarla desde otro lado.
        Dim t As Titular = fromRowToTitular(b.Rows(0))
        
        Return t

    End Function

    Private Shared Function fromRowToTitular(r As DataRow, Optional id_banco As Integer = -1) As Titular

        Dim apellido As String = r.Item("apellido"),
            nombre As String = DBUtils.ifNULLEmpty(r.Item("nombre")),
            cuit As Long = DBUtils.ifNULLCero(r.Item("cuit")),
            calle As String = DBUtils.ifNULLEmpty(r.Item("calle")),
            altura As Integer = DBUtils.ifNULLCero(r.Item("altura")),
            id_titular As Integer = DBUtils.ifNULLCero(r.Item("id_titular"))


        'Esto provoca un NullPointerException porque nunca se hace un New Titular.
        Dim t As New Titular With {
            .id_titular = id_titular,
            .apellido = apellido,
            .nombre = nombre,
            .calle = calle,
            .altura = altura,
            .cuit = cuit
        }

        Dim q As New QB.QueryBuilder
        'La tabla se llama Cuentas no Cuenta. En el where como es el nombre de un campo va con @

        q.table("Cuentas").seleccionar.join("Bancos", "nro_banco").where("@id_titular", id_titular)
        If id_banco <> -1 Then q.where("@Bancos.nro_banco", id_banco)

        Dim b As DataTable
        b = DBConn.executeSQL(q.build)

        Dim c As Cuenta
        Dim ban As Banco
        For Each Cuenta As DataRow In b.Rows

            Dim nro_cuenta As String = Cuenta.Item("nro_cuenta"),
                nro_banco As Integer = Cuenta.Item("nro_banco"),
                nom_banco As String = Cuenta.Item("nombre"),
                sucursal As Integer = DBUtils.ifNULLCero(Cuenta.Item("sucursal")),
                cbu As String = DBUtils.ifNULLEmpty(Cuenta.Item("cbu"))

            c = New Cuenta
            ban = New Banco
            'c.id_titular = id_titular
            ban.id = nro_banco
            ban.nombre = nom_banco
            c.Banco = ban
            c.NroCuenta = nro_cuenta
            c.Sucursal = sucursal
            c.CBU = cbu
            t.cuentas.Add(c)
        Next
        Return t
    End Function

    Public Shared Function addCuenta(id_titular As Integer, nro_banco As Integer, sucursarl As Integer, nro_cuenta As String, cbu As String) As Boolean
        Dim c As String
        If cbu = -1 Then
            c = "@null"
        Else
            c = cbu
        End If
        Dim q As New QB.QueryBuilder
        q.table("Cuentas").insert({{"id_titular", id_titular},
                                  {"nro_banco", nro_banco},
                                  {"nro_cuenta", nro_cuenta},
                                  {"cbu", c},
                                  {"sucursal", sucursarl}})

        Return DBConn.executeOnlySQL(q.build)
    End Function
    Public Shared Function deleteCuenta(nro_cuenta As String, nro_banco As String) As Boolean
        Dim q As New QueryBuilder
        q.table("Cuentas").update({{"deleted_at", "@GETDATE()"}}) _
            .where("@nro_cuenta", nro_cuenta) _
            .where("@nro_banco", nro_banco)

        Return DBConn.executeOnlySQL(q.build)
    End Function

    Public Shared Function getTitulareDeBanco(id_banco As Integer) As List(Of Titular)
        Dim sconsulta As New QueryBuilder
        sconsulta.table("Cuentas").seleccionar({"id_titular"}).where("@nro_banco", id_banco)
        Dim q As New QueryBuilder
        q.table("Titulares").seleccionar.where("@id_titular", "in", "@(" + sconsulta.build + ")")
        Dim table As DataTable = DBConn.executeSQL(q.build)
        Dim lista As New List(Of Titular)
        Dim t As Titular
        For Each row As DataRow In table.Rows
            t = fromRowToTitular(row, id_banco)
            lista.Add(t)
        Next
        Return lista
    End Function

End Class
