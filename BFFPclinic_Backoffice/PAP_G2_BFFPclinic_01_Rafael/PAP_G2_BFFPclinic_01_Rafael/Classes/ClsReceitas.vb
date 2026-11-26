
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsReceitas Classe da Tabela Receitas
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class ClsReceitas


' -----------------------------------------
' Property's da tabela Receitas
' -----------------------------------------

Public Property Cod_Receita As String									' Len:  5 - SQL_Type: nvarchar
Public Property Data_Emissao As Date									' SQL_Type: smalldatetime
Public Property Data_Vencimento As Date									' SQL_Type: smalldatetime
Public Property Cod_Medico As String									' Len:  5 - SQL_Type: nvarchar
Public Property Cod_Utente As String									' Len:  5 - SQL_Type: nvarchar
Public Property Local_Prescricao As String								' Len: 30 - SQL_Type: nvarchar
Public Property Num_Telefone As String									' Len: 20 - SQL_Type: nvarchar
Public Property FLG_Ativo As Boolean									' SQL_Type: bit


Sub New()
End Sub


Friend Shared Function GetNovoCodigo() As String

Return "R" & ClsEmpresas.GetContador(enCont.Receitas).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

End Function


''' <summary>
'''      Function GetReceitas() Método para devolver a Lista de Receitas
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <returns>
'''      mListaReceitas
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function GetReceitas() As List(Of clsReceitas)
Dim mListaReceitas As new List(Of clsReceitas)

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand
Dim mRDR As SqlDataReader

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()

mStrSQL="SELECT "
mStrSQL+="ISNULL(Cod_Receita,'') As Cod_Receita,"
mStrSQL+="ISNULL(Data_Emissao,0) As Data_Emissao,"
mStrSQL+="ISNULL(Data_Vencimento,0) As Data_Vencimento,"
mStrSQL+="ISNULL(Cod_Medico,'') As Cod_Medico,"
mStrSQL+="ISNULL(Cod_Utente,'') As Cod_Utente,"
mStrSQL+="ISNULL(Local_Prescricao,'') As Local_Prescricao,"
mStrSQL+="ISNULL(Num_Telefone,'') As Num_Telefone,"
mStrSQL+="ISNULL(FLG_Ativo,1) As FLG_Ativo "
mStrSQL+="FROM Receitas "
mStrSQL+="WHERE FLG_Ativo=1"


mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

mRDR = mCMD.ExecuteReader

While mRDR.Read()

Dim mClsReceitas As New ClsReceitas

With mClsReceitas
.Cod_Receita = mRDR.GetString(mRDR.GetOrdinal("Cod_Receita"))
.Data_Emissao = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Emissao"))
.Data_Vencimento = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Vencimento"))
.Cod_Medico = mRDR.GetString(mRDR.GetOrdinal("Cod_Medico"))
.Cod_Utente = mRDR.GetString(mRDR.GetOrdinal("Cod_Utente"))
.Local_Prescricao = mRDR.GetString(mRDR.GetOrdinal("Local_Prescricao"))
.Num_Telefone = mRDR.GetString(mRDR.GetOrdinal("Num_Telefone"))
.FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
End With


mListaReceitas.add(mClsReceitas)

End While

mRDR.Close()
mDB.Close()

Return mListaReceitas
End Function 

''' <summary>
'''      Function FiltrarReceitas Método para Filtrar os campos da lista de Receitas
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <returns>
'''      mListaReceitas
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function FiltrarReceitas(ByVal pFiltro As ClsReceitas) As List(Of clsReceitas)
Dim mListaReceitas As new List(Of clsReceitas)
Dim mLista As new List(Of clsReceitas)

mListaReceitas = GetReceitas()

mLista = mListaReceitas.FindAll(Function(x) _
x.Cod_Receita.Contains(pFiltro.Cod_Receita) 
)
'-----------------------------------------------------
'Pode Colocar em cima mais colunas como esta abaixo...
'-----------------------------------------------------
 ' AND x.Data_Emissao.Contains(pFiltro.Data_Emissao) 

Return mLista
End Function 


