Public Class vv
    Dim intDice1 As Integer
    Dim intPlayer1 As Integer
    Dim intPlayer2 As Integer
    Dim intPlayer3 As Integer
    Dim intPlayer4 As Integer
    Dim rand As New Random

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
        If intPlayer1 = 1 Then
            Shape1.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer1 = 2 Then
            Shape2.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer1 = 3 Then
            Shape3.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer1 = 4 Then
            Shape4.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer1 = 5 Then
            Shape5.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer1 = 6 Then
            Shape6.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer1 = 7 Then
            Shape7.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer1 = 8 Then
            Shape8.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer1 = 9 Then
            Shape9.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer1 = 10 Then
            Shape10.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer1 = 11 Then
            Shape11.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer1 = 12 Then
            Shape12.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer1 = 13 Then
            Shape13.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer1 = 14 Then
            Shape14.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer1 = 15 Then
            Shape15.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer1 = 16 Then
            Shape16.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer1 = 17 Then
            Shape17.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer1 = 18 Then
            Shape18.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer1 = 19 Then
            Shape19.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer1 = 20 Then
            Shape20.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer1 = 21 Then
            Shape21.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer1 = 22 Then
            Shape22.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer1 = 23 Then
            Shape23.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer1 = 24 Then
            Shape24.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer1 = 25 Then
            Shape25.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer1 = 26 Then
            Shape26.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer1 = 27 Then
            Shape27.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer1 = 28 Then
            Shape28.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer1 = 29 Then
            Shape29.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer1 = 30 Then
            Shape30.BackgroundImage = My.Resources.player_11
        End If
    End Sub

    Sub Player2()
        If intPlayer2 = 1 Then
            Shape1.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer2 = 2 Then
            Shape2.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer2 = 3 Then
            Shape3.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer2 = 4 Then
            Shape4.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer2 = 5 Then
            Shape5.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer2 = 6 Then
            Shape6.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer2 = 7 Then
            Shape7.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer2 = 8 Then
            Shape8.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer2 = 9 Then
            Shape9.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer2 = 10 Then
            Shape10.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer2 = 11 Then
            Shape11.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer2 = 12 Then
            Shape12.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer2 = 13 Then
            Shape13.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer2 = 14 Then
            Shape14.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer2 = 15 Then
            Shape15.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer2 = 16 Then
            Shape16.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer2 = 17 Then
            Shape17.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer2 = 18 Then
            Shape18.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer2 = 19 Then
            Shape19.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer2 = 20 Then
            Shape20.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer2 = 21 Then
            Shape21.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer2 = 22 Then
            Shape22.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer2 = 23 Then
            Shape23.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer2 = 24 Then
            Shape24.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer2 = 25 Then
            Shape25.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer2 = 26 Then
            Shape26.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer2 = 27 Then
            Shape27.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer2 = 28 Then
            Shape28.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer2 = 29 Then
            Shape29.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer2 = 30 Then
            Shape30.BackgroundImage = My.Resources.player_11
        End If
    End Sub

    Sub Player3()
        If intPlayer3 = 1 Then
            Shape1.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer3 = 2 Then
            Shape2.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer3 = 3 Then
            Shape3.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer3 = 4 Then
            Shape4.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer3 = 5 Then
            Shape5.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer3 = 6 Then
            Shape6.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer3 = 7 Then
            Shape7.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer3 = 8 Then
            Shape8.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer3 = 9 Then
            Shape9.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer3 = 10 Then
            Shape10.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer3 = 11 Then
            Shape11.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer3 = 12 Then
            Shape12.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer3 = 13 Then
            Shape13.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer3 = 14 Then
            Shape14.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer3 = 15 Then
            Shape15.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer3 = 16 Then
            Shape16.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer3 = 17 Then
            Shape17.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer3 = 18 Then
            Shape18.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer3 = 19 Then
            Shape19.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer3 = 20 Then
            Shape20.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer3 = 21 Then
            Shape21.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer3 = 22 Then
            Shape22.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer3 = 23 Then
            Shape23.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer3 = 24 Then
            Shape24.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer3 = 25 Then
            Shape25.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer3 = 26 Then
            Shape26.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer3 = 27 Then
            Shape27.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer3 = 28 Then
            Shape28.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer3 = 29 Then
            Shape29.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer3 = 30 Then
            Shape30.BackgroundImage = My.Resources.player_11
        End If

    End Sub

    Sub Player4()
        If intPlayer4 = 1 Then
            Shape1.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer4 = 2 Then
            Shape2.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer4 = 3 Then
            Shape3.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer4 = 4 Then
            Shape4.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer4 = 5 Then
            Shape5.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer4 = 6 Then
            Shape6.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer4 = 7 Then
            Shape7.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer4 = 8 Then
            Shape8.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer4 = 9 Then
            Shape9.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer4 = 10 Then
            Shape10.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer4 = 11 Then
            Shape11.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer4 = 12 Then
            Shape12.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer4 = 13 Then
            Shape13.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer4 = 14 Then
            Shape14.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer4 = 15 Then
            Shape15.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer4 = 16 Then
            Shape16.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer4 = 17 Then
            Shape17.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer4 = 18 Then
            Shape18.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer4 = 19 Then
            Shape19.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer4 = 20 Then
            Shape20.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer4 = 21 Then
            Shape21.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer4 = 22 Then
            Shape22.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer4 = 23 Then
            Shape23.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer4 = 24 Then
            Shape24.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer4 = 25 Then
            Shape25.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer4 = 26 Then
            Shape26.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer4 = 27 Then
            Shape27.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer4 = 28 Then
            Shape28.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer4 = 29 Then
            Shape29.BackgroundImage = My.Resources.player_11
        ElseIf intPlayer4 = 30 Then
            Shape30.BackgroundImage = My.Resources.player_11
        End If

    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        intDice1 = rand.Next(7) + 1

        MessageBox.Show("You rolled a " & intDice1.ToString & "!")

        DiceImage()

        intPlayer1 += intDice1

        Player1()

        ' Answer a question

        btnRoll2.Enabled = True
        btnRoll.Enabled = False

    End Sub

    Private Sub btnRoll2_Click(sender As Object, e As EventArgs) Handles btnRoll2.Click
        intDice1 = rand.Next(7) + 1

        MessageBox.Show("You rolled a " & intDice1.ToString & "!")

        DiceImage()

        intPlayer2 += intDice1

        Player2()

        ' Answer a question

        btnRoll3.Enabled = True
        btnRoll2.Enabled = False
    End Sub

    Private Sub btnRoll3_Click(sender As Object, e As EventArgs) Handles btnRoll3.Click
        intDice1 = rand.Next(7) + 1

        MessageBox.Show("You rolled a " & intDice1.ToString & "!")

        DiceImage()

        intPlayer3 += intDice1

        Player3()

        ' Answer a question

        btnRoll4.Enabled = True
        btnRoll3.Enabled = False
    End Sub

    Private Sub btnRoll4_Click(sender As Object, e As EventArgs) Handles btnRoll4.Click
        intDice1 = rand.Next(7) + 1

        MessageBox.Show("You rolled a " & intDice1.ToString & "!")

        DiceImage()

        intPlayer4 += intDice1

        Player4()

        ' Answer a question

        btnRoll4.Enabled = True
        btnRoll.Enabled = False
    End Sub
End Class