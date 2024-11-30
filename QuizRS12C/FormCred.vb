Public Class FormCred
    Public Property FlashieSide As Boolean = 0 '0 Left, 1 Right

    'Close
    Private Sub FormCred_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Close()
    End Sub

    'Start Animation Timer
    Private Sub FormCred_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    'When Timer ticks, change Left Minis to Right Minis
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If FlashieSide = 0 Then
            PictureBox2.Image = My.Resources.FlashieL
            PictureBox3.Image = My.Resources.BeanieL
            FlashieSide = 1
        Else
            PictureBox2.Image = My.Resources.Flashie
            PictureBox3.Image = My.Resources.Beanie
            FlashieSide = 0
        End If
    End Sub
End Class