Module _2_05
    Enum meses As Byte

        Enero = 1
        Febrero = 2
        Marzo = 3
        Abril = 4
        Mayo = 5
        Junio = 6
        Julio = 7
        Agosto = 8
        Septiembre = 9
        Octubre = 10
        Noviembre = 11
        Diciembre = 12
    End Enum
    Sub main()

        Console.Write("Ingrese un valor: ")
        mes = Console.ReadLine

        Select Case mes
            Case meses.Enero
                Console.Write("El mes del año correspondiente es Enero")
            Case meses.Febrero
                Console.Write("El mes del año correspondiente es Febrero")
            Case meses.Marzo
                Console.Write("El mes del año correspondiente es Marzo")
            Case meses.Abril
                Console.Write("El mes del año correspondiente es Abril")
            Case meses.Mayo
                Console.Write("El mes del año correspondiente es Mayo")
            Case meses.Junio
                Console.Write("El mes del año correspondiente es Junio ")
            Case meses.Julio
                Console.Write("El mes del año correspondiente es Julio ")
            Case meses.Agosto
                Console.Write("El mes del año correspondiente es Agosto ")
            Case meses.Septiembre
                Console.Write("El mes del año correspondiente es Septiembre ")
            Case meses.Octubre
                Console.Write("El mes del año correspondiente es Octubre ")
            Case meses.Noviembre
                Console.Write("El mes del año correspondiente es Noviembre ")
            Case meses.Diciembre
                Console.Write("El mes del año correspondiente es Diciembre ")
        End Select
        Console.ReadKey()
    End Sub
End Module
