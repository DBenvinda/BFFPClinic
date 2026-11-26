<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCategorias
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
        Dim Label10 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Me.UC_NAV11 = New PAP_G2_BFFPclinic_01_Rafael.UC_NAV1()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FLG_AtivoCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ImagemTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.btnApaga = New System.Windows.Forms.Button()
        Me.btnCarrega = New System.Windows.Forms.Button()
        Me.pbCategorias_Imagem = New System.Windows.Forms.PictureBox()
        Me.Cod_CategoriaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DesignacaoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.OFDCategorias = New System.Windows.Forms.OpenFileDialog()
        Label10 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.FLG_AtivoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagemTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCategorias_Imagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_CategoriaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DesignacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Label10.Location = New System.Drawing.Point(78, 207)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(149, 25)
        Label10.TabIndex = 187
        Label10.Text = "Cod Categoria :"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Label17.Location = New System.Drawing.Point(458, 211)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(106, 25)
        Label17.TabIndex = 184
        Label17.Text = "FLG_Ativo:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        NomeLabel.Location = New System.Drawing.Point(100, 279)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(124, 25)
        NomeLabel.TabIndex = 181
        NomeLabel.Text = "Designação :"
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
        Me.Panel1.Controls.Add(Me.FLG_AtivoCheckEdit)
        Me.Panel1.Controls.Add(Me.ImagemTextEdit)
        Me.Panel1.Controls.Add(Me.btnApaga)
        Me.Panel1.Controls.Add(Me.btnCarrega)
        Me.Panel1.Controls.Add(Me.pbCategorias_Imagem)
        Me.Panel1.Controls.Add(Me.Cod_CategoriaTextEdit)
        Me.Panel1.Controls.Add(Label10)
        Me.Panel1.Controls.Add(Label17)
        Me.Panel1.Controls.Add(Me.DesignacaoTextEdit)
        Me.Panel1.Controls.Add(NomeLabel)
        Me.Panel1.Controls.Add(Me.PictureBox14)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(12, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1088, 881)
        Me.Panel1.TabIndex = 7
        '
        'FLG_AtivoCheckEdit
        '
        Me.FLG_AtivoCheckEdit.Location = New System.Drawing.Point(570, 215)
        Me.FLG_AtivoCheckEdit.Name = "FLG_AtivoCheckEdit"
        Me.FLG_AtivoCheckEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.FLG_AtivoCheckEdit.Properties.Appearance.Options.UseFont = True
        Me.FLG_AtivoCheckEdit.Properties.Caption = ""
        Me.FLG_AtivoCheckEdit.Size = New System.Drawing.Size(75, 20)
        Me.FLG_AtivoCheckEdit.TabIndex = 265
        '
        'ImagemTextEdit
        '
        Me.ImagemTextEdit.Location = New System.Drawing.Point(759, 342)
        Me.ImagemTextEdit.Name = "ImagemTextEdit"
        Me.ImagemTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.ImagemTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ImagemTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.ImagemTextEdit.Properties.Appearance.Options.UseFont = True
        Me.ImagemTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ImagemTextEdit.Size = New System.Drawing.Size(127, 30)
        Me.ImagemTextEdit.TabIndex = 193
        '
        'btnApaga
        '
        Me.btnApaga.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnApaga.Location = New System.Drawing.Point(835, 380)
        Me.btnApaga.Name = "btnApaga"
        Me.btnApaga.Size = New System.Drawing.Size(101, 33)
        Me.btnApaga.TabIndex = 192
        Me.btnApaga.Text = "Apagar Imagem"
        Me.btnApaga.UseVisualStyleBackColor = True
        '
        'btnCarrega
        '
        Me.btnCarrega.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnCarrega.Location = New System.Drawing.Point(707, 378)
        Me.btnCarrega.Name = "btnCarrega"
        Me.btnCarrega.Size = New System.Drawing.Size(101, 33)
        Me.btnCarrega.TabIndex = 191
        Me.btnCarrega.Text = "Carregar Imagem"
        Me.btnCarrega.UseVisualStyleBackColor = True
        '
        'pbCategorias_Imagem
        '
        Me.pbCategorias_Imagem.Location = New System.Drawing.Point(707, 129)
        Me.pbCategorias_Imagem.Name = "pbCategorias_Imagem"
        Me.pbCategorias_Imagem.Size = New System.Drawing.Size(229, 207)
        Me.pbCategorias_Imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCategorias_Imagem.TabIndex = 190
        Me.pbCategorias_Imagem.TabStop = False
        '
        'Cod_CategoriaTextEdit
        '
        Me.Cod_CategoriaTextEdit.Location = New System.Drawing.Point(236, 205)
        Me.Cod_CategoriaTextEdit.Name = "Cod_CategoriaTextEdit"
        Me.Cod_CategoriaTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Cod_CategoriaTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Cod_CategoriaTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Cod_CategoriaTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Cod_CategoriaTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Cod_CategoriaTextEdit.Size = New System.Drawing.Size(155, 30)
        Me.Cod_CategoriaTextEdit.TabIndex = 189
        '
        'DesignacaoTextEdit
        '
        Me.DesignacaoTextEdit.Location = New System.Drawing.Point(236, 277)
        Me.DesignacaoTextEdit.Name = "DesignacaoTextEdit"
        Me.DesignacaoTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.DesignacaoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.DesignacaoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.DesignacaoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.DesignacaoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.DesignacaoTextEdit.Size = New System.Drawing.Size(412, 30)
        Me.DesignacaoTextEdit.TabIndex = 180
        '
        'PictureBox14
        '
        Me.PictureBox14.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox14.Enabled = False
        Me.PictureBox14.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.PictureBox14.Location = New System.Drawing.Point(230, 274)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(424, 36)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox14.TabIndex = 303
        Me.PictureBox14.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.PictureBox1.Location = New System.Drawing.Point(230, 203)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 304
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Enabled = False
        Me.PictureBox2.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.PictureBox2.Location = New System.Drawing.Point(752, 340)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(140, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 305
        Me.PictureBox2.TabStop = False
        '
        'OFDCategorias
        '
        Me.OFDCategorias.FileName = "OpenFileDialog1"
        '
        'FrmCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1112, 964)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UC_NAV11)
        Me.Name = "FrmCategorias"
        Me.Text = "FrmCategorias"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.FLG_AtivoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagemTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCategorias_Imagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_CategoriaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DesignacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UC_NAV11 As UC_NAV1
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbCategorias_Imagem As PictureBox
    Friend WithEvents Cod_CategoriaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DesignacaoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ImagemTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnApaga As Button
    Friend WithEvents btnCarrega As Button
    Friend WithEvents FLG_AtivoCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents OFDCategorias As OpenFileDialog
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
