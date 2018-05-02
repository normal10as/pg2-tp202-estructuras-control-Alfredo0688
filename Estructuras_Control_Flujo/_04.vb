Module _04
    Sub main()

        Dim valorProducto As Single
        Dim cantidadProducto As Byte
        Dim descuentoProducto As Single
        Dim descuento As Byte

        Console.Write("Ingrese el valor de un producto: ")
        valorProducto = Console.ReadLine
        Console.Write("Ingrese cantidad: ")
        cantidadProducto = Console.ReadLine


        If cantidadProducto >= 10 And cantidadProducto <= 50 Then
            descuento = 5
            descuentoProducto = valorProducto * descuento / 100
        ElseIf cantidadProducto > 50 And cantidadProducto <= 250 Then
            descuento = 10
            descuentoProducto = valorProducto * descuento / 100
        ElseIf cantidadProducto > 250 Then
            descuento = 20
            descuentoProducto = valorProducto * descuento / 100
        End If

        Console.WriteLine("Subtotal: " & cantidadProducto * valorProducto)
        Console.WriteLine("Descuento aplicado: " & descuento & "%")
        Console.WriteLine("Monto descontado: " & descuentoProducto)
        descuentoProducto = descuentoProducto * cantidadProducto
        Console.WriteLine("Total: " & cantidadProducto * valorProducto + descuentoProducto)
        Console.ReadKey()
    End Sub
End Module
