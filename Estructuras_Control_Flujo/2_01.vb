Module _2_01

    Sub Main()

        Dim num1, num2 As UShort

        Console.Write("Ingrese un valor: ")
        num1 = Console.ReadLine
        Console.Write("Ingrese otro valor: ")
        num2 = Console.ReadLine

        If num1 > num2 Then
            Console.Write("El valor mayor es: " & num1)
        ElseIf num2 > num1 Then
            Console.Write("El valor mayor es: " & num2)
        Else
            Console.Write("Los valores son iguales")
        End If
        Console.ReadKey()

    End Sub

End Module
