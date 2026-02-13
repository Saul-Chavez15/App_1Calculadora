Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles botonMas.Click

        Dim Numero1 As Integer = Integer.Parse(num1.Text)
        Dim Numero2 As Integer = Integer.Parse(num2.Text)

        Dim resultado As Integer = Numero1 + Numero2

        Label6.Text = resultado.ToString()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles botonDivision.Click
        Dim Numero1 As Integer = Integer.Parse(num1.Text)
        Dim Numero2 As Integer = Integer.Parse(num2.Text)

        Dim resultado As Integer = Numero1 / Numero2

        Label6.Text = resultado.ToString

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles botonResta.Click

        Dim Numero1 As Integer = Integer.Parse(num1.Text)
        Dim Numero2 As Integer = Integer.Parse(num2.Text)

        Dim resultado As Integer = Numero1 - Numero2

        Label6.Text = resultado.ToString

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles botonMultiplicación.Click
        Dim Numero1 As Integer = Integer.Parse(num1.Text)
        Dim Numero2 As Integer = Integer.Parse(num2.Text)

        Dim resultado As Integer = Numero1 * Numero2

        Label6.Text = resultado.ToString

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Boton2.Click
        num1.Text = num1.Text & "2"
    End Sub

    Private Sub Boton1_Click(sender As Object, e As EventArgs) Handles Boton1.Click
        num1.Text = num1.Text & "1"
    End Sub

    Private Sub Boton0_Click(sender As Object, e As EventArgs) Handles Boton0.Click
        num1.Text = num1.Text & "0"

    End Sub

    Private Sub Boton3_Click(sender As Object, e As EventArgs) Handles Boton3.Click
        num1.Text = num1.Text & "3"
    End Sub

    Private Sub Boton4_Click(sender As Object, e As EventArgs) Handles Boton4.Click
        num1.Text = num1.Text & "4"
    End Sub

    Private Sub Boton5_Click(sender As Object, e As EventArgs) Handles Boton5.Click
        num1.Text = num1.Text & "5"
    End Sub

    Private Sub Boton6_Click(sender As Object, e As EventArgs) Handles Boton6.Click
        num1.Text = num1.Text & "6"
    End Sub

    Private Sub Boton7_Click(sender As Object, e As EventArgs) Handles Boton7.Click
        num1.Text = num1.Text & "7"
    End Sub

    Private Sub Boton8_Click(sender As Object, e As EventArgs) Handles Boton8.Click
        num1.Text = num1.Text & "8"
    End Sub

    Private Sub Boton9_Click(sender As Object, e As EventArgs) Handles Boton9.Click
        num1.Text = num1.Text & "9"
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        num1.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles num1.TextChanged

    End Sub
End Class
