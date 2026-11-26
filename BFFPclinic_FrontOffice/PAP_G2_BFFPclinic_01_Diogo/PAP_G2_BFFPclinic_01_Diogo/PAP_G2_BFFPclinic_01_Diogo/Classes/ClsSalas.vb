
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsSalas Classe da Tabela Salas
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class ClsSalas


' -----------------------------------------
' Property's da tabela Salas
' -----------------------------------------

Public Property Cod_Sala As String										' Len:  5 - SQL_Type: nvarchar
Public Property Designacao As String									' Len: 30 - SQL_Type: nvarchar
Public Property FLG_Ativo As Boolean									' SQL_Type: bit
Public Property Piso As String											' Len:  2 - SQL_Type: nvarchar
Public Property Num_Sala As String										' Len:  2 - SQL_Type: nvarchar


Sub New()
End Sub


'--------------------------------------------
' Exemplo de criador de Código por contador
' Para ser usado no caso de o Cdigo ser gerado
' e o contador existir na tabela Empresas
'---------------------------------------------

'Friend Shared Function GetNovoCodigo() As String

'Return "S" & ClsEmpresas.GetContador(enCont.Salas).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

'End Function


''' <summary>
'''      Function GetSalas() Método para devolver a Lista de Salas
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <returns>
'''      mListaSalas
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function GetSalas() As List(Of clsSalas)
Dim mListaSalas As new List(Of clsSalas)

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand
Dim mRDR As SqlDataReader

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()

mStrSQL="SELECT "
mStrSQL+="ISNULL(Cod_Sala,'') As Cod_Sala,"
mStrSQL+="ISNULL(Designacao,'') As Designacao,"
mStrSQL+="ISNULL(FLG_Ativo,1) As FLG_Ativo,"
mStrSQL+="ISNULL(Piso,'') As Piso,"
mStrSQL+="ISNULL(Num_Sala,'') As Num_Sala "
mStrSQL+="FROM Salas "
mStrSQL+="WHERE FLG_Ativo=1"


mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

mRDR = mCMD.ExecuteReader

While mRDR.Read()

Dim mClsSalas As New ClsSalas

With mClsSalas
.Cod_Sala = mRDR.GetString(mRDR.GetOrdinal("Cod_Sala"))
.Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
.FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
.Piso = mRDR.GetString(mRDR.GetOrdinal("Piso"))
.Num_Sala = mRDR.GetString(mRDR.GetOrdinal("Num_Sala"))
End With


mListaSalas.add(mClsSalas)

End While

mRDR.Close()
mDB.Close()

Return mListaSalas
End Function 

''' <summary>
'''      Function FiltrarSalas Método para Filtrar os campos da lista de Salas
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <returns>
'''      mListaSalas
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function FiltrarSalas(ByVal pFiltro As ClsSalas) As List(Of clsSalas)
Dim mListaSalas As new List(Of clsSalas)
Dim mLista As new List(Of clsSalas)

mListaSalas = GetSalas()

mLista = mListaSalas.FindAll(Function(x) _
x.Cod_Sala.Contains(pFiltro.Cod_Sala) 
)
'-----------------------------------------------------
'Pode Colocar em cima mais colunas como esta abaixo...
'-----------------------------------------------------
 ' AND x.Designacao.Contains(pFiltro.Designacao) 

Return mLista
End Function 


''' <summary>
'''      Function GetSalasByCod(ByVal pCod_Sala As String) Método para decolver uma Classe de Salas
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <returns>
'''      mClsSalas
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function GetSalasByCod(ByVal pCod_Sala As String) As clsSalas
Dim mClsSalas As new clsSalas

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand
Dim mRDR As SqlDataReader

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()
mCMD.Parameters.AddWithValue("@pCod_Sala",pCod_Sala)


mStrSQL="SELECT "
mStrSQL+="ISNULL(Cod_Sala,'') As Cod_Sala,"
mStrSQL+="ISNULL(Designacao,'') As Designacao,"
mStrSQL+="ISNULL(FLG_Ativo,1) As FLG_Ativo,"
mStrSQL+="ISNULL(Piso,'') As Piso,"
mStrSQL+="ISNULL(Num_Sala,'') As Num_Sala "
mStrSQL+="FROM Salas "
mStrSQL+="WHERE FLG_Ativo=1 "
mStrSQL+="AND Cod_Sala=@pCod_Sala"


mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

mRDR = mCMD.ExecuteReader

IF mRDR.Read() Then


With mClsSalas
.Cod_Sala = mRDR.GetString(mRDR.GetOrdinal("Cod_Sala"))
.Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
.FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
.Piso = mRDR.GetString(mRDR.GetOrdinal("Piso"))
.Num_Sala = mRDR.GetString(mRDR.GetOrdinal("Num_Sala"))
End With


End IF
mRDR.Close()
mDB.Close()

Return mClsSalas
End Function 


''' <summary>
'''      Function ModificaSalas(ByVal pClsSalas As ClsSalas) Método para Modificar a TABELA Salas
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <returns>
'''      Boolean
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function ModificaSalas(ByVal pClsSalas As ClsSalas) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mCMD.Parameters.Clear()
mCMD.Parameters.AddWithValue("@pCod_Sala",pClsSalas.Cod_Sala.Substring(0,IIf(Len(pClsSalas.Cod_Sala)> 5, 5,Len(pClsSalas.Cod_Sala))))
mCMD.Parameters.AddWithValue("@pDesignacao",pClsSalas.Designacao.Substring(0,IIf(Len(pClsSalas.Designacao)> 30, 30,Len(pClsSalas.Designacao))))
mCMD.Parameters.AddWithValue("@pFLG_Ativo",pClsSalas.FLG_Ativo)
mCMD.Parameters.AddWithValue("@pPiso",pClsSalas.Piso.Substring(0,IIf(Len(pClsSalas.Piso)> 2, 2,Len(pClsSalas.Piso))))


