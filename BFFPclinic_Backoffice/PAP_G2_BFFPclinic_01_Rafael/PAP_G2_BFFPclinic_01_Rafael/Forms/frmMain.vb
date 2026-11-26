Imports DevExpress.DashboardCommon
Imports DevExpress.PivotGrid.OLAP.AdoWrappers
Imports DevExpress.Skins
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.FluentDesignSystem

Public Enum enMenu
    Entidades
    Artigos
    Categorias
    Docs
    Empresas
    Enderecos
    Especialidades
    IVA
    Marcacoes
    Salas
    Series
    Tipos_Doc
    Tipos_Exame
    Tipos_Marcacao
    Tipos_Pagamento

End Enum

Public Class frmMain
    Dim mContentor As New FluentDesignFormContainer
    Dim mFrm As New Form
    Public mUser As String

    Private Sub me_Load() Handles Me.Load
        ' Me.Size = 

    End Sub

    Sub Load_Menu(penMenu As enMenu)

        'Dim permissao As String = ClsEntidades.GetFLG_Entidadebyuser(mUser)
        Me.Panel1.Visible = True
        Me.FluentDesignFormContainer1.Dock = DockStyle.None
        Me.FluentDesignFormContainer1.Anchor = AnchorStyles.Left + AnchorStyles.Right + AnchorStyles.Top + AnchorStyles.Bottom
        Me.FluentDesignFormContainer1.Width = Me.Width - AccordionControl1.Width - Panel1.Width
        Me.FluentDesignFormContainer1.Height = Me.Height


        Select Case penMenu

            Case enMenu.Entidades
                mFrm = New frmEntidades
            Case enMenu.Artigos
                mFrm = New FrmArtigos
            Case enMenu.Categorias
                mFrm = New FrmCategorias
            Case enMenu.Docs
                mFrm = New FrmDocs
            Case enMenu.Empresas
                mFrm = New frmEmpresas
            Case enMenu.Enderecos
                mFrm = New frmEnderecos
            Case enMenu.Especialidades
                mFrm = New FrmEspecialidades
            Case enMenu.IVA
                mFrm = New frmIVA
            Case enMenu.Marcacoes
                mFrm = New frmMarcações
            Case enMenu.Salas
                mFrm = New frmSalas
            Case enMenu.Series
                mFrm = New frmSeries
            Case enMenu.Tipos_Doc
                mFrm = New frmTipos_Doc
            Case enMenu.Tipos_Marcacao
                mFrm = New FrmTipos_Marcação
            Case enMenu.Tipos_Pagamento
                mFrm = New frmTipos_Pagamento
        End Select

        mFrm.TopLevel = False
        mFrm.FormBorderStyle = FormBorderStyle.None
        mFrm.Dock = DockStyle.Fill

        mFrm.Parent = mContentor
        mFrm.Show()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmLogin.Show()
        Me.Hide()
        mContentor = Me.FluentDesignFormContainer1
        ' AccordionControl1.BackColor = Color.FromArgb(72, 119, 101)
        ' mContentor.BackColor = Color.FromArgb(72, 119, 101)
    End Sub

    Public Sub aceEntidades_Click(sender As Object, e As EventArgs) Handles aceEntidades.Click
        mFrm.Close()

        Load_Menu(enMenu.Entidades)

    End Sub

    Private Sub aceCategorias_Click(sender As Object, e As EventArgs)
        mFrm.Close()

        Load_Menu(enMenu.Categorias)
    End Sub

    Private Sub aceArtigos_Click(sender As Object, e As EventArgs) Handles aceArtigos.Click
        mFrm.Close()

        Load_Menu(enMenu.Artigos)
    End Sub

    Private Sub aceDocs_Click(sender As Object, e As EventArgs) Handles aceDocs.Click
        mFrm.Close()

        Load_Menu(enMenu.Docs)
        Me.Panel1.Visible = False
        Me.FluentDesignFormContainer1.Dock = DockStyle.Fill
    End Sub

    Private Sub aceEmpresas_Click(sender As Object, e As EventArgs)
        mFrm.Close()

        Load_Menu(enMenu.Empresas)
    End Sub

    Private Sub aceEnderecos_Click(sender As Object, e As EventArgs)
        mFrm.Close()

        Load_Menu(enMenu.Enderecos)
    End Sub

    Private Sub aceEspecialidades_Click(sender As Object, e As EventArgs) Handles aceEspecialidades.Click
        mFrm.Close()

        Load_Menu(enMenu.Especialidades)
    End Sub

    Private Sub aceIVA_Click(sender As Object, e As EventArgs) Handles aceIVA.Click
        mFrm.Close()

        Load_Menu(enMenu.IVA)
    End Sub

    Private Sub aceMarcacoes_Click(sender As Object, e As EventArgs) Handles aceMarcacoes.Click
        mFrm.Close()

        Load_Menu(enMenu.Marcacoes)
    End Sub

    Private Sub aceSalas_Click(sender As Object, e As EventArgs) Handles aceSalas.Click
        mFrm.Close()

        Load_Menu(enMenu.Salas)
    End Sub

    Private Sub AceSeries_Click(sender As Object, e As EventArgs) Handles AceSeries.Click
        mFrm.Close()

        Load_Menu(enMenu.Series)
    End Sub

    Private Sub aceTipos_Doc_Click(sender As Object, e As EventArgs) Handles aceTipos_Doc.Click
        mFrm.Close()

        Load_Menu(enMenu.Tipos_Doc)
    End Sub

    Private Sub aceTipos_Exame_Click(sender As Object, e As EventArgs)
        mFrm.Close()

        Load_Menu(enMenu.Tipos_Exame)
    End Sub

    Private Sub aceTipos_Marcacao_Click(sender As Object, e As EventArgs) Handles aceTipos_Marcacao.Click
        mFrm.Close()

        Load_Menu(enMenu.Tipos_Marcacao)
    End Sub

    Private Sub aceTipos_Pagamento_Click(sender As Object, e As EventArgs) Handles aceTipos_Pagamento.Click
        mFrm.Close()

        Load_Menu(enMenu.Tipos_Pagamento)
    End Sub

    Private Sub aceSair_Click(sender As Object, e As EventArgs) Handles aceSair.Click
        End
    End Sub

    Private Sub aceLogout_Click(sender As Object, e As EventArgs) Handles aceLogout.Click
        Me.Hide()
        FrmLogin.Show()
        FrmLogin.UsernameTextBox.Text = ""
        FrmLogin.PasswordTextBox.Text = ""
    End Sub


End Class