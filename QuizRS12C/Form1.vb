Public Class Form1
    Public Property Muted As Boolean = 0 '1 Muted
    Public Property Secret As Boolean = 0 '1 Second Quiz
    Public Property TimerEnabled As Boolean = 0 '1 Timer Enabled
    Public Property FlashieMove As Integer = 0 '1 Left, 2 Right
    Public Property FlashieSide As Integer = 2 '1 Left, 2 Right
    Public Property FlashieGender As Boolean = 0 '0 Male, 1 Female

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Start Timers
        Timer1.Start()
        Timer2.Start()
        'Start Normal Music
        My.Computer.Audio.Play(My.Resources.DJVI_Back_On_Track, AudioPlayMode.BackgroundLoop)
        'Lock Unlockables
        PictureBox2.Visible = False
        PictureBox3.Visible = False
    End Sub

    'Check Secret and start Quiz
    Private Sub Jogar_Click(sender As Object, e As EventArgs) Handles Jogar.Click
        Visible = False
        If Secret = 0 Then
            Form2.Show()
        Else
            Form3.Show()
        End If
    End Sub

    'Ajuda
    Private Sub Ajuda_Click(sender As Object, e As EventArgs) Handles Ajuda.Click
        FormAjuda.Show()
    End Sub

    'Créditos/Autor
    Private Sub Autor_Click(sender As Object, e As EventArgs) Handles Autor.Click
        FormCred.Show()
    End Sub

    'Sair/Fechar
    Private Sub Sair_Click(sender As Object, e As EventArgs) Handles Sair.Click
        Application.Exit()
    End Sub

    'Final Unlockable ฅ^•ﻌ•^ฅ
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Formdont.Show()
    End Sub

    'Mini Animations
    'Not the best way to do it, but works.
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'Mini has 1/10 chance to move every second
        If Int((10 * Rnd()) + 1) = 1 Then
            FlashieMove = FlashieSide
            FlashieSide = If(FlashieSide = 2, 1, 2)
        Else
            FlashieMove = 0
        End If
        'Instead of every second set random value between 800 and 1000
        Timer2.Interval = Int(((1000 - 800 + 1) * Rnd()) + 800)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Swap Right Mini for Left Mini and viceversa, depending on gender
        If FlashieMove = 1 Then
            Flashie.Image = If(FlashieGender = 0,
                If(Secret = 0, My.Resources.Flashie, My.Resources.FFlashie),
                If(Secret = 0, My.Resources.Beanie, My.Resources.BBeanie))
            Flashie.Left += 2
        ElseIf FlashieMove = 2 Then
            Flashie.Image = If(FlashieGender = 0,
                If(Secret = 0, My.Resources.FlashieL, My.Resources.FFlashieL),
                If(Secret = 0, My.Resources.BeanieL, My.Resources.BBeanieL))
            Flashie.Left -= 2
        End If
    End Sub

    'Mini Gender Swap
    Private Sub Flashie_Click(sender As Object, e As EventArgs) Handles Flashie.Click
        If FlashieGender = 0 Then
            FlashieGender = 1
            Flashie.Image = If(Secret = 0,
                If(Flashie.Image Is My.Resources.Flashie, My.Resources.Beanie, My.Resources.BeanieL),
                If(Flashie.Image Is My.Resources.FFlashie, My.Resources.BBeanie, My.Resources.BBeanieL))
        Else
            FlashieGender = 0
            Flashie.Image = If(Secret = 0,
                If(Flashie.Image Is My.Resources.Beanie, My.Resources.Flashie, My.Resources.FlashieL),
                If(Flashie.Image Is My.Resources.BBeanie, My.Resources.FFlashie, My.Resources.FFlashieL))
        End If
    End Sub

    'Mute
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Muted = 0 Then
            'Stop Music
            PictureBox1.Image = My.Resources.SpeakerMute
            My.Computer.Audio.Stop()
            Muted = 1
        Else
            'Play Music
            PictureBox1.Image = My.Resources.Speaker
            If Secret = 0 Then
                My.Computer.Audio.Play(My.Resources.DJVI_Back_On_Track, AudioPlayMode.BackgroundLoop)
            Else
                My.Computer.Audio.Play(My.Resources.DJVI_Back_On_Track_2_0, AudioPlayMode.BackgroundLoop)
            End If
            Muted = 0
        End If
    End Sub

    'Secret Quiz
    'Set the Main Menu style to Secret, and reset them
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Secret = 0 Then
            If Muted = 0 Then
                My.Computer.Audio.Play(My.Resources.DJVI_Back_On_Track_2_0, AudioPlayMode.BackgroundLoop)
            End If
            Secret = 1
            BackgroundImage = My.Resources.BackgroundRed
            Jogar.BackColor = Color.CornflowerBlue
            Flashie.Image = If(FlashieGender = 0,
                If(Flashie.Image Is My.Resources.Flashie, My.Resources.FFlashie, My.Resources.FFlashieL),
                If(Flashie.Image Is My.Resources.Beanie, My.Resources.BBeanie, My.Resources.BBeanieL))
        Else
            If Muted = 0 Then
                My.Computer.Audio.Play(My.Resources.DJVI_Back_On_Track, AudioPlayMode.BackgroundLoop)
            End If
            Secret = 0
            BackgroundImage = My.Resources.BackgroundBlue
            Jogar.BackColor = SystemColors.Control
            Flashie.Image = If(FlashieGender = 0,
                If(Flashie.Image Is My.Resources.FFlashie, My.Resources.Flashie, My.Resources.FlashieL),
                If(Flashie.Image Is My.Resources.BBeanie, My.Resources.Beanie, My.Resources.BeanieL))
        End If
    End Sub

    'Timer Enabled/Disabled
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If TimerEnabled = 0 Then
            PictureBox4.Image = My.Resources.Timer
            TimerEnabled = True
        Else
            PictureBox4.Image = My.Resources.Timer2
            TimerEnabled = False
        End If
    End Sub
End Class