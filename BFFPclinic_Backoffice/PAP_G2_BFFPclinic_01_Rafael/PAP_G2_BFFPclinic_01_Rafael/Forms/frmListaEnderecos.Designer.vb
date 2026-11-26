<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaEnderecos
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsEnderecos", -1)
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Entidade")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Endereco")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descritivo")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Endereco")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Postal")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Localidade")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Data_Registo")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnVolta_Entidades = New System.Windows.Forms.Button()
        Me.Lista_EnderecosUltraGrid = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.EnderecosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnderecosTableAdapter = New PAP_G2_BFFPclinic_01_Rafael.I21_G2DataSet2TableAdapters.EnderecosTableAdapter()
        Me.ClsEnderecosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.Lista_EnderecosUltraGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnderecosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClsEnderecosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnVolta_Entidades)
        Me.Panel1.Controls.Add(Me.Lista_EnderecosUltraGrid)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1088, 940)
        Me.Panel1.TabIndex = 2
        '
        'btnVolta_Entidades
        '
        Me.btnVolta_Entidades.Location = New System.Drawing.Point(848, 490)
        Me.btnVolta_Entidades.Name = "btnVolta_Entidades"
        Me.btnVolta_Entidades.Size = New System.Drawing.Size(102, 40)
        Me.btnVolta_Entidades.TabIndex = 12
        Me.btnVolta_Entidades.Text = "Voltar para as entidades"
        Me.btnVolta_Entidades.UseVisualStyleBackColor = True
        '
        'Lista_EnderecosUltraGrid
        '
        UltraGridColumn28.Header.VisiblePosition = 0
        UltraGridColumn28.Hidden = True
        UltraGridColumn28.Width = 53
        UltraGridColumn29.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn29.Header.Caption = "Cod"
        UltraGridColumn29.Header.VisiblePosition = 1
        UltraGridColumn29.Width = 44
        UltraGridColumn30.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn30.Header.VisiblePosition = 2
        UltraGridColumn30.Width = 154
        UltraGridColumn31.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn31.Header.Caption = "Endereço"
        UltraGridColumn31.Header.VisiblePosition = 3
        UltraGridColumn31.Width = 241
        UltraGridColumn32.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn32.Header.Caption = "CP"
        UltraGridColumn32.Header.VisiblePosition = 4
        UltraGridColumn32.Width = 49
        UltraGridColumn33.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn33.Header.VisiblePosition = 5
        UltraGridColumn33.Width = 241
        UltraGridColumn34.Header.VisiblePosition = 6
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.VisiblePosition = 7
        UltraGridColumn35.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35})
        Me.Lista_EnderecosUltraGrid.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.Lista_EnderecosUltraGrid.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.Lista_EnderecosUltraGrid.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.Lista_EnderecosUltraGrid.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.Lista_EnderecosUltraGrid.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.Lista_EnderecosUltraGrid.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.Lista_EnderecosUltraGrid.Dock = System.Windows.Forms.DockStyle.Left
        Me.Lista_EnderecosUltraGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lista_EnderecosUltraGrid.Location = New System.Drawing.Point(0, 0)
        Me.Lista_EnderecosUltraGrid.Name = "Lista_EnderecosUltraGrid"
        Me.Lista_EnderecosUltraGrid.Size = New System.Drawing.Size(750, 940)
        Me.Lista_EnderecosUltraGrid.TabIndex = 11
        Me.Lista_EnderecosUltraGrid.Text = "Lista de Endereços da Entidade"
        '
        'EnderecosTableAdapter
        '
        Me.EnderecosTableAdapter.ClearBeforeFill = True
        '
        'ClsEnderecosBindingSource
        '
        Me.ClsEnderecosBindingSource.DataSource = GetType(PAP_G2_BFFPclinic_01_Rafael.ClsEnderecos)
        '
        'frmListaEnderecos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1112, 964)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmListaEnderecos"
        Me.Text = "frmListaEnderecos"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Lista_EnderecosUltraGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnderecosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClsEnderecosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lista_EnderecosUltraGrid As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnVolta_Entidades As Button
    Friend WithEvents ClsEnderecosBindingSource As BindingSource
    Friend WithEvents EnderecosBindingSource As BindingSource
    Friend WithEvents EnderecosTableAdapter As I21_G2DataSet2TableAdapters.EnderecosTableAdapter
End Class
