Imports System.IO

Public Class FrmCategorias
    Dim mLista As New List(Of ClsCategorias)
    Dim mPathCategorias As String = "N:\000-Grupo02-I21\03-Programas\PAP_G2_BFFPclinic_02_Rafael\PAP_G2_BFFPclinic_01_Rafael\PAP_G2_BFFPclinic_01_Rafael\Resources\Imagens\"
    Private Sub frmCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mLista = ClsCategorias.GetCategorias
        mNav = New clsNav(mLista.Count)

        UC_NAV11.mFRM = Me

        SetupComps(True)
        UC_NAV11.Load_Status()
        UC_NAV11.SetupNav()
        LoadRegistos()

        Me.Text = "Manutenção da Tabela de Categorias"

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
        ' A mLista que contém a lista de Categorias
        ' pode ser filtrada através do método
        ' FiltrarCategorias com o parâmetro da ClsCategorias
        ' 
        ' É preciso criar uma variável do tipo ClsCategorias
        ' e chamar o método FiltrarCategorias com esse parâmetro:
        '
        '   Dim mclsFiltro as New clsCategorias with {.Cod_Categoria=txtCod_Categoria.Text, .Designacao=txtDesignacao.Text}
        '   Dim mListaFiltro = clsCategorias.FiltrarCategorias(mclsFiltro)
        '----------------------------------------------------------------------------------------------

        '-----------------
        'ucPaises
        '-----------------
        'ucPaises.DataSource = clsPaises.GetPaises
        'ucPaises.DisplayMember = "Pais"
        'ucPaises.ValueMember = "Cod_Pais"


    End Sub


    Sub SetupComps(ByVal pBool As Boolean)
        Me.Cod_CategoriaTextEdit.ReadOnly = True
        Me.DesignacaoTextEdit.ReadOnly = True
        If Not pBool Then
            If Me.UC_NAV11.mNovo Then
                Me.Cod_CategoriaTextEdit.Focus()
                Me.DesignacaoTextEdit.Focus()
                '  Else
                '      Me.DesignacaoTextEdit.Focus()
            End If
        End If
        '    DesignacaoTextEdit.ReadOnly = pBool
        ImagemTextEdit.ReadOnly = pBool
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
                DesignacaoTextEdit.Text = .Designacao
                ImagemTextEdit.Text = .Imagem
                '-------------------------
                ' Cod_Categoria
                '-------------------------
                Cod_CategoriaTextEdit.Text = .Cod_Categoria
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
        ImagemTextEdit.Text = ""
        '-------------------------------
        Cod_CategoriaTextEdit.Text = ""
        FLG_AtivoCheckEdit.Checked = True
    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsCategorias
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mCls
            If pbNovo Then
                '--------------------------------------
                'Método Não criado na CLASSE 
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Categoria = ClsCategorias.GetNovoCodigo
                '--------------------------------------
            Else
                '--------------------------------------
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Categoria = Cod_CategoriaTextEdit.Text
            End If
            '----------------------------------
            'Aqui VERIFICAR Todos os CAMPOS
            '  Não tem por ex. o FLG_Ativo...
            '----------------------------------
            .Designacao = DesignacaoTextEdit.Text
            .Imagem = ImagemTextEdit.Text
            .FLG_Ativo = FLG_AtivoCheckEdit.Checked
        End With

        If pbNovo Then
            mFLG_Gravou = ClsCategorias.GravaCategorias(mCls)
        Else
            mFLG_Gravou = ClsCategorias.ModificaCategorias(mCls)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV11.mNovo = False
                mLista = ClsCategorias.GetCategorias
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Categoria = mCls.Cod_Categoria) + 1
                LoadRegistos()

                '---------------------------
                'upBar.Maximum = mNav.Max_Registos
                'upBar.Value = mNav.Registo_Atual
            Else
                mLista = ClsCategorias.GetCategorias
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
            ClsCategorias.ApagaCategorias(mLista(mNav.Registo_Atual - 1).Cod_Categoria)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsCategorias.GetCategorias
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub
    Private Sub Carregar_Imagem()
        OFDCategorias.Filter = " JPG |*.jpg| PNG | *.png| Todos os Ficheiros| *.*"


        If OFDCategorias.ShowDialog = DialogResult.OK Then

            Dim mCont = 0
            Dim mFileName As String = OFDCategorias.FileName.ToString
            Dim mLen As Integer = Len(mFileName)
            Dim mExt As String = mFileName.Substring(mLen - 4, 4)

            Dim mFileDestino = mPathCategorias + Cod_CategoriaTextEdit.Text + mExt
            ImagemTextEdit.Text = Cod_CategoriaTextEdit.Text + mExt

Cont:
            Try
                File.Copy(OFDCategorias.FileName, mFileDestino, True)
            Catch ex As Exception
                If File.Exists(mFileDestino) Then
                    mCont += 1
                    mFileDestino = mPathCategorias + Cod_CategoriaTextEdit.Text + mCont.ToString("000") + mExt 'mCont.ToString("000")
                    Me.ImagemTextEdit.Text = Cod_CategoriaTextEdit.Text + mCont.ToString("000") + mExt
                    GoTo Cont
                End If
            End Try

            ' If mCont > 0 Then
            '     Me.pbCategorias_Imagem.Image.Tag = Cod_CategoriaTextEdit.Text + mExt 'mCont.ToString("000")
            ' Else
            '     Me.pbCategorias_Imagem.Image.Tag = Cod_CategoriaTextEdit.Text + mExt
            ' End If
            pbCategorias_Imagem.Image = Image.FromFile(mFileDestino)


        End If


    End Sub
    Private Sub btnCarrega_Click(sender As Object, e As EventArgs) Handles btnCarrega.Click
        Carregar_Imagem()
    End Sub

    Private Sub btnApaga_Click(sender As Object, e As EventArgs) Handles btnApaga.Click
        pbCategorias_Imagem = Nothing
        ImagemTextEdit.Text = ""

    End Sub
End Class