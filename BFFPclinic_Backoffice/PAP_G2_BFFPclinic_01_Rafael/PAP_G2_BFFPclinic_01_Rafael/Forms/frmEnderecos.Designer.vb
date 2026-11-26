<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEnderecos
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
        Dim Label5 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim NIFLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsPT_Enderecos", -1)
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Distrito")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Concelho")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Postal")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Endereco")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Localidade")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnderecos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FLG_AtivoCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.LocalidadeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_Endereco_TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DescritivoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_Entidade_TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ucCod_Postal = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Cod_Postal_TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.picCod_Entidade = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Data_RegistoDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.picCod_Postal = New System.Windows.Forms.PictureBox()
        Me.ucEnderecos = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Endereco_TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.cbLocalidade = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.BarNAV = New DevExpress.XtraBars.Bar()
        Me.Bar4 = New DevExpress.XtraBars.Bar()
        Me.Bar5 = New DevExpress.XtraBars.Bar()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.ClsPTEnderecosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.bbStatus = New DevExpress.XtraBars.BarStaticItem()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.bbNovo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbModifica = New DevExpress.XtraBars.BarButtonItem()
        Me.bbApaga = New DevExpress.XtraBars.BarButtonItem()
        Me.bbSair = New DevExpress.XtraBars.BarButtonItem()
        Me.bbGrava = New DevExpress.XtraBars.BarButtonItem()
        Me.bbCancela = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.bbPrimeiro = New DevExpress.XtraBars.BarButtonItem()
        Me.bbAnterior = New DevExpress.XtraBars.BarButtonItem()
        Me.bbSeguinte = New DevExpress.XtraBars.BarButtonItem()
        Me.bbUltimo = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Label5 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        NIFLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.FLG_AtivoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_Endereco_TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescritivoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_Entidade_TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucCod_Postal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_Postal_TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCod_Entidade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_RegistoDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_RegistoDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCod_Postal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucEnderecos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Endereco_TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbLocalidade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClsPTEnderecosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Label5.Location = New System.Drawing.Point(623, 180)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(106, 25)
        Label5.TabIndex = 207
        Label5.Text = "FLG_Ativo:"
        Label5.Visible = False
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Label4.Location = New System.Drawing.Point(234, 480)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(129, 25)
        Label4.TabIndex = 205
        Label4.Text = "Data Registo:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Label1.Location = New System.Drawing.Point(222, 240)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(141, 25)
        Label1.TabIndex = 203
        Label1.Text = "Cod Endereço:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Label3.Location = New System.Drawing.Point(251, 360)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(112, 25)
        Label3.TabIndex = 200
        Label3.Text = "Localidade:"
        '
        'NIFLabel
        '
        NIFLabel.AutoSize = True
        NIFLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        NIFLabel.Location = New System.Drawing.Point(547, 238)
        NIFLabel.Name = "NIFLabel"
        NIFLabel.Size = New System.Drawing.Size(111, 25)
        NIFLabel.TabIndex = 191
        NIFLabel.Text = "Cod Postal:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        EmailLabel.Location = New System.Drawing.Point(263, 420)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(100, 25)
        EmailLabel.TabIndex = 190
        EmailLabel.Text = "Endereço:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        NomeLabel.Location = New System.Drawing.Point(258, 300)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(105, 25)
        NomeLabel.TabIndex = 189
        NomeLabel.Text = "Descritivo:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Label7.Location = New System.Drawing.Point(227, 180)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(136, 25)
        Label7.TabIndex = 188
        Label7.Text = "Cod Entidade:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Controls.Add(Me.FLG_AtivoCheckEdit)
        Me.Panel1.Controls.Add(Me.LocalidadeTextEdit)
        Me.Panel1.Controls.Add(Me.Cod_Endereco_TextEdit)
        Me.Panel1.Controls.Add(Label5)
        Me.Panel1.Controls.Add(Label4)
        Me.Panel1.Controls.Add(Label1)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Me.DescritivoTextEdit)
        Me.Panel1.Controls.Add(NIFLabel)
        Me.Panel1.Controls.Add(EmailLabel)
        Me.Panel1.Controls.Add(NomeLabel)
        Me.Panel1.Controls.Add(Label7)
        Me.Panel1.Controls.Add(Me.Cod_Entidade_TextEdit)
        Me.Panel1.Controls.Add(Me.ucCod_Postal)
        Me.Panel1.Controls.Add(Me.Cod_Postal_TextEdit)
        Me.Panel1.Controls.Add(Me.picCod_Entidade)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.Data_RegistoDateEdit)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.picCod_Postal)
        Me.Panel1.Controls.Add(Me.ucEnderecos)
        Me.Panel1.Controls.Add(Me.Endereco_TextEdit)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Location = New System.Drawing.Point(12, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1088, 890)
        Me.Panel1.TabIndex = 0
        '
        'FLG_AtivoCheckEdit
        '
        Me.FLG_AtivoCheckEdit.Location = New System.Drawing.Point(735, 185)
        Me.FLG_AtivoCheckEdit.Name = "FLG_AtivoCheckEdit"
        Me.FLG_AtivoCheckEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.FLG_AtivoCheckEdit.Properties.Appearance.Options.UseFont = True
        Me.FLG_AtivoCheckEdit.Properties.Caption = ""
        Me.FLG_AtivoCheckEdit.Size = New System.Drawing.Size(75, 20)
        Me.FLG_AtivoCheckEdit.TabIndex = 266
        Me.FLG_AtivoCheckEdit.Tag = "frmEnderecos"
        Me.FLG_AtivoCheckEdit.Visible = False
        '
        'LocalidadeTextEdit
        '
        Me.LocalidadeTextEdit.Location = New System.Drawing.Point(383, 356)
        Me.LocalidadeTextEdit.Name = "LocalidadeTextEdit"
        Me.LocalidadeTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.LocalidadeTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.LocalidadeTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.LocalidadeTextEdit.Properties.Appearance.Options.UseFont = True
        Me.LocalidadeTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LocalidadeTextEdit.Size = New System.Drawing.Size(419, 30)
        Me.LocalidadeTextEdit.TabIndex = 211
        '
        'Cod_Endereco_TextEdit
        '
        Me.Cod_Endereco_TextEdit.Location = New System.Drawing.Point(382, 238)
        Me.Cod_Endereco_TextEdit.Name = "Cod_Endereco_TextEdit"
        Me.Cod_Endereco_TextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Cod_Endereco_TextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Cod_Endereco_TextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Cod_Endereco_TextEdit.Properties.Appearance.Options.UseFont = True
        Me.Cod_Endereco_TextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Cod_Endereco_TextEdit.Size = New System.Drawing.Size(130, 30)
        Me.Cod_Endereco_TextEdit.TabIndex = 209
        '
        'DescritivoTextEdit
        '
        Me.DescritivoTextEdit.Location = New System.Drawing.Point(382, 296)
        Me.DescritivoTextEdit.Name = "DescritivoTextEdit"
        Me.DescritivoTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.DescritivoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.DescritivoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.DescritivoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.DescritivoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.DescritivoTextEdit.Size = New System.Drawing.Size(418, 30)
        Me.DescritivoTextEdit.TabIndex = 185
        '
        'Cod_Entidade_TextEdit
        '
        Me.Cod_Entidade_TextEdit.Location = New System.Drawing.Point(382, 173)
        Me.Cod_Entidade_TextEdit.Name = "Cod_Entidade_TextEdit"
        Me.Cod_Entidade_TextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Cod_Entidade_TextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Cod_Entidade_TextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Cod_Entidade_TextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Cod_Entidade_TextEdit.Properties.Appearance.Options.UseFont = True
        Me.Cod_Entidade_TextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.Cod_Entidade_TextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.Cod_Entidade_TextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Cod_Entidade_TextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Cod_Entidade_TextEdit.Size = New System.Drawing.Size(130, 30)
        Me.Cod_Entidade_TextEdit.TabIndex = 193
        '
        'ucCod_Postal
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucCod_Postal.DisplayLayout.Appearance = Appearance1
        Me.ucCod_Postal.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucCod_Postal.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.ucCod_Postal.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucCod_Postal.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.ucCod_Postal.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucCod_Postal.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.ucCod_Postal.DisplayLayout.MaxColScrollRegions = 1
        Me.ucCod_Postal.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucCod_Postal.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ucCod_Postal.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.ucCod_Postal.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucCod_Postal.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.ucCod_Postal.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ucCod_Postal.DisplayLayout.Override.CellAppearance = Appearance8
        Me.ucCod_Postal.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucCod_Postal.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.ucCod_Postal.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.ucCod_Postal.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.ucCod_Postal.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucCod_Postal.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.ucCod_Postal.DisplayLayout.Override.RowAppearance = Appearance11
        Me.ucCod_Postal.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ucCod_Postal.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.ucCod_Postal.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucCod_Postal.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucCod_Postal.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ucCod_Postal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ucCod_Postal.Location = New System.Drawing.Point(664, 232)
        Me.ucCod_Postal.Name = "ucCod_Postal"
        Me.ucCod_Postal.Size = New System.Drawing.Size(152, 36)
        Me.ucCod_Postal.TabIndex = 14
        '
        'Cod_Postal_TextEdit
        '
        Me.Cod_Postal_TextEdit.EditValue = ""
        Me.Cod_Postal_TextEdit.Location = New System.Drawing.Point(668, 236)
        Me.Cod_Postal_TextEdit.Name = "Cod_Postal_TextEdit"
        Me.Cod_Postal_TextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Cod_Postal_TextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Cod_Postal_TextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Cod_Postal_TextEdit.Properties.Appearance.Options.UseFont = True
        Me.Cod_Postal_TextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Cod_Postal_TextEdit.Size = New System.Drawing.Size(142, 30)
        Me.Cod_Postal_TextEdit.TabIndex = 186
        '
        'picCod_Entidade
        '
        Me.picCod_Entidade.BackColor = System.Drawing.Color.Transparent
        Me.picCod_Entidade.Enabled = False
        Me.picCod_Entidade.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.picCod_Entidade.Location = New System.Drawing.Point(377, 171)
        Me.picCod_Entidade.Name = "picCod_Entidade"
        Me.picCod_Entidade.Size = New System.Drawing.Size(140, 34)
        Me.picCod_Entidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCod_Entidade.TabIndex = 307
        Me.picCod_Entidade.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.PictureBox1.Location = New System.Drawing.Point(377, 235)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 308
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Enabled = False
        Me.PictureBox2.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.PictureBox2.Location = New System.Drawing.Point(377, 294)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(439, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 309
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Enabled = False
        Me.PictureBox4.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.PictureBox4.Location = New System.Drawing.Point(377, 354)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(439, 34)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 310
        Me.PictureBox4.TabStop = False
        '
        'Data_RegistoDateEdit
        '
        Me.Data_RegistoDateEdit.EditValue = Nothing
        Me.Data_RegistoDateEdit.Location = New System.Drawing.Point(383, 482)
        Me.Data_RegistoDateEdit.Name = "Data_RegistoDateEdit"
        Me.Data_RegistoDateEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Data_RegistoDateEdit.Properties.Appearance.Options.UseFont = True
        Me.Data_RegistoDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Data_RegistoDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Data_RegistoDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Data_RegistoDateEdit.Size = New System.Drawing.Size(184, 30)
        Me.Data_RegistoDateEdit.TabIndex = 13
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Enabled = False
        Me.PictureBox6.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.PictureBox6.Location = New System.Drawing.Point(377, 480)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(196, 34)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 312
        Me.PictureBox6.TabStop = False
        '
        'picCod_Postal
        '
        Me.picCod_Postal.BackColor = System.Drawing.Color.Transparent
        Me.picCod_Postal.Enabled = False
        Me.picCod_Postal.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.picCod_Postal.Location = New System.Drawing.Point(664, 234)
        Me.picCod_Postal.Name = "picCod_Postal"
        Me.picCod_Postal.Size = New System.Drawing.Size(152, 34)
        Me.picCod_Postal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCod_Postal.TabIndex = 313
        Me.picCod_Postal.TabStop = False
        '
        'ucEnderecos
        '
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucEnderecos.DisplayLayout.Appearance = Appearance13
        UltraGridColumn37.Header.VisiblePosition = 0
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.Header.VisiblePosition = 1
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.Header.VisiblePosition = 2
        UltraGridColumn39.Hidden = True
        UltraGridColumn40.Header.VisiblePosition = 3
        UltraGridColumn40.Width = 351
        UltraGridColumn41.Header.VisiblePosition = 4
        UltraGridColumn41.Hidden = True
        UltraGridColumn42.Header.VisiblePosition = 5
        UltraGridColumn42.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42})
        Me.ucEnderecos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ucEnderecos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucEnderecos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance14.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        Me.ucEnderecos.DisplayLayout.GroupByBox.Appearance = Appearance14
        Appearance15.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucEnderecos.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance15
        Me.ucEnderecos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance16.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance16.BackColor2 = System.Drawing.SystemColors.Control
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucEnderecos.DisplayLayout.GroupByBox.PromptAppearance = Appearance16
        Me.ucEnderecos.DisplayLayout.MaxColScrollRegions = 1
        Me.ucEnderecos.DisplayLayout.MaxRowScrollRegions = 1
        Appearance17.BackColor = System.Drawing.SystemColors.Window
        Appearance17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucEnderecos.DisplayLayout.Override.ActiveCellAppearance = Appearance17
        Appearance18.BackColor = System.Drawing.SystemColors.Highlight
        Appearance18.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ucEnderecos.DisplayLayout.Override.ActiveRowAppearance = Appearance18
        Me.ucEnderecos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucEnderecos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Me.ucEnderecos.DisplayLayout.Override.CardAreaAppearance = Appearance19
        Appearance20.BorderColor = System.Drawing.Color.Silver
        Appearance20.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ucEnderecos.DisplayLayout.Override.CellAppearance = Appearance20
        Me.ucEnderecos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucEnderecos.DisplayLayout.Override.CellPadding = 0
        Appearance21.BackColor = System.Drawing.SystemColors.Control
        Appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance21.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance21.BorderColor = System.Drawing.SystemColors.Window
        Me.ucEnderecos.DisplayLayout.Override.GroupByRowAppearance = Appearance21
        Appearance22.TextHAlignAsString = "Left"
        Me.ucEnderecos.DisplayLayout.Override.HeaderAppearance = Appearance22
        Me.ucEnderecos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucEnderecos.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Appearance23.BorderColor = System.Drawing.Color.Silver
        Me.ucEnderecos.DisplayLayout.Override.RowAppearance = Appearance23
        Me.ucEnderecos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance24.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ucEnderecos.DisplayLayout.Override.TemplateAddRowAppearance = Appearance24
        Me.ucEnderecos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucEnderecos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucEnderecos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ucEnderecos.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ucEnderecos.Location = New System.Drawing.Point(377, 422)
        Me.ucEnderecos.Name = "ucEnderecos"
        Me.ucEnderecos.Size = New System.Drawing.Size(439, 36)
        Me.ucEnderecos.TabIndex = 15
        Me.ucEnderecos.Visible = False
        '
        'Endereco_TextEdit
        '
        Me.Endereco_TextEdit.Location = New System.Drawing.Point(382, 424)
        Me.Endereco_TextEdit.Name = "Endereco_TextEdit"
        Me.Endereco_TextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Endereco_TextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Endereco_TextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Endereco_TextEdit.Properties.Appearance.Options.UseFont = True
        Me.Endereco_TextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Endereco_TextEdit.Size = New System.Drawing.Size(419, 30)
        Me.Endereco_TextEdit.TabIndex = 187
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Enabled = False
        Me.PictureBox5.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.PictureBox5.Location = New System.Drawing.Point(377, 422)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(439, 34)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 311
        Me.PictureBox5.TabStop = False
        '
        'cbLocalidade
        '
        Appearance25.BackColor = System.Drawing.SystemColors.Window
        Appearance25.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cbLocalidade.DisplayLayout.Appearance = Appearance25
        Me.cbLocalidade.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cbLocalidade.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance26.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance26.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance26.BorderColor = System.Drawing.SystemColors.Window
        Me.cbLocalidade.DisplayLayout.GroupByBox.Appearance = Appearance26
        Appearance27.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cbLocalidade.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance27
        Me.cbLocalidade.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance28.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance28.BackColor2 = System.Drawing.SystemColors.Control
        Appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance28.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cbLocalidade.DisplayLayout.GroupByBox.PromptAppearance = Appearance28
        Me.cbLocalidade.DisplayLayout.MaxColScrollRegions = 1
        Me.cbLocalidade.DisplayLayout.MaxRowScrollRegions = 1
        Appearance29.BackColor = System.Drawing.SystemColors.Window
        Appearance29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbLocalidade.DisplayLayout.Override.ActiveCellAppearance = Appearance29
        Appearance30.BackColor = System.Drawing.SystemColors.Highlight
        Appearance30.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cbLocalidade.DisplayLayout.Override.ActiveRowAppearance = Appearance30
        Me.cbLocalidade.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cbLocalidade.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance31.BackColor = System.Drawing.SystemColors.Window
        Me.cbLocalidade.DisplayLayout.Override.CardAreaAppearance = Appearance31
        Appearance32.BorderColor = System.Drawing.Color.Silver
        Appearance32.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cbLocalidade.DisplayLayout.Override.CellAppearance = Appearance32
        Me.cbLocalidade.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cbLocalidade.DisplayLayout.Override.CellPadding = 0
        Appearance33.BackColor = System.Drawing.SystemColors.Control
        Appearance33.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance33.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance33.BorderColor = System.Drawing.SystemColors.Window
        Me.cbLocalidade.DisplayLayout.Override.GroupByRowAppearance = Appearance33
        Appearance34.TextHAlignAsString = "Left"
        Me.cbLocalidade.DisplayLayout.Override.HeaderAppearance = Appearance34
        Me.cbLocalidade.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cbLocalidade.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance35.BackColor = System.Drawing.SystemColors.Window
        Appearance35.BorderColor = System.Drawing.Color.Silver
        Me.cbLocalidade.DisplayLayout.Override.RowAppearance = Appearance35
        Me.cbLocalidade.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance36.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cbLocalidade.DisplayLayout.Override.TemplateAddRowAppearance = Appearance36
        Me.cbLocalidade.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cbLocalidade.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cbLocalidade.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cbLocalidade.Location = New System.Drawing.Point(268, 257)
        Me.cbLocalidade.Name = "cbLocalidade"
        Me.cbLocalidade.Size = New System.Drawing.Size(412, 22)
        Me.cbLocalidade.TabIndex = 199
        '
        'BarNAV
        '
        Me.BarNAV.BarName = "Tools"
        Me.BarNAV.DockCol = 0
        Me.BarNAV.DockRow = 0
        Me.BarNAV.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.BarNAV.Text = "Tools"
        '
        'Bar4
        '
        Me.Bar4.BarName = "Custom 5"
        Me.Bar4.DockCol = 1
        Me.Bar4.DockRow = 0
        Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar4.Offset = 227
        Me.Bar4.Text = "Custom 5"
        '
        'Bar5
        '
        Me.Bar5.BarName = "Custom 5"
        Me.Bar5.DockCol = 1
        Me.Bar5.DockRow = 0
        Me.Bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar5.Offset = 227
        Me.Bar5.Text = "Custom 5"
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.FloatLocation = New System.Drawing.Point(2255, 388)
        Me.Bar1.Text = "Tools"
        '
        'ClsPTEnderecosBindingSource
        '
        Me.ClsPTEnderecosBindingSource.DataSource = GetType(PAP_G2_BFFPclinic_01_Rafael.ClsPT_Enderecos)
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3, Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbPrimeiro, Me.bbAnterior, Me.bbSeguinte, Me.bbUltimo, Me.bbNovo, Me.bbModifica, Me.bbApaga, Me.bbSair, Me.bbGrava, Me.bbCancela, Me.bbStatus, Me.BarStaticItem1, Me.BarButtonItem1})
        Me.BarManager1.MaxItemId = 17
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbStatus)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'bbStatus
        '
        Me.bbStatus.Caption = "bsStatus"
        Me.bbStatus.Id = 13
        Me.bbStatus.Name = "bbStatus"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 5"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbNovo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbModifica), New DevExpress.XtraBars.LinkPersistInfo(Me.bbApaga), New DevExpress.XtraBars.LinkPersistInfo(Me.bbSair), New DevExpress.XtraBars.LinkPersistInfo(Me.bbGrava), New DevExpress.XtraBars.LinkPersistInfo(Me.bbCancela)})
        Me.Bar2.Offset = 4
        Me.Bar2.Text = "Custom 5"
        '
        'bbNovo
        '
        Me.bbNovo.Caption = "Novo"
        Me.bbNovo.Id = 4
        Me.bbNovo.ImageOptions.Image = CType(resources.GetObject("bbNovo.ImageOptions.Image"), System.Drawing.Image)
        Me.bbNovo.Name = "bbNovo"
        '
        'bbModifica
        '
        Me.bbModifica.Caption = "Modifica"
        Me.bbModifica.Id = 5
        Me.bbModifica.ImageOptions.Image = CType(resources.GetObject("bbModifica.ImageOptions.Image"), System.Drawing.Image)
        Me.bbModifica.Name = "bbModifica"
        '
        'bbApaga
        '
        Me.bbApaga.Caption = "Apaga"
        Me.bbApaga.Id = 8
        Me.bbApaga.ImageOptions.Image = CType(resources.GetObject("bbApaga.ImageOptions.Image"), System.Drawing.Image)
        Me.bbApaga.Name = "bbApaga"
        '
        'bbSair
        '
        Me.bbSair.Caption = "Sair"
        Me.bbSair.Id = 9
        Me.bbSair.ImageOptions.Image = CType(resources.GetObject("bbSair.ImageOptions.Image"), System.Drawing.Image)
        Me.bbSair.Name = "bbSair"
        '
        'bbGrava
        '
        Me.bbGrava.Caption = "Grava"
        Me.bbGrava.Id = 11
        Me.bbGrava.ImageOptions.Image = CType(resources.GetObject("bbGrava.ImageOptions.Image"), System.Drawing.Image)
        Me.bbGrava.Name = "bbGrava"
        '
        'bbCancela
        '
        Me.bbCancela.Caption = "Cancela"
        Me.bbCancela.Id = 12
        Me.bbCancela.ImageOptions.Image = CType(resources.GetObject("bbCancela.ImageOptions.Image"), System.Drawing.Image)
        Me.bbCancela.Name = "bbCancela"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1112, 32)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 942)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1112, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 32)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 910)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1112, 32)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 910)
        '
        'bbPrimeiro
        '
        Me.bbPrimeiro.Caption = "Primeiro"
        Me.bbPrimeiro.Id = 0
        Me.bbPrimeiro.ImageOptions.Image = CType(resources.GetObject("bbPrimeiro.ImageOptions.Image"), System.Drawing.Image)
        Me.bbPrimeiro.Name = "bbPrimeiro"
        '
        'bbAnterior
        '
        Me.bbAnterior.Caption = "Anterior"
        Me.bbAnterior.Id = 1
        Me.bbAnterior.ImageOptions.Image = CType(resources.GetObject("bbAnterior.ImageOptions.Image"), System.Drawing.Image)
        Me.bbAnterior.Name = "bbAnterior"
        '
        'bbSeguinte
        '
        Me.bbSeguinte.Caption = "Seguinte"
        Me.bbSeguinte.Id = 2
        Me.bbSeguinte.ImageOptions.Image = CType(resources.GetObject("bbSeguinte.ImageOptions.Image"), System.Drawing.Image)
        Me.bbSeguinte.Name = "bbSeguinte"
        '
        'bbUltimo
        '
        Me.bbUltimo.Caption = "Ultimo"
        Me.bbUltimo.Id = 3
        Me.bbUltimo.ImageOptions.Image = CType(resources.GetObject("bbUltimo.ImageOptions.Image"), System.Drawing.Image)
        Me.bbUltimo.Name = "bbUltimo"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "BarStaticItem1"
        Me.BarStaticItem1.Id = 14
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 16
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'frmEnderecos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1112, 964)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cbLocalidade)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmEnderecos"
        Me.Text = "frmEnderecos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.FLG_AtivoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_Endereco_TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescritivoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_Entidade_TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucCod_Postal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_Postal_TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCod_Entidade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_RegistoDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_RegistoDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCod_Postal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucEnderecos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Endereco_TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbLocalidade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClsPTEnderecosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BarNAV As DevExpress.XtraBars.Bar
    Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar5 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents ClsPTEnderecosBindingSource As BindingSource
    Friend WithEvents Endereco_TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cod_Endereco_TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbLocalidade As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Cod_Postal_TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DescritivoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cod_Entidade_TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ucEnderecos As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents ucCod_Postal As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Data_RegistoDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LocalidadeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FLG_AtivoCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents bbStatus As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents bbNovo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbModifica As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbApaga As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbSair As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbGrava As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbCancela As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents bbPrimeiro As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbAnterior As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbSeguinte As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbUltimo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents picCod_Entidade As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents picCod_Postal As PictureBox
    '

End Class
