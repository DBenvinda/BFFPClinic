<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTipos_Marcação
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
        Dim Label10 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Me.I21_G2DataSet1 = New PAP_G2_BFFPclinic_01_Rafael.I21_G2DataSet1()
        Me.TiposMarcacaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tipos_MarcacaoTableAdapter = New PAP_G2_BFFPclinic_01_Rafael.I21_G2DataSet1TableAdapters.Tipos_MarcacaoTableAdapter()
        Me.UC_NAV11 = New PAP_G2_BFFPclinic_01_Rafael.UC_NAV1()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FLG_AtivoCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.Cod_Tipo_MarcacaoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.picCod_Tipo_Marcacao = New System.Windows.Forms.PictureBox()
        Me.DesignacaoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.picDesignacao = New System.Windows.Forms.PictureBox()
        Label10 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        CType(Me.I21_G2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposMarcacaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.FLG_AtivoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_Tipo_MarcacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCod_Tipo_Marcacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DesignacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDesignacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Label10.Location = New System.Drawing.Point(188, 295)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(194, 25)
        Label10.TabIndex = 208
        Label10.Text = "Cod Tipo Marcação :"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Label17.Location = New System.Drawing.Point(573, 295)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(106, 25)
        Label17.TabIndex = 205
        Label17.Text = "FLG_Ativo:"
        Label17.Visible = False
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        NomeLabel.Location = New System.Drawing.Point(255, 347)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(124, 25)
        NomeLabel.TabIndex = 202
        NomeLabel.Text = "Designação :"
        '
        'I21_G2DataSet1
        '
        Me.I21_G2DataSet1.DataSetName = "I21_G2DataSet1"
        Me.I21_G2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TiposMarcacaoBindingSource
        '
        Me.TiposMarcacaoBindingSource.DataMember = "Tipos_Marcacao"
        Me.TiposMarcacaoBindingSource.DataSource = Me.I21_G2DataSet1
        '
        'Tipos_MarcacaoTableAdapter
        '
        Me.Tipos_MarcacaoTableAdapter.ClearBeforeFill = True
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
        Me.Panel1.Controls.Add(Label10)
        Me.Panel1.Controls.Add(Label17)
        Me.Panel1.Controls.Add(NomeLabel)
        Me.Panel1.Controls.Add(Me.Cod_Tipo_MarcacaoTextEdit)
        Me.Panel1.Controls.Add(Me.picCod_Tipo_Marcacao)
        Me.Panel1.Controls.Add(Me.DesignacaoTextEdit)
        Me.Panel1.Controls.Add(Me.picDesignacao)
        Me.Panel1.Location = New System.Drawing.Point(12, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1088, 879)
        Me.Panel1.TabIndex = 5
        '
        'FLG_AtivoCheckEdit
        '
        Me.FLG_AtivoCheckEdit.Location = New System.Drawing.Point(685, 300)
        Me.FLG_AtivoCheckEdit.Name = "FLG_AtivoCheckEdit"
        Me.FLG_AtivoCheckEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.FLG_AtivoCheckEdit.Properties.Appearance.Options.UseFont = True
        Me.FLG_AtivoCheckEdit.Properties.Caption = ""
        Me.FLG_AtivoCheckEdit.Size = New System.Drawing.Size(18, 20)
        Me.FLG_AtivoCheckEdit.TabIndex = 266
        '
        'Cod_Tipo_MarcacaoTextEdit
        '
        Me.Cod_Tipo_MarcacaoTextEdit.Location = New System.Drawing.Point(391, 291)
        Me.Cod_Tipo_MarcacaoTextEdit.Name = "Cod_Tipo_MarcacaoTextEdit"
        Me.Cod_Tipo_MarcacaoTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Cod_Tipo_MarcacaoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Cod_Tipo_MarcacaoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Cod_Tipo_MarcacaoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Cod_Tipo_MarcacaoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Cod_Tipo_MarcacaoTextEdit.Size = New System.Drawing.Size(158, 30)
        Me.Cod_Tipo_MarcacaoTextEdit.TabIndex = 210
        '
        'picCod_Tipo_Marcacao
        '
        Me.picCod_Tipo_Marcacao.BackColor = System.Drawing.Color.Transparent
        Me.picCod_Tipo_Marcacao.Enabled = False
        Me.picCod_Tipo_Marcacao.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.picCod_Tipo_Marcacao.Location = New System.Drawing.Point(385, 289)
        Me.picCod_Tipo_Marcacao.Name = "picCod_Tipo_Marcacao"
        Me.picCod_Tipo_Marcacao.Size = New System.Drawing.Size(167, 34)
        Me.picCod_Tipo_Marcacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCod_Tipo_Marcacao.TabIndex = 303
        Me.picCod_Tipo_Marcacao.TabStop = False
        '
        'DesignacaoTextEdit
        '
        Me.DesignacaoTextEdit.Location = New System.Drawing.Point(391, 345)
        Me.DesignacaoTextEdit.Name = "DesignacaoTextEdit"
        Me.DesignacaoTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.DesignacaoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.DesignacaoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.DesignacaoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.DesignacaoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.DesignacaoTextEdit.Size = New System.Drawing.Size(302, 30)
        Me.DesignacaoTextEdit.TabIndex = 267
        '
        'picDesignacao
        '
        Me.picDesignacao.BackColor = System.Drawing.Color.Transparent
        Me.picDesignacao.Enabled = False
        Me.picDesignacao.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.picDesignacao.Location = New System.Drawing.Point(385, 343)
        Me.picDesignacao.Name = "picDesignacao"
        Me.picDesignacao.Size = New System.Drawing.Size(315, 34)
        Me.picDesignacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDesignacao.TabIndex = 304
        Me.picDesignacao.TabStop = False
        '
        'FrmTipos_Marcação
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1112, 964)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UC_NAV11)
        Me.Name = "FrmTipos_Marcação"
        Me.Text = "FrmTipos_Marcação"
        CType(Me.I21_G2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposMarcacaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.FLG_AtivoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_Tipo_MarcacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCod_Tipo_Marcacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DesignacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDesignacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents I21_G2DataSet1 As I21_G2DataSet1
    Friend WithEvents TiposMarcacaoBindingSource As BindingSource
    Friend WithEvents Tipos_MarcacaoTableAdapter As I21_G2DataSet1TableAdapters.Tipos_MarcacaoTableAdapter
    Friend WithEvents UC_NAV11 As UC_NAV1
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Cod_Tipo_MarcacaoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FLG_AtivoCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DesignacaoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picCod_Tipo_Marcacao As PictureBox
    Friend WithEvents picDesignacao As PictureBox
End Class
