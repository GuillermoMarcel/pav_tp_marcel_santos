Public Class DBHCheque
    Public Shared Function addCheque(nro_cheque As Integer,
                                     monto As Decimal,
                                     fecha_emision As Date,
                                     fecna_vencimiento As Date,
                                     cruzado As Boolean,
                                     observacion As String,
                                      cuenta As Cuenta)
        Dim q As New QB.QueryBuilder
        'Insert de cheque en estado "Disponible" que tiene id 1
        q.table("Cheques").insert({
                                  {"nro_cheque", nro_cheque},
                                  {"monto", monto},
                                  {"nro_cuenta", cuenta.NroCuenta},
                                  {"nro_banco", cuenta.Banco.id},
                                  {"fecha_emision", fecha_emision},
                                  {"fecha_vencimiento", fecna_vencimiento},
                                  {"cruzado", DBUtils.BooleanToDB(cruzado)},
                                  {"observacion", observacion},
                                  {"id_estado", 1}
                              })

        Return DBConn.executeOnlySQL(q.build)
    End Function

End Class
