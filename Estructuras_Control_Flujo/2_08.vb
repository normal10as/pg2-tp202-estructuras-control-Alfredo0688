Module _2_08
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

        Console.WriteLine("Ingrese un mes para saber cuantos dias tiene")
        Console.Write("Mes: ")
        Dim mes As meses = Console.ReadLine

        If mes = 1 Or mes = 3 Or mes = 5 Or mes = 7 Or mes = 8 Or mes = 10 Or mes = 12 Then
            Console.WriteLine("El mes tiene 31 dias")
        ElseIf mes = 4 Or mes = 6 Or mes = 9 Or mes = 11 Then
            Console.WriteLine("El mes tiene 30 días")
        ElseIf mes = 2 Then
            Console.WriteLine("Escogío febrero")
            Console.Write("Ingrese el año para saber si este es bisiesto: ")
            Dim anio As UShort = Console.ReadLine

            If anio Mod 400 = 0 Then
                Console.WriteLine("El año es bisiesto")
                Console.WriteLine("El mes tiene 29 días")
            Else
                Console.WriteLine("El año no es bisiesto")
                Console.WriteLine("El mes tiene 28 días")
            End If
        End If
        Console.ReadKey()
    End Sub
End Module
