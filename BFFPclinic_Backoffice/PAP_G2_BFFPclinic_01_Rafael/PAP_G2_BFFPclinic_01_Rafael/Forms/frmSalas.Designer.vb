<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSalas
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
        Dim Lbl_FLG_Ativo As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Num_SalaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PisoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DesignacaoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FLG_AtivoCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.Cod_SalaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UC_NAV11 = New PAP_G2_BFFPclinic_01_Rafael.UC_NAV1()
        Lbl_FLG_Ativo = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Num_SalaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PisoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DesignacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLG_AtivoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_SalaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_FLG_Ativo
        '
        Lbl_FLG_Ativo.AutoSize = True
        Lbl_FLG_Ativo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Lbl_FLG_Ativo.Location = New System.Drawing.Point(406, 223)
        Lbl_FLG_Ativo.Name = "Lbl_FLG_Ativo"
        Lbl_FLG_Ativo.Size = New System.Drawing.Size(111, 25)
        Lbl_FLG_Ativo.TabIndex = 221
        Lbl_FLG_Ativo.Text = "FLG_Ativo :"
        Lbl_FLG_Ativo.Visible = False
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Label2.Location = New System.Drawing.Point(212, 223)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(107, 25)
        Label2.TabIndex = 216
        Label2.Text = "Num Sala :"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Label10.Location = New System.Drawing.Point(225, 123)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(94, 25)
        Label10.TabIndex = 208
        Label10.Text = "Cod Sala:"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Label17.Location = New System.Drawing.Point(200, 174)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(119, 25)
        Label17.TabIndex = 205
        Label17.Text = "Designação:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        NomeLabel.Location = New System.Drawing.Point(406, 123)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(54, 25)
        NomeLabel.TabIndex = 202
        NomeLabel.Text = "Piso:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Num_SalaTextEdit)
        Me.Panel1.Controls.Add(Me.PisoTextEdit)
        Me.Panel1.Controls.Add(Me.DesignacaoTextEdit)
        Me.Panel1.Controls.Add(Me.FLG_AtivoCheckEdit)
        Me.Panel1.Controls.Add(Lbl_FLG_Ativo)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Label10)
        Me.Panel1.Controls.Add(Label17)
        Me.Panel1.Controls.Add(NomeLabel)
        Me.Panel1.Controls.Add(Me.Cod_SalaTextEdit)
        Me.Panel1.Controls.Add(Me.PictureBox14)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1088, 878)
        Me.Panel1.TabIndex = 9
        '
        'Num_SalaTextEdit
        '
        Me.Num_SalaTextEdit.Location = New System.Drawing.Point(328, 218)
        Me.Num_SalaTextEdit.Name = "Num_SalaTextEdit"
        Me.Num_SalaTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Num_SalaTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Num_SalaTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Num_SalaTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Num_SalaTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Num_SalaTextEdit.Size = New System.Drawing.Size(68, 30)
        Me.Num_SalaTextEdit.TabIndex = 225
        '
        'PisoTextEdit
        '
        Me.PisoTextEdit.Location = New System.Drawing.Point(470, 119)
        Me.PisoTextEdit.Name = "PisoTextEdit"
        Me.PisoTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.PisoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.PisoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.PisoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.PisoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PisoTextEdit.Size = New System.Drawing.Size(68, 30)
        Me.PisoTextEdit.TabIndex = 224
        '
        'DesignacaoTextEdit
        '
        Me.DesignacaoTextEdit.Location = New System.Drawing.Point(329, 172)
        Me.DesignacaoTextEdit.Name = "DesignacaoTextEdit"
        Me.DesignacaoTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.DesignacaoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.DesignacaoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.DesignacaoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.DesignacaoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.DesignacaoTextEdit.Size = New System.Drawing.Size(204, 30)
        Me.DesignacaoTextEdit.TabIndex = 223
        '
        'FLG_AtivoCheckEdit
        '
        Me.FLG_AtivoCheckEdit.Location = New System.Drawing.Point(523, 228)
        Me.FLG_AtivoCheckEdit.Name = "FLG_AtivoCheckEdit"
        Me.FLG_AtivoCheckEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.FLG_AtivoCheckEdit.Properties.Appearance.Options.UseFont = True
        Me.FLG_AtivoCheckEdit.Properties.Caption = ""
        Me.FLG_AtivoCheckEdit.Size = New System.Drawing.Size(18, 20)
        Me.FLG_AtivoCheckEdit.TabIndex = 222
        '
        'Cod_SalaTextEdit
        '
        Me.Cod_SalaTextEdit.Location = New System.Drawing.Point(328, 119)
        Me.Cod_SalaTextEdit.Name = "Cod_SalaTextEdit"
        Me.Cod_SalaTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Cod_SalaTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Cod_SalaTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Cod_SalaTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Cod_SalaTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Cod_SalaTextEdit.Size = New System.Drawing.Size(68, 30)
        Me.Cod_SalaTextEdit.TabIndex = 210
        '
        'PictureBox14
        '
        Me.PictureBox14.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox14.Enabled = False
        Me.PictureBox14.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.PictureBox14.Location = New System.Drawing.Point(325, 170)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(216, 34)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox14.TabIndex = 303
        Me.PictureBox14.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Enabled = False
        Me.PictureBox3.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.PictureBox3.Location = New System.Drawing.Point(466, 117)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(75, 34)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 306
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Enabled = False
        Me.PictureBox2.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.PictureBox2.Location = New System.Drawing.Point(325, 117)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(74, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 305
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.PictureBox1.Location = New System.Drawing.Point(325, 217)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 304
        Me.PictureBox1.TabStop = False
        '
        'UC_NAV11
        '
        Me.UC_NAV11.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.UC_NAV11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_NAV11.Location = New System.Drawing.Point(0, 0)
        Me.UC_NAV11.mFRM = Nothing
        Me.UC_NAV11.Name = "UC_NAV11"
        Me.UC_NAV11.Size = New System.Drawing.Size(1112, 964)
        Me.UC_NAV11.TabIndex = 0
        '
        'frmSalas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1112, 964)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UC_NAV11)
        Me.Name = "frmSalas"
        Me.Text = "frmSalas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Num_SalaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PisoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DesignacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLG_AtivoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_SalaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UC_NAV11 As UC_NAV1
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Cod_SalaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FLG_AtivoCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PisoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DesignacaoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Num_SalaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
End Class
