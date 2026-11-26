
Imports System.Data.SqlClient
Imports System.Runtime.Remoting.Messaging
Imports System.Web.UI.Design.WebControls.WebParts
Imports DevExpress.Office.Utils
Imports DevExpress.Utils.DPI
Imports DevExpress.XtraReports.Native.Printing

Public Class ViewArt
    Public Property Cod_Artigo As String
    Public Property Cod_Especialidade As String

    Public Property Cod_Tipo_Marcacao As String
    Public Property FLG_PS As String
    Public Property Artigo As String
    Public Property Stock As Integer
    Public Property Preco_Unitario As Decimal
    Public Property Taxa_IVA As String

    Public FLG_Entidade As String

    Sub New()

    End Sub

    Friend Shared Function GetViewArt(pCod_Artigo As String, pFLG_Entidade As String) As ViewArt
        Dim mReturn As New ViewArt
        Dim mArtigo As New ClsArtigos

        mArtigo = ClsArtigos.GetArtigosByCod(pCod_Artigo)

        With mReturn
            .Cod_Artigo = mArtigo.Cod_Artigo
            .Cod_Especialidade = mArtigo.Cod_Especialidade
            .Cod_Tipo_Marcacao = mArtigo.Cod_Tipo_Marcacao
            .FLG_PS = mArtigo.FLG_Produto_Servico
            .Artigo = mArtigo.Designacao
            .FLG_Entidade = pFLG_Entidade
            If pFLG_Entidade = "C" Then
                .Preco_Unitario = mArtigo.Preco_Venda
            Else
                .Preco_Unitario = mArtigo.Preco_Compra
            End If
            .Stock = mArtigo.Stock
            .Taxa_IVA = mArtigo.Taxa_IVA
        End With


        Return mReturn
    End Function

    Friend Shared Function GetListaArtigos(Optional ByVal pFLG_Entidade As String = "C") As List(Of ViewArt)
        Dim mListaViewArt As New List(Of ViewArt)
        Dim mLista_Artigos As New List(Of ClsArtigos)

        mLista_Artigos = ClsArtigos.GetArtigos

        For Each pArt As ClsArtigos In mLista_Artigos
            Dim mView As New ViewArt

            With mView

                Select Case pFLG_Entidade
                    Case "C"
                        If (pArt.Stock <= 0 And (pArt.FLG_Produto_Servico = "P")) Then
                            Continue For
                        End If
                        .Preco_Unitario = pArt.Preco_Venda
                    Case "F"
                        If (pArt.FLG_Produto_Servico = "S") Then
                            Continue For
                        End If
                        .Preco_Unitario = pArt.Preco_Compra
                End Select

                .FLG_Entidade = pFLG_Entidade
                .Cod_Artigo = pArt.Cod_Artigo
                .Cod_Especialidade = pArt.Cod_Especialidade
                .Cod_Tipo_Marcacao = pArt.Cod_Tipo_Marcacao
                .FLG_PS = pArt.FLG_Produto_Servico
                .Artigo = pArt.Designacao
                .Stock = pArt.Stock
                .Taxa_IVA = pArt.Taxa_IVA

            End With

            mListaViewArt.Add(mView)
        Next
        Return mListaViewArt
    End Function
End Class


