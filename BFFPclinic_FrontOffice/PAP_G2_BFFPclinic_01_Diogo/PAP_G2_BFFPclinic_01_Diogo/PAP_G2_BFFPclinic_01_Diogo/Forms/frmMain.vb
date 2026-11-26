Imports DevExpress.CodeParser
Imports DevExpress.Pdf.Native.BouncyCastle.Asn1.X509.Qualified
Imports DevExpress.PivotGrid.OLAP.AdoWrappers
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.FluentDesignSystem
Imports DevExpress.XtraBars.Navigation

Public Enum enMenu
    Entidades
    Fatura
    Paises
    Artigos
    Marcacoes
    Enderecos
End Enum

Public Class frmMain
    Public Utilizador As String '= FrmLogin.Utilizador
    Dim mContentor As New FluentDesignFormContainer
    Dim mFrm As New Form

    Sub Load_Menu(penMenu As enMenu, Optional ptag As String = "", Optional pcod_TM As String = "")


        Select Case penMenu
            Case enMenu.Entidades
                mFrm = New frmEntidades
            Case enMenu.Fatura
                mFrm = New frmPAP
            Case enMenu.Marcacoes

                Dim mfrmMarcacoes As New frmMarcacoes
                mfrmMarcacoes.Tag = ptag
                mfrmMarcacoes.mcod_TM = pcod_TM

                If ptag = ClsEntidades.GetEspecialidadebyUtilizador(Utilizador) Or Utilizador.Substring(0, 3) = "Adm" Or Utilizador.Substring(0, 3) = "Rec" Then
                    mFrm = mfrmMarcacoes

                Else
                    MsgBox("Sem Permissão", MsgBoxStyle.Information, "BFFP Clinic")
                    Exit Sub
                End If
        End Select
        mFrm.TopLevel = False
        mFrm.FormBorderStyle = FormBorderStyle.None
        mFrm.Dock = DockStyle.Fill

        mFrm.Parent = mContentor

        mFrm.Show()


    End Sub

    'Sub utilizador()
    '    FrmLogin.User.Substring(0, 3)
    '    Dim Utilizador As String = FrmLogin.User.Substring(0, 3)
    'End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmLogin.Show()
        Me.Hide()
        mContentor = Me.FluentDesignFormContainer1
        load_grupo_Consultas()
        load_grupo_Exames()
        load_Grupo_Operaçoes()

    End Sub

    Public Sub preenche_Utilizador()
        LblUtilizador.Text = Utilizador
    End Sub


    Private Sub aceLogout_Click(sender As Object, e As EventArgs) Handles aceLogout.Click
        Me.Hide()
        FrmLogin.Show()
        FrmLogin.UsernameTextBox.Text = ""
        FrmLogin.UsernameTextBox.Focus()
        FrmLogin.PasswordTextBox.Text = ""

    End Sub


    Sub load_grupo_Consultas()
        Dim mlistaEspecialidades As List(Of ClsEspecialidades) = ClsEspecialidades.GetEspecialidades
        For Each linha As ClsEspecialidades In mlistaEspecialidades
            Dim mitem As New AccordionControlElement
            mitem.Text = linha.Designacao
            mitem.Tag = "TM001"
            If mitem.Text <> "N/A" And linha.FLG_Consultas = True Then
                grupo_Consultas.Elements.Add(mitem)
                AddHandler mitem.Click, AddressOf Item_Click
            End If

        Next

    End Sub

    Sub load_grupo_Exames()
        Dim mlistaEspecialidades As List(Of ClsEspecialidades) = ClsEspecialidades.GetEspecialidades
        For Each linha As ClsEspecialidades In mlistaEspecialidades
            Dim mitem As New AccordionControlElement
            mitem.Text = linha.Designacao
            mitem.Tag = "TM003"
            'mitem.Appearance.Default.Font.Size = 12
            If mitem.Text <> "N/A" And linha.FLG_Exames = True Then
                grupo_exames.Elements.Add(mitem)
                AddHandler mitem.Click, AddressOf Item_Click
            End If

        Next

    End Sub
    Sub load_Grupo_Operaçoes()
        Dim mlistaEspecialidades As List(Of ClsEspecialidades) = ClsEspecialidades.GetEspecialidades
        For Each linha As ClsEspecialidades In mlistaEspecialidades
            Dim mitem As New AccordionControlElement
            mitem.Text = linha.Designacao
            mitem.Tag = "TM002"
            If mitem.Text <> "N/A" And linha.FLG_Operacoes Then
                Grupo_Operacoes.Elements.Add(mitem)
                AddHandler mitem.Click, AddressOf Item_Click
            End If

        Next
    End Sub
    Sub Item_Click(sender As Object, e As EventArgs)
        Dim mitem As AccordionControlElement = DirectCast(sender, AccordionControlElement)
        Console.WriteLine("Item clicado" & mitem.Text)
        Open_frmMarcacoes(sender.text, sender.tag)



    End Sub

    Sub Open_frmMarcacoes(ptag As String, pcod_TM As String)

        mFrm.Close()

        Load_Menu(enMenu.Marcacoes, ptag, pcod_TM)
    End Sub
    Private Sub aceEntidades_Click(sender As Object, e As EventArgs) Handles aceEntidades.Click
        mFrm.Close()

        Load_Menu(enMenu.Entidades)



    End Sub
    Private Sub aceFatura_Click(sender As Object, e As EventArgs) Handles aceFatura.Click
        If Utilizador.Substring(0, 3) = "Adm" Or Utilizador.Substring(0, 3) = "Rec" Then
            open_frmPAP()
        Else
            MsgBox("Sem Permissão")
        End If

    End Sub

    Sub open_frmPAP()
        mFrm.Close()

        Load_Menu(enMenu.Fatura)
    End Sub

    Private Sub AcSair_Click(sender As Object, e As EventArgs) Handles acSair.Click
        End
    End Sub

    'Private Sub aceMarcacoes_Click(sender As Object, e As EventArgs) Handles grupo_marcacoes.Click
    '    mFrm.Close()

    '    Load_Menu(enMenu.Marcacoes)
    'End Sub
End Class