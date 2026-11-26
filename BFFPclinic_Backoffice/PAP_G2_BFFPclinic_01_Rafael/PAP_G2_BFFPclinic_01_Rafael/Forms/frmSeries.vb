Imports DevExpress.XtraCharts.Design

Public Class frmSeries
    Dim mLista As New List(Of ClsSeries)


    Private Sub frmSeries_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mLista = ClsSeries.GetSeries
        mNav = New clsNav(mLista.Count)

        UC_NAV11.mFRM = Me
        SetupComps(True)
        UC_NAV11.Load_Status()
        UC_NAV11.SetupNav()

        LoadRegistos()

        Me.Text = "Manutenção da Tabela de Series"

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
        ' A mLista que contém a lista de Series
        ' pode ser filtrada através do método
        ' FiltrarSeries com o parâmetro da ClsSeries
        ' 
        ' É preciso criar uma variável do tipo ClsSeries
        ' e chamar o método FiltrarSeries com esse parâmetro:
        '
        '   Dim mclsFiltro as New clsSeries with {.Cod_Serie=txtCod_Serie.Text, .FLG_Tipo_Doc=txtFLG_Tipo_Doc.Text}
        '   Dim mListaFiltro = clsSeries.FiltrarSeries(mclsFiltro)
        '----------------------------------------------------------------------------------------------

        '-----------------
        'ucPaises
        '-----------------
        'ucPaises.DataSource = clsPaises.GetPaises
        'ucPaises.DisplayMember = "Pais"
        'ucPaises.ValueMember = "Cod_Pais"


    End Sub


    Sub SetupComps(ByVal pBool As Boolean)
        Me.Cod_SerieTextEdit.ReadOnly = True
        BtnCriarSerie.Visible = Not pBool
        If Not pBool Then
            If Me.UC_NAV11.mNovo Then
                Me.Cod_SerieTextEdit.Focus()
                BtnCriarSerie.Visible = Not pBool
            Else
                Me.FLG_Tipo_DocTextEdit.Focus()
                BtnCriarSerie.Visible = pBool
            End If
        End If
        FLG_Tipo_DocTextEdit.ReadOnly = pBool
        Ano_TrabalhoTextEdit.ReadOnly = pBool
        ContadorTextEdit.ReadOnly = pBool
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
                FLG_Tipo_DocTextEdit.Text = .FLG_Tipo_Doc
                Ano_TrabalhoTextEdit.Text = .Ano_Trabalho
                ContadorTextEdit.Text = .Contador
                FLG_AtivoCheckEdit.Checked = .FLG_Ativo
                '-------------------------
                ' Cod_Serie
                '-------------------------
                Cod_SerieTextEdit.Text = .Cod_Serie

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
        Ano_TrabalhoTextEdit.Text = ""
        ContadorTextEdit.Text = ""
        FLG_AtivoCheckEdit.Checked = 1

        '-------------------------------
        Cod_SerieTextEdit.Text = ""
    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsSeries
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mCls
            If pbNovo Then
                '--------------------------------------
                'Método Não criado na CLASSE 
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                '.Cod_Serie = ClsSeries.Cria_Serie(Ano_TrabalhoTextEdit.Text)
                '--------------------------------------
            Else
                '--------------------------------------
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Serie = Cod_SerieTextEdit.Text
            End If
            '----------------------------------
            'Aqui VERIFICAR Todos os CAMPOS
            '  Não tem por ex. o FLG_Ativo...
            '----------------------------------
            .FLG_Tipo_Doc = FLG_Tipo_DocTextEdit.Text
            .Ano_Trabalho = Ano_TrabalhoTextEdit.Text
            .Contador = ContadorTextEdit.Text
            .FLG_Ativo = FLG_AtivoCheckEdit.Checked

        End With



        If pbNovo Then
            'mFLG_Gravou = ClsSeries.GravaSeries(mCls)
            'If Not ClsEmpresas.GravaAnoAtual(mAnoAtual) Then
            'MsgBox("Erro na gravação do ano atual")
            ' Exit Sub
            'End If
            '------------------------------------------
            'Criar os Cod_Serie para todos os Tipos_Doc
            '------------------------------------------
            mFLG_Gravou = ClsSeries.ModificaSeries(mCls)
        Else
            mFLG_Gravou = ClsSeries.Cria_Serie(Ano_TrabalhoTextEdit.Text)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV11.mNovo = False
                mLista = ClsSeries.GetSeries
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Serie = mCls.Cod_Serie) + 1
                LoadRegistos()
                MsgBox("Gravação feita")
                '---------------------------
                'upBar.Maximum = mNav.Max_Registos
                'upBar.Value = mNav.Registo_Atual
            Else
                mLista = ClsSeries.GetSeries
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mRegisto_Atual
                LoadRegistos()
            End If
        Else
            MsgBox("Erro na gravação")
        End If

    End Sub

    Sub BtnCriarSerie_Click(sender As Object, e As EventArgs) Handles BtnCriarSerie.Click
        '------------------------------------
        'Mudar o ano da tabela Empresas
        '------------------------------------
        Dim mAnoAtual As String = Year(Date.Now).ToString

        SetupComps(True)
        LoadRegistos()

        UC_NAV11.SetupBotoes(True)
        UC_NAV11.Load_Status()

        If Not ClsEmpresas.GravaAnoAtual(mAnoAtual) Then
                MsgBox("Erro na gravação do ano atual")
            Exit Sub
        End If
            '------------------------------------------
            'Criar os Cod_Serie para todos os Tipos_Doc 
            '------------------------------------------
            If Not ClsSeries.Cria_Serie(mAnoAtual) Then
            MsgBox("Erro na Criação da Serie")

            Exit Sub
        End If

        If ClsEmpresas.GravaAnoAtual(mAnoAtual) Then
            MsgBox("Ano atual gravado")
            mLista = ClsSeries.GetSeries
            mNav = New clsNav(mLista.Count)
            Exit Sub
        End If
        '------------------------------------------
        'Criar os Cod_Serie para todos os Tipos_Doc 
        '------------------------------------------
    End Sub

    Sub Apaga_Registo()
        Try
            ClsSeries.ApagaSeries(mLista(mNav.Registo_Atual - 1).Cod_Serie)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsSeries.GetSeries
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub
End Class