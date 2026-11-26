<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIVA
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
        Dim Label4 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim NIFLabel As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Me.UC_NAV11 = New PAP_G2_BFFPclinic_01_Rafael.UC_NAV1()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DesignacaoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Taxa_IVATextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FLG_AtivoCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.FLG_DescontinuadoCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.Data_Inicio_VigorDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.Data_Fim_VigorDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Tipo_IVATextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Cod_IVATextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Label4 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        NIFLabel = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DesignacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Taxa_IVATextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLG_AtivoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLG_DescontinuadoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_Inicio_VigorDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_Inicio_VigorDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_Fim_VigorDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_Fim_VigorDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tipo_IVATextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_IVATextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Label4.Location = New System.Drawing.Point(268, 392)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(106, 25)
        Label4.TabIndex = 243
        Label4.Text = "FLG_Ativo:"
        Label4.Visible = False
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Label9.Location = New System.Drawing.Point(468, 392)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(194, 25)
        Label9.TabIndex = 241
        Label9.Text = "FLG_Descontinuado:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Label10.Location = New System.Drawing.Point(468, 346)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(151, 25)
        Label10.TabIndex = 239
        Label10.Text = "Data Fim Vigor:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Label11.Location = New System.Drawing.Point(200, 287)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(119, 25)
        Label11.TabIndex = 236
        Label11.Text = "Designação:"
        '
        'NIFLabel
        '
        NIFLabel.AutoSize = True
        NIFLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        NIFLabel.Location = New System.Drawing.Point(497, 178)
        NIFLabel.Name = "NIFLabel"
        NIFLabel.Size = New System.Drawing.Size(93, 25)
        NIFLabel.TabIndex = 227
        NIFLabel.Text = "Taxa IVA:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Label12.Location = New System.Drawing.Point(151, 343)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(168, 25)
        Label12.TabIndex = 226
        Label12.Text = "Data Inicio Vigor:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        NomeLabel.Location = New System.Drawing.Point(226, 233)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(93, 25)
        NomeLabel.TabIndex = 225
        NomeLabel.Text = "Tipo IVA:"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Label13.Location = New System.Drawing.Point(225, 178)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(94, 25)
        Label13.TabIndex = 224
        Label13.Text = "Cod  IVA:"
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
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DesignacaoTextEdit)
        Me.Panel1.Controls.Add(Me.Taxa_IVATextEdit)
        Me.Panel1.Controls.Add(Me.FLG_AtivoCheckEdit)
        Me.Panel1.Controls.Add(Me.FLG_DescontinuadoCheckEdit)
        Me.Panel1.Controls.Add(Me.Data_Inicio_VigorDateEdit)
        Me.Panel1.Controls.Add(Label4)
        Me.Panel1.Controls.Add(Label9)
        Me.Panel1.Controls.Add(Label10)
        Me.Panel1.Controls.Add(Label11)
        Me.Panel1.Controls.Add(NIFLabel)
        Me.Panel1.Controls.Add(Label12)
        Me.Panel1.Controls.Add(NomeLabel)
        Me.Panel1.Controls.Add(Label13)
        Me.Panel1.Controls.Add(Me.Data_Fim_VigorDateEdit)
        Me.Panel1.Controls.Add(Me.PictureBox8)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Tipo_IVATextEdit)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.Cod_IVATextEdit)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Location = New System.Drawing.Point(12, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1088, 878)
        Me.Panel1.TabIndex = 9
        '
        'DesignacaoTextEdit
        '
        Me.DesignacaoTextEdit.Location = New System.Drawing.Point(331, 285)
        Me.DesignacaoTextEdit.Name = "DesignacaoTextEdit"
        Me.DesignacaoTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.DesignacaoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.DesignacaoTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.DesignacaoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.DesignacaoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.DesignacaoTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.DesignacaoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.DesignacaoTextEdit.Size = New System.Drawing.Size(418, 30)
        Me.DesignacaoTextEdit.TabIndex = 269
        '
        'Taxa_IVATextEdit
        '
        Me.Taxa_IVATextEdit.Location = New System.Drawing.Point(602, 173)
        Me.Taxa_IVATextEdit.Name = "Taxa_IVATextEdit"
        Me.Taxa_IVATextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Taxa_IVATextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Taxa_IVATextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Taxa_IVATextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Taxa_IVATextEdit.Properties.Appearance.Options.UseFont = True
        Me.Taxa_IVATextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.Taxa_IVATextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Taxa_IVATextEdit.Size = New System.Drawing.Size(147, 30)
        Me.Taxa_IVATextEdit.TabIndex = 267
        '
        'FLG_AtivoCheckEdit
        '
        Me.FLG_AtivoCheckEdit.Location = New System.Drawing.Point(380, 397)
        Me.FLG_AtivoCheckEdit.Name = "FLG_AtivoCheckEdit"
        Me.FLG_AtivoCheckEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.FLG_AtivoCheckEdit.Properties.Appearance.Options.UseFont = True
        Me.FLG_AtivoCheckEdit.Properties.Caption = ""
        Me.FLG_AtivoCheckEdit.Size = New System.Drawing.Size(75, 20)
        Me.FLG_AtivoCheckEdit.TabIndex = 266
        '
        'FLG_DescontinuadoCheckEdit
        '
        Me.FLG_DescontinuadoCheckEdit.Location = New System.Drawing.Point(668, 397)
        Me.FLG_DescontinuadoCheckEdit.Name = "FLG_DescontinuadoCheckEdit"
        Me.FLG_DescontinuadoCheckEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.FLG_DescontinuadoCheckEdit.Properties.Appearance.Options.UseFont = True
        Me.FLG_DescontinuadoCheckEdit.Properties.Caption = ""
        Me.FLG_DescontinuadoCheckEdit.Size = New System.Drawing.Size(75, 20)
        Me.FLG_DescontinuadoCheckEdit.TabIndex = 248
        '
        'Data_Inicio_VigorDateEdit
        '
        Me.Data_Inicio_VigorDateEdit.EditValue = Nothing
        Me.Data_Inicio_VigorDateEdit.Location = New System.Drawing.Point(329, 341)
        Me.Data_Inicio_VigorDateEdit.Name = "Data_Inicio_VigorDateEdit"
        Me.Data_Inicio_VigorDateEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Data_Inicio_VigorDateEdit.Properties.Appearance.Options.UseFont = True
        Me.Data_Inicio_VigorDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Data_Inicio_VigorDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Data_Inicio_VigorDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Data_Inicio_VigorDateEdit.Size = New System.Drawing.Size(124, 30)
        Me.Data_Inicio_VigorDateEdit.TabIndex = 247
        '
        'Data_Fim_VigorDateEdit
        '
        Me.Data_Fim_VigorDateEdit.EditValue = Nothing
        Me.Data_Fim_VigorDateEdit.Location = New System.Drawing.Point(625, 345)
        Me.Data_Fim_VigorDateEdit.Name = "Data_Fim_VigorDateEdit"
        Me.Data_Fim_VigorDateEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Data_Fim_VigorDateEdit.Properties.Appearance.Options.UseFont = True
        Me.Data_Fim_VigorDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Data_Fim_VigorDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Data_Fim_VigorDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Data_Fim_VigorDateEdit.Size = New System.Drawing.Size(124, 30)
        Me.Data_Fim_VigorDateEdit.TabIndex = 217
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.Enabled = False
        Me.PictureBox8.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.PictureBox8.Location = New System.Drawing.Point(325, 339)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(137, 36)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 309
        Me.PictureBox8.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.PictureBox1.Location = New System.Drawing.Point(622, 341)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(138, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 310
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Enabled = False
        Me.PictureBox2.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.PictureBox2.Location = New System.Drawing.Point(325, 282)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(435, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 311
        Me.PictureBox2.TabStop = False
        '
        'Tipo_IVATextEdit
        '
        Me.Tipo_IVATextEdit.Location = New System.Drawing.Point(333, 231)
        Me.Tipo_IVATextEdit.Name = "Tipo_IVATextEdit"
        Me.Tipo_IVATextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Tipo_IVATextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Tipo_IVATextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Tipo_IVATextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Tipo_IVATextEdit.Properties.Appearance.Options.UseFont = True
        Me.Tipo_IVATextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.Tipo_IVATextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Tipo_IVATextEdit.Size = New System.Drawing.Size(410, 30)
        Me.Tipo_IVATextEdit.TabIndex = 268
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Enabled = False
        Me.PictureBox3.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.PictureBox3.Location = New System.Drawing.Point(325, 228)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(435, 36)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 312
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Enabled = False
        Me.PictureBox4.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.PictureBox4.Location = New System.Drawing.Point(325, 169)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(137, 37)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 313
        Me.PictureBox4.TabStop = False
        '
        'Cod_IVATextEdit
        '
        Me.Cod_IVATextEdit.Location = New System.Drawing.Point(329, 172)
        Me.Cod_IVATextEdit.Name = "Cod_IVATextEdit"
        Me.Cod_IVATextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Cod_IVATextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Cod_IVATextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Cod_IVATextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Cod_IVATextEdit.Properties.Appearance.Options.UseFont = True
        Me.Cod_IVATextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.Cod_IVATextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.Cod_IVATextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Cod_IVATextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Cod_IVATextEdit.Size = New System.Drawing.Size(130, 30)
        Me.Cod_IVATextEdit.TabIndex = 229
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Enabled = False
        Me.PictureBox5.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.PictureBox5.Location = New System.Drawing.Point(596, 171)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(164, 36)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 314
        Me.PictureBox5.TabStop = False
        '
        'frmIVA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1112, 964)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UC_NAV11)
        Me.Name = "frmIVA"
        Me.Text = "frmIVA"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DesignacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Taxa_IVATextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLG_AtivoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLG_DescontinuadoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_Inicio_VigorDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_Inicio_VigorDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_Fim_VigorDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_Fim_VigorDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tipo_IVATextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_IVATextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UC_NAV11 As UC_NAV1
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Cod_IVATextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Data_Fim_VigorDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Data_Inicio_VigorDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents FLG_DescontinuadoCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents FLG_AtivoCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Taxa_IVATextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DesignacaoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Tipo_IVATextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
