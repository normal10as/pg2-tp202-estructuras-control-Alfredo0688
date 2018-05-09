Module _2_15
    Sub main()

        Const tasaInteres As Single = 36 / 100
        Dim capitalInicial As Single

        Dim intereses As Single
        Dim saldo As Single
        Dim meses As Byte
        Dim interesesGanados As Single

        Console.Write("Ingresar capital inicial: ")
        capitalInicial = Console.ReadLine
        Console.Write("Número de meses a depositar: ")
        meses = Console.ReadLine
        Console.WriteLine(" MES     CAPITAL      INTERES           SALDO")
        For n = 1 To meses
            capitalInicial = capitalInicial + saldo
            intereses = capitalInicial * (tasaInteres / 12)
            saldo = capitalInicial + intereses
            interesesGanados = interesesGanados + intereses
            Console.Write("  " & n & "       " & capitalInicial & "          " & intereses & "              " & saldo)
            Console.ReadKey()
            Console.WriteLine()
            capitalInicial = 0
        Next

        Console.WriteLine("Intereses ganados: " & interesesGanados)
        Console.ReadKey()

    End Sub
End Module
