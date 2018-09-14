Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.DoEvents()

        MessageBox.Show(Me, "Hello World!", "Hello World!", vbOK, vbInformation)

    End Sub
End Class
