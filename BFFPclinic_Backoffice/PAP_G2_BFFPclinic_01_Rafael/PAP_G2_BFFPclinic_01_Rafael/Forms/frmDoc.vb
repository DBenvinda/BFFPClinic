Public Class frmDoc
    Dim mLista As New List(Of ClsDoc)

    Private Sub frmDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mLista = ClsDoc.GetDoc
        mNav = New clsNav(mLista.Count)

        UC_NAV11.mFRM = Me

        SetupComps(True)
        UC_NAV11.Load_Status()
        UC_NAV11.SetupNav()
        LoadRegistos()

        Me.Text = "Manutenção da Tabela de Doc"

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


        With ucFLG_Tipo_Doc
            .DataSource = ClsTipos_Doc.GetTipos_Doc
            .DisplayLayout.Bands(0).Columns(0).Hidden = False
            .DisplayLayout.Bands(0).Columns(1).Hidden = True
            .DisplayLayout.Bands(0).Columns(2).Hidden = True
            .DisplayLayout.Bands(0).Columns(3).Hidden = True
            .DisplayLayout.Bands(0).Columns(4).Hidden = True
            .DisplayLayout.Bands(0).Columns(5).Hidden = True
            .DisplayLayout.Bands(0).Columns(6).Hidden = True
            .DisplayLayout.Bands(0).Columns(7).Hidden = True
            .DisplayLayout.Bands(0).Columns(8).Hidden = True
            .DisplayLayout.Bands(0).Columns(9).Hidden = True
            .DisplayLayout.Bands(0).Columns(10).Hidden = True
            .DisplayLayout.Bands(0).Columns(11).Hidden = True
        End With


        With ucTipo_Pagamento
            .DataSource = ClsTipos_Pagamento.GetTipos_Pagamento
            .DisplayLayout.Bands(0).Columns(0).Hidden = False
            .DisplayLayout.Bands(0).Columns(1).Hidden = False
            .DisplayLayout.Bands(0).Columns(2).Hidden = True
            .DisplayLayout.Bands(0).Columns(3).Hidden = True
        End With

        With ucCod_Entidade
            .DataSource = ClsEntidades.GetEntidades
            .DisplayLayout.Bands(0).Columns(0).Hidden = False
            .DisplayLayout.Bands(0).Columns(1).Hidden = True
            .DisplayLayout.Bands(0).Columns(2).Hidden = False
            .DisplayLayout.Bands(0).Columns(3).Hidden = True
            .DisplayLayout.Bands(0).Columns(4).Hidden = True
            .DisplayLayout.Bands(0).Columns(5).Hidden = True
            .DisplayLayout.Bands(0).Columns(6).Hidden = True
            .DisplayLayout.Bands(0).Columns(7).Hidden = True
            .DisplayLayout.Bands(0).Columns(8).Hidden = True
            .DisplayLayout.Bands(0).Columns(9).Hidden = True
            .DisplayLayout.Bands(0).Columns(10).Hidden = True
            .DisplayLayout.Bands(0).Columns(11).Hidden = True
            .DisplayLayout.Bands(0).Columns(12).Hidden = True
            .DisplayLayout.Bands(0).Columns(13).Hidden = True
            .DisplayLayout.Bands(0).Columns(14).Hidden = True
            .DisplayLayout.Bands(0).Columns(15).Hidden = True
            .DisplayLayout.Bands(0).Columns(16).Hidden = True
            .DisplayLayout.Bands(0).Columns(17).Hidden = True
            .DisplayLayout.Bands(0).Columns(18).Hidden = True
            .DisplayLayout.Bands(0).Columns(18).Hidden = True
            .DisplayLayout.Bands(0).Columns(19).Hidden = True
        End With
    End Sub


    Sub SetupComps(ByVal pBool As Boolean)
        Me.Num_DocTextEdit.ReadOnly = True
        If Not pBool Then
            If Me.UC_NAV11.mNovo Then
                Me.Num_DocTextEdit.Focus()
            Else
                Me.FLG_Tipo_DocTextEdit.Focus()
            End If
        End If
        FLG_Tipo_DocTextEdit.ReadOnly = pBool
        DesignacaoTextEdit.ReadOnly = pBool
        Data_DocDateEdit.ReadOnly = pBool
        Cod_EntidadeTextEdit.ReadOnly = pBool
        Taxa_DescontoTextEdit.ReadOnly = pBool
        Data_VencimentoDateEdit.ReadOnly = pBool
        FLG_PagoCheckEdit.ReadOnly = pBool
        Tipo_PagamentoTextEdit.ReadOnly = pBool
        Data_PagamentoDateEdit.ReadOnly = pBool
        FLG_AtivoCheckEdit.ReadOnly = pBool

        ucTipo_Pagamento.Visible = Not pBool
        ucFLG_Tipo_Doc.Visible = Not pBool
        ucCod_Entidade.Visible = Not pBool

        '------------------------------
        'Exemplo da eventual UltraCmbo 
        '------------------------------
        'Me.PaisUltraCombo.ReadOnly = pBool

    End Sub

    Sub LoadRegistos()
        LimpaTXT()
        If mNav.Registo_Atual > 0 Then
            With mLista(mNav.Registo_Atual - 1)
                FLG_Tipo_DocTextEdit.Text = .FLG_Tipo_Doc
                DesignacaoTextEdit.Text = .Designacao
                Data_DocDateEdit.Text = .Data_Doc
                Cod_EntidadeTextEdit.Text = .Cod_Entidade
                Taxa_DescontoTextEdit.Text = .Taxa_Desconto
                Data_VencimentoDateEdit.Text = .Data_Vencimento
                FLG_PagoCheckEdit.Checked = .FLG_Pago
                Tipo_PagamentoTextEdit.Text = .Tipo_Pagamento
                Data_PagamentoDateEdit.Text = .Data_Pagamento
                FLG_AtivoCheckEdit.Checked = .FLG_Ativo
                '-------------------------
                ' Num_Doc
                '-------------------------
                Num_DocTextEdit.Text = .Num_Doc

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

        FLG_Tipo_DocTextEdit.Text = ""
        DesignacaoTextEdit.Text = ""
        Data_DocDateEdit.Text = ""
        Cod_EntidadeTextEdit.Text = ""
        Taxa_DescontoTextEdit.Text = ""
        Data_VencimentoDateEdit.Text = ""
        FLG_PagoCheckEdit.Checked = True
        FLG_AtivoCheckEdit.Checked = True
        Tipo_PagamentoTextEdit.Text = ""
        Data_PagamentoDateEdit.Text = ""
        '-------------------------------
        Num_DocTextEdit.Text = ""


        ucTipo_Pagamento.Value = ""
        ucCod_Entidade.Value = ""
        ucFLG_Tipo_Doc.Value = ""
    End Sub


    'Sub Grava(ByVal pbNovo As Boolean)

    '    '----------------------------------
    '    'Exemplo de UltraValidate
    '    '----------------------------------
    '    'UltraValidator1.Validate()
    '    '----------------------------------

    '    Dim mFLG_Gravou As Boolean = False
    '    Dim mCls As New ClsDoc
    '    Dim mRegisto_Atual As Integer = mNav.Registo_Atual

    '    With mCls
    '        If pbNovo Then
    '            '--------------------------------------
    '            'Método Não criado na CLASSE 
    '            ' Se for preciso é preciso criá-lo... 
    '            '--------------------------------------
    '            .Num_Doc = Cls.GetNovoCodigo(FLG_Tipo_DocTextEdit.Text, Data_DocDateEdit.Text.Substring(6, 4))
    '            '--------------------------------------
    '        Else
    '            '--------------------------------------
    '            ' Se for preciso é preciso criá-lo... 
    '            '--------------------------------------
    '            .Num_Doc = Num_DocTextEdit.Text
    '        End If
    '        '----------------------------------
    '        'Aqui VERIFICAR Todos os CAMPOS
    '        '  Não tem por ex. o FLG_Ativo...
    '        '----------------------------------
    '        .FLG_Tipo_Doc = FLG_Tipo_DocTextEdit.Text
    '        .Designacao = DesignacaoTextEdit.Text
    '        .Data_Doc = Data_DocDateEdit.Text
    '        .Cod_Entidade = Cod_EntidadeTextEdit.Text
    '        .Taxa_Desconto = Taxa_DescontoTextEdit.Text
    '        .Data_Vencimento = Data_VencimentoDateEdit.Text
    '        .FLG_Pago = FLG_PagoCheckEdit.Checked
    '        .Tipo_Pagamento = Tipo_PagamentoTextEdit.Text
    '        .Data_Pagamento = Data_PagamentoDateEdit.Text
    '        .FLG_Ativo = FLG_AtivoCheckEdit.Checked
    '    End With

    '    If pbNovo Then
    '        mFLG_Gravou = ClsGrava.GravaDoc(mCls)
    '    Else
    '        mFLG_Gravou = ClsDoc.ModificaDoc(mCls)
    '    End If


    '    If mFLG_Gravou Then
    '        If pbNovo Then
    '            Me.UC_NAV11.mNovo = False
    '            mLista = ClsDoc.GetDoc
    '            mNav = New clsNav(mLista.Count)
    '            mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Num_Doc = mCls.Num_Doc) + 1
    '            LoadRegistos()

    '            '---------------------------
    '            'upBar.Maximum = mNav.Max_Registos
    '            'upBar.Value = mNav.Registo_Atual
    '        Else
    '            mLista = ClsDoc.GetDoc
    '            mNav = New clsNav(mLista.Count)
    '            mNav.Registo_Atual = mRegisto_Atual
    '            LoadRegistos()
    '        End If
    '    Else
    '        MsgBox("Erro na gravação:")
    '    End If
    'End Sub


    Sub Apaga_Registo()
        Try
            ClsDoc.ApagaDoc(mLista(mNav.Registo_Atual - 1).Num_Doc)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsDoc.GetDoc
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub

    Private Sub ucFLG_Tipos_Doc_AfterCloseup(sender As Object, e As EventArgs) Handles ucFLG_Tipo_Doc.AfterCloseUp, ucFLG_Tipo_Doc.Leave
        FLG_Tipo_DocTextEdit.Text = ucFLG_Tipo_Doc.SelectedRow.Cells("FLG_Tipo_Doc").Text
        'Cod_SalaTextEdit.Text = ucSalas.SelectedRow.Cells("Cod_sala").Text
    End Sub
    Private Sub ucCod_Entidade_AfterCloseup(sender As Object, e As EventArgs) Handles ucCod_Entidade.AfterCloseUp, ucCod_Entidade.Leave
        Cod_EntidadeTextEdit.Text = ucCod_Entidade.SelectedRow.Cells("Cod_Entidade").Text
        'Cod_ExameTextEdit.Text = ucExame.SelectedRow.Cells("Cod_Exame").Text
    End Sub
    Private Sub ucTipo_Pagamento_AfterCloseup(sender As Object, e As EventArgs) Handles ucTipo_Pagamento.AfterCloseUp, ucTipo_Pagamento.Leave
        Tipo_PagamentoTextEdit.Text = ucTipo_Pagamento.SelectedRow.Cells("Tipo_Pagamento").Text
        'id_StatusTextEdit.Text = ucStatus.SelectedRow.Cells("id").Text
    End Sub
End Class