Public Class frmTipos_Doc
    Dim mLista As New List(Of ClsTipos_Doc)

    Private Sub frmTipos_Doc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mLista = ClsTipos_Doc.GetTipos_Doc
        mNav = New clsNav(mLista.Count)

        UC_NAV11.mFRM = Me

        SetupComps(True)
        UC_NAV11.Load_Status()
        UC_NAV11.SetupNav()
        LoadRegistos()

        Me.Text = "Manutenção da Tabela de Tipos_Doc"



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


        '-----------------
        'ucPaises
        '-----------------
        'ucPaises.DataSource = clsPaises.GetPaises
        'ucPaises.DisplayMember = "Pais"
        'ucPaises.ValueMember = "Cod_Pais"


    End Sub


    Sub SetupComps(ByVal pBool As Boolean)

        'Me.teID_TipoDoc.ReadOnly = True

        If Not pBool Then
            If Me.UC_NAV11.mNovo Then


            Else
                Me.DesignacaoTextEdit.Focus()
            End If
        End If
        FLG_Tipo_DocTextEdit.ReadOnly = pBool
        DesignacaoTextEdit.ReadOnly = pBool
        Descritivo_ImpressaoTextEdit.ReadOnly = pBool
        FLG_ESCTextEdit.ReadOnly = pBool
        FLG_DCTextEdit.ReadOnly = pBool
        FLG_EntidadeTextEdit.ReadOnly = pBool
        FLG_VendaCheckEdit.ReadOnly = pBool
        FLG_CompraCheckEdit.ReadOnly = pBool
        FLG_StockCheckEdit.ReadOnly = pBool
        Cod_SerieTextEdit.ReadOnly = pBool
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
                Descritivo_ImpressaoTextEdit.Text = .Descritivo_Impressao
                FLG_ESCTextEdit.Text = .FLG_ESC
                FLG_DCTextEdit.Text = .FLG_DC
                Cod_SerieTextEdit.Text = .Cod_Serie
                FLG_EntidadeTextEdit.Text = .FLG_Entidade
                FLG_VendaCheckEdit.Checked = .FLG_Venda
                FLG_CompraCheckEdit.Checked = .FLG_Compra
                FLG_StockCheckEdit.Checked = .FLG_Stock
                FLG_AtivoCheckEdit.Checked = .FLG_Ativo
                '-------------------------
                ' FLG_Tipo_Doc
                '-------------------------
                FLG_Tipo_DocTextEdit.Text = .FLG_Tipo_Doc

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
        Descritivo_ImpressaoTextEdit.Text = ""
        FLG_ESCTextEdit.Text = ""
        FLG_DCTextEdit.Text = ""
        Cod_SerieTextEdit.Text = ""
        FLG_EntidadeTextEdit.Text = True
        FLG_VendaCheckEdit.Checked = True
        FLG_CompraCheckEdit.Checked = True
        FLG_StockCheckEdit.Checked = True
        FLG_AtivoCheckEdit.Checked = 1
        '-------------------------------
        FLG_Tipo_DocTextEdit.Text = ""
    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsTipos_Doc
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mCls
            If pbNovo Then
                '--------------------------------------
                'Método Não criado na CLASSE 
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                '.FLG_Tipo_Doc = ClsTipos_Doc.GetNovoCodigo
                .FLG_Tipo_Doc = FLG_Tipo_DocTextEdit.Text
                '--------------------------------------
            Else
                '--------------------------------------
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .FLG_Tipo_Doc = FLG_Tipo_DocTextEdit.Text
            End If
            '----------------------------------
            'Aqui VERIFICAR Todos os CAMPOS
            '  Não tem por ex. o FLG_Ativo...
            '----------------------------------
            .Designacao = DesignacaoTextEdit.Text
            .Descritivo_Impressao = Descritivo_ImpressaoTextEdit.Text
            .FLG_ESC = FLG_ESCTextEdit.Text
            .FLG_DC = FLG_DCTextEdit.Text
            .FLG_Entidade = FLG_EntidadeTextEdit.Text
            .FLG_Venda = FLG_VendaCheckEdit.Checked
            .FLG_Compra = FLG_CompraCheckEdit.Checked
            .FLG_Stock = FLG_StockCheckEdit.Checked
            .FLG_Ativo = FLG_AtivoCheckEdit.Checked

            .Cod_Serie = ClsEmpresas.GetEmpresasByCod(1).Ano_Trabalho & "-" & .FLG_Tipo_Doc
        End With

        If pbNovo Then
            mFLG_Gravou = ClsTipos_Doc.GravaTipos_Doc(mCls)
        Else
            mFLG_Gravou = ClsTipos_Doc.ModificaTipos_Doc(mCls)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV11.mNovo = False
                mLista = ClsTipos_Doc.GetTipos_Doc
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.FLG_Tipo_Doc = mCls.FLG_Tipo_Doc) + 1
                LoadRegistos()

                '---------------------------
                'upBar.Maximum = mNav.Max_Registos
                'upBar.Value = mNav.Registo_Atual
            Else
                mLista = ClsTipos_Doc.GetTipos_Doc
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
            ClsTipos_Doc.ApagaTipos_Doc(mLista(mNav.Registo_Atual - 1).FLG_Tipo_Doc)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsTipos_Doc.GetTipos_Doc
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub


End Class