Public Class Home
    Public I As Integer
    Public ScoreX As Integer
    Public ScoreO As Integer
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
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
    Private Sub NewGameMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameMenuItem.Click
        ScoreX = 0 : ScoreO = 0
        ResetBoard()
        PlayerXScoreLabel.Text = ScoreX
        PlayerOScoreLabel.Text = ScoreO
    End Sub
    Private Sub ResetMenuItem_Click(sender As Object, e As EventArgs) Handles ResetMenuItem.Click
        ResetBoard()
    End Sub
    Private Sub AboutMenuItem_Click(sender As Object, e As EventArgs) Handles AboutMenuItem.Click
        Hide()
        About.Show()
    End Sub
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click
        sender.Text = Chance()
        sender.Enabled = False
        I += 1
        Result()
    End Sub
    Private Sub MenuStrip_MouseDown(sender As Object, e As MouseEventArgs) Handles MenuStrip.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub
    Private Sub MenuStrip_MouseUp(sender As Object, e As MouseEventArgs) Handles MenuStrip.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub
    Private Sub MenuStrip_MouseMove(sender As Object, e As MouseEventArgs) Handles MenuStrip.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point With {
                    .X = Location.X + (e.X - MouseDownX),
                    .Y = Location.Y + (e.Y - MouseDownY)
                }
            Location = temp
            temp = Nothing
        End If
    End Sub
    Public Function ResetBoard()
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
        Return Nothing
    End Function
    Private Function DisableBoard()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        Return Nothing
    End Function
    Private Function Pair(ByVal Box1 As String, ByVal Box2 As String, ByVal Box3 As String) As Boolean
        If String.Equals(Box1, Box2) = True AndAlso String.Equals(Box2, Box3) = True Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function Score(ByVal Player As String)
        If String.Equals(Player, "X") Then
            ScoreX += 1
            PlayerXScoreLabel.Text = ScoreX
        ElseIf String.Equals(Player, "O") Then
            ScoreO += 1
            PlayerOScoreLabel.Text = ScoreO
        End If
        Return Nothing
    End Function
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
        If Button1.Text <> String.Empty AndAlso Pair(Button1.Text, Button2.Text, Button3.Text) = True Then
            Button1.BackColor = Color.Green
            Button2.BackColor = Color.Green
            Button3.BackColor = Color.Green
            StatusLabel.ForeColor = Color.Green
            Score(Button1.Text)
            StatusLabel.Text = "Player " + Button1.Text + " Wins!"
            DisableBoard()
        ElseIf Button4.Text <> String.Empty AndAlso Pair(Button4.Text, Button5.Text, Button6.Text) = True Then
            Button4.BackColor = Color.Green
            Button5.BackColor = Color.Green
            Button6.BackColor = Color.Green
            StatusLabel.ForeColor = Color.Green
            Score(Button4.Text)
            StatusLabel.Text = "Player " + Button4.Text + " Wins!"
            DisableBoard()
        ElseIf Button7.Text <> String.Empty AndAlso Pair(Button7.Text, Button8.Text, Button9.Text) = True Then
            Button7.BackColor = Color.Green
            Button8.BackColor = Color.Green
            Button9.BackColor = Color.Green
            StatusLabel.ForeColor = Color.Green
            Score(Button7.Text)
            StatusLabel.Text = "Player " + Button7.Text + " Wins!"
            DisableBoard()
        ElseIf Button1.Text <> String.Empty AndAlso Pair(Button1.Text, Button4.Text, Button7.Text) = True Then
            Button1.BackColor = Color.Green
            Button4.BackColor = Color.Green
            Button7.BackColor = Color.Green
            StatusLabel.ForeColor = Color.Green
            Score(Button1.Text)
            StatusLabel.Text = "Player " + Button1.Text + " Wins!"
            DisableBoard()
        ElseIf Button2.Text <> String.Empty AndAlso Pair(Button2.Text, Button5.Text, Button8.Text) = True Then
            Button2.BackColor = Color.Green
            Button5.BackColor = Color.Green
            Button8.BackColor = Color.Green
            StatusLabel.ForeColor = Color.Green
            Score(Button2.Text)
            StatusLabel.Text = "Player " + Button2.Text + " Wins!"
            DisableBoard()
        ElseIf Button3.Text <> String.Empty AndAlso Pair(Button3.Text, Button6.Text, Button9.Text) = True Then
            Button3.BackColor = Color.Green
            Button6.BackColor = Color.Green
            Button9.BackColor = Color.Green
            StatusLabel.ForeColor = Color.Green
            Score(Button3.Text)
            StatusLabel.Text = "Player " + Button3.Text + " Wins!"
            DisableBoard()
        ElseIf Button1.Text <> String.Empty AndAlso Pair(Button1.Text, Button5.Text, Button9.Text) = True Then
            Button1.BackColor = Color.Green
            Button5.BackColor = Color.Green
            Button9.BackColor = Color.Green
            StatusLabel.ForeColor = Color.Green
            Score(Button1.Text)
            StatusLabel.Text = "Player " + Button1.Text + " Wins!"
            DisableBoard()
        ElseIf Button3.Text <> String.Empty AndAlso Pair(Button3.Text, Button5.Text, Button7.Text) = True Then
            Button3.BackColor = Color.Green
            Button5.BackColor = Color.Green
            Button7.BackColor = Color.Green
            StatusLabel.ForeColor = Color.Green
            Score(Button3.Text)
            StatusLabel.Text = "Player " + Button3.Text + " Wins!"
            DisableBoard()
        ElseIf I > 9 Then
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
