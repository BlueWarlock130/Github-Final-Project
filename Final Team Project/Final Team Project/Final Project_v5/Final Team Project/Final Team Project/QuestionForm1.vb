Imports System.IO

Public Class QuestionForm1
    Dim intQuestionNumber As Integer
    Dim strQuestionType As String

    Private Sub QuestionForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Enter the type of questions you would like to use for the game.
        strQuestionType = InputBox("Which questions would you like to use: Multiple Choice or Short Answer?")

        ' If the user chooses Multiple Choice:
        If strQuestionType = "Multiple Choice" Then
            ' Disable the Short Answer tab
            tbQuestionShort.Enabled = False
            ' Enter the game type (MC or SA) into the file to check it later.
            myQuestions.intGameType = 0
            createFile.WriteLine(myQuestions.intGameType)
        ElseIf strQuestionType = "Short Answer" Then
            ' If the user chooses Short Answer:
            ' Disable the Multiple Choice tab
            tbQuestionMultiple.Enabled = False
            ' Enter the game type (MC or SA) into the file to check it later.
            myQuestions.intGameType = 1
            createFile.WriteLine(myQuestions.intGameType)
        End If

        ' Show directions for entering questions.
        MessageBox.Show("Enter your question, then save it and choose ''Next Question''. Once all questions are entered, the game will start!")
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Clear all the inputs for the next question.
        txtQuestion.Clear()
        txtCorrect.Clear()
        txtWrong1.Clear()
        txtWrong2.Clear()
        txtWrong3.Clear()
        txtShortQuestion.Clear()
        txtAnswer.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Enter the question information into the structure.
        myQuestions.strQuestion = txtQuestion.Text
        myQuestions.strCorrect = txtCorrect.Text
        myQuestions.strWrong1 = txtWrong1.Text
        myQuestions.strWrong2 = txtWrong2.Text
        myQuestions.strWrong3 = txtWrong3.Text

        myQuestions.strQuestion1 = txtShortQuestion.Text
        myQuestions.strAnswer = txtAnswer.Text

        ' If the question type is Multiple Choice, write that tab's lines to the file.
        If txtShortQuestion.Text = String.Empty Then
            createFile.WriteLine(myQuestions.strQuestion)
            createFile.WriteLine(myQuestions.strCorrect)
            createFile.WriteLine(myQuestions.strWrong1)
            createFile.WriteLine(myQuestions.strWrong2)
            createFile.WriteLine(myQuestions.strWrong3)
        Else
            ' If the question type is Short Answer, write that tab's lines to the file.
            createFile.WriteLine(myQuestions.strQuestion1)
            createFile.WriteLine(myQuestions.strAnswer)
        End If

        ' Show message saying the questions have been saved
        MessageBox.Show("Your question has been saved.")

        ' Count the number of questions and put it into the label
        intQuestionNumber += 1
        lblQuestionNumber.Text = intQuestionNumber.ToString

        ' If the all the questions have been entered, show a message and close the file and form.
        If intQuestionNumber = intText Then
            MessageBox.Show("You've entered all of your questions.")
            createFile.Close()
            Me.Close()
        End If
    End Sub
End Class
