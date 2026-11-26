
Imports System.Data.SqlClient
Imports DevExpress.Utils.Extensions
Imports DevExpress.XtraRichEdit.API.Native

''' <summary>
'''      Classe ClsLinhas Classe da Tabela Linhas
'''      Gerado em 20/03/2023 10:10:44
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class ClsLinhas


    ' -----------------------------------------
    ' Property's da tabela Linhas
    ' -----------------------------------------

    Public Property Num_Doc As String                                       ' Len: 11 - SQL_Type: nvarchar

    Public FLG_Entidade As String
    Public Property Num_Linha As Integer                                    ' SQL_Type: smallint
    Public ReadOnly Property sNum_Linha As String
        Get
            sNum_Linha = (Num_Linha + 1).ToString("00")
        End Get
    End Property
    Public Property Cod_Artigo As String                                    ' Len:  8 - SQL_Type: nvarchar

    Private cArtigo As ViewArt

    Private _Artigo As String
    Public Property Artigo As String
        Get
            Return (If(Cod_Artigo = "", "", Trim(cArtigo.Artigo)))
        End Get
        Set(value As String)

            _Artigo = value
        End Set
    End Property

    Public Property Quantidade As Integer                                   ' SQL_Type: smallint
    Public Property sQTD As String

    Private _P_unitario As Decimal
    Public Property P_Unitario As Decimal                                   ' SQL_Type: numeric
        Get

            If _sP_Unitario = "" Then
                Return If(Cod_Artigo = "", 0D, cArtigo.Preco_Unitario)
            Else
                Return If(Cod_Artigo = "", 0D, CDec(_sP_Unitario))
            End If

        End Get
        Set(value As Decimal)
            _P_unitario = value
        End Set
    End Property

    Private _sP_Unitario As String = ""
    Public Property sP_Unitario As String
        Get
            sP_Unitario = If(Cod_Artigo = "", "", FormatCurrency(P_Unitario).ToString)
        End Get
        Set(value As String)
            _sP_Unitario = value
        End Set
    End Property

    Public ReadOnly Property Unidade As String
        Get
            Unidade = If(Cod_Artigo = "", "", "Un.")
        End Get
    End Property

    Public Property Taxa_Desconto As Integer                                ' SQL_Type: smallint
    Public Property sTaxa_Desconto As String

    Public ReadOnly Property Taxa_IVA As Integer
        Get
            Return If(Cod_Artigo = "", 0, cArtigo.Taxa_IVA)
        End Get
    End Property

    Public ReadOnly Property sTaxa_IVA As String
        Get
            sTaxa_IVA = If(Cod_Artigo = "", "", Taxa_IVA.ToString("00"))
        End Get
    End Property

    Public ReadOnly Property Valor_Iliquido As Decimal
        Get
            Return If(Cod_Artigo = "", 0D, Quantidade * P_Unitario)
        End Get
    End Property

    Public ReadOnly Property sValor_Iliquido As String
        Get
            Return If(Cod_Artigo = "", "", FormatCurrency(Valor_Iliquido.ToString))
        End Get
    End Property
    Public ReadOnly Property Valor_IVA As Decimal
        Get
            Return If(Cod_Artigo = "", 0D, ((Quantidade * P_Unitario) - Valor_Desconto) * (Taxa_IVA / 100))
        End Get
    End Property
    Public ReadOnly Property Valor_Desconto As Decimal
        Get
            Return If(Cod_Artigo = "", 0D, ((Quantidade * P_Unitario) * (Taxa_Desconto) / 100))
        End Get
    End Property

    Public ReadOnly Property FLG_Feita As Boolean
        Get
            Return If(Cod_Artigo = "", False, True)
        End Get
    End Property

    Public Stock As Integer

    Public Index_Artigo As Integer
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit

    Sub New()
    End Sub
    Sub New(pDoc As String, pLinha As Integer)
        Num_Doc = pDoc
        Num_Linha = pLinha
        Cod_Artigo = ""
        Artigo = " "
        Stock = 0
        Index_Artigo = 0
    End Sub
    ''' <summary>
    ''' AFTER ARTIGO
    ''' </summary>
    ''' <param name="pNum_Doc"></param>
    ''' <param name="pLinha"></param>
    ''' <param name="pQTD"></param>
    ''' <param name="pDSC"></param>
    ''' <param name="pArtigo"></param>
    Sub New(pNum_Doc As String, pLinha As Integer, pQTD As Integer, pDSC As Integer, pIndex_Artigo As Integer, pArtigo As ViewArt)

        Num_Doc = pNum_Doc
        FLG_Entidade = pArtigo.FLG_Entidade
        Num_Linha = pLinha
        Cod_Artigo = pArtigo.Cod_Artigo
        Quantidade = pQTD
        Taxa_Desconto = pDSC
        '-------------
        cArtigo = pArtigo
        sQTD = Quantidade.ToString
        sTaxa_Desconto = Taxa_Desconto.ToString

        Stock = cArtigo.Stock
        Index_Artigo = pIndex_Artigo
    End Sub
    ''' <summary>
    ''' AFTER_QTD, PRECO E DSC
    ''' </summary>
    ''' <param name="pNum_Doc"></param>
    ''' <param name="pLinha"></param>
    ''' <param name="pQTD"></param>
    ''' <param name="pPreco"></param>
    ''' <param name="pDSC"></param>
    ''' <param name="pArtigo"></param>
    Sub New(pNum_Doc As String, pLinha As Integer, pQTD As Integer, pPreco As Decimal, pDSC As Integer, pIndex_Artigo As Integer, pArtigo As ViewArt)
        Num_Doc = pNum_Doc
        FLG_Entidade = pArtigo.FLG_Entidade
        Num_Linha = pLinha
        Cod_Artigo = pArtigo.Cod_Artigo
        Quantidade = pQTD
        Taxa_Desconto = pDSC
        P_Unitario = pPreco
        _sP_Unitario = pPreco.ToString
        '-------------
        cArtigo = pArtigo
        Stock = cArtigo.Stock
        sQTD = Quantidade.ToString
        sTaxa_Desconto = Taxa_Desconto.ToString
        Index_Artigo = pIndex_Artigo

    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    'Friend Shared Function GetNovoCodigo() As String

    'Return "L" & ClsEmpresas.GetContador(enCont.Linhas).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

    'End Function

    Public Shared Function GetListaLinhas(ByVal pNum_Doc As String, pFLG_Entidade As String) As List(Of ClsLinhas)
        Dim mListaLinhas As New List(Of ClsLinhas)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pNum_Doc", pNum_Doc)

        mStrSQL = "Select "
        mStrSQL += "ISNULL(Num_Doc,'') As Num_Doc,"
        mStrSQL += "ISNULL(Num_Linha,0) As Num_Linha,"
        mStrSQL += "ISNULL(Cod_Artigo,'') As Cod_Artigo,"
        mStrSQL += "ISNULL(Quantidade,0) As Quantidade,"
        mStrSQL += "ISNULL(P_Unitario,0) As P_Unitario,"
        mStrSQL += "ISNULL(Taxa_Desconto,0) As Taxa_Desconto,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Linhas "
        mStrSQL += "WHERE FLG_Ativo=1 AND Num_Doc=@pNum_Doc"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsLinhas As New ClsLinhas

            With mClsLinhas

                .Num_Doc = mRDR.GetString(mRDR.GetOrdinal("Num_Doc"))
                .Num_Linha = mRDR.GetValue(mRDR.GetOrdinal("Num_Linha"))
                .Cod_Artigo = mRDR.GetString(mRDR.GetOrdinal("Cod_Artigo"))
                .Quantidade = mRDR.GetValue(mRDR.GetOrdinal("Quantidade"))
                .P_Unitario = mRDR.GetDecimal(mRDR.GetOrdinal("P_Unitario"))
                .Taxa_Desconto = mRDR.GetValue(mRDR.GetOrdinal("Taxa_Desconto"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))

                .sQTD = .Quantidade.ToString
                .FLG_Entidade = pFLG_Entidade
                .cArtigo = ViewArt.GetViewArt(.Cod_Artigo, pFLG_Entidade)
                .sTaxa_Desconto = .Taxa_Desconto.ToString
            End With

            mListaLinhas.Add(mClsLinhas)

        End While

        Dim mCount As Integer = mListaLinhas.Count
        Dim mMax As Integer = My.Settings.MAX_LINHAS
        Dim mDoc As String = mListaLinhas(0).Num_Doc
        For n As Integer = mCount To mMax - 1
            Dim mLinha As New ClsLinhas(mDoc, n)
            mListaLinhas.Add(mLinha)
        Next

        mRDR.Close()
        mDB.Close()

        Return mListaLinhas
    End Function


    ''' <summary>
    '''      Function GetLinhas() Método para devolver a Lista de Linhas
    '''      Gerado em 20/03/2023 10:10:44
    ''' </summary>
    ''' <returns>
    '''      mListaLinhas
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetLinhas() As List(Of ClsLinhas)
        Dim mListaLinhas As New List(Of ClsLinhas)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Num_Doc,'') As Num_Doc,"
        mStrSQL += "ISNULL(Num_Linha,0) As Num_Linha,"
        mStrSQL += "ISNULL(Cod_Artigo,'') As Cod_Artigo,"
        mStrSQL += "ISNULL(Quantidade,0) As Quantidade,"
        mStrSQL += "ISNULL(P_Unitario,0) As P_Unitario,"
        mStrSQL += "ISNULL(Taxa_Desconto,0) As Taxa_Desconto,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Linhas "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsLinhas As New ClsLinhas

            With mClsLinhas
                .Num_Doc = mRDR.GetString(mRDR.GetOrdinal("Num_Doc"))
                .Num_Linha = mRDR.GetValue(mRDR.GetOrdinal("Num_Linha"))
                .Cod_Artigo = mRDR.GetString(mRDR.GetOrdinal("Cod_Artigo"))
                .Quantidade = mRDR.GetValue(mRDR.GetOrdinal("Quantidade"))
                .P_Unitario = mRDR.GetDecimal(mRDR.GetOrdinal("P_Unitario"))
                .Taxa_Desconto = mRDR.GetValue(mRDR.GetOrdinal("Taxa_Desconto"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaLinhas.Add(mClsLinhas)
        End While

        mRDR.Close()
        mDB.Close()

        Return mListaLinhas
    End Function
    Public Shared Function GetLinhas(ByVal pNum_Doc As String) As List(Of ClsLinhas)
        Dim mListaLinhas As New List(Of ClsLinhas)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pNum_Doc", pNum_Doc)

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Num_Doc,'') As Num_Doc,"
        mStrSQL += "ISNULL(Num_Linha,0) As Num_Linha,"
        mStrSQL += "ISNULL(Quantidade,0) As Quantidade,"
        mStrSQL += "ISNULL(P_Unitario,0) As P_Unitario,"
        mStrSQL += "ISNULL(Taxa_Desconto,0) As Taxa_Desconto,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Linhas "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Num_Doc=@pNum_Doc "


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsLinhas As New ClsLinhas

            With mClsLinhas
                .Num_Doc = mRDR.GetString(mRDR.GetOrdinal("Num_Doc"))
                .Num_Linha = mRDR.GetValue(mRDR.GetOrdinal("Num_Linha"))
                .Quantidade = mRDR.GetValue(mRDR.GetOrdinal("Quantidade"))
                .P_Unitario = mRDR.GetDecimal(mRDR.GetOrdinal("P_Unitario"))
                .Taxa_Desconto = mRDR.GetValue(mRDR.GetOrdinal("Taxa_Desconto"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))

                .sQTD = .Quantidade.ToString
                .sTaxa_Desconto = .Taxa_Desconto.ToString
            End With

            mListaLinhas.Add(mClsLinhas)

        End While

        For n As Integer = mListaLinhas.Count To My.Settings.MAX_LINHAS - 1
            Dim mClsLinhas As New ClsLinhas(pNum_Doc, n)
            mListaLinhas.Add(mClsLinhas)
        Next

        mRDR.Close()
        mDB.Close()

        Return mListaLinhas
    End Function


    ''' <summary>
    '''      Function GetLinhasByCod(ByVal pNum_Doc As String) Método para decolver uma Classe de Linhas
    '''      Gerado em 20/03/2023 10:10:44
    ''' </summary>
    ''' <returns>
    '''      mClsLinhas
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetLinhasByCod(ByVal pNum_Doc As String) As ClsLinhas
        Dim mClsLinhas As New ClsLinhas
        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pNum_Doc", pNum_Doc)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Num_Doc,'') As Num_Doc,"
        mStrSQL += "ISNULL(Num_Linha,0) As Num_Linha,"
        mStrSQL += "ISNULL(Cod_Artigo,'') As Cod_Artigo,"
        mStrSQL += "ISNULL(Quantidade,0) As Quantidade,"
        mStrSQL += "ISNULL(P_Unitario,0) As P_Unitario,"
        mStrSQL += "ISNULL(Taxa_Desconto,0) As Taxa_Desconto,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Linhas "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Num_Doc=@pNum_Doc"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsLinhas
                .Num_Doc = mRDR.GetString(mRDR.GetOrdinal("Num_Doc"))
                .Num_Linha = mRDR.GetValue(mRDR.GetOrdinal("Num_Linha"))
                .Cod_Artigo = mRDR.GetString(mRDR.GetOrdinal("Cod_Artigo"))
                .Quantidade = mRDR.GetValue(mRDR.GetOrdinal("Quantidade"))
                .P_Unitario = mRDR.GetDecimal(mRDR.GetOrdinal("P_Unitario"))
                .Taxa_Desconto = mRDR.GetValue(mRDR.GetOrdinal("Taxa_Desconto"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsLinhas
    End Function


    ''' <summary>
    '''      Function ModificaLinhas(ByVal pClsLinhas As ClsLinhas) Método para Modificar a TABELA Linhas
    '''      Gerado em 20/03/2023 10:10:44
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ModificaLinhas(ByVal pClsLinhas As ClsLinhas) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pNum_Doc", pClsLinhas.Num_Doc.Substring(0, IIf(Len(pClsLinhas.Num_Doc) > 11, 11, Len(pClsLinhas.Num_Doc))))
        mCMD.Parameters.AddWithValue("@pNum_Linha", pClsLinhas.Num_Linha)
        mCMD.Parameters.AddWithValue("@pCod_Artigo", pClsLinhas.Cod_Artigo.Substring(0, IIf(Len(pClsLinhas.Cod_Artigo) > 8, 8, Len(pClsLinhas.Cod_Artigo))))
        mCMD.Parameters.AddWithValue("@pQuantidade", pClsLinhas.Quantidade)
        mCMD.Parameters.AddWithValue("@pP_Unitario", pClsLinhas.P_Unitario)
        mCMD.Parameters.AddWithValue("@pTaxa_Desconto", pClsLinhas.Taxa_Desconto)


        mStrSQL = "UPDATE Linhas SET "
        mStrSQL += "Num_Linha=@pNum_Linha,"
        mStrSQL += "Cod_Artigo=@pCod_Artigo,"
        mStrSQL += "Quantidade=@pQuantidade,"
        mStrSQL += "P_Unitario=@pP_Unitario,"
        mStrSQL += "Taxa_Desconto=@pTaxa_Desconto "
        mStrSQL += "WHERE Num_Doc=@pNum_Doc"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaLinhas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function

    ''' <summary>
    '''      Function ApagaLinhas(ByVal pNum_Doc As String) Método para Apagar um Registo da Tabela Linhas
    '''      Gerado em 20/03/2023 10:10:44
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ApagaLinhas(ByVal pNum_Doc As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pNum_Doc", pNum_Doc)


        mStrSQL = "UPDATE Linhas SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Num_Doc=@pNum_Doc"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaLinhas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try
        mDB.Close()
        Return mReturn

    End Function
End Class

