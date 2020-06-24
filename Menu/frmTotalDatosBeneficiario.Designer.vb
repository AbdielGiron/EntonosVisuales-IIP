<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTotalDatosBeneficiario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtEstados = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkRegulares = New System.Windows.Forms.CheckBox()
        Me.chkBasicas = New System.Windows.Forms.CheckBox()
        Me.txtMunicipios = New System.Windows.Forms.TextBox()
        Me.txtDepartamentos = New System.Windows.Forms.TextBox()
        Me.txtDirecciones = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCantidades = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txtIdentidades = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEdades = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtEstados)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.txtMunicipios)
        Me.GroupBox3.Controls.Add(Me.txtDepartamentos)
        Me.GroupBox3.Controls.Add(Me.txtDirecciones)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtCantidades)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(43, 151)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(344, 280)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos familiares"
        '
        'txtEstados
        '
        Me.txtEstados.Location = New System.Drawing.Point(101, 27)
        Me.txtEstados.Name = "txtEstados"
        Me.txtEstados.Size = New System.Drawing.Size(150, 20)
        Me.txtEstados.TabIndex = 21
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkRegulares)
        Me.GroupBox4.Controls.Add(Me.chkBasicas)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 86)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(236, 49)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo de bolsa"
        '
        'chkRegulares
        '
        Me.chkRegulares.AutoSize = True
        Me.chkRegulares.Location = New System.Drawing.Point(131, 21)
        Me.chkRegulares.Name = "chkRegulares"
        Me.chkRegulares.Size = New System.Drawing.Size(63, 17)
        Me.chkRegulares.TabIndex = 29
        Me.chkRegulares.Text = "Regular"
        Me.chkRegulares.UseVisualStyleBackColor = True
        '
        'chkBasicas
        '
        Me.chkBasicas.AutoSize = True
        Me.chkBasicas.Location = New System.Drawing.Point(26, 21)
        Me.chkBasicas.Name = "chkBasicas"
        Me.chkBasicas.Size = New System.Drawing.Size(58, 17)
        Me.chkBasicas.TabIndex = 28
        Me.chkBasicas.Text = "Basica" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.chkBasicas.UseVisualStyleBackColor = True
        '
        'txtMunicipios
        '
        Me.txtMunicipios.Location = New System.Drawing.Point(101, 179)
        Me.txtMunicipios.Name = "txtMunicipios"
        Me.txtMunicipios.Size = New System.Drawing.Size(150, 20)
        Me.txtMunicipios.TabIndex = 27
        '
        'txtDepartamentos
        '
        Me.txtDepartamentos.Location = New System.Drawing.Point(101, 145)
        Me.txtDepartamentos.Name = "txtDepartamentos"
        Me.txtDepartamentos.Size = New System.Drawing.Size(150, 20)
        Me.txtDepartamentos.TabIndex = 26
        '
        'txtDirecciones
        '
        Me.txtDirecciones.Location = New System.Drawing.Point(101, 212)
        Me.txtDirecciones.Multiline = True
        Me.txtDirecciones.Name = "txtDirecciones"
        Me.txtDirecciones.Size = New System.Drawing.Size(217, 50)
        Me.txtDirecciones.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 212)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Direccion"
        '
        'txtCantidades
        '
        Me.txtCantidades.Location = New System.Drawing.Point(101, 60)
        Me.txtCantidades.Name = "txtCantidades"
        Me.txtCantidades.Size = New System.Drawing.Size(150, 20)
        Me.txtCantidades.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Cant. miembros"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Estado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Municipio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Departamento"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtNombres)
        Me.GroupBox5.Controls.Add(Me.txtIdentidades)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.txtEdades)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Location = New System.Drawing.Point(43, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(344, 133)
        Me.GroupBox5.TabIndex = 23
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Datos del Jefe de familia"
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(108, 23)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(228, 20)
        Me.txtNombres.TabIndex = 17
        '
        'txtIdentidades
        '
        Me.txtIdentidades.Location = New System.Drawing.Point(108, 60)
        Me.txtIdentidades.Name = "txtIdentidades"
        Me.txtIdentidades.Size = New System.Drawing.Size(150, 20)
        Me.txtIdentidades.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Nombre"
        '
        'txtEdades
        '
        Me.txtEdades.Location = New System.Drawing.Point(108, 97)
        Me.txtEdades.Mask = "99"
        Me.txtEdades.Name = "txtEdades"
        Me.txtEdades.Size = New System.Drawing.Size(53, 20)
        Me.txtEdades.TabIndex = 9
        Me.txtEdades.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtEdades.ValidatingType = GetType(Integer)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Identidad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 102)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Edad"
        '
        'frmTotalDatosBeneficiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 464)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Name = "frmTotalDatosBeneficiario"
        Me.Text = "frmTotalDatosBeneficiario"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Public WithEvents txtMunicipios As TextBox
    Public WithEvents txtDepartamentos As TextBox
    Public WithEvents txtDirecciones As TextBox
    Public WithEvents txtCantidades As TextBox
    Public WithEvents txtNombres As TextBox
    Public WithEvents txtIdentidades As TextBox
    Public WithEvents txtEdades As MaskedTextBox
    Public WithEvents chkRegulares As CheckBox
    Public WithEvents chkBasicas As CheckBox
    Public WithEvents txtEstados As TextBox
End Class
