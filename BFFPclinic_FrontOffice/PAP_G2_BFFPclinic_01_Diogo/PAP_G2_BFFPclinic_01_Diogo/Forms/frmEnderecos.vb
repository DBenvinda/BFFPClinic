Imports DevExpress.XtraBars.BarItemVisibility
Imports DevExpress.XtraEditors
'Public Class frmEnderecos
'        Dim mLista As New List(Of ClsEnderecos)

'        Public Property rCod_Entidade As String
'        Public Property rCod_Endereco As String
'        Public Property rNovo As Boolean = False

'        Dim mClasse As New ClsEnderecos

'        Dim mCod_Postal As String

'        Dim mLista_Cod_Postal As New List(Of String)
'        Dim mIndex_CP As Integer = 0

'        Dim mListaPT_Enderecos As New List(Of ClsPT_Enderecos)

'        Private Sub frmEnderecos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'        Me.StartPosition = FormStartPosition.CenterScreen
'        Me.FormBorderStyle = FormBorderStyle.FixedDialog

'        mLista_Cod_Postal = ClsPT_Enderecos.GetCod_Postal


'        If Not rNovo Then
'            mClasse = ClsEnderecos.GetEnderecosByCod(rCod_Entidade, rCod_Endereco)
'            SetupComps(False)
'            SetupBotoes(False)
'            LoadRegistos()

'            Me.DescritivoTextEdit.Focus()
'            ' Me.bbStatus.Caption = "Estou a Modificar Registo"
'        Else
'            '
'            SetupComps(False)
'            'SetupBotoes(False)
'            Me.Cod_Entidade_TextEdit.Text = rCod_Entidade
'            Me.Cod_Endereco_TextEdit.Text = rCod_Endereco
'            Me.DescritivoTextEdit.Focus()

'            'Me.bbStatus.Caption = "Estou a Criar um Novo Registo"
'        End If

'        ' ---------------------
'        ' ucCod_Postal
'        '----------------------
'        With ucCod_Postal
'            .DataSource = mLista_Cod_Postal
'            mIndex_CP = If(mIndex_CP < 0, 0, mIndex_CP)

'            .Rows(mIndex_CP).Selected = True
'        End With

'    End Sub


'        Sub SetupComps(ByVal pBool As Boolean)
'        Me.Cod_Entidade_TextEdit.ReadOnly = True
'        If Not pBool Then
'                If Me.UC_NAV11.mNovo Then
'                Me.Cod_Entidade_TextEdit.Focus()
'            Else
'                Me.Cod_Endereco_TextEdit.Focus()
'            End If
'            End If
'        Cod_Endereco_TextEdit.ReadOnly = pBool
'        DescritivoTextEdit.ReadOnly = pBool
'        Endereco_TextEdit.ReadOnly = pBool
'        Cod_Postal_TextEdit.ReadOnly = pBool
'        LocalidadeTextEdit.ReadOnly = pBool
'        Data_RegistoDateEdit.ReadOnly = pBool
'        FLG_AtivoCheckEdit.ReadOnly = pBool
'        cbLocalidade.ReadOnly = pBool
'        '------------------------------
'        'Exemplo da eventual UltraCmbo 
'        '------------------------------
'        'Me.PaisUltraCombo.ReadOnly = pBool

'    End Sub

'        Sub LoadRegistos()
'            LimpaTXT()
'            If mNav.Registo_Atual > 0 Then
'                With mLista(mNav.Registo_Atual - 1)
'                Cod_Endereco_TextEdit.Text = .Cod_Endereco
'                DescritivoTextEdit.Text = .Descritivo
'                Endereco_TextEdit.Text = .Endereco
'                Cod_Postal_TextEdit.Text = .Cod_Postal
'                LocalidadeTextEdit.Text = .Localidade
'                Data_RegistoDateEdit.DateTime = .Data_Registo
'                FLG_AtivoCheckEdit.Checked = .FLG_Ativo
'                cbLocalidade.Text = .Localidade
'                '-------------------------
'                ' Cod_Entidade
'                '-------------------------
'                Cod_Entidade_TextEdit.Text = .Cod_Entidade

