Module _2_02
    Sub main()

        Dim valor1, valor2, valor3 As Short

        Console.Write("Ingrese un valor: ")
        valor1 = Console.ReadLine
        Console.Write("Ingrese un valor: ")
        valor2 = Console.ReadLine
        Console.Write("Ingrese un valor: ")
        valor3 = Console.ReadLine

        If valor1 < valor2 And valor1 < valor3 Then
            Console.Write("El menor valor es: " & valor1)
        ElseIf valor2 < valor3 Then
            Console.Write("El menor valor es: " & valor2)
        Else
            Console.Write("El menor valor es: " & valor3)
        End If
        Console.ReadKey()
    End Sub
End Module
