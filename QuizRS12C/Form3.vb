Public Class Form3
    Public Property Question As Integer = 1 'Question Count
    Public Property Answered As Boolean = 0 'Question has been answered 
    Public Property FlashingText As Boolean = 0 'Flashing Congratulations
    Public Property AnswerRight As Integer = 0 'Right Answers Count
    Public Property FlashieMove As Integer = 0 '1 Left, 2 Right
    Public Property FlashieSide As Integer = 2 '1 Left, 2 Right

    'StartUp
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Flashie.Image = If(Form1.FlashieGender = 0, My.Resources.FFlashie, My.Resources.BBeanie)
        Timer1.Start()
        Timer2.Start()
        If Form1.TimerEnabled = True Then
            LabelTimer.Visible = True
            LabelTimer.Text = "20"
        Else
            LabelTimer.Visible = False
        End If
        Label1.Text = "O tamanho dum cabo de fibra óptica é mais parecido com o quê?"
        Button1.Text = "Conduta elétrica"
        Button2.Text = "Bambu"
        Button3.Text = "Fio de telefone"
        Button4.Text = "Cabelo humano" '
        ButtonNext.Visible = False
    End Sub

    'Voltar/Fechar
    Private Sub Voltar_Click(sender As Object, e As EventArgs) Handles Voltar.Click
        Close()
    End Sub
    Private Sub Form3_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub

    'Comment Help
    Private Sub Flashie_Click(sender As Object, e As EventArgs) Handles Flashie.Click
        FormComment.Show()
    End Sub

    'Flashie Animations
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Int((10 * Rnd()) + 1) = 1 Then
            FlashieMove = FlashieSide
            FlashieSide = If(FlashieSide = 2, 1, 2)
        Else
            FlashieMove = 0
        End If
        'Flashing Text at Result Screen
        If FlashingText = 0 Then
            Label2.BackColor = Color.PaleTurquoise
            FlashingText = 1
        Else
            Label2.BackColor = Color.LightCoral
            FlashingText = 0
        End If
        'Time Limit
        If Form1.TimerEnabled = True And Answered = 0 Then
            LabelTimer.Text = LabelTimer.Text - 1
            'Setting to -1 instead of 0 for Coyote Time, slight delay before consequences manifest
            'Just a nice thing :)
            If (LabelTimer.Text = -1) Then
                LabelTimer.Text = "Tempo Limite Atingido."
                Answered = 1
                Button1.BackColor = Color.DarkRed
                Button2.BackColor = Color.DarkRed
                Button3.BackColor = Color.DarkRed
                Button4.BackColor = Color.DarkRed
                ButtonNext.Visible = True
                MyVerticalProgressBar1.PerformStep()
            End If
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If FlashieMove = 1 Then
            Flashie.Image = If(Form1.FlashieGender = 0, My.Resources.FFlashie, My.Resources.BBeanie)
            Flashie.Left += 2
        ElseIf FlashieMove = 2 Then
            Flashie.Image = If(Form1.FlashieGender = 0, My.Resources.FFlashieL, My.Resources.BBeanieL)
            Flashie.Left -= 2
        End If
    End Sub

    'Answer Buttons
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Answered = 0 Then
            Select Case Question
                Case 1
                    Button1.BackColor = Color.DarkRed
                    Button4.BackColor = Color.DodgerBlue
                Case 2
                    Button1.BackColor = Color.DarkRed
                    Button3.BackColor = Color.DodgerBlue
                Case 3
                    Button1.BackColor = Color.DarkRed
                    Button4.BackColor = Color.DodgerBlue
                Case 4
                    Button1.BackColor = Color.DarkRed
                    Button3.BackColor = Color.DodgerBlue
                Case 5
                    Button1.BackColor = Color.DarkRed
                    Button3.BackColor = Color.DodgerBlue
                Case 6
                    Button1.BackColor = Color.DodgerBlue
                    AnswerRight += 1
                Case 7
                    Button1.BackColor = Color.DarkRed
                    Button2.BackColor = Color.DodgerBlue
                Case 8
                    Button1.BackColor = Color.DodgerBlue
                    AnswerRight += 1
                Case 9
                    Button1.BackColor = Color.DarkRed
                    Button2.BackColor = Color.DodgerBlue
                Case 10
                    Button1.BackColor = Color.DarkRed
                    Button4.BackColor = Color.DodgerBlue
                Case Else
                    Exit Select
            End Select
            MyVerticalProgressBar1.PerformStep()
        End If
        RightQuest.Text = AnswerRight & "/10"
        Answered = 1
        ButtonNext.Visible = True
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Answered = 0 Then
            Select Case Question
                Case 1
                    Button2.BackColor = Color.DarkRed
                    Button4.BackColor = Color.DodgerBlue
                Case 2
                    Button2.BackColor = Color.DarkRed
                    Button3.BackColor = Color.DodgerBlue
                Case 3
                    Button2.BackColor = Color.DarkRed
                    Button4.BackColor = Color.DodgerBlue
                Case 4
                    Button2.BackColor = Color.DarkRed
                    Button3.BackColor = Color.DodgerBlue
                Case 5
                    Button2.BackColor = Color.DarkRed
                    Button3.BackColor = Color.DodgerBlue
                Case 6
                    Button2.BackColor = Color.DarkRed
                    Button1.BackColor = Color.DodgerBlue
                Case 7
                    Button2.BackColor = Color.DodgerBlue
                    AnswerRight += 1
                Case 8
                    Button2.BackColor = Color.DarkRed
                    Button1.BackColor = Color.DodgerBlue
                Case 9
                    Button2.BackColor = Color.DodgerBlue
                    AnswerRight += 1
                Case 10
                    Button2.BackColor = Color.DarkRed
                    Button4.BackColor = Color.DodgerBlue
                Case Else
                    Exit Select
            End Select
            MyVerticalProgressBar1.PerformStep()
        End If
        RightQuest.Text = AnswerRight & "/10"
        Answered = 1
        ButtonNext.Visible = True
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Answered = 0 Then
            Select Case Question
                Case 1
                    Button3.BackColor = Color.DarkRed
                    Button4.BackColor = Color.DodgerBlue
                Case 2
                    Button3.BackColor = Color.DodgerBlue
                    AnswerRight += 1
                Case 3
                    Button3.BackColor = Color.DarkRed
                    Button4.BackColor = Color.DodgerBlue
                Case 4
                    Button3.BackColor = Color.DodgerBlue
                    AnswerRight += 1
                Case 5
                    Button3.BackColor = Color.DodgerBlue
                    AnswerRight += 1
                Case 6
                    Button3.BackColor = Color.DarkRed
                    Button1.BackColor = Color.DodgerBlue
                Case 7
                    Button3.BackColor = Color.DarkRed
                    Button2.BackColor = Color.DodgerBlue
                Case 8
                    Button3.BackColor = Color.DarkRed
                    Button1.BackColor = Color.DodgerBlue
                Case 9
                    Button3.BackColor = Color.DarkRed
                    Button2.BackColor = Color.DodgerBlue
                Case 10
                    Button3.BackColor = Color.DarkRed
                    Button4.BackColor = Color.DodgerBlue
                Case Else
                    Exit Select
            End Select
            MyVerticalProgressBar1.PerformStep()
        End If
        RightQuest.Text = AnswerRight & "/10"
        Answered = 1
        ButtonNext.Visible = True
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Answered = 0 Then
            Select Case Question
                Case 1
                    Button4.BackColor = Color.DodgerBlue
                    AnswerRight += 1
                Case 2
                    Button4.BackColor = Color.DarkRed
                    Button3.BackColor = Color.DodgerBlue
                Case 3
                    Button4.BackColor = Color.DodgerBlue
                    AnswerRight += 1
                Case 4
                    Button4.BackColor = Color.DarkRed
                    Button3.BackColor = Color.DodgerBlue
                Case 5
                    Button4.BackColor = Color.DarkRed
                    Button3.BackColor = Color.DodgerBlue
                Case 6
                    Button4.BackColor = Color.DarkRed
                    Button1.BackColor = Color.DodgerBlue
                Case 7
                    Button4.BackColor = Color.DarkRed
                    Button2.BackColor = Color.DodgerBlue
                Case 8
                    Button4.BackColor = Color.DarkRed
                    Button1.BackColor = Color.DodgerBlue
                Case 9
                    Button4.BackColor = Color.DarkRed
                    Button2.BackColor = Color.DodgerBlue
                Case 10
                    Button4.BackColor = Color.DodgerBlue
                    AnswerRight += 1
                Case Else
                    Exit Select
            End Select
            MyVerticalProgressBar1.PerformStep()
        End If
        RightQuest.Text = AnswerRight & "/10"
        Answered = 1
        ButtonNext.Visible = True
    End Sub

    'Next Question Button
    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        Question += 1
        FormComment.Close()
        ButtonNext.Visible = False
        Button1.BackColor = SystemColors.Control
        Button2.BackColor = SystemColors.Control
        Button3.BackColor = SystemColors.Control
        Button4.BackColor = SystemColors.Control
        LabelTimer.Text = "20"
        Select Case Question
            ' One (') for Right Answer
            ' Two ('') for Close but Wrong Answer
            Case 1
                Label1.Text = "O tamanho dum cabo de fibra óptica é mais parecido com o quê?"
                Button1.Text = "Conduta elétrica" ''
                Button2.Text = "Bambu"
                Button3.Text = "Fio de telefone"
                Button4.Text = "Cabelo humano" '
            Case 2
                Label1.Text = "O que significa PNG?"
                Button1.Text = "Photo Network Grayscale" ''
                Button2.Text = "Papua New Guinea"
                Button3.Text = "Portable Network Graphics" '
                Button4.Text = "Pendejo Noise Generator"
            Case 3
                Label1.Text = "Quando foram introduzidos os DVDs?"
                Button1.Text = "1977" ''Apple 2 Release Date
                Button2.Text = "1990"
                Button3.Text = "2000"
                Button4.Text = "1995" '
            Case 4
                Label1.Text = "Uma rede de computadores privada de uso exclusivo de um local é chamada de:"
                Button1.Text = "World Wide Web"
                Button2.Text = "Yahoo"
                Button3.Text = "Intranet" '
                Button4.Text = "Internet" ''
            Case 5
                Label1.Text = "Qual destes não é um dos primeiros computadores?"
                Button1.Text = "ENIAC"
                Button2.Text = "UNIVAC"
                Button3.Text = "NASA" '
                Button4.Text = "SAGE" ''
            Case 6
                Label1.Text = "Quantas linguagens de programação são usadas atualmente?"
                Button1.Text = "2000" '
                Button2.Text = "5000"
                Button3.Text = "50" ''
                Button4.Text = "20"
            Case 7
                Label1.Text = "Qual foi o primeiro videojogo com sucesso comercial?"
                Button1.Text = "Tetris" ''
                Button2.Text = "Pong" '
                Button3.Text = "Minecraft"
                Button4.Text = "Roblox"
            Case 8
                Label1.Text = "Quantos Call of Duty's existem sem contar com spin-offs até 2018?"
                Button1.Text = "15" '
                Button2.Text = "8"
                Button3.Text = "17" ''
                Button4.Text = "33"
            Case 9
                Label1.Text = "O que significa CPU?"
                Button1.Text = "Communist Party of Ukraine" ''
                Button2.Text = "Central Processing Unit" '
                Button3.Text = "Computer Power User"
                Button4.Text = "Critical Patch Update"
            Case 10
                Label1.Text = "O que originalmente significava LG de LG Electronics?"
                Button1.Text = "Life's Good" ''
                Button2.Text = "Luxury Goods"
                Button3.Text = "Laser Guided"
                Button4.Text = "Lucky-Goldstar" '
            Case Else
                'Result Screen
                Label1.Visible = False
                Button1.Visible = False
                Button2.Visible = False
                Button3.Visible = False
                Button4.Visible = False
                ButtonNext.Visible = False
                MyVerticalProgressBar1.Visible = False
                RightQuest.Visible = False
                LabelTimer.Visible = False
                Label2.Visible = True
                ProgressBar1.Visible = True
                ProgressBar1.Value = AnswerRight * 10
                Label3.Text = AnswerRight & "/10"
                Label3.Visible = True
                Label4.Visible = True
                Select Case AnswerRight
                    Case 0, 1
                        Label4.Text = "Algum problema? Tens o rato bem ligado?" + Environment.NewLine + "Talvez queiras desligar e voltar a ligar o computador."
                    Case 2 To 4
                        Label4.Text = "Se queres ser o mestre de, hum, factos importantes," + Environment.NewLine + "tenta novamente."
                    Case 5 To 7
                        Label4.Text = "Nada mau! Certamente estás lá perto." + Environment.NewLine + "Acertaste a pergunta do Call of Duty?"
                    Case 8 To 10
                        Label4.Text = "Maravilhoso! Que excelente vitória!" + Environment.NewLine + "Há outra surpresa à sua espera no menu inicial. Bye!"
                        'Unlock Final Secret
                        Form1.PictureBox3.Visible = True
                    Case Else
                        Exit Select
                End Select
                Exit Select
        End Select
        Answered = 0
    End Sub
End Class