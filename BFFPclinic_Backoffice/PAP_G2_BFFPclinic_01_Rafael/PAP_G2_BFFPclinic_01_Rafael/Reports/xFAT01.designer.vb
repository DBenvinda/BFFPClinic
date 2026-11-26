<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class xFAT01
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim QrCodeGenerator1 As DevExpress.XtraPrinting.BarCode.QRCodeGenerator = New DevExpress.XtraPrinting.BarCode.QRCodeGenerator()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xFAT01))
        Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim ObjectConstructorInfo1 As DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo = New DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo()
        Dim Parameter1 As DevExpress.DataAccess.ObjectBinding.Parameter = New DevExpress.DataAccess.ObjectBinding.Parameter()
        Dim XrWatermark1 As DevExpress.XtraReports.UI.XRWatermark = New DevExpress.XtraReports.UI.XRWatermark()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrPanel2 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrLabel39 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel40 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel41 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel38 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel37 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.cfCod_Postal_LOcalidade = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfNIF_Empresa = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfMatricula = New DevExpress.XtraReports.UI.CalculatedField()
        Me.cfRegistoCRC = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CF_Num_DOc = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CF_NIF_ENTIDADE = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CF_CP_LOCAL_ENT = New DevExpress.XtraReports.UI.CalculatedField()
        Me.EVEN = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ODD = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.XrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.ObjectDataSource1 = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 20.83333!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 50.97541!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel20, Me.XrLabel24, Me.XrLabel23, Me.XrLabel22, Me.XrLabel21, Me.XrLabel19, Me.XrLabel18, Me.XrLabel9})
        Me.Detail.HeightF = 14.71818!
        Me.Detail.Name = "Detail"
        '
        'XrLabel20
        '
        Me.XrLabel20.BackColor = System.Drawing.Color.Teal
        Me.XrLabel20.BorderColor = System.Drawing.Color.White
        Me.XrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel20.ForeColor = System.Drawing.Color.White
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(492.6942!, 0!)
        Me.XrLabel20.Multiline = True
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(33.073!, 14.71818!)
        Me.XrLabel20.StylePriority.UseBackColor = False
        Me.XrLabel20.StylePriority.UseBorderColor = False
        Me.XrLabel20.StylePriority.UseBorders = False
        Me.XrLabel20.StylePriority.UseForeColor = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = "QTD"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel24
        '
        Me.XrLabel24.BackColor = System.Drawing.Color.Teal
        Me.XrLabel24.BorderColor = System.Drawing.Color.White
        Me.XrLabel24.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel24.ForeColor = System.Drawing.Color.White
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(684.882!, 0!)
        Me.XrLabel24.Multiline = True
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(82.1181!, 14.71818!)
        Me.XrLabel24.StylePriority.UseBackColor = False
        Me.XrLabel24.StylePriority.UseBorderColor = False
        Me.XrLabel24.StylePriority.UseBorders = False
        Me.XrLabel24.StylePriority.UseForeColor = False
        Me.XrLabel24.StylePriority.UseTextAlignment = False
        Me.XrLabel24.Text = "Valor Ilíquido"
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel23
        '
        Me.XrLabel23.BackColor = System.Drawing.Color.Teal
        Me.XrLabel23.BorderColor = System.Drawing.Color.White
        Me.XrLabel23.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel23.ForeColor = System.Drawing.Color.White
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(651.809!, 0!)
        Me.XrLabel23.Multiline = True
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(33.07294!, 14.71818!)
        Me.XrLabel23.StylePriority.UseBackColor = False
        Me.XrLabel23.StylePriority.UseBorderColor = False
        Me.XrLabel23.StylePriority.UseBorders = False
        Me.XrLabel23.StylePriority.UseForeColor = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.Text = "IVA"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel22
        '
        Me.XrLabel22.BackColor = System.Drawing.Color.Teal
        Me.XrLabel22.BorderColor = System.Drawing.Color.White
        Me.XrLabel22.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel22.ForeColor = System.Drawing.Color.White
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(607.8853!, 0!)
        Me.XrLabel22.Multiline = True
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(43.92371!, 14.71818!)
        Me.XrLabel22.StylePriority.UseBackColor = False
        Me.XrLabel22.StylePriority.UseBorderColor = False
        Me.XrLabel22.StylePriority.UseBorders = False
        Me.XrLabel22.StylePriority.UseForeColor = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.Text = "%Dsc"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel21
        '
        Me.XrLabel21.BackColor = System.Drawing.Color.Teal
        Me.XrLabel21.BorderColor = System.Drawing.Color.White
        Me.XrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel21.ForeColor = System.Drawing.Color.White
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(525.7672!, 0!)
        Me.XrLabel21.Multiline = True
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(82.1181!, 14.71818!)
        Me.XrLabel21.StylePriority.UseBackColor = False
        Me.XrLabel21.StylePriority.UseBorderColor = False
        Me.XrLabel21.StylePriority.UseBorders = False
        Me.XrLabel21.StylePriority.UseForeColor = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = "Preço Unitário"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel19
        '
        Me.XrLabel19.BackColor = System.Drawing.Color.Teal
        Me.XrLabel19.BorderColor = System.Drawing.Color.White
        Me.XrLabel19.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel19.ForeColor = System.Drawing.Color.White
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(79.7916!, 0!)
        Me.XrLabel19.Multiline = True
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(412.9025!, 14.71818!)
        Me.XrLabel19.StylePriority.UseBackColor = False
        Me.XrLabel19.StylePriority.UseBorderColor = False
        Me.XrLabel19.StylePriority.UseBorders = False
        Me.XrLabel19.StylePriority.UseForeColor = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "Artigo"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel18
        '
        Me.XrLabel18.BackColor = System.Drawing.Color.Teal
        Me.XrLabel18.BorderColor = System.Drawing.Color.White
        Me.XrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel18.ForeColor = System.Drawing.Color.White
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(21.35415!, 0!)
        Me.XrLabel18.Multiline = True
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(58.43749!, 14.71818!)
        Me.XrLabel18.StylePriority.UseBackColor = False
        Me.XrLabel18.StylePriority.UseBorderColor = False
        Me.XrLabel18.StylePriority.UseBorders = False
        Me.XrLabel18.StylePriority.UseForeColor = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "Código"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.BackColor = System.Drawing.Color.Teal
        Me.XrLabel9.BorderColor = System.Drawing.Color.White
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel9.ForeColor = System.Drawing.Color.White
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel9.Multiline = True
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(21.35418!, 14.71818!)
        Me.XrLabel9.StylePriority.UseBackColor = False
        Me.XrLabel9.StylePriority.UseBorderColor = False
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseForeColor = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Nº"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2, Me.XrTable1, Me.XrPanel2, Me.XrBarCode1, Me.XrLabel1, Me.XrPictureBox1, Me.XrPanel1})
        Me.PageHeader.HeightF = 437.7182!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrTable2
        '
        Me.XrTable2.BackColor = System.Drawing.Color.Empty
        Me.XrTable2.BorderColor = System.Drawing.Color.Teal
        Me.XrTable2.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New DevExpress.Drawing.DXFont("Arial", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTable2.ForeColor = System.Drawing.Color.White
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0.0001273155!, 366.2599!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(766.9999!, 25.0!)
        Me.XrTable2.StylePriority.UseBackColor = False
        Me.XrTable2.StylePriority.UseBorderColor = False
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseForeColor = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell9, Me.XrTableCell10})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Data_Doc]")})
        Me.XrTableCell6.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell6.Multiline = True
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.StylePriority.UseBorders = False
        Me.XrTableCell6.StylePriority.UseForeColor = False
        Me.XrTableCell6.TextFormatString = "{0:dd-MM-yyyy}"
        Me.XrTableCell6.Weight = 1.0266208155012295R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Data_Vencimento]")})
        Me.XrTableCell7.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell7.Multiline = True
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.StylePriority.UseForeColor = False
        Me.XrTableCell7.TextFormatString = "{0:dd-MM-yyyy}"
        Me.XrTableCell7.Weight = 1.0R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Designacao]")})
        Me.XrTableCell8.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell8.Multiline = True
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseForeColor = False
        Me.XrTableCell8.Weight = 1.0R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Tipo_Pagamento]")})
        Me.XrTableCell9.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell9.Multiline = True
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StylePriority.UseForeColor = False
        Me.XrTableCell9.Weight = 0.99999930423552508R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Num_Doc]")})
        Me.XrTableCell10.ForeColor = System.Drawing.Color.Black
        Me.XrTableCell10.Multiline = True
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseBorders = False
        Me.XrTableCell10.StylePriority.UseForeColor = False
        Me.XrTableCell10.Weight = 0.97337878582782389R
        '
        'XrTable1
        '
        Me.XrTable1.BackColor = System.Drawing.Color.Teal
        Me.XrTable1.BorderColor = System.Drawing.Color.White
        Me.XrTable1.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrTable1.Font = New DevExpress.Drawing.DXFont("Arial", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTable1.ForeColor = System.Drawing.Color.White
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0.00009679794!, 341.2599!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(766.9999!, 25.0!)
        Me.XrTable1.StylePriority.UseBackColor = False
        Me.XrTable1.StylePriority.UseBorderColor = False
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseForeColor = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell5})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Multiline = True
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Text = "Data Documento"
        Me.XrTableCell1.Weight = 1.0266210144424128R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Multiline = True
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Text = "Data Vencimento"
        Me.XrTableCell2.Weight = 1.0R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Multiline = True
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Text = "Tipo Documento"
        Me.XrTableCell3.Weight = 1.0R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Multiline = True
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Text = "Cond.Pagamento"
        Me.XrTableCell4.Weight = 1.0R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell5.Multiline = True
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseBorders = False
        Me.XrTableCell5.Text = "Nº Documento"
        Me.XrTableCell5.Weight = 0.973378088741872R
        '
        'XrPanel2
        '
        Me.XrPanel2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.XrPanel2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel17, Me.XrLabel16, Me.XrLabel15, Me.XrLabel14, Me.XrLabel13})
        Me.XrPanel2.LocationFloat = New DevExpress.Utils.PointFloat(350.0798!, 89.30005!)
        Me.XrPanel2.Name = "XrPanel2"
        Me.XrPanel2.SizeF = New System.Drawing.SizeF(339.4966!, 91.22917!)
        Me.XrPanel2.StylePriority.UseBackColor = False
        '
        'XrLabel17
        '
        Me.XrLabel17.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CF_CP_LOCAL_ENT]")})
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(9.999939!, 69.87221!)
        Me.XrLabel17.Multiline = True
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(319.4966!, 13.625!)
        Me.XrLabel17.Text = "XrLabel17"
        '
        'XrLabel16
        '
        Me.XrLabel16.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Entidade].[Endereco].[Endereco]")})
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(9.999939!, 56.24721!)
        Me.XrLabel16.Multiline = True
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(319.4966!, 13.62498!)
        Me.XrLabel16.Text = "XrLabel16"
        '
        'XrLabel15
        '
        Me.XrLabel15.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Entidade].[Nome]")})
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(9.999939!, 42.62219!)
        Me.XrLabel15.Multiline = True
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(319.4966!, 13.62498!)
        Me.XrLabel15.Text = "XrLabel15"
        '
        'XrLabel14
        '
        Me.XrLabel14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Entidade].[Cod_Entidade]")})
        Me.XrLabel14.Font = New DevExpress.Drawing.DXFont("Arial", 8.0!, DevExpress.Drawing.DXFontStyle.Italic)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(10.00003!, 10.0!)
        Me.XrLabel14.Multiline = True
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(61.37854!, 13.62498!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.Text = "XrLabel14"
        '
        'XrLabel13
        '
        Me.XrLabel13.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CF_NIF_ENTIDADE]")})
        Me.XrLabel13.Font = New DevExpress.Drawing.DXFont("Arial", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(229.4966!, 10.0!)
        Me.XrLabel13.Multiline = True
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(100.0!, 13.62498!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "XrLabel13"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrBarCode1
        '
        Me.XrBarCode1.AutoModule = True
        Me.XrBarCode1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Num_Doc]")})
        Me.XrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(691.1754!, 27.84539!)
        Me.XrBarCode1.Name = "XrBarCode1"
        Me.XrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.XrBarCode1.ShowText = False
        Me.XrBarCode1.SizeF = New System.Drawing.SizeF(75.82489!, 61.00083!)
        Me.XrBarCode1.Symbology = QrCodeGenerator1
        '
        'XrLabel1
        '
        Me.XrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CF_Num_DOc]")})
        Me.XrLabel1.Font = New DevExpress.Drawing.DXFont("Arial", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(618.34!, 9.999994!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(138.66!, 17.84536!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.XrPictureBox1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox1.ImageSource"))
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(4.083693!, 9.999994!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(204.6125!, 135.5472!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        Me.XrPictureBox1.StylePriority.UseBackColor = False
        '
        'XrPanel1
        '
        Me.XrPanel1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel11, Me.XrLabel5, Me.XrLabel4, Me.XrLabel10, Me.XrLabel7, Me.XrLabel3, Me.XrLabel2})
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 145.5472!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(272.9377!, 121.8153!)
        Me.XrPanel1.StylePriority.UseBackColor = False
        '
        'XrLabel11
        '
        Me.XrLabel11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cfRegistoCRC]")})
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(4.08373!, 89.48189!)
        Me.XrLabel11.Multiline = True
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(258.8544!, 13.62495!)
        Me.XrLabel11.Text = "XrLabel11"
        '
        'XrLabel5
        '
        Me.XrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Empresa].[Email]")})
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(4.08373!, 62.23193!)
        Me.XrLabel5.Multiline = True
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(258.854!, 13.625!)
        Me.XrLabel5.Text = "XrLabel5"
        '
        'XrLabel4
        '
        Me.XrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cfMatricula]")})
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(4.08373!, 75.85693!)
        Me.XrLabel4.Multiline = True
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(258.854!, 13.62495!)
        Me.XrLabel4.Text = "XrLabel4"
        '
        'XrLabel10
        '
        Me.XrLabel10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cfNIF_Empresa]")})
        Me.XrLabel10.Font = New DevExpress.Drawing.DXFont("Arial", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(162.9381!, 7.731964!)
        Me.XrLabel10.Multiline = True
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(99.99997!, 13.625!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "XrLabel10"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel7
        '
        Me.XrLabel7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cfCod_Postal_LOcalidade]")})
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(4.08371!, 48.60696!)
        Me.XrLabel7.Multiline = True
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(258.8542!, 13.62498!)
        Me.XrLabel7.Text = "XrLabel7"
        '
        'XrLabel3
        '
        Me.XrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Empresa].[Endereco]")})
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(4.08371!, 34.98196!)
        Me.XrLabel3.Multiline = True
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(258.8542!, 13.625!)
        Me.XrLabel3.Text = "XrLabel3"
        '
        'XrLabel2
        '
        Me.XrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Empresa].[Nome]")})
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(4.08371!, 21.35696!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(258.8542!, 13.625!)
        Me.XrLabel2.Text = "XrLabel2"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrSubreport1, Me.XrLabel39, Me.XrLabel40, Me.XrLabel41, Me.XrLabel38, Me.XrLabel37, Me.XrLabel36, Me.XrLabel35, Me.XrLabel34, Me.XrLabel33, Me.XrLabel32, Me.XrLabel31, Me.XrLabel26, Me.XrLine2})
        Me.PageFooter.HeightF = 250.5005!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrLabel39
        '
        Me.XrLabel39.BackColor = System.Drawing.Color.Teal
        Me.XrLabel39.BorderColor = System.Drawing.Color.White
        Me.XrLabel39.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel39.CanGrow = False
        Me.XrLabel39.ForeColor = System.Drawing.Color.White
        Me.XrLabel39.LocationFloat = New DevExpress.Utils.PointFloat(575.8933!, 44.43748!)
        Me.XrLabel39.Name = "XrLabel39"
        Me.XrLabel39.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel39.SizeF = New System.Drawing.SizeF(108.9891!, 13.57346!)
        Me.XrLabel39.StylePriority.UseBackColor = False
        Me.XrLabel39.StylePriority.UseBorderColor = False
        Me.XrLabel39.StylePriority.UseBorders = False
        Me.XrLabel39.StylePriority.UseForeColor = False
        Me.XrLabel39.StylePriority.UseTextAlignment = False
        Me.XrLabel39.Text = "Total do Documento"
        Me.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel39.WordWrap = False
        '
        'XrLabel40
        '
        Me.XrLabel40.BackColor = System.Drawing.Color.Teal
        Me.XrLabel40.BorderColor = System.Drawing.Color.White
        Me.XrLabel40.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel40.CanGrow = False
        Me.XrLabel40.ForeColor = System.Drawing.Color.White
        Me.XrLabel40.LocationFloat = New DevExpress.Utils.PointFloat(575.8933!, 58.01094!)
        Me.XrLabel40.Name = "XrLabel40"
        Me.XrLabel40.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel40.SizeF = New System.Drawing.SizeF(108.9891!, 14.71818!)
        Me.XrLabel40.StylePriority.UseBackColor = False
        Me.XrLabel40.StylePriority.UseBorderColor = False
        Me.XrLabel40.StylePriority.UseBorders = False
        Me.XrLabel40.StylePriority.UseForeColor = False
        Me.XrLabel40.StylePriority.UseTextAlignment = False
        Me.XrLabel40.Text = "Acertos"
        Me.XrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel40.WordWrap = False
        '
        'XrLabel41
        '
        Me.XrLabel41.BackColor = System.Drawing.Color.Teal
        Me.XrLabel41.BorderColor = System.Drawing.Color.Teal
        Me.XrLabel41.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel41.CanGrow = False
        Me.XrLabel41.ForeColor = System.Drawing.Color.White
        Me.XrLabel41.LocationFloat = New DevExpress.Utils.PointFloat(575.8928!, 72.72911!)
        Me.XrLabel41.Name = "XrLabel41"
        Me.XrLabel41.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel41.SizeF = New System.Drawing.SizeF(108.9891!, 14.14579!)
        Me.XrLabel41.StylePriority.UseBackColor = False
        Me.XrLabel41.StylePriority.UseBorderColor = False
        Me.XrLabel41.StylePriority.UseBorders = False
        Me.XrLabel41.StylePriority.UseForeColor = False
        Me.XrLabel41.StylePriority.UseTextAlignment = False
        Me.XrLabel41.Text = "Total a Pagar"
        Me.XrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel41.WordWrap = False
        '
        'XrLabel38
        '
        Me.XrLabel38.BackColor = System.Drawing.Color.Teal
        Me.XrLabel38.BorderColor = System.Drawing.Color.White
        Me.XrLabel38.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel38.CanGrow = False
        Me.XrLabel38.ForeColor = System.Drawing.Color.White
        Me.XrLabel38.LocationFloat = New DevExpress.Utils.PointFloat(575.8928!, 30.29169!)
        Me.XrLabel38.Name = "XrLabel38"
        Me.XrLabel38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel38.SizeF = New System.Drawing.SizeF(108.9891!, 14.14581!)
        Me.XrLabel38.StylePriority.UseBackColor = False
        Me.XrLabel38.StylePriority.UseBorderColor = False
        Me.XrLabel38.StylePriority.UseBorders = False
        Me.XrLabel38.StylePriority.UseForeColor = False
        Me.XrLabel38.StylePriority.UseTextAlignment = False
        Me.XrLabel38.Text = "Total de IVA"
        Me.XrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel38.WordWrap = False
        '
        'XrLabel37
        '
        Me.XrLabel37.BackColor = System.Drawing.Color.Teal
        Me.XrLabel37.BorderColor = System.Drawing.Color.White
        Me.XrLabel37.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel37.CanGrow = False
        Me.XrLabel37.ForeColor = System.Drawing.Color.White
        Me.XrLabel37.LocationFloat = New DevExpress.Utils.PointFloat(575.8928!, 15.57348!)
        Me.XrLabel37.Name = "XrLabel37"
        Me.XrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel37.SizeF = New System.Drawing.SizeF(108.9891!, 14.71818!)
        Me.XrLabel37.StylePriority.UseBackColor = False
        Me.XrLabel37.StylePriority.UseBorderColor = False
        Me.XrLabel37.StylePriority.UseBorders = False
        Me.XrLabel37.StylePriority.UseForeColor = False
        Me.XrLabel37.StylePriority.UseTextAlignment = False
        Me.XrLabel37.Text = "Total Descontos"
        Me.XrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel37.WordWrap = False
        '
        'XrLabel36
        '
        Me.XrLabel36.BackColor = System.Drawing.Color.Teal
        Me.XrLabel36.BorderColor = System.Drawing.Color.White
        Me.XrLabel36.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel36.CanGrow = False
        Me.XrLabel36.ForeColor = System.Drawing.Color.White
        Me.XrLabel36.LocationFloat = New DevExpress.Utils.PointFloat(575.8928!, 1.999982!)
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel36.SizeF = New System.Drawing.SizeF(108.9891!, 13.5735!)
        Me.XrLabel36.StylePriority.UseBackColor = False
        Me.XrLabel36.StylePriority.UseBorderColor = False
        Me.XrLabel36.StylePriority.UseBorders = False
        Me.XrLabel36.StylePriority.UseForeColor = False
        Me.XrLabel36.StylePriority.UseTextAlignment = False
        Me.XrLabel36.Text = "Total Ilíquido"
        Me.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel36.WordWrap = False
        '
        'XrLabel35
        '
        Me.XrLabel35.BorderColor = System.Drawing.Color.Teal
        Me.XrLabel35.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel35.CanGrow = False
        Me.XrLabel35.EvenStyleName = "EVEN"
        Me.XrLabel35.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Totais].[Total_A_Pagar]")})
        Me.XrLabel35.LocationFloat = New DevExpress.Utils.PointFloat(684.8819!, 72.72912!)
        Me.XrLabel35.Name = "XrLabel35"
        Me.XrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel35.SizeF = New System.Drawing.SizeF(82.11816!, 14.14582!)
        Me.XrLabel35.StylePriority.UseBorderColor = False
        Me.XrLabel35.StylePriority.UseBorders = False
        Me.XrLabel35.StylePriority.UseTextAlignment = False
        Me.XrLabel35.Text = "XrLabel29"
        Me.XrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel35.TextFormatString = "{0:C}"
        Me.XrLabel35.WordWrap = False
        '
        'XrLabel34
        '
        Me.XrLabel34.BorderColor = System.Drawing.Color.Teal
        Me.XrLabel34.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel34.CanGrow = False
        Me.XrLabel34.EvenStyleName = "EVEN"
        Me.XrLabel34.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Totais].[Acertos]")})
        Me.XrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(684.8824!, 58.58331!)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel34.SizeF = New System.Drawing.SizeF(82.11816!, 14.14582!)
        Me.XrLabel34.StylePriority.UseBorderColor = False
        Me.XrLabel34.StylePriority.UseBorders = False
        Me.XrLabel34.StylePriority.UseTextAlignment = False
        Me.XrLabel34.Text = "XrLabel29"
        Me.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel34.TextFormatString = "{0:C}"
        Me.XrLabel34.WordWrap = False
        '
        'XrLabel33
        '
        Me.XrLabel33.BorderColor = System.Drawing.Color.Teal
        Me.XrLabel33.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel33.CanGrow = False
        Me.XrLabel33.EvenStyleName = "EVEN"
        Me.XrLabel33.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Totais].[Total_Doc]")})
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(684.8824!, 44.43748!)
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(82.11816!, 13.57345!)
        Me.XrLabel33.StylePriority.UseBorderColor = False
        Me.XrLabel33.StylePriority.UseBorders = False
        Me.XrLabel33.StylePriority.UseTextAlignment = False
        Me.XrLabel33.Text = "XrLabel29"
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel33.TextFormatString = "{0:C}"
        Me.XrLabel33.WordWrap = False
        '
        'XrLabel32
        '
        Me.XrLabel32.BorderColor = System.Drawing.Color.Teal
        Me.XrLabel32.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel32.CanGrow = False
        Me.XrLabel32.EvenStyleName = "EVEN"
        Me.XrLabel32.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Totais].[Total_IVA]")})
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(684.8819!, 30.29166!)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(82.11816!, 14.14582!)
        Me.XrLabel32.StylePriority.UseBorderColor = False
        Me.XrLabel32.StylePriority.UseBorders = False
        Me.XrLabel32.StylePriority.UseTextAlignment = False
        Me.XrLabel32.Text = "XrLabel29"
        Me.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel32.TextFormatString = "{0:C}"
        Me.XrLabel32.WordWrap = False
        '
        'XrLabel31
        '
        Me.XrLabel31.BorderColor = System.Drawing.Color.Teal
        Me.XrLabel31.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel31.CanGrow = False
        Me.XrLabel31.EvenStyleName = "EVEN"
        Me.XrLabel31.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Totais].[Total_Desconto]")})
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(684.8822!, 16.14583!)
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(82.11816!, 14.14582!)
        Me.XrLabel31.StylePriority.UseBorderColor = False
        Me.XrLabel31.StylePriority.UseBorders = False
        Me.XrLabel31.StylePriority.UseTextAlignment = False
        Me.XrLabel31.Text = "XrLabel29"
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel31.TextFormatString = "{0:C}"
        Me.XrLabel31.WordWrap = False
        '
        'XrLabel26
        '
        Me.XrLabel26.BorderColor = System.Drawing.Color.Teal
        Me.XrLabel26.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel26.CanGrow = False
        Me.XrLabel26.EvenStyleName = "EVEN"
        Me.XrLabel26.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Totais].[Total_Iliquido]")})
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(684.8819!, 2.000001!)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(82.11816!, 14.14582!)
        Me.XrLabel26.StylePriority.UseBorderColor = False
        Me.XrLabel26.StylePriority.UseBorders = False
        Me.XrLabel26.StylePriority.UseTextAlignment = False
        Me.XrLabel26.Text = "XrLabel29"
        Me.XrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel26.TextFormatString = "{0:C}"
        Me.XrLabel26.WordWrap = False
        '
        'XrLine2
        '
        Me.XrLine2.ForeColor = System.Drawing.Color.Teal
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(767.0001!, 2.0!)
        Me.XrLine2.StylePriority.UseForeColor = False
        '
        'DetailReport
        '
        Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1})
        Me.DetailReport.DataMember = "Linhas"
        Me.DetailReport.DataSource = Me.ObjectDataSource1
        Me.DetailReport.Level = 0
        Me.DetailReport.Name = "DetailReport"
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel28, Me.XrLabel30, Me.XrLabel25, Me.XrLabel29, Me.XrLabel27, Me.XrLabel12, Me.XrLabel8, Me.XrLabel6})
        Me.Detail1.EvenStyleName = "EVEN"
        Me.Detail1.HeightF = 14.14582!
        Me.Detail1.Name = "Detail1"
        Me.Detail1.StylePriority.UseTextAlignment = False
        Me.Detail1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel28
        '
        Me.XrLabel28.BorderColor = System.Drawing.Color.Teal
        Me.XrLabel28.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel28.CanGrow = False
        Me.XrLabel28.CanPublish = False
        Me.XrLabel28.EvenStyleName = "EVEN"
        Me.XrLabel28.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[sTaxa_IVA]")})
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(651.809!, 0!)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.OddStyleName = "ODD"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(33.07288!, 14.14579!)
        Me.XrLabel28.StylePriority.UseBorderColor = False
        Me.XrLabel28.StylePriority.UseBorderDashStyle = False
        Me.XrLabel28.StylePriority.UseBorders = False
        Me.XrLabel28.StylePriority.UseTextAlignment = False
        Me.XrLabel28.Text = "XrLabel28"
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel28.WordWrap = False
        '
        'XrLabel30
        '
        Me.XrLabel30.BorderColor = System.Drawing.Color.Teal
        Me.XrLabel30.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel30.CanGrow = False
        Me.XrLabel30.CanPublish = False
        Me.XrLabel30.EvenStyleName = "EVEN"
        Me.XrLabel30.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Linhas].[sP_Unitario]")})
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(525.767!, 0!)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.OddStyleName = "ODD"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(82.11816!, 14.1458!)
        Me.XrLabel30.StylePriority.UseBorderColor = False
        Me.XrLabel30.StylePriority.UseBorderDashStyle = False
        Me.XrLabel30.StylePriority.UseBorders = False
        Me.XrLabel30.StylePriority.UseTextAlignment = False
        Me.XrLabel30.Text = "XrLabel30"
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel30.WordWrap = False
        '
        'XrLabel25
        '
        Me.XrLabel25.BorderColor = System.Drawing.Color.Teal
        Me.XrLabel25.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel25.CanGrow = False
        Me.XrLabel25.CanPublish = False
        Me.XrLabel25.EvenStyleName = "EVEN"
        Me.XrLabel25.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[sQTD]")})
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(492.6942!, 0!)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.OddStyleName = "ODD"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(33.07303!, 14.14582!)
        Me.XrLabel25.StylePriority.UseBorderColor = False
        Me.XrLabel25.StylePriority.UseBorderDashStyle = False
        Me.XrLabel25.StylePriority.UseBorders = False
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        Me.XrLabel25.Text = "XrLabel25"
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel25.WordWrap = False
        '
        'XrLabel29
        '
        Me.XrLabel29.BorderColor = System.Drawing.Color.Teal
        Me.XrLabel29.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel29.CanGrow = False
        Me.XrLabel29.CanPublish = False
        Me.XrLabel29.EvenStyleName = "EVEN"
        Me.XrLabel29.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[sValor_Iliquido]")})
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(684.8822!, 0!)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.OddStyleName = "ODD"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(82.11816!, 14.14582!)
        Me.XrLabel29.StylePriority.UseBorderColor = False
        Me.XrLabel29.StylePriority.UseBorderDashStyle = False
        Me.XrLabel29.StylePriority.UseBorders = False
        Me.XrLabel29.StylePriority.UseTextAlignment = False
        Me.XrLabel29.Text = "XrLabel29"
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel29.WordWrap = False
        '
        'XrLabel27
        '
        Me.XrLabel27.BorderColor = System.Drawing.Color.Teal
        Me.XrLabel27.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel27.CanGrow = False
        Me.XrLabel27.CanPublish = False
        Me.XrLabel27.EvenStyleName = "EVEN"
        Me.XrLabel27.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[sTaxa_Desconto]")})
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(607.8853!, 0!)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.OddStyleName = "ODD"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(43.92371!, 14.14582!)
        Me.XrLabel27.StylePriority.UseBorderColor = False
        Me.XrLabel27.StylePriority.UseBorderDashStyle = False
        Me.XrLabel27.StylePriority.UseBorders = False
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        Me.XrLabel27.Text = "XrLabel27"
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel27.WordWrap = False
        '
        'XrLabel12
        '
        Me.XrLabel12.BorderColor = System.Drawing.Color.Teal
        Me.XrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel12.CanGrow = False
        Me.XrLabel12.CanPublish = False
        Me.XrLabel12.EvenStyleName = "EVEN"
        Me.XrLabel12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Artigo]")})
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(79.7916!, 0!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.OddStyleName = "ODD"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(412.9026!, 14.14582!)
        Me.XrLabel12.StylePriority.UseBorderColor = False
        Me.XrLabel12.StylePriority.UseBorderDashStyle = False
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "XrLabel12"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel12.WordWrap = False
        '
        'XrLabel8
        '
        Me.XrLabel8.BorderColor = System.Drawing.Color.Teal
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel8.CanGrow = False
        Me.XrLabel8.CanPublish = False
        Me.XrLabel8.EvenStyleName = "EVEN"
        Me.XrLabel8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Cod_Artigo]")})
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(21.35415!, 0!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.OddStyleName = "ODD"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(58.43749!, 14.14582!)
        Me.XrLabel8.StylePriority.UseBorderColor = False
        Me.XrLabel8.StylePriority.UseBorderDashStyle = False
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "XrLabel8"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel8.WordWrap = False
        '
        'XrLabel6
        '
        Me.XrLabel6.BorderColor = System.Drawing.Color.Teal
        Me.XrLabel6.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel6.CanGrow = False
        Me.XrLabel6.CanPublish = False
        Me.XrLabel6.EvenStyleName = "EVEN"
        Me.XrLabel6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[sNum_Linha]")})
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.OddStyleName = "ODD"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(21.35419!, 14.14582!)
        Me.XrLabel6.StylePriority.UseBorderColor = False
        Me.XrLabel6.StylePriority.UseBorderDashStyle = False
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "XrLabel6"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel6.WordWrap = False
        '
        'cfCod_Postal_LOcalidade
        '
        Me.cfCod_Postal_LOcalidade.Expression = "[Empresa].[Cod_Postal] + ' ' + [Empresa].[Localidade]"
        Me.cfCod_Postal_LOcalidade.Name = "cfCod_Postal_LOcalidade"
        '
        'cfNIF_Empresa
        '
        Me.cfNIF_Empresa.Expression = "'NIF: ' + [Empresa].[NIF]"
        Me.cfNIF_Empresa.Name = "cfNIF_Empresa"
        '
        'cfMatricula
        '
        Me.cfMatricula.Expression = "'Matrícula na CRC: '+[Empresa].[Matricula_CRC]"
        Me.cfMatricula.Name = "cfMatricula"
        '
        'cfRegistoCRC
        '
        Me.cfRegistoCRC.Expression = "'Registado na CRC: ' + [Empresa].[Registo_Comercial]"
        Me.cfRegistoCRC.Name = "cfRegistoCRC"
        '
        'CF_Num_DOc
        '
        Me.CF_Num_DOc.Expression = "'Documento: ' + [Num_Doc]"
        Me.CF_Num_DOc.Name = "CF_Num_DOc"
        '
        'CF_NIF_ENTIDADE
        '
        Me.CF_NIF_ENTIDADE.Expression = "'NIF: ' + [Entidade].[NIF]"
        Me.CF_NIF_ENTIDADE.Name = "CF_NIF_ENTIDADE"
        '
        'CF_CP_LOCAL_ENT
        '
        Me.CF_CP_LOCAL_ENT.Expression = "[Entidade].[Endereco].[Cod_Postal] + ' ' + [Entidade].[Endereco].[Localidade]"
        Me.CF_CP_LOCAL_ENT.Name = "CF_CP_LOCAL_ENT"
        '
        'EVEN
        '
        Me.EVEN.BackColor = System.Drawing.Color.LightCyan
        Me.EVEN.Name = "EVEN"
        Me.EVEN.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        '
        'ODD
        '
        Me.ODD.Name = "ODD"
        Me.ODD.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "Connection"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        ColumnExpression1.ColumnName = "ID_Linha"
        Table1.Name = "Linhas"
        ColumnExpression1.Table = Table1
        Column1.Expression = ColumnExpression1
        ColumnExpression2.ColumnName = "Num_Doc"
        ColumnExpression2.Table = Table1
        Column2.Expression = ColumnExpression2
        ColumnExpression3.ColumnName = "Num_Linha"
        ColumnExpression3.Table = Table1
        Column3.Expression = ColumnExpression3
        ColumnExpression4.ColumnName = "Cod_Artigo"
        ColumnExpression4.Table = Table1
        Column4.Expression = ColumnExpression4
        ColumnExpression5.ColumnName = "Quantidade"
        ColumnExpression5.Table = Table1
        Column5.Expression = ColumnExpression5
        ColumnExpression6.ColumnName = "P_Unitario"
        ColumnExpression6.Table = Table1
        Column6.Expression = ColumnExpression6
        ColumnExpression7.ColumnName = "Taxa_Desconto"
        ColumnExpression7.Table = Table1
        Column7.Expression = ColumnExpression7
        ColumnExpression8.ColumnName = "FLG_Ativo"
        ColumnExpression8.Table = Table1
        Column8.Expression = ColumnExpression8
        SelectQuery1.Columns.Add(Column1)
        SelectQuery1.Columns.Add(Column2)
        SelectQuery1.Columns.Add(Column3)
        SelectQuery1.Columns.Add(Column4)
        SelectQuery1.Columns.Add(Column5)
        SelectQuery1.Columns.Add(Column6)
        SelectQuery1.Columns.Add(Column7)
        SelectQuery1.Columns.Add(Column8)
        SelectQuery1.Name = "Linhas"
        SelectQuery1.Tables.Add(Table1)
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'XrSubreport1
        '
        Me.XrSubreport1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "HeightF", "[QI]")})
        Me.XrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 15.57347!)
        Me.XrSubreport1.Name = "XrSubreport1"
        Me.XrSubreport1.ReportSource = New PAP_G2_BFFPclinic_01_Rafael.xrQI()
        Me.XrSubreport1.SizeF = New System.Drawing.SizeF(258.8544!, 136.9583!)
        '
        'ObjectDataSource1
        '
        Me.ObjectDataSource1.Constructor = ObjectConstructorInfo1
        Me.ObjectDataSource1.DataMember = "GetDocByCod"
        Me.ObjectDataSource1.DataSource = GetType(PAP_G2_BFFPclinic_01_Rafael.ClsDoc)
        Me.ObjectDataSource1.Name = "ObjectDataSource1"
        Parameter1.Name = "pNum_Doc"
        Parameter1.Type = GetType(String)
        Parameter1.ValueInfo = "FC029/2023"
        Me.ObjectDataSource1.Parameters.AddRange(New DevExpress.DataAccess.ObjectBinding.Parameter() {Parameter1})
        '
        'xFAT01
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.PageHeader, Me.PageFooter, Me.DetailReport})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.cfCod_Postal_LOcalidade, Me.cfNIF_Empresa, Me.cfMatricula, Me.cfRegistoCRC, Me.CF_Num_DOc, Me.CF_NIF_ENTIDADE, Me.CF_CP_LOCAL_ENT})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.ObjectDataSource1, Me.SqlDataSource1})
        Me.DataSource = Me.ObjectDataSource1
        Me.Font = New DevExpress.Drawing.DXFont("Arial", 8.0!)
        Me.Margins = New DevExpress.Drawing.DXMargins(28.0!, 31.0!, 20.83333!, 50.97541!)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.EVEN, Me.ODD})
        Me.Version = "23.2"
        XrWatermark1.Id = "Watermark1"
        Me.Watermarks.Add(XrWatermark1)
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ObjectDataSource1 As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents cfCod_Postal_LOcalidade As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfNIF_Empresa As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfMatricula As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents cfRegistoCRC As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CF_Num_DOc As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrPanel2 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CF_NIF_ENTIDADE As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents CF_CP_LOCAL_ENT As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents EVEN As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel40 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel41 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel38 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel37 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ODD As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents XrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
End Class
