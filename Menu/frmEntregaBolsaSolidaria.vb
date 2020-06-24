Public Class frmEntregaBolsaSolidaria

    Private numero As Integer = 0
    Private beneficiado(10, 10) As String
    'Proceso
    Private Sub limpiar()
        txtNombree.Clear()
        txtId.Clear()
        txtEdadd.Clear()
        cmbEstado.Text = ""
        txtCantidad.Clear()
        chkBasica.Checked = False
        chkRegular.Checked = False
        txtDepartamento.Clear()
        txtMunicipio.Clear()
        txtDireccion.Clear()
    End Sub
    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        If txtCantidad.Text = "" Then
            chkRegular.Enabled = False
            chkBasica.Enabled = False
        Else
            If Val(txtCantidad.Text) > 0 And Val(txtCantidad.Text) < 4 Then
                chkRegular.Enabled = False
                chkBasica.Enabled = True
            Else
                chkRegular.Enabled = True
                chkBasica.Enabled = True
            End If

            If Val(txtCantidad.Text) > 3 Then
                chkBasica.Enabled = False
            Else
                chkBasica.Enabled = True
            End If
        End If
    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Try
            If Me.ValidateChildren And txtNombree.Text <> String.Empty And txtId.Text <> String.Empty And txtEdadd.Text <> String.Empty And (chkBasica.Checked = True Or chkRegular.Checked = True) And txtDepartamento.Text <> String.Empty And txtMunicipio.Text <> String.Empty And txtDireccion.Text <> String.Empty Then
                btnLimpiar.Enabled = True
                numero += 1
                beneficiado(numero, 1) = numero
                beneficiado(numero, 2) = txtId.Text
                beneficiado(numero, 3) = txtNombree.Text
                beneficiado(numero, 4) = txtEdadd.Text
                beneficiado(numero, 5) = cmbEstado.SelectedItem
                beneficiado(numero, 6) = txtCantidad.Text

                If chkBasica.Checked = True Then
                    beneficiado(numero, 7) = "Basica"
                ElseIf chkRegular.Checked = True Then
                    beneficiado(numero, 7) = "Regular"
                End If

                beneficiado(numero, 8) = txtDepartamento.Text
                beneficiado(numero, 9) = txtMunicipio.Text
                beneficiado(numero, 10) = txtDireccion.Text
                dgwHistorial.Rows.Add(numero, txtId.Text, cmbEstado.SelectedItem, "Regular", txtDepartamento.Text)

            Else
                MessageBox.Show("ERROR AL INGRESAR LOS DATOS", "INGRESO DEL BENEFICIADO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtNombree_MouseHover(sender As Object, e As EventArgs) Handles txtNombree.MouseHover
        ToolTip.SetToolTip(txtNombree, "Nombre del Jefe de familia")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtId_MouseHover(sender As Object, e As EventArgs) Handles txtId.MouseHover
        ToolTip.SetToolTip(txtId, "Identidad del Jefe de familia")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtEdadd_MouseHover(sender As Object, e As EventArgs) Handles txtEdadd.MouseHover
        ToolTip.SetToolTip(txtEdadd, "Edad del Jefe de familia")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbEstado_MouseHover(sender As Object, e As EventArgs) Handles cmbEstado.MouseHover
        ToolTip.SetToolTip(cmbEstado, "Estado economico de la familia")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCantidad_MouseHover(sender As Object, e As EventArgs) Handles txtCantidad.MouseHover
        ToolTip.SetToolTip(txtCantidad, "Cantidad de miembros en la familia")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub GroupBox4_MouseHover(sender As Object, e As EventArgs) Handles GroupBox4.MouseHover
        ToolTip.SetToolTip(GroupBox4, "tipo de bolsa solidatia")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDepartamento_MouseHover(sender As Object, e As EventArgs) Handles txtDepartamento.MouseHover
        ToolTip.SetToolTip(txtDepartamento, "Departamento de residencia")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtMunicipio_MouseHover(sender As Object, e As EventArgs) Handles txtMunicipio.MouseHover
        ToolTip.SetToolTip(txtMunicipio, "Municipio de residencia")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDireccion_MouseHover(sender As Object, e As EventArgs) Handles txtDireccion.MouseHover
        ToolTip.SetToolTip(txtDireccion, "direccion de domicilio")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnBuscarr_MouseHover(sender As Object, e As EventArgs) Handles btnBuscarr.MouseHover
        ToolTip.SetToolTip(btnBuscarr, "Buscar la identidad en el sistema")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnAgregar_MouseHover(sender As Object, e As EventArgs) Handles btnAgregar.MouseHover
        ToolTip.SetToolTip(btnAgregar, "Agrega al benficiario al Historial")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub



    Private Sub btnBuscarr_Click(sender As Object, e As EventArgs) Handles btnBuscarr.Click
        Dim identidad As String
        identidad = txtId.Text
        If identidad.Length = 13 Or identidad.Length = 15 Then

            Select Case identidad.Substring(0, 2)
                Case "01"
                    txtDepartamento.Text = "Atlantidad"

                    Select Case identidad.Substring(2, 2)
                        Case "01"
                            txtMunicipio.Text = "La Ceiba"
                        Case "02"
                            txtMunicipio.Text = "El Porvenir"
                        Case "03"
                            txtMunicipio.Text = "Esparta"
                        Case "04"
                            txtMunicipio.Text = "Jutiapa"
                        Case "05"
                            txtMunicipio.Text = "La Masica"
                        Case "06"
                            txtMunicipio.Text = "San Francisco"
                        Case "07"
                            txtMunicipio.Text = "Tela"
                        Case "08"
                            txtMunicipio.Text = "Arizona"
                    End Select

                Case "02"
                    txtDepartamento.Text = "Colón"

                    Select Case identidad.Substring(2, 2)
                        Case "01"
                            txtMunicipio.Text = "Trujillo"
                        Case "02"
                            txtMunicipio.Text = "Balfate"
                        Case "03"
                            txtMunicipio.Text = "Iriona"
                        Case "04"
                            txtMunicipio.Text = "Limón"
                        Case "05"
                            txtMunicipio.Text = "Sabá"
                        Case "06"
                            txtMunicipio.Text = "Santa Fe"
                        Case "07"
                            txtMunicipio.Text = "Santa Rosa de Aguán"
                        Case "08"
                            txtMunicipio.Text = "Sonaguera"
                        Case "09"
                            txtMunicipio.Text = "Tocoa"
                        Case "10"
                            txtMunicipio.Text = "Bonito Oriental"
                    End Select

                Case "03"
                    txtDepartamento.Text = "Comayagua"

                    Select Case identidad.Substring(2, 2)
                        Case "01"
                            txtMunicipio.Text = "Comayagua"
                        Case "02"
                            txtMunicipio.Text = "Ajuterique"
                        Case "03"
                            txtMunicipio.Text = "El Rosario"
                        Case "04"
                            txtMunicipio.Text = "Esquías"
                        Case "05"
                            txtMunicipio.Text = "Humuya"
                        Case "06"
                            txtMunicipio.Text = "La Libertad"
                        Case "07"
                            txtMunicipio.Text = "Lamaní"
                        Case "08"
                            txtMunicipio.Text = "La Trinidad"
                        Case "09"
                            txtMunicipio.Text = "Lejamaní"
                        Case "10"
                            txtMunicipio.Text = "Meámbar"
                        Case "11"
                            txtMunicipio.Text = "Minas de Oro"
                        Case "12"
                            txtMunicipio.Text = "Ojos de Agua"
                        Case "13"
                            txtMunicipio.Text = "San Jerónimo"
                        Case "14"
                            txtMunicipio.Text = "San José de Comayagua"
                        Case "15"
                            txtMunicipio.Text = "San José del Potrero"
                        Case "16"
                            txtMunicipio.Text = "San Luis"
                        Case "17"
                            txtMunicipio.Text = "San Sebastián"
                        Case "18"
                            txtMunicipio.Text = "Siguatepeque"
                        Case "19"
                            txtMunicipio.Text = "Villa de San Antonio"
                        Case "20"
                            txtMunicipio.Text = "Las Lajas"
                        Case "21"
                            txtMunicipio.Text = "Taulabé"

                    End Select
                Case "04"
                    txtDepartamento.Text = "Copán"

                    Select Case identidad.Substring(2, 2)
                        Case "01"
                            txtMunicipio.Text = "Santa Rosa de Copán"
                        Case "02"
                            txtMunicipio.Text = "Cabañas"
                        Case "03"
                            txtMunicipio.Text = "Concepción"
                        Case "04"
                            txtMunicipio.Text = "Copán Ruinas"
                        Case "05"
                            txtMunicipio.Text = "Corquín"
                        Case "06"
                            txtMunicipio.Text = "Cucuyagua"
                        Case "07"
                            txtMunicipio.Text = "Dolores"
                        Case "08"
                            txtMunicipio.Text = "Dulce Nombre"
                        Case "09"
                            txtMunicipio.Text = "El Paraíso"
                        Case "10"
                            txtMunicipio.Text = "Florida"
                        Case "11"
                            txtMunicipio.Text = "La Jigua"
                        Case "12"
                            txtMunicipio.Text = "La Unión"
                        Case "13"
                            txtMunicipio.Text = "Nueva Arcadia"
                        Case "14"
                            txtMunicipio.Text = "San Agustín"
                        Case "15"
                            txtMunicipio.Text = "San Antonio"
                        Case "16"
                            txtMunicipio.Text = "San Jerónimo"
                        Case "17"
                            txtMunicipio.Text = "San José"
                        Case "18"
                            txtMunicipio.Text = "San Juan de Opoa"
                        Case "19"
                            txtMunicipio.Text = "San Nicolás"
                        Case "20"
                            txtMunicipio.Text = "San Pedro"
                        Case "21"
                            txtMunicipio.Text = "Santa Rita"
                        Case "22"
                            txtMunicipio.Text = "Trinidad de Copán"
                        Case "23"
                            txtMunicipio.Text = "Veracruz"
                    End Select

                Case "05"
                    txtDepartamento.Text = "Cortés"
                Case "06"
                    txtDepartamento.Text = "Choluteca"
                Case "07"
                    txtDepartamento.Text = "El Paraíso"
                Case "08"
                    txtDepartamento.Text = "Francisco Morazán"
                Case "09"
                    txtDepartamento.Text = "Gracias a Dios"
                Case "10"
                    txtDepartamento.Text = "Intibucá"
                Case "11"
                    txtDepartamento.Text = "Islas de La Bahía"
                Case "12"
                    txtDepartamento.Text = "La Paz"
                Case "13"
                    txtDepartamento.Text = "Lempira"
                Case "14"
                    txtDepartamento.Text = "Ocotepeque"
                Case "15"
                    txtDepartamento.Text = "Olancho"
                Case "16"
                    txtDepartamento.Text = "Santa Bárbara"
                Case "17"
                    txtDepartamento.Text = "Valle"
                Case "18"
                    txtDepartamento.Text = "Yoro"

            End Select
        Else
            MessageBox.Show("Cantidad de caracteres insuficientes", "Identidad", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Private Sub btnMasInfo_Click(sender As Object, e As EventArgs) Handles btnMasInfo.Click
        Module1.identidad = beneficiado(dgwHistorial.CurrentRow.Index + 1, 2)
        Module1.nombre = beneficiado(dgwHistorial.CurrentRow.Index + 1, 3)
        Module1.edad = beneficiado(dgwHistorial.CurrentRow.Index + 1, 4)
        Module1.estado = beneficiado(dgwHistorial.CurrentRow.Index + 1, 5)
        Module1.cantidad = beneficiado(dgwHistorial.CurrentRow.Index + 1, 6)
        Module1.bolsa = beneficiado(dgwHistorial.CurrentRow.Index + 1, 7)
        Module1.departamento = beneficiado(dgwHistorial.CurrentRow.Index + 1, 8)
        Module1.municipio = beneficiado(dgwHistorial.CurrentRow.Index + 1, 9)
        Module1.direccion = beneficiado(dgwHistorial.CurrentRow.Index + 1, 10)
        frmTotalDatosBeneficiario.ShowDialog()


    End Sub

    Private Sub txtNombree_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombree.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtId_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtId.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtCantidad_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCantidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtDepartamento_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtMunicipio.Validating, txtDireccion.Validating, txtDepartamento.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub
End Class