Namespace QB
    Public Class QueryBuilderException
        Inherits Exception
        Sub New(m As String)
            MyBase.New(m)
        End Sub
    End Class
    Public Class InvalidMethodException
        Inherits QueryBuilderException
        Public Sub New()
            MyBase.New("Operacion no valida")
        End Sub
    End Class
    Public Class NoTableSettedException
        Inherits QueryBuilderException
        Sub New()
            MyBase.New("No se seteo ninguna tabla. Pruebe builder.table(@tablename)")
        End Sub
    End Class
    Public Class NoValueSettedException
        Inherits QueryBuilderException
        Sub New()
            MyBase.New("No se seteo ningun valor. Pruebe los metodos insert, o update")
        End Sub
    End Class
    Public Class DomainNotMatchException
        Inherits QueryBuilderException
        Sub New()
            MyBase.New("El nuevo dominio no coincide con el dominio ingresado anteriormente")
        End Sub
    End Class
End Namespace
