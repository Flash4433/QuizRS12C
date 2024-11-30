Public Class FormComment
    'Close if it has been clicked...
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Close()
    End Sub

    'Or Close if 5 seconds have passed
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Close()
    End Sub
    'It also closes after passing to the next question

    Private Sub FormComment_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
        'Set Comment position to around under the center of the movement of the Mini, like an RPG-Style game's text box
        StartPosition = FormStartPosition.Manual
        Location = If(Form1.Secret = 0, Form2.Location, Form3.Location)
        Left += 530
        Top += 600
        'Detect Question and select right Comment
        If Form1.Secret = 0 Then
            Select Case Form2.Question
                Case 1
                    Label1.Text = "HD é 1280x720, então Full HD... hum..."
                Case 2
                    Label1.Text = "~Why you think they call me Mr. Worldwide?~"
                Case 3
                    Label1.Text = "Acho que é 2 elevado a algo."
                Case 4
                    Label1.Text = "Bill Gates é aquele das janelas, ah... Win-qualquer coisa."
                Case 5
                    Label1.Text = "Pessoalmente, considero perifécios como coisas fora da caixa do PC."
                Case 6
                    Label1.Text = "Um destes é uma marca de carros russa."
                Case 7
                    Label1.Text = "Alguém lembra-se do iBook?"
                Case 8
                    Label1.Text = "O zoom dos telemóveis é horrível."
                Case 9
                    Label1.Text = "CIA é um tipo de ficheiros usado para instalar jogos para uma Nintendo 3DS."
                Case 10
                    Label1.Text = "Sim, Razr é um telemóvel. Não, não é da Razer."
                Case Else
                    Label1.TextAlign = ContentAlignment.MiddleCenter
                    Label1.Text = "^_^"
            End Select
        Else
            Select Case Form3.Question
                Case 1
                    Label1.Text = "Dica: É muito pequeno. Tipo, mesmo pequenino."
                Case 2
                    Label1.Text = "PNGs têm transparência, mas não são só a preto e branco."
                Case 3
                    Label1.Text = "Para comparação, os CDs sairam antes dos DVDs, e isso foi em 1982."
                Case 4
                    Label1.Text = "Se é privada, não pode ser a Internet, certo?"
                Case 5
                    Label1.Text = "Que nomes estranhos... Conheces algum que não é um computador? SAGE?"
                Case 6
                    Label1.Text = "Muito mais que 50."
                Case 7
                    Label1.Text = "Ping-P..."
                Case 8
                    Label1.Text = "1, 2, 3, Modern Warfare, MW2, Black Ops, MW3, BO2, e o resto depois de 2012..."
                Case 9
                    Label1.Text = "A CPU processa, então..."
                Case 10
                    Label1.Text = "Life's Good é o slogan atual, mas tinha outro significado antigamente."
                Case Else
                    Label1.TextAlign = ContentAlignment.MiddleCenter
                    Label1.Text = "^_^"
            End Select
        End If
    End Sub
End Class