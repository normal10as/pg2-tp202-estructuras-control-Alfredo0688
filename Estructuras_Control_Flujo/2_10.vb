Module _2_10
    Sub main()

        Dim valor_a As UShort
        Dim valor_b As UShort
        Dim multiplo As Byte


        Console.Write("Ingrese el primer valor: ")
        valor_a = Console.ReadLine
        Console.Write("Ingrese el segundo valor: ")
        valor_b = Console.ReadLine


        For n = valor_a To valor_b

            If n Mod 5 = 0 Then

                multiplo = multiplo + 1

            End If

        Next
        Console.WriteLine("Los múltiplos de 5 de los valores ingresados es: " & multiplo)
        Console.ReadKey()

    End Sub
End Module
