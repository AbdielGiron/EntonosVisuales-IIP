Public Class frmArreglos
    Private Sub btnComputador_Click(sender As Object, e As EventArgs) Handles btnComputador.Click
        Dim listaPCs(3) As String
        listaPCs(0) = "Toshiba"
        listaPCs(1) = "Dell"
        listaPCs(2) = "Asus"
        listaPCs(3) = "Mac"

        For i = 0 To listaPCs.Length - 1 Step 1
            cmbListaPc.Items.Add(listaPCs(i))
        Next
    End Sub

    Private Sub btnPrecio_Click(sender As Object, e As EventArgs) Handles btnPrecio.Click
        Dim listaPrecios(3) As Integer
        listaPrecios(0) = 20000
        listaPrecios(1) = 22000
        listaPrecios(2) = 29000
        listaPrecios(3) = 42000

        For i = 0 To listaPrecios.Length - 1 Step 1
            cmbListaPrecio.Items.Add(listaPrecios(i))
        Next
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        cmbListaPc.Items.Clear()
        cmbListaPrecio.Items.Clear()
    End Sub

    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        Dim PCs() As String
        Dim cantidad As Integer
        cantidad = Val(txtCantidad.Text)
        ReDim PCs(cantidad)
        For j = 0 To (cantidad - 1) Step 1
            PCs(j) = InputBox("Ingrese la marca de la PC", "Ingreso")
        Next

        For i = 0 To (cantidad - 1) Step 1
            cmbPCs.Items.Add(PCs(i))
        Next
    End Sub
End Class