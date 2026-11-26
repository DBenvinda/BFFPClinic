Public Class FrmTipos_Marcação
    Dim mLista As New List(Of ClsTipos_Marcacao)

    Private Sub frmTipos_Marcacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mLista = ClsTipos_Marcacao.GetTipos_Marcacao
        mNav = New clsNav(mLista.Count)

        UC_NAV11.mFRM = Me

        SetupComps(True)
        UC_NAV11.Load_Status()
        UC_NAV11.SetupNav()
        LoadRegistos()

        Me.Text = "Manutenção da Tabela de Tipos_Marcacao"

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
        ' A mLista que contém a lista de Tipos_Marcacao
        ' pode ser filtrada através do método
        ' FiltrarTipos_Marcacao com o parâmetro da ClsTipos_Marcacao
        ' 
        ' É preciso criar uma variável do tipo ClsTipos_Marcacao
        ' e chamar o método FiltrarTipos_Marcacao com esse parâmetro:
        '
        '   Dim mclsFiltro as New clsTipos_Marcacao with {.Cod_Tipo_Marcacao=txtCod_Tipo_Marcacao.Text, .Designacao=txtDesignacao.Text}
        '   Dim mListaFiltro = clsTipos_Marcacao.FiltrarTipos_Marcacao(mclsFiltro)
        '----------------------------------------------------------------------------------------------

        '-----------------
        'ucPaises
        '-----------------
        'ucPaises.DataSource = clsPaises.GetPaises
        'ucPaises.DisplayMember = "Pais"
        'ucPaises.ValueMember = "Cod_Pais"


    End Sub


    Sub SetupComps(ByVal pBool As Boolean)
        Me.Cod_Tipo_MarcacaoTextEdit.ReadOnly = True
        If Not pBool Then
            If Me.UC_NAV11.mNovo Then
                Me.Cod_Tipo_MarcacaoTextEdit.Focus()
            Else
                Me.DesignacaoTextEdit.Focus()
            End If
        End If
        DesignacaoTextEdit.ReadOnly = pBool
        FLG_AtivoCheckEdit.ReadOnly = pBool
        FLG_AtivoCheckEdit.Visible = False

        '------------------------------
        'Exemplo da eventual UltraCmbo 
        '------------------------------
        'Me.PaisUltraCombo.ReadOnly = pBool

    End Sub

    Sub LoadRegistos()
        LimpaTXT()
        If mNav.Registo_Atual > 0 Then
            With mLista(mNav.Registo_Atual - 1)
                DesignacaoTextEdit.Text = .Designacao
                '-------------------------
                ' Cod_Tipo_Marcacao
                '-------------------------
                Cod_Tipo_MarcacaoTextEdit.Text = .Cod_Tipo_Marcacao
                FLG_AtivoCheckEdit.Checked = .FLG_Ativo

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

        DesignacaoTextEdit.Text = ""
        '-------------------------------
        Cod_Tipo_MarcacaoTextEdit.Text = ""
        FLG_AtivoCheckEdit.Checked = 1
    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsTipos_Marcacao
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mCls
            If pbNovo Then
                '--------------------------------------
                'Método Não criado na CLASSE 
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Tipo_Marcacao = ClsTipos_Marcacao.GetNovoCodigo
                '--------------------------------------
            Else
                '--------------------------------------
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Tipo_Marcacao = Cod_Tipo_MarcacaoTextEdit.Text
            End If
            '----------------------------------
            'Aqui VERIFICAR Todos os CAMPOS
            '  Não tem por ex. o FLG_Ativo...
            '----------------------------------
            .Designacao = DesignacaoTextEdit.Text
            .FLG_Ativo = FLG_AtivoCheckEdit.Checked
        End With

        If pbNovo Then
            mFLG_Gravou = ClsTipos_Marcacao.GravaTipos_Marcacao(mCls)
        Else
            mFLG_Gravou = ClsTipos_Marcacao.ModificaTipos_Marcacao(mCls)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV11.mNovo = False
                mLista = ClsTipos_Marcacao.GetTipos_Marcacao
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Tipo_Marcacao = mCls.Cod_Tipo_Marcacao) + 1
                LoadRegistos()

                '---------------------------
                'upBar.Maximum = mNav.Max_Registos
                'upBar.Value = mNav.Registo_Atual
            Else
                mLista = ClsTipos_Marcacao.GetTipos_Marcacao
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
            ClsTipos_Marcacao.ApagaTipos_Marcacao(mLista(mNav.Registo_Atual - 1).Cod_Tipo_Marcacao)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsTipos_Marcacao.GetTipos_Marcacao
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub

End Class