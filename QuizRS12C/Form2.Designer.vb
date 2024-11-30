<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Voltar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Flashie = New System.Windows.Forms.PictureBox()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.RightQuest = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelTimer = New System.Windows.Forms.Label()
        Me.MyVerticalProgressBar1 = New QuizRS12C.MyVerticalProgressBar()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Flashie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Voltar
        '
        Me.Voltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Voltar.Location = New System.Drawing.Point(12, 526)
        Me.Voltar.Name = "Voltar"
        Me.Voltar.Size = New System.Drawing.Size(75, 23)
        Me.Voltar.TabIndex = 0
        Me.Voltar.Text = "Voltar"
        Me.Voltar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button4, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(226, 317)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(332, 208)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(3, 107)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 98)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "1920x1080"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(169, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(160, 98)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "2560x1440"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Control
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(169, 107)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(160, 98)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "800x600"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 98)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "1280x720"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 20
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Flashie
        '
        Me.Flashie.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Flashie.BackColor = System.Drawing.Color.Transparent
        Me.Flashie.Image = Global.QuizRS12C.My.Resources.Resources.Flashie
        Me.Flashie.Location = New System.Drawing.Point(664, 521)
        Me.Flashie.Name = "Flashie"
        Me.Flashie.Size = New System.Drawing.Size(55, 40)
        Me.Flashie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Flashie.TabIndex = 3
        Me.Flashie.TabStop = False
        '
        'ButtonNext
        '
        Me.ButtonNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonNext.Location = New System.Drawing.Point(560, 490)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(30, 30)
        Me.ButtonNext.TabIndex = 4
        Me.ButtonNext.Text = "➤"
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'RightQuest
        '
        Me.RightQuest.Location = New System.Drawing.Point(731, 25)
        Me.RightQuest.Name = "RightQuest"
        Me.RightQuest.Size = New System.Drawing.Size(44, 15)
        Me.RightQuest.TabIndex = 5
        Me.RightQuest.Text = "0/10"
        Me.RightQuest.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(133, 387)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(518, 77)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "...Auch... Impressionante, num sentido negativo." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Por favor, tente novamente, e v" &
    "eja se o rato está bem ligado."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label4.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Topsicle", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(228, 306)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(329, 68)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "0/10"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label3.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(62, 269)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(660, 23)
        Me.ProgressBar1.TabIndex = 7
        Me.ProgressBar1.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Label2.Font = New System.Drawing.Font("Elephant", 72.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(62, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(660, 230)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Parabéns!!"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(660, 230)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Qual é a resolução de uma imagem Full HD?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelTimer
        '
        Me.LabelTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelTimer.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTimer.ForeColor = System.Drawing.Color.Maroon
        Me.LabelTimer.Location = New System.Drawing.Point(232, 255)
        Me.LabelTimer.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelTimer.Name = "LabelTimer"
        Me.LabelTimer.Size = New System.Drawing.Size(320, 40)
        Me.LabelTimer.TabIndex = 11
        Me.LabelTimer.Text = "Tempo Limite Atingido"
        Me.LabelTimer.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MyVerticalProgressBar1
        '
        Me.MyVerticalProgressBar1.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.MyVerticalProgressBar1.Location = New System.Drawing.Point(742, 50)
        Me.MyVerticalProgressBar1.Name = "MyVerticalProgressBar1"
        Me.MyVerticalProgressBar1.Size = New System.Drawing.Size(22, 467)
        Me.MyVerticalProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.MyVerticalProgressBar1.TabIndex = 6
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuizRS12C.My.Resources.Resources.BackgroundSky
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.LabelTimer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.MyVerticalProgressBar1)
        Me.Controls.Add(Me.RightQuest)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.Flashie)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Voltar)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Quiz"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.Flashie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Voltar As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Flashie As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ButtonNext As Button
    Friend WithEvents RightQuest As Label
    Friend WithEvents MyVerticalProgressBar1 As MyVerticalProgressBar
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelTimer As Label
End Class
