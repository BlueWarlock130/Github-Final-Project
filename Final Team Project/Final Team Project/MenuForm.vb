Public Class MenuForm
    Private Sub MenuForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Are you sure you wish to exit the best game ever?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btnQuestions_Click(sender As Object, e As EventArgs) Handles btnQuestions.Click
        QuestionsForm.ShowDialog()
    End Sub
End Class
