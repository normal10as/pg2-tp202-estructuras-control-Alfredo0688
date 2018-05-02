Module _11
    Sub main()

        Dim valor As UShort = 1
        Dim pares As Byte
        Dim impares As Byte
        Dim contador As Byte



      
        Do Until valor = 0

            Console.WriteLine("Ingresar valores hasta que sea cero")
            Console.Write("Valor: ")
            valor = Console.ReadLine

            If valor Mod 2 = 0 And valor <> 0 Then
                pares += 1
            ElseIf valor Mod 2 <> 0 And valor <> 0 Then
                impares += 1
            End If

            contador += 1
        Loop

        contador = contador - 1

        If contador = 0 Then
            Console.WriteLine("fin del programa")

        ElseIf pares = contador Then

            Console.WriteLine("Los valores ingresados son todos pares: " & pares)
        ElseIf impares = contador Then

            Console.WriteLine("Los valores ingresados son todos impares: " & impares)
        Else

            Console.WriteLine("Los valores ingresados son {0}, pares: {1} e impares: {2} ", contador, pares, impares)
        End If

        Console.ReadKey()

    End Sub
End Module
