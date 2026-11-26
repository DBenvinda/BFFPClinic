Public Class frmEmpresas
    Dim mLista As New List(Of ClsEmpresas)

    Private Sub frmEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mLista = ClsEmpresas.GetEmpresas
        mNav = New clsNav(mLista.Count)

        UC_NAV11.mFRM = Me

        SetupComps(True)
        UC_NAV11.Load_Status()
        UC_NAV11.SetupNav()
        LoadRegistos()

        Me.Text = "Manutenção da Tabela de Empresas"

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
        'ucPaises.DataSource = clsPaises.GetPaises
        'ucPaises.DisplayMember = "Pais"
        'ucPaises.ValueMember = "Cod_Pais"

        '----------------------------------------------------------------------------------------------
        ' Como se faz um Filtro da Lista de Clientes?
        ' 
        ' A mLista que contém a lista de Empresas
        ' pode ser filtrada através do método
        ' FiltrarEmpresas com o parâmetro da ClsEmpresas
        ' 
        ' É preciso criar uma variável do tipo ClsEmpresas
        ' e chamar o método FiltrarEmpresas com esse parâmetro:
        '
        '   Dim mclsFiltro as New clsEmpresas with {.Cod_Empresa=txtCod_Empresa.Text, .Nome=txtNome.Text}
        '   Dim mListaFiltro = clsEmpresas.FiltrarEmpresas(mclsFiltro)
        '----------------------------------------------------------------------------------------------

        '-----------------
        'ucPaises
        '-----------------
        'ucPaises.DataSource = clsPaises.GetPaises
        'ucPaises.DisplayMember = "Pais"
        'ucPaises.ValueMember = "Cod_Pais"


    End Sub


    Sub SetupComps(ByVal pBool As Boolean)
        Me.Cod_EmpresaTextEdit.ReadOnly = True
        If Not pBool Then
            If Me.UC_NAV11.mNovo Then
                Me.Cod_EmpresaTextEdit.Focus()
            Else
                Me.NomeTextEdit.Focus()
            End If
        End If
        NomeTextEdit.ReadOnly = pBool
        EnderecoTextEdit.ReadOnly = pBool
        PaisTextEdit.ReadOnly = pBool
        Cod_PostalTextEdit.ReadOnly = pBool
        LocalidadeTextEdit.ReadOnly = pBool
        EmailTextEdit.ReadOnly = pBool
        ' wwwTextEdit.ReadOnly = pBool
        Num_TelefoneTextEdit.ReadOnly = pBool
        Num_TelemovelTextEdit.ReadOnly = pBool
        Capital_SocialTextEdit.ReadOnly = pBool
        Registo_ComercialTextEdit.ReadOnly = pBool
        Matricula_CRCTextEdit.ReadOnly = pBool
        Data_ConstituicaoDateEdit.ReadOnly = pBool
        NIFTextEdit.ReadOnly = pBool
        ' Contador_ClientesTextEdit.ReadOnly = pBool
        ' Contador_FornecedoresTextEdit.ReadOnly = pBool
        ' Contador_EmpregadosTextEdit.ReadOnly = pBool
        ' Contador_MedicosTextEdit.ReadOnly = pBool
        ' Contador_UtentesTextEdit.ReadOnly = pBool
        ' Contador_ProdutosTextEdit.ReadOnly = pBool
        ' Contador_ServicosTextEdit.ReadOnly = pBool
        ' Contador_IVATextEdit.ReadOnly = pBool
        ' Contador_CategoriasTextEdit.ReadOnly = pBool
        ' Contador_EspecialidadesTextEdit.ReadOnly = pBool
        ' Contador_ReceitasTextEdit.ReadOnly = pBool
        ' Contador_Tipos_MarcacaoTextEdit.ReadOnly = pBool
        ' Contador_Tipos_ExamesTextEdit.ReadOnly = pBool
        ' Contador_Tipos_PagamentoTextEdit.ReadOnly = pBool
        ' Contador_OperacoesTextEdit.ReadOnly = pBool
        ' Contador_ExamesTextEdit.ReadOnly = pBool
        ' Contador_ConsultasTextEdit.ReadOnly = pBool
        Ano_TrabalhoTextEdit.ReadOnly = pBool
        Hora_AberturaTextEdit.ReadOnly = pBool
        Hora_FechoTextEdit.ReadOnly = pBool
        FLG_AtivoCheckEdit.ReadOnly = pBool

        '------------------------------
        'Exemplo da eventual UltraCmbo 
        '------------------------------
        'Me.PaisUltraCombo.ReadOnly = pBool

    End Sub

    Sub LoadRegistos()
        LimpaTXT()
        If mNav.Registo_Atual > 0 Then
            With mLista(mNav.Registo_Atual - 1)
                NomeTextEdit.Text = .Nome
                EnderecoTextEdit.Text = .Endereco
                PaisTextEdit.Text = .Pais
                Cod_PostalTextEdit.Text = .Cod_Postal
                LocalidadeTextEdit.Text = .Localidade
                EmailTextEdit.Text = .Email
                '  wwwTextEdit.Text = .www
                Num_TelefoneTextEdit.Text = .Num_Telefone
                Num_TelemovelTextEdit.Text = .Num_Telemovel
                Capital_SocialTextEdit.Text = .Capital_Social
                Registo_ComercialTextEdit.Text = .Registo_Comercial
                Matricula_CRCTextEdit.Text = .Matricula_CRC
                Data_ConstituicaoDateEdit.Text = .Data_Constituicao
                NIFTextEdit.Text = .NIF
                ' Contador_ClientesTextEdit.Text = .Contador_Clientes
                ' Contador_FornecedoresTextEdit.Text = .Contador_Fornecedores
                ' Contador_EmpregadosTextEdit.Text = .Contador_Empregados
                ' Contador_MedicosTextEdit.Text = .Contador_Medicos
                ' Contador_UtentesTextEdit.Text = .Contador_Utentes
                ' Contador_ProdutosTextEdit.Text = .Contador_Produtos
                ' Contador_ServicosTextEdit.Text = .Contador_Servicos
                ' Contador_IVATextEdit.Text = .Contador_IVA
                ' Contador_CategoriasTextEdit.Text = .Contador_Categorias
                ' Contador_EspecialidadesTextEdit.Text = .Contador_Especialidades
                ' Contador_ReceitasTextEdit.Text = .Contador_Receitas
                ' Contador_Tipos_MarcacaoTextEdit.Text = .Contador_Tipos_Marcacao
                ' Contador_Tipos_ExamesTextEdit.Text = .Contador_Tipos_Exames
                ' Contador_Tipos_PagamentoTextEdit.Text = .Contador_Tipos_Pagamento
                ' Contador_OperacoesTextEdit.Text = .Contador_Operacoes
                ' Contador_ExamesTextEdit.Text = .Contador_Exames
                ' Contador_ConsultasTextEdit.Text = .Contador_Consultas
                Ano_TrabalhoTextEdit.Text = .Ano_Trabalho
                Hora_AberturaTextEdit.Text = .Hora_Abertura
                Hora_FechoTextEdit.Text = .Hora_Fecho
                FLG_AtivoCheckEdit.Text = .FLG_Ativo
                '-------------------------
                ' Cod_Empresa
                '-------------------------
                Cod_EmpresaTextEdit.Text = .Cod_Empresa

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

        NomeTextEdit.Text = ""
        EnderecoTextEdit.Text = ""
        PaisTextEdit.Text = ""
        Cod_PostalTextEdit.Text = ""
        LocalidadeTextEdit.Text = ""
        EmailTextEdit.Text = ""
        ' wwwTextEdit.Text = ""
        Num_TelefoneTextEdit.Text = ""
        Num_TelemovelTextEdit.Text = ""
        Capital_SocialTextEdit.Text = ""
        Registo_ComercialTextEdit.Text = ""
        Matricula_CRCTextEdit.Text = ""
        Data_ConstituicaoDateEdit.Text = ""
        NIFTextEdit.Text = ""
        ' Contador_ClientesTextEdit.Text = ""
        ' Contador_FornecedoresTextEdit.Text = ""
        ' Contador_EmpregadosTextEdit.Text = ""
        ' Contador_MedicosTextEdit.Text = ""
        ' Contador_UtentesTextEdit.Text = ""
        ' Contador_ProdutosTextEdit.Text = ""
        ' Contador_ServicosTextEdit.Text = ""
        ' Contador_IVATextEdit.Text = ""
        ' Contador_CategoriasTextEdit.Text = ""
        ' Contador_EspecialidadesTextEdit.Text = ""
        ' Contador_ReceitasTextEdit.Text = ""
        ' Contador_Tipos_MarcacaoTextEdit.Text = ""
        ' Contador_Tipos_ExamesTextEdit.Text = ""
        ' Contador_Tipos_PagamentoTextEdit.Text = ""
        ' Contador_OperacoesTextEdit.Text = ""
        ' Contador_ExamesTextEdit.Text = ""
        ' Contador_ConsultasTextEdit.Text = ""
        Ano_TrabalhoTextEdit.Text = ""
        Hora_AberturaTextEdit.Text = ""
        Hora_FechoTextEdit.Text = ""
        FLG_AtivoCheckEdit.Checked = True
        '-------------------------------
        Cod_EmpresaTextEdit.Text = ""
    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsEmpresas
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mCls
            If pbNovo Then
                '--------------------------------------
                'Método Não criado na CLASSE 
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                '  .Cod_Empresa = ClsEmpresas.GetNovoCodigo
                '--------------------------------------
            Else
                '--------------------------------------
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Empresa = Cod_EmpresaTextEdit.Text
            End If
            '----------------------------------
            'Aqui VERIFICAR Todos os CAMPOS
            '  Não tem por ex. o FLG_Ativo...
            '----------------------------------
            .Nome = NomeTextEdit.Text
            .Endereco = EnderecoTextEdit.Text
            .Pais = PaisTextEdit.Text
            .Cod_Postal = Cod_PostalTextEdit.Text
            .Localidade = LocalidadeTextEdit.Text
            .Email = EmailTextEdit.Text
            ' .www = wwwTextEdit.Text
            .Num_Telefone = Num_TelefoneTextEdit.Text
            .Num_Telemovel = Num_TelemovelTextEdit.Text
            .Capital_Social = Capital_SocialTextEdit.Text
            .Registo_Comercial = Registo_ComercialTextEdit.Text
            .Matricula_CRC = Matricula_CRCTextEdit.Text
            .Data_Constituicao = Data_ConstituicaoDateEdit.Text
            .NIF = NIFTextEdit.Text
            ' .Contador_Clientes = Contador_ClientesTextEdit.Text
            ' .Contador_Fornecedores = Contador_FornecedoresTextEdit.Text
            ' .Contador_Empregados = Contador_EmpregadosTextEdit.Text
            ' .Contador_Medicos = Contador_MedicosTextEdit.Text
            ' .Contador_Utentes = Contador_UtentesTextEdit.Text
            ' .Contador_Produtos = Contador_ProdutosTextEdit.Text
            ' .Contador_Servicos = Contador_ServicosTextEdit.Text
            ' .Contador_IVA = Contador_IVATextEdit.Text
            ' .Contador_Categorias = Contador_CategoriasTextEdit.Text
            ' .Contador_Especialidades = Contador_EspecialidadesTextEdit.Text
            ' .Contador_Receitas = Contador_ReceitasTextEdit.Text
            ' .Contador_Tipos_Marcacao = Contador_Tipos_MarcacaoTextEdit.Text
            ' .Contador_Tipos_Exames = Contador_Tipos_ExamesTextEdit.Text
            ' .Contador_Tipos_Pagamento = Contador_Tipos_PagamentoTextEdit.Text
            ' .Contador_Operacoes = Contador_OperacoesTextEdit.Text
            ' .Contador_Exames = Contador_ExamesTextEdit.Text
            ' .Contador_Consultas = Contador_ConsultasTextEdit.Text
            .Ano_Trabalho = Ano_TrabalhoTextEdit.Text
            .Hora_Abertura = Hora_AberturaTextEdit.Text
            .Hora_Fecho = Hora_FechoTextEdit.Text
            .FLG_Ativo = FLG_AtivoCheckEdit.Checked
        End With

        If pbNovo Then
            mFLG_Gravou = ClsEmpresas.GravaEmpresas(mCls)
        Else
            mFLG_Gravou = ClsEmpresas.ModificaEmpresas(mCls)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV11.mNovo = False
                mLista = ClsEmpresas.GetEmpresas
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Empresa = mCls.Cod_Empresa) + 1
                LoadRegistos()

                '---------------------------
                'upBar.Maximum = mNav.Max_Registos
                'upBar.Value = mNav.Registo_Atual
            Else
                mLista = ClsEmpresas.GetEmpresas
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
            ClsEmpresas.ApagaEmpresas(mLista(mNav.Registo_Atual - 1).Cod_Empresa)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsEmpresas.GetEmpresas
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub


End Class