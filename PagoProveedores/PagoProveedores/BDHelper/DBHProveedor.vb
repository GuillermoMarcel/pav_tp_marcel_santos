Imports PagoProveedores.QB
Public Class DBHProveedor
    Public Shared Function getProveedores() As DataTable
        Dim p As New QB.QueryBuilder
        Dim campos As String() = {"id_proveedor", "razon_social", "cuit", "@(calle + ' ' + CONVERT(varchar(5), altura)) direccion", "altura", "observaciones"}
        p.table("Proveedores").seleccionar(campos)
        Return DBConn.executeSQL(p.build)
    End Function

    Public Shared Function addProveedor(razonSocial As String, cuit As Long, direccion As Direccion, observacion As String, telefonos As List(Of Telefono), mails As List(Of Mail)) As Boolean
        Dim p As New QueryBuilder

        Dim com As New List(Of String)
        Dim c As String = cuit.ToString
        If cuit = 0 Then c = "@null"

        p.table("Proveedores").insert({
                                      {"razon_social", razonSocial},
                                      {"cuit", c},
                                      {"calle", direccion.Calle},
                                      {"altura", direccion.Altura},
                                      {"observaciones", observacion}
                                  })

        com.Add(p.build)
        com.Add("DECLARE @ProvId INT = @@IDENTITY")


        For Each t As Telefono In telefonos
            p.clear.table("Proveedor_Telefonos").insert({
                                                  {"id_proveedor", "@@ProvId"},
                                                  {"telefono", t.Telefono},
                                                  {"observaciones", t.Observacion}
                                              })
            com.Add(p.build)
        Next
        For Each m As Mail In mails
            p.clear.table("Proveedor_Mails").insert({
                                                {"id_proveedor", "@@ProvId"},
                                                {"mail", m.Mail},
                                                {"observaciones", m.Observacion}
                                            })

            com.Add(p.build)
        Next

        Return DBConn.executeTransaction(com.ToArray)

    End Function

    Public Shared Function modificarProveedor(id As Integer) As Proveedor
        Dim q As New QueryBuilder
        q.table("Proveedores").seleccionar.where("@id_proveedor", id)
        Dim b As Data.DataTable = DBConn.executeSQL(q.build)

        Dim rs As String = b.Rows(0).Item("razon_social"),
            calle As String = DBUtils.ifNULLEmpty(b.Rows(0).Item("calle")),
            altura As Integer = DBUtils.ifNULLCero(b.Rows(0).Item("altura")),
            cuit As Long = b.Rows(0).Item("cuit"),
            observacion As String = DBUtils.ifNULLEmpty(b.Rows(0).Item("observaciones"))


        Dim mails As List(Of Mail) = getMailsProveedor(id)
        Dim telefonos As List(Of Telefono) = getTelefonosProveedor(id)


        Dim p As New Proveedor(id, telefonos, mails)
        p.RazonSocial = rs
        p.Cuit = cuit
        p.Observacion = observacion
        p.Direccion = New Direccion(calle, altura)

        Return p
    End Function

    Public Shared Function confirmarModificacionProveedor(id As String, razonSocial As String, cuit As Long, direccion As Direccion, observacion As String) As Boolean
        Dim q As New QueryBuilder
        q.table("Proveedores").update({
                                     {"razon_social", razonSocial},
                                     {"cuit", cuit},
                                     {"observaciones", observacion},
                                     {"calle", direccion.Calle},
                                     {"altura", direccion.Altura}
                                 }).
                         where("@id_proveedor", id)
        Dim com As String = q.build
        Return DBConn.executeOnlySQL(com)
    End Function

    Public Shared Function eliminarProveedor(id As String) As Boolean
        Dim q As New QueryBuilder
        q.table("Proveedores").update({
                                      {"deleted_at", "@getDate()"}
                                  }).
                          where("@id_proveedor", id)
        Return DBConn.executeOnlySQL(q.build)
    End Function

    'TELEFONOS Y MAILS

    Public Shared Function agregarMailProveedor(id As Integer, mail As String, texto As String) As List(Of Mail)
        Dim q As New QueryBuilder
        q.table("Proveedor_Mails").insert({
                                          {"id_proveedor", id},
                                          {"mail", mail},
                                          {"observaciones", texto}
                                      })
        DBConn.executeOnlySQL(q.build)
        Return getMailsProveedor(id)
    End Function

    Public Shared Function agregarTelefonoProveedor(id As Integer, numero As String, texto As String) As List(Of Telefono)
        Dim q As New QueryBuilder
        q.table("Proveedor_Telefonos").insert({
                                          {"id_proveedor", id},
                                          {"telefono", numero},
                                          {"observaciones", texto}
                                      })
        DBConn.executeOnlySQL(q.build)
        Return getTelefonosProveedor(id)

    End Function

    Public Shared Function getMailsProveedor(id As Integer) As List(Of Mail)
        Dim q As New QueryBuilder
        q.table("Proveedor_Mails").seleccionar.where("@id_proveedor", id)
        Dim b = DBConn.executeSQL(q.build)
        Dim mails As New List(Of Mail)
        For Each r As Data.DataRow In b.Rows
            Dim m As New Mail
            m.Mail = DBUtils.ifNULLEmpty(r.Item("mail"))
            m.Observacion = DBUtils.ifNULLEmpty(r.Item("observaciones"))
            mails.Add(m)
        Next
        Return mails
    End Function

    Private Shared Function getTelefonosProveedor(id As Integer) As List(Of Telefono)
        Dim q As New QB.QueryBuilder
        q.table("Proveedor_Telefonos").seleccionar.where("@id_proveedor", id)
        Dim b = DBConn.executeSQL(q.build)
        Dim telefonos As New List(Of Telefono)
        For Each r As Data.DataRow In b.Rows
            Dim t As New Telefono
            t.Telefono = DBUtils.ifNULLEmpty(r.Item("telefono"))
            t.Observacion = DBUtils.ifNULLEmpty(r.Item("observaciones"))
            telefonos.Add(t)
        Next
        Return telefonos
    End Function

    Public Shared Function modificarTelefonoProveedor(id As Integer, telefono As String, ntelefono As String, nobservacion As String) As List(Of Telefono)
        Dim q As New QueryBuilder
        q.table("Proveedor_Telefonos").update({
                                              {"telefono", ntelefono},
                                              {"observaciones", nobservacion}
                                          }).
        where("@id_proveedor", id).
        where("@telefono", telefono)

        Dim com As String = q.build
        DBConn.executeOnlySQL(com)
        Return getTelefonosProveedor(id)
    End Function

    Shared Function eliminarTelefonoProveedor(id As Integer, telefono As String) As List(Of Telefono)
        Dim q As New QueryBuilder
        'q.table("Proveedor_Telefonos").delete.where("@id_proveedor", id).where("@telefono", telefono)
        q.table("Proveedor_Telefonos").update({"deleted_at", "@getdate()"}).
            where("@id_proveedor", id).
            where("@telefono", telefono)
        Dim com As String = q.build
        DBConn.executeOnlySQL(com)
        Return getTelefonosProveedor(id)
    End Function

    Shared Function modificarMailProveedor(id As Integer, mail As String, nmail As String, nobservacion As String) As List(Of Mail)
        Dim q As New QueryBuilder
        q.table("Proveedor_Mails").update({
                                              {"mail", nmail},
                                              {"observaciones", nobservacion}
                                          }).
        where("@id_proveedor", id).
        where("@mail", mail)

        Dim com As String = q.build
        DBConn.executeOnlySQL(com)
        Return getMailsProveedor(id)
    End Function

    Shared Function eliminarMailProveedor(id As Integer, mail As String) As List(Of Mail)
        Dim q As New QueryBuilder
        'q.table("Proveedor_Telefonos").delete.where("@id_proveedor", id).where("@telefono", telefono)
        q.table("Proveedor_Mails").update({"deleted_at", "@getdate()"}).
            where("@id_proveedor", id).
            where("@mail", mail)
        Dim com As String = q.build
        DBConn.executeOnlySQL(com)
        Return getMailsProveedor(id)
    End Function

End Class
