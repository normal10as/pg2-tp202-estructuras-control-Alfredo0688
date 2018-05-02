Module _07
    Sub main()

        Dim angulo As UShort

        Console.Write("Ingrese un grado de un angulo: ")
        angulo = Console.ReadLine

        Select Case angulo

            Case 1 To 89
                Console.WriteLine("Angulo agudo: ")
            Case 90
                Console.WriteLine("Angulo recto")
            Case 91 To 179
                Console.WriteLine("Angulo obtuso")
            Case 180
                Console.WriteLine("Angulo llano")
            Case 181 To 359
                Console.WriteLine("Angulo concavo")
            Case Else
                Console.WriteLine("Error")
        End Select

        Console.ReadKey()



    End Sub
End Module
