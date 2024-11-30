Public Class Form2
    Public Property Question As Integer = 1 'Question Count
    Public Property Answered As Boolean = 0 'Question has been answered 
    Public Property FlashingText As Boolean = 0 'Flashing Congratulations
    Public Property AnswerRight As Integer = 0 'Right Answers Count
    Public Property FlashieMove As Integer = 0 '1 Left, 2 Right
    Public Property FlashieSide As Integer = 2 '1 Left, 2 Right

    'StartUp
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Flashie.Image = If(Form1.FlashieGender = 0, My.Resources.Flashie, My.Resources.Beanie)
        Timer1.Start()
        Timer2.Start()
        If Form1.TimerEnabled = True Then
            LabelTimer.Visible = True
            LabelTimer.Text = "20"
        Else
            LabelTimer.Visible = False
        End If
        Label1.Text = "Qual é a resolução de uma imagem Full HD?"
        Button1.Text = "1280x720"
        Button2.Text = "1920x1080" '
        Button3.Text = "2560x1440"
        Button4.Text = "800x600"
        ButtonNext.Visible = False
    End Sub

    'Voltar/Fechar
    Private Sub Voltar_Click(sender As Object, e As EventArgs) Handles Voltar.Click
        Close()
    End Sub
    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
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
            Flashie.Image = If(Form1.FlashieGender = 0, My.Resources.Flashie, My.Resources.Beanie)
            Flashie.Left += 2
        ElseIf FlashieMove = 2 Then
            Flashie.Image = If(Form1.FlashieGender = 0, My.Resources.FlashieL, My.Resources.BeanieL)
            Flashie.Left -= 2
        End If
    End Sub

    'Answer Buttons
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Answered = 0 Then
            Select Case Question
                Case 1
                    Button1.BackColor = Color.DarkRed
                    Button2.BackColor = Color.SpringGreen
                Case 2
                    Button1.BackColor = Color.DarkRed
                    Button3.BackColor = Color.SpringGreen
                Case 3
                    Button1.BackColor = Color.DarkRed
                    Button2.BackColor = Color.SpringGreen
                Case 4
                    Button1.BackColor = Color.DarkRed
                    Button3.BackColor = Color.SpringGreen
                Case 5
                    Button1.BackColor = Color.DarkRed
                    Button4.BackColor = Color.SpringGreen
                Case 6
                    Button1.BackColor = Color.DarkRed
                    Button4.BackColor = Color.SpringGreen
                Case 7
                    Button1.BackColor = Color.SpringGreen
                    AnswerRight += 1
                Case 8
                    Button1.BackColor = Color.SpringGreen
                    AnswerRight += 1
                Case 9
                    Button1.BackColor = Color.DarkRed
                    Button2.BackColor = Color.SpringGreen
                Case 10
                    Button1.BackColor = Color.DarkRed
                    Button3.BackColor = Color.SpringGreen
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
                    Button2.BackColor = Color.SpringGreen
                    AnswerRight += 1
                Case 2
                    Button2.BackColor = Color.DarkRed
                    Button3.BackColor = Color.SpringGreen
                Case 3
                    Button2.BackColor = Color.SpringGreen
                    AnswerRight += 1
                Case 4
                    Button2.BackColor = Color.DarkRed
                    Button3.BackColor = Color.SpringGreen
                Case 5
                    Button2.BackColor = Color.DarkRed
                    Button4.BackColor = Color.SpringGreen
                Case 6
                    Button2.BackColor = Color.DarkRed
                    Button4.BackColor = Color.SpringGreen
                Case 7
                    Button2.BackColor = Color.DarkRed
                    Button1.BackColor = Color.SpringGreen
                Case 8
                    Button2.BackColor = Color.DarkRed
                    Button1.BackColor = Color.SpringGreen
                Case 9
                    Button2.BackColor = Color.SpringGreen
                    AnswerRight += 1
                Case 10
                    Button2.BackColor = Color.DarkRed
                    Button3.BackColor = Color.SpringGreen
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
                    Button2.BackColor = Color.SpringGreen
                Case 2
                    Button3.BackColor = Color.SpringGreen
                    AnswerRight += 1
                Case 3
                    Button3.BackColor = Color.DarkRed
                    Button2.BackColor = Color.SpringGreen
                Case 4
                    Button3.BackColor = Color.SpringGreen
                    AnswerRight += 1
                Case 5
                    Button3.BackColor = Color.DarkRed
                    Button4.BackColor = Color.SpringGreen
                Case 6
                    Button3.BackColor = Color.DarkRed
                    Button4.BackColor = Color.SpringGreen
                Case 7
                    Button3.BackColor = Color.DarkRed
                    Button1.BackColor = Color.SpringGreen
                Case 8
                    Button3.BackColor = Color.DarkRed
                    Button1.BackColor = Color.SpringGreen
                Case 9
                    Button3.BackColor = Color.DarkRed
                    Button2.BackColor = Color.SpringGreen
                Case 10
                    Button3.BackColor = Color.SpringGreen
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
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Answered = 0 Then
            Select Case Question
                Case 1
                    Button4.BackColor = Color.DarkRed
                    Button2.BackColor = Color.SpringGreen
                Case 2
                    Button4.BackColor = Color.DarkRed
                    Button3.BackColor = Color.SpringGreen
                Case 3
                    Button4.BackColor = Color.DarkRed
                    Button2.BackColor = Color.SpringGreen
                Case 4
                    Button4.BackColor = Color.DarkRed
                    Button3.BackColor = Color.SpringGreen
                Case 5
                    Button4.BackColor = Color.SpringGreen
                    AnswerRight += 1
                Case 6
                    Button4.BackColor = Color.SpringGreen
                    AnswerRight += 1
                Case 7
                    Button4.BackColor = Color.DarkRed
                    Button1.BackColor = Color.SpringGreen
                Case 8
                    Button4.BackColor = Color.DarkRed
                    Button1.BackColor = Color.SpringGreen
                Case 9
                    Button4.BackColor = Color.DarkRed
                    Button2.BackColor = Color.SpringGreen
                Case 10
                    Button4.BackColor = Color.DarkRed
                    Button3.BackColor = Color.SpringGreen
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
                Label1.Text = "Qual é a resolução de uma imagem Full HD?"
                Button1.Text = "1280x720" ''
                Button2.Text = "1920x1080" '
                Button3.Text = "2560x1440"
                Button4.Text = "800x600"
            Case 2
                Label1.Text = "O que significa a sigla 'www' na Internet?"
                Button1.Text = "Web World Wide" ''
                Button2.Text = "Web Wide World"
                Button3.Text = "World Wide Web" '
                Button4.Text = "World Web Wide"
            Case 3
                Label1.Text = "Quantos bits cabem em um byte?"
                Button1.Text = "1 bit"
                Button2.Text = "8 bits" '
                Button3.Text = "12 bits"
                Button4.Text = "64 bits" ''
            Case 4
                Label1.Text = "Quem fundou a Apple Computer, Inc.?"
                Button1.Text = "Fernando Mendes"
                Button2.Text = "Bill Gates" ''
                Button3.Text = "Steve Jobs" '
                Button4.Text = "Stephen Hawking"
            Case 5
                Label1.Text = "Qual destes não é um periférico, em termos de computador?"
                Button1.Text = "Teclado"
                Button2.Text = "Monitor" ''
                Button3.Text = "Rato"
                Button4.Text = "Placa-mãe" '
            Case 6
                Label1.Text = "Qual destes não é uma marca de computador?"
                Button1.Text = "Apple"
                Button2.Text = "Lenovo"
                Button3.Text = "Toshiba" ''
                Button4.Text = "Lada" '
            Case 7
                Label1.Text = "Qual destes produtos não foi feito pela Apple Corporation?"
                Button1.Text = "IMAX" '
                Button2.Text = "iPhone"
                Button3.Text = "iMac"
                Button4.Text = "iPod"
            Case 8
                Label1.Text = "Com qual destes dispositivos está o telefone mais relacionado?"
                Button1.Text = "Rádio" '
                Button2.Text = "Torradeira"
                Button3.Text = "Lâmpada"
                Button4.Text = "Telescópio" ''
            Case 9
                Label1.Text = "Qual destes é um formato de ficheiro para imagens digitais?"
                Button1.Text = "CIA" ''
                Button2.Text = "JPG" '
                Button3.Text = "ICBM"
                Button4.Text = "IBM"
            Case 10
                Label1.Text = "Qual destes não é um telemóvel?"
                Button1.Text = "Razr" ''
                Button2.Text = "Blackberry"
                Button3.Text = "iPod" '
                Button4.Text = "iPhone"
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
                        Label4.Text = "...Auch... Impressionante, num sentido negativo." + Environment.NewLine + "Por favor, tente novamente, e veja se o rato está bem ligado."
                    Case 2 To 4
                        Label4.Text = "Estava à espera de mais, este não é o modo dificil..." + Environment.NewLine + "Ups, disse demais? Hum, tente novamente por favor."
                    Case 5 To 7
                        Label4.Text = "Muito bem! Impressionante até! Mas aposto que consegue mais!" + Environment.NewLine + "Vai haver uma surpresa se conseguir uma pontuação ainda melhor!"
                    Case 8 To 10
                        Label4.Text = "Excelente! Tem bons conhecimentos sobre a tecnologia!" + Environment.NewLine + "Há uma surpresa à sua espera no menu inicial~"
                        'Unlock Secret Quiz
                        Form1.PictureBox2.Visible = True
                    Case Else
                        Exit Select
                End Select
                Exit Select
        End Select
        Answered = 0
    End Sub
End Class