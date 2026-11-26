Public Class frmTipos_Pagamento
    Dim mLista As New List(Of ClsTipos_Pagamento)

    Private Sub frmTipos_Pagamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mLista = ClsTipos_Pagamento.GetTipos_Pagamento
        mNav = New clsNav(mLista.Count)

        UC_NAV11.mFRM = Me

        SetupComps(True)
        UC_NAV11.Load_Status()
        UC_NAV11.SetupNav()
        LoadRegistos()

        Me.Text = "Manutenção da Tabela de Tipos_Pagamento"

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
        ' A mLista que contém a lista de Tipos_Pagamento
        ' pode ser filtrada através do método
        ' FiltrarTipos_Pagamento com o parâmetro da ClsTipos_Pagamento
        ' 
        ' É preciso criar uma variável do tipo ClsTipos_Pagamento
        ' e chamar o método FiltrarTipos_Pagamento com esse parâmetro:
        '
        '   Dim mclsFiltro as New clsTipos_Pagamento with {.Cod_Tipo_Pagamento=txtCod_Tipo_Pagamento.Text, .Tipo_Pagamento=txtTipo_Pagamento.Text}
        '   Dim mListaFiltro = clsTipos_Pagamento.FiltrarTipos_Pagamento(mclsFiltro)
        '----------------------------------------------------------------------------------------------

        '-----------------
        'ucPaises
        '-----------------
        'ucPaises.DataSource = clsPaises.GetPaises
        'ucPaises.DisplayMember = "Pais"
        'ucPaises.ValueMember = "Cod_Pais"


    End Sub


    Sub SetupComps(ByVal pBool As Boolean)
        Me.Cod_Tipo_PagamentoTextEdit.ReadOnly = True
        If Not pBool Then
            If Me.UC_NAV11.mNovo Then
                Me.Tipo_PagamentoTextEdit.Focus()
            Else
                Me.Tipo_PagamentoTextEdit.Focus()
            End If
        End If
        Tipo_PagamentoTextEdit.ReadOnly = pBool
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
                Tipo_PagamentoTextEdit.Text = .Tipo_Pagamento
                '-------------------------
                ' Cod_Tipo_Pagamento
                '-------------------------
                Cod_Tipo_PagamentoTextEdit.Text = .Cod_Tipo_Pagamento
                FLG_AtivoCheckEdit.Text = .FLG_Ativo

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

        Tipo_PagamentoTextEdit.Text = ""
        '-------------------------------
        Cod_Tipo_PagamentoTextEdit.Text = ""
        FLG_AtivoCheckEdit.Checked = 1
    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsTipos_Pagamento
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mCls
            If pbNovo Then
                '--------------------------------------
                'Método Não criado na CLASSE 
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Tipo_Pagamento = ClsTipos_Pagamento.GetNovoCodigo
                '--------------------------------------
            Else
                '--------------------------------------
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Tipo_Pagamento = Cod_Tipo_PagamentoTextEdit.Text
            End If
            '----------------------------------
            'Aqui VERIFICAR Todos os CAMPOS
            '  Não tem por ex. o FLG_Ativo...
            '----------------------------------
            .Tipo_Pagamento = Tipo_PagamentoTextEdit.Text
            .FLG_Ativo = FLG_AtivoCheckEdit.Checked
        End With

        If pbNovo Then
            mFLG_Gravou = ClsTipos_Pagamento.GravaTipos_Pagamento(mCls)
        Else
            mFLG_Gravou = ClsTipos_Pagamento.ModificaTipos_Pagamento(mCls)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV11.mNovo = False
                mLista = ClsTipos_Pagamento.GetTipos_Pagamento
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Tipo_Pagamento = mCls.Cod_Tipo_Pagamento) + 1
                LoadRegistos()

                '---------------------------
                'upBar.Maximum = mNav.Max_Registos
                'upBar.Value = mNav.Registo_Atual
            Else
                mLista = ClsTipos_Pagamento.GetTipos_Pagamento
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
            ClsTipos_Pagamento.ApagaTipos_Pagamento(mLista(mNav.Registo_Atual - 1).Cod_Tipo_Pagamento)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsTipos_Pagamento.GetTipos_Pagamento
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub

End Class