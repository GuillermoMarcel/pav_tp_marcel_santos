Namespace QB
    Public Class DeleteOperation
        Implements Operacion
        Private table As String
        Private whereclaus As List(Of WhereClausule)
        Public Sub New()
            whereclaus = New List(Of WhereClausule)
        End Sub


        Public Function getItems() As List(Of String) Implements Joinable.getItems
            Throw New NotImplementedException
        End Function

        Public Function join(table As String, items() As String, onA As String, Optional onB As String = Nothing, Optional type As JoinSelected.JoinType = JoinSelected.JoinType.Neutral) As TableSelected Implements Joinable.join
            Throw New NotImplementedException
        End Function

        Public Function build() As String Implements Operacion.build
            'delete from Pagos where id_pago = 100
            If table Is Nothing Then Throw New NoTableSettedException
            build = "DELETE FROM " & table


            If Not hasWhere() Then Exit Function

            build &= " WHERE "

            For i = 0 To whereclaus.Count - 1
                If i <> 0 Then build &= " AND "
                build &= whereclaus(i).build()
            Next

            Return build
        End Function

        Private Function hasWhere() As Boolean
            Return whereclaus.Count > 0
        End Function

        Public Function setFields(s() As String) As Operacion Implements Operacion.setFields
            Throw New NotImplementedException
        End Function

        Public Function setTable(s As String) As Operacion Implements Operacion.setTable
            Me.table = s
            Return Me
        End Function

        Public Function values(keyvalues(,) As String) As Operacion Implements Operacion.values
            Throw New NotImplementedException
        End Function
        Public Function orderBy(s As String()) As Operacion Implements Operacion.orderBy
            Throw New NotImplementedException
        End Function

        Public Function where(clausula As WhereClausule) As Operacion Implements Operacion.where
            whereclaus.Add(clausula)
            Return Me
        End Function

    End Class

End Namespace