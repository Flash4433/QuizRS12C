<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Jogar = New System.Windows.Forms.Button()
        Me.Autor = New System.Windows.Forms.Button()
        Me.Ajuda = New System.Windows.Forms.Button()
        Me.Sair = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Flashie = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Flashie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Jogar, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Autor, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Ajuda, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Sair, 1, 1)
        Me.TableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(103, 149)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(162, 58)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Jogar
        '
        Me.Jogar.BackColor = System.Drawing.SystemColors.Control
        Me.Jogar.Location = New System.Drawing.Point(3, 3)
        Me.Jogar.Name = "Jogar"
        Me.Jogar.Size = New System.Drawing.Size(75, 23)
        Me.Jogar.TabIndex = 0
        Me.Jogar.Text = "Jogar"
        Me.Jogar.UseVisualStyleBackColor = False
        '
        'Autor
        '
        Me.Autor.BackColor = System.Drawing.SystemColors.Control
        Me.Autor.Location = New System.Drawing.Point(3, 32)
        Me.Autor.Name = "Autor"
        Me.Autor.Size = New System.Drawing.Size(75, 23)
        Me.Autor.TabIndex = 1
        Me.Autor.Text = "Autor"
        Me.Autor.UseVisualStyleBackColor = False
        '
        'Ajuda
        '
        Me.Ajuda.BackColor = System.Drawing.SystemColors.Control
        Me.Ajuda.Location = New System.Drawing.Point(84, 3)
        Me.Ajuda.Name = "Ajuda"
        Me.Ajuda.Size = New System.Drawing.Size(75, 23)
        Me.Ajuda.TabIndex = 2
        Me.Ajuda.Text = "Ajuda"
        Me.Ajuda.UseVisualStyleBackColor = False
        '
        'Sair
        '
        Me.Sair.BackColor = System.Drawing.SystemColors.Control
        Me.Sair.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Sair.Location = New System.Drawing.Point(84, 32)
        Me.Sair.Name = "Sair"
        Me.Sair.Size = New System.Drawing.Size(75, 23)
        Me.Sair.TabIndex = 3
        Me.Sair.Text = "Sair"
        Me.Sair.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 20
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 117)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "QUIZ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Help
        Me.PictureBox2.Image = Global.QuizRS12C.My.Resources.Resources.Star
        Me.PictureBox2.Location = New System.Drawing.Point(254, 28)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.QuizRS12C.My.Resources.Resources.Speaker
        Me.PictureBox1.Location = New System.Drawing.Point(0, 312)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Flashie
        '
        Me.Flashie.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Flashie.BackColor = System.Drawing.Color.Transparent
        Me.Flashie.Image = Global.QuizRS12C.My.Resources.Resources.Flashie
        Me.Flashie.Location = New System.Drawing.Point(274, 304)
        Me.Flashie.Name = "Flashie"
        Me.Flashie.Size = New System.Drawing.Size(55, 40)
        Me.Flashie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Flashie.TabIndex = 1
        Me.Flashie.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Help
        Me.PictureBox3.Image = Global.QuizRS12C.My.Resources.Resources.Star2
        Me.PictureBox3.Location = New System.Drawing.Point(171, 166)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Image = Global.QuizRS12C.My.Resources.Resources.Timer2
        Me.PictureBox4.Location = New System.Drawing.Point(32, 312)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'Form1
        '
        Me.AcceptButton = Me.Jogar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.QuizRS12C.My.Resources.Resources.BackgroundBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.Sair
        Me.ClientSize = New System.Drawing.Size(368, 345)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Flashie)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Quiz"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Flashie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Jogar As Button
    Friend WithEvents Autor As Button
    Friend WithEvents Ajuda As Button
    Friend WithEvents Sair As Button
    Friend WithEvents Flashie As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
