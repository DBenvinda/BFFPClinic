<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDocs
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsDoc", -1)
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Num_Doc")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Tipo_Doc")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Designacao")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Data_Doc")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Entidade")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nome")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Entidade", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Taxa_Desconto")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Data_Vencimento")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Pago")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo_Pagamento")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Data_Pagamento")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Totais")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Empresa")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Linhas")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("QI")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Linhas", 0)
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Num_Doc")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Num_Linha")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sNum_Linha")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Artigo")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Artigo")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Quantidade")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sQTD")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("P_Unitario")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sP_Unitario")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Unidade")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Taxa_Desconto")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sTaxa_Desconto")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Taxa_IVA")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sTaxa_IVA")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Valor_Iliquido")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sValor_Iliquido")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Valor_IVA")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Valor_Desconto")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Feita")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("QI", 0)
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Num_Doc")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo_IVA")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Taxa_IVA")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("S_IVA")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("V_IVA")
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDocs))
        Me.PrintPreviewRepositoryItemComboBox3 = New DevExpress.XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox()
        Me.ugDocs = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DocumentViewerBarManager1 = New DevExpress.XtraPrinting.Preview.DocumentViewerBarManager(Me.components)
        Me.PreviewBar1 = New DevExpress.XtraPrinting.Preview.PreviewBar()
        Me.bbiDocumentMap = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiParameters = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiThumbnails = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiFind = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiHighlightEditingFields = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiCustomize = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiOpen = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiSave = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiPrint = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiPrintDirect = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiPageSetup = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiEditPageHF = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiScale = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiHandTool = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiMagnifier = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiZoomOut = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiZoom = New DevExpress.XtraPrinting.Preview.ZoomBarEditItem()
        Me.PrintPreviewRepositoryItemComboBox1 = New DevExpress.XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox()
        Me.bbiZoomIn = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiShowFirstPage = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiShowPrevPage = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiShowNextPage = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiShowLastPage = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiMultiplePages = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiFillBackground = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiWatermark = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiExportFile = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiSendFile = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.PreviewBar3 = New DevExpress.XtraPrinting.Preview.PreviewBar()
        Me.miFile = New DevExpress.XtraPrinting.Preview.PrintPreviewSubItem()
        Me.bbiClosePreview = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.miView = New DevExpress.XtraPrinting.Preview.PrintPreviewSubItem()
        Me.miPageLayout = New DevExpress.XtraPrinting.Preview.PrintPreviewSubItem()
        Me.miPageLayoutFacing = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.miPageLayoutContinuous = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.miToolbars = New DevExpress.XtraBars.BarToolbarsListItem()
        Me.miBackground = New DevExpress.XtraPrinting.Preview.PrintPreviewSubItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl5 = New DevExpress.XtraBars.BarDockControl()
        Me.ClsDocBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PrintPreviewRepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugDocs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentViewerBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintPreviewRepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClsDocBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintPreviewRepositoryItemComboBox3
        '
        Me.PrintPreviewRepositoryItemComboBox3.AutoComplete = False
        Me.PrintPreviewRepositoryItemComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PrintPreviewRepositoryItemComboBox3.DropDownRows = 11
        Me.PrintPreviewRepositoryItemComboBox3.Name = "PrintPreviewRepositoryItemComboBox3"
        '
        'ugDocs
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugDocs.DisplayLayout.Appearance = Appearance1
        UltraGridColumn23.Header.VisiblePosition = 0
        UltraGridColumn23.Width = 103
        UltraGridColumn18.Header.VisiblePosition = 1
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.VisiblePosition = 2
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 4
        UltraGridColumn20.Width = 101
        UltraGridColumn21.Header.VisiblePosition = 5
        UltraGridColumn21.Hidden = True
        UltraGridColumn1.Header.VisiblePosition = 6
        UltraGridColumn2.Header.VisiblePosition = 3
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.Width = 101
        UltraGridColumn28.Header.VisiblePosition = 7
        UltraGridColumn28.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 8
        UltraGridColumn22.Width = 124
        UltraGridColumn24.Header.VisiblePosition = 10
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.Header.VisiblePosition = 9
        UltraGridColumn25.Width = 119
        UltraGridColumn26.Header.VisiblePosition = 11
        UltraGridColumn26.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 13
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 14
        UltraGridColumn4.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 12
        UltraGridColumn33.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 15
        UltraGridColumn6.Header.VisiblePosition = 16
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn23, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn1, UltraGridColumn2, UltraGridColumn28, UltraGridColumn22, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn3, UltraGridColumn4, UltraGridColumn33, UltraGridColumn5, UltraGridColumn6})
        UltraGridColumn7.Header.VisiblePosition = 0
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 1
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 2
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 3
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 4
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 5
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 6
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 7
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 8
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 9
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 10
        UltraGridColumn17.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 11
        UltraGridColumn27.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 12
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.VisiblePosition = 13
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.Header.VisiblePosition = 14
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 15
        UltraGridColumn32.Hidden = True
        UltraGridColumn34.Header.VisiblePosition = 16
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.VisiblePosition = 17
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.Header.VisiblePosition = 18
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.Header.VisiblePosition = 19
        UltraGridColumn37.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn27, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37})
        UltraGridColumn38.Header.VisiblePosition = 0
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.Header.VisiblePosition = 1
        UltraGridColumn39.Hidden = True
        UltraGridColumn40.Header.VisiblePosition = 2
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.Header.VisiblePosition = 3
        UltraGridColumn41.Hidden = True
        UltraGridColumn42.Header.VisiblePosition = 4
        UltraGridColumn42.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42})
        Me.ugDocs.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ugDocs.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ugDocs.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.ugDocs.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugDocs.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ugDocs.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.ugDocs.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.AlignWithDataRows
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.ugDocs.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugDocs.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.ugDocs.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugDocs.DisplayLayout.GroupByBox.Hidden = True
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugDocs.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.ugDocs.DisplayLayout.MaxColScrollRegions = 1
        Me.ugDocs.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugDocs.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugDocs.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.ugDocs.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugDocs.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.ugDocs.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugDocs.DisplayLayout.Override.CellAppearance = Appearance8
        Me.ugDocs.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugDocs.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.ugDocs.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.ugDocs.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.ugDocs.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugDocs.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.ugDocs.DisplayLayout.Override.RowAppearance = Appearance11
        Me.ugDocs.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.ugDocs.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.None
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugDocs.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.ugDocs.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugDocs.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugDocs.Dock = System.Windows.Forms.DockStyle.Left
        Me.ugDocs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ugDocs.Location = New System.Drawing.Point(0, 45)
        Me.ugDocs.Name = "ugDocs"
        Me.ugDocs.Size = New System.Drawing.Size(585, 582)
        Me.ugDocs.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.logo_Original_Fundo_maisclaro
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(584, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1037, 582)
        Me.Panel1.TabIndex = 1
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1621, 45)
        Me.barDockControlRight.Manager = Me.DocumentViewerBarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 582)
        '
        'DocumentViewerBarManager1
        '
        Me.DocumentViewerBarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.PreviewBar1, Me.PreviewBar3})
        Me.DocumentViewerBarManager1.DockControls.Add(Me.barDockControlTop)
        Me.DocumentViewerBarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.DocumentViewerBarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.DocumentViewerBarManager1.DockControls.Add(Me.BarDockControl1)
        Me.DocumentViewerBarManager1.Form = Me
        Me.DocumentViewerBarManager1.ImageStream = CType(resources.GetObject("DocumentViewerBarManager1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.DocumentViewerBarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiDocumentMap, Me.bbiParameters, Me.bbiThumbnails, Me.bbiFind, Me.bbiHighlightEditingFields, Me.bbiCustomize, Me.bbiOpen, Me.bbiSave, Me.bbiPrint, Me.bbiPrintDirect, Me.bbiPageSetup, Me.bbiEditPageHF, Me.bbiScale, Me.bbiHandTool, Me.bbiMagnifier, Me.bbiZoomOut, Me.bbiZoom, Me.bbiZoomIn, Me.bbiShowFirstPage, Me.bbiShowPrevPage, Me.bbiShowNextPage, Me.bbiShowLastPage, Me.bbiMultiplePages, Me.bbiFillBackground, Me.bbiWatermark, Me.bbiExportFile, Me.bbiSendFile, Me.miFile, Me.miView, Me.miBackground, Me.bbiClosePreview, Me.miPageLayout, Me.miToolbars, Me.miPageLayoutFacing, Me.miPageLayoutContinuous})
        Me.DocumentViewerBarManager1.MaxItemId = 39
        '
        'PreviewBar1
        '
        Me.PreviewBar1.BarName = "Toolbar"
        Me.PreviewBar1.DockCol = 0
        Me.PreviewBar1.DockRow = 1
        Me.PreviewBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.PreviewBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiDocumentMap), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiParameters), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiThumbnails), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiFind), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiHighlightEditingFields), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCustomize, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiOpen, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSave), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiPrint, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiPrintDirect), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiPageSetup), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEditPageHF), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiScale), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiHandTool, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiMagnifier), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiZoomOut, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiZoom), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiZoomIn), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiShowFirstPage, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiShowPrevPage), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiShowNextPage), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiShowLastPage), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiMultiplePages, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiFillBackground), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiWatermark), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiExportFile, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSendFile)})
        Me.PreviewBar1.Text = "Toolbar"
        '
        'bbiDocumentMap
        '
        Me.bbiDocumentMap.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiDocumentMap.Caption = "Document Map"
        Me.bbiDocumentMap.Command = DevExpress.XtraPrinting.PrintingSystemCommand.DocumentMap
        Me.bbiDocumentMap.Enabled = False
        Me.bbiDocumentMap.Hint = "Document Map"
        Me.bbiDocumentMap.Id = 5
        Me.bbiDocumentMap.Name = "bbiDocumentMap"
        '
        'bbiParameters
        '
        Me.bbiParameters.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiParameters.Caption = "Parameters"
        Me.bbiParameters.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Parameters
        Me.bbiParameters.Enabled = False
        Me.bbiParameters.Hint = "Parameters"
        Me.bbiParameters.Id = 6
        Me.bbiParameters.Name = "bbiParameters"
        '
        'bbiThumbnails
        '
        Me.bbiThumbnails.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiThumbnails.Caption = "Thumbnails"
        Me.bbiThumbnails.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Thumbnails
        Me.bbiThumbnails.Enabled = False
        Me.bbiThumbnails.Hint = "Thumbnails"
        Me.bbiThumbnails.Id = 7
        Me.bbiThumbnails.Name = "bbiThumbnails"
        '
        'bbiFind
        '
        Me.bbiFind.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiFind.Caption = "Search"
        Me.bbiFind.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Find
        Me.bbiFind.Enabled = False
        Me.bbiFind.Hint = "Search"
        Me.bbiFind.Id = 8
        Me.bbiFind.Name = "bbiFind"
        '
        'bbiHighlightEditingFields
        '
        Me.bbiHighlightEditingFields.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiHighlightEditingFields.Caption = "Editing Fields"
        Me.bbiHighlightEditingFields.Command = DevExpress.XtraPrinting.PrintingSystemCommand.HighlightEditingFields
        Me.bbiHighlightEditingFields.Enabled = False
        Me.bbiHighlightEditingFields.Hint = "Highlight Editing Fields"
        Me.bbiHighlightEditingFields.Id = 9
        Me.bbiHighlightEditingFields.Name = "bbiHighlightEditingFields"
        '
        'bbiCustomize
        '
        Me.bbiCustomize.Caption = "Customize"
        Me.bbiCustomize.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Customize
        Me.bbiCustomize.Enabled = False
        Me.bbiCustomize.Hint = "Customize"
        Me.bbiCustomize.Id = 10
        Me.bbiCustomize.Name = "bbiCustomize"
        '
        'bbiOpen
        '
        Me.bbiOpen.Caption = "Open"
        Me.bbiOpen.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Open
        Me.bbiOpen.Enabled = False
        Me.bbiOpen.Hint = "Open a document"
        Me.bbiOpen.Id = 11
        Me.bbiOpen.Name = "bbiOpen"
        '
        'bbiSave
        '
        Me.bbiSave.Caption = "Save"
        Me.bbiSave.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Save
        Me.bbiSave.Enabled = False
        Me.bbiSave.Hint = "Save the document"
        Me.bbiSave.Id = 12
        Me.bbiSave.Name = "bbiSave"
        '
        'bbiPrint
        '
        Me.bbiPrint.Caption = "&Print..."
        Me.bbiPrint.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Print
        Me.bbiPrint.Enabled = False
        Me.bbiPrint.Hint = "Print"
        Me.bbiPrint.Id = 13
        Me.bbiPrint.Name = "bbiPrint"
        '
        'bbiPrintDirect
        '
        Me.bbiPrintDirect.Caption = "P&rint"
        Me.bbiPrintDirect.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PrintDirect
        Me.bbiPrintDirect.Enabled = False
        Me.bbiPrintDirect.Hint = "Quick Print"
        Me.bbiPrintDirect.Id = 14
        Me.bbiPrintDirect.Name = "bbiPrintDirect"
        '
        'bbiPageSetup
        '
        Me.bbiPageSetup.Caption = "Page Set&up..."
        Me.bbiPageSetup.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageSetup
        Me.bbiPageSetup.Enabled = False
        Me.bbiPageSetup.Hint = "Page Setup"
        Me.bbiPageSetup.Id = 15
        Me.bbiPageSetup.Name = "bbiPageSetup"
        '
        'bbiEditPageHF
        '
        Me.bbiEditPageHF.Caption = "Header And Footer"
        Me.bbiEditPageHF.Command = DevExpress.XtraPrinting.PrintingSystemCommand.EditPageHF
        Me.bbiEditPageHF.Enabled = False
        Me.bbiEditPageHF.Hint = "Header And Footer"
        Me.bbiEditPageHF.Id = 16
        Me.bbiEditPageHF.Name = "bbiEditPageHF"
        '
        'bbiScale
        '
        Me.bbiScale.ActAsDropDown = True
        Me.bbiScale.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.bbiScale.Caption = "Scale"
        Me.bbiScale.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Scale
        Me.bbiScale.Enabled = False
        Me.bbiScale.Hint = "Scale"
        Me.bbiScale.Id = 17
        Me.bbiScale.Name = "bbiScale"
        '
        'bbiHandTool
        '
        Me.bbiHandTool.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiHandTool.Caption = "Hand Tool"
        Me.bbiHandTool.Command = DevExpress.XtraPrinting.PrintingSystemCommand.HandTool
        Me.bbiHandTool.Enabled = False
        Me.bbiHandTool.Hint = "Hand Tool"
        Me.bbiHandTool.Id = 18
        Me.bbiHandTool.Name = "bbiHandTool"
        '
        'bbiMagnifier
        '
        Me.bbiMagnifier.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiMagnifier.Caption = "Magnifier"
        Me.bbiMagnifier.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Magnifier
        Me.bbiMagnifier.Enabled = False
        Me.bbiMagnifier.Hint = "Magnifier"
        Me.bbiMagnifier.Id = 19
        Me.bbiMagnifier.Name = "bbiMagnifier"
        '
        'bbiZoomOut
        '
        Me.bbiZoomOut.Caption = "Zoom Out"
        Me.bbiZoomOut.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomOut
        Me.bbiZoomOut.Enabled = False
        Me.bbiZoomOut.Hint = "Zoom Out"
        Me.bbiZoomOut.Id = 20
        Me.bbiZoomOut.Name = "bbiZoomOut"
        '
        'bbiZoom
        '
        Me.bbiZoom.Caption = "Zoom"
        Me.bbiZoom.Edit = Me.PrintPreviewRepositoryItemComboBox1
        Me.bbiZoom.EditWidth = 70
        Me.bbiZoom.Enabled = False
        Me.bbiZoom.Hint = "Zoom"
        Me.bbiZoom.Id = 21
        Me.bbiZoom.Name = "bbiZoom"
        '
        'PrintPreviewRepositoryItemComboBox1
        '
        Me.PrintPreviewRepositoryItemComboBox1.AutoComplete = False
        Me.PrintPreviewRepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PrintPreviewRepositoryItemComboBox1.DropDownRows = 11
        Me.PrintPreviewRepositoryItemComboBox1.Name = "PrintPreviewRepositoryItemComboBox1"
        '
        'bbiZoomIn
        '
        Me.bbiZoomIn.Caption = "Zoom In"
        Me.bbiZoomIn.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomIn
        Me.bbiZoomIn.Enabled = False
        Me.bbiZoomIn.Hint = "Zoom In"
        Me.bbiZoomIn.Id = 22
        Me.bbiZoomIn.Name = "bbiZoomIn"
        '
        'bbiShowFirstPage
        '
        Me.bbiShowFirstPage.Caption = "First Page"
        Me.bbiShowFirstPage.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowFirstPage
        Me.bbiShowFirstPage.Enabled = False
        Me.bbiShowFirstPage.Hint = "First Page"
        Me.bbiShowFirstPage.Id = 23
        Me.bbiShowFirstPage.Name = "bbiShowFirstPage"
        '
        'bbiShowPrevPage
        '
        Me.bbiShowPrevPage.Caption = "Previous Page"
        Me.bbiShowPrevPage.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowPrevPage
        Me.bbiShowPrevPage.Enabled = False
        Me.bbiShowPrevPage.Hint = "Previous Page"
        Me.bbiShowPrevPage.Id = 24
        Me.bbiShowPrevPage.Name = "bbiShowPrevPage"
        '
        'bbiShowNextPage
        '
        Me.bbiShowNextPage.Caption = "Next Page"
        Me.bbiShowNextPage.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowNextPage
        Me.bbiShowNextPage.Enabled = False
        Me.bbiShowNextPage.Hint = "Next Page"
        Me.bbiShowNextPage.Id = 25
        Me.bbiShowNextPage.Name = "bbiShowNextPage"
        '
        'bbiShowLastPage
        '
        Me.bbiShowLastPage.Caption = "Last Page"
        Me.bbiShowLastPage.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowLastPage
        Me.bbiShowLastPage.Enabled = False
        Me.bbiShowLastPage.Hint = "Last Page"
        Me.bbiShowLastPage.Id = 26
        Me.bbiShowLastPage.Name = "bbiShowLastPage"
        '
        'bbiMultiplePages
        '
        Me.bbiMultiplePages.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.bbiMultiplePages.Caption = "Multiple Pages"
        Me.bbiMultiplePages.Command = DevExpress.XtraPrinting.PrintingSystemCommand.MultiplePages
        Me.bbiMultiplePages.Enabled = False
        Me.bbiMultiplePages.Hint = "Multiple Pages"
        Me.bbiMultiplePages.Id = 27
        Me.bbiMultiplePages.Name = "bbiMultiplePages"
        '
        'bbiFillBackground
        '
        Me.bbiFillBackground.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.bbiFillBackground.Caption = "&Color..."
        Me.bbiFillBackground.Command = DevExpress.XtraPrinting.PrintingSystemCommand.FillBackground
        Me.bbiFillBackground.Enabled = False
        Me.bbiFillBackground.Hint = "Background"
        Me.bbiFillBackground.Id = 28
        Me.bbiFillBackground.Name = "bbiFillBackground"
        '
        'bbiWatermark
        '
        Me.bbiWatermark.Caption = "&Watermark..."
        Me.bbiWatermark.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Watermark
        Me.bbiWatermark.Enabled = False
        Me.bbiWatermark.Hint = "Watermark"
        Me.bbiWatermark.Id = 29
        Me.bbiWatermark.Name = "bbiWatermark"
        '
        'bbiExportFile
        '
        Me.bbiExportFile.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.bbiExportFile.Caption = "Export Document..."
        Me.bbiExportFile.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportFile
        Me.bbiExportFile.Enabled = False
        Me.bbiExportFile.Hint = "Export Document..."
        Me.bbiExportFile.Id = 30
        Me.bbiExportFile.Name = "bbiExportFile"
        '
        'bbiSendFile
        '
        Me.bbiSendFile.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.bbiSendFile.Caption = "Send via E-Mail..."
        Me.bbiSendFile.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendFile
        Me.bbiSendFile.Enabled = False
        Me.bbiSendFile.Hint = "Send via E-Mail..."
        Me.bbiSendFile.Id = 31
        Me.bbiSendFile.Name = "bbiSendFile"
        '
        'PreviewBar3
        '
        Me.PreviewBar3.BarName = "Main Menu"
        Me.PreviewBar3.DockCol = 0
        Me.PreviewBar3.DockRow = 0
        Me.PreviewBar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.PreviewBar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.miFile), New DevExpress.XtraBars.LinkPersistInfo(Me.miView), New DevExpress.XtraBars.LinkPersistInfo(Me.miBackground)})
        Me.PreviewBar3.OptionsBar.MultiLine = True
        Me.PreviewBar3.OptionsBar.UseWholeRow = True
        Me.PreviewBar3.Text = "Main Menu"
        '
        'miFile
        '
        Me.miFile.Caption = "&File"
        Me.miFile.Command = DevExpress.XtraPrinting.PrintingSystemCommand.File
        Me.miFile.Id = 33
        Me.miFile.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiPageSetup), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiPrint), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiPrintDirect), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiExportFile, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSendFile), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiClosePreview, True)})
        Me.miFile.Name = "miFile"
        '
        'bbiClosePreview
        '
        Me.bbiClosePreview.Caption = "E&xit"
        Me.bbiClosePreview.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ClosePreview
        Me.bbiClosePreview.Enabled = False
        Me.bbiClosePreview.Hint = "Close Preview"
        Me.bbiClosePreview.Id = 32
        Me.bbiClosePreview.Name = "bbiClosePreview"
        '
        'miView
        '
        Me.miView.Caption = "&View"
        Me.miView.Command = DevExpress.XtraPrinting.PrintingSystemCommand.View
        Me.miView.Id = 34
        Me.miView.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.miPageLayout, True), New DevExpress.XtraBars.LinkPersistInfo(Me.miToolbars, True)})
        Me.miView.Name = "miView"
        '
        'miPageLayout
        '
        Me.miPageLayout.Caption = "&Page Layout"
        Me.miPageLayout.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayout
        Me.miPageLayout.Id = 36
        Me.miPageLayout.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.miPageLayoutFacing), New DevExpress.XtraBars.LinkPersistInfo(Me.miPageLayoutContinuous)})
        Me.miPageLayout.Name = "miPageLayout"
        '
        'miPageLayoutFacing
        '
        Me.miPageLayoutFacing.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.miPageLayoutFacing.Caption = "&Facing"
        Me.miPageLayoutFacing.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayoutFacing
        Me.miPageLayoutFacing.Enabled = False
        Me.miPageLayoutFacing.GroupIndex = 100
        Me.miPageLayoutFacing.Id = 37
        Me.miPageLayoutFacing.Name = "miPageLayoutFacing"
        '
        'miPageLayoutContinuous
        '
        Me.miPageLayoutContinuous.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.miPageLayoutContinuous.Caption = "&Continuous"
        Me.miPageLayoutContinuous.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayoutContinuous
        Me.miPageLayoutContinuous.Enabled = False
        Me.miPageLayoutContinuous.GroupIndex = 100
        Me.miPageLayoutContinuous.Id = 38
        Me.miPageLayoutContinuous.Name = "miPageLayoutContinuous"
        '
        'miToolbars
        '
        Me.miToolbars.Caption = "Bars"
        Me.miToolbars.Id = 39
        Me.miToolbars.Name = "miToolbars"
        '
        'miBackground
        '
        Me.miBackground.Caption = "&Background"
        Me.miBackground.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Background
        Me.miBackground.Id = 35
        Me.miBackground.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiFillBackground), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiWatermark)})
        Me.miBackground.Name = "miBackground"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.DocumentViewerBarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1621, 45)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 627)
        Me.barDockControlBottom.Manager = Me.DocumentViewerBarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1621, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 45)
        Me.barDockControlLeft.Manager = Me.DocumentViewerBarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 582)
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl1.Location = New System.Drawing.Point(1621, 45)
        Me.BarDockControl1.Manager = Me.DocumentViewerBarManager1
        Me.BarDockControl1.Size = New System.Drawing.Size(0, 582)
        '
        'BarDockControl5
        '
        Me.BarDockControl5.CausesValidation = False
        Me.BarDockControl5.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl5.Location = New System.Drawing.Point(1621, 45)
        Me.BarDockControl5.Manager = Nothing
        Me.BarDockControl5.Size = New System.Drawing.Size(0, 582)
        '
        'ClsDocBindingSource
        '
        Me.ClsDocBindingSource.DataSource = GetType(PAP_G2_BFFPclinic_01_Rafael.ClsDoc)
        '
        'FrmDocs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1621, 627)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ugDocs)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.BarDockControl5)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "FrmDocs"
        Me.Text = "FrmDocs"
        CType(Me.PrintPreviewRepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugDocs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentViewerBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintPreviewRepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClsDocBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ugDocs As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl5 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents PrintPreviewRepositoryItemComboBox3 As DevExpress.XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox
    Friend WithEvents DocumentViewerBarManager1 As DevExpress.XtraPrinting.Preview.DocumentViewerBarManager
    Friend WithEvents PreviewBar1 As DevExpress.XtraPrinting.Preview.PreviewBar
    Friend WithEvents bbiDocumentMap As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiParameters As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiThumbnails As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiFind As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiHighlightEditingFields As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiCustomize As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiOpen As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiSave As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiPrint As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiPrintDirect As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiPageSetup As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiEditPageHF As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiScale As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiHandTool As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiMagnifier As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiZoomOut As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiZoom As DevExpress.XtraPrinting.Preview.ZoomBarEditItem
    Friend WithEvents PrintPreviewRepositoryItemComboBox1 As DevExpress.XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox
    Friend WithEvents bbiZoomIn As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiShowFirstPage As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiShowPrevPage As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiShowNextPage As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiShowLastPage As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiMultiplePages As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiFillBackground As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiWatermark As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiExportFile As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiSendFile As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents PreviewBar3 As DevExpress.XtraPrinting.Preview.PreviewBar
    Friend WithEvents miFile As DevExpress.XtraPrinting.Preview.PrintPreviewSubItem
    Friend WithEvents bbiClosePreview As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents miView As DevExpress.XtraPrinting.Preview.PrintPreviewSubItem
    Friend WithEvents miPageLayout As DevExpress.XtraPrinting.Preview.PrintPreviewSubItem
    Friend WithEvents miPageLayoutFacing As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents miPageLayoutContinuous As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents miToolbars As DevExpress.XtraBars.BarToolbarsListItem
    Friend WithEvents miBackground As DevExpress.XtraPrinting.Preview.PrintPreviewSubItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents ClsDocBindingSource As BindingSource
    Friend WithEvents Panel1 As Panel
End Class
