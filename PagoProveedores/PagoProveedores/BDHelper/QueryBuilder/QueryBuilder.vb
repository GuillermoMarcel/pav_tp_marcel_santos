Namespace QB

    Public Class QueryBuilder
        Private op As Operacion
        Private t As String
        Private all As String() = {"*"}

        ''' <summary>
        ''' Metodo necesario para setear la tabla a usar.
        ''' </summary>
        ''' <param name="t">Tabla Simple! para varias tabla usar Where metodo</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function table(t As String) As QueryBuilder
            Me.t = t
            If op IsNot Nothing Then op.setTable(t)
            Return Me
        End Function

        ''' <summary>
        ''' Definir una seleccion
        ''' </summary>
        ''' <param name="items">Array con los items de la tabla principal necesarios. SOLO TABLA PRINCIPAL. Default all</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function seleccionar(Optional items As String() = Nothing) As QueryBuilder
            If items Is Nothing Then items = all
            If op Is Nothing Then op = New SelectOperation().setTable(t)

            op.setFields(items)
            Return Me
        End Function
        ''' <summary>
        ''' Definir una insercion simple o multiple.
        ''' </summary>
        ''' <param name="values">Doble array con los campos a insertar y sus valores. No acepta campo especial @</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function insert(values As String(,)) As QueryBuilder
            If op Is Nothing Then op = New InsertOperation().setTable(t)
            op.values(values)
            Return Me
        End Function
        ''' <summary>
        ''' Definir una actualizacion.
        ''' </summary>
        ''' <param name="values">Doble array con los campos a modificar y sus valores. Acepta campo especial @</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function update(values As String(,)) As QueryBuilder
            If op Is Nothing Then op = New UpdateOperation().setTable(Me.t)
            op.values(values)
            Return Me
        End Function
        ''' <summary>
        ''' Define una actualizacion con un unico valor a modificar.
        ''' </summary>
        ''' <param name="singleKeyValue">Array de 2 con el campo a modificar y sus valores.</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function update(singleKeyValue As String()) As QueryBuilder
            Return Me.update({{singleKeyValue(0), singleKeyValue(1)}})
        End Function

        ''' <summary>
        ''' Union comun entre la tabla original y otra
        ''' </summary>
        ''' <param name="table">Tabla a unir</param>
        ''' <param name="onA">Campo de union en la tabla original</param>
        ''' <param name="onB">Campo de union en la tabla de union</param>
        ''' <param name="items">Items seleccionados de la tabla de union</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function join(table As String, onA As String, onB As String, Optional items As String() = Nothing) As TableSelected
            fjoin(table, onA, onB, items, JoinSelected.JoinType.Neutral)
            Return op.join(table, items, onA, onB)
        End Function
        ''' <summary>
        ''' Union natural entre 
        ''' </summary>
        ''' <param name="table"></param>
        ''' <param name="common"></param>
        ''' <param name="items"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function join(table As String, common As String, Optional items As String() = Nothing) As TableSelected
            Return fjoin(table, common, common, items, JoinSelected.JoinType.Neutral)
        End Function
        Public Function leftJoin(table As String, onA As String, onB As String, Optional items As String() = Nothing) As TableSelected
            Return fjoin(table, onA, onB, items, JoinSelected.JoinType.Left)
        End Function
        Public Function Leftjoin(table As String, common As String, Optional items As String() = Nothing) As TableSelected
            Return fjoin(table, common, common, items, JoinSelected.JoinType.Left)
        End Function
        Private Function fjoin(table As String, a As String, b As String, items As String(), t As JoinSelected.JoinType) As TableSelected
            If items Is Nothing Then items = all
            Return op.join(table, items, a, b, t)
        End Function

        ''' <summary>
        ''' Ingresa una clausula where de igualdad
        ''' </summary>
        ''' <param name="field">campo</param>
        ''' <param name="value">valor</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function where(field As String, value As String) As QueryBuilder
            Me.op.where(New WhereClausule(field, value))
            Return Me
        End Function
        ''' <summary>
        ''' Agrega una clausula where con el campo, la operacion y el valor.
        ''' </summary>
        ''' <param name="field">campo</param>
        ''' <param name="op">operacion</param>
        ''' <param name="value">valor</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function where(field As String, op As String, value As String) As QueryBuilder
            Dim w As New WhereClausule(field, value) With {.op = op}
            Me.op.where(w)
            Return Me
        End Function
        ''' <summary>
        ''' Ingresa un arreglo de pares campos, valores.
        ''' </summary>
        ''' <param name="keyvalues"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function values(keyvalues As String(,)) As QueryBuilder
            op.values(keyvalues)
            Return Me
        End Function
        ''' <summary>
        ''' Inserta un unico par de campo, valor
        ''' </summary>
        ''' <param name="singleKeyValue"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function values(singleKeyValue As String()) As QueryBuilder
            Return Me.values({{singleKeyValue(0), singleKeyValue(1)}})
        End Function

        ''' <summary>
        ''' Contruye el codigo SQL correspondinete
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function build() As String
            Return op.build
        End Function

        ''' <summary>
        ''' Limpia el QueryBuilder para poder volver a utilizarlo.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function clear() As QueryBuilder
            Me.op = Nothing
            Return Me
        End Function





    End Class

End Namespace


