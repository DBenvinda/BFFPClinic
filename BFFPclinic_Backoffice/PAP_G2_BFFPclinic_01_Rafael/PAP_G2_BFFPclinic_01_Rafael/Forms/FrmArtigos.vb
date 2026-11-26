Imports System.Security.Cryptography
Imports DevExpress.Xpo.Metadata
Imports DevExpress.XtraEditors

Public Class FrmArtigos
    Dim mLista As New List(Of ClsArtigos)
    Dim mindex_Especialidades As Integer = 0
    Dim mindex_TM As Integer = 0
    Dim mIndex_IVA As Integer = 0
    Dim mLista_Tipos_Marcacao As New List(Of ClsTipos_Marcacao)
    Dim mLista_Utentes As New List(Of ClsEntidades)
    Dim mLista_Especialidades As New List(Of ClsEspecialidades)
    Dim mLista_IVA As New List(Of ClsIVA)
    Dim mclsArtigo As New ClsArtigos
    Dim mClsMarcacao As New ClsMarcacoes
    Dim mClsIVA As New ClsIVA


    Private Sub frmArtigos_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        mLista = ClsArtigos.GetArtigos
        mNav = New clsNav(mLista.Count)
        getmlistas()
        UC_NAV11.mFRM = Me

        SetupComps(True)
        UC_NAV11.Load_Status()
        UC_NAV11.SetupNav()
        LoadRegistos()

        Me.Text = "Manutenção da Tabela de Artigos"

        With cbPS
            .Items.Add("Produto")
            .Items.Add("Serviço")
            .SelectedIndex = 0
        End With

        With ucMarcacoes
            .DataSource = ClsTipos_Marcacao.GetTipos_Marcacao
            .DisplayLayout.Bands(0).Columns(2).Hidden = True
        End With

        With ucEspecialidades
            .DataSource = ClsEspecialidades.GetEspecialidades()
            .DisplayLayout.Bands(0).Columns(2).Hidden = True

        End With

        With ucIVA
            .DataSource = ClsIVA.GetIVA()
            .DisplayLayout.Bands(0).Columns(1).Hidden = True
            .DisplayLayout.Bands(0).Columns(4).Hidden = True
            .DisplayLayout.Bands(0).Columns(5).Hidden = True
            .DisplayLayout.Bands(0).Columns(6).Hidden = True
            .DisplayLayout.Bands(0).Columns(7).Hidden = True
        End With

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

        '-----------------
        'ucPaises
        '-----------------
        'ucPaises.DataSource = ClsPaises.GetPaises
        'ucPaises.DisplayMember = "Pais"
        'ucPaises.ValueMember = "Cod_Pais"

        '----------------------------------------------------------------------------------------------
        ' Como se faz um Filtro da Lista de Clientes?
        ' 
        ' A mLista que contém a lista de Artigos
        ' pode ser filtrada através do método
        ' FiltrarArtigos com o parâmetro da ClsArtigos
        ' 
        ' É preciso criar uma variável do tipo ClsArtigos
        ' e chamar o método FiltrarArtigos com esse parâmetro:
        '
        '   Dim mclsFiltro as New clsArtigos with {.Cod_Artigo=txtCod_Artigo.Text, .Cod_Categoria=txtCod_Categoria.Text}
        '   Dim mListaFiltro = clsArtigos.FiltrarArtigos(mclsFiltro)
        '----------------------------------------------------------------------------------------------

        '-----------------
        'ucPaises
        '-----------------
        'ucPaises.DataSource = clsPaises.GetPaises
        'ucPaises.DisplayMember = "Pais"
        'ucPaises.ValueMember = "Cod_Pais"

        Loadspin()
    End Sub

    Sub getmlistas()
        mLista_Especialidades = ClsEspecialidades.GetEspecialidades

        mLista_Tipos_Marcacao = ClsTipos_Marcacao.GetTipos_Marcacao

        mLista_IVA = ClsIVA.GetIVA()
    End Sub
    Sub Get_UCS(pNovo As Boolean)
        getmlistas()

        If pNovo Then
            mindex_TM = 0
            mindex_Especialidades = 0
            mIndex_IVA = 0
        Else

            mindex_TM = mLista_Tipos_Marcacao.FindIndex(Function(x) x.Cod_Tipo_Marcacao = mclsArtigo.Cod_Tipo_Marcacao) + 1

            mindex_Especialidades = mLista_Especialidades.FindIndex(Function(x) x.Cod_Especialidade = mclsArtigo.Cod_Especialidade) + 1

            mIndex_IVA = mLista_IVA.FindIndex(Function(x) x.Tipo_IVA = mClsIVA.Tipo_IVA) + 1

        End If

        With Me.ucMarcacoes
            .DataSource = mLista_Tipos_Marcacao
            .DisplayMember = "Cod_Tipo_Marcacao"
            .Rows(mindex_TM).Selected = True
            ucMarcacoes.Value = Cod_TIpo_MarcacaoTextEdit.Text
        End With

        With Me.ucEspecialidades
            .DataSource = mLista_Especialidades
            .DisplayMember = "Cod_Especialidade"
            .Rows(mindex_Especialidades).Selected = True
            ucEspecialidades.Value = Cod_EspecialidadeTextEdit.Text

        End With

        With Me.ucIVA
            .DataSource = mLista_IVA
            .DisplayMember = "Tipo_IVA"
            .Rows(mIndex_IVA).Selected = True
            ucIVA.Value = Tipo_IVATextEdit.Text

        End With
    End Sub
    Sub SetupComps(ByVal pBool As Boolean)
        Me.Cod_ArtigoTextEdit.ReadOnly = True
        Me.TipoMarcacaoTextEdit.ReadOnly = True
        Me.EspecialidadeTextEdit.ReadOnly = True
        cbPS.Visible = False
        If Not pBool Then
            If Me.UC_NAV11.mNovo Then
                'Me.Cod_ArtigoTextEdit.Focus()
                cbPS.Visible = True
                cbPS.Focus()
            Else
                Me.Cod_TIpo_MarcacaoTextEdit.Focus()
            End If
        End If

        ucEspecialidades.Visible = Not pBool
        ucMarcacoes.Visible = Not pBool
        ucIVA.Visible = Not pBool

        Cod_EspecialidadeTextEdit.ReadOnly = pBool
        Cod_TIpo_MarcacaoTextEdit.ReadOnly = pBool
        FLG_Produto_ServicoTextEdit.ReadOnly = pBool
        DesignacaoTextEdit.ReadOnly = pBool
        Tipo_IVATextEdit.ReadOnly = pBool
        Preco_CompraSpinEdit.ReadOnly = pBool
        Preco_VendaSpinEdit.ReadOnly = pBool
        Data_Ultima_EntradaDateEdit.ReadOnly = pBool
        Data_Ultima_VendaDateEdit.ReadOnly = pBool
        Data_RegistoDateEdit.ReadOnly = pBool
        FLG_AtivoCheckEdit.ReadOnly = pBool
        FLG_AtivoCheckEdit.Visible = False
        Data_Ultima_EntradaDateEdit.BackColor = Color.White
        Data_Ultima_VendaDateEdit.BackColor = Color.White
        Preco_CompraSpinEdit.BackColor = Color.White
        Preco_VendaSpinEdit.BackColor = Color.White
        Data_RegistoDateEdit.BackColor = Color.White

        Get_UCS(pBool)
        '------------------------------
        'Exemplo da eventual UltraCmbo 
        '------------------------------
        'Me.PaisUltraCombo.ReadOnly = pBool

    End Sub

    Sub LoadRegistos()
        LimpaTXT()
        If mNav.Registo_Atual > 0 Then
            With mLista(mNav.Registo_Atual - 1)
                Cod_TIpo_MarcacaoTextEdit.Text = .Cod_Tipo_Marcacao
                Cod_EspecialidadeTextEdit.Text = .Cod_Especialidade
                FLG_Produto_ServicoTextEdit.Text = .FLG_Produto_Servico
                DesignacaoTextEdit.Text = .Designacao
                Tipo_IVATextEdit.Text = .Tipo_IVA

                Preco_CompraSpinEdit.Text = .Preco_Compra

                Preco_VendaSpinEdit.Text = .Preco_Venda
                Data_Ultima_EntradaDateEdit.Text = .Data_Ultima_Entrada
                Data_Ultima_VendaDateEdit.Text = .Data_Ultima_Venda
                Data_RegistoDateEdit.Text = .Data_Registo
                FLG_AtivoCheckEdit.Checked = .FLG_Ativo
                EspecialidadeTextEdit.Text = .Especialidade
                TipoMarcacaoTextEdit.Text = .Tipo_Marcacao
                '-------------------------
                ' Cod_Artigo
                '-------------------------
                Cod_ArtigoTextEdit.Text = .Cod_Artigo


                '-------------------------------
                'Exemplo para as Combos...
                '-------------------------------
                'ucPaises.Text = clsPaises.GetPaisbyCod(.Cod_Pais).Pais
            End With
            '-------------------------------
            'upBar.Value = mNav.Registo_Atual
            '-------------------------------

        End If

    End Sub

    Sub LimpaTXT()

        EspecialidadeTextEdit.Text = ""
        TipoMarcacaoTextEdit.Text = ""
        ucEspecialidades.Value = ""
        ucMarcacoes.Value = ""
        ucIVA.Value = ""
        Cod_TIpo_MarcacaoTextEdit.Text = ""
        Cod_EspecialidadeTextEdit.Text = ""
        FLG_Produto_ServicoTextEdit.Text = ""
        DesignacaoTextEdit.Text = ""
        Tipo_IVATextEdit.Text = ""
        Preco_CompraSpinEdit.Text = ""
        Preco_VendaSpinEdit.Text = ""
        Data_Ultima_EntradaDateEdit.Text = ""
        Data_Ultima_VendaDateEdit.Text = ""
        Data_RegistoDateEdit.Text = ""
        TipoMarcacaoTextEdit.Text = ""
        EspecialidadeTextEdit.Text = ""
        '-------------------------------
        Cod_ArtigoTextEdit.Text = ""
        FLG_AtivoCheckEdit.Checked = 1
    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsArtigos
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mCls

            If pbNovo Then
                '--------------------------------------
                'Método Não criado na CLASSE 
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Artigo = ClsArtigos.GetNovoCodigo(FLG_Produto_ServicoTextEdit.Text)
                '--------------------------------------
            Else
                '--------------------------------------
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Artigo = Cod_ArtigoTextEdit.Text
            End If
            '----------------------------------
            'Aqui VERIFICAR Todos os CAMPOS
            '  Não tem por ex. o FLG_Ativo...
            '----------------------------------
            .Cod_Especialidade = Cod_EspecialidadeTextEdit.Text
            .Cod_Tipo_Marcacao = Cod_TIpo_MarcacaoTextEdit.Text
            .FLG_Produto_Servico = FLG_Produto_ServicoTextEdit.Text
            .Designacao = DesignacaoTextEdit.Text
            .Tipo_IVA = Tipo_IVATextEdit.Text
            .Preco_Compra = Preco_CompraSpinEdit.Text
            .Preco_Venda = Preco_VendaSpinEdit.Text

            .Data_Ultima_Entrada = DateTime.Parse(Data_Ultima_EntradaDateEdit.DateTime)
            .Data_Ultima_Venda = DateTime.Parse(Data_Ultima_VendaDateEdit.DateTime)
            .Data_Registo = DateTime.Parse(Data_RegistoDateEdit.DateTime)

            .FLG_Ativo = FLG_AtivoCheckEdit.Checked
        End With

        If pbNovo Then
            mFLG_Gravou = ClsArtigos.GravaArtigos(mCls)
        Else
            mFLG_Gravou = ClsArtigos.ModificaArtigos(mCls)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV11.mNovo = False
                mLista = ClsArtigos.GetArtigos
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Artigo = mCls.Cod_Artigo) + 1
                LoadRegistos()

                '---------------------------
                'upBar.Maximum = mNav.Max_Registos
                'upBar.Value = mNav.Registo_Atual
            Else
                mLista = ClsArtigos.GetArtigos
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mRegisto_Atual
                LoadRegistos()
            End If
        Else
            MsgBox("Erro na gravação:")
        End If
    End Sub


    Sub Apaga_Registo()
        Try
            ClsArtigos.ApagaArtigos(mLista(mNav.Registo_Atual - 1).Cod_Artigo)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsArtigos.GetArtigos
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub

    Private Sub cbEntidades_DropDown(sender As Object, e As EventArgs) Handles cbPS.DropDown, cbPS.Leave
        Dim mIndex As Integer = cbPS.SelectedIndex

        Select Case mIndex
            Case 0
                FLG_Produto_ServicoTextEdit.Text = "P"
            Case 1
                FLG_Produto_ServicoTextEdit.Text = "S"

        End Select
    End Sub

    Private Sub ucEspecialidades_AfterCloseup(sender As Object, e As EventArgs) Handles ucEspecialidades.Leave 'ucEspecialidades.AfterCloseUp
        If ucEspecialidades.Value <> "" Then
            EspecialidadeTextEdit.Text = ucEspecialidades.SelectedRow.Cells("Designacao").Text
            Cod_EspecialidadeTextEdit.Text = ucEspecialidades.SelectedRow.Cells("Cod_Especialidade").Text
        End If
    End Sub



    Private Sub ucMarcacoes_AfterCloseup(sender As Object, e As EventArgs) Handles ucMarcacoes.Leave 'ucMarcacoes.AfterCloseUp

        If ucMarcacoes.Value <> "" Then
            TipoMarcacaoTextEdit.Text = ucMarcacoes.SelectedRow.Cells("Designacao").Text
            Cod_TIpo_MarcacaoTextEdit.Text = ucMarcacoes.SelectedRow.Cells("Cod_Tipo_Marcacao").Text
        End If
    End Sub

    Private Sub ucIVA_AfterCloseup(sender As Object, e As EventArgs) Handles ucIVA.Leave 'ucMarcacoes.AfterCloseUp

        If ucIVA.Value <> "" Then
            Tipo_IVATextEdit.Text = ucIVA.SelectedRow.Cells("Tipo_IVA").Text
        End If
    End Sub

    Private Sub Preco_CompraSpinEdit_ValueChanged(sender As Object, e As EventArgs) Handles Preco_CompraSpinEdit.Click ', Preco_CompraSpinEdit.EditValueChanged
        ' If Preco_CompraSpinEdit.Value > 0 Then
        If Preco_CompraSpinEdit.Value >= Preco_VendaSpinEdit.Value And Preco_VendaSpinEdit.Value <> 0 Then
                Preco_CompraSpinEdit.Value = Preco_VendaSpinEdit.Value - 1
            End If
        If Preco_CompraSpinEdit.Value <= 0 Then
            Preco_CompraSpinEdit.Value = 1
        End If

    End Sub

    Private Sub Preco_VendaSpinEdit_ValueChanged(sender As Object, e As EventArgs) Handles Preco_VendaSpinEdit.Click ', Preco_VendaSpinEdit.EditValueChanged


        'Loadspin()
        'Preco_VendaSpinEdit.Properties.MinValue = Preco_CompraSpinEdit.Value + 1
        'Preco_CompraSpinEdit.Properties.MaxValue = Preco_VendaSpinEdit.Value - 1
        'If Preco_CompraSpinEdit.Value > 0 Then
        If Preco_VendaSpinEdit.Value <= Preco_CompraSpinEdit.Value Then
                Preco_VendaSpinEdit.Value = Preco_CompraSpinEdit.Value + 1
            End If
        If Preco_VendaSpinEdit.Value <= 0 Then
            Preco_VendaSpinEdit.Value = 1
        End If
    End Sub

    Sub config_Spinedits()
        Preco_CompraSpinEdit.Properties.MinValue = 2
        Preco_CompraSpinEdit.Properties.MaxValue = 5

        Preco_VendaSpinEdit.Properties.MinValue = 1
        Preco_VendaSpinEdit.Properties.MaxValue = 10
    End Sub
    Sub Loadspin()
        If mNav.Registo_Atual > 0 Then
            With mLista(mNav.Registo_Atual - 1)


                Preco_CompraSpinEdit.Text = .Preco_Compra

                Preco_VendaSpinEdit.Text = .Preco_Venda

                '-------------------------
                ' Cod_Artigo
                '-------------------------



                '-------------------------------
                'Exemplo para as Combos...
                '-------------------------------
                'ucPaises.Text = clsPaises.GetPaisbyCod(.Cod_Pais).Pais
            End With
            '-------------------------------
            'upBar.Value = mNav.Registo_Atual
            '-------------------------------

        End If
    End Sub

    Private Sub UC_NAV11_Load(sender As Object, e As EventArgs) Handles UC_NAV11.Load

    End Sub
End Class