Public Class Operadores
    Dim num1, num2 As Integer
    Dim suma, resta, mult As Integer
    Dim div, potencia, raiz As Double

    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click
        suma = num1 + num2
        resta = num1 - num2
        mult = num1 * num2
        div = num1 / num2
        potencia = num1 ^ num2
        raiz = num1 ^ (1 / num2)

        TextBoxSuma.Text = suma
        TextBoxResta.Text = resta
        TextBoxMultiplicacion.Text = mult
        TextBoxDivision.Text = div
        TextBoxPotencia.Text = potencia
        TextBoxRaiz.Text = raiz

        LabelOperacionSuma.Text = TextBox1.Text & "+" & TextBox2.Text
        LabelOperacionResta.Text = TextBox1.Text & "-" & TextBox2.Text
        LabelOperacionMult.Text = TextBox1.Text & "*" & TextBox2.Text
        LabelOperacionDiv.Text = TextBox1.Text & "/" & TextBox2.Text
        LabelOperacionPot.Text = TextBox1.Text & "^" & TextBox2.Text
        LabelOperacionRaiz.Text = TextBox1.Text & "^(1/" & TextBox2.Text & ")"

    End Sub

    Private Sub PictureBoxUML_Click(sender As Object, e As EventArgs) Handles PictureBoxUML.Click
        FormUML.Show()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        num2 = Val(TextBox2.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        num1 = Val(TextBox1.Text)
    End Sub

    Private Sub ButtonNuevo_Click(sender As Object, e As EventArgs) Handles ButtonNuevo.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBoxSuma.Clear()
        TextBoxResta.Clear()
        TextBoxMultiplicacion.Clear()
        TextBoxDivision.Clear()
        TextBoxPotencia.Clear()
        TextBoxRaiz.Clear()

        LabelOperacionSuma.Text = ""
        LabelOperacionResta.Text = ""
        LabelOperacionMult.Text = ""
        LabelOperacionDiv.Text = ""
        LabelOperacionPot.Text = ""
        LabelOperacionRaiz.Text = ""

    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ToolTipUML.IsBalloon = True
        Me.ToolTipUML.SetToolTip(PictureBoxUML, "Diagrama UML")
    End Sub
End Class
