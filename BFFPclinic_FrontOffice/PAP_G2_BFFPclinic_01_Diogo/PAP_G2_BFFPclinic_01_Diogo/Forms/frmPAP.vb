Imports System.ComponentModel
Imports System.Diagnostics.CodeAnalysis
Imports System.Runtime.InteropServices.ComTypes
Imports DevExpress.Charts.Native
Imports DevExpress.CodeParser
Imports DevExpress.Data.Helpers
Imports DevExpress.Data.Linq.Helpers
Imports DevExpress.Office
Imports DevExpress.Pdf.Native
Imports DevExpress.Pdf.Native.BouncyCastle.Asn1
Imports DevExpress.PivotGrid.OLAP.AdoWrappers
Imports DevExpress.XtraRichEdit.Import.OpenDocument
Imports Infragistics.Win
Imports Infragistics.Win.Misc
Imports Infragistics.Win.UltraWinGrid


Public Class frmPAP
    Dim mFLG_ESC As String
    Dim mFLG_Novo As Boolean = True

    Dim mLista_Clientes As New List(Of ClsEntidades)
    Dim mLista_Utentes As New List(Of ClsEntidades)

    Dim mLista_TD As New List(Of ClsTipos_Doc)
    Dim mLista_Artigos As New List(Of ViewArt)

    Dim mIndex_TD As Integer = 0

    Dim mIndex As Integer = 0
    Dim mIndex_Clientes As Integer = 0
    Dim mIndex_Utentes As Integer = 0

    Dim mDoc As New ClsDoc
    Dim mTD As New ClsTipos_Doc

    Dim mIndex_Repetida As Integer = -1
    Dim mMaiorStock As Integer = -1

    Dim mRowArtigo As UltraGridRow = Nothing

    Dim mlista_Marcações_a_Pagar As New List(Of ClsMarcacoes)



    Private Sub frmPAP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mFLG_ESC = "S"
        mFLG_Novo = True

        mTD = ClsTipos_Doc.GetTipos_DocByFlag_TD("FC")

        'Load_TD()
        Load_Entidades()
        Load_ucClientes()
        Load_ucUtentes()
        Load_ugLinhas()

        NovoDoc()


        Init_Doc()
        '-----------------------



        mDoc = New ClsDoc(ClsTipos_Doc.GetTipos_DocByFlag_TD("FC"))

        Num_DocTextEdit.Text = mDoc.Num_Doc
        mDoc.Data_Doc = Date.Now

        mDoc.Tipo_Pagamento = "0"
        mDoc.Data_Vencimento = mDoc.Data_Doc
        uceCondPag.SelectedIndex = CInt(mDoc.Tipo_Pagamento)
        uceCondPag.Text = "      Pronto Pagamento"
        uceCondPag.Enabled = True

        Load_Datas()

        mDoc.Designacao = mTD.Descritivo_Impressao

        mDoc.FLG_Tipo_Doc = mTD.FLG_Tipo_Doc

        'mLista_Artigos = ViewArt.GetListaArtigos(mTD.FLG_Entidade)
        get_Artigos_Filtrados()

        Init_UP_DOWN()
        Me.Num_DocTextEdit.Text = mTD.FLG_Tipo_Doc & UP_DOWN.Value.ToString("000") & "/" & mTD.Cod_Serie.Substring(0, 4)

        Load_Artigos()

        Display_Cliente()
        Display_Utente()
        TimerLoadUgLinhas.Interval = 1
        TimerLoadUgLinhas.Start()
    End Sub

    Sub preenche_mDoc()
        mDoc = New ClsDoc(ClsTipos_Doc.GetTipos_DocByFlag_TD("FC"))
        mDoc.Data_Doc = Date.Now
        mDoc.Tipo_Pagamento = "0"
        mDoc.Data_Vencimento = mDoc.Data_Doc
        mDoc.Designacao = mTD.Descritivo_Impressao
        mDoc.FLG_Tipo_Doc = mTD.FLG_Tipo_Doc
    End Sub
    Private Sub TimerLoadUgLinhas_Tick(sender As Object, e As EventArgs) Handles TimerLoadUgLinhas.Tick
        TimerLoadUgLinhas.Stop()
        resize_ugLinhas()
    End Sub
    Sub Load_uceConfPag()
        With uceCondPag
            .Items.Clear()
            .Items.Add("Pronto Pagamento")
            .Items.Add("Pagamento a 30 dias")
            .Items.Add("Pagamento a 60 dias")
            .Items.Add("Pagamento a 90 dias")
            .SelectedIndex = 0
        End With
    End Sub


    Sub Load_Datas()
        lblData_Doc.Text = FormatDateTime(mDoc.Data_Doc, DateFormat.ShortDate)
        uceCondPag.SelectedIndex = CInt(mDoc.Tipo_Pagamento)
        If mTD.FLG_Tipo_Doc = "FC" Then
            mDoc.Data_Vencimento = FormatDateTime(mDoc.Data_Vencimento, DateFormat.ShortDate)
            lblData_Vencimento.Text = FormatDateTime(mDoc.Data_Vencimento, DateFormat.ShortDate)
        Else
            mDoc.Data_Vencimento = "1900-01-01"
            lblData_Vencimento.Text = "      Não Disponível"
        End If

    End Sub

    Sub Load_Entidades()
        mLista_Clientes = ClsEntidades.GetEntidadesBy_FLG("C")
        Config_ucClientes()
        mLista_Utentes = ClsEntidades.GetEntidadesBy_FLG("U")
        Load_ucUtentes()

    End Sub

    Sub Load_ucClientes()
        With ucClientes
            .DataSource = mLista_Clientes
            .DisplayMember = "Cod_Entidade"
            .SelectedRow = ucClientes.Rows(mIndex_Clientes)
        End With
    End Sub
    Sub Load_ucUtentes()
        With ucUtentes
            .DataSource = mLista_Utentes
            .DisplayMember = "Cod_Entidade"
            .SelectedRow = ucUtentes.Rows(mIndex_Utentes)
        End With
    End Sub
    Sub Load_Artigos()
        Config_ucArtigos()

        With ucArtigos
            .DataSource = mLista_Artigos
            .DisplayMember = "Artigo"
            .ValueMember = "Cod_Artigo"
        End With
    End Sub


    'Sub Load_TD()
    '
    '    Config_ucTD()
    '    mLista_TD = ClsTipos_Doc.GetTipos_DocByFlag(mFLG_ESC)
    '
    '    Me.ucTD.DataSource = mLista_TD
    '    Me.ucTD.DisplayMember = "Descritivo_Impressao"
    '   'Me.ucTD.SelectedRow = ucTD.Rows(mIndex_TD)
    '
    '
    'End Sub
    Sub Init_Doc()
        Load_uceConfPag()

        'ucTD.Focus()

        Config_ugLinhas()
        Config_ugQI()
        CMD_DISABLED()
    End Sub
    Sub Init_UP_DOWN()
        With Me.UP_DOWN
            .Minimum = 1
            .Maximum = mTD.Contador + 1
            .Value = .Maximum
        End With
    End Sub

    Private Sub UP_DOWN_Click(sender As Object, e As EventArgs) Handles UP_DOWN.Click
        Select Case UP_DOWN.Value
            Case < UP_DOWN.Maximum
                Me.Num_DocTextEdit.Text = mTD.FLG_Tipo_Doc & UP_DOWN.Value.ToString("000") & "/" & mTD.Cod_Serie.Substring(0, 4)
                Read_Doc()
            Case UP_DOWN.Maximum
                mFLG_Novo = True
                NovoDoc()
                Me.Num_DocTextEdit.Text = mTD.FLG_Tipo_Doc & UP_DOWN.Value.ToString("000") & "/" & mTD.Cod_Serie.Substring(0, 4)
        End Select
    End Sub
    'Private Sub ucTD_AfterCloseUp(sender As Object, e As EventArgs) Handles ucTD.AfterCloseUp, ucTD.Leave
    '
    '    Dim mRow As UltraGridRow = ucTD.ActiveRow
    '
    '    If mRow IsNot Nothing Then
    '        mIndex_TD = ucTD.ActiveRow.Index
    '    Else
    '        mIndex_TD = 0
    '    End If
    '
    '    mTD = mLista_TD(mIndex_TD)
    '
    '    Load_Entidades()
    '    mLista_Entidades = mLista_Entidades.FindAll(Function(x) x.FLG_Entidade = mTD.FLG_Entidade)
    '
    '    mIndex = If(mTD.FLG_Entidade = "C", mIndex_Clientes, mIndex_Fornecedores)
    '
    '    Load_ucClientes()
    '
    '    mDoc = New ClsDoc(mTD)
    '    mFLG_Novo = True
    '
    '    Num_DocTextEdit.Text = mDoc.Num_Doc
    '    mDoc.Data_Doc = Date.Now
    '
    '    If mTD.FLG_Tipo_Doc <> "FC" Then
    '        mDoc.Tipo_Pagamento = "0"
    '        uceCondPag.Text = "Não Disponível"
    '        uceCondPag.Enabled = False
    '    Else
    '        mDoc.Tipo_Pagamento = "0"
    '        mDoc.Data_Vencimento = mDoc.Data_Doc
    '        uceCondPag.SelectedIndex = CInt(mDoc.Tipo_Pagamento)
    '        uceCondPag.Text = "      Pronto Pagamento"
    '        uceCondPag.Enabled = True
    '    End If
    '
    '    Load_Datas()
    '
    '    mDoc.Designacao = mTD.Descritivo_Impressao
    '
    '    mDoc.FLG_Tipo_Doc = mTD.FLG_Tipo_Doc
    '
    '    mLista_Artigos = ViewArt.GetListaArtigos(mTD.FLG_Entidade)
    '
    '    Init_UP_DOWN()
    '    Me.Num_DocTextEdit.Text = mTD.FLG_Tipo_Doc & UP_DOWN.Value.ToString("000") & "/" & mTD.Cod_Serie.Substring(0, 4)
    '
    '    Load_Artigos()
    '    Display_Entidade()
    'End Sub

    'Sub inicio()
    '    Load_Entidades()
    '    Load_ucClientes()
    '    Load_ucUtentes()
    '    mDoc = New ClsDoc("FC")
    '    mFLG_Novo = True
    '    Num_DocTextEdit.Text = mDoc.Num_Doc
    '    mDoc.Data_Doc = Date.Now
    '
    '    mDoc.Tipo_Pagamento = "0"
    '    mDoc.Data_Vencimento = mDoc.Data_Doc
    '    uceCondPag.SelectedIndex = CInt(mDoc.Tipo_Pagamento)
    '    uceCondPag.Text = "      Pronto Pagamento"
    '    uceCondPag.Enabled = True
    '
    '    Load_Datas()
    '
    '    mDoc.Designacao = mTD.Descritivo_Impressao
    '
    '    mDoc.FLG_Tipo_Doc = mTD.FLG_Tipo_Doc
    '
    '    mLista_Artigos = ViewArt.GetListaArtigos(mTD.FLG_Entidade)
    '
    '    Init_UP_DOWN()
    '    Me.Num_DocTextEdit.Text = mTD.FLG_Tipo_Doc & UP_DOWN.Value.ToString("000") & "/" & mTD.Cod_Serie.Substring(0, 4)
    '
    '    Load_Artigos()
    '
    '    Display_Cliente()
    '    Display_Utente()
    'End Sub


    Sub Limpa_Totais()
        Me.lblTotal_Iliquido.Text = 0D
        Me.lblTotal_Desconto.Text = 0D
        Me.lblTotal_IVA.Text = 0D
        Me.lblTotal_Doc.Text = 0D
        Me.lblAcertos.Text = 0D
        Me.lblTotal_A_Pagar.Text = 0D
    End Sub
    Sub Display_Totais()

        mDoc.Totais = New ClsTotais(mDoc.Linhas)

        With mDoc.Totais
            Me.lblTotal_Iliquido.Text = FormatCurrency(.Total_Iliquido)
            Me.lblTotal_Desconto.Text = FormatCurrency(.Total_Desconto)
            Me.lblTotal_IVA.Text = FormatCurrency(.Total_IVA)
            Me.lblTotal_Doc.Text = FormatCurrency(.Total_Doc)
            Me.lblAcertos.Text = FormatCurrency(.Acertos)
            Me.lblTotal_A_Pagar.Text = FormatCurrency(.Total_A_Pagar)
        End With

        Display_QI()
        CMD_DISABLED()
    End Sub

    Sub Config_ugQI()
        With ugQI.DisplayLayout.Bands(0)

            .Override.HeaderClickAction = HeaderClickAction.Select

            .Columns("Num_Doc").Hidden = True
            .Columns("Taxa_IVA").Hidden = True

            .Columns("Tipo_IVA").Hidden = False
            .Columns("Tipo_IVA").Header.Appearance.TextHAlign = HAlign.Center
            .Columns("Tipo_IVA").Header.Caption = "Tipo IVA"
            .Columns("Tipo_IVA").CellAppearance.TextHAlign = HAlign.Center
            .Columns("Tipo_IVA").Width = 35

            .Columns("S_IVA").Hidden = False
            .Columns("S_IVA").Header.Appearance.TextHAlign = HAlign.Center
            .Columns("S_IVA").Header.Caption = "Incid. IVA"
            .Columns("S_IVA").CellAppearance.TextHAlign = HAlign.Right
            .Columns("S_IVA").Width = 80
            .Columns("S_IVA").Format = "c"

            .Columns("V_IVA").Hidden = False
            .Columns("V_IVA").Header.Appearance.TextHAlign = HAlign.Center
            .Columns("V_IVA").Header.Caption = "Valor IVA"
            .Columns("V_IVA").CellAppearance.TextHAlign = HAlign.Right
            .Columns("V_IVA").Width = 80
            .Columns("V_IVA").Format = "c"

        End With
    End Sub

    Sub Config_ucArtigos()
        With ucArtigos.DisplayLayout.Bands(0)

            .Override.HeaderClickAction = HeaderClickAction.Select

            .Columns("Cod_Artigo").Hidden = False
            .Columns("Cod_Artigo").CellAppearance.TextHAlign = HAlign.Center
            .Columns("Cod_Artigo").Header.Appearance.TextHAlign = HAlign.Center
            .Columns("Cod_Artigo").Header.Caption = "Código"
            .Columns("Cod_Artigo").Width = 70


            .Columns("Artigo").Hidden = False
            .Columns("Artigo").CellAppearance.TextHAlign = HAlign.Left
            .Columns("Artigo").Header.Appearance.TextHAlign = HAlign.Center
            .Columns("Artigo").Header.Caption = "Artigo"
            .Columns("Artigo").Width = 400
            .Columns("Artigo").EditorComponent = ucArtigos
        End With
    End Sub

    Sub Config_ucClientes()
        With ucClientes.DisplayLayout.Bands(0)

            .Override.HeaderClickAction = HeaderClickAction.Select

        End With
    End Sub

    Sub Disable_ugLinhas()
        With ugLinhas.DisplayLayout.Bands(0)

            .Columns("Artigo").CellActivation = Activation.NoEdit
            .Columns("sQTD").CellActivation = Activation.NoEdit
            .Columns("sP_Unitario").CellActivation = Activation.NoEdit
            .Columns("sTaxa_Desconto").CellActivation = Activation.NoEdit

        End With
    End Sub

    Sub Config_ugLinhas()
        Try


            With ugLinhas.DisplayLayout.Bands(0)

                .Override.HeaderClickAction = HeaderClickAction.Select

                .Columns("Num_Doc").Hidden = True
                .Columns("Num_Linha").Hidden = True
                .Columns("Quantidade").Hidden = True
                .Columns("P_Unitario").Hidden = True
                .Columns("Taxa_Desconto").Hidden = True
                .Columns("Taxa_IVA").Hidden = True
                .Columns("Valor_Iliquido").Hidden = True
                .Columns("Valor_IVA").Hidden = True
                .Columns("Valor_Desconto").Hidden = True
                .Columns("FLG_Ativo").Hidden = True

                '-------------------------------------------
                .Columns("sNum_Linha").Hidden = False
                .Columns("sNum_Linha").CellAppearance.TextHAlign = HAlign.Center
                .Columns("sNum_Linha").Header.Appearance.TextHAlign = HAlign.Center
                .Columns("sNum_Linha").Header.Caption = "Nº"
                .Columns("sNum_Linha").Width = 30
                .Columns("sNum_Linha").CellActivation = Activation.NoEdit

                .Columns("Cod_Artigo").Hidden = False
                .Columns("Cod_Artigo").CellAppearance.TextHAlign = HAlign.Center
                .Columns("Cod_Artigo").Header.Appearance.TextHAlign = HAlign.Center
                .Columns("Cod_Artigo").Header.Caption = "Código"
                .Columns("Cod_Artigo").Width = 70
                .Columns("Cod_Artigo").CellActivation = Activation.NoEdit




                .Columns("sQTD").Hidden = False
                .Columns("sQTD").CellAppearance.TextHAlign = HAlign.Center
                .Columns("sQTD").Header.Appearance.TextHAlign = HAlign.Center
                .Columns("sQTD").Header.Caption = "QTD"
                .Columns("sQTD").Width = 50
                .Columns("sQTD").CellActivation = Activation.NoEdit

                .Columns("Unidade").Hidden = False
                .Columns("Unidade").CellAppearance.TextHAlign = HAlign.Center
                .Columns("Unidade").Header.Appearance.TextHAlign = HAlign.Center
                .Columns("Unidade").Header.Caption = "Un."
                .Columns("Unidade").Width = 40
                .Columns("Unidade").CellActivation = Activation.NoEdit

                .Columns("sP_Unitario").Hidden = False
                .Columns("sP_Unitario").CellAppearance.TextHAlign = HAlign.Right
                .Columns("sP_Unitario").Header.Appearance.TextHAlign = HAlign.Center
                .Columns("sP_Unitario").Header.Caption = "P.Unitário"
                .Columns("sP_Unitario").Width = 120

                If mTD.FLG_Entidade = "F" Then
                    .Columns("sP_Unitario").CellActivation = Activation.AllowEdit
                Else
                    .Columns("sP_Unitario").CellActivation = Activation.NoEdit
                End If


                .Columns("sTaxa_Desconto").Hidden = False
                .Columns("sTaxa_Desconto").CellAppearance.TextHAlign = HAlign.Center
                .Columns("sTaxa_Desconto").Header.Appearance.TextHAlign = HAlign.Center
                .Columns("sTaxa_Desconto").Header.Caption = "%Dsc"
                .Columns("sTaxa_Desconto").Width = 45
                .Columns("sTaxa_Desconto").CellActivation = Activation.AllowEdit

                .Columns("sTaxa_IVA").Hidden = False
                .Columns("sTaxa_IVA").CellAppearance.TextHAlign = HAlign.Center
                .Columns("sTaxa_IVA").Header.Appearance.TextHAlign = HAlign.Center
                .Columns("sTaxa_IVA").Header.Caption = "%IVA"
                .Columns("sTaxa_IVA").Width = 50
                .Columns("sTaxa_IVA").CellActivation = Activation.NoEdit

                .Columns("sValor_Iliquido").Hidden = False
                .Columns("sValor_Iliquido").CellAppearance.TextHAlign = HAlign.Right
                .Columns("sValor_Iliquido").Header.Appearance.TextHAlign = HAlign.Center
                .Columns("sValor_Iliquido").Header.Caption = "V.Ilíquido"
                .Columns("sValor_Iliquido").Width = 120
                .Columns("sValor_Iliquido").CellActivation = Activation.NoEdit

                .Columns("Artigo").Hidden = False
                .Columns("Artigo").CellAppearance.TextHAlign = HAlign.Left
                .Columns("Artigo").Header.Appearance.TextHAlign = HAlign.Center
                .Columns("Artigo").Header.Caption = "Artigo"
                .Columns("Artigo").Width = 400
                .Columns("Artigo").EditorComponent = ucArtigos
                .Columns("Artigo").CellActivation = Activation.AllowEdit

                .Columns("Artigo").AutoCompleteMode = AutoCompleteMode.Suggest
                .Columns("Artigo").AutoSuggestFilterMode = AutoSuggestFilterMode.Contains


            End With
        Catch ex As Exception

        End Try
    End Sub

    ' Sub Config_ucTD()
    '     With ucTD.DisplayLayout.Bands(0)
    '         .Override.HeaderClickAction = HeaderClickAction.Select
    '
    '         .Columns("FLG_Tipo_Doc").Hidden = True
    '         .Columns("Designacao").Hidden = True
    '         .Columns("FLG_ESC").Hidden = True
    '         .Columns("FLG_DC").Hidden = True
    '         .Columns("FLG_Entidade").Hidden = True
    '         .Columns("FLG_Venda").Hidden = True
    '         .Columns("FLG_Compra").Hidden = True
    '         .Columns("FLG_Stock").Hidden = True
    '         .Columns("Cod_Serie").Hidden = True
    '         .Columns("Contador").Hidden = True
    '         .Columns("FLG_Ativo").Hidden = True
    '
    '
    '         .Columns("Descritivo_Impressao").Hidden = False
    '         .Columns("Descritivo_Impressao").CellAppearance.TextHAlign = HAlign.Left
    '         .Columns("Descritivo_Impressao").Header.Appearance.TextHAlign = HAlign.Center
    '         .Columns("Descritivo_Impressao").Header.Caption = "Documento a Criar"
    '         .Columns("Descritivo_Impressao").Width = 250
    '
    '     End With
    ' End Sub


    Sub Limpa_Cliente()
        Me.NomeClienteTextEdit.Text = ""
        Me.EnderecoClienteTextEdit.Text = ""

        Me.Cod_PostalClienteTextEdit.Text = ""
        Me.NIFTextEdit.Text = ""
        Me.LocalidadeClienteTextEdit.Text = ""
    End Sub

    Sub Limpa_Utente()
        Me.nomeUtenteTextEdit.Text = ""
        Me.EnderecoUtenteTextEdit.Text = ""

        Me.Cod_PostalUtenteTextEdit.Text = ""
        Me.NUSTextEdit.Text = ""
        Me.LocalidadeUtenteTextEdit.Text = ""
    End Sub

    Sub Display_QI()
        mDoc.QI = ClsQI.GetQI(mDoc.Linhas)
        Me.ugQI.DataSource = mDoc.QI
    End Sub

    Sub Display_Cliente()
        Limpa_Cliente()

        Me.NomeClienteTextEdit.Text = mLista_Clientes(mIndex_Clientes).Nome
        Me.EnderecoClienteTextEdit.Text = mLista_Clientes(mIndex_Clientes).Lista_Enderecos(0).Endereco

        Me.Cod_PostalClienteTextEdit.Text = mLista_Clientes(mIndex_Clientes).Lista_Enderecos(0).Cod_Postal
        Me.NIFTextEdit.Text = mLista_Clientes(mIndex_Clientes).NIF
        Me.LocalidadeClienteTextEdit.Text = mLista_Clientes(mIndex_Clientes).Lista_Enderecos(0).Localidade
    End Sub

    Sub Display_Utente()
        Limpa_Utente()

        Me.nomeUtenteTextEdit.Text = mLista_Utentes(mIndex_Utentes).Nome
        Me.EnderecoUtenteTextEdit.Text = mLista_Utentes(mIndex_Utentes).Lista_Enderecos(0).Endereco

        Me.Cod_PostalUtenteTextEdit.Text = mLista_Utentes(mIndex_Utentes).Lista_Enderecos(0).Cod_Postal
        Me.NUSTextEdit.Text = mLista_Clientes(mIndex_Utentes).NIF
        Me.LocalidadeUtenteTextEdit.Text = mLista_Utentes(mIndex_Utentes).Lista_Enderecos(0).Localidade
    End Sub


    Private Sub ucUtente_AfterCloseUp(sender As Object, e As EventArgs) Handles ucUtentes.Leave, ucUtentes.AfterCloseUp
        mDoc.Linhas.Clear()
        NovoDoc()
        Init_Doc()
        preenche_mDoc()
        Dim mRow As UltraGridRow = ucUtentes.ActiveRow

        If mRow IsNot Nothing Then
            mIndex_Utentes = ucUtentes.ActiveRow.Index
        Else
            mIndex_Utentes = 0
        End If

        Display_Utente()
        'Load_ugLinhas()


        ugLinhas.DataSource = mDoc.Linhas

        ugLinhas.Refresh()


        get_Artigos_Filtrados()


    End Sub

    Sub get_Artigos_Filtrados()
        mlista_Marcações_a_Pagar = ClsMarcacoes.GetLista_Cod_Artigos(ucUtentes.SelectedRow.Cells("Cod_Entidade").Text)
        Dim mMarcacao As ClsMarcacoes
        Dim mLista_Artigos_Filtrados As New List(Of ViewArt)
        For Each mMarcacao In mlista_Marcações_a_Pagar
            mLista_Artigos_Filtrados.Add(ViewArt.GetViewArt(mMarcacao.Cod_Artigo, "C"))
        Next

        mLista_Artigos.Clear()
        'For Each item In mLista_Artigos_Filtrados
        '    mLista_Artigos.Add(item)
        'Next
        mLista_Artigos = mLista_Artigos_Filtrados

        ucArtigos.DataSource = mLista_Artigos
        ucArtigos.Refresh()
    End Sub

    Private Sub ucClientes_AfterCloseUp(sender As Object, e As EventArgs) Handles ucClientes.AfterCloseUp, ucClientes.Leave

        Dim mRow As UltraGridRow = ucClientes.ActiveRow

        If mRow IsNot Nothing Then
            mIndex_Clientes = ucClientes.ActiveRow.Index
        Else
            mIndex_Clientes = 0
        End If

        mDoc.Cod_Entidade = mLista_Clientes(mIndex_Clientes).Cod_Entidade

        Display_Cliente()
        'Load_ugLinhas()
        ugLinhas.DataSource = mDoc.Linhas

    End Sub

    Sub Load_ugLinhas()
        Config_ugLinhas()
        ugLinhas.DataSource = mDoc.Linhas
    End Sub


    Sub AFTER_ARTIGO(e As CellEventArgs)
        Dim mIndexCell As Integer = 0
        Dim mIndexArtigo As Integer = 0

        Dim mQTD As Integer = 1
        Dim mDSC As Integer = 0
        mIndexArtigo = mRowArtigo.Index

        mIndexCell = e.Cell.Row.Index

        mDoc.Linhas(mIndexCell) = New ClsLinhas(mDoc.Num_Doc, mIndexCell, mQTD, mDSC, mIndexArtigo, mLista_Artigos(mIndexArtigo))
    End Sub

    Sub SomaQTD()
        Dim mLinha As New ClsLinhas
        mLinha = mDoc.Linhas(mIndex_Repetida)

        'Dim mQTD As Integer = If(mLinha.Quantidade < mLinha.Stock, mLinha.Quantidade + 1, mLinha.Quantidade)
        Dim mQTD As Integer = mLinha.Quantidade + 1
        Dim mPreco As Decimal = mLinha.P_Unitario
        Dim mDSC As Integer = mLinha.Taxa_Desconto
        Dim mIndexArtigo As Integer = mRowArtigo.Index

        mDoc.Linhas(mIndex_Repetida) = New ClsLinhas(mDoc.Num_Doc, mIndex_Repetida, mQTD, mPreco, mDSC, mIndexArtigo, mLista_Artigos(mIndexArtigo))
        ugLinhas.Refresh()
        mIndex_Repetida = -1

        Display_Totais()
        Display_QI()




    End Sub



    Sub AFTER_PRECO(e As CellEventArgs)
        Dim mIndexCell As Integer = 0
        Dim mIndexArtigo As Integer = 0


        Dim mQTD As Integer = 1
        mQTD = CInt(e.Cell.Row.Cells("sQTD").Text)

        Dim mDSC As Integer = 0
        mDSC = CInt(e.Cell.Row.Cells("sTaxa_Desconto").Text)

        Dim mPreco As Decimal = 0D
        mPreco = e.Cell.Text

        mIndexCell = e.Cell.Row.Index

        mIndexArtigo = mDoc.Linhas(mIndexCell).Index_Artigo

        mDoc.Linhas(mIndexCell) = New ClsLinhas(mDoc.Num_Doc, mIndexCell, mQTD, mPreco, mDSC, mIndexArtigo, mLista_Artigos(mIndexArtigo))
    End Sub
    Sub AFTER_QTD(e As CellEventArgs)
        Dim mIndexCell As Integer = 0
        Dim mIndexArtigo As Integer = 0


        Dim mQTD As Integer = 1
        mQTD = e.Cell.Text

        Dim mDSC As Integer = 0
        mDSC = CInt(e.Cell.Row.Cells("sTaxa_Desconto").Text)

        Dim mPreco As Decimal = 0D
        mPreco = CDec(e.Cell.Row.Cells("sP_Unitario").Text)

        mIndexCell = e.Cell.Row.Index

        mIndexArtigo = mDoc.Linhas(mIndexCell).Index_Artigo

        mDoc.Linhas(mIndexCell) = New ClsLinhas(mDoc.Num_Doc, mIndexCell, mQTD, mPreco, mDSC, mIndexArtigo, mLista_Artigos(mIndexArtigo))
    End Sub
    Sub AFTER_DSC(e As CellEventArgs)
        Dim mIndexCell As Integer = 0
        Dim mIndexArtigo As Integer = 0


        Dim mQTD As Integer = 1
        mQTD = CInt(e.Cell.Row.Cells("sQTD").Text)

        Dim mDSC As Integer = 0
        mDSC = e.Cell.Text

        Dim mPreco As Decimal = 0D
        mPreco = CDec(e.Cell.Row.Cells("sP_Unitario").Text)

        mIndexCell = e.Cell.Row.Index

        mIndexArtigo = mDoc.Linhas(mIndexCell).Index_Artigo

        mDoc.Linhas(mIndexCell) = New ClsLinhas(mDoc.Num_Doc, mIndexCell, mQTD, mPreco, mDSC, mIndexArtigo, mLista_Artigos(mIndexArtigo))
    End Sub

    Private Sub ugLinhas_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles ugLinhas.AfterCellUpdate

        Select Case e.Cell.Column.Key
            Case "Artigo"
                AFTER_ARTIGO(e)

            Case "sP_Unitario"
                If mTD.FLG_Entidade = "F" Then
                    AFTER_PRECO(e)
                End If

            Case "sQTD"
                AFTER_QTD(e)

            Case "sTaxa_Desconto"
                AFTER_DSC(e)
        End Select

    End Sub

    Private Sub ucArtigos_RowSelected(sender As Object, e As RowSelectedEventArgs) Handles ucArtigos.RowSelected
        mRowArtigo = e.Row
        'mLista_Artigos.Remove(mLista_Artigos(mRowArtigo.Index))

        'ucArtigos.Refresh()
    End Sub



    Private Sub ucArtigos_AfterCloseUp(sender As Object, e As EventArgs) Handles ucArtigos.AfterCloseUp

    End Sub

    Sub retira_Artigo()
        ' Verifique se mLista_Artigos é diferente de Nothing e contém itens

        If mLista_Artigos IsNot Nothing AndAlso mLista_Artigos.Count > 0 Then
            ' Verifique se mRowArtigo não é Nothing
            If mRowArtigo IsNot Nothing Then
                ' Remova o item da lista usando o índice fornecido por mRowArtigo
                'mRowArtigo = ucArtigos.SelectedRow
                mLista_Artigos.RemoveAt(mRowArtigo.Index)
            End If
        End If

        ' Atualize o controle
        ucArtigos.Refresh()
    End Sub
    Private Sub ugLinhas_KeyDown(sender As Object, e As KeyEventArgs) Handles ugLinhas.KeyDown
        Dim mCell As UltraGridCell = ugLinhas.ActiveCell

        If mCell Is Nothing Then Exit Sub

        Select Case e.KeyValue
            Case Keys.Enter
                Select Case mCell.Column.Key
                    Case "sNum_Linha", "Cod_Artigo"
                        ugLinhas.ActiveCell = ugLinhas.ActiveRow.Cells("Artigo")
                        ugLinhas.PerformAction(UltraGridAction.EnterEditMode)

                    Case "Artigo"
                        ugLinhas.ActiveCell = ugLinhas.ActiveRow.Cells("sQTD")
                        ugLinhas.PerformAction(UltraGridAction.EnterEditMode)

                    Case "sQTD"
                        If mTD.FLG_Entidade = "F" Then
                            ugLinhas.ActiveCell = ugLinhas.ActiveRow.Cells("sP_Unitario")
                            ugLinhas.PerformAction(UltraGridAction.EnterEditMode)
                        Else
                            ugLinhas.ActiveCell = ugLinhas.ActiveRow.Cells("sTaxa_Desconto")
                            ugLinhas.PerformAction(UltraGridAction.EnterEditMode)
                        End If
                    Case "Unidade"
                        ugLinhas.ActiveCell = ugLinhas.ActiveRow.Cells("sTaxa_Desconto")
                        ugLinhas.PerformAction(UltraGridAction.EnterEditMode)

                    Case "sP_Unitario"

                        ugLinhas.ActiveCell = ugLinhas.ActiveRow.Cells("sTaxa_Desconto")
                        ugLinhas.PerformAction(UltraGridAction.EnterEditMode)


                    Case "sTaxa_Desconto", "sTaxa_IVA", "sValor_Iliquido"

                        If ugLinhas.ActiveRow.Cells("Cod_Artigo").Text <> "" Then
                            ugLinhas.PerformAction(UltraGridAction.NextRow)
                            ugLinhas.ActiveCell = ugLinhas.ActiveRow.Cells("Artigo")
                            ugLinhas.PerformAction(UltraGridAction.EnterEditMode)
                        Else
                            ugLinhas.ActiveCell = ugLinhas.ActiveRow.Cells("Artigo")
                            ugLinhas.PerformAction(UltraGridAction.EnterEditMode)
                        End If

                End Select

            Case Keys.PageDown
                ugLinhas.PerformAction(UltraGridAction.PageDownRow)
            Case Keys.PageUp
                ugLinhas.PerformAction(UltraGridAction.PageUpRow)
            Case Keys.Delete
                ASK_Apaga()


        End Select
    End Sub

    Sub Apaga_Linha()
        mDoc.Linhas(ugLinhas.ActiveRow.Index) = New ClsLinhas(mDoc.Num_Doc, ugLinhas.ActiveRow.Index)
        ugLinhas.ActiveCell = ugLinhas.ActiveRow.Cells("Artigo")
        ugLinhas.PerformAction(UltraGridAction.EnterEditMode)
        ugLinhas.Refresh()
        Display_Totais()
    End Sub
    Sub ASK_Apaga()

        If ugLinhas.ActiveRow.Cells("Cod_Artigo").Text = "" Then Exit Sub

        Dim mResposta As MsgBoxResult

        mResposta = MsgBox("Tem a Certeza que Quer APAGAR esta Linha?", MsgBoxStyle.YesNo, "Apagar linha")
        If mResposta = MsgBoxResult.Yes Then Apaga_Linha()
    End Sub

    Private Sub ugLinhas_AfterRowUpdate(sender As Object, e As RowEventArgs) Handles ugLinhas.AfterRowUpdate
        Display_Totais()
        mRowArtigo = Nothing

    End Sub

    Private Sub ugLinhas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ugLinhas.KeyPress
        Dim mCell As UltraGridCell = ugLinhas.ActiveCell

        If mCell Is Nothing Then Exit Sub

        Dim mChar As Char = e.KeyChar

        Select Case mCell.Column.Key

            Case "sQTD"
                If Not (Char.IsDigit(mChar) Or Char.IsControl(mChar)) Then
                    e.Handled = True
                End If
            Case "sP_Unitario"

                If Not (Char.IsDigit(mChar) Or Char.IsControl(mChar) Or mChar = ",") Then
                    e.Handled = True
                End If
            Case "sTaxa_Desconto"

                If Not (Char.IsDigit(mChar) Or Char.IsControl(mChar)) Then
                    e.Handled = True
                End If

        End Select

    End Sub

    Friend Function TESTA_REPETIDAS(ByVal pCod_Artigo As String) As Boolean
        Dim mReturn As Boolean = False

        For Each pLinha As ClsLinhas In mDoc.Linhas
            If pLinha.Cod_Artigo = pCod_Artigo Then
                mIndex_Repetida = pLinha.Num_Linha
                mReturn = True
                Exit For
            End If
        Next

        Return mReturn
    End Function


    Private Sub ugLinhas_BeforeCellUpdate(sender As Object, e As BeforeCellUpdateEventArgs) Handles ugLinhas.BeforeCellUpdate
        Dim mCell As UltraGridCell = ugLinhas.ActiveCell

        If mCell Is Nothing Then Exit Sub

        Select Case mCell.Column.Key
            Case "Artigo"
                mIndex_Repetida = -1
                e.Cancel = TESTA_REPETIDAS(mRowArtigo.Cells("Cod_Artigo").Text)
            Case "sQTD"
                e.Cancel = Valida_QTD(e)
            Case "sP_Unitario"
                e.Cancel = Valida_PRECO(e)

            Case "sTaxa_Desconto"
                e.Cancel = Valida_DSC(e)

        End Select

    End Sub

    Function Valida_QTD(e As BeforeCellUpdateEventArgs) As Boolean
        Dim mReturn As Boolean = False
        Dim mIndexArtigo As Integer = 0

        mMaiorStock = -1

        Dim mCell As UltraGridCell = ugLinhas.ActiveCell
        If mCell Is Nothing Then GoTo mSai

        mIndexArtigo = mDoc.Linhas(mCell.Row.Index).Index_Artigo

        Dim mArtigo As ViewArt = mLista_Artigos(mIndexArtigo)

        Dim mMax As Integer = If(mArtigo.FLG_PS = "P", mArtigo.Stock, 10)

        If e.NewValue > mMax Then mMaiorStock = mMax

        mReturn = Not (e.NewValue >= 1 And e.NewValue <= mMax)