''' <summary>
'''      Function GetReceitasByCod(ByVal pCod_Receita As String) Método para decolver uma Classe de Receitas
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <returns>
'''      mClsReceitas
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function GetReceitasByCod(ByVal pCod_Receita As String) As clsReceitas
Dim mClsReceitas As new clsReceitas

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand
Dim mRDR As SqlDataReader

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()
mCMD.Parameters.AddWithValue("@pCod_Receita",pCod_Receita)


mStrSQL="SELECT "
mStrSQL+="ISNULL(Cod_Receita,'') As Cod_Receita,"
mStrSQL+="ISNULL(Data_Emissao,0) As Data_Emissao,"
mStrSQL+="ISNULL(Data_Vencimento,0) As Data_Vencimento,"
mStrSQL+="ISNULL(Cod_Medico,'') As Cod_Medico,"
mStrSQL+="ISNULL(Cod_Utente,'') As Cod_Utente,"
mStrSQL+="ISNULL(Local_Prescricao,'') As Local_Prescricao,"
mStrSQL+="ISNULL(Num_Telefone,'') As Num_Telefone,"
mStrSQL+="ISNULL(FLG_Ativo,1) As FLG_Ativo "
mStrSQL+="FROM Receitas "
mStrSQL+="WHERE FLG_Ativo=1 "
mStrSQL+="AND Cod_Receita=@pCod_Receita"


mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

mRDR = mCMD.ExecuteReader

IF mRDR.Read() Then


With mClsReceitas
.Cod_Receita = mRDR.GetString(mRDR.GetOrdinal("Cod_Receita"))
.Data_Emissao = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Emissao"))
.Data_Vencimento = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Vencimento"))
.Cod_Medico = mRDR.GetString(mRDR.GetOrdinal("Cod_Medico"))
.Cod_Utente = mRDR.GetString(mRDR.GetOrdinal("Cod_Utente"))
.Local_Prescricao = mRDR.GetString(mRDR.GetOrdinal("Local_Prescricao"))
.Num_Telefone = mRDR.GetString(mRDR.GetOrdinal("Num_Telefone"))
.FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
End With


End IF
mRDR.Close()
mDB.Close()

Return mClsReceitas
End Function 


''' <summary>
'''      Function ModificaReceitas(ByVal pClsReceitas As ClsReceitas) Método para Modificar a TABELA Receitas
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <returns>
'''      Boolean
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function ModificaReceitas(ByVal pClsReceitas As ClsReceitas) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mCMD.Parameters.Clear()
mCMD.Parameters.AddWithValue("@pCod_Receita",pClsReceitas.Cod_Receita.Substring(0,IIf(Len(pClsReceitas.Cod_Receita)> 5, 5,Len(pClsReceitas.Cod_Receita))))
mCMD.Parameters.AddWithValue("@pData_Emissao",pClsReceitas.Data_Emissao)
mCMD.Parameters.AddWithValue("@pData_Vencimento",pClsReceitas.Data_Vencimento)
mCMD.Parameters.AddWithValue("@pCod_Medico",pClsReceitas.Cod_Medico.Substring(0,IIf(Len(pClsReceitas.Cod_Medico)> 5, 5,Len(pClsReceitas.Cod_Medico))))
mCMD.Parameters.AddWithValue("@pCod_Utente",pClsReceitas.Cod_Utente.Substring(0,IIf(Len(pClsReceitas.Cod_Utente)> 5, 5,Len(pClsReceitas.Cod_Utente))))
mCMD.Parameters.AddWithValue("@pLocal_Prescricao",pClsReceitas.Local_Prescricao.Substring(0,IIf(Len(pClsReceitas.Local_Prescricao)> 30, 30,Len(pClsReceitas.Local_Prescricao))))
mCMD.Parameters.AddWithValue("@pNum_Telefone",pClsReceitas.Num_Telefone.Substring(0,IIf(Len(pClsReceitas.Num_Telefone)> 20, 20,Len(pClsReceitas.Num_Telefone))))


mStrSQL="UPDATE Receitas SET "
mStrSQL+="Data_Emissao=@pData_Emissao,"
mStrSQL+="Data_Vencimento=@pData_Vencimento,"
mStrSQL+="Cod_Medico=@pCod_Medico,"
mStrSQL+="Cod_Utente=@pCod_Utente,"
mStrSQL+="Local_Prescricao=@pLocal_Prescricao,"
mStrSQL+="Num_Telefone=@pNum_Telefone "
mStrSQL+="WHERE Cod_Receita=@pCod_Receita"


