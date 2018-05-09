Module _2_06
    Sub main()

        Dim valorProducto As Single
        Dim cantidadProducto As Byte
        Dim descuentoAplicado As Byte
        Dim descuentoProducido As Single

        Console.Write("Ingresar el valor del producto: ")
        valorProducto = Console.ReadLine
        Console.Write("Ingresar la cantidad: ")
        cantidadProducto = Console.ReadLine

        Select Case cantidadProducto

            Case 10 To 50
                descuentoAplicado = 5
                descuentoProducido = valorProducto * descuentoAplicado / 100

            Case 51 To 250
                descuentoAplicado = 10
                descuentoProducido = valorProducto * descuentoAplicado / 100

            Case Is > 250
                descuentoAplicado = 20
                descuentoProducido = valorProducto * descuentoAplicado / 100

        End Select

        Console.WriteLine("Subtotal: " & valorProducto * cantidadProducto)
        Console.WriteLine("Descuento aplicado: " & descuentoAplicado & "%")
        Console.WriteLine("Descuento producido: " & descuentoProducido)
        descuentoProducido = descuentoProducido * cantidadProducto
        Console.WriteLine("Total: " & valorProducto * cantidadProducto + descuentoProducido)
        Console.ReadKey()
    End Sub
End Module
