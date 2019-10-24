Public Class Q10

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mark1 As Integer
        Dim mark2 As Integer
        Dim mark3 As Integer
        Dim avg_mark As Double
        Dim status As String
        mark1 = Val(TextBox1.Text)
        mark2 = Val(TextBox2.Text)
        mark3 = Val(TextBox3.Text)
        avg_mark = (mark1 + mark2 + mark3) / 3
        If (avg_mark >= 81) And (avg_mark <= 100) Then
            status = "A (distinction)"
        ElseIf (avg_mark >= 61) And (avg_mark < 81) Then
            status = "B (good)"
        ElseIf (avg_mark >= 51) And (avg_mark < 61) Then
            status = "C (satisfaction)"
        ElseIf (avg_mark >= 40) And (avg_mark < 51) Then
            status = "D (pass)"
        ElseIf (avg_mark >= 0) And (avg_mark < 40) Then
            status = "F (fail)"


        End If
        TextBox4.Text = (avg_mark)
        TextBox5.Text = status
    End Sub
End Class
