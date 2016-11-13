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


    Public Shared Function addTitular(nombre As String, apellido As String, cuit As Long, calle As String, altura As Integer) As Titular
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

        Dim v As String = "Select @@IDENTITY"
        Dim tabla As DataTable = DBConn.executeTransactionQuery({q.build, v})
        Dim id As Integer = tabla.Rows(0).Item(0)
        Return getTitular(id)
    End Function

    Public Shared Function getCuentas(id_titular As Integer)
        Dim q As New QB.QueryBuilder
        q.table("Cuentas").seleccionar({"nro_cuenta", "cbu"}).join("Bancos", "nro_banco", {"nombre Banco"}).where("@id_titular", id_titular)
        Return DBConn.executeSQL(q.build)
    End Function

    Public Shared Function getCuentasFavoritas() As List(Of Cuenta)
        Dim q As New QueryBuilder
        q.table("Cuentas").seleccionar.join("Bancos", "nro_banco").where("@favorita", 1)
        'q.table("Cuentas").seleccionar()
        Dim t As DataTable = DBConn.executeSQL(q.build)
        Dim l As New List(Of Cuenta)
        For Each r As DataRow In t.Rows
            l.Add(fromRowToCuenta(r))
        Next
        Return l
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

        Dim b As DataTable = DBConn.executeSQL(q.build)

        For Each cuenta_row As DataRow In b.Rows
            t.cuentas.Add(fromRowToCuenta(cuenta_row))
        Next
        Return t
    End Function
    Private Shared Function fromRowToCuenta(r As DataRow) As Cuenta
        Dim nro_cuenta As String = r.Item("nro_cuenta"),
                nro_banco As Integer = r.Item("nro_banco"),
                nom_banco As String = r.Item("nombre"),
                sucursal As Integer = DBUtils.ifNULLCero(r.Item("sucursal")),
                cbu As String = DBUtils.ifNULLEmpty(r.Item("cbu"))

        Dim c As New Cuenta
        Dim ban As New Banco
        'c.id_titular = id_titular
        ban.id = nro_banco
        ban.nombre = nom_banco
        c.Banco = ban
        c.NroCuenta = nro_cuenta
        c.Sucursal = sucursal
        c.CBU = cbu
        Return c
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

    Shared Function deleteTitular(id As String) As Boolean
        Dim q As New QueryBuilder
        Dim comandos As New List(Of String)

        q.table("Cuentas").update({{"deleted_at", "@GETDATE()"}}).
            where("@id_titular", id).
            where("@deleted_at", " is ", "@null")
        comandos.Add(q.build)

        q.table("Titulares").update({{"deleted_at", "@GETDATE()"}}).where("@id_titular", id)
        comandos.Add(q.build)
        Return DBConn.executeTransaction(comandos.ToArray)
    End Function



End Class
