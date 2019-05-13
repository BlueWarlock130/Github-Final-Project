Imports System.IO

Module GameModule
    Public intText As Integer
    Public createFile As StreamWriter
    Public readingFile As StreamReader
    Public myQuestions As Questions
    Public strFileName As String
    Public intQuestionType As Integer
    Public intValidation As Integer

    Public Structure Questions
        ' Create a structure to hold the questions and the game type (Multiple Choice or Short Answer).

        Public intGameType As Integer

        Public strQuestion As String
        Public strCorrect As String
        Public strWrong1 As String
        Public strWrong2 As String
        Public strWrong3 As String

        Public strQuestion1 As String
        Public strAnswer As String
    End Structure

    Public Function NameForm()
        ' Create a file for the questions.

        strFileName = InputBox("Enter the file's name.")

        createFile = File.AppendText(strFileName)

        Return createFile
    End Function
    Public Function NumOfQuestion() As Integer
        ' Let the user input the number of questions.

        intText = InputBox("Enter Number of Questions You Want In The Game")

        ' If the number is not between 1 and 30, show an error message.
        If intText > 30 Then
            MessageBox.Show("Enter a number between 1 - 30")
        ElseIf intText <= 0 Then
            MessageBox.Show("Enter a number between 1 - 30")
        End If

        Return intText
    End Function
End Module
