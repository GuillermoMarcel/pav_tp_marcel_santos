Namespace QB
    Public Class TableSelected
        Implements Joinable

        Public name As String
        Public items As String()
        Public whereClausules As List(Of WhereClausule)

        Protected joins As List(Of JoinSelected)
        Public Sub New()
            whereClausules = New List(Of WhereClausule)
            joins = New List(Of JoinSelected)
        End Sub

        Public Sub where(field, value)
            whereClausules.Add(New WhereClausule(field, value))
        End Sub

        Public Function getItems() As List(Of String) Implements Joinable.getItems
            Dim l As New List(Of String)
            For Each it As String In items
                l.Add(Escaper.escapeAddTable(it, Me.name))
            Next
            For Each j As Joinable In joins
                l.AddRange(j.getItems)
            Next
            Return l
        End Function

        Public Function join(table As String, items() As String, onA As String, Optional onB As String = Nothing, Optional type As JoinSelected.JoinType = JoinSelected.JoinType.Neutral) As TableSelected Implements Joinable.join
            If onB Is Nothing Then onB = onA
            Dim i As New JoinSelected(type)
            i.name = table
            i.items = items
            i.onA = onA
            i.onB = onB
            i.joiningTable = table
            joins.Add(i)

            Return i
        End Function
    End Class

    Public Class JoinSelected
        Inherits TableSelected

        Public onA, onB As String
        Public joiningTable As String
        Private t As JoinType
        Public Sub New(type As JoinType)
            MyBase.New()
            Me.t = type
        End Sub


        Public Function build() As String
            build = ""
            Select Case Me.t
                Case JoinType.Cross
                    build = "asdf "
                Case JoinType.Left
                    build = "LEFT JOIN "
                Case JoinType.Right
                    build = "RIGHT JOIN "
                Case JoinType.Neutral
                    build = "JOIN "
            End Select
            build &= Me.name & " ON " & joiningTable & "." & onA & " = " & Me.name & "." & onB
            If joins.Count = 0 Then Exit Function

            For Each j As JoinSelected In MyBase.joins
                build &= " " & j.build
            Next
        End Function


        Public Enum JoinType
            Neutral
            Left
            Right
            Cross
        End Enum
    End Class
End Namespace
