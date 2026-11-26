<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipos_Pagamento
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Me.UC_NAV11 = New PAP_G2_BFFPclinic_01_Rafael.UC_NAV1()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FLG_AtivoCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.Tipo_PagamentoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_Tipo_PagamentoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Label1 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.FLG_AtivoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tipo_PagamentoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_Tipo_PagamentoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Label1.Location = New System.Drawing.Point(350, 390)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(111, 25)
        Label1.TabIndex = 213
        Label1.Text = "FLG_Ativo :"
        Label1.Visible = False
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Label10.Location = New System.Drawing.Point(258, 284)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(205, 25)
        Label10.TabIndex = 208
        Label10.Text = "Cod Tipo Pagamento:"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Label17.Location = New System.Drawing.Point(297, 341)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(164, 25)
        Label17.TabIndex = 205
        Label17.Text = "Tipo Pagamento:"
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
        Me.Panel1.Controls.Add(Me.Tipo_PagamentoTextEdit)
        Me.Panel1.Controls.Add(Label1)
        Me.Panel1.Controls.Add(Label10)
        Me.Panel1.Controls.Add(Label17)
        Me.Panel1.Controls.Add(Me.Cod_Tipo_PagamentoTextEdit)
        Me.Panel1.Controls.Add(Me.PictureBox14)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1088, 882)
        Me.Panel1.TabIndex = 6
        '
        'FLG_AtivoCheckEdit
        '
        Me.FLG_AtivoCheckEdit.Location = New System.Drawing.Point(470, 395)
        Me.FLG_AtivoCheckEdit.Name = "FLG_AtivoCheckEdit"
        Me.FLG_AtivoCheckEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.FLG_AtivoCheckEdit.Properties.Appearance.Options.UseFont = True
        Me.FLG_AtivoCheckEdit.Properties.Caption = ""
        Me.FLG_AtivoCheckEdit.Size = New System.Drawing.Size(75, 20)
        Me.FLG_AtivoCheckEdit.TabIndex = 266
        '
        'Tipo_PagamentoTextEdit
        '
        Me.Tipo_PagamentoTextEdit.Location = New System.Drawing.Point(470, 339)
        Me.Tipo_PagamentoTextEdit.Name = "Tipo_PagamentoTextEdit"
        Me.Tipo_PagamentoTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Tipo_PagamentoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Tipo_PagamentoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Tipo_PagamentoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Tipo_PagamentoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Tipo_PagamentoTextEdit.Size = New System.Drawing.Size(158, 30)
        Me.Tipo_PagamentoTextEdit.TabIndex = 218
        '
        'Cod_Tipo_PagamentoTextEdit
        '
        Me.Cod_Tipo_PagamentoTextEdit.Location = New System.Drawing.Point(469, 282)
        Me.Cod_Tipo_PagamentoTextEdit.Name = "Cod_Tipo_PagamentoTextEdit"
        Me.Cod_Tipo_PagamentoTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Cod_Tipo_PagamentoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Cod_Tipo_PagamentoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Cod_Tipo_PagamentoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Cod_Tipo_PagamentoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Cod_Tipo_PagamentoTextEdit.Size = New System.Drawing.Size(158, 30)
        Me.Cod_Tipo_PagamentoTextEdit.TabIndex = 210
        '
        'PictureBox14
        '
        Me.PictureBox14.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox14.Enabled = False
        Me.PictureBox14.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.PictureBox14.Location = New System.Drawing.Point(467, 280)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(164, 34)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox14.TabIndex = 303
        Me.PictureBox14.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.PictureBox1.Location = New System.Drawing.Point(467, 337)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(164, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 304
        Me.PictureBox1.TabStop = False
        '
        'frmTipos_Pagamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1112, 964)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UC_NAV11)
        Me.Name = "frmTipos_Pagamento"
        Me.Text = "frmTipos_Pagamento"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.FLG_AtivoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tipo_PagamentoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_Tipo_PagamentoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UC_NAV11 As UC_NAV1
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Cod_Tipo_PagamentoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Tipo_PagamentoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FLG_AtivoCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
