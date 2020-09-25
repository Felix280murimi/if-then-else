Public Class Form1
    Private Sub btnDayOfTheWeek_Click(sender As Object, e As EventArgs) Handles btnDayOfTheWeek.Click
        Dim today As Integer
        today = Val(InputBox("Enter an interger in the range from 1 to 7"))
        If (today = 5) Then
            MessageBox.Show("Leo ni Furahi Day .MEMBERS DAY")
        ElseIf (today = 3) Then
            MessageBox.Show("Leo ni wednesday.LADIES NIGHT to Night")
        ElseIf (today = 7) Then
            MessageBox.Show("Leo ni Sunday.Praise and Glory To God")
        ElseIf (today > 7) Then
            MessageBox.Show("INVALID ENTRY")
        End If
        MessageBox.Show("Life Continues")
    End Sub
End Class
