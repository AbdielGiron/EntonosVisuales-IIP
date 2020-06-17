<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArreglos
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbListaPc = New System.Windows.Forms.ComboBox()
        Me.cmbListaPrecio = New System.Windows.Forms.ComboBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnPrecio = New System.Windows.Forms.Button()
        Me.btnComputador = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbPCs = New System.Windows.Forms.ComboBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.a = New System.Windows.Forms.Label()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbListaPc)
        Me.GroupBox1.Controls.Add(Me.cmbListaPrecio)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnPrecio)
        Me.GroupBox1.Controls.Add(Me.btnComputador)
        Me.GroupBox1.Location = New System.Drawing.Point(51, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(287, 272)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "UNIDIMENSIONALES"
        '
        'cmbListaPc
        '
        Me.cmbListaPc.FormattingEnabled = True
        Me.cmbListaPc.Location = New System.Drawing.Point(6, 131)
        Me.cmbListaPc.Name = "cmbListaPc"
        Me.cmbListaPc.Size = New System.Drawing.Size(121, 21)
        Me.cmbListaPc.TabIndex = 4
        '
        'cmbListaPrecio
        '
        Me.cmbListaPrecio.FormattingEnabled = True
        Me.cmbListaPrecio.Location = New System.Drawing.Point(160, 131)
        Me.cmbListaPrecio.Name = "cmbListaPrecio"
        Me.cmbListaPrecio.Size = New System.Drawing.Size(121, 21)
        Me.cmbListaPrecio.TabIndex = 3
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(111, 218)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 26)
        Me.btnLimpiar.TabIndex = 2
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnPrecio
        '
        Me.btnPrecio.Location = New System.Drawing.Point(180, 63)
        Me.btnPrecio.Name = "btnPrecio"
        Me.btnPrecio.Size = New System.Drawing.Size(75, 43)
        Me.btnPrecio.TabIndex = 1
        Me.btnPrecio.Text = "Generar Precio"
        Me.btnPrecio.UseVisualStyleBackColor = True
        '
        'btnComputador
        '
        Me.btnComputador.Location = New System.Drawing.Point(35, 63)
        Me.btnComputador.Name = "btnComputador"
        Me.btnComputador.Size = New System.Drawing.Size(75, 43)
        Me.btnComputador.TabIndex = 0
        Me.btnComputador.Text = "Generar Computador"
        Me.btnComputador.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSolicitar)
        Me.GroupBox2.Controls.Add(Me.cmbPCs)
        Me.GroupBox2.Controls.Add(Me.a)
        Me.GroupBox2.Controls.Add(Me.txtCantidad)
        Me.GroupBox2.Location = New System.Drawing.Point(488, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(272, 244)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "INTERACTIVO"
        '
        'cmbPCs
        '
        Me.cmbPCs.FormattingEnabled = True
        Me.cmbPCs.Location = New System.Drawing.Point(78, 140)
        Me.cmbPCs.Name = "cmbPCs"
        Me.cmbPCs.Size = New System.Drawing.Size(121, 21)
        Me.cmbPCs.TabIndex = 5
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(132, 34)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 0
        '
        'a
        '
        Me.a.AutoSize = True
        Me.a.Location = New System.Drawing.Point(23, 37)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(103, 13)
        Me.a.TabIndex = 1
        Me.a.Text = "Cant. Computadoras"
        '
        'btnSolicitar
        '
        Me.btnSolicitar.Location = New System.Drawing.Point(93, 80)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(75, 26)
        Me.btnSolicitar.TabIndex = 5
        Me.btnSolicitar.Text = "Solicitar"
        Me.btnSolicitar.UseVisualStyleBackColor = True
        '
        'frmArreglos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 520)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmArreglos"
        Me.Text = "frmArreglos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbListaPc As ComboBox
    Friend WithEvents cmbListaPrecio As ComboBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnPrecio As Button
    Friend WithEvents btnComputador As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents cmbPCs As ComboBox
    Friend WithEvents a As Label
    Friend WithEvents txtCantidad As TextBox
End Class
