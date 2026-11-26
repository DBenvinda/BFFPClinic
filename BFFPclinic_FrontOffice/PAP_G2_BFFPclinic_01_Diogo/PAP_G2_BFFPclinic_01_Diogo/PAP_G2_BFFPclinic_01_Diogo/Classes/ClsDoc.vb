
Imports System.Data.SqlClient
Imports System.Math
Imports DevExpress.Map.Native
Imports DevExpress.Xpo.Helpers
Imports PAP_G2_BFFPclinic_01_Diogo.My

Public Class ClsGrava
    Shared mDB As New SqlConnection
    Shared mCMD As New SqlCommand
    Shared mTR As SqlTransaction

    Public Shared Function Grava_Documento(pDoc As ClsDoc, pTD As ClsTipos_Doc) As Boolean
        Dim mReturn As Boolean = True

        Dim mPreco_Compra As Decimal = 0D
        Dim mStock As Integer = 0
        pDoc.Data_Pagamento = CDate("01/01/1900")


        mDB.ConnectionString = My.Settings.Connection
        mDB.Open()
        mCMD.Connection = mDB

        mTR = mDB.BeginTransaction
        mCMD.Transaction = mTR

        '-------------------
        ' GRAVA_DOC
        '-------------------
        If Not GravaDoc(pDoc) Then
            mTR.Rollback()
            GoTo ERRO
        End If

        '-------------------
        ' GRAVA LINHAS
        '-------------------
        Dim mN As Integer = 0
        For Each pLinha As ClsLinhas In pDoc.Linhas

            If pLinha.FLG_Feita Then
                pLinha.Num_Linha = mN

                If Not GravaLinhas(pLinha) Then
                    mTR.Rollback()
                    GoTo ERRO
                End If

                If pTD.FLG_Stock Then

                    mStock = pLinha.Stock
                    '--------------------------------
                    ' Atualizar o STOCK nos artigos
                    '--------------------------------
                    If pTD.FLG_ESC = "E" Then
                        mPreco_Compra = pLinha.P_Unitario
                        mStock += pLinha.Quantidade
                    Else
                        mPreco_Compra = 0D
                        mStock -= pLinha.Quantidade
                    End If

                    If Not Atualiza_Stock(pLinha.Cod_Artigo, mStock, mPreco_Compra, pTD.FLG_ESC) Then
                        mTR.Rollback()
                        GoTo ERRO
                    End If
                End If
                mN += 1
            End If

        Next
        '-------------------
        ' GRAVA Contador
        '-------------------
        If Not Grava_Contador_Doc(pTD.Cod_Serie) Then
            mTR.Rollback()
            GoTo ERRO
        End If

        mTR.Commit()

