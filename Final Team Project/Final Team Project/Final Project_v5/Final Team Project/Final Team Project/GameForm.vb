Imports System.IO

Public Class GameForm
    Dim intDice1 As Integer
    Dim intPlayer1 As Integer
    Dim intPlayer2 As Integer
    Dim intPlayer3 As Integer
    Dim intPlayer4 As Integer
    Dim rand As New Random
    Dim strFileName1 As String
    Dim strQuestion1 As String
    Dim strAnswer As String

    Private Sub GameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Play the game audio.
        ' My.Computer.Audio.Play("E:\Final Project_v5\Final Team Project\Undertale OST 021 - Dogsong.wav", AudioPlayMode.BackgroundLoop)

        ' Open the file you created/selected.
        readingFile = File.OpenText(strFileName)
    End Sub

    Sub MultipleChoice1()
        ' Display the Multiple Choice form
        MultipleChoiceForm.Show()

        ' If the answer is correct, let the player move
        If intValidation = 0 Then
            intPlayer1 += intDice1
        ElseIf intValidation = 1 Then
            ' If the answer is incorrect, don't move the player
            intPlayer1 = intPlayer1
        End If
    End Sub

    Sub ShortAnswer1()
        ' Read the next three lines of the file
        readingFile.ReadLine()
        readingFile.ReadLine()
        readingFile.ReadLine()

        ' Display the question to the user and allow them to answer
        strAnswer = InputBox(myQuestions.strQuestion1)

        ' If the answer is correct, let the player move
        If strAnswer = myQuestions.strAnswer Then
            MessageBox.Show("Correct!")
            intPlayer1 += intDice1
            ' If it's incorrect, don't let the player move
        Else
            MessageBox.Show("That is incorrect.")
            intPlayer1 = intPlayer1
        End If
    End Sub

    Sub DiceImage()
        If intDice1 = 1 Then
            picDice1.Image = My.Resources.Die1
        ElseIf intDice1 = 2 Then
            picDice1.Image = My.Resources.Die2
        ElseIf intDice1 = 3 Then
            picDice1.Image = My.Resources.Die3
        ElseIf intDice1 = 4 Then
            picDice1.Image = My.Resources.Die4
        ElseIf intDice1 = 5 Then
            picDice1.Image = My.Resources.Die5
        ElseIf intDice1 = 6 Then
            picDice1.Image = My.Resources.Die6
        End If
    End Sub

    Sub Player1()

        ' Place Player 1 on the game board.

        If intPlayer1 = 0 Then
            picBrad.Visible = True
        ElseIf intPlayer1 = 1 Then
            picBrad.Location = New Point(93, 131)
            picBrad.BackColor = Color.HotPink
        ElseIf intPlayer1 = 2 Then
            picBrad.Location = New Point(191, 145)
            picBrad.BackColor = Color.Orange
        ElseIf intPlayer1 = 3 Then
            picBrad.Location = New Point(292, 125)
            picBrad.BackColor = Color.Cyan
        ElseIf intPlayer1 = 4 Then
            picBrad.Location = New Point(387, 142)
            picBrad.BackColor = Color.Red
        ElseIf intPlayer1 = 5 Then
            picBrad.Location = New Point(491, 128)
            picBrad.BackColor = Color.Lime
        ElseIf intPlayer1 = 6 Then
            picBrad.Location = New Point(590, 158)
            picBrad.BackColor = Color.Turquoise
        ElseIf intPlayer1 = 7 Then
            picBrad.Location = New Point(684, 133)
            picBrad.BackColor = Color.MediumSlateBlue
        ElseIf intPlayer1 = 8 Then
            picBrad.Location = New Point(784, 173)
            picBrad.BackColor = Color.LightCoral
        ElseIf intPlayer1 = 9 Then
            picBrad.Location = New Point(752, 285)
            picBrad.BackColor = Color.LimeGreen
        ElseIf intPlayer1 = 10 Then
            picBrad.Location = New Point(642, 304)
            picBrad.BackColor = Color.Khaki
        ElseIf intPlayer1 = 11 Then
            picBrad.Location = New Point(534, 302)
            picBrad.BackColor = Color.Silver
        ElseIf intPlayer1 = 12 Then
            picBrad.Location = New Point(426, 272)
            picBrad.BackColor = Color.LightSalmon
        ElseIf intPlayer1 = 13 Then
            picBrad.Location = New Point(331, 293)
            picBrad.BackColor = Color.Goldenrod
        ElseIf intPlayer1 = 14 Then
            picBrad.Location = New Point(227, 297)
            picBrad.BackColor = Color.Magenta
        ElseIf intPlayer1 = 15 Then
            picBrad.Location = New Point(124, 278)
            picBrad.BackColor = Color.CornflowerBlue
        ElseIf intPlayer1 = 16 Then
            picBrad.Location = New Point(29, 342)
            picBrad.BackColor = Color.Blue
        ElseIf intPlayer1 = 17 Then
            picBrad.Location = New Point(54, 447)
            picBrad.BackColor = Color.LightBlue
        ElseIf intPlayer1 = 18 Then
            picBrad.Location = New Point(152, 462)
            picBrad.BackColor = Color.SpringGreen
        ElseIf intPlayer1 = 19 Then
            picBrad.Location = New Point(263, 446)
            picBrad.BackColor = Color.LightGreen
        ElseIf intPlayer1 = 20 Then
            picBrad.Location = New Point(358, 460)
            picBrad.BackColor = Color.MediumOrchid
        ElseIf intPlayer1 = 21 Then
            picBrad.Location = New Point(453, 425)
            picBrad.BackColor = Color.GreenYellow
        ElseIf intPlayer1 = 22 Then
            picBrad.Location = New Point(556, 458)
            picBrad.BackColor = Color.OliveDrab
        ElseIf intPlayer1 = 23 Then
            picBrad.Location = New Point(660, 465)
            picBrad.BackColor = Color.Salmon
        ElseIf intPlayer1 = 24 Then
            picBrad.Location = New Point(769, 441)
            picBrad.BackColor = Color.SandyBrown
        ElseIf intPlayer1 = 25 Then
            picBrad.Location = New Point(821, 562)
            picBrad.BackColor = Color.Yellow
        ElseIf intPlayer1 = 26 Then
            picBrad.Location = New Point(711, 611)
            picBrad.BackColor = Color.SlateBlue
        ElseIf intPlayer1 = 27 Then
            picBrad.Location = New Point(591, 605)
            picBrad.BackColor = Color.Aqua
        ElseIf intPlayer1 = 28 Then
            picBrad.Location = New Point(475, 631)
            picBrad.BackColor = Color.PaleGoldenrod
        ElseIf intPlayer1 = 29 Then
            picBrad.Location = New Point(367, 595)
            picBrad.BackColor = Color.DarkRed
        ElseIf intPlayer1 = 30 Then
            picBrad.Location = New Point(256, 634)
            picBrad.BackColor = Color.BurlyWood
        ElseIf intPlayer1 >= 30 Then
            picBrad.Visible = False
            picFinish.Visible = True
            picFinish.BackgroundImage = My.Resources.player_11

            ' If Player 1 has won, then show a message and close the game.
            MessageBox.Show("Brad has won the game!!!")

            Me.Close()
            GameSelector.Close()
        End If
    End Sub

    Sub Player2()

        ' Place Player 2 on the game board.

        If intPlayer2 = 0 Then
            picZibner.Visible = True
        ElseIf intPlayer2 = 1 Then
            picZibner.Location = New Point(93, 131)
            picZibner.BackColor = Color.HotPink
        ElseIf intPlayer2 = 2 Then
            picZibner.Location = New Point(191, 145)
            picZibner.BackColor = Color.Orange
        ElseIf intPlayer2 = 3 Then
            picZibner.Location = New Point(292, 125)
            picZibner.BackColor = Color.Cyan
        ElseIf intPlayer2 = 4 Then
            picZibner.Location = New Point(387, 142)
            picZibner.BackColor = Color.Red
        ElseIf intPlayer2 = 5 Then
            picZibner.Location = New Point(491, 128)
            picZibner.BackColor = Color.Lime
        ElseIf intPlayer2 = 6 Then
            picZibner.Location = New Point(590, 158)
            picZibner.BackColor = Color.Turquoise
        ElseIf intPlayer2 = 7 Then
            picZibner.Location = New Point(684, 133)
            picZibner.BackColor = Color.MediumSlateBlue
        ElseIf intPlayer2 = 8 Then
            picZibner.Location = New Point(784, 173)
            picZibner.BackColor = Color.LightCoral
        ElseIf intPlayer2 = 9 Then
            picZibner.Location = New Point(752, 285)
            picZibner.BackColor = Color.LimeGreen
        ElseIf intPlayer2 = 10 Then
            picZibner.Location = New Point(642, 304)
            picZibner.BackColor = Color.Khaki
        ElseIf intPlayer2 = 11 Then
            picZibner.Location = New Point(534, 302)
            picZibner.BackColor = Color.Silver
        ElseIf intPlayer2 = 12 Then
            picZibner.Location = New Point(426, 272)
            picZibner.BackColor = Color.LightSalmon
        ElseIf intPlayer2 = 13 Then
            picZibner.Location = New Point(331, 293)
            picZibner.BackColor = Color.Goldenrod
        ElseIf intPlayer2 = 14 Then
            picZibner.Location = New Point(227, 297)
            picZibner.BackColor = Color.Magenta
        ElseIf intPlayer2 = 15 Then
            picZibner.Location = New Point(124, 278)
            picZibner.BackColor = Color.CornflowerBlue
        ElseIf intPlayer2 = 16 Then
            picZibner.Location = New Point(29, 342)
            picZibner.BackColor = Color.Blue
        ElseIf intPlayer2 = 17 Then
            picZibner.Location = New Point(54, 447)
            picZibner.BackColor = Color.LightBlue
        ElseIf intPlayer2 = 18 Then
            picZibner.Location = New Point(152, 462)
            picZibner.BackColor = Color.SpringGreen
        ElseIf intPlayer2 = 19 Then
            picZibner.Location = New Point(263, 446)
            picZibner.BackColor = Color.LightGreen
        ElseIf intPlayer2 = 20 Then
            picZibner.Location = New Point(358, 460)
            picZibner.BackColor = Color.MediumOrchid
        ElseIf intPlayer2 = 21 Then
            picZibner.Location = New Point(453, 425)
            picZibner.BackColor = Color.GreenYellow
        ElseIf intPlayer2 = 22 Then
            picZibner.Location = New Point(556, 458)
            picZibner.BackColor = Color.OliveDrab
        ElseIf intPlayer2 = 23 Then
            picZibner.Location = New Point(660, 465)
            picZibner.BackColor = Color.Salmon
        ElseIf intPlayer2 = 24 Then
            picZibner.Location = New Point(769, 441)
            picZibner.BackColor = Color.SandyBrown
        ElseIf intPlayer2 = 25 Then
            picZibner.Location = New Point(821, 562)
            picZibner.BackColor = Color.Yellow
        ElseIf intPlayer2 = 26 Then
            picZibner.Location = New Point(711, 611)
            picZibner.BackColor = Color.SlateBlue
        ElseIf intPlayer2 = 27 Then
            picZibner.Location = New Point(591, 605)
            picZibner.BackColor = Color.Aqua
        ElseIf intPlayer2 = 28 Then
            picZibner.Location = New Point(475, 631)
            picZibner.BackColor = Color.PaleGoldenrod
        ElseIf intPlayer2 = 29 Then
            picZibner.Location = New Point(367, 595)
            picZibner.BackColor = Color.DarkRed
        ElseIf intPlayer2 = 30 Then
            picZibner.Location = New Point(256, 634)
            picZibner.BackColor = Color.BurlyWood
        ElseIf intPlayer2 >= 30 Then
            picZibner.Visible = False
            picFinish.Visible = True
            picFinish.BackgroundImage = My.Resources.player_21

            ' If Player 2 has won, then show a message and close the game.
            MessageBox.Show("Zibner has won the game!!!")

            Me.Close()
            GameSelector.Close()
        End If
    End Sub

    Sub Player3()

        ' Place Player 3 on the game board.

        If intPlayer3 = 0 Then
            picJonnyIron.Visible = True
        ElseIf intPlayer3 = 1 Then
            picJonnyIron.Location = New Point(93, 131)
            picJonnyIron.BackColor = Color.HotPink
        ElseIf intPlayer3 = 2 Then
            picJonnyIron.Location = New Point(191, 145)
            picJonnyIron.BackColor = Color.Orange
        ElseIf intPlayer3 = 3 Then
            picJonnyIron.Location = New Point(292, 125)
            picJonnyIron.BackColor = Color.Cyan
        ElseIf intPlayer3 = 4 Then
            picJonnyIron.Location = New Point(387, 142)
            picJonnyIron.BackColor = Color.Red
        ElseIf intPlayer3 = 5 Then
            picJonnyIron.Location = New Point(491, 128)
            picJonnyIron.BackColor = Color.Lime
        ElseIf intPlayer3 = 6 Then
            picJonnyIron.Location = New Point(590, 158)
            picJonnyIron.BackColor = Color.Turquoise
        ElseIf intPlayer3 = 7 Then
            picJonnyIron.Location = New Point(684, 133)
            picJonnyIron.BackColor = Color.MediumSlateBlue
        ElseIf intPlayer3 = 8 Then
            picJonnyIron.Location = New Point(784, 173)
            picJonnyIron.BackColor = Color.LightCoral
        ElseIf intPlayer3 = 9 Then
            picJonnyIron.Location = New Point(752, 285)
            picJonnyIron.BackColor = Color.LimeGreen
        ElseIf intPlayer3 = 10 Then
            picJonnyIron.Location = New Point(642, 304)
            picJonnyIron.BackColor = Color.Khaki
        ElseIf intPlayer3 = 11 Then
            picJonnyIron.Location = New Point(534, 302)
            picJonnyIron.BackColor = Color.Silver
        ElseIf intPlayer3 = 12 Then
            picJonnyIron.Location = New Point(426, 272)
            picJonnyIron.BackColor = Color.LightSalmon
        ElseIf intPlayer3 = 13 Then
            picJonnyIron.Location = New Point(331, 293)
            picJonnyIron.BackColor = Color.Goldenrod
        ElseIf intPlayer3 = 14 Then
            picJonnyIron.Location = New Point(227, 297)
            picJonnyIron.BackColor = Color.Magenta
        ElseIf intPlayer3 = 15 Then
            picJonnyIron.Location = New Point(124, 278)
            picJonnyIron.BackColor = Color.CornflowerBlue
        ElseIf intPlayer3 = 16 Then
            picJonnyIron.Location = New Point(29, 342)
            picJonnyIron.BackColor = Color.Blue
        ElseIf intPlayer3 = 17 Then
            picJonnyIron.Location = New Point(54, 447)
            picJonnyIron.BackColor = Color.LightBlue
        ElseIf intPlayer3 = 18 Then
            picJonnyIron.Location = New Point(152, 462)
            picJonnyIron.BackColor = Color.SpringGreen
        ElseIf intPlayer3 = 19 Then
            picJonnyIron.Location = New Point(263, 446)
            picJonnyIron.BackColor = Color.LightGreen
        ElseIf intPlayer3 = 20 Then
            picJonnyIron.Location = New Point(358, 460)
            picJonnyIron.BackColor = Color.MediumOrchid
        ElseIf intPlayer3 = 21 Then
            picJonnyIron.Location = New Point(453, 425)
            picJonnyIron.BackColor = Color.GreenYellow
        ElseIf intPlayer3 = 22 Then
            picJonnyIron.Location = New Point(556, 458)
            picJonnyIron.BackColor = Color.OliveDrab
        ElseIf intPlayer3 = 23 Then
            picJonnyIron.Location = New Point(660, 465)
            picJonnyIron.BackColor = Color.Salmon
        ElseIf intPlayer3 = 24 Then
            picJonnyIron.Location = New Point(769, 441)
            picJonnyIron.BackColor = Color.SandyBrown
        ElseIf intPlayer3 = 25 Then
            picJonnyIron.Location = New Point(821, 562)
            picJonnyIron.BackColor = Color.Yellow
        ElseIf intPlayer3 = 26 Then
            picJonnyIron.Location = New Point(711, 611)
            picJonnyIron.BackColor = Color.SlateBlue
        ElseIf intPlayer3 = 27 Then
            picJonnyIron.Location = New Point(591, 605)
            picJonnyIron.BackColor = Color.Aqua
        ElseIf intPlayer3 = 28 Then
            picJonnyIron.Location = New Point(475, 631)
            picJonnyIron.BackColor = Color.PaleGoldenrod
        ElseIf intPlayer3 = 29 Then
            picJonnyIron.Location = New Point(367, 595)
            picJonnyIron.BackColor = Color.DarkRed
        ElseIf intPlayer3 = 30 Then
            picJonnyIron.Location = New Point(256, 634)
            picJonnyIron.BackColor = Color.BurlyWood
        ElseIf intPlayer3 >= 30 Then
            picJonnyIron.Visible = False
            picFinish.Visible = True
            picFinish.BackgroundImage = My.Resources.player_31

            ' If Player 3 has won, then show a message and close the game.
            MessageBox.Show("Jonny Iron has won the game!!!")

            Me.Close()
            GameSelector.Close()
        End If
    End Sub

    Sub Player4()

        ' Place Player 4 on the game board.

        If intPlayer4 = 0 Then
            picSquareUp.Visible = True
        ElseIf intPlayer4 = 1 Then
            picSquareUp.Location = New Point(93, 131)
            picSquareUp.BackColor = Color.HotPink
        ElseIf intPlayer4 = 2 Then
            picSquareUp.Location = New Point(191, 145)
            picSquareUp.BackColor = Color.Orange
        ElseIf intPlayer4 = 3 Then
            picSquareUp.Location = New Point(292, 125)
            picSquareUp.BackColor = Color.Cyan
        ElseIf intPlayer4 = 4 Then
            picSquareUp.Location = New Point(387, 142)
            picSquareUp.BackColor = Color.Red
        ElseIf intPlayer4 = 5 Then
            picSquareUp.Location = New Point(491, 128)
            picSquareUp.BackColor = Color.Lime
        ElseIf intPlayer4 = 6 Then
            picSquareUp.Location = New Point(590, 158)
            picSquareUp.BackColor = Color.Turquoise
        ElseIf intPlayer4 = 7 Then
            picSquareUp.Location = New Point(684, 133)
            picSquareUp.BackColor = Color.MediumSlateBlue
        ElseIf intPlayer4 = 8 Then
            picSquareUp.Location = New Point(784, 173)
            picSquareUp.BackColor = Color.LightCoral
        ElseIf intPlayer4 = 9 Then
            picSquareUp.Location = New Point(752, 285)
            picSquareUp.BackColor = Color.LimeGreen
        ElseIf intPlayer4 = 10 Then
            picSquareUp.Location = New Point(642, 304)
            picSquareUp.BackColor = Color.Khaki
        ElseIf intPlayer4 = 11 Then
            picSquareUp.Location = New Point(534, 302)
            picSquareUp.BackColor = Color.Silver
        ElseIf intPlayer4 = 12 Then
            picSquareUp.Location = New Point(426, 272)
            picSquareUp.BackColor = Color.LightSalmon
        ElseIf intPlayer4 = 13 Then
            picSquareUp.Location = New Point(331, 293)
            picSquareUp.BackColor = Color.Goldenrod
        ElseIf intPlayer4 = 14 Then
            picSquareUp.Location = New Point(227, 297)
            picSquareUp.BackColor = Color.Magenta
        ElseIf intPlayer4 = 15 Then
            picSquareUp.Location = New Point(124, 278)
            picSquareUp.BackColor = Color.CornflowerBlue
        ElseIf intPlayer4 = 16 Then
            picSquareUp.Location = New Point(29, 342)
            picSquareUp.BackColor = Color.Blue
        ElseIf intPlayer4 = 17 Then
            picSquareUp.Location = New Point(54, 447)
            picSquareUp.BackColor = Color.LightBlue
        ElseIf intPlayer4 = 18 Then
            picSquareUp.Location = New Point(152, 462)
            picSquareUp.BackColor = Color.SpringGreen
        ElseIf intPlayer4 = 19 Then
            picSquareUp.Location = New Point(263, 446)
            picSquareUp.BackColor = Color.LightGreen
        ElseIf intPlayer4 = 20 Then
            picSquareUp.Location = New Point(358, 460)
            picSquareUp.BackColor = Color.MediumOrchid
        ElseIf intPlayer4 = 21 Then
            picSquareUp.Location = New Point(453, 425)
            picSquareUp.BackColor = Color.GreenYellow
        ElseIf intPlayer4 = 22 Then
            picSquareUp.Location = New Point(556, 458)
            picSquareUp.BackColor = Color.OliveDrab
        ElseIf intPlayer4 = 23 Then
            picSquareUp.Location = New Point(660, 465)
            picSquareUp.BackColor = Color.Salmon
        ElseIf intPlayer4 = 24 Then
            picSquareUp.Location = New Point(769, 441)
            picSquareUp.BackColor = Color.SandyBrown
        ElseIf intPlayer4 = 25 Then
            picSquareUp.Location = New Point(821, 562)
            picSquareUp.BackColor = Color.Yellow
        ElseIf intPlayer4 = 26 Then
            picSquareUp.Location = New Point(711, 611)
            picSquareUp.BackColor = Color.SlateBlue
        ElseIf intPlayer4 = 27 Then
            picSquareUp.Location = New Point(591, 605)
            picSquareUp.BackColor = Color.Aqua
        ElseIf intPlayer4 = 28 Then
            picSquareUp.Location = New Point(475, 631)
            picSquareUp.BackColor = Color.PaleGoldenrod
        ElseIf intPlayer4 = 29 Then
            picSquareUp.Location = New Point(367, 595)
            picSquareUp.BackColor = Color.DarkRed
        ElseIf intPlayer4 = 30 Then
            picSquareUp.Location = New Point(256, 634)
            picSquareUp.BackColor = Color.BurlyWood
        ElseIf intPlayer4 >= 30 Then
            picSquareUp.Visible = False
            picFinish.Visible = True
            picFinish.BackgroundImage = My.Resources.player_41

            ' If Player 4 has won, then show a message and close the game.
            MessageBox.Show("Square Up has won the game!!!")

            Me.Close()
            GameSelector.Close()
        End If
    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        ' Roll the dice
        intDice1 = rand.Next(6) + 1

        ' Show what number the user rolled
        MessageBox.Show("You rolled a " & intDice1.ToString & "!")

        ' Call the sub that shows the picture of the dice rolled
        DiceImage()

        ' Read the first line of the file
        readingFile.ReadLine()

        ' If the game type is Multiple Choice, open the MC sub
        If myQuestions.intGameType = 0 Then
            MultipleChoice1()
        ElseIf myQuestions.intGameType = 1 Then
            ' If the game type is Short Answer, open the SA sub
            ShortAnswer1()
        End If

        ' If the player is on the same square as another, move them a square back
        If intPlayer1 = intPlayer2 Then
            intPlayer1 = intPlayer1 - 1
            MessageBox.Show("There can't be multiple players on the same space.")
        ElseIf intPlayer1 = intPlayer3 Then
            intPlayer1 = intPlayer1 - 1
            MessageBox.Show("There can't be multiple players on the same space.")
        ElseIf intPlayer1 = intPlayer4 Then
            intPlayer1 = intPlayer1 - 1
            MessageBox.Show("There can't be multiple players on the same space.")
        End If

        ' Find the place of the player on the board
        Player1()

        ' Allow the next player to roll
        btnRoll2.Enabled = True
        btnRoll.Enabled = False

    End Sub

    Private Sub btnRoll2_Click(sender As Object, e As EventArgs) Handles btnRoll2.Click
        intDice1 = rand.Next(6) + 1

        MessageBox.Show("You rolled a " & intDice1.ToString & "!")

        DiceImage()

        intPlayer2 += intDice1

        If intPlayer2 = intPlayer1 Then
            intPlayer2 = intPlayer2 - 1
            MessageBox.Show("There can't be multiple players on the same space.")
        ElseIf intPlayer2 = intPlayer3 Then
            intPlayer2 = intPlayer2 - 1
            MessageBox.Show("There can't be multiple players on the same space.")
        ElseIf intPlayer2 = intPlayer4 Then
            intPlayer2 = intPlayer2 - 1
            MessageBox.Show("There can't be multiple players on the same space.")
        End If

        Player2()

        ' Answer a question

        btnRoll3.Enabled = True
        btnRoll2.Enabled = False
    End Sub

    Private Sub btnRoll3_Click(sender As Object, e As EventArgs) Handles btnRoll3.Click
        intDice1 = rand.Next(6) + 1

        MessageBox.Show("You rolled a " & intDice1.ToString & "!")

        DiceImage()

        intPlayer3 += intDice1

        If intPlayer3 = intPlayer1 Then
            intPlayer3 = intPlayer3 - 1
            MessageBox.Show("There can't be multiple players on the same space.")
        ElseIf intPlayer3 = intPlayer2 Then
            intPlayer3 = intPlayer3 - 1
            MessageBox.Show("There can't be multiple players on the same space.")
        ElseIf intPlayer3 = intPlayer4 Then
            intPlayer3 = intPlayer3 - 1
            MessageBox.Show("There can't be multiple players on the same space.")
        End If

        Player3()

        ' Answer a question

        btnRoll4.Enabled = True
        btnRoll3.Enabled = False
    End Sub

    Private Sub btnRoll4_Click(sender As Object, e As EventArgs) Handles btnRoll4.Click
        intDice1 = rand.Next(6) + 1

        MessageBox.Show("You rolled a " & intDice1.ToString & "!")

        DiceImage()

        intPlayer4 += intDice1

        If intPlayer4 = intPlayer1 Then
            intPlayer4 = intPlayer4 - 1
            MessageBox.Show("There can't be multiple players on the same space.")
        ElseIf intPlayer4 = intPlayer2 Then
            intPlayer4 = intPlayer4 - 1
            MessageBox.Show("There can't be multiple players on the same space.")
        ElseIf intPlayer4 = intPlayer3 Then
            intPlayer4 = intPlayer4 - 1
            MessageBox.Show("There can't be multiple players on the same space.")
        End If

        Player4()

        ' Answer a question

        btnRoll4.Enabled = False
        btnRoll.Enabled = True
    End Sub
End Class