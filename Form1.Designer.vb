<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Operadores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Operadores))
        Me.GroupBoxCalcular = New System.Windows.Forms.GroupBox()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.ButtonCalcular = New System.Windows.Forms.Button()
        Me.ButtonNuevo = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LabelNúmero2 = New System.Windows.Forms.Label()
        Me.LabelNumero1 = New System.Windows.Forms.Label()
        Me.GroupBoxResultados = New System.Windows.Forms.GroupBox()
        Me.LabelOperacionRaiz = New System.Windows.Forms.Label()
        Me.LabelOperacionPot = New System.Windows.Forms.Label()
        Me.LabelOperacionDiv = New System.Windows.Forms.Label()
        Me.LabelOperacionMult = New System.Windows.Forms.Label()
        Me.LabelOperacionResta = New System.Windows.Forms.Label()
        Me.LabelOperacionSuma = New System.Windows.Forms.Label()
        Me.TextBoxRaiz = New System.Windows.Forms.TextBox()
        Me.TextBoxPotencia = New System.Windows.Forms.TextBox()
        Me.TextBoxDivision = New System.Windows.Forms.TextBox()
        Me.TextBoxMultiplicacion = New System.Windows.Forms.TextBox()
        Me.TextBoxResta = New System.Windows.Forms.TextBox()
        Me.TextBoxSuma = New System.Windows.Forms.TextBox()
        Me.LabelRaiz = New System.Windows.Forms.Label()
        Me.LabelPotencia = New System.Windows.Forms.Label()
        Me.LabelDivision = New System.Windows.Forms.Label()
        Me.LabelMultiplicacion = New System.Windows.Forms.Label()
        Me.LabelResta = New System.Windows.Forms.Label()
        Me.LabelSuma = New System.Windows.Forms.Label()
        Me.PictureBoxUML = New System.Windows.Forms.PictureBox()
        Me.ToolTipUML = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBoxCalcular.SuspendLayout()
        Me.GroupBoxResultados.SuspendLayout()
        CType(Me.PictureBoxUML, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxCalcular
        '
        Me.GroupBoxCalcular.Controls.Add(Me.PictureBoxUML)
        Me.GroupBoxCalcular.Controls.Add(Me.ButtonSalir)
        Me.GroupBoxCalcular.Controls.Add(Me.ButtonCalcular)
        Me.GroupBoxCalcular.Controls.Add(Me.ButtonNuevo)
        Me.GroupBoxCalcular.Controls.Add(Me.TextBox2)
        Me.GroupBoxCalcular.Controls.Add(Me.TextBox1)
        Me.GroupBoxCalcular.Controls.Add(Me.LabelNúmero2)
        Me.GroupBoxCalcular.Controls.Add(Me.LabelNumero1)
        Me.GroupBoxCalcular.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxCalcular.Name = "GroupBoxCalcular"
        Me.GroupBoxCalcular.Size = New System.Drawing.Size(776, 203)
        Me.GroupBoxCalcular.TabIndex = 0
        Me.GroupBoxCalcular.TabStop = False
        Me.GroupBoxCalcular.Text = "Calcular"
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Location = New System.Drawing.Point(573, 116)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(131, 24)
        Me.ButtonSalir.TabIndex = 6
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'ButtonCalcular
        '
        Me.ButtonCalcular.Location = New System.Drawing.Point(573, 76)
        Me.ButtonCalcular.Name = "ButtonCalcular"
        Me.ButtonCalcular.Size = New System.Drawing.Size(131, 24)
        Me.ButtonCalcular.TabIndex = 5
        Me.ButtonCalcular.Text = "Calcular"
        Me.ButtonCalcular.UseVisualStyleBackColor = True
        '
        'ButtonNuevo
        '
        Me.ButtonNuevo.Location = New System.Drawing.Point(573, 35)
        Me.ButtonNuevo.Name = "ButtonNuevo"
        Me.ButtonNuevo.Size = New System.Drawing.Size(131, 24)
        Me.ButtonNuevo.TabIndex = 4
        Me.ButtonNuevo.Text = "Nuevo - Borrar"
        Me.ButtonNuevo.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(198, 115)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(110, 20)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(198, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(110, 20)
        Me.TextBox1.TabIndex = 2
        '
        'LabelNúmero2
        '
        Me.LabelNúmero2.AutoSize = True
        Me.LabelNúmero2.Location = New System.Drawing.Point(42, 122)
        Me.LabelNúmero2.Name = "LabelNúmero2"
        Me.LabelNúmero2.Size = New System.Drawing.Size(53, 13)
        Me.LabelNúmero2.TabIndex = 1
        Me.LabelNúmero2.Text = "Número 2"
        '
        'LabelNumero1
        '
        Me.LabelNumero1.AutoSize = True
        Me.LabelNumero1.Location = New System.Drawing.Point(42, 47)
        Me.LabelNumero1.Name = "LabelNumero1"
        Me.LabelNumero1.Size = New System.Drawing.Size(53, 13)
        Me.LabelNumero1.TabIndex = 0
        Me.LabelNumero1.Text = "Número 1"
        '
        'GroupBoxResultados
        '
        Me.GroupBoxResultados.Controls.Add(Me.LabelOperacionRaiz)
        Me.GroupBoxResultados.Controls.Add(Me.LabelOperacionPot)
        Me.GroupBoxResultados.Controls.Add(Me.LabelOperacionDiv)
        Me.GroupBoxResultados.Controls.Add(Me.LabelOperacionMult)
        Me.GroupBoxResultados.Controls.Add(Me.LabelOperacionResta)
        Me.GroupBoxResultados.Controls.Add(Me.LabelOperacionSuma)
        Me.GroupBoxResultados.Controls.Add(Me.TextBoxRaiz)
        Me.GroupBoxResultados.Controls.Add(Me.TextBoxPotencia)
        Me.GroupBoxResultados.Controls.Add(Me.TextBoxDivision)
        Me.GroupBoxResultados.Controls.Add(Me.TextBoxMultiplicacion)
        Me.GroupBoxResultados.Controls.Add(Me.TextBoxResta)
        Me.GroupBoxResultados.Controls.Add(Me.TextBoxSuma)
        Me.GroupBoxResultados.Controls.Add(Me.LabelRaiz)
        Me.GroupBoxResultados.Controls.Add(Me.LabelPotencia)
        Me.GroupBoxResultados.Controls.Add(Me.LabelDivision)
        Me.GroupBoxResultados.Controls.Add(Me.LabelMultiplicacion)
        Me.GroupBoxResultados.Controls.Add(Me.LabelResta)
        Me.GroupBoxResultados.Controls.Add(Me.LabelSuma)
        Me.GroupBoxResultados.Location = New System.Drawing.Point(12, 221)
        Me.GroupBoxResultados.Name = "GroupBoxResultados"
        Me.GroupBoxResultados.Size = New System.Drawing.Size(776, 217)
        Me.GroupBoxResultados.TabIndex = 1
        Me.GroupBoxResultados.TabStop = False
        '
        'LabelOperacionRaiz
        '
        Me.LabelOperacionRaiz.AutoSize = True
        Me.LabelOperacionRaiz.Enabled = False
        Me.LabelOperacionRaiz.Location = New System.Drawing.Point(507, 162)
        Me.LabelOperacionRaiz.Name = "LabelOperacionRaiz"
        Me.LabelOperacionRaiz.Size = New System.Drawing.Size(0, 13)
        Me.LabelOperacionRaiz.TabIndex = 17
        '
        'LabelOperacionPot
        '
        Me.LabelOperacionPot.AutoSize = True
        Me.LabelOperacionPot.Enabled = False
        Me.LabelOperacionPot.Location = New System.Drawing.Point(507, 105)
        Me.LabelOperacionPot.Name = "LabelOperacionPot"
        Me.LabelOperacionPot.Size = New System.Drawing.Size(0, 13)
        Me.LabelOperacionPot.TabIndex = 16
        '
        'LabelOperacionDiv
        '
        Me.LabelOperacionDiv.AutoSize = True
        Me.LabelOperacionDiv.Enabled = False
        Me.LabelOperacionDiv.Location = New System.Drawing.Point(507, 45)
        Me.LabelOperacionDiv.Name = "LabelOperacionDiv"
        Me.LabelOperacionDiv.Size = New System.Drawing.Size(0, 13)
        Me.LabelOperacionDiv.TabIndex = 15
        '
        'LabelOperacionMult
        '
        Me.LabelOperacionMult.AutoSize = True
        Me.LabelOperacionMult.Enabled = False
        Me.LabelOperacionMult.Location = New System.Drawing.Point(130, 162)
        Me.LabelOperacionMult.Name = "LabelOperacionMult"
        Me.LabelOperacionMult.Size = New System.Drawing.Size(0, 13)
        Me.LabelOperacionMult.TabIndex = 14
        '
        'LabelOperacionResta
        '
        Me.LabelOperacionResta.AutoSize = True
        Me.LabelOperacionResta.Enabled = False
        Me.LabelOperacionResta.Location = New System.Drawing.Point(130, 105)
        Me.LabelOperacionResta.Name = "LabelOperacionResta"
        Me.LabelOperacionResta.Size = New System.Drawing.Size(0, 13)
        Me.LabelOperacionResta.TabIndex = 13
        '
        'LabelOperacionSuma
        '
        Me.LabelOperacionSuma.AutoSize = True
        Me.LabelOperacionSuma.Enabled = False
        Me.LabelOperacionSuma.Location = New System.Drawing.Point(130, 45)
        Me.LabelOperacionSuma.Name = "LabelOperacionSuma"
        Me.LabelOperacionSuma.Size = New System.Drawing.Size(0, 13)
        Me.LabelOperacionSuma.TabIndex = 12
        '
        'TextBoxRaiz
        '
        Me.TextBoxRaiz.Enabled = False
        Me.TextBoxRaiz.Location = New System.Drawing.Point(573, 155)
        Me.TextBoxRaiz.Name = "TextBoxRaiz"
        Me.TextBoxRaiz.Size = New System.Drawing.Size(131, 20)
        Me.TextBoxRaiz.TabIndex = 11
        '
        'TextBoxPotencia
        '
        Me.TextBoxPotencia.Enabled = False
        Me.TextBoxPotencia.Location = New System.Drawing.Point(573, 102)
        Me.TextBoxPotencia.Name = "TextBoxPotencia"
        Me.TextBoxPotencia.Size = New System.Drawing.Size(131, 20)
        Me.TextBoxPotencia.TabIndex = 10
        '
        'TextBoxDivision
        '
        Me.TextBoxDivision.Enabled = False
        Me.TextBoxDivision.Location = New System.Drawing.Point(573, 38)
        Me.TextBoxDivision.Name = "TextBoxDivision"
        Me.TextBoxDivision.Size = New System.Drawing.Size(131, 20)
        Me.TextBoxDivision.TabIndex = 9
        '
        'TextBoxMultiplicacion
        '
        Me.TextBoxMultiplicacion.Enabled = False
        Me.TextBoxMultiplicacion.Location = New System.Drawing.Point(198, 159)
        Me.TextBoxMultiplicacion.Name = "TextBoxMultiplicacion"
        Me.TextBoxMultiplicacion.Size = New System.Drawing.Size(110, 20)
        Me.TextBoxMultiplicacion.TabIndex = 8
        '
        'TextBoxResta
        '
        Me.TextBoxResta.Enabled = False
        Me.TextBoxResta.Location = New System.Drawing.Point(198, 98)
        Me.TextBoxResta.Name = "TextBoxResta"
        Me.TextBoxResta.Size = New System.Drawing.Size(110, 20)
        Me.TextBoxResta.TabIndex = 7
        '
        'TextBoxSuma
        '
        Me.TextBoxSuma.Enabled = False
        Me.TextBoxSuma.Location = New System.Drawing.Point(198, 38)
        Me.TextBoxSuma.Name = "TextBoxSuma"
        Me.TextBoxSuma.Size = New System.Drawing.Size(110, 20)
        Me.TextBoxSuma.TabIndex = 6
        '
        'LabelRaiz
        '
        Me.LabelRaiz.AutoSize = True
        Me.LabelRaiz.Location = New System.Drawing.Point(442, 162)
        Me.LabelRaiz.Name = "LabelRaiz"
        Me.LabelRaiz.Size = New System.Drawing.Size(28, 13)
        Me.LabelRaiz.TabIndex = 5
        Me.LabelRaiz.Text = "Raiz"
        '
        'LabelPotencia
        '
        Me.LabelPotencia.AutoSize = True
        Me.LabelPotencia.Location = New System.Drawing.Point(442, 105)
        Me.LabelPotencia.Name = "LabelPotencia"
        Me.LabelPotencia.Size = New System.Drawing.Size(49, 13)
        Me.LabelPotencia.TabIndex = 4
        Me.LabelPotencia.Text = "Potencia"
        '
        'LabelDivision
        '
        Me.LabelDivision.AutoSize = True
        Me.LabelDivision.Location = New System.Drawing.Point(442, 45)
        Me.LabelDivision.Name = "LabelDivision"
        Me.LabelDivision.Size = New System.Drawing.Size(44, 13)
        Me.LabelDivision.TabIndex = 3
        Me.LabelDivision.Text = "División"
        '
        'LabelMultiplicacion
        '
        Me.LabelMultiplicacion.AutoSize = True
        Me.LabelMultiplicacion.Location = New System.Drawing.Point(50, 162)
        Me.LabelMultiplicacion.Name = "LabelMultiplicacion"
        Me.LabelMultiplicacion.Size = New System.Drawing.Size(71, 13)
        Me.LabelMultiplicacion.TabIndex = 2
        Me.LabelMultiplicacion.Text = "Multiplicación"
        '
        'LabelResta
        '
        Me.LabelResta.AutoSize = True
        Me.LabelResta.Location = New System.Drawing.Point(50, 105)
        Me.LabelResta.Name = "LabelResta"
        Me.LabelResta.Size = New System.Drawing.Size(35, 13)
        Me.LabelResta.TabIndex = 1
        Me.LabelResta.Text = "Resta"
        '
        'LabelSuma
        '
        Me.LabelSuma.AutoSize = True
        Me.LabelSuma.Location = New System.Drawing.Point(50, 45)
        Me.LabelSuma.Name = "LabelSuma"
        Me.LabelSuma.Size = New System.Drawing.Size(34, 13)
        Me.LabelSuma.TabIndex = 0
        Me.LabelSuma.Text = "Suma"
        '
        'PictureBoxUML
        '
        Me.PictureBoxUML.Image = CType(resources.GetObject("PictureBoxUML.Image"), System.Drawing.Image)
        Me.PictureBoxUML.Location = New System.Drawing.Point(362, 19)
        Me.PictureBoxUML.Name = "PictureBoxUML"
        Me.PictureBoxUML.Size = New System.Drawing.Size(179, 166)
        Me.PictureBoxUML.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxUML.TabIndex = 7
        Me.PictureBoxUML.TabStop = False
        '
        'Operadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBoxCalcular)
        Me.Controls.Add(Me.GroupBoxResultados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Operadores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OPERADORES ARÍTMETICOS"
        Me.GroupBoxCalcular.ResumeLayout(False)
        Me.GroupBoxCalcular.PerformLayout()
        Me.GroupBoxResultados.ResumeLayout(False)
        Me.GroupBoxResultados.PerformLayout()
        CType(Me.PictureBoxUML, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxCalcular As GroupBox
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents ButtonCalcular As Button
    Friend WithEvents ButtonNuevo As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LabelNúmero2 As Label
    Friend WithEvents LabelNumero1 As Label
    Friend WithEvents GroupBoxResultados As GroupBox
    Friend WithEvents TextBoxRaiz As TextBox
    Friend WithEvents TextBoxPotencia As TextBox
    Friend WithEvents TextBoxDivision As TextBox
    Friend WithEvents TextBoxMultiplicacion As TextBox
    Friend WithEvents TextBoxResta As TextBox
    Friend WithEvents TextBoxSuma As TextBox
    Friend WithEvents LabelRaiz As Label
    Friend WithEvents LabelPotencia As Label
    Friend WithEvents LabelDivision As Label
    Friend WithEvents LabelMultiplicacion As Label
    Friend WithEvents LabelResta As Label
    Friend WithEvents LabelSuma As Label
    Friend WithEvents LabelOperacionRaiz As Label
    Friend WithEvents LabelOperacionPot As Label
    Friend WithEvents LabelOperacionDiv As Label
    Friend WithEvents LabelOperacionMult As Label
    Friend WithEvents LabelOperacionResta As Label
    Friend WithEvents LabelOperacionSuma As Label
    Friend WithEvents PictureBoxUML As PictureBox
    Friend WithEvents ToolTipUML As ToolTip
End Class