ERRO:
        mDB.Close()

        Return mReturn
    End Function

    Public Shared Function GravaDoc(ByVal pNovoDoc As ClsDoc) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pNum_Doc", pNovoDoc.Num_Doc.Substring(0, IIf(Len(pNovoDoc.Num_Doc) > 11, 11, Len(pNovoDoc.Num_Doc))))
        mCMD.Parameters.AddWithValue("@pFLG_Tipo_Doc", pNovoDoc.FLG_Tipo_Doc.Substring(0, IIf(Len(pNovoDoc.FLG_Tipo_Doc) > 3, 3, Len(pNovoDoc.FLG_Tipo_Doc))))
        mCMD.Parameters.AddWithValue("@pDesignacao", pNovoDoc.Designacao.Substring(0, IIf(Len(pNovoDoc.Designacao) > 50, 50, Len(pNovoDoc.Designacao))))
        mCMD.Parameters.AddWithValue("@pData_Doc", pNovoDoc.Data_Doc)
        mCMD.Parameters.AddWithValue("@pCod_Entidade", pNovoDoc.Cod_Entidade.Substring(0, IIf(Len(pNovoDoc.Cod_Entidade) > 5, 5, Len(pNovoDoc.Cod_Entidade))))
        mCMD.Parameters.AddWithValue("@pTaxa_Desconto", pNovoDoc.Taxa_Desconto)
        mCMD.Parameters.AddWithValue("@pData_Vencimento", pNovoDoc.Data_Vencimento)
        mCMD.Parameters.AddWithValue("@pFLG_Pago", pNovoDoc.FLG_Pago)
        mCMD.Parameters.AddWithValue("@pTipo_Pagamento", pNovoDoc.Tipo_Pagamento.Substring(0, IIf(Len(pNovoDoc.Tipo_Pagamento) > 30, 30, Len(pNovoDoc.Tipo_Pagamento))))
        mCMD.Parameters.AddWithValue("@pData_Pagamento", pNovoDoc.Data_Pagamento)
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoDoc.FLG_Ativo)


        mStrSQL = "INSERT INTO Doc "
        mStrSQL += "("
        mStrSQL += "Num_Doc,"
        mStrSQL += "FLG_Tipo_Doc,"
        mStrSQL += "Designacao,"
        mStrSQL += "Data_Doc,"
        mStrSQL += "Cod_Entidade,"
        mStrSQL += "Taxa_Desconto,"
        mStrSQL += "Data_Vencimento,"
        mStrSQL += "FLG_Pago,"
        mStrSQL += "Tipo_Pagamento,"
        mStrSQL += "Data_Pagamento,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pNum_Doc,"
        mStrSQL += "@pFLG_Tipo_Doc,"
        mStrSQL += "@pDesignacao,"
        mStrSQL += "@pData_Doc,"
        mStrSQL += "@pCod_Entidade,"
        mStrSQL += "@pTaxa_Desconto,"
        mStrSQL += "@pData_Vencimento,"
        mStrSQL += "@pFLG_Pago,"
        mStrSQL += "@pTipo_Pagamento,"
        mStrSQL += "@pData_Pagamento,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL

        Try
            mCMD.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("GravaDoc:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        Return mReturn

    End Function

    Public Shared Function GravaLinhas(ByVal pNovoLinhas As ClsLinhas) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pNum_Doc", pNovoLinhas.Num_Doc.Substring(0, IIf(Len(pNovoLinhas.Num_Doc) > 11, 11, Len(pNovoLinhas.Num_Doc))))
        mCMD.Parameters.AddWithValue("@pNum_Linha", pNovoLinhas.Num_Linha)
        mCMD.Parameters.AddWithValue("@pCod_Artigo", pNovoLinhas.Cod_Artigo.Substring(0, IIf(Len(pNovoLinhas.Cod_Artigo) > 8, 8, Len(pNovoLinhas.Cod_Artigo))))
        mCMD.Parameters.AddWithValue("@pQuantidade", pNovoLinhas.Quantidade)
        mCMD.Parameters.AddWithValue("@pP_Unitario", pNovoLinhas.P_Unitario)
        mCMD.Parameters.AddWithValue("@pTaxa_Desconto", pNovoLinhas.Taxa_Desconto)
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoLinhas.FLG_Ativo)


        mStrSQL = "INSERT INTO Linhas "
        mStrSQL += "("
        mStrSQL += "Num_Doc,"
        mStrSQL += "Num_Linha,"
        mStrSQL += "Cod_Artigo,"
        mStrSQL += "Quantidade,"
        mStrSQL += "P_Unitario,"
        mStrSQL += "Taxa_Desconto,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pNum_Doc,"
        mStrSQL += "@pNum_Linha,"
        mStrSQL += "@pCod_Artigo,"
        mStrSQL += "@pQuantidade,"
        mStrSQL += "@pP_Unitario,"
        mStrSQL += "@pTaxa_Desconto,"
        mStrSQL += "1"
        mStrSQL += ")"

        mCMD.CommandText = mStrSQL

        Try
            mCMD.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("GravaLinhas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        Return mReturn

    End Function

    Public Shared Function Atualiza_Stock(ByVal pCod_Artigo As String, ByVal pStock As String, pPreco_Unitario As Decimal, pFLG_ESC As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mData_Entrada As Date = Date.Now
        Dim mData_Saida As Date = Date.Now

        Dim mStrSQL As String

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pStock", pStock)
        mCMD.Parameters.AddWithValue("@pCod_Artigo", pCod_Artigo)
        If pFLG_ESC = "E" Then
            pStock += 1
            mCMD.Parameters.AddWithValue("@pPreco_Compra", pPreco_Unitario)
            mCMD.Parameters.AddWithValue("@pData_Ultima_Entrada", mData_Entrada)
        Else
            pStock -= 1
            mCMD.Parameters.AddWithValue("@pData_Ultima_Venda", mData_Saida)
        End If


        mStrSQL = "UPDATE Artigos SET "

        If pFLG_ESC = "E" Then
            mStrSQL += "Preco_Compra=@pPreco_Compra,"
            mStrSQL += "Data_Ultima_Entrada=@pData_Ultima_Entrada,"
        Else
            mStrSQL += "Data_Ultima_Venda=@pData_Ultima_Venda,"
        End If

        mStrSQL += "Stock=@pStock "
        mStrSQL += "WHERE Cod_Artigo=@pCod_Artigo"



        mCMD.CommandText = mStrSQL

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Atualiza Stock:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try


        Return mReturn

    End Function

    Public Shared Function Grava_Contador_Doc(ByVal pCod_Serie As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Serie", pCod_Serie)

        mStrSQL = "UPDATE Series SET "
        mStrSQL += "Contador=Contador+1 "
        mStrSQL += "WHERE Cod_Serie=@pCod_Serie"

        mCMD.CommandText = mStrSQL

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Grava COntador Doc:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        Return mReturn

    End Function
End Class

Public Class ClsQI
    Public Property Num_Doc As String
    Public Property Tipo_IVA As String
    Public Property Taxa_IVA As Integer
    Public Property S_IVA As Decimal
    Public Property V_IVA As Decimal


    Sub New()

    End Sub

    Sub New(pTaxa_IVA As String, pLinhas As List(Of ClsLinhas))

        Dim mS_IVA As Decimal = 0D
        Dim mV_IVA As Decimal = 0D


        For Each pLinha As ClsLinhas In pLinhas
            If pLinha.Taxa_IVA = pTaxa_IVA And pLinha.Cod_Artigo <> "" Then

                mS_IVA += (pLinha.Valor_Iliquido - pLinha.Valor_Desconto)
                mV_IVA += pLinha.Valor_IVA

            End If
        Next

        Num_Doc = pLinhas(0).Num_Doc
        Taxa_IVA = pTaxa_IVA
        Tipo_IVA = Taxa_IVA.ToString & "% "
        S_IVA = Round(mS_IVA, 1)
        V_IVA = Round(mV_IVA, 1)

    End Sub

    Friend Shared Function GetQI(pLinhas As List(Of ClsLinhas)) As List(Of ClsQI)
        Dim mReturn As New List(Of ClsQI)
        Dim mListaIVA As New List(Of ClsIVA)

        mListaIVA = ClsIVA.GetIVA

        For Each pIVA As ClsIVA In mListaIVA

            Dim mQI As New ClsQI(pIVA.Taxa_IVA, pLinhas)

            If mQI.S_IVA > 0D Then
                mReturn.Add(mQI)
            End If

        Next

        Return mReturn
    End Function

End Class

Public Class ClsTotais
    Public Property Total_Iliquido As Decimal
    Public Property Total_Desconto As Decimal
    Public Property Total_IVA As Decimal
    Public Property Total_Doc As Decimal
    Public Property Acertos As Decimal
    Public Property Total_A_Pagar As Decimal

    Sub New()

    End Sub
    Sub New(pLinhas As List(Of ClsLinhas))

        Total_Iliquido = pLinhas.Sum(Function(x) x.Valor_Iliquido)
        Total_Desconto = pLinhas.Sum(Function(x) x.Valor_Desconto)
        Total_IVA = pLinhas.Sum(Function(x) x.Valor_IVA)
        Total_Doc = (Total_Iliquido - Total_Desconto) + Total_IVA
        Acertos = 0D
        Total_A_Pagar = Total_Doc + Acertos

    End Sub

End Class



''' <summary>
'''      Classe ClsDoc Classe da Tabela Doc
'''      Gerado em 20/03/2023 10:10:43
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class ClsDoc


    ' -----------------------------------------
    ' Property's da tabela Doc
    ' -----------------------------------------

    Public Property Num_Doc As String                                       ' Len: 11 - SQL_Type: nvarchar
    Public Property FLG_Tipo_Doc As String                                  ' Len:  3 - SQL_Type: nvarchar
    Public Property Designacao As String                                    ' Len: 50 - SQL_Type: nvarchar
    Public Property Data_Doc As Date                                        ' SQL_Type: smalldatetime
    Public Property Cod_Entidade As String                                  ' Len:  5 - SQL_Type: nvarchar
    Public ReadOnly Property Nome As String
        Get
            Return If(Cod_Entidade = "", "", ClsEntidades.GetEntidadesByCod(Cod_Entidade).Nome)
        End Get
    End Property

    Public Property Entidade As New ClsEntidades

    Public Property Taxa_Desconto As Integer                                ' SQL_Type: smallint
    Public Property Data_Vencimento As Date                                 ' SQL_Type: smalldatetime
    Public Property FLG_Pago As Boolean                                     ' SQL_Type: bit
    Public Property Tipo_Pagamento As String                                ' Len: 30 - SQL_Type: nvarchar
    Public Property Data_Pagamento As Date                                  ' SQL_Type: smalldatetime

    Public Property Linhas As List(Of ClsLinhas)
    Public Property Totais As ClsTotais
    Public Property QI As New List(Of ClsQI)
    Public Property Empresa As ClsEmpresas
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()

    End Sub

    Sub New(pTD As ClsTipos_Doc)
        Num_Doc = pTD.FLG_Tipo_Doc & (pTD.Contador + 1).ToString("000") & "/" & pTD.Cod_Serie.Substring(0, 4)
        Linhas = Init_Linhas(Num_Doc, pTD.FLG_Entidade)
        Empresa = ClsEmpresas.GetEmpresasByCod("1")
    End Sub

    Friend Shared Function Init_Linhas(pNum_Doc As String, pFLG_Entidade As String) As List(Of ClsLinhas)
        Dim mLista As New List(Of ClsLinhas)

        For n As Integer = 0 To My.Settings.MAX_LINHAS - 1
            Dim mLinha As New ClsLinhas
            With mLinha
                .Num_Doc = pNum_Doc
                .Num_Linha = (n).ToString("00")
                .Cod_Artigo = ""
                .Quantidade = 0
                .Taxa_Desconto = 0
                .FLG_Entidade = pFLG_Entidade

            End With
            mLista.Add(mLinha)
        Next



        Return mLista
    End Function



    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    'Friend Shared Function GetNovoCodigo() As String

    'Return "D" & ClsEmpresas.GetContador(enCont.Doc).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

    'End Function


    ''' <summary>
    '''      Function GetDoc() Método para devolver a Lista de Doc
    '''      Gerado em 20/03/2023 10:10:43
    ''' </summary>
    ''' <returns>
    '''      mListaDoc
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetDoc() As List(Of clsDoc)
        Dim mListaDoc As new List(Of clsDoc)

        Dim mStrSQL as String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Num_Doc,'') As Num_Doc,"
        mStrSQL += "ISNULL(FLG_Tipo_Doc,'') As FLG_Tipo_Doc,"
        mStrSQL += "ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(Data_Doc,0) As Data_Doc,"
        mStrSQL += "ISNULL(Cod_Entidade,'') As Cod_Entidade,"
        mStrSQL += "ISNULL(Taxa_Desconto,0) As Taxa_Desconto,"
        mStrSQL += "ISNULL(Data_Vencimento,0) As Data_Vencimento,"
        mStrSQL += "ISNULL(FLG_Pago,1) As FLG_Pago,"
        mStrSQL += "ISNULL(Tipo_Pagamento,'') As Tipo_Pagamento,"
        mStrSQL += "ISNULL(Data_Pagamento,0) As Data_Pagamento,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Doc "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsDoc As New ClsDoc

            With mClsDoc
                .Num_Doc = mRDR.GetString(mRDR.GetOrdinal("Num_Doc"))
                .FLG_Tipo_Doc = mRDR.GetString(mRDR.GetOrdinal("FLG_Tipo_Doc"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .Data_Doc = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Doc"))
                .Cod_Entidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Entidade"))
                .Taxa_Desconto = mRDR.Getvalue(mRDR.GetOrdinal("Taxa_Desconto"))
                .Data_Vencimento = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Vencimento"))
                .FLG_Pago = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Pago"))
                .Tipo_Pagamento = mRDR.GetString(mRDR.GetOrdinal("Tipo_Pagamento"))
                .Data_Pagamento = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Pagamento"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaDoc.add(mClsDoc)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaDoc
    End Function


    ''' <summary>
    '''      Function GetDocByCod(ByVal pNum_Doc As String) Método para decolver uma Classe de Doc
    '''      Gerado em 20/03/2023 10:10:43
    ''' </summary>
    ''' <returns>
    '''      mClsDoc
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetDocByCod(ByVal pNum_Doc As String) As ClsDoc
        Dim mClsDoc As New ClsDoc
        Dim mFLG_Entidade As String = ""

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pNum_Doc", pNum_Doc)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Num_Doc,'') As Num_Doc,"
        mStrSQL += "ISNULL(FLG_Tipo_Doc,'') As FLG_Tipo_Doc,"
        mStrSQL += "ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(Data_Doc,0) As Data_Doc,"
        mStrSQL += "ISNULL(Cod_Entidade,'') As Cod_Entidade,"
        mStrSQL += "ISNULL(Taxa_Desconto,0) As Taxa_Desconto,"
        mStrSQL += "ISNULL(Data_Vencimento,0) As Data_Vencimento,"
        mStrSQL += "ISNULL(FLG_Pago,1) As FLG_Pago,"
        mStrSQL += "ISNULL(Tipo_Pagamento,'') As Tipo_Pagamento,"
        mStrSQL += "ISNULL(Data_Pagamento,0) As Data_Pagamento,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Doc "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Num_Doc=@pNum_Doc"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsDoc
                .Num_Doc = mRDR.GetString(mRDR.GetOrdinal("Num_Doc"))
                .FLG_Tipo_Doc = mRDR.GetString(mRDR.GetOrdinal("FLG_Tipo_Doc"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .Data_Doc = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Doc"))
                .Cod_Entidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Entidade"))
                .Taxa_Desconto = mRDR.GetValue(mRDR.GetOrdinal("Taxa_Desconto"))
                .Data_Vencimento = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Vencimento"))
                .FLG_Pago = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Pago"))
                .Tipo_Pagamento = mRDR.GetString(mRDR.GetOrdinal("Tipo_Pagamento"))
                .Data_Pagamento = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Pagamento"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))

                mFLG_Entidade = .Cod_Entidade.Substring(0, 1)
                .Linhas = ClsLinhas.GetListaLinhas(.Num_Doc, mFLG_Entidade)
                .Totais = New ClsTotais(.Linhas)
                .QI = ClsQI.GetQI(.Linhas)
                .Empresa = ClsEmpresas.GetEmpresasByCod("1")
                .Entidade = ClsEntidades.GetEntidadesByCod(.Cod_Entidade)
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsDoc
    End Function


    ''' <summary>
    '''      Function ModificaDoc(ByVal pClsDoc As ClsDoc) Método para Modificar a TABELA Doc
    '''      Gerado em 20/03/2023 10:10:43
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ModificaDoc(ByVal pClsDoc As ClsDoc) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL as String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pNum_Doc", pClsDoc.Num_Doc.Substring(0, IIf(Len(pClsDoc.Num_Doc) > 11, 11, Len(pClsDoc.Num_Doc))))
        mCMD.Parameters.AddWithValue("@pFLG_Tipo_Doc", pClsDoc.FLG_Tipo_Doc.Substring(0, IIf(Len(pClsDoc.FLG_Tipo_Doc) > 3, 3, Len(pClsDoc.FLG_Tipo_Doc))))
        mCMD.Parameters.AddWithValue("@pDesignacao", pClsDoc.Designacao.Substring(0, IIf(Len(pClsDoc.Designacao) > 50, 50, Len(pClsDoc.Designacao))))
        mCMD.Parameters.AddWithValue("@pData_Doc", pClsDoc.Data_Doc)
        mCMD.Parameters.AddWithValue("@pCod_Entidade", pClsDoc.Cod_Entidade.Substring(0, IIf(Len(pClsDoc.Cod_Entidade) > 5, 5, Len(pClsDoc.Cod_Entidade))))
        mCMD.Parameters.AddWithValue("@pTaxa_Desconto", pClsDoc.Taxa_Desconto)
        mCMD.Parameters.AddWithValue("@pData_Vencimento", pClsDoc.Data_Vencimento)
        mCMD.Parameters.AddWithValue("@pFLG_Pago", pClsDoc.FLG_Pago)
        mCMD.Parameters.AddWithValue("@pTipo_Pagamento", pClsDoc.Tipo_Pagamento.Substring(0, IIf(Len(pClsDoc.Tipo_Pagamento) > 30, 30, Len(pClsDoc.Tipo_Pagamento))))
        mCMD.Parameters.AddWithValue("@pData_Pagamento", pClsDoc.Data_Pagamento)


        mStrSQL = "UPDATE Doc SET "
        mStrSQL += "FLG_Tipo_Doc=@pFLG_Tipo_Doc,"
        mStrSQL += "Designacao=@pDesignacao,"
        mStrSQL += "Data_Doc=@pData_Doc,"
        mStrSQL += "Cod_Entidade=@pCod_Entidade,"
        mStrSQL += "Taxa_Desconto=@pTaxa_Desconto,"
        mStrSQL += "Data_Vencimento=@pData_Vencimento,"
        mStrSQL += "FLG_Pago=@pFLG_Pago,"
        mStrSQL += "Tipo_Pagamento=@pTipo_Pagamento,"
        mStrSQL += "Data_Pagamento=@pData_Pagamento "
        mStrSQL += "WHERE Num_Doc=@pNum_Doc"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            Msgbox("ModificaDoc:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function






    ''' <summary>
    '''      Function ApagaDoc(ByVal pNum_Doc As String) Método para Apagar um Registo da Tabela Doc
    '''      Gerado em 20/03/2023 10:10:43
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ApagaDoc(ByVal pNum_Doc As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL as String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pNum_Doc", pNum_Doc)


        mStrSQL = "UPDATE Doc SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Num_Doc=@pNum_Doc"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            Msgbox("ApagaDoc:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class

