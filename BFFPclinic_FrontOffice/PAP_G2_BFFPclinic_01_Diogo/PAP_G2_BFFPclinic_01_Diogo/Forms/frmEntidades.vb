

Imports System.ComponentModel
Imports System.IO
Imports DevExpress.CodeParser
Imports DevExpress.Office.Internal
Imports DevExpress.Pdf.Native.BouncyCastle.Asn1.Cms
Imports DevExpress.Utils
Imports DevExpress.XtraScheduler.Drawing
Imports Infragistics.Win.UltraWinGrid
''' <summary>
'''      Classe frmEntidades- Form da Tabela de Entidades
'''      Gerado em 06/01/2023 11:28:24
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class frmEntidades
    Dim mLista As New List(Of ClsEntidades)
    Dim mPathEntidade As String = "N:\000-Grupo02-I21\03-Programas\PAP_G2_BFFPclinic_01_Rafael\PAP_G2_BFFPclinic_01_Rafael\Resources\Imagens\"



    Private Sub frmEntidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mLista = ClsEntidades.GetEntidades

        mNav = New clsNav(mLista.Count)

        cbEntidades.Visible = False


        UC_NAV11.mFRM = Me

        SetupComps(True)
        UC_NAV11.Load_Status()
        UC_NAV11.SetupNav()
        LoadRegistos()

        Me.Text = "Manutenção da Tabela de Entidades"

        '-------------------------------
        'Exemplo de ProgressBar
        '-------------------------------
        'upBar.Maximum = mNav.Max_Registos
        'upBar.Minimum = 1
        'upBar.Value = mNav.RegistoAtual
        '-------------------------------


        '-------------------------------
        'Exemplo de Combo...
        '-------------------------------
        With cbEntidades
            .Items.Add("Cliente")
            '.Items.Add("Fornecedor")
            .Items.Add("Utente")
            '.Items.Add("Medico")
            '.Items.Add("Rececionista")
            '.Items.Add("Administrador")
            .SelectedIndex = 0
        End With


        '-----------------
        'ucPaises
        '-----------------
        ucPaises.DataSource = ClsPaises.GetPaises
        ucPaises.DisplayMember = "Pais"
        ucPaises.ValueMember = "Cod_Pais"

        ' ucCod_Especialidade.DataSource = ClsEspecialidades.GetEspecialidades
        ' ucCod_Especialidade.DisplayMember = "cod_Especialidade"
        ' ucCod_Especialidade.ValueMember = "Cod_Especialidade"


        TimerLoad_Lista_Enderecos.Interval = 1
        TimerLoad_Lista_Enderecos.Start()
        '----------------------------------------------------------------------------------------------
        ' Como se faz um Filtro da Lista de Clientes?
        ' 
        ' A mLista que contém a lista de Entidades
        ' pode ser filtrada através do método
        ' FiltrarEntidades com o parâmetro da ClsEntidade
        ' 
        ' É preciso criar uma variável do tipo ClsEntidades
        ' e chamar o método FiltrarEntidades com esse parâmetro:
        '
        '   Dim mclsFiltro as New clsEntidades with {.Cod_Entidade=txtCod_Entidade.Text, .FLG_Entidade=txtFLG_Entidade.Text}
        '   Dim mListaFiltro = clsEntidades.FiltrarEntidades(mclsFiltro)
        '----------------------------------------------------------------------------------------------

        '-----------------
        'ucPaises
        '-----------------
        'ucPaises.DataSource = clsPaises.GetPaises
        'ucPaises.DisplayMember = "Pais"
        'ucPaises.ValueMember = "Cod_Pais"
        'Resize_Ultra_Grid()
    End Sub


    Sub SetupComps(ByVal pBool As Boolean)
        Me.Cod_EntidadeTextEdit.ReadOnly = True
        'Me.teUtilizador.ReadOnly = True
        Me.cbEntidades.Visible = False
        'Me.teData_Registo.Enabled = False
        If Not pBool Then
            If Me.UC_NAV11.mNovo Then
                Me.cbEntidades.Visible = True
                Me.cbEntidades.Focus()

            Else
                Me.teNome_Completo.Focus()
            End If
        End If

        FLG_EntidadeTextEdit.ReadOnly = pBool

        teNome_Completo.ReadOnly = pBool
        Cod_PaisTextEdit.ReadOnly = pBool

        PaisTextEdit.ReadOnly = True
        Cod_EntidadeTextEdit.ReadOnly = True

        ucPaises.Visible = Not pBool
        'ucCod_Especialidade.Visible = False

        'teCod_Especialidade.ReadOnly = pBool
        ' tePasse.ReadOnly = pBool
        'teUtilizador.ReadOnly = pBool
        teNum_Telefone.ReadOnly = pBool
        teNum_Telemovel.ReadOnly = pBool
        teEmail.ReadOnly = pBool
        teNIF.ReadOnly = pBool
        FLG_AtivoCheckEdit.ReadOnly = pBool
        'teData_Registo.ReadOnly = pBool
        teNum_UtenteSaude.ReadOnly = pBool
        'cbEntidades.Visible = pBool
        'teCod_Especialidade.ReadOnly = pBool
        'lblCod_Especialidade = pBool
        'ucCod_Especialidade.Visible = pBool
        'lblUtilizador.Visible = pBool
        'lblPalavra_Passe.Visible = pBool
        'teUtilizador.ReadOnly = pBool
        'tePasse.ReadOnly = pBool
        Me.btnCarrega.Visible = Not pBool
        Me.btnApaga.Visible = Not pBool
        '------------------------------
        'Exemplo da eventual UltraCmbo 
        '------------------------------
        'Me.PaisUltraCombo.ReadOnly = pBool

    End Sub

    Sub LoadRegistos()
        LimpaTXT()



        If mNav.Registo_Atual > 0 Then
            With mLista(mNav.Registo_Atual - 1)
                FLG_EntidadeTextEdit.Text = .FLG_Entidade
                teNome_Completo.Text = .Nome
                Cod_PaisTextEdit.Text = .Cod_Pais
                teNum_Telefone.Text = .Num_Telefone
                teNum_Telemovel.Text = .Num_Telemovel
                teEmail.Text = .Email
                teNIF.Text = .NIF
                Cod_EntidadeTextEdit.Text = .Cod_Entidade
                teNum_UtenteSaude.Text = .Num_Utente_Saude
                'teCod_Especialidade.Text = .Cod_Especialidade
                'teUtilizador.Text = .Utilizador
                'tePasse.Text = .Palavra_Passe
                Data_RegistoDE.Text = .Data_Registo
                FLG_AtivoCheckEdit.Checked = .FLG_Ativo
                TeFotografia.Text = .Fotografia

                Lista_Enderecos()
                If .Fotografia = "" Then
                    pbEntidades_Imagem.Image = Image.FromFile(mPathEntidade + "Default.png")
                Else
                    Try
                        pbEntidades_Imagem.Image = Image.FromFile(mPathEntidade + .Fotografia)
                    Catch ex As Exception
                        'MsgBox("Imagem não encontrada:" + vbCrLf + "" + vbCrLf + ex.ToString)
                        pbEntidades_Imagem.Image = Image.FromFile(mPathEntidade + "Default.png")
                    End Try

                End If

                'Data_RegistoDateEdit.Text = .Data_Registo
                '-------------------------
                ' Cod_Entidade
                '-------------------------


                Me.PaisTextEdit.Text = .Pais
                Me.ucPaises.Text = .Pais

                Dim mLista_Enderecos As New List(Of ClsEnderecos)
                mLista_Enderecos = .Lista_Enderecos.FindAll(Function(x) x.FLG_Ativo = True)

                'ja se ve Me.Lista_EnderecosUltraGrid.DataSource = mLista_Enderecos
                'Me.Lista_EnderecosUltraGrid.ActiveRow = Nothing

                'ja se ve Me.Lista_EnderecosUltraGrid.Refresh()


                '-------------------------------
                'Exemplo para as Combos...
                '-------------------------------
                'ucPaises.Text = clsPaises.GetPaisbyCod(.Cod_Pais).Pais
            End With
            '-------------------------------
            'upBar.Value = mNav.Registo_Atual
            '-------------------------------

        End If
        'LoadFLG_entidadetextedit()
        'disable_controlsbyFLG_entidade()
    End Sub



    Sub LimpaTXT()

        FLG_EntidadeTextEdit.Text = ""
        teNome_Completo.Text = ""
        Cod_PaisTextEdit.Text = ""
        teNum_Telefone.Text = ""
        teNum_Telemovel.Text = ""
        teEmail.Text = ""
        teNIF.Text = ""
        'Data_RegistoDateEdit.Text = ""
        '-------------------------------
        teNum_UtenteSaude.Text = ""
        TeFotografia.Text = ""
        Cod_EntidadeTextEdit.Text = ""
        'teCod_Especialidade.Text = ""
        Data_RegistoDE.Text = ""
        'teUtilizador.Text = ""
        'tePasse.Text = ""
        FLG_AtivoCheckEdit.Checked = True
        TeFotografia.Text = ""
        PaisTextEdit.Text = ""

    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsEntidades
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mCls
            If pbNovo Then
                '--------------------------------------
                'Método Não criado na CLASSE 
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------

                .Cod_Entidade = ClsEntidades.GetNovoCodigo(FLG_EntidadeTextEdit.Text)

                '--------------------------------------
            Else
                '--------------------------------------
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Entidade = Cod_EntidadeTextEdit.Text

            End If

            Select Case FLG_EntidadeTextEdit.Text

                Case "M"
                    .Utilizador = "Med" + teNome_Completo.Text.Substring(0, 3) + .Cod_Entidade.Substring(1, 4)
                Case "A"
                    .Utilizador = "Adm" + teNome_Completo.Text.Substring(0, 3) + .Cod_Entidade.Substring(1, 4)
                Case "R"
                    .Utilizador = "Rec" + teNome_Completo.Text.Substring(0, 3) + .Cod_Entidade.Substring(1, 4)
                Case "C"
                    .Utilizador = "N/A"
                    .Palavra_Passe = "N/A"
                Case "U"
                    .Utilizador = "N/A"
                    .Palavra_Passe = "N/A"

            End Select

            '----------------------------------
            'Aqui VERIFICAR Todos os CAMPOS
            '  Não tem por ex. o FLG_Ativo...
            '----------------------------------
            .FLG_Entidade = FLG_EntidadeTextEdit.Text
            .Nome = teNome_Completo.Text
            .Cod_Pais = Cod_PaisTextEdit.Text
            .Num_Telefone = teNum_Telefone.Text
            .Num_Telemovel = teNum_Telemovel.Text
            .Email = teEmail.Text
            .NIF = teNIF.Text
            .Data_Registo = Date.Now
            .Cod_Especialidade = "N/A"

            .Num_Utente_Saude = teNum_UtenteSaude.Text
            .Fotografia = TeFotografia.Text
            .FLG_Ativo = FLG_AtivoCheckEdit.Checked

        End With

        If pbNovo Then
            mFLG_Gravou = ClsEntidades.GravaEntidades(mCls)
        Else
            mFLG_Gravou = ClsEntidades.ModificaEntidades(mCls)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV11.mNovo = False
                mLista = ClsEntidades.GetEntidades
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Entidade = mCls.Cod_Entidade) + 1
                LoadRegistos()

                '---------------------------
                'upBar.Maximum = mNav.Max_Registos
                'upBar.Value = mNav.Registo_Atual
            Else
                mLista = ClsEntidades.GetEntidades
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mRegisto_Atual
                LoadRegistos()
            End If
        Else
            MsgBox("Erro na gravação:")
        End If
        ' cbEntidades.Visible = True
        ' teCod_Especialidade.Visible = True
        ' lblCod_Especialidade.Visible = True
        ' ucCod_Especialidade.Visible = True
        ' lblUtilizador.Visible = True
        ' lblPalavra_Passe.Visible = True
        ' teUtilizador.Visible = True
        ' tePasse.Visible = True
        SetupComps(True)
    End Sub


    Sub Apaga_Registo()
        Try
            ClsEntidades.ApagaEntidades(mLista(mNav.Registo_Atual - 1).Cod_Entidade)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsEntidades.GetEntidades
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub


    Private Sub cbEntidades_DropDownClosed(sender As Object, e As EventArgs) Handles cbEntidades.DropDownClosed  ', cbEntidades.SelectedValueChanged
        LoadFLG_entidadetextedit()
        ' disable_controlsbyFLG_entidade()

    End Sub


    'Sub disable_controlsbyFLG_entidade()
    'If cbEntidades.SelectedItem <> "Medico" Or FLG_EntidadeTextEdit.Text <> "M" Then
    'teCod_Especialidade.Visible = False
    'lblCod_Especialidade.Visible = False
    'ucCod_Especialidade.Visible = False
    'ucCod_Especialidade.Text = ""
    'picCod_Especialidade.Visible = False
    ''teCod_Especialidade.Text = ""
    'Else 'cbEntidades.SelectedItem = "Medico" Then

    'teCod_Especialidade.Visible = True
    'lblCod_Especialidade.Visible = True
    'ucCod_Especialidade.Visible = True
    'picCod_Especialidade.Visible = True


    'End If
    'If cbEntidades.SelectedItem <> "Medico" And cbEntidades.SelectedItem <> "Administrador" And cbEntidades.SelectedItem <> "Rececionista" And FLG_EntidadeTextEdit.Text <> "M" And FLG_EntidadeTextEdit.Text <> "A" And FLG_EntidadeTextEdit.Text <> "R" Then
    'lblUtilizador.Visible = False
    'lblPalavra_Passe.Visible = False
    'teUtilizador.Visible = False
    'tePasse.Visible = False
    'PicPass.Visible = False
    'PicUtilizadores.Visible = False
    ''PICS DO UTILIZADOR E PASS SAO FALSE

    'ElseIf FLG_EntidadeTextEdit.Text = "M" Then
    'lblUtilizador.Visible = True
    'lblPalavra_Passe.Visible = True
    'teUtilizador.Visible = True
    'tePasse.Visible = True
    'teCod_Especialidade.Visible = True
    'lblCod_Especialidade.Visible = True
    'PicPass.Visible = True
    'PicUtilizadores.Visible = True
    ''PICS DO UTILIZADOR E PASS SAO True 
    'Else
    'lblUtilizador.Visible = True
    'lblPalavra_Passe.Visible = True
    'teUtilizador.Visible = True
    'tePasse.Visible = True
    'PicPass.Visible = True
    'PicUtilizadores.Visible = True
    ''PICS DO UTILIZADOR E PASS SAO true 

    ''FALTA ATIVAR ISTO NOVAMENTE DEPOIS DE GRAVAR
    'End If
    'End Sub

    Private Sub ucPaises_AfterCloseUp(sender As Object, e As EventArgs) Handles ucPaises.Leave, ucPaises.AfterCloseUp
        If ucPaises.ActiveRow Is Nothing Then
            Me.Cod_PaisTextEdit.Text = "PT"
            Exit Sub
        End If
        Try
            Me.Cod_PaisTextEdit.Text = ucPaises.ActiveRow.Cells("Cod_Pais").Text
        Catch ex As Exception
            Me.Cod_PaisTextEdit.Text = "PT"
        End Try
    End Sub

    'Private Sub ucEspecialidade_AfterCloseUp(sender As Object, e As EventArgs)
    'If ucCod_Especialidade.ActiveRow Is Nothing Then
    'Me.teCod_Especialidade.Text = "N/A"
    'Exit Sub
    'End If
    'Try
    'Me.teCod_Especialidade.Text = ucCod_Especialidade.ActiveRow.Cells("Cod_Especialidade").Text
    'Catch ex As Exception
    'Me.teCod_Especialidade.Text = "N/A"
    'End Try
    'End Sub

    Sub LoadFLG_entidadetextedit() 'Handles cbEntidades.DropDownClosed 'cbEntidades.SelectedValueChanged
        Dim mIndex As Integer = cbEntidades.SelectedIndex

        Select Case mIndex
            Case enCont.Clientes
                FLG_EntidadeTextEdit.Text = "C"
                'Case enCont.Fornecedores
            '    FLG_EntidadeTextEdit.Text = "F"
            Case enCont.utentes
                FLG_EntidadeTextEdit.Text = "U"
                ' Case enCont.Medicos
                '     FLG_EntidadeTextEdit.Text = "M"
                ' Case enCont.Rececionistas
                '     FLG_EntidadeTextEdit.Text = "R"
                ' Case enCont.Administradores
                '     FLG_EntidadeTextEdit.Text = "A"



        End Select
    End Sub

    Private Sub Lista_EnderecosUltraGrid_Click(sender As Object, e As EventArgs) Handles Lista_EnderecosUltraGrid.DoubleClick
        Dim mFrm As New frmEnderecos

        mFrm.rCod_Entidade = mLista(mNav.Registo_Atual - 1).Cod_Entidade

        If Not Lista_EnderecosUltraGrid.ActiveRow.Cells("Descritivo").Text = "" Then
            mFrm.rCod_Endereco = Lista_EnderecosUltraGrid.ActiveRow.Cells("Cod_Endereco").Text
        Else
            mFrm.rNovo = True

            Dim mContador As Integer = (mLista(mNav.Registo_Atual - 1).Contador_Enderecos + 1)

            mFrm.rCod_Endereco = "E" & mContador.ToString("00")
        End If


        mFrm.ShowDialog()
        LoadRegistos()
    End Sub

    Private Sub cmAPAGA_Opening(sender As Object, e As CancelEventArgs) Handles cmAPAGA.Opening
        Dim mBool As Boolean = Lista_EnderecosUltraGrid.ActiveRow.Cells("Descritivo").Text = ""

        tsApagar.Enabled = Not mBool
        tsModificar.Enabled = Not mBool
        tsCriar.Enabled = mBool

    End Sub
    Private Sub tsCriar_Click(sender As Object, e As EventArgs) Handles tsCriar.Click
        ' Criar Endereco
        Dim mFrm As New frmEnderecos

        mFrm.rCod_Entidade = mLista(mNav.Registo_Atual - 1).Cod_Entidade
        mFrm.rNovo = True

        Dim mContador As Integer = (mLista(mNav.Registo_Atual - 1).Contador_Enderecos + 1)

        mFrm.rCod_Endereco = "E" & mContador.ToString("00")

        mFrm.ShowDialog()
        LoadRegistos()
    End Sub

    Private Sub tsModificar_Click(sender As Object, e As EventArgs) Handles tsModificar.Click
        ' Modificar
        Dim mFrm As New frmEnderecos

        mFrm.rCod_Entidade = mLista(mNav.Registo_Atual - 1).Cod_Entidade
        mFrm.rCod_Endereco = Lista_EnderecosUltraGrid.ActiveRow.Cells("Cod_Endereco").Text

        mFrm.ShowDialog()
        LoadRegistos()
        'disable_controlsbyFLG_entidade()

    End Sub

    Sub AskApaga()
        Dim mResult As MsgBoxResult

        mResult = MsgBox("Tem a certeza que quer apagar a Linha?", MsgBoxStyle.YesNo)

        If mResult = MsgBoxResult.Yes Then
            Apagar_Endereco()
        End If

    End Sub

    Sub Apagar_Endereco()
        Dim mCod_Entidade As String = mLista(mNav.Registo_Atual - 1).Cod_Entidade
        Dim mCod_Endereco As String = Lista_EnderecosUltraGrid.ActiveRow.Cells("Cod_Endereco").Text

        Try
            ClsEnderecos.ApagaEnderecos(mCod_Entidade, mCod_Endereco)
        Catch ex As Exception
            MsgBox("Alguma coisa correu mal..." & vbCrLf & ex.ToString)
        End Try
        LoadRegistos()
    End Sub

    Private Sub tsApagar_Click(sender As Object, e As EventArgs) Handles tsApagar.Click
        ' Apagar
        AskApaga()

    End Sub

    Private Sub BtnListaEnderecos_Click(sender As Object, e As EventArgs) Handles BtnListaEnderecos.Click
        Lista_Enderecos()
        If Lista_EnderecosUltraGrid.Visible = False Then
            Lista_EnderecosUltraGrid.Visible = True
        Else
            Lista_EnderecosUltraGrid.Visible = False
        End If
    End Sub
    Sub Lista_Enderecos()

        Dim mLista_Enderecos As New List(Of ClsEnderecos)
        With mLista(mNav.Registo_Atual - 1)
            mLista_Enderecos = .Lista_Enderecos.FindAll(Function(x) x.FLG_Ativo = True)

            Me.Lista_EnderecosUltraGrid.DataSource = mLista_Enderecos
            'Me.Lista_EnderecosUltraGrid.ActiveRow = Nothing

            Me.Lista_EnderecosUltraGrid.Refresh()
        End With
    End Sub

    Private Sub Carregar_Imagem()
        OFDEntidades.Filter = " JPG |*.jpg| PNG | *.png| Todos os Ficheiros| *.*"


        If OFDEntidades.ShowDialog = DialogResult.OK Then

            Dim mCont = 0
            Dim mFileName As String = OFDEntidades.FileName.ToString
            Dim mLen As Integer = Len(mFileName)
            Dim mExt As String = mFileName.Substring(mLen - 4, 4)

            Dim mFileDestino = mPathEntidade + Cod_EntidadeTextEdit.Text + mExt
            TeFotografia.Text = Cod_EntidadeTextEdit.Text + mExt

Cont:
            Try
                File.Copy(OFDEntidades.FileName, mFileDestino, True)

            Catch ex As Exception
                If File.Exists(mFileDestino) Then
                    mCont += 1
                    mFileDestino = mPathEntidade + Cod_EntidadeTextEdit.Text + mCont.ToString("000") + mExt
                    Me.TeFotografia.Text = Cod_EntidadeTextEdit.Text + mCont.ToString("000") + mExt
                    GoTo Cont
                End If
            End Try

            If mCont > 0 Then
                Me.pbEntidades_Imagem.Image.Tag = Cod_EntidadeTextEdit.Text + mCont.ToString("000") + mExt
            Else
                Me.pbEntidades_Imagem.Image.Tag = Cod_EntidadeTextEdit.Text + mExt
            End If
            pbEntidades_Imagem.Image = Image.FromFile(mFileDestino)


        End If

        'TeFotografia.Text = OFDEntidades.FileName
    End Sub


    Private Sub btnCarrega_Click(sender As Object, e As EventArgs) Handles btnCarrega.Click
        Carregar_Imagem()
    End Sub

    Private Sub btnApaga_Click(sender As Object, e As EventArgs) Handles btnApaga.Click
        pbEntidades_Imagem.Image = Nothing
        TeFotografia.Text = ""
    End Sub

    Private Sub BtnCriar_Enderecos_Click(sender As Object, e As EventArgs)
        frmMain.Load_Menu(enMenu.Enderecos)
    End Sub



    Private Sub frmEntidades_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'Resize_Ultra_Grid()
    End Sub

    Sub Resize_Ultra_Grid()
        Dim W_Cod_Enderecos As Integer = Lista_EnderecosUltraGrid.DisplayLayout.Bands(0).Columns("Endereco").Width
        Dim W_Descritivo As Integer = Lista_EnderecosUltraGrid.DisplayLayout.Bands(0).Columns("Descritivo").Width
        Dim W_Localidade As Integer = Lista_EnderecosUltraGrid.DisplayLayout.Bands(0).Columns("Localidade").Width
        Dim W_Cod_Postal As Integer = Lista_EnderecosUltraGrid.DisplayLayout.Bands(0).Columns("Cod_Postal").Width

        Lista_EnderecosUltraGrid.DisplayLayout.Bands(0).Columns("Endereco").Width = Lista_EnderecosUltraGrid.Width - W_Cod_Enderecos - W_Cod_Postal - W_Descritivo - W_Localidade

    End Sub

    Private Sub TimerLoadUgLinhas_Tick(sender As Object, e As EventArgs) Handles TimerLoad_Lista_Enderecos.Tick
        TimerLoad_Lista_Enderecos.Stop()
        Resize_Ultra_Grid()
    End Sub

    Private Sub UC_NAV11_Load(sender As Object, e As EventArgs) Handles UC_NAV11.Load

    End Sub


End Class