'                '-------------------------------
'                'Exemplo para as Combos...
'                '-------------------------------
'                'ucPaises.Text = clsPaises.GetPaisbyCod(.Cod_Pais).Pais
'            End With
'                '-------------------------------
'                'upBar.Value = mNav.Registo_Atual
'                '-------------------------------

'            End If

'        End Sub

'        Sub LimpaTXT()

'        Cod_Endereco_TextEdit.Text = ""
'        DescritivoTextEdit.Text = ""
'        Endereco_TextEdit.Text = ""
'        Cod_Postal_TextEdit.Text = ""
'        LocalidadeTextEdit.Text = ""
'        Data_RegistoDateEdit.DateTime = Date.Now
'        FLG_AtivoCheckEdit.Checked = True
'        cbLocalidade.Text = ""
'        '-------------------------------
'        Cod_Entidade_TextEdit.Text = ""
'    End Sub

'    Sub SetupBotoes(pBool As Boolean)

'        Me.bbNovo.Visibility = If(Not pBool, Never, Always)
'        Me.bbModifica.Visibility = If(Not pBool, Never, Always)
'        Me.bbApaga.Visibility = If(Not pBool, Never, Always)
'        Me.bbSair.Visibility = If(Not pBool, Never, Always)
'        Me.bbGrava.Visibility = If(pBool, Never, Always)
'        Me.bbCancela.Visibility = If(pBool, Never, Always)

'        'If mNovo Then bbStatus.Caption = ""


'    End Sub
'    Sub Grava(ByVal pbNovo As Boolean)

'            '----------------------------------
'            'Exemplo de UltraValidate
'            '----------------------------------
'            'UltraValidator1.Validate()
'            '----------------------------------

'            Dim mFLG_Gravou As Boolean = False
'            Dim mCls As New ClsEnderecos
'            Dim mRegisto_Atual As Integer = mNav.Registo_Atual

'            With mCls
'                If pbNovo Then
'                '--------------------------------------
'                'Método Não criado na CLASSE 
'                ' Se for preciso é preciso criá-lo... 
'                '--------------------------------------
'                .Cod_Endereco = ClsEnderecos.GetNovoCodigo
'                '--------------------------------------
'            Else
'                '--------------------------------------
'                ' Se for preciso é preciso criá-lo... 
'                '--------------------------------------
'                .Cod_Entidade = Cod_Entidade_TextEdit.Text
'            End If
'            '----------------------------------
'            'Aqui VERIFICAR Todos os CAMPOS
'            '  Não tem por ex. o FLG_Ativo...
'            '----------------------------------
'            .Cod_Endereco = Cod_Endereco_TextEdit.Text
'            .Descritivo = DescritivoTextEdit.Text
'            .Endereco = Endereco_TextEdit.Text
'            .Cod_Postal = Cod_Postal_TextEdit.Text
'            .Localidade = LocalidadeTextEdit.Text
'            .Data_Registo = Data_RegistoDateEdit.DateTime
'            .Localidade = cbLocalidade.Text
'        End With

'            If pbNovo Then
'                mFLG_Gravou = ClsEnderecos.GravaEnderecos(mCls)
'            Else
'                mFLG_Gravou = ClsEnderecos.ModificaEnderecos(mCls)
'            End If


'            If mFLG_Gravou Then
'                If pbNovo Then
'                    Me.UC_NAV11.mNovo = False
'                    mLista = ClsEnderecos.GetEnderecos
'                    mNav = New clsNav(mLista.Count)
'                    mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Entidade = mCls.Cod_Entidade) + 1
'                    LoadRegistos()

'                    '---------------------------
'                    'upBar.Maximum = mNav.Max_Registos
'                    'upBar.Value = mNav.Registo_Atual
'                Else
'                    mLista = ClsEnderecos.GetEnderecos
'                    mNav = New clsNav(mLista.Count)
'                    mNav.Registo_Atual = mRegisto_Atual
'                    LoadRegistos()
'                End If
'            Else
'                MsgBox("Erro na gravação:")
'            End If
'        End Sub


