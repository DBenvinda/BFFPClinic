Public Class FrmEspecialidades
    Dim mLista As New List(Of ClsEspecialidades)

    Private Sub frmEspecialidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mLista = ClsEspecialidades.GetEspecialidades
        mNav = New clsNav(mLista.Count)

        UC_NAV11.mFRM = Me

        SetupComps(True)
        UC_NAV11.Load_Status()
        UC_NAV11.SetupNav()
        LoadRegistos()

        Me.Text = "Manutenção da Tabela de Especialidades"

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
        ' A mLista que contém a lista de Especialidades
        ' pode ser filtrada através do método
        ' FiltrarEspecialidades com o parâmetro da ClsEspecialidades
        ' 
        ' É preciso criar uma variável do tipo ClsEspecialidades
        ' e chamar o método FiltrarEspecialidades com esse parâmetro:
        '
        '   Dim mclsFiltro as New clsEspecialidades with {.Cod_Especialidade=txtCod_Especialidade.Text, .Designacao=txtDesignacao.Text}
        '   Dim mListaFiltro = clsEspecialidades.FiltrarEspecialidades(mclsFiltro)
        '----------------------------------------------------------------------------------------------

        '-----------------
        'ucPaises
        '-----------------
        'ucPaises.DataSource = clsPaises.GetPaises
        'ucPaises.DisplayMember = "Pais"
        'ucPaises.ValueMember = "Cod_Pais"


    End Sub


    Sub SetupComps(ByVal pBool As Boolean)
        Me.Cod_EspecialidadeTextEdit.ReadOnly = True
        If Not pBool Then
            If Me.UC_NAV11.mNovo Then
                Me.Cod_EspecialidadeTextEdit.Focus()
            Else
                Me.DesignacaoTextEdit.Focus()
            End If
        End If
        DesignacaoTextEdit.ReadOnly = pBool
        FLG_AtivoCheckEdit.ReadOnly = pBool
        FLG_AtivoCheckEdit.Visible = False
        FLG_ExamesCheckEdit.ReadOnly = pBool
        FLG_OperacoesCheckEdit.ReadOnly = pBool
        FLG_ConsultasCheckEdit.ReadOnly = pBool

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
                ' Cod_Especialidade
                '-------------------------
                Cod_EspecialidadeTextEdit.Text = .Cod_Especialidade
                FLG_AtivoCheckEdit.Checked = .FLG_Ativo
                FLG_ExamesCheckEdit.Checked = .FLG_Exames
                FLG_OperacoesCheckEdit.Checked = .FLG_Operacoes
                FLG_ConsultasCheckEdit.Checked = .FLG_Consultas

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
        Cod_EspecialidadeTextEdit.Text = ""
        FLG_AtivoCheckEdit.Checked = 1
        FLG_ExamesCheckEdit.Checked = True
        FLG_OperacoesCheckEdit.Checked = True
        FLG_ConsultasCheckEdit.Checked = True
    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsEspecialidades
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mCls
            If pbNovo Then
                '--------------------------------------
                'Método Não criado na CLASSE 
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Especialidade = ClsEspecialidades.GetNovoCodigo
                '--------------------------------------
            Else
                '--------------------------------------
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Especialidade = Cod_EspecialidadeTextEdit.Text
            End If
            '----------------------------------
            'Aqui VERIFICAR Todos os CAMPOS
            '  Não tem por ex. o FLG_Ativo...
            '----------------------------------
            .Designacao = DesignacaoTextEdit.Text
            .FLG_Ativo = FLG_AtivoCheckEdit.Checked
            .FLG_Exames = FLG_ExamesCheckEdit.Checked
            .FLG_Operacoes = FLG_OperacoesCheckEdit.Checked
            .FLG_Consultas = FLG_ConsultasCheckEdit.Checked
        End With

        If pbNovo Then
            mFLG_Gravou = ClsEspecialidades.GravaEspecialidades(mCls)
        Else
            mFLG_Gravou = ClsEspecialidades.ModificaEspecialidades(mCls)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV11.mNovo = False
                mLista = ClsEspecialidades.GetEspecialidades
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Especialidade = mCls.Cod_Especialidade) + 1
                LoadRegistos()

                '---------------------------
                'upBar.Maximum = mNav.Max_Registos
                'upBar.Value = mNav.Registo_Atual
            Else
                mLista = ClsEspecialidades.GetEspecialidades
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
            ClsEspecialidades.ApagaEspecialidades(mLista(mNav.Registo_Atual - 1).Cod_Especialidade)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsEspecialidades.GetEspecialidades
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub
End Class