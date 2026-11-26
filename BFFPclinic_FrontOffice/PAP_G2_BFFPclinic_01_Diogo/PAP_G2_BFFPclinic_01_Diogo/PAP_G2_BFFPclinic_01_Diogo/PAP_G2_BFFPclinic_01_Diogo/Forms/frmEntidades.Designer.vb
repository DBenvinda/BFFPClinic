<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntidades
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
        Me.components = New System.ComponentModel.Container()
        Dim Cod_EntidadeLabel As System.Windows.Forms.Label
        Dim FLG_EntidadeLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim Cod_PaisLabel As System.Windows.Forms.Label
        Dim Num_TelefoneLabel As System.Windows.Forms.Label
        Dim Num_TelemovelLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim NIFLabel As System.Windows.Forms.Label
        Dim PaisLabel As System.Windows.Forms.Label
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsEnderecos", -1)
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Entidade")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Endereco")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descritivo")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Endereco")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Postal")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Localidade")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Data_Registo")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbEntidades = New System.Windows.Forms.ComboBox()
        Me.ucPaises = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.PaisTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Lista_EnderecosUltraGrid = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.cmAPAGA = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsCriar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsApagar = New System.Windows.Forms.ToolStripMenuItem()
        Me.NIFTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EmailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Num_TelemovelTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Num_TelefoneTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_PaisTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NomeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FLG_EntidadeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_EntidadeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UC_NAV11 = New PAP_G2_BFFPclinic_01_Diogo.UC_NAV1()
        Cod_EntidadeLabel = New System.Windows.Forms.Label()
        FLG_EntidadeLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        Cod_PaisLabel = New System.Windows.Forms.Label()
        Num_TelefoneLabel = New System.Windows.Forms.Label()
        Num_TelemovelLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        NIFLabel = New System.Windows.Forms.Label()
        PaisLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.ucPaises, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaisTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lista_EnderecosUltraGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmAPAGA.SuspendLayout()
        CType(Me.NIFTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num_TelemovelTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num_TelefoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_PaisTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NomeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLG_EntidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_EntidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cod_EntidadeLabel
        '
        Cod_EntidadeLabel.AutoSize = True
        Cod_EntidadeLabel.Location = New System.Drawing.Point(18, 15)
        Cod_EntidadeLabel.Name = "Cod_EntidadeLabel"
        Cod_EntidadeLabel.Size = New System.Drawing.Size(74, 13)
        Cod_EntidadeLabel.TabIndex = 6
        Cod_EntidadeLabel.Text = "Cod Entidade:"
        '
        'FLG_EntidadeLabel
        '
        FLG_EntidadeLabel.AutoSize = True
        FLG_EntidadeLabel.Location = New System.Drawing.Point(567, 35)
        FLG_EntidadeLabel.Name = "FLG_EntidadeLabel"
        FLG_EntidadeLabel.Size = New System.Drawing.Size(75, 13)
        FLG_EntidadeLabel.TabIndex = 15
        FLG_EntidadeLabel.Text = "FLG Entidade:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(54, 39)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 7
        NomeLabel.Text = "Nome:"
        '
        'Cod_PaisLabel
        '
        Cod_PaisLabel.AutoSize = True
        Cod_PaisLabel.Location = New System.Drawing.Point(591, 59)
        Cod_PaisLabel.Name = "Cod_PaisLabel"
        Cod_PaisLabel.Size = New System.Drawing.Size(52, 13)
        Cod_PaisLabel.TabIndex = 16
        Cod_PaisLabel.Text = "Cod Pais:"
        '
        'Num_TelefoneLabel
        '
        Num_TelefoneLabel.AutoSize = True
        Num_TelefoneLabel.Location = New System.Drawing.Point(18, 63)
        Num_TelefoneLabel.Name = "Num_TelefoneLabel"
        Num_TelefoneLabel.Size = New System.Drawing.Size(77, 13)
        Num_TelefoneLabel.TabIndex = 10
        Num_TelefoneLabel.Text = "Num Telefone:"
        '
        'Num_TelemovelLabel
        '
        Num_TelemovelLabel.AutoSize = True
        Num_TelemovelLabel.Location = New System.Drawing.Point(222, 63)
        Num_TelemovelLabel.Name = "Num_TelemovelLabel"
        Num_TelemovelLabel.Size = New System.Drawing.Size(84, 13)
        Num_TelemovelLabel.TabIndex = 10
        Num_TelemovelLabel.Text = "Num Telemovel:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(60, 87)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 8
        EmailLabel.Text = "Email:"
        '
        'NIFLabel
        '
        NIFLabel.AutoSize = True
        NIFLabel.Location = New System.Drawing.Point(282, 15)
        NIFLabel.Name = "NIFLabel"
        NIFLabel.Size = New System.Drawing.Size(27, 13)
        NIFLabel.TabIndex = 12
        NIFLabel.Text = "NIF:"
        '
        'PaisLabel
        '
        PaisLabel.AutoSize = True
        PaisLabel.Location = New System.Drawing.Point(66, 111)
        PaisLabel.Name = "PaisLabel"
        PaisLabel.Size = New System.Drawing.Size(30, 13)
        PaisLabel.TabIndex = 9
        PaisLabel.Text = "Pais:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.cbEntidades)
        Me.Panel1.Controls.Add(Me.ucPaises)
        Me.Panel1.Controls.Add(PaisLabel)
        Me.Panel1.Controls.Add(Me.PaisTextEdit)
        Me.Panel1.Controls.Add(Me.Lista_EnderecosUltraGrid)
        Me.Panel1.Controls.Add(NIFLabel)
        Me.Panel1.Controls.Add(Me.NIFTextEdit)
        Me.Panel1.Controls.Add(EmailLabel)
        Me.Panel1.Controls.Add(Me.EmailTextEdit)
        Me.Panel1.Controls.Add(Num_TelemovelLabel)
        Me.Panel1.Controls.Add(Me.Num_TelemovelTextEdit)
        Me.Panel1.Controls.Add(Num_TelefoneLabel)
        Me.Panel1.Controls.Add(Me.Num_TelefoneTextEdit)
        Me.Panel1.Controls.Add(Cod_PaisLabel)
        Me.Panel1.Controls.Add(Me.Cod_PaisTextEdit)
        Me.Panel1.Controls.Add(NomeLabel)
        Me.Panel1.Controls.Add(Me.NomeTextEdit)
        Me.Panel1.Controls.Add(FLG_EntidadeLabel)
        Me.Panel1.Controls.Add(Me.FLG_EntidadeTextEdit)
        Me.Panel1.Controls.Add(Cod_EntidadeLabel)
        Me.Panel1.Controls.Add(Me.Cod_EntidadeTextEdit)
        Me.Panel1.Location = New System.Drawing.Point(6, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(787, 473)
        Me.Panel1.TabIndex = 1
        '
        'cbEntidades
        '
        Me.cbEntidades.FormattingEnabled = True
        Me.cbEntidades.Location = New System.Drawing.Point(102, 12)
        Me.cbEntidades.Name = "cbEntidades"
        Me.cbEntidades.Size = New System.Drawing.Size(102, 21)
        Me.cbEntidades.TabIndex = 99
        '
        'ucPaises
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucPaises.DisplayLayout.Appearance = Appearance1
        Me.ucPaises.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucPaises.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.ucPaises.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucPaises.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.ucPaises.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucPaises.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.ucPaises.DisplayLayout.MaxColScrollRegions = 1
        Me.ucPaises.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucPaises.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ucPaises.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.ucPaises.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucPaises.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.ucPaises.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ucPaises.DisplayLayout.Override.CellAppearance = Appearance8
        Me.ucPaises.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucPaises.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.ucPaises.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.ucPaises.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.ucPaises.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucPaises.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.ucPaises.DisplayLayout.Override.RowAppearance = Appearance11
        Me.ucPaises.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ucPaises.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.ucPaises.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucPaises.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucPaises.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ucPaises.Location = New System.Drawing.Point(102, 108)
        Me.ucPaises.Name = "ucPaises"
        Me.ucPaises.Size = New System.Drawing.Size(318, 22)
        Me.ucPaises.TabIndex = 5
        '
        'PaisTextEdit
        '
        Me.PaisTextEdit.Location = New System.Drawing.Point(102, 108)
        Me.PaisTextEdit.Name = "PaisTextEdit"
        Me.PaisTextEdit.Size = New System.Drawing.Size(318, 20)
        Me.PaisTextEdit.TabIndex = 18
        '
        'Lista_EnderecosUltraGrid
        '
        Me.Lista_EnderecosUltraGrid.ContextMenuStrip = Me.cmAPAGA
        UltraGridColumn9.Header.VisiblePosition = 0
        UltraGridColumn9.Hidden = True
        UltraGridColumn9.Width = 53
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn10.Header.Caption = "Cod"
        UltraGridColumn10.Header.VisiblePosition = 1
        UltraGridColumn10.Width = 40
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn11.Header.VisiblePosition = 2
        UltraGridColumn11.Width = 151
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn12.Header.Caption = "Endereço"
        UltraGridColumn12.Header.VisiblePosition = 3
        UltraGridColumn12.Width = 236
        UltraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn13.Header.Caption = "CP"
        UltraGridColumn13.Header.VisiblePosition = 4
        UltraGridColumn13.Width = 48
        UltraGridColumn14.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn14.Header.VisiblePosition = 5
        UltraGridColumn14.Width = 236
        UltraGridColumn15.Header.VisiblePosition = 6
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 7
        UltraGridColumn16.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16})
        Me.Lista_EnderecosUltraGrid.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.Lista_EnderecosUltraGrid.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.Lista_EnderecosUltraGrid.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.Lista_EnderecosUltraGrid.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.Lista_EnderecosUltraGrid.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.Lista_EnderecosUltraGrid.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.Lista_EnderecosUltraGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lista_EnderecosUltraGrid.Location = New System.Drawing.Point(18, 156)
        Me.Lista_EnderecosUltraGrid.Name = "Lista_EnderecosUltraGrid"
        Me.Lista_EnderecosUltraGrid.Size = New System.Drawing.Size(751, 307)
        Me.Lista_EnderecosUltraGrid.TabIndex = 11
        Me.Lista_EnderecosUltraGrid.Text = "Lista de Endereços da Entidade"
        '
        'cmAPAGA
        '
        Me.cmAPAGA.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsCriar, Me.tsModificar, Me.ToolStripSeparator1, Me.tsApagar})
        Me.cmAPAGA.Name = "cmAPAGA"
        Me.cmAPAGA.Size = New System.Drawing.Size(178, 76)
        '
        'tsCriar
        '
        Me.tsCriar.Image = Global.PAP_G2_BFFPclinic_01_Diogo.My.Resources.Resources.add
        Me.tsCriar.Name = "tsCriar"
        Me.tsCriar.Size = New System.Drawing.Size(177, 22)
        Me.tsCriar.Text = "Criar Endereço"
        '
        'tsModificar
        '
        Me.tsModificar.Image = Global.PAP_G2_BFFPclinic_01_Diogo.My.Resources.Resources.document_edit
        Me.tsModificar.Name = "tsModificar"
        Me.tsModificar.Size = New System.Drawing.Size(177, 22)
        Me.tsModificar.Text = "Modificar Endereço"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(174, 6)
        '
        'tsApagar
        '
        Me.tsApagar.Image = Global.PAP_G2_BFFPclinic_01_Diogo.My.Resources.Resources.delete
        Me.tsApagar.Name = "tsApagar"
        Me.tsApagar.Size = New System.Drawing.Size(177, 22)
        Me.tsApagar.Text = "Apagar Endereço"
        '
        'NIFTextEdit
        '
        Me.NIFTextEdit.Location = New System.Drawing.Point(318, 12)
        Me.NIFTextEdit.Name = "NIFTextEdit"
        Me.NIFTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.NIFTextEdit.TabIndex = 1
        '
        'EmailTextEdit
        '
        Me.EmailTextEdit.Location = New System.Drawing.Point(102, 84)
        Me.EmailTextEdit.Name = "EmailTextEdit"
        Me.EmailTextEdit.Size = New System.Drawing.Size(318, 20)
        Me.EmailTextEdit.TabIndex = 4
        '
        'Num_TelemovelTextEdit
        '
        Me.Num_TelemovelTextEdit.Location = New System.Drawing.Point(312, 60)
        Me.Num_TelemovelTextEdit.Name = "Num_TelemovelTextEdit"
        Me.Num_TelemovelTextEdit.Size = New System.Drawing.Size(108, 20)
        Me.Num_TelemovelTextEdit.TabIndex = 3
        '
        'Num_TelefoneTextEdit
        '
        Me.Num_TelefoneTextEdit.Location = New System.Drawing.Point(102, 60)
        Me.Num_TelefoneTextEdit.Name = "Num_TelefoneTextEdit"
        Me.Num_TelefoneTextEdit.Size = New System.Drawing.Size(114, 20)
        Me.Num_TelefoneTextEdit.TabIndex = 2
        '
        'Cod_PaisTextEdit
        '
        Me.Cod_PaisTextEdit.Location = New System.Drawing.Point(651, 56)
        Me.Cod_PaisTextEdit.Name = "Cod_PaisTextEdit"
        Me.Cod_PaisTextEdit.Size = New System.Drawing.Size(36, 20)
        Me.Cod_PaisTextEdit.TabIndex = 14
        '
        'NomeTextEdit
        '
        Me.NomeTextEdit.Location = New System.Drawing.Point(102, 36)
        Me.NomeTextEdit.Name = "NomeTextEdit"
        Me.NomeTextEdit.Size = New System.Drawing.Size(318, 20)
        Me.NomeTextEdit.TabIndex = 0
        '
        'FLG_EntidadeTextEdit
        '
        Me.FLG_EntidadeTextEdit.Location = New System.Drawing.Point(651, 32)
        Me.FLG_EntidadeTextEdit.Name = "FLG_EntidadeTextEdit"
        Me.FLG_EntidadeTextEdit.Size = New System.Drawing.Size(36, 20)
        Me.FLG_EntidadeTextEdit.TabIndex = 13
        '
        'Cod_EntidadeTextEdit
        '
        Me.Cod_EntidadeTextEdit.Location = New System.Drawing.Point(102, 12)
        Me.Cod_EntidadeTextEdit.Name = "Cod_EntidadeTextEdit"
        Me.Cod_EntidadeTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.Cod_EntidadeTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Cod_EntidadeTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Cod_EntidadeTextEdit.TabIndex = 101
        '
        'UC_NAV11
        '
        Me.UC_NAV11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_NAV11.Location = New System.Drawing.Point(0, 0)
        Me.UC_NAV11.mFRM = Nothing
        Me.UC_NAV11.Name = "UC_NAV11"
        Me.UC_NAV11.Size = New System.Drawing.Size(802, 541)
        Me.UC_NAV11.TabIndex = 0
        '
        'frmEntidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 541)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UC_NAV11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEntidades"
        Me.Text = "frmEntidades"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ucPaises, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaisTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lista_EnderecosUltraGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmAPAGA.ResumeLayout(False)
        CType(Me.NIFTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num_TelemovelTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num_TelefoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_PaisTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NomeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLG_EntidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_EntidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UC_NAV11 As UC_NAV1
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lista_EnderecosUltraGrid As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents NIFTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Num_TelemovelTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Num_TelefoneTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cod_PaisTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NomeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FLG_EntidadeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cod_EntidadeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PaisTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ucPaises As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbEntidades As ComboBox
    Friend WithEvents cmAPAGA As ContextMenuStrip
    Friend WithEvents tsCriar As ToolStripMenuItem
    Friend WithEvents tsModificar As ToolStripMenuItem
    Friend WithEvents tsApagar As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
