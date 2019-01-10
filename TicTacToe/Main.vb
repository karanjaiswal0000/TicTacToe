Public Class Home
    Private I As Integer
    Private X As Integer
    Private O As Integer
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        PlayerOScoreLabel.Text = ""
        PlayerXScoreLabel.Text = ""
    End Sub
    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        Hide()
    End Sub
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        End
    End Sub
    Private Sub SinglePlayerMenuItem_Click(sender As Object, e As EventArgs) Handles SinglePlayerMenuItem.Click
        I = 1 : X = 0 : O = 0
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
        Button1.BackColor = Color.Transparent
        Button2.BackColor = Color.Transparent
        Button3.BackColor = Color.Transparent
        Button4.BackColor = Color.Transparent
        Button5.BackColor = Color.Transparent
        Button6.BackColor = Color.Transparent
        Button7.BackColor = Color.Transparent
        Button8.BackColor = Color.Transparent
        Button9.BackColor = Color.Transparent
        StatusLabel.ForeColor = Color.Black
        StatusLabel.Text = ""
        PlayerXScoreLabel.Text = X
        PlayerOScoreLabel.Text = O
    End Sub
    Private Sub MultiPlayerMenuItem_Click(sender As Object, e As EventArgs) Handles MultiPlayerMenuItem.Click
        I = 1 : X = 0 : O = 0
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
        Button1.BackColor = Color.Transparent
        Button2.BackColor = Color.Transparent
        Button3.BackColor = Color.Transparent
        Button4.BackColor = Color.Transparent
        Button5.BackColor = Color.Transparent
        Button6.BackColor = Color.Transparent
        Button7.BackColor = Color.Transparent
        Button8.BackColor = Color.Transparent
        Button9.BackColor = Color.Transparent
        StatusLabel.ForeColor = Color.Black
        StatusLabel.Text = ""
        PlayerXScoreLabel.Text = X
        PlayerOScoreLabel.Text = O
    End Sub
    Private Sub ResetMenuItem_Click(sender As Object, e As EventArgs) Handles ResetMenuItem.Click
        I = 1
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
        Button1.BackColor = Color.Transparent
        Button2.BackColor = Color.Transparent
        Button3.BackColor = Color.Transparent
        Button4.BackColor = Color.Transparent
        Button5.BackColor = Color.Transparent
        Button6.BackColor = Color.Transparent
        Button7.BackColor = Color.Transparent
        Button8.BackColor = Color.Transparent
        Button9.BackColor = Color.Transparent
        StatusLabel.ForeColor = Color.Black
        StatusLabel.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Text = Chance()
        Button1.Enabled = False
        I += 1
        Result()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Text = Chance()
        Button2.Enabled = False
        I += 1
        Result()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Text = Chance()
        Button3.Enabled = False
        I += 1
        Result()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.Text = Chance()
        Button4.Enabled = False
        I += 1
        Result()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button5.Text = Chance()
        Button5.Enabled = False
        I += 1
        Result()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Button6.Text = Chance()
        Button6.Enabled = False
        I += 1
        Result()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button7.Text = Chance()
        Button7.Enabled = False
        I += 1
        Result()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Button8.Text = Chance()
        Button8.Enabled = False
        I += 1
        Result()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Button9.Text = Chance()
        Button9.Enabled = False
        I += 1
        Result()
    End Sub
    Private Function Chance() As String
        If I Mod 2 = 1 Then
            StatusLabel.ForeColor = Color.Black
            StatusLabel.Text = "Player O's Turn!"
            Return "X"
        Else
            StatusLabel.ForeColor = Color.Black
            StatusLabel.Text = "Player X's Turn!"
            Return "O"
        End If
    End Function
    Private Function Result()
        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then
            X += 1
            Button1.BackColor = Color.Green
            Button2.BackColor = Color.Green
            Button3.BackColor = Color.Green
            StatusLabel.ForeColor = Color.Green
            StatusLabel.Text = "Player X Wins!"
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            PlayerXScoreLabel.Text = X
        ElseIf Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Then
            X += 1
            Button1.BackColor = Color.Green
            Button4.BackColor = Color.Green
            Button7.BackColor = Color.Green
            StatusLabel.ForeColor = Color.Green
            StatusLabel.Text = "Player X Wins!"
            Button2.Enabled = False
            Button3.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            PlayerXScoreLabel.Text = X
        ElseIf Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Then
            X += 1
            Button3.BackColor = Color.Green
            Button6.BackColor = Color.Green
            Button9.BackColor = Color.Green
            StatusLabel.ForeColor = Color.Green
            StatusLabel.Text = "Player X Wins!"
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            PlayerXScoreLabel.Text = X
        ElseIf Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Then
            X += 1
            Button7.BackColor = Color.Green
            Button8.BackColor = Color.Green
            Button9.BackColor = Color.Green
            StatusLabel.ForeColor = Color.Green
            StatusLabel.Text = "Player X Wins!"
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            PlayerXScoreLabel.Text = X
        ElseIf Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" Then
            X += 1
            Button2.BackColor = Color.Green
            Button5.BackColor = Color.Green
            Button8.BackColor = Color.Green
            StatusLabel.ForeColor = Color.Green
            StatusLabel.Text = "Player X Wins!"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button9.Enabled = False
            PlayerXScoreLabel.Text = X
        ElseIf Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Then
            X += 1
            Button4.BackColor = Color.Green
            Button5.BackColor = Color.Green
            Button6.BackColor = Color.Green
            StatusLabel.ForeColor = Color.Green
            StatusLabel.Text = "Player X Wins!"
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            PlayerXScoreLabel.Text = X
        ElseIf Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Then
            X += 1
            Button1.BackColor = Color.Green
            Button5.BackColor = Color.Green
            Button9.BackColor = Color.Green
            StatusLabel.ForeColor = Color.Green
            StatusLabel.Text = "Player X Wins!"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            PlayerXScoreLabel.Text = X
        ElseIf Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X" Then
            X += 1
            Button3.BackColor = Color.Green
            Button5.BackColor = Color.Green
            Button7.BackColor = Color.Green
            StatusLabel.ForeColor = Color.Green
            StatusLabel.Text = "Player X Wins!"
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Enabled = False
            Button6.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            PlayerXScoreLabel.Text = X
        ElseIf Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" Then
            O += 1
            Button1.BackColor = Color.Green
            Button2.BackColor = Color.Green
            Button3.BackColor = Color.Green
            StatusLabel.ForeColor = Color.Green
            StatusLabel.Text = "Player O Wins!"
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            PlayerOScoreLabel.Text = O
        ElseIf Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O" Then
            O += 1
            Button1.BackColor = Color.Green
            Button4.BackColor = Color.Green
            Button7.BackColor = Color.Green
            StatusLabel.ForeColor = Color.Green
            StatusLabel.Text = "Player O Wins!"
            Button2.Enabled = False
            Button3.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            PlayerOScoreLabel.Text = O
        ElseIf Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O" Then
            O += 1
            Button3.BackColor = Color.Green
            Button6.BackColor = Color.Green
            Button9.BackColor = Color.Green
            StatusLabel.ForeColor = Color.Green
            StatusLabel.Text = "Player O Wins!"
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            PlayerOScoreLabel.Text = O
        ElseIf Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O" Then
            O += 1
            Button7.BackColor = Color.Green
            Button8.BackColor = Color.Green
            Button9.BackColor = Color.Green
            StatusLabel.ForeColor = Color.Green
            StatusLabel.Text = "Player O Wins!"
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            PlayerOScoreLabel.Text = O
        ElseIf Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O" Then
            O += 1
            Button2.BackColor = Color.Green
            Button5.BackColor = Color.Green
            Button8.BackColor = Color.Green
            StatusLabel.ForeColor = Color.Green
            StatusLabel.Text = "Player O Wins!"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button9.Enabled = False
            PlayerOScoreLabel.Text = O
        ElseIf Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O" Then
            O += 1
            Button4.BackColor = Color.Green
            Button5.BackColor = Color.Green
            Button6.BackColor = Color.Green
            StatusLabel.ForeColor = Color.Green
            StatusLabel.Text = "Player O Wins!"
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            PlayerOScoreLabel.Text = O
        ElseIf Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O" Then
            O += 1
            Button1.BackColor = Color.Green
            Button5.BackColor = Color.Green
            Button9.BackColor = Color.Green
            StatusLabel.ForeColor = Color.Green
            StatusLabel.Text = "Player O Wins!"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            PlayerOScoreLabel.Text = O
        ElseIf Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O" Then
            O += 1
            Button3.BackColor = Color.Green
            Button5.BackColor = Color.Green
            Button7.BackColor = Color.Green
            StatusLabel.ForeColor = Color.Green
            StatusLabel.Text = "Player O Wins!"
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Enabled = False
            Button6.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            PlayerOScoreLabel.Text = O
        ElseIf Button1.Text <> "" And Button2.Text <> "" And Button3.Text <> "" And Button4.Text <> "" And Button5.Text <> "" And Button6.Text <> "" And Button7.Text <> "" And Button8.Text <> "" And Button9.Text <> "" Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Red
            Button8.BackColor = Color.Red
            Button9.BackColor = Color.Red
            StatusLabel.ForeColor = Color.Red
            StatusLabel.Text = "Its a tie!"
        End If
        Return Nothing
    End Function
End Class