''' <summary>
'''      Classe ClsArtigos Classe da Tabela Artigos
'''      Gerado em 20/03/2023 10:10:43
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class ClsArtigos


    ' -----------------------------------------
    ' Property's da tabela Artigos
    ' -----------------------------------------

    Public Property Cod_Artigo As String                                    ' Len:  8 - SQL_Type: nvarchar
    Public Property Cod_Especialidade As String                                 ' Len: 15 - SQL_Type: nvarchar
    Public ReadOnly Property Especialidade As String

        Get
            Return ClsEspecialidades.GetEspecialidadesByCod(Cod_Especialidade).Designacao
        End Get
    End Property

    Public ReadOnly Property Tipo_Marcacao As String

        Get
            Return ClsTipos_Marcacao.GetTipos_MarcacaoByCod(Cod_Tipo_Marcacao).Designacao
        End Get
    End Property
    Public Property Cod_Tipo_Marcacao As String                                 ' Len: 15 - SQL_Type: nvarchar
    Public Property FLG_Produto_Servico As String                           ' Len:  1 - SQL_Type: nvarchar
    Public Property Designacao As String                                    ' Len:100 - SQL_Type: nvarchar
    Public Property Tipo_IVA As String                                      ' Len:  1 - SQL_Type: nvarchar
    Public ReadOnly Property Taxa_IVA As Integer
        Get
            Return If(Tipo_IVA = "", 0, ClsIVA.GetIVAByTipo(Tipo_IVA).Taxa_IVA)
        End Get
    End Property
    Public Property Stock As Integer                                        ' SQL_Type: int
    Public Property Preco_Compra As Decimal                                 ' SQL_Type: decimal
    Public Property Preco_Venda As Decimal                                  ' SQL_Type: decimal
    Public Property Data_Ultima_Entrada As Date                             ' SQL_Type: smalldatetime
    Public Property Data_Ultima_Venda As Date                               ' SQL_Type: smalldatetime
    Public Property Data_Registo As Date                                    ' SQL_Type: smalldatetime
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    Friend Shared Function GetNovoCodigo(pFLG_PS As String) As String
        Dim mreturn As String = "S"
        Select Case pFLG_PS
            Case "P"
                mreturn = "P" & ClsEmpresas.GetContador(enCont.Produtos).ToString("0000") ' <-------------- VERIFICAR O Nº de ZEROS
            Case "S"
                mreturn = "S" & ClsEmpresas.GetContador(enCont.Servicos).ToString("0000") ' <-------------- VERIFICAR O Nº de ZEROS
        End Select

        Return mreturn
    End Function


    ''' <summary>
    '''      Function GetArtigos() Método para devolver a Lista de Artigos
    '''      Gerado em 20/03/2023 10:10:43
    ''' </summary>
    ''' <returns>
    '''      mListaArtigos
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetArtigos() As List(Of ClsArtigos)
        Dim mListaArtigos As New List(Of ClsArtigos)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Artigo,'') As Cod_Artigo,"
        mStrSQL += "ISNULL(Cod_Especialidade,'') As Cod_Especialidade,"
        mStrSQL += "ISNULL(Cod_Tipo_Marcacao,'') As Cod_Tipo_Marcacao,"
        mStrSQL += "ISNULL(FLG_Produto_Servico,'P') As FLG_Produto_Servico,"
        mStrSQL += "ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(Tipo_IVA,'') As Tipo_IVA,"
        mStrSQL += "ISNULL(Stock,0) As Stock,"
        mStrSQL += "ISNULL(Preco_Compra,0) As Preco_Compra,"
        mStrSQL += "ISNULL(Preco_Venda,0) As Preco_Venda,"
        mStrSQL += "ISNULL(Data_Ultima_Entrada,0) As Data_Ultima_Entrada,"
        mStrSQL += "ISNULL(Data_Ultima_Venda,0) As Data_Ultima_Venda,"
        mStrSQL += "ISNULL(Data_Registo,getdate()) As Data_Registo,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Artigos "
        mStrSQL += "WHERE FLG_Ativo=1 ORDER BY Cod_Artigo"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsArtigos As New ClsArtigos

            With mClsArtigos
                .Cod_Artigo = mRDR.GetString(mRDR.GetOrdinal("Cod_Artigo"))
                .Cod_Tipo_Marcacao = mRDR.GetString(mRDR.GetOrdinal("Cod_Tipo_Marcacao"))
                .Cod_Especialidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Especialidade"))
                .FLG_Produto_Servico = mRDR.GetString(mRDR.GetOrdinal("FLG_Produto_Servico"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .Tipo_IVA = mRDR.GetString(mRDR.GetOrdinal("Tipo_IVA"))
                .Stock = mRDR.GetValue(mRDR.GetOrdinal("Stock"))
                .Preco_Compra = mRDR.GetDecimal(mRDR.GetOrdinal("Preco_Compra"))
                .Preco_Venda = mRDR.GetDecimal(mRDR.GetOrdinal("Preco_Venda"))
                .Data_Ultima_Entrada = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Ultima_Entrada"))
                .Data_Ultima_Venda = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Ultima_Venda"))
                .Data_Registo = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Registo"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaArtigos.Add(mClsArtigos)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaArtigos
    End Function

    ''' <summary>
    '''      Function FiltrarArtigos Método para Filtrar os campos da lista de Artigos
    '''      Gerado em 20/03/2023 10:10:43
    ''' </summary>
    ''' <returns>
    '''      mListaArtigos
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function FiltrarArtigos(ByVal pFiltro As ClsArtigos) As List(Of ClsArtigos)
        Dim mListaArtigos As New List(Of ClsArtigos)
        Dim mLista As New List(Of ClsArtigos)

        mListaArtigos = GetArtigos()

        mLista = mListaArtigos.FindAll(Function(x) _
        x.Cod_Artigo.Contains(pFiltro.Cod_Artigo)
        )
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Cod_Categoria.Contains(pFiltro.Cod_Categoria) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetArtigosByCod(ByVal pCod_Artigo As String) Método para decolver uma Classe de Artigos
    '''      Gerado em 20/03/2023 10:10:43
    ''' </summary>
    ''' <returns>
    '''      mClsArtigos
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetArtigosByCod(ByVal pCod_Artigo As String) As ClsArtigos
        Dim mClsArtigos As New ClsArtigos

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Artigo", pCod_Artigo)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Artigo,'') As Cod_Artigo,"
        mStrSQL += "ISNULL(Cod_Especialidade,'') As Cod_Especialidade,"
        mStrSQL += "ISNULL(Cod_Tipo_Marcacao,'') As Cod_Tipo_Marcacao,"
        mStrSQL += "ISNULL(FLG_Produto_Servico,'P') As FLG_Produto_Servico,"
        mStrSQL += "ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(Tipo_IVA,'') As Tipo_IVA,"
        mStrSQL += "ISNULL(Stock,0) As Stock,"
        mStrSQL += "ISNULL(Preco_Compra,0) As Preco_Compra,"
        mStrSQL += "ISNULL(Preco_Venda,0) As Preco_Venda,"
        mStrSQL += "ISNULL(Data_Ultima_Entrada,0) As Data_Ultima_Entrada,"
        mStrSQL += "ISNULL(Data_Ultima_Venda,0) As Data_Ultima_Venda,"
        mStrSQL += "ISNULL(Data_Registo,getdate()) As Data_Registo,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Artigos "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Artigo=@pCod_Artigo"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsArtigos
                .Cod_Artigo = mRDR.GetString(mRDR.GetOrdinal("Cod_Artigo"))
                .Cod_Especialidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Especialidade"))
                .Cod_Tipo_Marcacao = mRDR.GetString(mRDR.GetOrdinal("Cod_Tipo_Marcacao"))
                .FLG_Produto_Servico = mRDR.GetString(mRDR.GetOrdinal("FLG_Produto_Servico"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .Tipo_IVA = mRDR.GetString(mRDR.GetOrdinal("Tipo_IVA"))
                .Stock = mRDR.GetValue(mRDR.GetOrdinal("Stock"))
                .Preco_Compra = mRDR.GetDecimal(mRDR.GetOrdinal("Preco_Compra"))
                .Preco_Venda = mRDR.GetDecimal(mRDR.GetOrdinal("Preco_Venda"))
                .Data_Ultima_Entrada = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Ultima_Entrada"))
                .Data_Ultima_Venda = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Ultima_Venda"))
                .Data_Registo = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Registo"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsArtigos
    End Function

    Public Shared Function GetArtigosFiltrados(ByVal pCod_Especialidade As String, ByVal pcod_Tipo_Marcacao As String) As ClsArtigos
        Dim mClsArtigos As New ClsArtigos

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Especialidade", pCod_Especialidade)
        mCMD.Parameters.AddWithValue("@pCod_Tipo_Marcacao", pcod_Tipo_Marcacao)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Artigo,'') As Cod_Artigo,"
        mStrSQL += "ISNULL(Cod_Especialidade,'') As Cod_Especialidade,"
        mStrSQL += "ISNULL(Cod_Tipo_Marcacao,'') As Cod_Tipo_Marcacao,"
        mStrSQL += "ISNULL(FLG_Produto_Servico,'P') As FLG_Produto_Servico,"
        mStrSQL += "ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(Tipo_IVA,'') As Tipo_IVA,"
        mStrSQL += "ISNULL(Stock,0) As Stock,"
        mStrSQL += "ISNULL(Preco_Compra,0) As Preco_Compra,"
        mStrSQL += "ISNULL(Preco_Venda,0) As Preco_Venda,"
        mStrSQL += "ISNULL(Data_Ultima_Entrada,0) As Data_Ultima_Entrada,"
        mStrSQL += "ISNULL(Data_Ultima_Venda,0) As Data_Ultima_Venda,"
        mStrSQL += "ISNULL(Data_Registo,getdate()) As Data_Registo,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Artigos "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Especialidade=@pCod_Especialidade "
        mStrSQL += "AND Cod_Tipo_Marcacao=@pCod_Tipo_Marcacao"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsArtigos
                .Cod_Artigo = mRDR.GetString(mRDR.GetOrdinal("Cod_Artigo"))
                .Cod_Especialidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Especialidade"))
                .Cod_Tipo_Marcacao = mRDR.GetString(mRDR.GetOrdinal("Cod_Tipo_Marcacao"))
                .FLG_Produto_Servico = mRDR.GetString(mRDR.GetOrdinal("FLG_Produto_Servico"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .Tipo_IVA = mRDR.GetString(mRDR.GetOrdinal("Tipo_IVA"))
                .Stock = mRDR.GetValue(mRDR.GetOrdinal("Stock"))
                .Preco_Compra = mRDR.GetDecimal(mRDR.GetOrdinal("Preco_Compra"))
                .Preco_Venda = mRDR.GetDecimal(mRDR.GetOrdinal("Preco_Venda"))
                .Data_Ultima_Entrada = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Ultima_Entrada"))
                .Data_Ultima_Venda = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Ultima_Venda"))
                .Data_Registo = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Registo"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsArtigos
    End Function


    ''' <summary>
    '''      Function ModificaArtigos(ByVal pClsArtigos As ClsArtigos) Método para Modificar a TABELA Artigos
    '''      Gerado em 20/03/2023 10:10:43
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ModificaArtigos(ByVal pClsArtigos As ClsArtigos) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Artigo", pClsArtigos.Cod_Artigo.Substring(0, IIf(Len(pClsArtigos.Cod_Artigo) > 8, 8, Len(pClsArtigos.Cod_Artigo))))
        mCMD.Parameters.AddWithValue("@pCod_Especialidade", pClsArtigos.Cod_Especialidade.Substring(0, IIf(Len(pClsArtigos.Cod_Especialidade) > 15, 15, Len(pClsArtigos.Cod_Especialidade))))
        mCMD.Parameters.AddWithValue("@pCod_Tipo_Marcacao", pClsArtigos.Cod_Tipo_Marcacao.Substring(0, IIf(Len(pClsArtigos.Cod_Tipo_Marcacao) > 15, 15, Len(pClsArtigos.Cod_Tipo_Marcacao))))
        mCMD.Parameters.AddWithValue("@pFLG_Produto_Servico", pClsArtigos.FLG_Produto_Servico.Substring(0, IIf(Len(pClsArtigos.FLG_Produto_Servico) > 1, 1, Len(pClsArtigos.FLG_Produto_Servico))))
        mCMD.Parameters.AddWithValue("@pDesignacao", pClsArtigos.Designacao.Substring(0, IIf(Len(pClsArtigos.Designacao) > 100, 100, Len(pClsArtigos.Designacao))))
        mCMD.Parameters.AddWithValue("@pTipo_IVA", pClsArtigos.Tipo_IVA.Substring(0, IIf(Len(pClsArtigos.Tipo_IVA) > 1, 1, Len(pClsArtigos.Tipo_IVA))))
        mCMD.Parameters.AddWithValue("@pStock", pClsArtigos.Stock)
        mCMD.Parameters.AddWithValue("@pPreco_Compra", pClsArtigos.Preco_Compra)
        mCMD.Parameters.AddWithValue("@pPreco_Venda", pClsArtigos.Preco_Venda)
        mCMD.Parameters.AddWithValue("@pData_Ultima_Entrada", pClsArtigos.Data_Ultima_Entrada)
        mCMD.Parameters.AddWithValue("@pData_Ultima_Venda", pClsArtigos.Data_Ultima_Venda)
        mCMD.Parameters.AddWithValue("@pData_Registo", pClsArtigos.Data_Registo)


        mStrSQL = "UPDATE Artigos SET "
        mStrSQL += "Cod_Especialidade=@pCod_Especialidade,"
        mStrSQL += "Cod_Tipo_Marcacao=@pCod_Tipo_Marcacao,"
        mStrSQL += "FLG_Produto_Servico=@pFLG_Produto_Servico,"
        mStrSQL += "Designacao=@pDesignacao,"
        mStrSQL += "Tipo_IVA=@pTipo_IVA,"
        mStrSQL += "Stock=@pStock,"
        mStrSQL += "Preco_Compra=@pPreco_Compra,"
        mStrSQL += "Preco_Venda=@pPreco_Venda,"
        mStrSQL += "Data_Ultima_Entrada=@pData_Ultima_Entrada,"
        mStrSQL += "Data_Ultima_Venda=@pData_Ultima_Venda,"
        mStrSQL += "Data_Registo=@pData_Registo "
        mStrSQL += "WHERE Cod_Artigo=@pCod_Artigo"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaArtigos:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaArtigos(ByVal pNovoArtigos As ClsArtigos) Método para Gravar a TABELA Artigos
    '''      Gerado em 20/03/2023 10:10:43
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GravaArtigos(ByVal pNovoArtigos As ClsArtigos) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Artigo", pNovoArtigos.Cod_Artigo.Substring(0, IIf(Len(pNovoArtigos.Cod_Artigo) > 8, 8, Len(pNovoArtigos.Cod_Artigo))))
        mCMD.Parameters.AddWithValue("@pCod_Especialidade", pNovoArtigos.Cod_Especialidade.Substring(0, IIf(Len(pNovoArtigos.Cod_Especialidade) > 15, 15, Len(pNovoArtigos.Cod_Especialidade))))
        mCMD.Parameters.AddWithValue("@pCod_Tipo_Marcacao", pNovoArtigos.Cod_Tipo_Marcacao.Substring(0, IIf(Len(pNovoArtigos.Cod_Tipo_Marcacao) > 15, 15, Len(pNovoArtigos.Cod_Tipo_Marcacao))))
        mCMD.Parameters.AddWithValue("@pFLG_Produto_Servico", pNovoArtigos.FLG_Produto_Servico.Substring(0, IIf(Len(pNovoArtigos.FLG_Produto_Servico) > 1, 1, Len(pNovoArtigos.FLG_Produto_Servico))))
        mCMD.Parameters.AddWithValue("@pDesignacao", pNovoArtigos.Designacao.Substring(0, IIf(Len(pNovoArtigos.Designacao) > 100, 100, Len(pNovoArtigos.Designacao))))
        mCMD.Parameters.AddWithValue("@pTipo_IVA", pNovoArtigos.Tipo_IVA.Substring(0, IIf(Len(pNovoArtigos.Tipo_IVA) > 1, 1, Len(pNovoArtigos.Tipo_IVA))))
        mCMD.Parameters.AddWithValue("@pStock", pNovoArtigos.Stock)
        mCMD.Parameters.AddWithValue("@pPreco_Compra", pNovoArtigos.Preco_Compra)
        mCMD.Parameters.AddWithValue("@pPreco_Venda", pNovoArtigos.Preco_Venda)
        mCMD.Parameters.AddWithValue("@pData_Ultima_Entrada", pNovoArtigos.Data_Ultima_Entrada)
        mCMD.Parameters.AddWithValue("@pData_Ultima_Venda", pNovoArtigos.Data_Ultima_Venda)
        mCMD.Parameters.AddWithValue("@pData_Registo", pNovoArtigos.Data_Registo)
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoArtigos.FLG_Ativo)


        mStrSQL = "INSERT INTO Artigos "
        mStrSQL += "("
        mStrSQL += "Cod_Artigo,"
        mStrSQL += "Cod_Especialidade,"
        mStrSQL += "Cod_Tipo_Marcacao,"
        mStrSQL += "FLG_Produto_Servico,"
        mStrSQL += "Designacao,"
        mStrSQL += "Tipo_IVA,"
        mStrSQL += "Stock,"
        mStrSQL += "Preco_Compra,"
        mStrSQL += "Preco_Venda,"
        mStrSQL += "Data_Ultima_Entrada,"
        mStrSQL += "Data_Ultima_Venda,"
        mStrSQL += "Data_Registo,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Artigo,"
        mStrSQL += "@pCod_Especialidade,"
        mStrSQL += "@pCod_Tipo_Marcacao,"
        mStrSQL += "@pFLG_Produto_Servico,"
        mStrSQL += "@pDesignacao,"
        mStrSQL += "@pTipo_IVA,"
        mStrSQL += "@pStock,"
        mStrSQL += "@pPreco_Compra,"
        mStrSQL += "@pPreco_Venda,"
        mStrSQL += "@pData_Ultima_Entrada,"
        mStrSQL += "@pData_Ultima_Venda,"
        mStrSQL += "@pData_Registo,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            Select Case pNovoArtigos.FLG_Produto_Servico
                Case "P"
                    ClsEmpresas.GravaContador(enCont.Produtos)
                Case "S"
                    ClsEmpresas.GravaContador(enCont.Servicos)
            End Select


        Catch ex As Exception
            MsgBox("GravaArtigos:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaArtigos(ByVal pCod_Artigo As String) Método para Apagar um Registo da Tabela Artigos
    '''      Gerado em 20/03/2023 10:10:43
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ApagaArtigos(ByVal pCod_Artigo As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Artigo", pCod_Artigo)


        mStrSQL = "UPDATE Artigos SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Artigo=@pCod_Artigo"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaArtigos:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe ArtigosComparer 
'''      Gerado em 20/03/2023 10:10:43
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class ArtigosComparer
    Implements IEqualityComparer(Of ClsArtigos)

    Public Function Equals1(ByVal x As ClsArtigos, ByVal y As ClsArtigos) As Boolean Implements IEqualityComparer(Of ClsArtigos).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Artigo = y.Cod_Artigo) ' AndAlso (x.Cod_Categoria = y.Cod_Categoria)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsArtigos) As Integer Implements IEqualityComparer(Of ClsArtigos).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsArtigos_Cod_Categoria = pCls.Cod_Categoria.GetHashCode()
        Dim Hash_ClsArtigos_Cod_Artigo = pCls.Cod_Artigo.GetHashCode()

        Return Hash_ClsArtigos_Cod_Artigo 'Xor Hash_ClsArtigos_Cod_Categoria
    End Function
End Class
