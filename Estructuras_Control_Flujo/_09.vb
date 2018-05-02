Module _09
    Sub main()

        Dim medida As String
        Dim metro As Single
        Dim centimetro As Single
        Dim yarda As Single
        Dim pie As Single
        Dim pulgada As Single

        Console.WriteLine("Conversiones de equivalencias a Metro - Yarda - Pulgada - Centimetro y Pie")
        Console.WriteLine("Que unidad de medida desea convertir? escriba correctamente")
        Console.Write("Medida: ")
        medida = Console.ReadLine
        Select Case medida

            Case "metro"
                Console.Write("unidad de {0}: ", medida)
                metro = Console.ReadLine
                centimetro = metro * 100
                pulgada = centimetro / 2.54
                pie = pulgada / 12
                yarda = pie / 3

            Case "centimetro"
                Console.Write("unidad de {0}: ", medida)
                centimetro = Console.ReadLine
                metro = centimetro / 100
                pulgada = centimetro / 2.54
                pie = pulgada / 12
                yarda = pie / 3
            Case "pie"
                Console.Write("unidad de {0}: ", medida)
                pie = Console.ReadLine
                yarda = pie / 3
                pulgada = pie * 12
                centimetro = pulgada * 2.54
                metro = centimetro / 100
            Case "yarda"
                Console.Write("unidad de {0}: ", medida)
                yarda = Console.ReadLine
                pie = yarda * 3
                pulgada = pie * 12
                centimetro = pulgada * 2.54
                metro = centimetro / 100
            Case "pulgada"
                Console.Write("unidad de {0}: ", medida)
                pulgada = Console.ReadLine
                pie = pulgada / 12
                yarda = pie / 3
                centimetro = pulgada * 2.54
                metro = centimetro / 100
            Case Else
                Console.WriteLine("Error")
        End Select

        Console.WriteLine("Metro: " & metro)
        Console.WriteLine("Centimetro: " & centimetro)
        Console.WriteLine("Pulgada: " & pulgada)
        Console.WriteLine("Pie: " & pie)
        Console.WriteLine("Yarda: " & yarda)

        Console.ReadKey()
    End Sub
End Module
