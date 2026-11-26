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
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Entidade")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Endereco")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descritivo")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Endereco")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Postal")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Localidade")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Data_Registo")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
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
        Me.LblFLG_Ativo = New System.Windows.Forms.Label()
        Me.lblPalavra_Passe = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OlhoA_PictureBox = New System.Windows.Forms.PictureBox()
        Me.OlhoF_PictureBox = New System.Windows.Forms.PictureBox()
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
        Me.picPasse = New System.Windows.Forms.PictureBox()
        Me.picEmail = New System.Windows.Forms.PictureBox()
        Me.PicUser = New System.Windows.Forms.PictureBox()
        Me.picNum_Telemovel = New System.Windows.Forms.PictureBox()
        Me.picNome_Completo = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.picNIF = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.picCod_Entidade = New System.Windows.Forms.PictureBox()
        Me.picData_Registo = New System.Windows.Forms.PictureBox()
        Me.picCod_Especialidade = New System.Windows.Forms.PictureBox()
        Me.OFDEntidades = New System.Windows.Forms.OpenFileDialog()
        Me.TimerLoad_Lista_Enderecos = New System.Windows.Forms.Timer(Me.components)
        Me.UC_NAV11 = New PAP_G2_BFFPclinic_01_Rafael.UC_NAV1()
        Me.Panel1.SuspendLayout()
        CType(Me.OlhoA_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OlhoF_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.picPasse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNum_Telemovel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNome_Completo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNIF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCod_Entidade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picData_Registo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'LblFLG_Ativo
        '
        Me.LblFLG_Ativo.AutoSize = True
        Me.LblFLG_Ativo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.LblFLG_Ativo.Location = New System.Drawing.Point(441, 449)
        Me.LblFLG_Ativo.Name = "LblFLG_Ativo"
        Me.LblFLG_Ativo.Size = New System.Drawing.Size(106, 25)
        Me.LblFLG_Ativo.TabIndex = 130
        Me.LblFLG_Ativo.Text = "FLG_Ativo:"
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
        Me.Panel1.Controls.Add(Me.OlhoA_PictureBox)
        Me.Panel1.Controls.Add(Me.OlhoF_PictureBox)
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
        Me.Panel1.Controls.Add(Me.LblFLG_Ativo)
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
        Me.Panel1.Controls.Add(Me.picPasse)
        Me.Panel1.Controls.Add(Me.picEmail)
        Me.Panel1.Controls.Add(Me.PicUser)
        Me.Panel1.Controls.Add(Me.picNum_Telemovel)
        Me.Panel1.Controls.Add(Me.picNome_Completo)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.PictureBox7)
        Me.Panel1.Controls.Add(Me.PictureBox8)
        Me.Panel1.Controls.Add(Me.picNIF)
        Me.Panel1.Controls.Add(Me.PictureBox10)
        Me.Panel1.Controls.Add(Me.picCod_Entidade)
        Me.Panel1.Controls.Add(Me.picData_Registo)
        Me.Panel1.Controls.Add(Me.picCod_Especialidade)
        Me.Panel1.Location = New System.Drawing.Point(12, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1244, 782)
        Me.Panel1.TabIndex = 1
        '
        'OlhoA_PictureBox
        '
        Me.OlhoA_PictureBox.BackColor = System.Drawing.Color.White
        Me.OlhoA_PictureBox.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.OlhoA
        Me.OlhoA_PictureBox.Location = New System.Drawing.Point(1041, 416)
        Me.OlhoA_PictureBox.Name = "OlhoA_PictureBox"
        Me.OlhoA_PictureBox.Size = New System.Drawing.Size(25, 21)
        Me.OlhoA_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.OlhoA_PictureBox.TabIndex = 285
        Me.OlhoA_PictureBox.TabStop = False
        '
        'OlhoF_PictureBox
        '
        Me.OlhoF_PictureBox.BackColor = System.Drawing.Color.White
        Me.OlhoF_PictureBox.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.OlhoF
        Me.OlhoF_PictureBox.Location = New System.Drawing.Point(1041, 416)
        Me.OlhoF_PictureBox.Name = "OlhoF_PictureBox"
        Me.OlhoF_PictureBox.Size = New System.Drawing.Size(25, 21)
        Me.OlhoF_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.OlhoF_PictureBox.TabIndex = 286
        Me.OlhoF_PictureBox.TabStop = False
        '
        'Lista_EnderecosUltraGrid
        '
        Me.Lista_EnderecosUltraGrid.ContextMenuStrip = Me.cmAPAGA
        UltraGridColumn17.Header.VisiblePosition = 0
        UltraGridColumn17.Hidden = True
        UltraGridColumn17.Width = 53
        UltraGridColumn18.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn18.Header.Caption = "Cod"
        UltraGridColumn18.Header.VisiblePosition = 1
        UltraGridColumn18.Width = 40
        UltraGridColumn19.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn19.Header.VisiblePosition = 2
        UltraGridColumn19.Width = 151
        UltraGridColumn20.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn20.Header.Caption = "Endereço"
        UltraGridColumn20.Header.VisiblePosition = 3
        UltraGridColumn20.Width = 236
        UltraGridColumn21.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn21.Header.Caption = "CP"
        UltraGridColumn21.Header.VisiblePosition = 4
        UltraGridColumn21.Width = 48
        UltraGridColumn22.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn22.Header.VisiblePosition = 5
        UltraGridColumn22.Width = 236
        UltraGridColumn23.Header.VisiblePosition = 6
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.VisiblePosition = 7
        UltraGridColumn24.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24})
        Me.Lista_EnderecosUltraGrid.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.Lista_EnderecosUltraGrid.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.Lista_EnderecosUltraGrid.DisplayLayout.GroupByBox.Hidden = True
        Me.Lista_EnderecosUltraGrid.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.Lista_EnderecosUltraGrid.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.Lista_EnderecosUltraGrid.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.Lista_EnderecosUltraGrid.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.Lista_EnderecosUltraGrid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Lista_EnderecosUltraGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lista_EnderecosUltraGrid.Location = New System.Drawing.Point(0, 483)
        Me.Lista_EnderecosUltraGrid.Name = "Lista_EnderecosUltraGrid"
        Me.Lista_EnderecosUltraGrid.Size = New System.Drawing.Size(1244, 299)
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
        Me.tsCriar.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.add
        Me.tsCriar.Name = "tsCriar"
        Me.tsCriar.Size = New System.Drawing.Size(177, 22)
        Me.tsCriar.Text = "Criar Endereço"
        '
        'tsModificar
        '
        Me.tsModificar.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.document_edit
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
        Me.tsApagar.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.delete
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
        Me.btnApaga.Location = New System.Drawing.Point(204, 280)
        Me.btnApaga.Name = "btnApaga"
        Me.btnApaga.Size = New System.Drawing.Size(110, 84)
        Me.btnApaga.TabIndex = 143
        Me.btnApaga.Text = "Apagar Imagem"
        Me.btnApaga.UseVisualStyleBackColor = True
        '
        'btnCarrega
        '
        Me.btnCarrega.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnCarrega.Location = New System.Drawing.Point(86, 280)
        Me.btnCarrega.Name = "btnCarrega"
        Me.btnCarrega.Size = New System.Drawing.Size(110, 84)
        Me.btnCarrega.TabIndex = 142
        Me.btnCarrega.Text = "Carregar Imagem"
        Me.btnCarrega.UseVisualStyleBackColor = True
        '
        'ucCod_Especialidade
        '
        Me.ucCod_Especialidade.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
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
        Me.ucCod_Especialidade.Location = New System.Drawing.Point(572, 408)
        Me.ucCod_Especialidade.Name = "ucCod_Especialidade"
        Me.ucCod_Especialidade.Size = New System.Drawing.Size(152, 32)
        Me.ucCod_Especialidade.TabIndex = 141
        '
        'Cod_PaisTextEdit
        '
        Me.Cod_PaisTextEdit.Location = New System.Drawing.Point(1166, 3)
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
        Me.FLG_EntidadeTextEdit.Location = New System.Drawing.Point(844, 20)
        Me.FLG_EntidadeTextEdit.Name = "FLG_EntidadeTextEdit"
        Me.FLG_EntidadeTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.FLG_EntidadeTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.FLG_EntidadeTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.FLG_EntidadeTextEdit.Properties.Appearance.Options.UseFont = True
        Me.FLG_EntidadeTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.FLG_EntidadeTextEdit.Size = New System.Drawing.Size(75, 30)
        Me.FLG_EntidadeTextEdit.TabIndex = 139
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
        Me.teCod_Especialidade.Location = New System.Drawing.Point(581, 409)
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
        Me.ucPaises.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.ucPaises.DisplayLayout.AddNewBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucPaises.DisplayLayout.Appearance = Appearance13
        Me.ucPaises.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.ucPaises.DisplayLayout.BorderStyleCaption = Infragistics.Win.UIElementBorderStyle.None
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
        Me.ucPaises.Location = New System.Drawing.Point(572, 353)
        Me.ucPaises.Name = "ucPaises"
        Me.ucPaises.Size = New System.Drawing.Size(152, 32)
        Me.ucPaises.TabIndex = 5
        '
        'PaisTextEdit
        '
        Me.PaisTextEdit.Location = New System.Drawing.Point(575, 356)
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
        Me.pbEntidades_Imagem.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.no_img
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
        Me.cbEntidades.Location = New System.Drawing.Point(578, 100)
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
        'picPasse
        '
        Me.picPasse.BackColor = System.Drawing.Color.Transparent
        Me.picPasse.Enabled = False
        Me.picPasse.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.picPasse.Location = New System.Drawing.Point(890, 408)
        Me.picPasse.Name = "picPasse"
        Me.picPasse.Size = New System.Drawing.Size(182, 34)
        Me.picPasse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPasse.TabIndex = 270
        Me.picPasse.TabStop = False
        '
        'picEmail
        '
        Me.picEmail.BackColor = System.Drawing.Color.Transparent
        Me.picEmail.Enabled = False
        Me.picEmail.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.picEmail.Location = New System.Drawing.Point(572, 298)
        Me.picEmail.Name = "picEmail"
        Me.picEmail.Size = New System.Drawing.Size(500, 39)
        Me.picEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEmail.TabIndex = 272
        Me.picEmail.TabStop = False
        '
        'PicUser
        '
        Me.PicUser.BackColor = System.Drawing.Color.Transparent
        Me.PicUser.Enabled = False
        Me.PicUser.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.PicUser.Location = New System.Drawing.Point(890, 353)
        Me.PicUser.Name = "PicUser"
        Me.PicUser.Size = New System.Drawing.Size(182, 34)
        Me.PicUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicUser.TabIndex = 271
        Me.PicUser.TabStop = False
        '
        'picNum_Telemovel
        '
        Me.picNum_Telemovel.BackColor = System.Drawing.Color.Transparent
        Me.picNum_Telemovel.Enabled = False
        Me.picNum_Telemovel.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.picNum_Telemovel.Location = New System.Drawing.Point(887, 246)
        Me.picNum_Telemovel.Name = "picNum_Telemovel"
        Me.picNum_Telemovel.Size = New System.Drawing.Size(185, 34)
        Me.picNum_Telemovel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picNum_Telemovel.TabIndex = 273
        Me.picNum_Telemovel.TabStop = False
        '
        'picNome_Completo
        '
        Me.picNome_Completo.BackColor = System.Drawing.Color.Transparent
        Me.picNome_Completo.Enabled = False
        Me.picNome_Completo.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.picNome_Completo.Location = New System.Drawing.Point(572, 150)
        Me.picNome_Completo.Name = "picNome_Completo"
        Me.picNome_Completo.Size = New System.Drawing.Size(500, 39)
        Me.picNome_Completo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picNome_Completo.TabIndex = 274
        Me.picNome_Completo.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Enabled = False
        Me.PictureBox6.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
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
        Me.PictureBox7.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
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
        Me.PictureBox8.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.PictureBox8.Location = New System.Drawing.Point(572, 353)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(145, 32)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 277
        Me.PictureBox8.TabStop = False
        '
        'picNIF
        '
        Me.picNIF.BackColor = System.Drawing.Color.Transparent
        Me.picNIF.Enabled = False
        Me.picNIF.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.picNIF.Location = New System.Drawing.Point(891, 97)
        Me.picNIF.Name = "picNIF"
        Me.picNIF.Size = New System.Drawing.Size(181, 39)
        Me.picNIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picNIF.TabIndex = 278
        Me.picNIF.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.Enabled = False
        Me.PictureBox10.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.PictureBox10.Location = New System.Drawing.Point(57, 229)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(289, 38)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 279
        Me.PictureBox10.TabStop = False
        '
        'picCod_Entidade
        '
        Me.picCod_Entidade.BackColor = System.Drawing.Color.Transparent
        Me.picCod_Entidade.Enabled = False
        Me.picCod_Entidade.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.picCod_Entidade.Location = New System.Drawing.Point(572, 96)
        Me.picCod_Entidade.Name = "picCod_Entidade"
        Me.picCod_Entidade.Size = New System.Drawing.Size(149, 39)
        Me.picCod_Entidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCod_Entidade.TabIndex = 282
        Me.picCod_Entidade.TabStop = False
        '
        'picData_Registo
        '
        Me.picData_Registo.BackColor = System.Drawing.Color.Transparent
        Me.picData_Registo.Enabled = False
        Me.picData_Registo.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.picData_Registo.Location = New System.Drawing.Point(888, 200)
        Me.picData_Registo.Name = "picData_Registo"
        Me.picData_Registo.Size = New System.Drawing.Size(184, 36)
        Me.picData_Registo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picData_Registo.TabIndex = 283
        Me.picData_Registo.TabStop = False
        '
        'picCod_Especialidade
        '
        Me.picCod_Especialidade.BackColor = System.Drawing.Color.Transparent
        Me.picCod_Especialidade.Enabled = False
        Me.picCod_Especialidade.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.Shade2
        Me.picCod_Especialidade.Location = New System.Drawing.Point(573, 408)
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
        CType(Me.OlhoA_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OlhoF_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.picPasse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNum_Telemovel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNome_Completo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNIF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCod_Entidade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picData_Registo, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LblFLG_Ativo As Label
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
    Friend WithEvents picPasse As PictureBox
    Friend WithEvents picEmail As PictureBox
    Friend WithEvents PicUser As PictureBox
    Friend WithEvents picNum_Telemovel As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents picNome_Completo As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents picNIF As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents picCod_Entidade As PictureBox
    Friend WithEvents picData_Registo As PictureBox
    Friend WithEvents picCod_Especialidade As PictureBox
    Friend WithEvents OlhoA_PictureBox As PictureBox
    Friend WithEvents OlhoF_PictureBox As PictureBox
End Class
