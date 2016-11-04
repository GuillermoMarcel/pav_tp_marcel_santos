Imports PagoProveedores.QB
Public Class DBHBanco
    Public Shared Function getBancos(Optional id_banco As Integer = -1) As DataTable
        Dim q As New QB.QueryBuilder
        Dim campos As String() = {"nro_banco", "nombre"}

            q.table("Bancos").seleccionar(campos)
            Return DBConn.executeSQL(q.build)
    End Function

    Public Shared Function getBanco(id_banco As Integer) As Banco
        Dim q As New QB.QueryBuilder
        Dim campos As String() = {"nro_banco", "nombre"}

        q.table("Bancos").seleccionar(campos).where("nro_banco", id_banco)

        Dim bancoTable As DataTable = DBConn.executeSQL(q.build)
        If bancoTable.Rows.Count = 0 Then Throw New Exception("No se encontro Banco")

        Dim banco As New Banco With {
            .id = bancoTable.Rows.Item(0).Item(0).value,
            .nombre = bancoTable.Rows.Item(0).Item(1).value}

        Return banco
    End Function

    Public Shared Function insertarBanco(nro As Integer, nom As String) As Boolean
        Dim q As New QB.QueryBuilder
        q.table("Bancos").insert({{"nro_banco", nro},
                                 {"nombre", nom}
                                })
        Return DBConn.executeOnlySQL(q.build)
    End Function

    Public Shared Function borrarBanco(id As Integer) As Boolean
        Dim q As New QB.QueryBuilder
        q.table("Bancos").update({"deleted_at", "@getDate()"}).where("@nro_banco", id)
        Return DBConn.executeOnlySQL(q.build)
    End Function
    Public Shared Function modificarBanco(curid As Integer, id As Integer, nombre As String) As Boolean
        Dim q As New QB.QueryBuilder
        q.table("Bancos").update({
                                 {"nro_banco", id},
                                 {"nombre", nombre}
                             }).where("@nro_banco", curid)
        Return DBConn.executeOnlySQL(q.build)
    End Function
End Class
