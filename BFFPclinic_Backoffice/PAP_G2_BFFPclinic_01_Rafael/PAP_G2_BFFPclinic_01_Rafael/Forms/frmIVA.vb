Public Class frmIVA
    Dim mLista As New List(Of ClsIVA)

    Private Sub frmIVA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mLista = ClsIVA.GetIVA
        mNav = New clsNav(mLista.Count)

        UC_NAV11.mFRM = Me

        SetupComps(True)
        UC_NAV11.Load_Status()
        UC_NAV11.SetupNav()
        LoadRegistos()

        Me.Text = "Manutenção da Tabela de IVA"

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
        ' A mLista que contém a lista de IVA
        ' pode ser filtrada através do método
        ' FiltrarIVA com o parâmetro da ClsIVA
        ' 
        ' É preciso criar uma variável do tipo ClsIVA
        ' e chamar o método FiltrarIVA com esse parâmetro:
        '
        '   Dim mclsFiltro as New clsIVA with {.Cod_IVA=txtCod_IVA.Text, .Taxa_IVA=txtTaxa_IVA.Text}
        '   Dim mListaFiltro = clsIVA.FiltrarIVA(mclsFiltro)
        '----------------------------------------------------------------------------------------------

        '-----------------
        'ucPaises
        '-----------------
        'ucPaises.DataSource = clsPaises.GetPaises
        'ucPaises.DisplayMember = "Pais"
        'ucPaises.ValueMember = "Cod_Pais"


    End Sub


    Sub SetupComps(ByVal pBool As Boolean)
        Me.Cod_IVATextEdit.ReadOnly = True
        If Not pBool Then
            If Me.UC_NAV11.mNovo Then
                Me.Cod_IVATextEdit.Focus()
            Else
                Me.Taxa_IVATextEdit.Focus()
            End If
        End If
        Taxa_IVATextEdit.ReadOnly = pBool
        Tipo_IVATextEdit.ReadOnly = pBool
        DesignacaoTextEdit.ReadOnly = pBool
        Data_Inicio_VigorDateEdit.ReadOnly = pBool
        Data_Fim_VigorDateEdit.ReadOnly = pBool
        FLG_DescontinuadoCheckEdit.ReadOnly = pBool
        FLG_AtivoCheckEdit.ReadOnly = pBool
        FLG_AtivoCheckEdit.Visible = False

        Data_Inicio_VigorDateEdit.BackColor = Color.White
        Data_Fim_VigorDateEdit.BackColor = Color.White

        '------------------------------
        'Exemplo da eventual UltraCmbo 
        '------------------------------
        'Me.PaisUltraCombo.ReadOnly = pBool

    End Sub

    Sub LoadRegistos()
        LimpaTXT()
        If mNav.Registo_Atual > 0 Then
            With mLista(mNav.Registo_Atual - 1)
                Taxa_IVATextEdit.Text = .Taxa_IVA
                Tipo_IVATextEdit.Text = .Tipo_IVA
                DesignacaoTextEdit.Text = .Designacao
                Data_Inicio_VigorDateEdit.Text = .Data_Inicio_Vigor
                Data_Fim_VigorDateEdit.Text = .Data_Fim_Vigor
                FLG_DescontinuadoCheckEdit.Checked = .FLG_Descontinuado
                FLG_AtivoCheckEdit.Checked = .FLG_Ativo
                '-------------------------
                ' Cod_IVA
                '-------------------------
                Cod_IVATextEdit.Text = .Cod_IVA

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

        Taxa_IVATextEdit.Text = ""
        Tipo_IVATextEdit.Text = ""
        DesignacaoTextEdit.Text = ""
        Data_Inicio_VigorDateEdit.Text = ""
        Data_Fim_VigorDateEdit.Text = ""
        FLG_DescontinuadoCheckEdit.Checked = True
        FLG_AtivoCheckEdit.Checked = 1
        '-------------------------------
        Cod_IVATextEdit.Text = ""
    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsIVA
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mCls
            If pbNovo Then
                '--------------------------------------
                'Método Não criado na CLASSE 
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_IVA = ClsIVA.GetNovoCodigo
                '--------------------------------------
            Else
                '--------------------------------------
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_IVA = Cod_IVATextEdit.Text
            End If
            '----------------------------------
            'Aqui VERIFICAR Todos os CAMPOS
            '  Não tem por ex. o FLG_Ativo...
            '----------------------------------
            .Taxa_IVA = Taxa_IVATextEdit.Text
            .Tipo_IVA = Tipo_IVATextEdit.Text
            .Designacao = DesignacaoTextEdit.Text
            .Data_Inicio_Vigor = Data_Inicio_VigorDateEdit.Text
            .Data_Fim_Vigor = Data_Fim_VigorDateEdit.Text
            .FLG_Descontinuado = FLG_DescontinuadoCheckEdit.Checked
            .FLG_Ativo = FLG_AtivoCheckEdit.Checked
        End With

        If pbNovo Then
            mFLG_Gravou = ClsIVA.GravaIVA(mCls)
        Else
            mFLG_Gravou = ClsIVA.ModificaIVA(mCls)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV11.mNovo = False
                mLista = ClsIVA.GetIVA
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_IVA = mCls.Cod_IVA) + 1
                LoadRegistos()

                '---------------------------
                'upBar.Maximum = mNav.Max_Registos
                'upBar.Value = mNav.Registo_Atual
            Else
                mLista = ClsIVA.GetIVA
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
            ClsIVA.ApagaIVA(mLista(mNav.Registo_Atual - 1).Cod_IVA)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsIVA.GetIVA
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub
End Class