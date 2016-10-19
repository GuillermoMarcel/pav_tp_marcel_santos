Imports System.Data.SqlClient
Public Class DBHTitular

    Public Shared Function getTitulares() As DataTable
        Dim p As New QB.QueryBuilder
        p.table("Titulares").seleccionar()
        Return DBConn.executeSQL(p.build)
    End Function

    Public Shared Function getMaxID() As Integer
        Dim str As String
        Dim table As DataTable
        Dim id As Integer
        str = "select MAX(id_titular) FROM Titulares"

        table = DBConn.executeSQL(str)

        For Each row In table.Rows
            id = Convert.ToInt32((row.item(0).ToString))
        Next
        Return id
    End Function

    Public Shared Function addTitular(nombre As String, apellido As String, cuit As Long, calle As String, altura As Integer) As Boolean
        Dim q As New QB.QueryBuilder
        q.table("Titulares").insert({
                                    {"nombre", nombre},
                                    {"apellido", apellido},
                                    {"cuit", cuit},
                                    {"calle", calle},
                                    {"altura", altura}
                                })
        Return DBConn.executeOnlySQL(q.build)
    End Function

    Public Shared Function getCuentas(id_titular As Integer)
        Dim q As New QB.QueryBuilder
        q.table("Cuentas").seleccionar({"nro_cuenta", "cbu"}).join("Bancos", "nro_banco", {"nombre"}).where("@id_titular", id_titular)
        Return DBConn.executeSQL(q.build)
    End Function

    Public Shared Function getTitular(id_titular As Integer) As Titular
        Dim t As Titular
        Dim c As Cuenta

        Dim q As New QB.QueryBuilder
        q.table("Titular").seleccionar.where("id_titular", id_titular)
        Dim b As DataTable = DBConn.executeSQL(q.build)

        Dim apellido As String = b.Rows(0).Item("apellido"),
            nombre As String = DBUtils.ifNULLEmpty(b.Rows(0).Item("nombre")),
            cuit As Long = DBUtils.ifNULLCero(b.Rows(0).Item("nombre")),
            calle As String = DBUtils.ifNULLEmpty(b.Rows(0).Item("calle")),
            altura As Integer = DBUtils.ifNULLCero(b.Rows(0).Item("altura"))

        t.apellido = apellido
        t.nombre = nombre
        t.cuit = cuit
        t.calle = calle
        t.altura = altura

        q = New QB.QueryBuilder
        q.table("Cuenta").seleccionar.where("id_titular", id_titular)

        b = New DataTable
        b = DBConn.executeSQL(q.build)

        For Each Cuenta As DataRow In b.Rows

            Dim nro_cuenta As Integer = Cuenta.Item("nro_cuenta"),
                nro_banco As Integer = DBUtils.ifNULLCero(Cuenta.Item("nro_banco")),
                sucursal As Long = DBUtils.ifNULLCero(Cuenta.Item("sucursal")),
                cbu As String = DBUtils.ifNULLCero(Cuenta.Item("cbu"))

            c = New Cuenta

            c.id_titular = id_titular
            c.nro_banco = nro_banco
            c.nro_cuenta = nro_cuenta
            c.sucursal = sucursal
            c.cbu = cbu
            t.cuentas.Add(c)


        Next
        Return t

    End Function

    Public Shared Function addCuenta(id_titular As Integer, nro_banco As Integer, sucursarl As Integer, nro_cuenta As Long, cbu As Long) As Boolean
        Dim q As New QB.QueryBuilder
        q.table("Cuentas").insert({{"id_titular", id_titular},
                                  {"nro_banco", nro_banco},
                                  {"nro_cuenta", nro_cuenta},
                                  {"cbu", cbu},
                                  {"sucursal", sucursarl}})

        Return DBConn.executeOnlySQL(q.build)
    End Function

End Class
