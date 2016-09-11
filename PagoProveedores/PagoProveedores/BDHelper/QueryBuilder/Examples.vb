Imports PagoProveedores.QB
Public Class Examples
    Public Shared Function main()

        'Se llama la constructor sin singun atributo
        Dim q As New QB.QueryBuilder

        Try
            'La mayoria de las acciones se pueden encadenar.

            q = ejemplos_con_select(q)

            q = ejemplos_con_join(q)

            q = ejemplos_con_update(q)

            q = ejemplos_con_insert(q)


            ' -- Para obtener el query a ejecutar llamar al metodo build() del QueryBuilder
            Dim sqlFinal As String = q.build
            Return sqlFinal

        Catch ex As NoTableSettedException
            'No Se selecciono ninguna tabla antes de hacer el build
            Return ex.Message
        Catch ex As NoValueSettedException
            'Intentamos ejecutar un Insert o Update sin asignar valores
            Return ex.Message
        Catch ex As DomainNotMatchException
            'No deberia aparece nunca. Si aparece es porque hay problemas con el dominio entre inserciones multiples
            Return ex.Message
        Catch ex As QB.QueryBuilderException
            'Interceptamos cualquier tipo de excepcion del QueryBuilder
            Return ex.Message
        End Try
    End Function

    Public Shared Function ejemplos_con_select(q As QB.QueryBuilder) As QB.QueryBuilder
        'Todos los elementos de la tabla Alumnos
        q.table("Alumnos").seleccionar()

        'Nombre y apellido de la tabla alumnos
        q.table("Alumnos").seleccionar({"Nombres", "Apellido"})

        'cambiar el nombre del atributo nombres por Primer Nombre
        q.table("Alumnos").seleccionar({"Nombres [Primer Nombre]", "Apellido"})

        'Alumno con dni 37888888
        q.table("Alumnos").seleccionar().where("@nro_documento", 37821733)

        ' -- Usamos el caracter @ para evitar que se tome como un texto. De esta forma toma el valor como el campo y no texto.
        ' -- El al usar el caracter @ asumimos que es un campo y se le agrega el nombre de la tabla antes.

        'Alumnos con mas de 2 hijos
        q.table("Alumnos").seleccionar().where("@cant_hijos", ">", 2)

        'Personas con mas gastos que ingresos [ingresos y gastos son campos de personas]
        q.table("Alumnos").seleccionar().where("@gastos", ">", "@ingresos")

        'Personas con Ingreso 10% mayor o mas que los gastos
        q.table("Alumnos").seleccionar().where("@ingresos", ">", "@gastos * 1.1")

        'Personas cuyo nombre terminen con BERTO
        q.table("Alumnos").seleccionar().where("@Nombres", "like", "%berto")


        'Personas cuyos gastos sean inferior a 5000 e ingresos mayores a 10000
        q.table("Alumnos").seleccionar().
            where("@gastos", "<", 5000).
            where("@ingresos", ">", 10000)

        'Si la clausula incluye elementos de otra tabla deben ser incluidos el el objeto devuelto por el metodo join.
        ' Ejemplos a continuacion.

        Return q
    End Function

    Public Shared Function ejemplos_con_join(q As QB.QueryBuilder) As QB.QueryBuilder
        'NO ANIDAR DESPUES DE HACER UN JOIN, PUEDE MAL ENTENDERSE.

        'Todos los elementos de la tabla Alumnos con los de la tabla carrera unidos por el elemento id_carrera en ambas
        q.table("Alumnos").seleccionar().join("carrera", "id_carrera")

        'Idem pero con la Foraign Key distinta de la Primary key [ FK; id_carrera (En alumno), PK: id (En carrera)]
        q.table("Alumnos").seleccionar().
            join("carrera", "id_carrera", "id")

        'Idem pero con los datos del alumno y solo el nombre de la carrera y su descripcion
        q.table("Alumno").seleccionar.
            join("carrera", "id_carrera", {"nombre_carrera", "desc"})

        'Solo los datos de la carrera
        q.table("Alumnos").seleccionar({}).join("carrera", "id_carrera")
        'El array vacio {} indica que no se quieren items de esa tabla.

        'TODOS los alumnos aunque no tengan carrera asignada [LEFT JOIN]
        q.table("Alumnos").seleccionar().leftJoin("carrera", "id_carrera")


        '-- Para valuar una clausula de WHERE con elementos de la tabla join tienen que hacerse inmediatamete despues del join
        '-- ya que este debuelve otro objeto 
        '-- el where se puede anidar con el correspondiente join

        'Obtener solo los alumnos de la carrera de Medicina
        Dim tablaCarrera As TableSelected = q.table("Alumnos").seleccionar().join("carrera", "id_carrera")
        tablaCarrera.where("@n_carrera", "Medicina")

        'Obtener todos los alumnos de Medicina cuyos ingresos sean mayores a 5000
        q.table("Alumnos").seleccionar().
            where("@ingresos", ">", 5000).
            join("carreras", "id_carreras").
            where("@n_carrera", "Medicina")

        ' __________________________________________________________
        '|                                                          |
        '|               Union de tablas consecutivas               |
        '|__________________________________________________________|
        '| Para unir una tabla con otra y esa con otra              |
        '| Ej: Alumnos -> carreras -> tipo_carrera                  |
        '|                                                          |
        '| Se tiene que hacer el join con el objeto que se obtiene  |
        '| del join entre la tabla principal y el primer join.      |
        '| Todo join hecho sobre el Query Principal se intentara    |
        '| hacer sobre la tabla principal.                          |
        '| Ej: Alumnos -> Carrera  ^    Alumnos -> tipo_documentos  |
        '|__________________________________________________________|

        'Unir la tabla Alumnos con la de carrera y la de tipo_documento
        '   Alumnos -> Carrera y Alumnos -> tipo_documento
        q.table("Alumnos").seleccionar()
        q.join("carreras", "id_carrera")
        q.join("tipo_documento", "id_tipo_documento")
        'Notese que ambos joins se hacen sobre el Query Principal

        'Unir la tabla Alumnos con carrera y esta con tipo_carrera
        '   Alumnos -> Carrera -> tipo_carrera
        q.table("Alumnos").seleccionar().join("carrera", "id_carrera").join("tipo_carrera", Nothing, "id_tipo_carrera")
        'Notese que el metodo del segundo join no es el mismo que el primero.
        'Para hacer un segundo left join, o selecionar los items
        q.table("Alumnos").seleccionar().join("carrera", "id_carrera").join("tipo_carrera", {"nombre_tipo", "descripcion"}, "id_tipo_carrera", type:=JoinSelected.JoinType.Left)

        'Sobre eso se puede hacer un WHERE para esae join


        Return q
    End Function

    Public Shared Function ejemplos_con_update(q As QB.QueryBuilder) As QB.QueryBuilder
        ' __________________________________________________________
        '|                                                          |
        '|               Actualizacion de datos                     |
        '|__________________________________________________________|
        '| Para hacer una actualizacion se selecciona primero la    |
        '| tabla igual que antes. y luego de a pares los campos a   |
        '| modificar junto con su valor en forma de dobles array    |
        '|                                                          |
        '| Ese update tambien cumple con la regla del caracter      |
        '| especial @ para uso de campos. Unicamente en el valor.   |
        '|                                                          |
        '| De igual manera que antes se puede hacer WHERE para      |
        '| modificar valores seleccionados.                         |
        '|__________________________________________________________|

        'Actuaizar todos los Pagos Obligatorios a 0
        q.table("Clientes").update({"pagos_obligatorios", 0})
        'Notese que si es un solo valor se puede hacer con un array simple

        'Actualizar todos los pagos obligatorios a 0 y costos a 500
        q.table("Clientes").update({
                                   {"pagos_obligatorios", 0},
                                   {"costos", 500}
                               })

        'Actualizar los costos un 15%
        q.table("Producto").update({"costos", "@costos * 1.15"})

        'Aumentar la comicion de las empleadas mujeres
        q.table("Empleados").update({"comicion", "@comicion * 1.10"}).where("sexo", "m")

        'Cambiar el nombre, apellido, nombre de la calle y numero de la calle del alumno con dni 555555
        q.table("Alumnos").update({
                                  {"Nombres", "Ramon"},
                                  {"Apellidos", "Diaz"},
                                  {"calle", "Humberto Primo"},
                                  {"nro_calle", 522}
                              }).where("nro_documento", 5555555)

        'Tira excepcion si intentas hacer join


        Return q
    End Function

    Public Shared Function ejemplos_con_insert(q As QB.QueryBuilder) As QB.QueryBuilder
        ' __________________________________________________________
        '|                                                          |
        '|                   Inercion de datos                      | 
        '|__________________________________________________________|
        '| La insercion de datos es muy similar a la actualizacion  |
        '| sin contar que es la mas facil.                          |
        '| Igual que en la actualizacion. los datos se pasan con    |
        '| arrays dobles con el campo y el valor.                   |
        '| Este metodo no acepta joins ni where.                    |
        '| Se puede usar @null para insertar un valor nulo          |
        '| de igual manera que Nothing                              |
        '|                                                          |
        '| Se pueden hacer inserciones multiples en el mismo        |
        '| Query Builder                                            |
        '|__________________________________________________________|

        'Insertar un nuevo alumno
        q.table("Alumno").insert({
                                 {"Nombres", "Juan Luis"},
                                 {"Apellido", "Ramirez"},
                                 {"id_tipo_documento", 1},
                                 {"sexo", "h"},
                                 {"calle", "@null"},
                                 {"actividad", Nothing}
                             })

        'Insertar Varios alumnos a la vez. Simplemente llamando al insert de vuelta antes del build.
        q.table("Alumno").insert({
                                 {"Nombres", "Juan Luis"},
                                 {"Apellido", "Ramirez"},
                                 {"id_tipo_documento", 1},
                                 {"sexo", "h"},
                                 {"calle", "@null"},
                                 {"actividad", Nothing}
                             })
        q.insert({
                 {"Nombres", "Juan Luis"},
                 {"Apellido", "Ramirez"},
                 {"id_tipo_documento", 1},
                 {"sexo", "h"},
                 {"calle", "@null"},
                 {"actividad", Nothing}
             })
        q.build()

        Return q
    End Function



End Class