mStrSQL="UPDATE Salas SET "
mStrSQL+="Designacao=@pDesignacao,"
mStrSQL+="FLG_Ativo=@pFLG_Ativo,"
mStrSQL+="Piso=@pPiso "
mStrSQL+="WHERE Cod_Sala=@pCod_Sala"


mDB.ConnectionString = My.Settings.Connection
mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
Catch ex As Exception
Msgbox("ModificaSalas:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 


''' <summary>
'''      Function GravaSalas(ByVal pNovoSalas As ClsSalas) Método para Gravar a TABELA Salas
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <returns>
'''      Boolean
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function GravaSalas(ByVal pNovoSalas As ClsSalas) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()


mCMD.Parameters.AddWithValue("@pCod_Sala",pNovoSalas.Cod_Sala.Substring(0,IIf(Len(pNovoSalas.Cod_Sala)> 5, 5,Len(pNovoSalas.Cod_Sala))))
mCMD.Parameters.AddWithValue("@pDesignacao",pNovoSalas.Designacao.Substring(0,IIf(Len(pNovoSalas.Designacao)> 30, 30,Len(pNovoSalas.Designacao))))
mCMD.Parameters.AddWithValue("@pFLG_Ativo",pNovoSalas.FLG_Ativo)
mCMD.Parameters.AddWithValue("@pPiso",pNovoSalas.Piso.Substring(0,IIf(Len(pNovoSalas.Piso)> 2, 2,Len(pNovoSalas.Piso))))
mCMD.Parameters.AddWithValue("@pNum_Sala",pNovoSalas.Num_Sala.Substring(0,IIf(Len(pNovoSalas.Num_Sala)> 2, 2,Len(pNovoSalas.Num_Sala))))


mStrSQL="INSERT INTO Salas "
mStrSQL+="("
mStrSQL+="Cod_Sala,"
mStrSQL+="Designacao,"
mStrSQL+="FLG_Ativo,"
mStrSQL+="Piso,"
mStrSQL+="Num_Sala "
mStrSQL+=") "
mStrSQL+="VALUES "
mStrSQL+="("
mStrSQL+="@pCod_Sala,"
mStrSQL+="@pDesignacao,"
mStrSQL+="@pFLG_Ativo,"
mStrSQL+="@pPiso,"
mStrSQL+="@pNum_Sala "
mStrSQL+=")"


mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
'ClsEmpresas.GravaContador(enCont.Salas)'<<<<-------- Verificar se é  preciso...
Catch ex As Exception
Msgbox("GravaSalas:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 


''' <summary>
'''      Function ApagaSalas(ByVal pCod_Sala As String) Método para Apagar um Registo da Tabela Salas
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <returns>
'''      Boolean
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function ApagaSalas(ByVal pCod_Sala As String) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mCMD.Parameters.Clear()

mCMD.Parameters.AddWithValue("@pCod_Sala", pCod_Sala)


mStrSQL="UPDATE Salas SET "
mStrSQL+="FLG_Ativo=0 "
mStrSQL+="WHERE Cod_Sala=@pCod_Sala"


mDB.ConnectionString = My.Settings.Connection
mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
Catch ex As Exception
Msgbox("ApagaSalas:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 
End Class



''' <summary>
'''      Classe SalasComparer 
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class SalasComparer 
Implements IEqualityComparer(Of clsSalas)

Public Function Equals1(ByVal x As clsSalas, ByVal y As clsSalas) As Boolean Implements IEqualityComparer(Of clsSalas).Equals

If x Is y Then Return True

If x Is Nothing OrElse y Is Nothing Then Return False

Return (x.Cod_Sala = y.Cod_Sala) ' AndAlso (x.Designacao = y.Designacao)
End Function

Public Function GetHashCode1(ByVal pCls As clsSalas) As Integer Implements IEqualityComparer(Of clsSalas).GetHashCode

If pCls Is Nothing Then Return 0

'Dim Hash_ClsSalas_Designacao = pCls.Designacao.GetHashCode()
Dim Hash_ClsSalas_Cod_Sala = pCls.Cod_Sala.GetHashCode()

Return Hash_ClsSalas_Cod_Sala 'Xor Hash_ClsSalas_Designacao
End Function
End Class
