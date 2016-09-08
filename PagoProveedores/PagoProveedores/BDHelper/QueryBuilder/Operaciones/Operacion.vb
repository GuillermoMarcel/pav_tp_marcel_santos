Namespace QueryBuilder
    Public Interface Operacion
        Inherits Joinable
        
        Function setTable(s As String) As Operacion
        Function setFields(s As String()) As Operacion
        Function where(clausula As WhereClausule) As Operacion
        Function values(keyvalues As String(,)) As Operacion

        Function build() As String
    End Interface

    Public Interface Joinable
        Function join(table As String, items As String(), onA As String, Optional onB As String = Nothing, Optional type As JoinSelected.JoinType = JoinSelected.JoinType.Neutral) As TableSelected
        Function getItems() As List(Of String)
    End Interface
End Namespace

