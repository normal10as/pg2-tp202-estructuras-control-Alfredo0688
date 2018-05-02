Module _05
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
        Dim valor As meses
        Console.Write("Ingrese un valor: ")
        valor = Console.ReadLine

        Select Case valor
            Case 1
                Console.Write("El mes del año correspondiente es: " & valor.ToString)
            Case 2
                Console.Write("El mes del año correspondiente es: " & valor.ToString)
            Case 3
                Console.Write("El mes del año correspondiente es: " & valor.ToString)
            Case 4
                Console.Write("El mes del año correspondiente es: " & valor.ToString)
            Case 5
                Console.Write("El mes del año correspondiente es: " & valor.ToString)
            Case 6
                Console.Write("El mes del año correspondiente es: " & valor.ToString)
            Case 7
                Console.Write("El mes del año correspondiente es: " & valor.ToString)
            Case 8
                Console.Write("El mes del año correspondiente es: " & valor.ToString)
            Case 9
                Console.Write("El mes del año correspondiente es: " & valor.ToString)
            Case 10
                Console.Write("El mes del año correspondiente es: " & valor.ToString)
            Case 11
                Console.Write("El mes del año correspondiente es: " & valor.ToString)
            Case 12
                Console.Write("El mes del año correspondiente es: " & valor.ToString)
        End Select
        Console.ReadKey()
    End Sub
End Module
