Public Class FormUML
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub FormUML_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FormUML_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.Close()

    End Sub
End Class