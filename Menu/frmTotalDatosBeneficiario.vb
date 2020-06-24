Public Class frmTotalDatosBeneficiario
    Private Sub frmTotalDatosBeneficiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdentidades.Text = Module1.identidad
        txtNombres.Text = Module1.nombre
        txtIdentidades.Text = Module1.identidad
        txtEstados.Text = Module1.estado
        txtEdades.Text = Module1.edad
        txtCantidades.Text = Module1.cantidad
        If Module1.bolsa = "Basica" Then
            chkBasicas.Checked = True
            chkRegulares.Enabled = False
        Else
            chkRegulares.Checked = True
            chkBasicas.Enabled = False
        End If
        txtDepartamentos.Text = Module1.departamento
        txtMunicipios.Text = Module1.municipio
        txtDirecciones.Text = Module1.direccion
    End Sub
End Class