Module _2_10_b

    Sub main()
        Dim valora As UShort
        Dim valorb As UShort
        Dim multiplo As Byte
        Console.WriteLine("Ingrese dos valores, el primero inferior al segundo,se mostrarán los múltiplos de 5 entre ellos")

        Console.Write("Primer valor: ")
        valora = Console.ReadLine()
        Console.Write("Segundo valor: ")
        valorb = Console.ReadLine()

        Do Until (valora > valorb)

            If valora Mod 5 = 0 Then
                multiplo = multiplo + 1

            End If
            valora = valora + 1
        Loop


        Console.WriteLine("Los múltiplos de 5 son: " & multiplo)
        Console.ReadKey()

    End Sub


End Module
