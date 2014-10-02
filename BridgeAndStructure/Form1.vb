Public Class Form1

    Private Sub btbCross_Click(sender As Object, e As EventArgs) Handles btbCross.Click
        Dim strSecName As String = "Braden"
        Dim strNameGuess As String = Me.txtName.Text
        Dim strQuest As String = "To seek the holy grail"
        Dim strSecQuest As String = Me.txtQuest.Text
        Dim strColor As String = "red"
        Dim strSecColor As String = Me.txtColor.Text
        If strSecName = strNameGuess And strQuest = strSecQuest And strSecColor = strColor Then
            Me.lblFate.Text = "You may pass"
            Me.lblFate.Text = "You Die"
        End If
    End Sub
End Class
