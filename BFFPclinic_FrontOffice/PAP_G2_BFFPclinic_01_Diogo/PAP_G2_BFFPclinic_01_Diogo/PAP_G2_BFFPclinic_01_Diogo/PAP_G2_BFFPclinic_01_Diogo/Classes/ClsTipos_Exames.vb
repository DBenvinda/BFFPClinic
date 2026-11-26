
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsTipos_Exames Classe da Tabela Tipos_Exames
'''      Gerado em 31/01/2024 10:35:38
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class ClsTipos_Exames


' -----------------------------------------
' Property's da tabela Tipos_Exames
' -----------------------------------------

Public Property Cod_Exame As String										' Len:  5 - SQL_Type: nvarchar
Public Property Designacao As String									' Len: 40 - SQL_Type: nvarchar
Public Property FLG_Ativo As Boolean									' SQL_Type: bit


Sub New()
End Sub


Friend Shared Function GetNovoCodigo() As String

Return "T" & ClsEmpresas.GetContador(enCont.Tipos_Exames).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

End Function


''' <summary>
'''      Function GetTipos_Exames() Método para devolver a Lista de Tipos_Exames
'''      Gerado em 31/01/2024 10:35:38
''' </summary>
''' <returns>
'''      mListaTipos_Exames
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function GetTipos_Exames() As List(Of clsTipos_Exames)
Dim mListaTipos_Exames As new List(Of clsTipos_Exames)

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand
Dim mRDR As SqlDataReader

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()

mStrSQL="SELECT "
mStrSQL+="ISNULL(Cod_Exame,'') As Cod_Exame,"
mStrSQL+="ISNULL(Designacao,'') As Designacao,"
mStrSQL+="ISNULL(FLG_Ativo,1) As FLG_Ativo "
mStrSQL+="FROM Tipos_Exames "
mStrSQL+="WHERE FLG_Ativo=1"


mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

mRDR = mCMD.ExecuteReader

While mRDR.Read()

Dim mClsTipos_Exames As New ClsTipos_Exames

With mClsTipos_Exames
.Cod_Exame = mRDR.GetString(mRDR.GetOrdinal("Cod_Exame"))
.Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
.FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
End With


mListaTipos_Exames.add(mClsTipos_Exames)

End While

mRDR.Close()
mDB.Close()

Return mListaTipos_Exames
End Function

    ''' <summary>
    '''      Function FiltrarTipos_Exames Método para Filtrar os campos da lista de Tipos_Exames
    '''      Gerado em 31/01/2024 10:35:38
    ''' </summary>
    ''' <returns>
    '''      mListaTipos_Exames
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    ''' 

    Public Shared Function FiltrarTipos_Exames(ByVal pFiltro As ClsTipos_Exames) As List(Of clsTipos_Exames)
Dim mListaTipos_Exames As new List(Of clsTipos_Exames)
Dim mLista As new List(Of clsTipos_Exames)

mListaTipos_Exames = GetTipos_Exames()

mLista = mListaTipos_Exames.FindAll(Function(x) _
x.Cod_Exame.Contains(pFiltro.Cod_Exame) 
)
'-----------------------------------------------------
'Pode Colocar em cima mais colunas como esta abaixo...
'-----------------------------------------------------
 ' AND x.Designacao.Contains(pFiltro.Designacao) 

