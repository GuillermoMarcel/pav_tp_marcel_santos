Namespace QB
    Public Class InsertOperation
        Implements Operacion
        Private table As String
        Private dominio As List(Of String)
        Private ins As List(Of String())

        Public Sub New()
            ins = New List(Of String())
        End Sub


        Public Function build() As String Implements Operacion.build
            If table = String.Empty Then Throw New NoTableSettedException
            Dim final = "INSERT INTO alumnos (id, nombre, carrera, dni) VALUES (2, 'Guille', 1, 37821733)"
            build = "INSERT INTO " & table & "("

            Dim first As Boolean = True

            For Each d As String In dominio
                If Not first Then build &= ", "
                build &= d
                first = False
            Next
            build &= ") VALUES"

            first = True
            For Each vvs As String() In ins
                If Not first Then build &= ","
                build &= " ("

                Dim secondfirst As Boolean = True
                For Each v As String In vvs
                    If Not secondfirst Then build &= ", "
                    build &= Escaper.escapeAndClose(v)
                    secondfirst = False
                Next

                build &= ")"
                first = False
            Next


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

        Public Function where(clausula As WhereClausule) As Operacion Implements Operacion.where
            Throw New InvalidMethodException
        End Function

        Public Function values(keyvalues(,) As String) As Operacion Implements Operacion.values
            arreglarDominio(keyvalues)
            agregarInsert(keyvalues)
            Return Me
        End Function

        Private Sub arreglarDominio(v(,) As String)
            If dominio Is Nothing Then
                dominio = New List(Of String)

                Dim insert(v.GetUpperBound(0)) As String
                For i = 0 To v.GetUpperBound(0)
                    'insert(i) = v(i, 1)
                    dominio.Add(v(i, 0))
                Next
                'Me.ins.Add(insert)
            Else
                'Agrega los valores del dominio faltantes

                'Verificador para saber si hay que redimencionar ins actuales
                Dim thereAreNewOnes As Boolean = False
                For i = 0 To v.GetUpperBound(0)
                    If Not dominio.Contains(v(i, 0)) Then
                        dominio.Add(v(i, 0))
                        thereAreNewOnes = True
                    End If
                Next

                If thereAreNewOnes Then redimActuales()

            End If

        End Sub

        ''' <summary>
        ''' Actualiza el tamaño de los insers actuales segun el nuevo dominio
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub redimActuales()
            For i = 0 To ins.Count - 1
                Dim c As String() = ins(i)
                ReDim Preserve c(dominio.Count - 1)
                ins(i) = c
            Next
        End Sub

        ''' <summary>
        ''' Ajusta la insercion actual al dominio existente.
        ''' Si se ejecuto arreglar dominio, este deveria incluir al de esta insercion.
        ''' </summary>
        ''' <param name="v"></param>
        ''' <remarks></remarks>
        Private Sub agregarInsert(v(,) As String)
            Dim insert(dominio.Count - 1) As String
            Dim actual As Integer = 0
            For Each dom As String In dominio
                For i = 0 To v.GetUpperBound(0)
                    If v(i, 0) = dom Then
                        insert(actual) = v(i, 1)

                        Exit For
                    End If
                Next
                actual += 1
            Next
            ins.Add(insert)
        End Sub
    End Class
End Namespace
