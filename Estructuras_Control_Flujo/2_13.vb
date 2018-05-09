Module _2_13
    Sub main()
        Dim contador As UShort
        Dim numeroPrimo As UShort

        For n = 1 To 999

            For x = 1 To 999

                If n Mod x = 0 Then
                    contador += 1
                End If
            Next

            If contador = 2 Then
                numeroPrimo += 1
            End If
            contador = 0
        Next

        Console.WriteLine("Los números primos menores a 1000 son: " & numeroPrimo)
        Console.ReadKey()


    End Sub
End Module
