Imports PagoProveedores.QB
Public Class DBHBanco
    Public Shared Function getBancos() As DataTable
        Dim q As New QB.QueryBuilder
        Dim campos As String() = {"nro_banco", "nombre"}
        q.table("Bancos").seleccionar(campos)
        Return DBConn.executeSQL(q.build)
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
