﻿Module _10c
    Sub main()
        Dim valora As UShort
        Dim valorb As UShort
        Dim multiplo As Byte
        Console.WriteLine("Ingrese dos valores, el primero inferior al segundo,se mostrarán los múltiplos de 5 entre ellos")

        Console.Write("Primer valor: ")
        valora = console.readline()
        console.write("Segundo valor: ")
        valorb = console.readline()

        Do
            If valora Mod 5 = 0 Then

                multiplo = multiplo + 1

            End If

            valora = valora + 1
        Loop While (valora <= valorb)


        Console.WriteLine("Múltiplos de 5: " & multiplo)
        Console.ReadKey()

    End Sub
End Module
