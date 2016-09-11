Namespace QB
    Public Class WhereClausule
        Public field, value As String
        Public op As String
        Public Sub New(field As String, value As String)
            Me.field = field
            Me.value = value
            op = "="
        End Sub
        Public Sub New(field As String, op As String, value As String)
            Me.field = field
            Me.value = value
            Me.op = op
        End Sub

        Public Function build() As String
            Return Escaper.escapeAndClose(field) & " " & op & " " & Escaper.escapeAndClose(value)
        End Function

    End Class
End Namespace
