Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text.Trim)
        Label2.Text = TextBox1.Text.Trim
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim word As String = ListBox1.Text
        ListBox1.Items.Add(TextBox1.Text.Trim) = True Then
            MessageBox.Show(" item already exist") 'duplication not allowed


    End Sub
End Class
