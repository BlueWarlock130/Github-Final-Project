Public Class GameSelector
    Dim frmQuestion As New QuestionForm1
    Private Sub btnCreate_Click(sender As Object, e As EventArgs)
        Dim strText As String
        Dim strName As String
        strName = InputBox("Name the Game")
        strText = InputBox("Enter Number of Questions You Want In The Game")
    End Sub
End Class