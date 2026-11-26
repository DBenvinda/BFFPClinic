<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEspecialidades
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Label10 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FLG_ConsultasCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.FLG_ExamesCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.FLG_OperacoesCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.FLG_AtivoCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.Cod_EspecialidadeComboBox = New System.Windows.Forms.ComboBox()
        Me.DesignacaoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_EspecialidadeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UC_NAV11 = New PAP_G2_BFFPclinic_01_Rafael.UC_NAV1()
        Label10 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.FLG_ConsultasCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLG_ExamesCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLG_OperacoesCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLG_AtivoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DesignacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_EspecialidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Label10.Location = New System.Drawing.Point(229, 279)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(181, 25)
        Label10.TabIndex = 197
        Label10.Text = "Cod Especialidade :"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Label17.Location = New System.Drawing.Point(619, 285)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(106, 25)
        Label17.TabIndex = 194
        Label17.Text = "FLG_Ativo:"
        Label17.Visible = False
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        NomeLabel.Location = New System.Drawing.Point(286, 336)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(124, 25)
        NomeLabel.TabIndex = 191
        NomeLabel.Text = "Designação :"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Label1.Location = New System.Drawing.Point(404, 385)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(152, 25)
        Label1.TabIndex = 267
        Label1.Text = "FLG_Operações:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Label2.Location = New System.Drawing.Point(250, 385)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(125, 25)
        Label2.TabIndex = 269
        Label2.Text = "FLG_Exames:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Label3.Location = New System.Drawing.Point(586, 386)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(145, 25)
        Label3.TabIndex = 271
        Label3.Text = "FLG_Consultas:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Controls.Add(Me.FLG_ConsultasCheckEdit)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Me.FLG_ExamesCheckEdit)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.FLG_OperacoesCheckEdit)
        Me.Panel1.Controls.Add(Label1)
        Me.Panel1.Controls.Add(Me.FLG_AtivoCheckEdit)
        Me.Panel1.Controls.Add(Me.Cod_EspecialidadeComboBox)
        Me.Panel1.Controls.Add(Label10)
        Me.Panel1.Controls.Add(Label17)
        Me.Panel1.Controls.Add(Me.DesignacaoTextEdit)
        Me.Panel1.Controls.Add(NomeLabel)
        Me.Panel1.Controls.Add(Me.Cod_EspecialidadeTextEdit)
        Me.Panel1.Controls.Add(Me.PictureBox13)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1088, 878)
        Me.Panel1.TabIndex = 6
        '
        'FLG_ConsultasCheckEdit
        '
        Me.FLG_ConsultasCheckEdit.Location = New System.Drawing.Point(737, 391)
        Me.FLG_ConsultasCheckEdit.Name = "FLG_ConsultasCheckEdit"
        Me.FLG_ConsultasCheckEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.FLG_ConsultasCheckEdit.Properties.Appearance.Options.UseFont = True
        Me.FLG_ConsultasCheckEdit.Properties.Caption = ""
        Me.FLG_ConsultasCheckEdit.Size = New System.Drawing.Size(24, 20)
        Me.FLG_ConsultasCheckEdit.TabIndex = 272
        '
        'FLG_ExamesCheckEdit
        '
        Me.FLG_ExamesCheckEdit.Location = New System.Drawing.Point(381, 390)
        Me.FLG_ExamesCheckEdit.Name = "FLG_ExamesCheckEdit"
        Me.FLG_ExamesCheckEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.FLG_ExamesCheckEdit.Properties.Appearance.Options.UseFont = True
        Me.FLG_ExamesCheckEdit.Properties.Caption = ""
        Me.FLG_ExamesCheckEdit.Size = New System.Drawing.Size(17, 20)
        Me.FLG_ExamesCheckEdit.TabIndex = 270
        '
        'FLG_OperacoesCheckEdit
        '
        Me.FLG_OperacoesCheckEdit.Location = New System.Drawing.Point(562, 390)
        Me.FLG_OperacoesCheckEdit.Name = "FLG_OperacoesCheckEdit"
        Me.FLG_OperacoesCheckEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.FLG_OperacoesCheckEdit.Properties.Appearance.Options.UseFont = True
        Me.FLG_OperacoesCheckEdit.Properties.Caption = ""
        Me.FLG_OperacoesCheckEdit.Size = New System.Drawing.Size(18, 20)
        Me.FLG_OperacoesCheckEdit.TabIndex = 268
        '
        'FLG_AtivoCheckEdit
        '
        Me.FLG_AtivoCheckEdit.Location = New System.Drawing.Point(731, 290)
        Me.FLG_AtivoCheckEdit.Name = "FLG_AtivoCheckEdit"
        Me.FLG_AtivoCheckEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.FLG_AtivoCheckEdit.Properties.Appearance.Options.UseFont = True
        Me.FLG_AtivoCheckEdit.Properties.Caption = ""
        Me.FLG_AtivoCheckEdit.Size = New System.Drawing.Size(30, 20)
        Me.FLG_AtivoCheckEdit.TabIndex = 266
        '
        'Cod_EspecialidadeComboBox
        '
        Me.Cod_EspecialidadeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cod_EspecialidadeComboBox.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Cod_EspecialidadeComboBox.FormattingEnabled = True
        Me.Cod_EspecialidadeComboBox.Location = New System.Drawing.Point(421, 277)
        Me.Cod_EspecialidadeComboBox.Name = "Cod_EspecialidadeComboBox"
        Me.Cod_EspecialidadeComboBox.Size = New System.Drawing.Size(158, 33)
        Me.Cod_EspecialidadeComboBox.TabIndex = 121
        Me.Cod_EspecialidadeComboBox.Visible = False
        '
        'DesignacaoTextEdit
        '
        Me.DesignacaoTextEdit.Location = New System.Drawing.Point(421, 331)
        Me.DesignacaoTextEdit.Name = "DesignacaoTextEdit"
        Me.DesignacaoTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.DesignacaoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.DesignacaoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.DesignacaoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.DesignacaoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.DesignacaoTextEdit.Size = New System.Drawing.Size(335, 30)
        Me.DesignacaoTextEdit.TabIndex = 190
        '
        'Cod_EspecialidadeTextEdit
        '
        Me.Cod_EspecialidadeTextEdit.Location = New System.Drawing.Point(420, 279)
        Me.Cod_EspecialidadeTextEdit.Name = "Cod_EspecialidadeTextEdit"
        Me.Cod_EspecialidadeTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Cod_EspecialidadeTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Cod_EspecialidadeTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Cod_EspecialidadeTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Cod_EspecialidadeTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Cod_EspecialidadeTextEdit.Size = New System.Drawing.Size(158, 30)
        Me.Cod_EspecialidadeTextEdit.TabIndex = 199
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox13.Enabled = False
        Me.PictureBox13.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.PictureBox13.Location = New System.Drawing.Point(416, 328)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(345, 36)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox13.TabIndex = 302
        Me.PictureBox13.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.PictureBox1.Location = New System.Drawing.Point(416, 276)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 303
        Me.PictureBox1.TabStop = False
        '
        'UC_NAV11
        '
        Me.UC_NAV11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_NAV11.Location = New System.Drawing.Point(0, 0)
        Me.UC_NAV11.mFRM = Nothing
        Me.UC_NAV11.Name = "UC_NAV11"
        Me.UC_NAV11.Size = New System.Drawing.Size(1112, 964)
        Me.UC_NAV11.TabIndex = 0
        '
        'FrmEspecialidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1112, 964)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UC_NAV11)
        Me.Name = "FrmEspecialidades"
        Me.Text = "FrmEspecialidades"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.FLG_ConsultasCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLG_ExamesCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLG_OperacoesCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLG_AtivoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DesignacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_EspecialidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UC_NAV11 As UC_NAV1
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Cod_EspecialidadeComboBox As ComboBox
    Friend WithEvents DesignacaoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cod_EspecialidadeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FLG_AtivoCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents FLG_ConsultasCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents FLG_ExamesCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents FLG_OperacoesCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
