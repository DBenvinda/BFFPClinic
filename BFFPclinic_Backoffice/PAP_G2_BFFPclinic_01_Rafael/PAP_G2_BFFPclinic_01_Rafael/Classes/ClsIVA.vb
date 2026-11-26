
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsIVA Classe da Tabela IVA
'''      Gerado em 20/03/2023 10:10:44
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class ClsIVA


    ' -----------------------------------------
    ' Property's da tabela IVA
    ' -----------------------------------------

    Public Property Cod_IVA As String                                       ' Len:  3 - SQL_Type: nvarchar
    Public Property Taxa_IVA As Integer                                     ' SQL_Type: smallint
    Public Property Tipo_IVA As String                                      ' Len:  1 - SQL_Type: nvarchar
    Public Property Designacao As String                                    ' Len: 30 - SQL_Type: nvarchar
    Public Property Data_Inicio_Vigor As Date                               ' SQL_Type: smalldatetime
    Public Property Data_Fim_Vigor As Date                                  ' SQL_Type: smalldatetime
    Public Property FLG_Descontinuado As Boolean                            ' SQL_Type: bit
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    Friend Shared Function GetNovoCodigo() As String
        Dim mreturn As String = ""

        mreturn = "I" & ClsEmpresas.GetContador(enCont.IVA).ToString("00") ' <-------------- VERIFICAR O Nº de ZEROS

        Return mreturn

    End Function


    ''' <summary>
    '''      Function GetIVA() Método para devolver a Lista de IVA
    '''      Gerado em 20/03/2023 10:10:44
    ''' </summary>
    ''' <returns>
    '''      mListaIVA
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetIVA() As List(Of clsIVA)
        Dim mListaIVA As new List(Of clsIVA)

        Dim mStrSQL as String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_IVA,'') As Cod_IVA,"
        mStrSQL += "ISNULL(Taxa_IVA,0) As Taxa_IVA,"
        mStrSQL += "ISNULL(Tipo_IVA,'') As Tipo_IVA,"
        mStrSQL += "ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(Data_Inicio_Vigor,0) As Data_Inicio_Vigor,"
        mStrSQL += "ISNULL(Data_Fim_Vigor,0) As Data_Fim_Vigor,"
        mStrSQL += "ISNULL(FLG_Descontinuado,0) As FLG_Descontinuado,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM IVA "
        mStrSQL += "WHERE FLG_Ativo=1 ORDER BY Taxa_IVA"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsIVA As New ClsIVA

            With mClsIVA
                .Cod_IVA = mRDR.GetString(mRDR.GetOrdinal("Cod_IVA"))
                .Taxa_IVA = mRDR.Getvalue(mRDR.GetOrdinal("Taxa_IVA"))
                .Tipo_IVA = mRDR.GetString(mRDR.GetOrdinal("Tipo_IVA"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .Data_Inicio_Vigor = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Inicio_Vigor"))
                .Data_Fim_Vigor = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Fim_Vigor"))
                .FLG_Descontinuado = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Descontinuado"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaIVA.add(mClsIVA)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaIVA
    End Function

    ''' <summary>
    '''      Function FiltrarIVA Método para Filtrar os campos da lista de IVA
    '''      Gerado em 20/03/2023 10:10:44
    ''' </summary>
    ''' <returns>
    '''      mListaIVA
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function FiltrarIVA(ByVal pFiltro As ClsIVA) As List(Of clsIVA)
        Dim mListaIVA As new List(Of clsIVA)
        Dim mLista As new List(Of clsIVA)

        mListaIVA = GetIVA()

        mLista = mListaIVA.FindAll(Function(x) _
        x.Cod_IVA.Contains(pFiltro.Cod_IVA)
        )
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Taxa_IVA.Contains(pFiltro.Taxa_IVA) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetIVAByCod(ByVal pCod_IVA As String) Método para decolver uma Classe de IVA
    '''      Gerado em 20/03/2023 10:10:44
    ''' </summary>
    ''' <returns>
    '''      mClsIVA
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetIVAByTipo(ByVal pTipo_IVA As String) As ClsIVA
        Dim mClsIVA As New ClsIVA

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pTipo_IVA", pTipo_IVA)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_IVA,'') As Cod_IVA,"
        mStrSQL += "ISNULL(Taxa_IVA,0) As Taxa_IVA,"
        mStrSQL += "ISNULL(Tipo_IVA,'') As Tipo_IVA,"
        mStrSQL += "ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(Data_Inicio_Vigor,0) As Data_Inicio_Vigor,"
        mStrSQL += "ISNULL(Data_Fim_Vigor,0) As Data_Fim_Vigor,"
        mStrSQL += "ISNULL(FLG_Descontinuado,0) As FLG_Descontinuado,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM IVA "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Tipo_IVA=@pTipo_IVA"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsIVA
                .Cod_IVA = mRDR.GetString(mRDR.GetOrdinal("Cod_IVA"))
                .Taxa_IVA = mRDR.GetValue(mRDR.GetOrdinal("Taxa_IVA"))
                .Tipo_IVA = mRDR.GetString(mRDR.GetOrdinal("Tipo_IVA"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .Data_Inicio_Vigor = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Inicio_Vigor"))
                .Data_Fim_Vigor = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Fim_Vigor"))
                .FLG_Descontinuado = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Descontinuado"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsIVA
    End Function


    ''' <summary>
    '''      Function ModificaIVA(ByVal pClsIVA As ClsIVA) Método para Modificar a TABELA IVA
    '''      Gerado em 20/03/2023 10:10:44
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ModificaIVA(ByVal pClsIVA As ClsIVA) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL as String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_IVA", pClsIVA.Cod_IVA.Substring(0, IIf(Len(pClsIVA.Cod_IVA) > 3, 3, Len(pClsIVA.Cod_IVA))))
        mCMD.Parameters.AddWithValue("@pTaxa_IVA", pClsIVA.Taxa_IVA)
        mCMD.Parameters.AddWithValue("@pTipo_IVA", pClsIVA.Tipo_IVA.Substring(0, IIf(Len(pClsIVA.Tipo_IVA) > 1, 1, Len(pClsIVA.Tipo_IVA))))
        mCMD.Parameters.AddWithValue("@pDesignacao", pClsIVA.Designacao.Substring(0, IIf(Len(pClsIVA.Designacao) > 30, 30, Len(pClsIVA.Designacao))))
        mCMD.Parameters.AddWithValue("@pData_Inicio_Vigor", pClsIVA.Data_Inicio_Vigor)
        mCMD.Parameters.AddWithValue("@pData_Fim_Vigor", pClsIVA.Data_Fim_Vigor)
        mCMD.Parameters.AddWithValue("@pFLG_Descontinuado", pClsIVA.FLG_Descontinuado)


        mStrSQL = "UPDATE IVA SET "
        mStrSQL += "Taxa_IVA=@pTaxa_IVA,"
        mStrSQL += "Tipo_IVA=@pTipo_IVA,"
        mStrSQL += "Designacao=@pDesignacao,"
        mStrSQL += "Data_Inicio_Vigor=@pData_Inicio_Vigor,"
        mStrSQL += "Data_Fim_Vigor=@pData_Fim_Vigor,"
        mStrSQL += "FLG_Descontinuado=@pFLG_Descontinuado "
        mStrSQL += "WHERE Cod_IVA=@pCod_IVA"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            Msgbox("ModificaIVA:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaIVA(ByVal pNovoIVA As ClsIVA) Método para Gravar a TABELA IVA
    '''      Gerado em 20/03/2023 10:10:44
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GravaIVA(ByVal pNovoIVA As ClsIVA) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL as String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_IVA", pNovoIVA.Cod_IVA.Substring(0, IIf(Len(pNovoIVA.Cod_IVA) > 3, 3, Len(pNovoIVA.Cod_IVA))))
        mCMD.Parameters.AddWithValue("@pTaxa_IVA", pNovoIVA.Taxa_IVA)
        mCMD.Parameters.AddWithValue("@pTipo_IVA", pNovoIVA.Tipo_IVA.Substring(0, IIf(Len(pNovoIVA.Tipo_IVA) > 1, 1, Len(pNovoIVA.Tipo_IVA))))
        mCMD.Parameters.AddWithValue("@pDesignacao", pNovoIVA.Designacao.Substring(0, IIf(Len(pNovoIVA.Designacao) > 30, 30, Len(pNovoIVA.Designacao))))
        mCMD.Parameters.AddWithValue("@pData_Inicio_Vigor", pNovoIVA.Data_Inicio_Vigor)
        mCMD.Parameters.AddWithValue("@pData_Fim_Vigor", pNovoIVA.Data_Fim_Vigor)
        mCMD.Parameters.AddWithValue("@pFLG_Descontinuado", pNovoIVA.FLG_Descontinuado)
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoIVA.FLG_Ativo)


        mStrSQL = "INSERT INTO IVA "
        mStrSQL += "("
        mStrSQL += "Cod_IVA,"
        mStrSQL += "Taxa_IVA,"
        mStrSQL += "Tipo_IVA,"
        mStrSQL += "Designacao,"
        mStrSQL += "Data_Inicio_Vigor,"
        mStrSQL += "Data_Fim_Vigor,"
        mStrSQL += "FLG_Descontinuado,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_IVA,"
        mStrSQL += "@pTaxa_IVA,"
        mStrSQL += "@pTipo_IVA,"
        mStrSQL += "@pDesignacao,"
        mStrSQL += "@pData_Inicio_Vigor,"
        mStrSQL += "@pData_Fim_Vigor,"
        mStrSQL += "@pFLG_Descontinuado,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            ClsEmpresas.GravaContador(enCont.IVA)
        Catch ex As Exception
            Msgbox("GravaIVA:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaIVA(ByVal pCod_IVA As String) Método para Apagar um Registo da Tabela IVA
    '''      Gerado em 20/03/2023 10:10:44
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ApagaIVA(ByVal pCod_IVA As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL as String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_IVA", pCod_IVA)


        mStrSQL = "UPDATE IVA SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_IVA=@pCod_IVA"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            Msgbox("ApagaIVA:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe IVAComparer 
'''      Gerado em 20/03/2023 10:10:44
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class IVAComparer
    Implements IEqualityComparer(Of clsIVA)

    Public Function Equals1(ByVal x As clsIVA, ByVal y As clsIVA) As Boolean Implements IEqualityComparer(Of clsIVA).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_IVA = y.Cod_IVA) ' AndAlso (x.Taxa_IVA = y.Taxa_IVA)
    End Function

    Public Function GetHashCode1(ByVal pCls As clsIVA) As Integer Implements IEqualityComparer(Of clsIVA).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsIVA_Taxa_IVA = pCls.Taxa_IVA.GetHashCode()
        Dim Hash_ClsIVA_Cod_IVA = pCls.Cod_IVA.GetHashCode()

        Return Hash_ClsIVA_Cod_IVA 'Xor Hash_ClsIVA_Taxa_IVA
    End Function
End Class
