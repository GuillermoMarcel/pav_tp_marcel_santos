Namespace QB
    Public Class UpdateOperation
        Implements Operacion
        Private table As String
        Private updates As String(,)
        Private whereclaus As List(Of WhereClausule)
        Sub New()
            whereclaus = New List(Of WhereClausule)

        End Sub
        Public Function build() As String Implements Operacion.build
            'UPDATE alumnos SET nro_calle = nro_calle + 100, Nombres = 'gilberto' WHERE sexo = 'm'
            If updates Is Nothing Then Throw New NoValueSettedException
            If table Is Nothing Then Throw New NoTableSettedException
            build = "UPDATE " & table & " SET "


            For i = 0 To updates.GetUpperBound(0)
                If i <> 0 Then build &= ", "
                build &= Escaper.escape(updates(i, 0)) & " = " & Escaper.escapeAndClose(updates(i, 1))
            Next

            If Not hasWhere() Then Exit Function

            build &= " WHERE "

            For i = 0 To whereclaus.Count - 1
                If i <> 0 Then build &= ", "
                build &= whereclaus(i).build()
            Next

        End Function

        Private Function hasWhere() As Boolean
            Return whereclaus.Count > 0
        End Function

        Public Function join(table As String, items() As String, onA As String, Optional onB As String = Nothing, Optional type As JoinSelected.JoinType = JoinSelected.JoinType.Neutral) As TableSelected Implements Operacion.join
            Throw New InvalidMethodException
        End Function
        Public Function getItems() As List(Of String) Implements Joinable.getItems
            Throw New InvalidMethodException
        End Function

        Public Function setFields(s() As String) As Operacion Implements Operacion.setFields
            Throw New InvalidMethodException
        End Function

        Public Function setTable(s As String) As Operacion Implements Operacion.setTable
            Me.table = s
            Return Me
        End Function

        Public Function values(keyvalues(,) As String) As Operacion Implements Operacion.values
            Me.updates = keyvalues
            Return Me
        End Function

        Public Function where(clausula As WhereClausule) As Operacion Implements Operacion.where
            Me.whereclaus.Add(clausula)
            Return Me
        End Function
    End Class
End Namespace
