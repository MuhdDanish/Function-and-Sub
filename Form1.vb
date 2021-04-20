Public Class Form1
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Papar1()
    End Sub

    Private Sub Papar1()
        Lbl1.Text = "Nama"
    End Sub
    Private Sub Papar()
        Dim strInsert As String
        strInsert = TextBox1.Text
        Lbl2.Text = strInsert
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Papar()
    End Sub

    Private Function Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        Lbl3.Text = "Umur"
    End Function

    Private Function Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        Dim strInsert As String
        strInsert = TextBox2.Text
        Lbl4.Text = strInsert
    End Function
End Class
