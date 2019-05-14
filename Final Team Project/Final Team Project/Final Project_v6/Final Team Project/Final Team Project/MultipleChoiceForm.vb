Public Class MultipleChoiceForm
    Dim intTimer2 As Integer

    Private Sub tmrQTImer2_Tick(sender As Object, e As EventArgs) Handles tmrQTImer2.Tick
        intTimer2 += 1
    End Sub

    Private Sub MultipleChoiceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrQTImer2.Enabled = True

        radAnswer1.Checked = False
        radAnswer2.Checked = False
        radAnswer3.Checked = False
        radAnswer4.Checked = False

        ' Read the next five lines of the file
        myQuestions.strQuestion = readingFile.ReadLine()
        myQuestions.strCorrect = readingFile.ReadLine()
        myQuestions.strWrong1 = readingFile.ReadLine()
        myQuestions.strWrong2 = readingFile.ReadLine()
        myQuestions.strWrong3 = readingFile.ReadLine()

        ' Use the file info the fill in the question and the answers given
        lblQuestion.Text = myQuestions.strQuestion
        radAnswer1.Text = myQuestions.strCorrect
        radAnswer2.Text = myQuestions.strWrong1
        radAnswer3.Text = myQuestions.strWrong2
        radAnswer4.Text = myQuestions.strWrong3
    End Sub

    Sub Timer()
        If intTimer2 = 10 Then
            tmrQTImer2.Enabled = False
            MessageBox.Show("Time is up.")
            Me.Close()
        End If
    End Sub

    ' Check to see if the selected answer is correct or incorrect
    Function ValidateAnswer() As Boolean
        If radAnswer1.Checked = True Then
            ' If it's correct, return true
            MessageBox.Show("Correct!")
            Return True
        ElseIf radAnswer2.Checked = True Then
            ' If it's incorrect, return false
            MessageBox.Show("That is incorrect. You have to stay back.")
            Return False
        ElseIf radAnswer3.Checked = True Then
            ' If it's incorrect, return false
            MessageBox.Show("That is incorrect. You have to stay back.")
            Return False
        ElseIf radAnswer3.Checked = True Then
            ' If it's incorrect, return false
            MessageBox.Show("That is incorrect. You have to stay back.")
            Return False
        End If

        Return True
    End Function

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        ' Check to see if the answer is correct
        If ValidateAnswer() Then
            ' 0 = Correct
            intValidation = 0
        Else
            ' 1 = Incorrect
            intValidation = 1
        End If

        ' Close the form
        Me.Close()
    End Sub
End Class