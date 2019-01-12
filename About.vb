Public Class About
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        Hide()
    End Sub
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        End
    End Sub
    Private Sub NewGameMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameMenuItem.Click
        Home.ScoreX = 0 : Home.ScoreO = 0
        Home.ResetBoard()
        Home.PlayerXScoreLabel.Text = Home.ScoreX
        Home.PlayerOScoreLabel.Text = Home.ScoreO
        Home.Show()
        Hide()
    End Sub
    Private Sub ResetMenuItem_Click(sender As Object, e As EventArgs) Handles ResetMenuItem.Click
        Home.ResetBoard()
        Home.Show()
        Hide()
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
End Class