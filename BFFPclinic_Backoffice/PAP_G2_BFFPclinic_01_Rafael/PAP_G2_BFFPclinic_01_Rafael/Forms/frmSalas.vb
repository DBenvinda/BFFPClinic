Public Class frmSalas
    Dim mLista As New List(Of ClsSalas)

    Private Sub frmSalas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mLista = ClsSalas.GetSalas
        mNav = New clsNav(mLista.Count)

        UC_NAV11.mFRM = Me

        SetupComps(True)
        UC_NAV11.Load_Status()
        UC_NAV11.SetupNav()
        LoadRegistos()

        Me.Text = "Manutenção da Tabela de Salas"

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
        ' A mLista que contém a lista de Salas
        ' pode ser filtrada através do método
        ' FiltrarSalas com o parâmetro da ClsSalas
        ' 
        ' É preciso criar uma variável do tipo ClsSalas
        ' e chamar o método FiltrarSalas com esse parâmetro:
        '
        '   Dim mclsFiltro as New clsSalas with {.Cod_Sala=txtCod_Sala.Text, .Designacao=txtDesignacao.Text}
        '   Dim mListaFiltro = clsSalas.FiltrarSalas(mclsFiltro)
        '----------------------------------------------------------------------------------------------

        '-----------------
        'ucPaises
        '-----------------
        'ucPaises.DataSource = clsPaises.GetPaises
        'ucPaises.DisplayMember = "Pais"
        'ucPaises.ValueMember = "Cod_Pais"


    End Sub


    Sub SetupComps(ByVal pBool As Boolean)
        Me.Cod_SalaTextEdit.ReadOnly = True

        If Not pBool Then
            If Me.UC_NAV11.mNovo Then
                Me.Cod_SalaTextEdit.Focus()
            Else
                Me.DesignacaoTextEdit.Focus()
            End If
        End If
        DesignacaoTextEdit.ReadOnly = pBool
        FLG_AtivoCheckEdit.ReadOnly = pBool
        PisoTextEdit.ReadOnly = pBool
        Num_SalaTextEdit.ReadOnly = pBool
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
                FLG_AtivoCheckEdit.Checked = .FLG_Ativo
                PisoTextEdit.Text = .Piso
                Num_SalaTextEdit.Text = .Num_Sala

                '-------------------------
                ' Cod_Sala
                '-------------------------
                Cod_SalaTextEdit.Text = .Cod_Sala

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
        FLG_AtivoCheckEdit.Checked = 1
        PisoTextEdit.Text = ""
        Num_SalaTextEdit.Text = ""
        '-------------------------------
        Cod_SalaTextEdit.Text = ""
    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsSalas
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mCls
            If pbNovo Then
                '--------------------------------------
                'Método Não criado na CLASSE 
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Sala = ClsSalas.GetNovoCodigo
                '--------------------------------------
            Else
                '--------------------------------------
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Sala = Cod_SalaTextEdit.Text
            End If
            '----------------------------------
            'Aqui VERIFICAR Todos os CAMPOS
            '  Não tem por ex. o FLG_Ativo...
            '----------------------------------
            .Designacao = DesignacaoTextEdit.Text
            .FLG_Ativo = FLG_AtivoCheckEdit.Checked
            .Piso = PisoTextEdit.Text
            .Num_Sala = Num_SalaTextEdit.Text
        End With

        If pbNovo Then
            mFLG_Gravou = ClsSalas.GravaSalas(mCls)
        Else
            mFLG_Gravou = ClsSalas.ModificaSalas(mCls)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV11.mNovo = False
                mLista = ClsSalas.GetSalas
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Sala = mCls.Cod_Sala) + 1
                LoadRegistos()

                '---------------------------
                'upBar.Maximum = mNav.Max_Registos
                'upBar.Value = mNav.Registo_Atual
            Else
                mLista = ClsSalas.GetSalas
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
            ClsSalas.ApagaSalas(mLista(mNav.Registo_Atual - 1).Cod_Sala)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsSalas.GetSalas
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub

End Class