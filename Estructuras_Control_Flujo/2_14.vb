Module _2_14
    Sub main()

        Dim cantidadProducto As UShort
        Dim precioUnitario As Single
        Dim descuentoProducto As Byte
        Dim montoDescontado As Single
        Dim totalDescontado As Single
        Dim total As Single
        Dim totalCobrar As Single

        Do

            Console.Write("Cantidad producto: ")
            cantidadProducto = Console.ReadLine
            If cantidadProducto = 0 Then
                Exit Do
            End If
            Console.Write("Precio unitario: $")
            precioUnitario = Console.ReadLine

            If cantidadProducto >= 10 And cantidadProducto <= 50 Then
                descuentoProducto = 5
            ElseIf cantidadProducto > 50 And cantidadProducto <= 250 Then
                descuentoProducto = 10
            ElseIf cantidadProducto > 250 Then
                descuentoProducto = 20
            End If
            montoDescontado = (precioUnitario * descuentoProducto / 100) * cantidadProducto
            total = cantidadProducto * precioUnitario - montoDescontado
            Console.WriteLine("Subtotal: " & cantidadProducto * precioUnitario)
            Console.WriteLine("Porcentaje aplicado: %" & descuentoProducto)
            Console.WriteLine("Monto descontado: " & montoDescontado)
            Console.WriteLine("Total: " & total)
            totalDescontado = montoDescontado + totalDescontado
            totalCobrar = total + totalCobrar

        Loop

        Console.WriteLine("El total descontado es: {0} y el total a cobrar: {1} ", totalDescontado, totalCobrar)
        Console.ReadKey()

    End Sub
End Module
