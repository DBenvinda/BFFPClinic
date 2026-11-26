<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSeries
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
        Dim Label2 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FLG_Tipo_DocTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ContadorTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Ano_TrabalhoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FLG_AtivoCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.BtnCriarSerie = New System.Windows.Forms.Button()
        Me.Cod_SerieTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.picAno_Trabalho = New System.Windows.Forms.PictureBox()
        Me.picCod_Serie = New System.Windows.Forms.PictureBox()
        Me.picContador = New System.Windows.Forms.PictureBox()
        Me.picFLG_TipoDoc = New System.Windows.Forms.PictureBox()
        Me.UC_NAV11 = New PAP_G2_BFFPclinic_01_Rafael.UC_NAV1()
        Label2 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.FLG_Tipo_DocTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContadorTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ano_TrabalhoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLG_AtivoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_SerieTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAno_Trabalho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCod_Serie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picContador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFLG_TipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Label2.Location = New System.Drawing.Point(521, 247)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(107, 25)
        Label2.TabIndex = 216
        Label2.Text = "Contador :"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Label10.Location = New System.Drawing.Point(194, 250)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(102, 25)
        Label10.TabIndex = 208
        Label10.Text = "Cod Serie:"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Label17.Location = New System.Drawing.Point(494, 301)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(134, 25)
        Label17.TabIndex = 205
        Label17.Text = "FLG_TipoDoc:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        NomeLabel.Location = New System.Drawing.Point(157, 304)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(137, 25)
        NomeLabel.TabIndex = 202
        NomeLabel.Text = "Ano Trabalho:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Label1.Location = New System.Drawing.Point(409, 349)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(111, 25)
        Label1.TabIndex = 218
        Label1.Text = "FLG_Ativo :"
        Label1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Controls.Add(Me.FLG_Tipo_DocTextEdit)
        Me.Panel1.Controls.Add(Me.ContadorTextEdit)
        Me.Panel1.Controls.Add(Me.Ano_TrabalhoTextEdit)
        Me.Panel1.Controls.Add(Me.FLG_AtivoCheckEdit)
        Me.Panel1.Controls.Add(Me.BtnCriarSerie)
        Me.Panel1.Controls.Add(Label1)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Label10)
        Me.Panel1.Controls.Add(Label17)
        Me.Panel1.Controls.Add(NomeLabel)
        Me.Panel1.Controls.Add(Me.Cod_SerieTextEdit)
        Me.Panel1.Controls.Add(Me.picAno_Trabalho)
        Me.Panel1.Controls.Add(Me.picCod_Serie)
        Me.Panel1.Controls.Add(Me.picContador)
        Me.Panel1.Controls.Add(Me.picFLG_TipoDoc)
        Me.Panel1.Location = New System.Drawing.Point(12, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1088, 882)
        Me.Panel1.TabIndex = 7
        '
        'FLG_Tipo_DocTextEdit
        '
        Me.FLG_Tipo_DocTextEdit.Location = New System.Drawing.Point(639, 299)
        Me.FLG_Tipo_DocTextEdit.Name = "FLG_Tipo_DocTextEdit"
        Me.FLG_Tipo_DocTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.FLG_Tipo_DocTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.FLG_Tipo_DocTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.FLG_Tipo_DocTextEdit.Properties.Appearance.Options.UseFont = True
        Me.FLG_Tipo_DocTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.FLG_Tipo_DocTextEdit.Size = New System.Drawing.Size(97, 30)
        Me.FLG_Tipo_DocTextEdit.TabIndex = 269
        '
        'ContadorTextEdit
        '
        Me.ContadorTextEdit.EditValue = "            "
        Me.ContadorTextEdit.Location = New System.Drawing.Point(638, 243)
        Me.ContadorTextEdit.Name = "ContadorTextEdit"
        Me.ContadorTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.ContadorTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ContadorTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.ContadorTextEdit.Properties.Appearance.Options.UseFont = True
        Me.ContadorTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ContadorTextEdit.Size = New System.Drawing.Size(97, 30)
        Me.ContadorTextEdit.TabIndex = 268
        '
        'Ano_TrabalhoTextEdit
        '
        Me.Ano_TrabalhoTextEdit.Location = New System.Drawing.Point(302, 298)
        Me.Ano_TrabalhoTextEdit.Name = "Ano_TrabalhoTextEdit"
        Me.Ano_TrabalhoTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Ano_TrabalhoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Ano_TrabalhoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Ano_TrabalhoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Ano_TrabalhoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Ano_TrabalhoTextEdit.Size = New System.Drawing.Size(158, 30)
        Me.Ano_TrabalhoTextEdit.TabIndex = 267
        '
        'FLG_AtivoCheckEdit
        '
        Me.FLG_AtivoCheckEdit.Location = New System.Drawing.Point(526, 354)
        Me.FLG_AtivoCheckEdit.Name = "FLG_AtivoCheckEdit"
        Me.FLG_AtivoCheckEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.FLG_AtivoCheckEdit.Properties.Appearance.Options.UseFont = True
        Me.FLG_AtivoCheckEdit.Properties.Caption = ""
        Me.FLG_AtivoCheckEdit.Size = New System.Drawing.Size(75, 20)
        Me.FLG_AtivoCheckEdit.TabIndex = 266
        '
        'BtnCriarSerie
        '
        Me.BtnCriarSerie.FlatAppearance.BorderSize = 0
        Me.BtnCriarSerie.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BtnCriarSerie.Location = New System.Drawing.Point(456, 389)
        Me.BtnCriarSerie.Name = "BtnCriarSerie"
        Me.BtnCriarSerie.Size = New System.Drawing.Size(125, 35)
        Me.BtnCriarSerie.TabIndex = 219
        Me.BtnCriarSerie.Text = "Criar Serie"
        Me.BtnCriarSerie.UseVisualStyleBackColor = True
        '
        'Cod_SerieTextEdit
        '
        Me.Cod_SerieTextEdit.Location = New System.Drawing.Point(309, 243)
        Me.Cod_SerieTextEdit.Name = "Cod_SerieTextEdit"
        Me.Cod_SerieTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Cod_SerieTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Cod_SerieTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Cod_SerieTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Cod_SerieTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Cod_SerieTextEdit.Size = New System.Drawing.Size(158, 30)
        Me.Cod_SerieTextEdit.TabIndex = 210
        '
        'picAno_Trabalho
        '
        Me.picAno_Trabalho.BackColor = System.Drawing.Color.Transparent
        Me.picAno_Trabalho.Enabled = False
        Me.picAno_Trabalho.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.picAno_Trabalho.Location = New System.Drawing.Point(300, 296)
        Me.picAno_Trabalho.Name = "picAno_Trabalho"
        Me.picAno_Trabalho.Size = New System.Drawing.Size(176, 34)
        Me.picAno_Trabalho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAno_Trabalho.TabIndex = 303
        Me.picAno_Trabalho.TabStop = False
        '
        'picCod_Serie
        '
        Me.picCod_Serie.BackColor = System.Drawing.Color.Transparent
        Me.picCod_Serie.Enabled = False
        Me.picCod_Serie.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.picCod_Serie.Location = New System.Drawing.Point(300, 241)
        Me.picCod_Serie.Name = "picCod_Serie"
        Me.picCod_Serie.Size = New System.Drawing.Size(176, 34)
        Me.picCod_Serie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCod_Serie.TabIndex = 304
        Me.picCod_Serie.TabStop = False
        '
        'picContador
        '
        Me.picContador.BackColor = System.Drawing.Color.Transparent
        Me.picContador.Enabled = False
        Me.picContador.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.picContador.Location = New System.Drawing.Point(634, 241)
        Me.picContador.Name = "picContador"
        Me.picContador.Size = New System.Drawing.Size(108, 34)
        Me.picContador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picContador.TabIndex = 306
        Me.picContador.TabStop = False
        '
        'picFLG_TipoDoc
        '
        Me.picFLG_TipoDoc.BackColor = System.Drawing.Color.Transparent
        Me.picFLG_TipoDoc.Enabled = False
        Me.picFLG_TipoDoc.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.picFLG_TipoDoc.Location = New System.Drawing.Point(634, 297)
        Me.picFLG_TipoDoc.Name = "picFLG_TipoDoc"
        Me.picFLG_TipoDoc.Size = New System.Drawing.Size(108, 34)
        Me.picFLG_TipoDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFLG_TipoDoc.TabIndex = 305
        Me.picFLG_TipoDoc.TabStop = False
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
        'frmSeries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1112, 964)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UC_NAV11)
        Me.Name = "frmSeries"
        Me.Text = "frmSeries"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.FLG_Tipo_DocTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContadorTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ano_TrabalhoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLG_AtivoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_SerieTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAno_Trabalho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCod_Serie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picContador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFLG_TipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UC_NAV11 As UC_NAV1
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Cod_SerieTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnCriarSerie As Button
    Friend WithEvents FLG_AtivoCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Ano_TrabalhoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FLG_Tipo_DocTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContadorTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picAno_Trabalho As PictureBox
    Friend WithEvents picCod_Serie As PictureBox
    Friend WithEvents picContador As PictureBox
    Friend WithEvents picFLG_TipoDoc As PictureBox
End Class