'    Sub Apaga_Registo()
'        Try
'            ClsEnderecos.ApagaEnderecos(mLista(mNav.Registo_Atual - 1).Cod_Entidade, mLista(mNav.Registo_Atual - 1).Cod_Endereco)
'        Catch ex As Exception
'            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
'            Exit Sub
'        End Try

'        mLista = ClsEnderecos.GetEnderecos
'        mNav = New clsNav(mLista.Count)
'        LoadRegistos()
'    End Sub

'    Private Sub ucCod_Postal_AfterCloseUp(sender As Object, e As EventArgs) Handles ucCod_Postal.AfterCloseUp, ucCod_Postal.Leave
'        mCod_Postal = ucCod_Postal.Text

'        'Me.ucEnderecos.Visible = True
'        '----------------
'        ' ucEnderecos
'        '-----------------
'        mListaPT_Enderecos = ClsPT_Enderecos.GetPT_EnderecosByCod_Postal(mCod_Postal)
'        If mListaPT_Enderecos.Count > 0 Then


'            With ucEnderecos
'                .DisplayMember = "Endereco"
'                .DataSource = mListaPT_Enderecos
'                .Rows(0).Selected = True

'            End With
'            Me.ucEnderecos.Focus()

'        Else
'            Me.ucCod_Postal.Focus()
'        End If
'        Dim mIndex As Integer = 0

'        If ucEnderecos.ActiveRow IsNot Nothing Then
'            mIndex = ucEnderecos.ActiveRow.Index
'        End If

'        Me.Endereco_TextEdit.Text = mListaPT_Enderecos(mIndex).Endereco
'        Me.Cod_Postal_TextEdit.Text = mListaPT_Enderecos(mIndex).Cod_Postal
'        Me.LocalidadeTextEdit.Text = mListaPT_Enderecos(mIndex).Localidade
'    End Sub

'        Private Sub ucEnderecos_AfterCloseUp(sender As Object, e As EventArgs) Handles ucEnderecos.AfterCloseUp, ucEnderecos.Leave
'            ' Dim mEndereco As String = ucEnderecos.Text
'            Dim mIndex As Integer = 0

'            If ucEnderecos.ActiveRow IsNot Nothing Then
'                mIndex = ucEnderecos.ActiveRow.Index
'            End If

'        Me.Endereco_TextEdit.Text = mListaPT_Enderecos(mIndex).Endereco
'        Me.Cod_Postal_TextEdit.Text = mListaPT_Enderecos(mIndex).Cod_Postal
'        Me.LocalidadeTextEdit.Text = mListaPT_Enderecos(mIndex).Localidade

'        End Sub
'    Private Sub bbNovo_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbNovo.ItemClick
'        SetupComps(False)
'        SetupBotoes(False)
'    End Sub

'    Private Sub bbModifica_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbModifica.ItemClick
'        SetupComps(False)
'        SetupBotoes(False)
'    End Sub

'    Private Sub bbGrava_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbGrava.ItemClick
'        Grava(rNovo)
'        Close()
'    End Sub

'    Private Sub bbCancela_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbCancela.ItemClick
'        Close()
'    End Sub


'    'Private Sub ucEnderecos_AfterCloseUp(sender As Object, e As EventArgs) Handles ucEnderecos.AfterCloseUp, ucEnderecos.Leave
'    '    ' Dim mEndereco As String = ucEnderecos.Text
'    '    Dim mIndex As Integer = 0
'    '
'    '    If ucEnderecos.ActiveRow IsNot Nothing Then
'    '        mIndex = ucEnderecos.ActiveRow.Index
'    '    End If
'    '
'    '    Me.EnderecoTextEdit.Text = mListaPT_Enderecos(mIndex).Endereco
'    '    Me.Cod_PostalTextEdit.Text = mListaPT_Enderecos(mIndex).Cod_Postal
'    '    Me.LocalidadeTextEdit.Text = mListaPT_Enderecos(mIndex).Localidade
'    '
'    'End Sub
'End Class


'Public Class frmEnderecos
'    Public Property rCod_Entidade As String
'    Public Property rCod_Endereco As String
'    Public Property rNovo As Boolean = False

'    Dim mClasse As New ClsEnderecos

'    Dim mCod_Postal As String

