Module _12
    Sub main()
        Dim inicio As UShort
        Dim final As UShort = 1
        Dim Secuencia As UShort = 0
        Dim n As Byte = 1
        Console.WriteLine("Secuencia Fibonacci")


        While n <= 20

            Console.WriteLine(n & "º: " & Secuencia)
            Secuencia = inicio + final
            inicio = final
            final = Secuencia
            Console.ReadKey()
            n += 1
        End While



    End Sub
End Module