mDB.ConnectionString = My.Settings.Connection
mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
Catch ex As Exception
Msgbox("ModificaReceitas:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 


''' <summary>
'''      Function GravaReceitas(ByVal pNovoReceitas As ClsReceitas) Método para Gravar a TABELA Receitas
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <returns>
'''      Boolean
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function GravaReceitas(ByVal pNovoReceitas As ClsReceitas) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()


mCMD.Parameters.AddWithValue("@pCod_Receita",pNovoReceitas.Cod_Receita.Substring(0,IIf(Len(pNovoReceitas.Cod_Receita)> 5, 5,Len(pNovoReceitas.Cod_Receita))))
mCMD.Parameters.AddWithValue("@pData_Emissao",pNovoReceitas.Data_Emissao)
mCMD.Parameters.AddWithValue("@pData_Vencimento",pNovoReceitas.Data_Vencimento)
mCMD.Parameters.AddWithValue("@pCod_Medico",pNovoReceitas.Cod_Medico.Substring(0,IIf(Len(pNovoReceitas.Cod_Medico)> 5, 5,Len(pNovoReceitas.Cod_Medico))))
mCMD.Parameters.AddWithValue("@pCod_Utente",pNovoReceitas.Cod_Utente.Substring(0,IIf(Len(pNovoReceitas.Cod_Utente)> 5, 5,Len(pNovoReceitas.Cod_Utente))))
mCMD.Parameters.AddWithValue("@pLocal_Prescricao",pNovoReceitas.Local_Prescricao.Substring(0,IIf(Len(pNovoReceitas.Local_Prescricao)> 30, 30,Len(pNovoReceitas.Local_Prescricao))))
mCMD.Parameters.AddWithValue("@pNum_Telefone",pNovoReceitas.Num_Telefone.Substring(0,IIf(Len(pNovoReceitas.Num_Telefone)> 20, 20,Len(pNovoReceitas.Num_Telefone))))
mCMD.Parameters.AddWithValue("@pFLG_Ativo",pNovoReceitas.FLG_Ativo)


mStrSQL="INSERT INTO Receitas "
mStrSQL+="("
mStrSQL+="Cod_Receita,"
mStrSQL+="Data_Emissao,"
mStrSQL+="Data_Vencimento,"
mStrSQL+="Cod_Medico,"
mStrSQL+="Cod_Utente,"
mStrSQL+="Local_Prescricao,"
mStrSQL+="Num_Telefone,"
mStrSQL+="FLG_Ativo "
mStrSQL+=") "
mStrSQL+="VALUES "
mStrSQL+="("
mStrSQL+="@pCod_Receita,"
mStrSQL+="@pData_Emissao,"
mStrSQL+="@pData_Vencimento,"
mStrSQL+="@pCod_Medico,"
mStrSQL+="@pCod_Utente,"
mStrSQL+="@pLocal_Prescricao,"
mStrSQL+="@pNum_Telefone,"
mStrSQL+="1"
mStrSQL+=")"


mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
ClsEmpresas.GravaContador(enCont.Receitas)
Catch ex As Exception
Msgbox("GravaReceitas:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 


''' <summary>
'''      Function ApagaReceitas(ByVal pCod_Receita As String) Método para Apagar um Registo da Tabela Receitas
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <returns>
'''      Boolean
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function ApagaReceitas(ByVal pCod_Receita As String) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mCMD.Parameters.Clear()

mCMD.Parameters.AddWithValue("@pCod_Receita", pCod_Receita)


mStrSQL="UPDATE Receitas SET "
mStrSQL+="FLG_Ativo=0 "
mStrSQL+="WHERE Cod_Receita=@pCod_Receita"


mDB.ConnectionString = My.Settings.Connection
mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
Catch ex As Exception
Msgbox("ApagaReceitas:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 
End Class



''' <summary>
'''      Classe ReceitasComparer 
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class ReceitasComparer 
Implements IEqualityComparer(Of clsReceitas)

Public Function Equals1(ByVal x As clsReceitas, ByVal y As clsReceitas) As Boolean Implements IEqualityComparer(Of clsReceitas).Equals

If x Is y Then Return True

If x Is Nothing OrElse y Is Nothing Then Return False

Return (x.Cod_Receita = y.Cod_Receita) ' AndAlso (x.Data_Emissao = y.Data_Emissao)
End Function

Public Function GetHashCode1(ByVal pCls As clsReceitas) As Integer Implements IEqualityComparer(Of clsReceitas).GetHashCode

If pCls Is Nothing Then Return 0

'Dim Hash_ClsReceitas_Data_Emissao = pCls.Data_Emissao.GetHashCode()
Dim Hash_ClsReceitas_Cod_Receita = pCls.Cod_Receita.GetHashCode()

Return Hash_ClsReceitas_Cod_Receita 'Xor Hash_ClsReceitas_Data_Emissao
End Function
End Class