'    Dim mLista_Cod_Postal As New List(Of String)
'    Dim mIndex_CP As Integer = 0

'    Dim mListaPT_Enderecos As New List(Of ClsPT_Enderecos)


'    Private Sub frmEnderecos_Load(sender As Object, e As EventArgs) Handles Me.Load

'        Me.StartPosition = FormStartPosition.CenterScreen
'        Me.FormBorderStyle = FormBorderStyle.FixedDialog

'        mLista_Cod_Postal = ClsPT_Enderecos.GetCod_Postal
'        'UC_NAV11.mFRM = Me
'        SetupBotoes(False)
'        SetupComps(True)
'        UC_NAV11.Load_Status()
'        UC_NAV11.SetupNav()
'        LoadRegistos()

'        If Not rNovo Then
'            mClasse = ClsEnderecos.GetEnderecosByCod(rCod_Entidade, rCod_Endereco)
'            SetupComps(False)
'            SetupBotoes(False)
'            LoadRegistos()

'            Me.DescritivoTextEdit.Focus()
'            Me.UC_NAV11.bbStatus.Caption = "Estou a Modificar Registo"
'        Else
'            '
'            SetupComps(False)
'            'SetupBotoes(False)
'            Me.Cod_Entidade_TextEdit.Text = rCod_Entidade
'            Me.Cod_Endereco_TextEdit.Text = rCod_Endereco
'            Me.DescritivoTextEdit.Focus()

'            Me.UC_NAV11.bbStatus.Caption = "Estou a Criar um Novo Registo"
'        End If

'        ' ---------------------
'        ' ucCod_Postal
'        '----------------------
'        With ucCod_Postal
'            .DataSource = mLista_Cod_Postal
'            mIndex_CP = If(mIndex_CP < 0, 0, mIndex_CP)

'            .Rows(mIndex_CP).Selected = True
'        End With

'    End Sub


'    Sub SetupBotoes(pBool As Boolean)

'        Me.UC_NAV11.bbNovo.Visibility = Not pBool
'        Me.UC_NAV11.bbModifica.Visibility = Not pBool
'        Me.UC_NAV11.bbApaga.Visibility = Not pBool
'        Me.UC_NAV11.bbSair.Visibility = Not pBool
'        Me.UC_NAV11.bbGrava.Visibility = pBool
'        Me.UC_NAV11.bbCancela.Visibility = pBool

'        'If mNovo Then bbStatus.Caption = ""


'    End Sub
'    Sub LimpaTXT()

'        Cod_Endereco_TextEdit.Text = ""
'        DescritivoTextEdit.Text = ""
'        Endereco_TextEdit.Text = ""
'        Cod_Postal_TextEdit.Text = ""
'        LocalidadeTextEdit.Text = ""
'        Data_RegistoDateEdit.Text = ""
'        '-------------------------------
'        Cod_Entidade_TextEdit.Text = ""
'    End Sub

'    Friend Function Find_Index() As Integer
'        Dim mReturn As Integer = 0
'        Dim mI As Integer = 0
'        For Each mS As String In mLista_Cod_Postal
'            If mS = mCod_Postal Then
'                mReturn = mI
'                Exit For
'            End If
'            mI += 1
'        Next

'        Return mReturn
'    End Function
'    Sub LoadRegistos()
'        LimpaTXT()

'        With mClasse
'            If rNovo Then
'                Data_RegistoDateEdit.Text = Date.Now
'            Else
'                Data_RegistoDateEdit.Text = .Data_Registo
'                mCod_Postal = .Cod_Postal
'                mIndex_CP = mLista_Cod_Postal.FindIndex(Function(x) x = mCod_Postal)
'                'mIndex_CP = Find_Index()
'            End If

'            Cod_Entidade_TextEdit.Text = .Cod_Entidade
'            Cod_Endereco_TextEdit.Text = .Cod_Endereco

'            DescritivoTextEdit.Text = .Descritivo
'            Endereco_TextEdit.Text = .Endereco
'            Cod_Postal_TextEdit.Text = .Cod_Postal
'            LocalidadeTextEdit.Text = .Localidade


'        End With
'        '-------------------------------
'        'upBar.Value = mNav.Registo_Atual
'        '-------------------------------



