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
End Enum

Public Class frmMain
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
                mFrm = mfrmMarcacoes
        End Select

        mFrm.TopLevel = False
        mFrm.FormBorderStyle = FormBorderStyle.None
        mFrm.Dock = DockStyle.Fill

        mFrm.Parent = mContentor

        mFrm.Show()

    End Sub


    Private Sub aceSair_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mContentor = Me.FluentDesignFormContainer1
        load_grupo_Consultas()
        load_grupo_Exames()
        load_Grupo_Operaçoes()
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
        mFrm.Close()

        Load_Menu(enMenu.Fatura)
    End Sub

    Private Sub FluentDesignFormContainer1_Click(sender As Object, e As EventArgs) Handles FluentDesignFormContainer1.Click

    End Sub

    'Private Sub aceMarcacoes_Click(sender As Object, e As EventArgs) Handles grupo_marcacoes.Click
    '    mFrm.Close()

    '    Load_Menu(enMenu.Marcacoes)
    'End Sub

    Private Sub AccordionControlElement2_Click(sender As Object, e As EventArgs) Handles grupo_Faturaçao.Click

    End Sub

    Private Sub AccordionControlElement1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub aceReports_Click(sender As Object, e As EventArgs) Handles aceReports.Click

    End Sub
End Class