mSai:
        Return mReturn
    End Function

    Function Valida_PRECO(e As BeforeCellUpdateEventArgs) As Boolean
        Dim mReturn As Boolean = False
        Dim mIndexArtigo As Integer = 0

        Dim mPreco As Decimal = 0D

        mIndexArtigo = mDoc.Linhas(e.Cell.Row.Index).Index_Artigo

        mPreco = mLista_Artigos(mIndexArtigo).Preco_Unitario

        Dim mPMin As Decimal = 0D
        Dim mPMax As Decimal = 0D

        mPMin = mPreco - (mPreco * 0.3)
        mPMax = mPreco + (mPreco * 0.3)

        mReturn = Not (e.NewValue >= mPMin And e.NewValue <= mPMax)

        Return mReturn
    End Function
    Function Valida_DSC(e As BeforeCellUpdateEventArgs) As Boolean
        Dim mReturn As Boolean = False

        mReturn = Not (e.NewValue >= 0 And e.NewValue <= 30)

        Return mReturn
    End Function

    Sub Display_Stock()

        Dim mCell As UltraGridCell = ugLinhas.ActiveCell

        If mCell Is Nothing Then
            lblStock.Text = ""
            Exit Sub
        End If

        Dim mRowH As UltraGridRow = mCell.Row
        Dim mStock As Integer = mDoc.Linhas(mRowH.Index).Stock

        lblStock.Text = If(mStock = 0, "", mStock)

    End Sub

    Private Sub ugLinhas_AfterCellActivate(sender As Object, e As EventArgs) Handles ugLinhas.AfterCellActivate

        Display_Stock()
    End Sub

    Private Sub TRETA_AfterCloseUp(sender As Object, e As EventArgs) Handles uceCondPag.AfterCloseUp
        Dim mIndexCP As Integer = uceCondPag.SelectedIndex
        mDoc.Data_Vencimento = mDoc.Data_Doc.AddDays(30 * mIndexCP)
        lblData_Vencimento.Text = FormatDateTime(mDoc.Data_Vencimento, DateFormat.ShortDate)

        ucClientes.Focus()
    End Sub

    Private Sub ugLinhas_BeforeCellDeactivate(sender As Object, e As CancelEventArgs) Handles ugLinhas.BeforeCellDeactivate
        If mIndex_Repetida >= 0 And ugLinhas.ActiveCell.Column.Key = "Artigo" Then
            SomaQTD()

            e.Cancel = True
        End If
        If ugLinhas.ActiveCell.Column.Key = "sQTD" And mMaiorStock <> -1 Then
            ugLinhas.ActiveCell.Value = mMaiorStock.ToString
            mMaiorStock = -1

            e.Cancel = False
        End If
        retira_Artigo()
    End Sub
    Function Testa(pPFS As String) As Boolean
        Dim mReturn As Boolean = False


        mReturn = Not (mDoc.Linhas.FindAll(Function(x) x.Artigo = pPFS).Count > 0)

        Return mReturn
    End Function


    Friend Function Testa_Linhas() As Boolean
        Dim mReturn As Boolean = False

        mReturn = mDoc.Linhas.FindAll(Function(x) x.FLG_Feita).Count > 0

        Return mReturn
    End Function

    Private Sub cms01_Opening(sender As Object, e As CancelEventArgs) Handles cms01.Opening
        With Me.cms01
            .Items("tsmFretes").Enabled = Testa_Linhas() AndAlso Testa("Fretes")
            .Items("tsmPortes").Enabled = Testa_Linhas() AndAlso Testa("Portes")
            .Items("tsmSeguros").Enabled = Testa_Linhas() AndAlso Testa("Seguros")

            .Items("tsmApaga_Linha").Enabled = Testa_Linhas()

        End With
    End Sub
    Sub Insert(pPFS As String)
        Dim mIndexArtigo As Integer = 0
        Dim mIndexCell As Integer = 0

        mIndexArtigo = mLista_Artigos.FindIndex(Function(x) x.Artigo = pPFS)

        Dim mQTD As Integer = 1
        Dim mDSC As Integer = 0

        mIndexCell = ugLinhas.ActiveRow.Index

        ugLinhas.ActiveCell = ugLinhas.ActiveRow.Cells("Artigo")

        With ugLinhas.ActiveCell.Appearance

            .ImageHAlign = HAlign.Left
            .ImageVAlign = VAlign.Middle

            Select Case pPFS

                Case "Portes"
                    .Image = My.Resources.Portes
                Case "Fretes"
                    .Image = My.Resources.Fretes
                Case "Seguros"
                    .Image = My.Resources.Seguros
            End Select

        End With

        mDoc.Linhas(mIndexCell) = New ClsLinhas(mDoc.Num_Doc, mIndexCell, mQTD, mDSC, mIndexArtigo, mLista_Artigos(mIndexArtigo))
        ugLinhas.PerformAction(UltraGridAction.BelowRow)

        Display_Totais()
        Display_QI()

    End Sub

    Sub Verifica_PFS()
        Dim mLinhas As New List(Of ClsLinhas)

        mLinhas = mDoc.Linhas.FindAll(Function(x) x.FLG_Feita)

        mLinhas = mLinhas.FindAll(Function(x) x.Cod_Artigo.Substring(0, 1) = "X")

        If mLinhas.Count <= 0 Then Exit Sub

        For Each pLinhas In mLinhas
            ugLinhas.ActiveRow = ugLinhas.Rows(pLinhas.Num_Linha)

            Select Case pLinhas.Cod_Artigo
                Case "X000001" ' Portes
                    Insert("Portes")
                Case "X000002" ' Fretes
                    Insert("Fretes")
                Case "X000003" ' Seguros
                    Insert("Seguros")
            End Select
        Next

    End Sub



    Sub CMD_DISABLED()

        Me.cmdGrava.Enabled = Testa_Linhas()
        Me.cmdNovo.Enabled = Testa_Linhas()
        Me.cmdImprime.Enabled = Testa_Linhas()

    End Sub

    Private Sub tsmFretes_Click(sender As Object, e As EventArgs) Handles tsmFretes.Click
        Insert("Fretes")
    End Sub
    Private Sub tsmPortesClick(sender As Object, e As EventArgs) Handles tsmPortes.Click
        Insert("Portes")
    End Sub
    Private Sub tsmSeguros_Click(sender As Object, e As EventArgs) Handles tsmSeguros.Click
        Insert("Seguros")
    End Sub
    Private Sub tsmApaga_Linha_Click(sender As Object, e As EventArgs) Handles tsmApaga_Linha.Click
        ASK_Apaga()
    End Sub

    Sub Grava_Doc()
        If Not ClsGrava.Grava_Documento(mDoc, mTD) Then
            MsgBox("Falhou a gravação")
        Else
            Dim mclslinhas As ClsLinhas
            Dim i As Integer = 0
            Dim l As Integer = 0

            For l = 0 To mlista_Marcações_a_Pagar.Count - 1

                For Each mclslinhas In mDoc.Linhas

                    If mclslinhas.Artigo = mlista_Marcações_a_Pagar(l).Artigo Then
                        ClsMarcacoes.Atualiza_Status(mlista_Marcações_a_Pagar(l).Cod_Marcacao)
                        ClsAppointments.Atualiza_Status(mlista_Marcações_a_Pagar(l).Cod_Marcacao)

                    End If
                Next
            Next

            NovoDoc()
            frmMain.open_frmPAP()
        End If

    End Sub
    Private Sub cmdGrava_Click(sender As Object, e As EventArgs) Handles cmdGrava.Click

        Grava_Doc()
    End Sub

    Sub NovoDoc()
        mDoc = New ClsDoc(mTD)
        ugLinhas.DataSource = mDoc.Linhas
        Me.Num_DocTextEdit.Text = ""
        Config_ugLinhas()
        TimerLoadUgLinhas.Start()


        Limpa_Cliente()
        Limpa_Utente()
        Limpa_Totais()
        Display_QI()
        Init_Doc()

    End Sub

    Private Sub cmdNovo_Click(sender As Object, e As EventArgs) Handles cmdNovo.Click
        NovoDoc()
    End Sub

    Sub Read_Doc()
        Dim mNum_Doc As String = Num_DocTextEdit.Text
        mFLG_Novo = False

        mDoc = ClsDoc.GetDocByCod(mNum_Doc)


        Display_Doc()

        Disable_ugLinhas()
    End Sub

    Sub Display_Doc()

        Display_Cliente()
        Display_Utente()
        Display_Totais()
        Display_ugLinhas()
        Display_ugQI()
        Verifica_PFS()

    End Sub
    Sub Display_ugLinhas()
        ugLinhas.DataSource = mDoc.Linhas
        'mDoc.Linhas.Sort(Function(x, y) x.Num_Linha.CompareTo(y.Num_Linha))
        ugLinhas.Refresh()
    End Sub
    Sub Display_ugQI()
        ugQI.DataSource = mDoc.QI
    End Sub

    Private Sub cmdImprime_Click(sender As Object, e As EventArgs) Handles cmdImprime.Click

        If mFLG_Novo Then
            If Not ClsGrava.Grava_Documento(mDoc, mTD) Then
                MsgBox("Falhou a gravação")
                NovoDoc()
                Exit Sub
            End If

        End If

        Dim mReport As New xFAT01
        Dim mxrQI As New xrQI
        Dim mNum_Doc = Num_DocTextEdit.Text

        With mReport

            .ObjectDataSource1.Parameters(0).Value = mNum_Doc
            .XrSubreport1.ReportSource = mxrQI

        End With

        With mxrQI

            .ObjectDataSource1.Parameters(0).Value = mNum_Doc
        End With


        Dim mFrm As New frmReport
        mFrm.DocumentViewer1.DocumentSource = mReport

        mFrm.ShowDialog()

    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub frmPAP_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        resize_ugLinhas()
    End Sub

    Sub resize_ugLinhas()
        Try
            Dim W_Codigo As Integer = ugLinhas.DisplayLayout.Bands(0).Columns("Cod_Artigo").Width
            Dim W_QTD As Integer = ugLinhas.DisplayLayout.Bands(0).Columns("sQTD").Width
            Dim W_P_Unitario As Integer = ugLinhas.DisplayLayout.Bands(0).Columns("sP_Unitario").Width
            Dim W_Un As Integer = ugLinhas.DisplayLayout.Bands(0).Columns("Unidade").Width
            Dim W_Dsc As Integer = ugLinhas.DisplayLayout.Bands(0).Columns("sTaxa_Desconto").Width
            Dim W_IVA As Integer = ugLinhas.DisplayLayout.Bands(0).Columns("sTaxa_IVA").Width
            Dim W_VI As Integer = ugLinhas.DisplayLayout.Bands(0).Columns("sValor_Iliquido").Width
            Dim W_FLG_Feita As Integer = ugLinhas.DisplayLayout.Bands(0).Columns("FLG_Feita").Width
            Dim W_Num As Integer = ugLinhas.DisplayLayout.Bands(0).Columns("sNum_Linha").Width

            ugLinhas.DisplayLayout.Bands(0).Columns("Artigo").Width = Panel_ugLinhas.Width - W_Num - W_Codigo - W_QTD - W_P_Unitario - W_Un - W_Dsc - W_IVA - W_VI - W_FLG_Feita - 20
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub


End Class