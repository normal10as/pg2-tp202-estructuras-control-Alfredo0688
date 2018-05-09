Module _2_03
    Sub main()

        Dim valor1, valor2, valor3, valor4, valor5 As Short
        Dim posicion As String

        Console.Write("Ingrese un valor: ")
        valor1 = Console.ReadLine
        Console.Write("Ingrese un valor: ")
        valor2 = Console.ReadLine
        Console.Write("Ingrese un valor: ")
        valor3 = Console.ReadLine
        Console.Write("Ingrese un valor: ")
        valor4 = Console.ReadLine
        Console.Write("Ingrese un valor: ")
        valor5 = Console.ReadLine

        If valor1 > valor2 And valor1 > valor3 And valor1 > valor4 And valor1 > valor5 Then
            posicion = "primer"
        ElseIf valor2 > valor3 And valor2 > valor4 And valor2 > valor5 Then
            posicion = "segundo"
        ElseIf valor3 > valor4 And valor3 > valor5 Then
            posicion = "tercer"
        ElseIf valor4 > valor5 Then
            posicion = "cuarto"
        Else
            posicion = "quinto"
        End If

        Console.WriteLine("Valores ingresados: {0} {1} {2} {3} {4} ", valor1, valor2, valor3, valor4, valor5)
        Console.Write("El {0} número ingresado es el mayor ", posicion)
        Console.ReadKey()

    End Sub
End Module
