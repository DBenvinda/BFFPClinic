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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.BtnEntrar = New System.Windows.Forms.Button()
        Me.OlhoA_PictureBox = New System.Windows.Forms.PictureBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.OlhoF_PictureBox = New System.Windows.Forms.PictureBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OlhoA_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OlhoF_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.PAP_G2_BFFPclinic_01_Diogo.My.Resources.Resources.corclara
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(21, 33)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(453, 351)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 25
        Me.PictureBox3.TabStop = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.Transparent
        Me.Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancel.CausesValidation = False
        Me.Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Cancel.FlatAppearance.BorderSize = 0
        Me.Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(773, 349)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(110, 35)
        Me.Cancel.TabIndex = 22
        Me.Cancel.Text = "Sair"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'BtnEntrar
        '
        Me.BtnEntrar.BackColor = System.Drawing.Color.Transparent
        Me.BtnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEntrar.CausesValidation = False
        Me.BtnEntrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEntrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.BtnEntrar.FlatAppearance.BorderSize = 0
        Me.BtnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEntrar.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEntrar.Location = New System.Drawing.Point(635, 237)
        Me.BtnEntrar.Name = "BtnEntrar"
        Me.BtnEntrar.Size = New System.Drawing.Size(110, 35)
        Me.BtnEntrar.TabIndex = 21
        Me.BtnEntrar.Text = "Entrar"
        Me.BtnEntrar.UseVisualStyleBackColor = False
        '
        'OlhoA_PictureBox
        '
        Me.OlhoA_PictureBox.Image = Global.PAP_G2_BFFPclinic_01_Diogo.My.Resources.Resources.OlhoA
        Me.OlhoA_PictureBox.Location = New System.Drawing.Point(773, 179)
        Me.OlhoA_PictureBox.Name = "OlhoA_PictureBox"
        Me.OlhoA_PictureBox.Size = New System.Drawing.Size(25, 21)
        Me.OlhoA_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.OlhoA_PictureBox.TabIndex = 19
        Me.OlhoA_PictureBox.TabStop = False
        '
        'PasswordLabel
        '
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(525, 176)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(104, 26)
        Me.PasswordLabel.TabIndex = 17
        Me.PasswordLabel.Text = "Password:"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.UsernameLabel.Location = New System.Drawing.Point(525, 144)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(104, 26)
        Me.UsernameLabel.TabIndex = 15
        Me.UsernameLabel.Text = "Username:"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OlhoF_PictureBox
        '
        Me.OlhoF_PictureBox.Image = Global.PAP_G2_BFFPclinic_01_Diogo.My.Resources.Resources.OlhoF
        Me.OlhoF_PictureBox.Location = New System.Drawing.Point(773, 179)
        Me.OlhoF_PictureBox.Name = "OlhoF_PictureBox"
        Me.OlhoF_PictureBox.Size = New System.Drawing.Size(25, 21)
        Me.OlhoF_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.OlhoF_PictureBox.TabIndex = 20
        Me.OlhoF_PictureBox.TabStop = False
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UsernameTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(635, 144)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(165, 26)
        Me.UsernameTextBox.TabIndex = 16
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(635, 176)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(165, 26)
        Me.PasswordTextBox.TabIndex = 18
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.PAP_G2_BFFPclinic_01_Diogo.My.Resources.Resources.cormenosesc
        Me.PictureBox2.Image = Global.PAP_G2_BFFPclinic_01_Diogo.My.Resources.Resources.corclara2
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(472, 392)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PAP_G2_BFFPclinic_01_Diogo.My.Resources.Resources.cormenosesc2
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(908, 413)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.BtnEntrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(909, 412)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.BtnEntrar)
        Me.Controls.Add(Me.OlhoA_PictureBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.OlhoF_PictureBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmLogin"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OlhoA_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OlhoF_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Cancel As Button
    Friend WithEvents BtnEntrar As Button
    Friend WithEvents OlhoA_PictureBox As PictureBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents OlhoF_PictureBox As PictureBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
