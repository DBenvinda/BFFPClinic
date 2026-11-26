
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsSeries Classe da Tabela Series
'''      Gerado em 31/01/2024 10:35:38
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class ClsSeries


' -----------------------------------------
' Property's da tabela Series
' -----------------------------------------

Public Property Cod_Serie As String										' Len:  8 - SQL_Type: nvarchar
Public Property FLG_Tipo_Doc As String									' Len:  3 - SQL_Type: nvarchar
Public Property Ano_Trabalho As String									' Len:  4 - SQL_Type: nvarchar
Public Property Contador As Integer										' SQL_Type: smallint
Public Property FLG_Ativo As Boolean									' SQL_Type: bit


Sub New()
End Sub


'--------------------------------------------
' Exemplo de criador de Código por contador
' Para ser usado no caso de o Cdigo ser gerado
' e o contador existir na tabela Empresas
'---------------------------------------------

'Friend Shared Function GetNovoCodigo() As String

'Return "S" & ClsEmpresas.GetContador(enCont.Series).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

'End Function


''' <summary>
'''      Function GetSeries() Método para devolver a Lista de Series
'''      Gerado em 31/01/2024 10:35:38
''' </summary>
''' <returns>
'''      mListaSeries
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function GetSeries() As List(Of clsSeries)
Dim mListaSeries As new List(Of clsSeries)

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand
Dim mRDR As SqlDataReader

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()

mStrSQL="SELECT "
mStrSQL+="ISNULL(Cod_Serie,'') As Cod_Serie,"
mStrSQL+="ISNULL(FLG_Tipo_Doc,'FC') As FLG_Tipo_Doc,"
mStrSQL+="ISNULL(Ano_Trabalho,2018) As Ano_Trabalho,"
mStrSQL+="ISNULL(Contador,0) As Contador,"
mStrSQL+="ISNULL(FLG_Ativo,1) As FLG_Ativo "
mStrSQL+="FROM Series "
mStrSQL+="WHERE FLG_Ativo=1"


mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

mRDR = mCMD.ExecuteReader

While mRDR.Read()

Dim mClsSeries As New ClsSeries

With mClsSeries
.Cod_Serie = mRDR.GetString(mRDR.GetOrdinal("Cod_Serie"))
.FLG_Tipo_Doc = mRDR.GetString(mRDR.GetOrdinal("FLG_Tipo_Doc"))
.Ano_Trabalho = mRDR.GetString(mRDR.GetOrdinal("Ano_Trabalho"))
.Contador = mRDR.Getvalue(mRDR.GetOrdinal("Contador"))
.FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
End With


mListaSeries.add(mClsSeries)

End While

mRDR.Close()
mDB.Close()

Return mListaSeries
End Function 

''' <summary>
'''      Function FiltrarSeries Método para Filtrar os campos da lista de Series
'''      Gerado em 31/01/2024 10:35:38
''' </summary>
''' <returns>
'''      mListaSeries
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function FiltrarSeries(ByVal pFiltro As ClsSeries) As List(Of clsSeries)
Dim mListaSeries As new List(Of clsSeries)
Dim mLista As new List(Of clsSeries)

mListaSeries = GetSeries()

mLista = mListaSeries.FindAll(Function(x) _
x.Cod_Serie.Contains(pFiltro.Cod_Serie) 
)
'-----------------------------------------------------
'Pode Colocar em cima mais colunas como esta abaixo...
'-----------------------------------------------------
 ' AND x.FLG_Tipo_Doc.Contains(pFiltro.FLG_Tipo_Doc) 

Return mLista
End Function 


''' <summary>
'''      Function GetSeriesByCod(ByVal pCod_Serie As String) Método para decolver uma Classe de Series
'''      Gerado em 31/01/2024 10:35:38
''' </summary>
''' <returns>
'''      mClsSeries
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function GetSeriesByCod(ByVal pCod_Serie As String) As clsSeries
Dim mClsSeries As new clsSeries

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand
Dim mRDR As SqlDataReader

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()
mCMD.Parameters.AddWithValue("@pCod_Serie",pCod_Serie)


mStrSQL="SELECT "
mStrSQL+="ISNULL(Cod_Serie,'') As Cod_Serie,"
mStrSQL+="ISNULL(FLG_Tipo_Doc,'FC') As FLG_Tipo_Doc,"
mStrSQL+="ISNULL(Ano_Trabalho,2018) As Ano_Trabalho,"
mStrSQL+="ISNULL(Contador,0) As Contador,"
mStrSQL+="ISNULL(FLG_Ativo,1) As FLG_Ativo "
mStrSQL+="FROM Series "
mStrSQL+="WHERE FLG_Ativo=1 "
mStrSQL+="AND Cod_Serie=@pCod_Serie"


mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

mRDR = mCMD.ExecuteReader

IF mRDR.Read() Then


With mClsSeries
.Cod_Serie = mRDR.GetString(mRDR.GetOrdinal("Cod_Serie"))
.FLG_Tipo_Doc = mRDR.GetString(mRDR.GetOrdinal("FLG_Tipo_Doc"))
.Ano_Trabalho = mRDR.GetString(mRDR.GetOrdinal("Ano_Trabalho"))
.Contador = mRDR.Getvalue(mRDR.GetOrdinal("Contador"))
.FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
End With


End IF
mRDR.Close()
mDB.Close()

Return mClsSeries
End Function 


''' <summary>
'''      Function ModificaSeries(ByVal pClsSeries As ClsSeries) Método para Modificar a TABELA Series
'''      Gerado em 31/01/2024 10:35:38
''' </summary>
''' <returns>
'''      Boolean
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function ModificaSeries(ByVal pClsSeries As ClsSeries) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mCMD.Parameters.Clear()
mCMD.Parameters.AddWithValue("@pCod_Serie",pClsSeries.Cod_Serie.Substring(0,IIf(Len(pClsSeries.Cod_Serie)> 8, 8,Len(pClsSeries.Cod_Serie))))
mCMD.Parameters.AddWithValue("@pFLG_Tipo_Doc",pClsSeries.FLG_Tipo_Doc.Substring(0,IIf(Len(pClsSeries.FLG_Tipo_Doc)> 3, 3,Len(pClsSeries.FLG_Tipo_Doc))))
mCMD.Parameters.AddWithValue("@pAno_Trabalho",pClsSeries.Ano_Trabalho.Substring(0,IIf(Len(pClsSeries.Ano_Trabalho)> 4, 4,Len(pClsSeries.Ano_Trabalho))))
mCMD.Parameters.AddWithValue("@pContador",pClsSeries.Contador)


mStrSQL="UPDATE Series SET "
mStrSQL+="FLG_Tipo_Doc=@pFLG_Tipo_Doc,"
mStrSQL+="Ano_Trabalho=@pAno_Trabalho,"
mStrSQL+="Contador=@pContador "
mStrSQL+="WHERE Cod_Serie=@pCod_Serie"


mDB.ConnectionString = My.Settings.Connection
mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
Catch ex As Exception
Msgbox("ModificaSeries:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 


''' <summary>
'''      Function GravaSeries(ByVal pNovoSeries As ClsSeries) Método para Gravar a TABELA Series
'''      Gerado em 31/01/2024 10:35:38
''' </summary>
''' <returns>
'''      Boolean
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function GravaSeries(ByVal pNovoSeries As ClsSeries) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()


mCMD.Parameters.AddWithValue("@pCod_Serie",pNovoSeries.Cod_Serie.Substring(0,IIf(Len(pNovoSeries.Cod_Serie)> 8, 8,Len(pNovoSeries.Cod_Serie))))
mCMD.Parameters.AddWithValue("@pFLG_Tipo_Doc",pNovoSeries.FLG_Tipo_Doc.Substring(0,IIf(Len(pNovoSeries.FLG_Tipo_Doc)> 3, 3,Len(pNovoSeries.FLG_Tipo_Doc))))
mCMD.Parameters.AddWithValue("@pAno_Trabalho",pNovoSeries.Ano_Trabalho.Substring(0,IIf(Len(pNovoSeries.Ano_Trabalho)> 4, 4,Len(pNovoSeries.Ano_Trabalho))))
mCMD.Parameters.AddWithValue("@pContador",pNovoSeries.Contador)
mCMD.Parameters.AddWithValue("@pFLG_Ativo",pNovoSeries.FLG_Ativo)


mStrSQL="INSERT INTO Series "
mStrSQL+="("
mStrSQL+="Cod_Serie,"
mStrSQL+="FLG_Tipo_Doc,"
mStrSQL+="Ano_Trabalho,"
mStrSQL+="Contador,"
mStrSQL+="FLG_Ativo "
mStrSQL+=") "
mStrSQL+="VALUES "
mStrSQL+="("
mStrSQL+="@pCod_Serie,"
mStrSQL+="@pFLG_Tipo_Doc,"
mStrSQL+="@pAno_Trabalho,"
mStrSQL+="@pContador,"
mStrSQL+="1"
mStrSQL+=")"


mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
'ClsEmpresas.GravaContador(enCont.Series)'<<<<-------- Verificar se é  preciso...
Catch ex As Exception
Msgbox("GravaSeries:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 


''' <summary>
'''      Function ApagaSeries(ByVal pCod_Serie As String) Método para Apagar um Registo da Tabela Series
'''      Gerado em 31/01/2024 10:35:38
''' </summary>
''' <returns>
'''      Boolean
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function ApagaSeries(ByVal pCod_Serie As String) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mCMD.Parameters.Clear()

mCMD.Parameters.AddWithValue("@pCod_Serie", pCod_Serie)


mStrSQL="UPDATE Series SET "
mStrSQL+="FLG_Ativo=0 "
mStrSQL+="WHERE Cod_Serie=@pCod_Serie"


mDB.ConnectionString = My.Settings.Connection
mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
Catch ex As Exception
Msgbox("ApagaSeries:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 
End Class



''' <summary>
'''      Classe SeriesComparer 
'''      Gerado em 31/01/2024 10:35:38
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class SeriesComparer 
Implements IEqualityComparer(Of clsSeries)

Public Function Equals1(ByVal x As clsSeries, ByVal y As clsSeries) As Boolean Implements IEqualityComparer(Of clsSeries).Equals

If x Is y Then Return True

If x Is Nothing OrElse y Is Nothing Then Return False

Return (x.Cod_Serie = y.Cod_Serie) ' AndAlso (x.FLG_Tipo_Doc = y.FLG_Tipo_Doc)
End Function

Public Function GetHashCode1(ByVal pCls As clsSeries) As Integer Implements IEqualityComparer(Of clsSeries).GetHashCode

If pCls Is Nothing Then Return 0

'Dim Hash_ClsSeries_FLG_Tipo_Doc = pCls.FLG_Tipo_Doc.GetHashCode()
Dim Hash_ClsSeries_Cod_Serie = pCls.Cod_Serie.GetHashCode()

Return Hash_ClsSeries_Cod_Serie 'Xor Hash_ClsSeries_FLG_Tipo_Doc
End Function
End Class