Return mLista
End Function


    ''' <summary>
    '''      Function GetTipos_ExamesByCod(ByVal pCod_Exame As String) Método para decolver uma Classe de Tipos_Exames
    '''      Gerado em 31/01/2024 10:35:38
    ''' </summary>
    ''' <returns>
    '''      mClsTipos_Exames
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function GetTipos_ExamesByCod(ByVal pCod_Exame As String) As clsTipos_Exames
        Dim mClsTipos_Exames As New clsTipos_Exames

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Exame", pCod_Exame)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Exame,'') As Cod_Exame,"
        mStrSQL += "ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Tipos_Exames "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Exame=@pCod_Exame"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsTipos_Exames
                .Cod_Exame = mRDR.GetString(mRDR.GetOrdinal("Cod_Exame"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsTipos_Exames
    End Function

    Public Shared Function GetTipos_ExamesBydesiignacao(ByVal pdesignacao As String) As String
        Dim mcod_Exame As String

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pDesignacao", pdesignacao)


        mStrSQL = "SELECT "

        mStrSQL += "ISNULL(Cod_Exame,'') As Cod_Exame "

        mStrSQL += "FROM Tipos_Exames "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Designacao=@pDesignacao"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then




            mcod_Exame = mRDR.GetString(mRDR.GetOrdinal("Cod_Exame"))




        End If
        mRDR.Close()
        mDB.Close()

        Return mcod_Exame
    End Function


    ''' <summary>
    '''      Function ModificaTipos_Exames(ByVal pClsTipos_Exames As ClsTipos_Exames) Método para Modificar a TABELA Tipos_Exames
    '''      Gerado em 31/01/2024 10:35:38
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function ModificaTipos_Exames(ByVal pClsTipos_Exames As ClsTipos_Exames) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mCMD.Parameters.Clear()
mCMD.Parameters.AddWithValue("@pCod_Exame",pClsTipos_Exames.Cod_Exame.Substring(0,IIf(Len(pClsTipos_Exames.Cod_Exame)> 5, 5,Len(pClsTipos_Exames.Cod_Exame))))
mCMD.Parameters.AddWithValue("@pDesignacao",pClsTipos_Exames.Designacao.Substring(0,IIf(Len(pClsTipos_Exames.Designacao)> 40, 40,Len(pClsTipos_Exames.Designacao))))


mStrSQL="UPDATE Tipos_Exames SET "
mStrSQL+="Designacao=@pDesignacao "
mStrSQL+="WHERE Cod_Exame=@pCod_Exame"


mDB.ConnectionString = My.Settings.Connection
mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
Catch ex As Exception
Msgbox("ModificaTipos_Exames:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 


''' <summary>
'''      Function GravaTipos_Exames(ByVal pNovoTipos_Exames As ClsTipos_Exames) Método para Gravar a TABELA Tipos_Exames
'''      Gerado em 31/01/2024 10:35:38
''' </summary>
''' <returns>
'''      Boolean
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function GravaTipos_Exames(ByVal pNovoTipos_Exames As ClsTipos_Exames) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()


mCMD.Parameters.AddWithValue("@pCod_Exame",pNovoTipos_Exames.Cod_Exame.Substring(0,IIf(Len(pNovoTipos_Exames.Cod_Exame)> 5, 5,Len(pNovoTipos_Exames.Cod_Exame))))
mCMD.Parameters.AddWithValue("@pDesignacao",pNovoTipos_Exames.Designacao.Substring(0,IIf(Len(pNovoTipos_Exames.Designacao)> 40, 40,Len(pNovoTipos_Exames.Designacao))))
mCMD.Parameters.AddWithValue("@pFLG_Ativo",pNovoTipos_Exames.FLG_Ativo)


mStrSQL="INSERT INTO Tipos_Exames "
mStrSQL+="("
mStrSQL+="Cod_Exame,"
mStrSQL+="Designacao,"
mStrSQL+="FLG_Ativo "
mStrSQL+=") "
mStrSQL+="VALUES "
mStrSQL+="("
mStrSQL+="@pCod_Exame,"
mStrSQL+="@pDesignacao,"
mStrSQL+="1"
mStrSQL+=")"


mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
ClsEmpresas.GravaContador(enCont.Tipos_Exames)
Catch ex As Exception
Msgbox("GravaTipos_Exames:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 


''' <summary>
'''      Function ApagaTipos_Exames(ByVal pCod_Exame As String) Método para Apagar um Registo da Tabela Tipos_Exames
'''      Gerado em 31/01/2024 10:35:38
''' </summary>
''' <returns>
'''      Boolean
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function ApagaTipos_Exames(ByVal pCod_Exame As String) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mCMD.Parameters.Clear()

mCMD.Parameters.AddWithValue("@pCod_Exame", pCod_Exame)


mStrSQL="UPDATE Tipos_Exames SET "
mStrSQL+="FLG_Ativo=0 "
mStrSQL+="WHERE Cod_Exame=@pCod_Exame"


mDB.ConnectionString = My.Settings.Connection
mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
Catch ex As Exception
Msgbox("ApagaTipos_Exames:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 
End Class



''' <summary>
'''      Classe Tipos_ExamesComparer 
'''      Gerado em 31/01/2024 10:35:38
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class Tipos_ExamesComparer 
Implements IEqualityComparer(Of clsTipos_Exames)

Public Function Equals1(ByVal x As clsTipos_Exames, ByVal y As clsTipos_Exames) As Boolean Implements IEqualityComparer(Of clsTipos_Exames).Equals

If x Is y Then Return True

If x Is Nothing OrElse y Is Nothing Then Return False

Return (x.Cod_Exame = y.Cod_Exame) ' AndAlso (x.Designacao = y.Designacao)
End Function

Public Function GetHashCode1(ByVal pCls As clsTipos_Exames) As Integer Implements IEqualityComparer(Of clsTipos_Exames).GetHashCode

If pCls Is Nothing Then Return 0

'Dim Hash_ClsTipos_Exames_Designacao = pCls.Designacao.GetHashCode()
Dim Hash_ClsTipos_Exames_Cod_Exame = pCls.Cod_Exame.GetHashCode()

Return Hash_ClsTipos_Exames_Cod_Exame 'Xor Hash_ClsTipos_Exames_Designacao
End Function
End Class
