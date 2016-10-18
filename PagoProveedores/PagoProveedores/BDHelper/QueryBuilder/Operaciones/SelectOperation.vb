Namespace QB
    Public Class SelectOperation
        Implements Operacion
        Private prim As TableSelected
        Private joins As List(Of JoinSelected)
        Sub New()
            joins = New List(Of JoinSelected)
        End Sub

        Public Function setFields(s As String()) As Operacion Implements Operacion.setFields
            prim.items = s
            Return Me
        End Function

        Public Function setTable(s As String) As Operacion Implements Operacion.setTable
            prim = New TableSelected
            prim.name = s
            Dim w As New WhereClausule("@" + prim.name + ".deleted_at", "@NULL")
            w.op = "Is"
            prim.whereClausules.Add(w)

            Return Me
        End Function

        Public Function build() As String Implements Operacion.build


            Dim sql As String = "SELECT "
            Dim first As Boolean = True

            For Each item As String In Me.getItems
                If Not first Then sql += ", "
                'sql += Escaper.escapeAddTable(i, prim.name) 'prim.name & "." & i
                sql &= item
                first = False
            Next

            'For Each i As String In prim.items

            'Next
            'For Each t As TableSelected In joins
            '    If t.items.Length = 0 Then Continue For
            '    If Not first Then sql += ", "
            '    first = True
            '    For Each i As String In t.items
            '        If Not first Then sql += ", "
            '        sql += Escaper.escapeAddTable(i, t.name) 't.name & "." & i
            '        first = False
            '    Next
            'Next

            sql += " FROM " & prim.name


            For Each t As JoinSelected In joins
                sql &= " " & t.build()
            Next

            If hasWhere() Then
                sql &= " WHERE "

                first = True
                For Each w As WhereClausule In prim.whereClausules
                    If Not first Then sql += " AND "
                    sql &= w.build()
                    first = False
                Next
                For Each j As TableSelected In joins
                    For Each w As WhereClausule In j.whereClausules
                        If Not first Then sql += " AND "
                        sql &= w.build()
                        first = False
                    Next
                Next
            End If



            Return sql

        End Function
        Public Function getItems() As List(Of String) Implements Joinable.getItems
            Dim l As List(Of String) = prim.getItems
            For Each j As Joinable In joins
                l.AddRange(j.getItems)
            Next
            Return l
        End Function

        Private Function hasWhere() As Boolean
            hasWhere = False
            If prim.whereClausules.Count > 0 Then hasWhere = True
            For Each i As JoinSelected In joins
                If i.whereClausules.Count > 0 Then hasWhere = True
            Next
        End Function

        Public Function where(clausula As WhereClausule) As Operacion Implements Operacion.where
            prim.whereClausules.Add(clausula)
            Return Me
        End Function

        Public Function join(table As String, items As String(), onA As String, Optional onB As String = Nothing, Optional type As JoinSelected.JoinType = JoinSelected.JoinType.Neutral) As TableSelected Implements Operacion.join
            If onB Is Nothing Then onB = onA
            Dim i As New JoinSelected(type)
            i.name = table
            i.items = items
            i.onA = onA
            i.onB = onB
            i.joiningTable = prim.name
            joins.Add(i)

            Return i
        End Function


        Public Function values(keyvalues(,) As String) As Operacion Implements Operacion.values
            Throw New InvalidMethodException
        End Function
    End Class


End Namespace

