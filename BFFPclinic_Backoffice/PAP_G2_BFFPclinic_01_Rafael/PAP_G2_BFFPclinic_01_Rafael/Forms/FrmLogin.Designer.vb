<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.OlhoA_PictureBox = New System.Windows.Forms.PictureBox()
        Me.OlhoF_PictureBox = New System.Windows.Forms.PictureBox()
        Me.BtnEntrar = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.OlhoA_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OlhoF_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.UsernameLabel.ForeColor = System.Drawing.Color.White
        Me.UsernameLabel.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.cormenosesc
        Me.UsernameLabel.Location = New System.Drawing.Point(599, 256)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(108, 26)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "Username:"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.PasswordLabel.ForeColor = System.Drawing.Color.White
        Me.PasswordLabel.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.cormenosesc
        Me.PasswordLabel.Location = New System.Drawing.Point(605, 307)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(102, 26)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "Password:"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UsernameTextBox.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.UsernameTextBox.Location = New System.Drawing.Point(717, 256)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(165, 26)
        Me.UsernameTextBox.TabIndex = 1
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PasswordTextBox.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.PasswordTextBox.Location = New System.Drawing.Point(717, 307)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(165, 26)
        Me.PasswordTextBox.TabIndex = 3
        '
        'OlhoA_PictureBox
        '
        Me.OlhoA_PictureBox.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.OlhoA
        Me.OlhoA_PictureBox.Location = New System.Drawing.Point(857, 309)
        Me.OlhoA_PictureBox.Name = "OlhoA_PictureBox"
        Me.OlhoA_PictureBox.Size = New System.Drawing.Size(25, 21)
        Me.OlhoA_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.OlhoA_PictureBox.TabIndex = 8
        Me.OlhoA_PictureBox.TabStop = False
        '
        'OlhoF_PictureBox
        '
        Me.OlhoF_PictureBox.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.OlhoF
        Me.OlhoF_PictureBox.Location = New System.Drawing.Point(857, 309)
        Me.OlhoF_PictureBox.Name = "OlhoF_PictureBox"
        Me.OlhoF_PictureBox.Size = New System.Drawing.Size(25, 21)
        Me.OlhoF_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.OlhoF_PictureBox.TabIndex = 9
        Me.OlhoF_PictureBox.TabStop = False
        '
        'BtnEntrar
        '
        Me.BtnEntrar.BackColor = System.Drawing.Color.White
        Me.BtnEntrar.BackgroundImage = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.cormenosesc
        Me.BtnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEntrar.CausesValidation = False
        Me.BtnEntrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEntrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.BtnEntrar.FlatAppearance.BorderSize = 0
        Me.BtnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEntrar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BtnEntrar.ForeColor = System.Drawing.Color.White
        Me.BtnEntrar.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.corfundoesc21
        Me.BtnEntrar.Location = New System.Drawing.Point(742, 358)
        Me.BtnEntrar.Name = "BtnEntrar"
        Me.BtnEntrar.Size = New System.Drawing.Size(112, 37)
        Me.BtnEntrar.TabIndex = 10
        Me.BtnEntrar.Text = "Entrar"
        Me.BtnEntrar.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.Transparent
        Me.Cancel.BackgroundImage = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.cormenosesc
        Me.Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancel.CausesValidation = False
        Me.Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Cancel.FlatAppearance.BorderSize = 0
        Me.Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Cancel.ForeColor = System.Drawing.Color.White
        Me.Cancel.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.corfundoesc21
        Me.Cancel.Location = New System.Drawing.Point(857, 443)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(110, 35)
        Me.Cancel.TabIndex = 11
        Me.Cancel.Text = "Sair"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.cormenosesc2
        Me.PictureBox1.Location = New System.Drawing.Point(75, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(908, 413)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.cormenosesc
        Me.PictureBox2.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.corclara2
        Me.PictureBox2.Location = New System.Drawing.Point(86, 98)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(472, 392)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.corclara
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(98, 120)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(450, 346)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'PictureBox14
        '
        Me.PictureBox14.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox14.BackgroundImage = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.cormenosesc
        Me.PictureBox14.Enabled = False
        Me.PictureBox14.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.PictureBox14.Location = New System.Drawing.Point(713, 250)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(175, 36)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox14.TabIndex = 314
        Me.PictureBox14.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.cormenosesc
        Me.PictureBox4.Enabled = False
        Me.PictureBox4.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.PictureBox4.Location = New System.Drawing.Point(713, 302)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(175, 36)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 315
        Me.PictureBox4.TabStop = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.corfundoesc
        Me.ClientSize = New System.Drawing.Size(1081, 589)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.BtnEntrar)
        Me.Controls.Add(Me.OlhoA_PictureBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.OlhoF_PictureBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login"
        CType(Me.OlhoA_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OlhoF_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OlhoA_PictureBox As PictureBox
    Friend WithEvents OlhoF_PictureBox As PictureBox
    Friend WithEvents BtnEntrar As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