'    End Sub


'    Sub SetupComps(ByVal pBool As Boolean)

'        Me.Cod_Entidade_TextEdit.ReadOnly = True
'        Me.Cod_Endereco_TextEdit.ReadOnly = True

'        DescritivoTextEdit.ReadOnly = pBool
'        Endereco_TextEdit.ReadOnly = pBool
'        Cod_Postal_TextEdit.ReadOnly = pBool
'        LocalidadeTextEdit.ReadOnly = pBool

'        Data_RegistoDateEdit.ReadOnly = True


'    End Sub

'    Sub Grava(ByVal pbNovo As Boolean)

'        '----------------------------------
'        'Exemplo de UltraValidate
'        '----------------------------------
'        'UltraValidator1.Validate()
'        '----------------------------------

'        Dim mFLG_Gravou As Boolean = False
'        Dim mCls As New ClsEnderecos


'        With mCls

'            .Cod_Entidade = Cod_Entidade_TextEdit.Text
'            .Cod_Endereco = Cod_Endereco_TextEdit.Text
'            '----------------------------------
'            'Aqui VERIFICAR Todos os CAMPOS
'            '  Não tem por ex. o FLG_Ativo...
'            '----------------------------------

'            .Descritivo = DescritivoTextEdit.Text
'            .Endereco = Endereco_TextEdit.Text
'            .Cod_Postal = Cod_Postal_TextEdit.Text
'            .Localidade = LocalidadeTextEdit.Text

'            .Data_Registo = If(pbNovo, Date.Now, Data_RegistoDateEdit.Text)

'        End With

'        If pbNovo Then
'            mFLG_Gravou = ClsEnderecos.GravaEnderecos(mCls)
'        Else
'            mFLG_Gravou = ClsEnderecos.ModificaEnderecos(mCls)
'        End If


'        If mFLG_Gravou Then
'            rNovo = False
'            Me.Close()
'        Else
'            MsgBox("Erro na gravação:")
'        End If
'    End Sub


'    Private Sub bbNovo_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbNovo.ItemClick
'        SetupComps(False)
'        SetupBotoes(False)
'    End Sub

'    Private Sub bbModifica_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbModifica.ItemClick
'        SetupComps(False)
'        SetupBotoes(False)
'    End Sub

'    Private Sub bbGrava_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbGrava.ItemClick
'        Grava(rNovo)
'        Close()
'    End Sub

'    Private Sub bbCancela_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbCancela.ItemClick
'        Close()
'    End Sub

'    Private Sub ucCod_Postal_AfterCloseUp(sender As Object, e As EventArgs) Handles ucCod_Postal.AfterCloseUp, ucCod_Postal.Leave
'        mCod_Postal = ucCod_Postal.Text

'        'Me.ucEnderecos.Visible = True
'        '----------------
'        ' ucEnderecos
'        '-----------------
'        mListaPT_Enderecos = ClsPT_Enderecos.GetPT_EnderecosByCod_Postal(mCod_Postal)
'        If mListaPT_Enderecos.Count > 0 Then


'            With ucEnderecos
'                .DisplayMember = "Endereco"
'                .DataSource = mListaPT_Enderecos
'                .Rows(0).Selected = True

'            End With
'            Me.ucEnderecos.Focus()

'        Else
'            Me.ucCod_Postal.Focus()
'        End If
'        Dim mIndex As Integer = 0

'        If ucEnderecos.ActiveRow IsNot Nothing Then
'            mIndex = ucEnderecos.ActiveRow.Index
'        End If

'        Me.Endereco_TextEdit.Text = mListaPT_Enderecos(mIndex).Endereco
'        Me.Cod_Postal_TextEdit.Text = mListaPT_Enderecos(mIndex).Cod_Postal
'        Me.LocalidadeTextEdit.Text = mListaPT_Enderecos(mIndex).Localidade
'    End Sub

'    Private Sub frmEnderecos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
'        Me.UC_NAV11.SetupBotoes(False)
'    End Sub



