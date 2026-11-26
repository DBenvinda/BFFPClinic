<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEntidades
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsEnderecos", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Entidade")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Endereco")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descritivo")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Endereco")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Postal")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Localidade")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Data_Registo")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
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
        Me.Cod_EntidadeLabel = New System.Windows.Forms.Label()
        Me.NomeLabel = New System.Windows.Forms.Label()
        Me.Num_TelefoneLabel = New System.Windows.Forms.Label()
        Me.Num_TelemovelLabel = New System.Windows.Forms.Label()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.NIFLabel = New System.Windows.Forms.Label()
        Me.PaisLabel = New System.Windows.Forms.Label()
        Me.lblUtilizador = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCod_Especialidade = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPalavra_Passe = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lista_EnderecosUltraGrid = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.cmAPAGA = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsCriar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsApagar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Data_RegistoDE = New DevExpress.XtraEditors.DateEdit()
        Me.FLG_AtivoCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.TeFotografia = New DevExpress.XtraEditors.TextEdit()
        Me.btnApaga = New System.Windows.Forms.Button()
        Me.btnCarrega = New System.Windows.Forms.Button()
        Me.ucCod_Especialidade = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Cod_PaisTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FLG_EntidadeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.tePasse = New DevExpress.XtraEditors.TextEdit()
        Me.teCod_Especialidade = New DevExpress.XtraEditors.TextEdit()
        Me.teUtilizador = New DevExpress.XtraEditors.TextEdit()
        Me.teNum_UtenteSaude = New DevExpress.XtraEditors.TextEdit()
        Me.ucPaises = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.PaisTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.teNIF = New DevExpress.XtraEditors.TextEdit()
        Me.teEmail = New DevExpress.XtraEditors.TextEdit()
        Me.teNome_Completo = New DevExpress.XtraEditors.TextEdit()
        Me.pbEntidades_Imagem = New System.Windows.Forms.PictureBox()
        Me.BtnListaEnderecos = New System.Windows.Forms.Button()
        Me.cbEntidades = New System.Windows.Forms.ComboBox()
        Me.teNum_Telemovel = New DevExpress.XtraEditors.TextEdit()
        Me.teNum_Telefone = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_EntidadeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.picCod_Especialidade = New System.Windows.Forms.PictureBox()
        Me.OFDEntidades = New System.Windows.Forms.OpenFileDialog()
        Me.TimerLoad_Lista_Enderecos = New System.Windows.Forms.Timer(Me.components)
        Me.UC_NAV11 = New PAP_G2_BFFPclinic_01_Diogo.UC_NAV1()
        Me.Panel1.SuspendLayout()
        CType(Me.Lista_EnderecosUltraGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmAPAGA.SuspendLayout()
        CType(Me.Data_RegistoDE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_RegistoDE.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLG_AtivoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeFotografia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucCod_Especialidade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_PaisTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLG_EntidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tePasse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teCod_Especialidade.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teUtilizador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNum_UtenteSaude.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucPaises, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaisTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNIF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNome_Completo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEntidades_Imagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNum_Telemovel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNum_Telefone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_EntidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCod_Especialidade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cod_EntidadeLabel
        '
        Me.Cod_EntidadeLabel.AutoSize = True
        Me.Cod_EntidadeLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Cod_EntidadeLabel.Location = New System.Drawing.Point(432, 105)
        Me.Cod_EntidadeLabel.Name = "Cod_EntidadeLabel"
        Me.Cod_EntidadeLabel.Size = New System.Drawing.Size(136, 25)
        Me.Cod_EntidadeLabel.TabIndex = 6
        Me.Cod_EntidadeLabel.Text = "Cod Entidade:"
        '
        'NomeLabel
        '
        Me.NomeLabel.AutoSize = True
        Me.NomeLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.NomeLabel.Location = New System.Drawing.Point(402, 156)
        Me.NomeLabel.Name = "NomeLabel"
        Me.NomeLabel.Size = New System.Drawing.Size(163, 25)
        Me.NomeLabel.TabIndex = 7
        Me.NomeLabel.Text = "Nome Completo:"
        '
        'Num_TelefoneLabel
        '
        Me.Num_TelefoneLabel.AutoSize = True
        Me.Num_TelefoneLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Num_TelefoneLabel.Location = New System.Drawing.Point(425, 252)
        Me.Num_TelefoneLabel.Name = "Num_TelefoneLabel"
        Me.Num_TelefoneLabel.Size = New System.Drawing.Size(141, 25)
        Me.Num_TelefoneLabel.TabIndex = 10
        Me.Num_TelefoneLabel.Text = "Num Telefone:"
        '
        'Num_TelemovelLabel
        '
        Me.Num_TelemovelLabel.AutoSize = True
        Me.Num_TelemovelLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Num_TelemovelLabel.Location = New System.Drawing.Point(731, 253)
        Me.Num_TelemovelLabel.Name = "Num_TelemovelLabel"
        Me.Num_TelemovelLabel.Size = New System.Drawing.Size(154, 25)
        Me.Num_TelemovelLabel.TabIndex = 10
        Me.Num_TelemovelLabel.Text = "Num Telemovel:"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.EmailLabel.Location = New System.Drawing.Point(502, 304)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(64, 25)
        Me.EmailLabel.TabIndex = 8
        Me.EmailLabel.Text = "Email:"
        '
        'NIFLabel
        '
        Me.NIFLabel.AutoSize = True
        Me.NIFLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.NIFLabel.Location = New System.Drawing.Point(839, 105)
        Me.NIFLabel.Name = "NIFLabel"
        Me.NIFLabel.Size = New System.Drawing.Size(48, 25)
        Me.NIFLabel.TabIndex = 12
        Me.NIFLabel.Text = "NIF:"
        '
        'PaisLabel
        '
        Me.PaisLabel.AutoSize = True
        Me.PaisLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.PaisLabel.Location = New System.Drawing.Point(516, 360)
        Me.PaisLabel.Name = "PaisLabel"
        Me.PaisLabel.Size = New System.Drawing.Size(52, 25)
        Me.PaisLabel.TabIndex = 9
        Me.PaisLabel.Text = "Pais:"
        '
        'lblUtilizador
        '
        Me.lblUtilizador.AutoSize = True
        Me.lblUtilizador.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblUtilizador.Location = New System.Drawing.Point(779, 360)
        Me.lblUtilizador.Name = "lblUtilizador"
        Me.lblUtilizador.Size = New System.Drawing.Size(105, 25)
        Me.lblUtilizador.TabIndex = 116
        Me.lblUtilizador.Text = "Utilizador:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(382, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 25)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "Num Utente Saude:"
        '
        'lblCod_Especialidade
        '
        Me.lblCod_Especialidade.AutoSize = True
        Me.lblCod_Especialidade.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblCod_Especialidade.Location = New System.Drawing.Point(393, 410)
        Me.lblCod_Especialidade.Name = "lblCod_Especialidade"
        Me.lblCod_Especialidade.Size = New System.Drawing.Size(176, 25)
        Me.lblCod_Especialidade.TabIndex = 124
        Me.lblCod_Especialidade.Text = "Cod Especialidade:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(758, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 25)
        Me.Label4.TabIndex = 127
        Me.Label4.Text = "Data Registo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(441, 449)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 25)
        Me.Label5.TabIndex = 130
        Me.Label5.Text = "FLG_Ativo:"
        '
        'lblPalavra_Passe
        '
        Me.lblPalavra_Passe.AutoSize = True
        Me.lblPalavra_Passe.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblPalavra_Passe.Location = New System.Drawing.Point(752, 413)
        Me.lblPalavra_Passe.Name = "lblPalavra_Passe"
        Me.lblPalavra_Passe.Size = New System.Drawing.Size(135, 25)
        Me.lblPalavra_Passe.TabIndex = 135
        Me.lblPalavra_Passe.Text = "Palavra Passe:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Lista_EnderecosUltraGrid)
        Me.Panel1.Controls.Add(Me.Data_RegistoDE)
        Me.Panel1.Controls.Add(Me.FLG_AtivoCheckEdit)
        Me.Panel1.Controls.Add(Me.TeFotografia)
        Me.Panel1.Controls.Add(Me.btnApaga)
        Me.Panel1.Controls.Add(Me.btnCarrega)
        Me.Panel1.Controls.Add(Me.ucCod_Especialidade)
        Me.Panel1.Controls.Add(Me.Cod_PaisTextEdit)
        Me.Panel1.Controls.Add(Me.FLG_EntidadeTextEdit)
        Me.Panel1.Controls.Add(Me.tePasse)
        Me.Panel1.Controls.Add(Me.lblPalavra_Passe)
        Me.Panel1.Controls.Add(Me.teCod_Especialidade)
        Me.Panel1.Controls.Add(Me.teUtilizador)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblCod_Especialidade)
        Me.Panel1.Controls.Add(Me.teNum_UtenteSaude)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblUtilizador)
        Me.Panel1.Controls.Add(Me.ucPaises)
        Me.Panel1.Controls.Add(Me.PaisTextEdit)
        Me.Panel1.Controls.Add(Me.teNIF)
        Me.Panel1.Controls.Add(Me.teEmail)
        Me.Panel1.Controls.Add(Me.teNome_Completo)
        Me.Panel1.Controls.Add(Me.pbEntidades_Imagem)
        Me.Panel1.Controls.Add(Me.BtnListaEnderecos)
        Me.Panel1.Controls.Add(Me.cbEntidades)
        Me.Panel1.Controls.Add(Me.PaisLabel)
        Me.Panel1.Controls.Add(Me.NIFLabel)
        Me.Panel1.Controls.Add(Me.EmailLabel)
        Me.Panel1.Controls.Add(Me.Num_TelemovelLabel)
        Me.Panel1.Controls.Add(Me.teNum_Telemovel)
        Me.Panel1.Controls.Add(Me.Num_TelefoneLabel)
        Me.Panel1.Controls.Add(Me.teNum_Telefone)
        Me.Panel1.Controls.Add(Me.NomeLabel)
        Me.Panel1.Controls.Add(Me.Cod_EntidadeLabel)
        Me.Panel1.Controls.Add(Me.Cod_EntidadeTextEdit)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.PictureBox7)
        Me.Panel1.Controls.Add(Me.PictureBox8)
        Me.Panel1.Controls.Add(Me.PictureBox9)
        Me.Panel1.Controls.Add(Me.PictureBox10)
        Me.Panel1.Controls.Add(Me.PictureBox11)
        Me.Panel1.Controls.Add(Me.PictureBox12)
        Me.Panel1.Controls.Add(Me.PictureBox13)
        Me.Panel1.Controls.Add(Me.PictureBox14)
        Me.Panel1.Controls.Add(Me.picCod_Especialidade)
        Me.Panel1.Location = New System.Drawing.Point(12, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1244, 782)
        Me.Panel1.TabIndex = 1
        '
        'Lista_EnderecosUltraGrid
        '
        Me.Lista_EnderecosUltraGrid.ContextMenuStrip = Me.cmAPAGA
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 53
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "Cod"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 40
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 151
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.Caption = "Endereço"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 236
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.Caption = "CP"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 48
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Width = 236
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8})
        Me.Lista_EnderecosUltraGrid.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.Lista_EnderecosUltraGrid.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.Lista_EnderecosUltraGrid.DisplayLayout.GroupByBox.Hidden = True
        Me.Lista_EnderecosUltraGrid.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.Lista_EnderecosUltraGrid.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.Lista_EnderecosUltraGrid.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.Lista_EnderecosUltraGrid.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.Lista_EnderecosUltraGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lista_EnderecosUltraGrid.Location = New System.Drawing.Point(95, 503)
        Me.Lista_EnderecosUltraGrid.Name = "Lista_EnderecosUltraGrid"
        Me.Lista_EnderecosUltraGrid.Size = New System.Drawing.Size(749, 276)
        Me.Lista_EnderecosUltraGrid.TabIndex = 269
        Me.Lista_EnderecosUltraGrid.Text = "Lista de Endereços da Entidade"
        Me.Lista_EnderecosUltraGrid.Visible = False
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
        'Data_RegistoDE
        '
        Me.Data_RegistoDE.EditValue = Nothing
        Me.Data_RegistoDE.Location = New System.Drawing.Point(891, 203)
        Me.Data_RegistoDE.Name = "Data_RegistoDE"
        Me.Data_RegistoDE.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Data_RegistoDE.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Data_RegistoDE.Properties.Appearance.Options.UseBackColor = True
        Me.Data_RegistoDE.Properties.Appearance.Options.UseFont = True
        Me.Data_RegistoDE.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Data_RegistoDE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Data_RegistoDE.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Data_RegistoDE.Size = New System.Drawing.Size(179, 30)
        Me.Data_RegistoDE.TabIndex = 267
        '
        'FLG_AtivoCheckEdit
        '
        Me.FLG_AtivoCheckEdit.Location = New System.Drawing.Point(553, 454)
        Me.FLG_AtivoCheckEdit.Name = "FLG_AtivoCheckEdit"
        Me.FLG_AtivoCheckEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.FLG_AtivoCheckEdit.Properties.Appearance.Options.UseFont = True
        Me.FLG_AtivoCheckEdit.Properties.Caption = ""
        Me.FLG_AtivoCheckEdit.Size = New System.Drawing.Size(75, 20)
        Me.FLG_AtivoCheckEdit.TabIndex = 266
        '
        'TeFotografia
        '
        Me.TeFotografia.Location = New System.Drawing.Point(64, 233)
        Me.TeFotografia.Name = "TeFotografia"
        Me.TeFotografia.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TeFotografia.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.TeFotografia.Properties.Appearance.Options.UseBackColor = True
        Me.TeFotografia.Properties.Appearance.Options.UseFont = True
        Me.TeFotografia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TeFotografia.Size = New System.Drawing.Size(276, 30)
        Me.TeFotografia.TabIndex = 144
        '
        'btnApaga
        '
        Me.btnApaga.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnApaga.Location = New System.Drawing.Point(203, 274)
        Me.btnApaga.Name = "btnApaga"
        Me.btnApaga.Size = New System.Drawing.Size(110, 84)
        Me.btnApaga.TabIndex = 143
        Me.btnApaga.Text = "Apagar Imagem"
        Me.btnApaga.UseVisualStyleBackColor = True
        '
        'btnCarrega
        '
        Me.btnCarrega.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnCarrega.Location = New System.Drawing.Point(84, 274)
        Me.btnCarrega.Name = "btnCarrega"
        Me.btnCarrega.Size = New System.Drawing.Size(110, 84)
        Me.btnCarrega.TabIndex = 142
        Me.btnCarrega.Text = "Carregar Imagem"
        Me.btnCarrega.UseVisualStyleBackColor = True
        '
        'ucCod_Especialidade
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucCod_Especialidade.DisplayLayout.Appearance = Appearance1
        Me.ucCod_Especialidade.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucCod_Especialidade.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.ucCod_Especialidade.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucCod_Especialidade.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.ucCod_Especialidade.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucCod_Especialidade.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.ucCod_Especialidade.DisplayLayout.MaxColScrollRegions = 1
        Me.ucCod_Especialidade.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucCod_Especialidade.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ucCod_Especialidade.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.ucCod_Especialidade.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucCod_Especialidade.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.ucCod_Especialidade.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ucCod_Especialidade.DisplayLayout.Override.CellAppearance = Appearance8
        Me.ucCod_Especialidade.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucCod_Especialidade.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.ucCod_Especialidade.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.ucCod_Especialidade.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.ucCod_Especialidade.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucCod_Especialidade.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.ucCod_Especialidade.DisplayLayout.Override.RowAppearance = Appearance11
        Me.ucCod_Especialidade.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ucCod_Especialidade.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.ucCod_Especialidade.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucCod_Especialidade.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucCod_Especialidade.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ucCod_Especialidade.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ucCod_Especialidade.Location = New System.Drawing.Point(572, 404)
        Me.ucCod_Especialidade.Name = "ucCod_Especialidade"
        Me.ucCod_Especialidade.Size = New System.Drawing.Size(153, 36)
        Me.ucCod_Especialidade.TabIndex = 141
        '
        'Cod_PaisTextEdit
        '
        Me.Cod_PaisTextEdit.Location = New System.Drawing.Point(807, 3)
        Me.Cod_PaisTextEdit.Name = "Cod_PaisTextEdit"
        Me.Cod_PaisTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Cod_PaisTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cod_PaisTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Cod_PaisTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Cod_PaisTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Cod_PaisTextEdit.Size = New System.Drawing.Size(75, 24)
        Me.Cod_PaisTextEdit.TabIndex = 140
        Me.Cod_PaisTextEdit.Visible = False
        '
        'FLG_EntidadeTextEdit
        '
        Me.FLG_EntidadeTextEdit.Location = New System.Drawing.Point(801, 52)
        Me.FLG_EntidadeTextEdit.Name = "FLG_EntidadeTextEdit"
        Me.FLG_EntidadeTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.FLG_EntidadeTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.FLG_EntidadeTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.FLG_EntidadeTextEdit.Properties.Appearance.Options.UseFont = True
        Me.FLG_EntidadeTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.FLG_EntidadeTextEdit.Size = New System.Drawing.Size(75, 30)
        Me.FLG_EntidadeTextEdit.TabIndex = 139
        Me.FLG_EntidadeTextEdit.Visible = False
        '
        'tePasse
        '
        Me.tePasse.Location = New System.Drawing.Point(893, 410)
        Me.tePasse.Name = "tePasse"
        Me.tePasse.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.tePasse.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.tePasse.Properties.Appearance.Options.UseBackColor = True
        Me.tePasse.Properties.Appearance.Options.UseFont = True
        Me.tePasse.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.tePasse.Size = New System.Drawing.Size(169, 30)
        Me.tePasse.TabIndex = 137
        '
        'teCod_Especialidade
        '
        Me.teCod_Especialidade.Location = New System.Drawing.Point(580, 408)
        Me.teCod_Especialidade.Name = "teCod_Especialidade"
        Me.teCod_Especialidade.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.teCod_Especialidade.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.teCod_Especialidade.Properties.Appearance.Options.UseBackColor = True
        Me.teCod_Especialidade.Properties.Appearance.Options.UseFont = True
        Me.teCod_Especialidade.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.teCod_Especialidade.Size = New System.Drawing.Size(128, 30)
        Me.teCod_Especialidade.TabIndex = 134
        '
        'teUtilizador
        '
        Me.teUtilizador.Location = New System.Drawing.Point(895, 355)
        Me.teUtilizador.Name = "teUtilizador"
        Me.teUtilizador.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.teUtilizador.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.teUtilizador.Properties.Appearance.Options.UseBackColor = True
        Me.teUtilizador.Properties.Appearance.Options.UseFont = True
        Me.teUtilizador.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.teUtilizador.Properties.ReadOnly = True
        Me.teUtilizador.Size = New System.Drawing.Size(167, 30)
        Me.teUtilizador.TabIndex = 132
        '
        'teNum_UtenteSaude
        '
        Me.teNum_UtenteSaude.Location = New System.Drawing.Point(578, 204)
        Me.teNum_UtenteSaude.Name = "teNum_UtenteSaude"
        Me.teNum_UtenteSaude.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.teNum_UtenteSaude.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.teNum_UtenteSaude.Properties.Appearance.Options.UseBackColor = True
        Me.teNum_UtenteSaude.Properties.Appearance.Options.UseFont = True
        Me.teNum_UtenteSaude.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.teNum_UtenteSaude.Size = New System.Drawing.Size(139, 30)
        Me.teNum_UtenteSaude.TabIndex = 121
        '
        'ucPaises
        '
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucPaises.DisplayLayout.Appearance = Appearance13
        Me.ucPaises.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucPaises.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance14.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        Me.ucPaises.DisplayLayout.GroupByBox.Appearance = Appearance14
        Appearance15.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucPaises.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance15
        Me.ucPaises.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance16.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance16.BackColor2 = System.Drawing.SystemColors.Control
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucPaises.DisplayLayout.GroupByBox.PromptAppearance = Appearance16
        Me.ucPaises.DisplayLayout.MaxColScrollRegions = 1
        Me.ucPaises.DisplayLayout.MaxRowScrollRegions = 1
        Appearance17.BackColor = System.Drawing.SystemColors.Window
        Appearance17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucPaises.DisplayLayout.Override.ActiveCellAppearance = Appearance17
        Appearance18.BackColor = System.Drawing.SystemColors.Highlight
        Appearance18.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ucPaises.DisplayLayout.Override.ActiveRowAppearance = Appearance18
        Me.ucPaises.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucPaises.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Me.ucPaises.DisplayLayout.Override.CardAreaAppearance = Appearance19
        Appearance20.BorderColor = System.Drawing.Color.Silver
        Appearance20.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ucPaises.DisplayLayout.Override.CellAppearance = Appearance20
        Me.ucPaises.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucPaises.DisplayLayout.Override.CellPadding = 0
        Appearance21.BackColor = System.Drawing.SystemColors.Control
        Appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance21.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance21.BorderColor = System.Drawing.SystemColors.Window
        Me.ucPaises.DisplayLayout.Override.GroupByRowAppearance = Appearance21
        Appearance22.TextHAlignAsString = "Left"
        Me.ucPaises.DisplayLayout.Override.HeaderAppearance = Appearance22
        Me.ucPaises.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucPaises.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Appearance23.BorderColor = System.Drawing.Color.Silver
        Me.ucPaises.DisplayLayout.Override.RowAppearance = Appearance23
        Me.ucPaises.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance24.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ucPaises.DisplayLayout.Override.TemplateAddRowAppearance = Appearance24
        Me.ucPaises.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucPaises.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucPaises.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ucPaises.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ucPaises.Location = New System.Drawing.Point(572, 351)
        Me.ucPaises.Name = "ucPaises"
        Me.ucPaises.Size = New System.Drawing.Size(152, 36)
        Me.ucPaises.TabIndex = 5
        '
        'PaisTextEdit
        '
        Me.PaisTextEdit.Location = New System.Drawing.Point(581, 356)
        Me.PaisTextEdit.Name = "PaisTextEdit"
        Me.PaisTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.PaisTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.PaisTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.PaisTextEdit.Properties.Appearance.Options.UseFont = True
        Me.PaisTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PaisTextEdit.Size = New System.Drawing.Size(136, 30)
        Me.PaisTextEdit.TabIndex = 18
        '
        'teNIF
        '
        Me.teNIF.EditValue = ""
        Me.teNIF.Location = New System.Drawing.Point(897, 104)
        Me.teNIF.Name = "teNIF"
        Me.teNIF.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.teNIF.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.teNIF.Properties.Appearance.Options.UseBackColor = True
        Me.teNIF.Properties.Appearance.Options.UseFont = True
        Me.teNIF.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.teNIF.Size = New System.Drawing.Size(150, 30)
        Me.teNIF.TabIndex = 1
        '
        'teEmail
        '
        Me.teEmail.Location = New System.Drawing.Point(581, 302)
        Me.teEmail.Name = "teEmail"
        Me.teEmail.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.teEmail.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.teEmail.Properties.Appearance.Options.UseBackColor = True
        Me.teEmail.Properties.Appearance.Options.UseFont = True
        Me.teEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.teEmail.Size = New System.Drawing.Size(476, 30)
        Me.teEmail.TabIndex = 4
        '
        'teNome_Completo
        '
        Me.teNome_Completo.Location = New System.Drawing.Point(581, 154)
        Me.teNome_Completo.Name = "teNome_Completo"
        Me.teNome_Completo.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.teNome_Completo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.teNome_Completo.Properties.Appearance.Options.UseBackColor = True
        Me.teNome_Completo.Properties.Appearance.Options.UseFont = True
        Me.teNome_Completo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.teNome_Completo.Size = New System.Drawing.Size(476, 30)
        Me.teNome_Completo.TabIndex = 0
        '
        'pbEntidades_Imagem
        '
        Me.pbEntidades_Imagem.BackColor = System.Drawing.Color.White
        Me.pbEntidades_Imagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbEntidades_Imagem.Image = Global.PAP_G2_BFFPclinic_01_Diogo.My.Resources.Resources.no_img
        Me.pbEntidades_Imagem.Location = New System.Drawing.Point(84, 12)
        Me.pbEntidades_Imagem.Name = "pbEntidades_Imagem"
        Me.pbEntidades_Imagem.Size = New System.Drawing.Size(229, 207)
        Me.pbEntidades_Imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbEntidades_Imagem.TabIndex = 103
        Me.pbEntidades_Imagem.TabStop = False
        '
        'BtnListaEnderecos
        '
        Me.BtnListaEnderecos.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BtnListaEnderecos.Location = New System.Drawing.Point(112, 374)
        Me.BtnListaEnderecos.Name = "BtnListaEnderecos"
        Me.BtnListaEnderecos.Size = New System.Drawing.Size(178, 100)
        Me.BtnListaEnderecos.TabIndex = 102
        Me.BtnListaEnderecos.Text = "Ver Lista de Endereços"
        Me.BtnListaEnderecos.UseVisualStyleBackColor = True
        '
        'cbEntidades
        '
        Me.cbEntidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbEntidades.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.cbEntidades.FormattingEnabled = True
        Me.cbEntidades.Location = New System.Drawing.Point(577, 100)
        Me.cbEntidades.Name = "cbEntidades"
        Me.cbEntidades.Size = New System.Drawing.Size(133, 33)
        Me.cbEntidades.TabIndex = 99
        Me.cbEntidades.Visible = False
        '
        'teNum_Telemovel
        '
        Me.teNum_Telemovel.Location = New System.Drawing.Point(891, 248)
        Me.teNum_Telemovel.Name = "teNum_Telemovel"
        Me.teNum_Telemovel.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.teNum_Telemovel.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.teNum_Telemovel.Properties.Appearance.Options.UseBackColor = True
        Me.teNum_Telemovel.Properties.Appearance.Options.UseFont = True
        Me.teNum_Telemovel.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.teNum_Telemovel.Size = New System.Drawing.Size(150, 30)
        Me.teNum_Telemovel.TabIndex = 3
        '
        'teNum_Telefone
        '
        Me.teNum_Telefone.Location = New System.Drawing.Point(577, 251)
        Me.teNum_Telefone.Name = "teNum_Telefone"
        Me.teNum_Telefone.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.teNum_Telefone.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.teNum_Telefone.Properties.Appearance.Options.UseBackColor = True
        Me.teNum_Telefone.Properties.Appearance.Options.UseFont = True
        Me.teNum_Telefone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.teNum_Telefone.Size = New System.Drawing.Size(143, 30)
        Me.teNum_Telefone.TabIndex = 2
        '
        'Cod_EntidadeTextEdit
        '
        Me.Cod_EntidadeTextEdit.Location = New System.Drawing.Point(578, 103)
        Me.Cod_EntidadeTextEdit.Name = "Cod_EntidadeTextEdit"
        Me.Cod_EntidadeTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Cod_EntidadeTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Cod_EntidadeTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Cod_EntidadeTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Cod_EntidadeTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Cod_EntidadeTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.Cod_EntidadeTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Cod_EntidadeTextEdit.Size = New System.Drawing.Size(130, 30)
        Me.Cod_EntidadeTextEdit.TabIndex = 101
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Enabled = False
        Me.PictureBox5.Image = Global.PAP_G2_BFFPclinic_01_Diogo.My.Resources.Resources.Shade2
        Me.PictureBox5.Location = New System.Drawing.Point(890, 408)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(182, 34)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 270
        Me.PictureBox5.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Enabled = False
        Me.PictureBox2.Image = Global.PAP_G2_BFFPclinic_01_Diogo.My.Resources.Resources.Shade2
        Me.PictureBox2.Location = New System.Drawing.Point(572, 298)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(500, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 272
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = Global.PAP_G2_BFFPclinic_01_Diogo.My.Resources.Resources.Shade2
        Me.PictureBox1.Location = New System.Drawing.Point(890, 353)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 271
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Enabled = False
        Me.PictureBox3.Image = Global.PAP_G2_BFFPclinic_01_Diogo.My.Resources.Resources.Shade2
        Me.PictureBox3.Location = New System.Drawing.Point(887, 246)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(185, 34)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 273
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Enabled = False
        Me.PictureBox4.Image = Global.PAP_G2_BFFPclinic_01_Diogo.My.Resources.Resources.Shade2
        Me.PictureBox4.Location = New System.Drawing.Point(572, 150)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(500, 39)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 274
        Me.PictureBox4.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Enabled = False
        Me.PictureBox6.Image = Global.PAP_G2_BFFPclinic_01_Diogo.My.Resources.Resources.Shade2
        Me.PictureBox6.Location = New System.Drawing.Point(572, 250)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(153, 34)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 275
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Enabled = False
        Me.PictureBox7.Image = Global.PAP_G2_BFFPclinic_01_Diogo.My.Resources.Resources.Shade2
        Me.PictureBox7.Location = New System.Drawing.Point(572, 202)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(153, 34)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 276
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.Enabled = False
        Me.PictureBox8.Image = Global.PAP_G2_BFFPclinic_01_Diogo.My.Resources.Resources.Shade2
        Me.PictureBox8.Location = New System.Drawing.Point(572, 354)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(148, 33)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 277
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.Enabled = False
        Me.PictureBox9.Image = Global.PAP_G2_BFFPclinic_01_Diogo.My.Resources.Resources.Shade2
        Me.PictureBox9.Location = New System.Drawing.Point(891, 97)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(181, 39)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 278
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.Enabled = False
        Me.PictureBox10.Image = Global.PAP_G2_BFFPclinic_01_Diogo.My.Resources.Resources.Shade2
        Me.PictureBox10.Location = New System.Drawing.Point(57, 229)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(289, 38)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 279
        Me.PictureBox10.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox11.Enabled = False
        Me.PictureBox11.Image = Global.PAP_G2_BFFPclinic_01_Diogo.My.Resources.Resources.Shade2
        Me.PictureBox11.Location = New System.Drawing.Point(763, -1)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(152, 35)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 280
        Me.PictureBox11.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox12.Enabled = False
        Me.PictureBox12.Image = Global.PAP_G2_BFFPclinic_01_Diogo.My.Resources.Resources.Shade2
        Me.PictureBox12.Location = New System.Drawing.Point(763, 50)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(152, 35)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 281
        Me.PictureBox12.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox13.Enabled = False
        Me.PictureBox13.Image = Global.PAP_G2_BFFPclinic_01_Diogo.My.Resources.Resources.Shade2
        Me.PictureBox13.Location = New System.Drawing.Point(572, 96)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(149, 39)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox13.TabIndex = 282
        Me.PictureBox13.TabStop = False
        '
        'PictureBox14
        '
        Me.PictureBox14.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox14.Enabled = False
        Me.PictureBox14.Image = Global.PAP_G2_BFFPclinic_01_Diogo.My.Resources.Resources.Shade2
        Me.PictureBox14.Location = New System.Drawing.Point(888, 200)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(184, 36)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox14.TabIndex = 283
        Me.PictureBox14.TabStop = False
        '
        'picCod_Especialidade
        '
        Me.picCod_Especialidade.BackColor = System.Drawing.Color.Transparent
        Me.picCod_Especialidade.Enabled = False
        Me.picCod_Especialidade.Image = Global.PAP_G2_BFFPclinic_01_Diogo.My.Resources.Resources.Shade2
        Me.picCod_Especialidade.Location = New System.Drawing.Point(572, 406)
        Me.picCod_Especialidade.Name = "picCod_Especialidade"
        Me.picCod_Especialidade.Size = New System.Drawing.Size(148, 32)
        Me.picCod_Especialidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCod_Especialidade.TabIndex = 284
        Me.picCod_Especialidade.TabStop = False
        '
        'OFDEntidades
        '
        Me.OFDEntidades.FileName = "OpenFileDialog1"
        '
        'TimerLoad_Lista_Enderecos
        '
        Me.TimerLoad_Lista_Enderecos.Interval = 1000
        '
        'UC_NAV11
        '
        Me.UC_NAV11.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.UC_NAV11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_NAV11.Location = New System.Drawing.Point(0, 0)
        Me.UC_NAV11.mFRM = Nothing
        Me.UC_NAV11.Name = "UC_NAV11"
        Me.UC_NAV11.Size = New System.Drawing.Size(1268, 855)
        Me.UC_NAV11.TabIndex = 0
        '
        'frmEntidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1268, 855)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UC_NAV11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEntidades"
        Me.Text = "frmEntidades"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Lista_EnderecosUltraGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmAPAGA.ResumeLayout(False)
        CType(Me.Data_RegistoDE.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_RegistoDE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLG_AtivoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeFotografia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucCod_Especialidade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_PaisTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLG_EntidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tePasse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teCod_Especialidade.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teUtilizador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNum_UtenteSaude.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucPaises, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaisTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNIF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNome_Completo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEntidades_Imagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNum_Telemovel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNum_Telefone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_EntidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCod_Especialidade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UC_NAV11 As UC_NAV1
    Friend WithEvents Panel1 As Panel
    Friend WithEvents teNIF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teNum_Telemovel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teNum_Telefone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cod_EntidadeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PaisTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ucPaises As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbEntidades As ComboBox
    Friend WithEvents cmAPAGA As ContextMenuStrip
    Friend WithEvents tsCriar As ToolStripMenuItem
    Friend WithEvents tsModificar As ToolStripMenuItem
    Friend WithEvents tsApagar As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BtnListaEnderecos As Button
    Friend WithEvents pbEntidades_Imagem As PictureBox
    Friend WithEvents teNum_UtenteSaude As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teUtilizador As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teCod_Especialidade As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tePasse As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cod_PaisTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FLG_EntidadeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teNome_Completo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cod_EntidadeLabel As Label
    Friend WithEvents NomeLabel As Label
    Friend WithEvents Num_TelefoneLabel As Label
    Friend WithEvents Num_TelemovelLabel As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents NIFLabel As Label
    Friend WithEvents PaisLabel As Label
    Friend WithEvents lblUtilizador As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCod_Especialidade As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPalavra_Passe As Label
    Friend WithEvents ucCod_Especialidade As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents btnApaga As Button
    Friend WithEvents btnCarrega As Button
    Friend WithEvents TeFotografia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OFDEntidades As OpenFileDialog
    Friend WithEvents FLG_AtivoCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Data_RegistoDE As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Lista_EnderecosUltraGrid As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents TimerLoad_Lista_Enderecos As Timer
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents picCod_Especialidade As PictureBox
End Class