'    'Private Sub ucEnderecos_AfterCloseUp(sender As Object, e As EventArgs) Handles ucEnderecos.AfterCloseUp, ucEnderecos.Leave
'    '    ' Dim mEndereco As String = ucEnderecos.Text
'    '    Dim mIndex As Integer = 0
'    '
'    '    If ucEnderecos.ActiveRow IsNot Nothing Then
'    '        mIndex = ucEnderecos.ActiveRow.Index
'    '    End If
'    '
'    '    Me.EnderecoTextEdit.Text = mListaPT_Enderecos(mIndex).Endereco
'    '    Me.Cod_PostalTextEdit.Text = mListaPT_Enderecos(mIndex).Cod_Postal
'    '    Me.LocalidadeTextEdit.Text = mListaPT_Enderecos(mIndex).Localidade
'    '
'    'End Sub
'End Class



Public Class frmEnderecos
    Public Property rCod_Entidade As String
    Public Property rCod_Endereco As String
    Public Property rNovo As Boolean = False

    Dim mClasse As New ClsEnderecos

    Dim mCod_Postal As String

    Dim mLista_Cod_Postal As New List(Of String)
    Dim mIndex_CP As Integer = 0

    Dim mListaPT_Enderecos As New List(Of ClsPT_Enderecos)


    Private Sub frmEnderecos_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedDialog

        mLista_Cod_Postal = ClsPT_Enderecos.GetCod_Postal


        If Not rNovo Then
            mClasse = ClsEnderecos.GetEnderecosByCod(rCod_Entidade, rCod_Endereco)
            SetupComps(False)
            SetupBotoes(False)
            LoadRegistos()

            Me.DescritivoTextEdit.Focus()
            Me.bbStatus.Caption = "Estou a Modificar Registo"
        Else
            '
            SetupComps(False)
            SetupBotoes(False)
            Me.Cod_Entidade_TextEdit.Text = rCod_Entidade
            Me.Cod_Endereco_TextEdit.Text = rCod_Endereco
            Me.DescritivoTextEdit.Focus()
            FLG_AtivoCheckEdit.Checked = True
            Me.bbStatus.Caption = "Estou a Criar um Novo Registo"
            Data_RegistoDateEdit.Text = Date.Now
        End If

        ' ---------------------
        ' ucCod_Postal
        '----------------------
        With ucCod_Postal
            .DataSource = mLista_Cod_Postal
            mIndex_CP = If(mIndex_CP < 0, 0, mIndex_CP)

            .Rows(mIndex_CP).Selected = True
        End With

    End Sub


    Sub SetupBotoes(pBool As Boolean)

        Me.bbNovo.Visibility = If(Not pBool, Never, Always)
        Me.bbModifica.Visibility = If(Not pBool, Never, Always)
        Me.bbApaga.Visibility = If(Not pBool, Never, Always)
        Me.bbSair.Visibility = If(Not pBool, Never, Always)
        Me.bbGrava.Visibility = If(pBool, Never, Always)
        Me.bbCancela.Visibility = If(pBool, Never, Always)

        'If mNovo Then bbStatus.Caption = ""


    End Sub
    Sub LimpaTXT()

        Cod_Endereco_TextEdit.Text = ""
        DescritivoTextEdit.Text = ""
        Endereco_TextEdit.Text = ""
        Cod_Postal_TextEdit.Text = ""
        LocalidadeTextEdit.Text = ""
        Data_RegistoDateEdit.Text = ""
        '-------------------------------
        Cod_Entidade_TextEdit.Text = ""
    End Sub

    Friend Function Find_Index() As Integer
        Dim mReturn As Integer = 0
        Dim mI As Integer = 0
        For Each mS As String In mLista_Cod_Postal
            If mS = mCod_Postal Then
                mReturn = mI
                Exit For
            End If
            mI += 1
        Next

        Return mReturn
    End Function
    Sub LoadRegistos()
        LimpaTXT()

        With mClasse
            If rNovo Then
                Data_RegistoDateEdit.Text = Date.Now

            Else
                Data_RegistoDateEdit.Text = .Data_Registo
                mCod_Postal = .Cod_Postal
                mIndex_CP = mLista_Cod_Postal.FindIndex(Function(x) x = mCod_Postal)
                'mIndex_CP = Find_Index()
            End If

            Cod_Entidade_TextEdit.Text = .Cod_Entidade
            Cod_Endereco_TextEdit.Text = .Cod_Endereco

            DescritivoTextEdit.Text = .Descritivo
            Endereco_TextEdit.Text = .Endereco
            Cod_Postal_TextEdit.Text = .Cod_Postal
            LocalidadeTextEdit.Text = .Localidade


        End With
        '-------------------------------
        'upBar.Value = mNav.Registo_Atual
        '-------------------------------



    End Sub


    Sub SetupComps(ByVal pBool As Boolean)

        Me.Cod_Entidade_TextEdit.ReadOnly = True
        Me.Cod_Endereco_TextEdit.ReadOnly = True

        DescritivoTextEdit.ReadOnly = pBool
        Endereco_TextEdit.ReadOnly = pBool
        Cod_Postal_TextEdit.ReadOnly = pBool
        LocalidadeTextEdit.ReadOnly = pBool

        Data_RegistoDateEdit.ReadOnly = True


    End Sub

    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsEnderecos


        With mCls

            .Cod_Entidade = Cod_Entidade_TextEdit.Text
            .Cod_Endereco = Cod_Endereco_TextEdit.Text
            '----------------------------------
            'Aqui VERIFICAR Todos os CAMPOS
            '  Não tem por ex. o FLG_Ativo...
            '----------------------------------

            .Descritivo = DescritivoTextEdit.Text
            .Endereco = Endereco_TextEdit.Text
            .Cod_Postal = Cod_Postal_TextEdit.Text
            .Localidade = LocalidadeTextEdit.Text

            .Data_Registo = If(pbNovo, Date.Now, Data_RegistoDateEdit.Text)

        End With

        If pbNovo Then
            mFLG_Gravou = ClsEnderecos.GravaEnderecos(mCls)
        Else
            mFLG_Gravou = ClsEnderecos.ModificaEnderecos(mCls)
        End If


        If mFLG_Gravou Then
            rNovo = False
        Else
            MsgBox("Erro na gravação:")
        End If
    End Sub


    Private Sub bbNovo_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbNovo.ItemClick
        SetupComps(False)
        SetupBotoes(False)
    End Sub

    Private Sub bbModifica_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbModifica.ItemClick
        SetupComps(False)
        SetupBotoes(False)
    End Sub

    Private Sub bbGrava_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbGrava.ItemClick
        Grava(rNovo)
        Close()
    End Sub

    Private Sub bbCancela_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbCancela.ItemClick
        Close()
    End Sub

    Private Sub ucCod_Postal_AfterCloseUp(sender As Object, e As EventArgs) Handles ucCod_Postal.AfterCloseUp, ucCod_Postal.Leave
        mCod_Postal = ucCod_Postal.Text

        Me.ucEnderecos.Visible = True
        Me.Endereco_TextEdit.Visible = False
        '----------------
        ' ucEnderecos
        '-----------------
        mListaPT_Enderecos = ClsPT_Enderecos.GetPT_EnderecosByCod_Postal(mCod_Postal)
        If mListaPT_Enderecos.Count > 0 Then


            With ucEnderecos
                .DisplayMember = "Endereco"
                .DataSource = mListaPT_Enderecos
                .Rows(0).Selected = True

            End With
            Me.ucEnderecos.Focus()

        Else
            Me.ucCod_Postal.Focus()
        End If
    End Sub

    Private Sub ucEnderecos_AfterCloseUp(sender As Object, e As EventArgs) Handles ucEnderecos.AfterCloseUp, ucEnderecos.Leave
        ' Dim mEndereco As String = ucEnderecos.Text
        Dim mIndex As Integer = 0

        If ucEnderecos.ActiveRow IsNot Nothing Then
            mIndex = ucEnderecos.ActiveRow.Index
        End If

        Me.Endereco_TextEdit.Text = mListaPT_Enderecos(mIndex).Endereco
        Me.Cod_Postal_TextEdit.Text = mListaPT_Enderecos(mIndex).Cod_Postal
        Me.LocalidadeTextEdit.Text = mListaPT_Enderecos(mIndex).Localidade

    End Sub
End Class