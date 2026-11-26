
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsLinhas_Receita Classe da Tabela Linhas_Receita
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class ClsLinhas_Receita


' -----------------------------------------
' Property's da tabela Linhas_Receita
' -----------------------------------------

Public Property Cod_Medicamento As String								' Len:  5 - SQL_Type: nvarchar
Public Property Quantidade As Integer									' SQL_Type: smallint
Public Property Cod_Receita As String									' Len:  5 - SQL_Type: nvarchar
Public Property FLG_Ativo As Boolean									' SQL_Type: bit


Sub New()
End Sub


'--------------------------------------------
' Exemplo de criador de Código por contador
' Para ser usado no caso de o Cdigo ser gerado
' e o contador existir na tabela Empresas
'---------------------------------------------

'Friend Shared Function GetNovoCodigo() As String

'Return "L" & ClsEmpresas.GetContador(enCont.Linhas_Receita).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

'End Function


''' <summary>
'''      Function GetLinhas_Receita() Método para devolver a Lista de Linhas_Receita
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <returns>
'''      mListaLinhas_Receita
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function GetLinhas_Receita() As List(Of clsLinhas_Receita)
Dim mListaLinhas_Receita As new List(Of clsLinhas_Receita)

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand
Dim mRDR As SqlDataReader

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()

mStrSQL="SELECT "
mStrSQL+="ISNULL(Cod_Medicamento,'') As Cod_Medicamento,"
mStrSQL+="ISNULL(Quantidade,0) As Quantidade,"
mStrSQL+="ISNULL(Cod_Receita,'') As Cod_Receita,"
mStrSQL+="ISNULL(FLG_Ativo,1) As FLG_Ativo "
mStrSQL+="FROM Linhas_Receita "
mStrSQL+="WHERE FLG_Ativo=1"


mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

mRDR = mCMD.ExecuteReader

While mRDR.Read()

Dim mClsLinhas_Receita As New ClsLinhas_Receita

With mClsLinhas_Receita
.Cod_Medicamento = mRDR.GetString(mRDR.GetOrdinal("Cod_Medicamento"))
.Quantidade = mRDR.Getvalue(mRDR.GetOrdinal("Quantidade"))
.Cod_Receita = mRDR.GetString(mRDR.GetOrdinal("Cod_Receita"))
.FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
End With


mListaLinhas_Receita.add(mClsLinhas_Receita)

End While

mRDR.Close()
mDB.Close()

Return mListaLinhas_Receita
End Function 

''' <summary>
'''      Function FiltrarLinhas_Receita Método para Filtrar os campos da lista de Linhas_Receita
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <returns>
'''      mListaLinhas_Receita
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function FiltrarLinhas_Receita(ByVal pFiltro As ClsLinhas_Receita) As List(Of clsLinhas_Receita)
Dim mListaLinhas_Receita As new List(Of clsLinhas_Receita)
Dim mLista As new List(Of clsLinhas_Receita)

mListaLinhas_Receita = GetLinhas_Receita()

mLista = mListaLinhas_Receita.FindAll(Function(x) _
x.Cod_Medicamento.Contains(pFiltro.Cod_Medicamento) 
)
'-----------------------------------------------------
'Pode Colocar em cima mais colunas como esta abaixo...
'-----------------------------------------------------
 ' AND x.Quantidade.Contains(pFiltro.Quantidade) 

Return mLista
End Function 


''' <summary>
'''      Function GetLinhas_ReceitaByCod(ByVal pCod_Medicamento As String) Método para decolver uma Classe de Linhas_Receita
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <returns>
'''      mClsLinhas_Receita
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function GetLinhas_ReceitaByCod(ByVal pCod_Medicamento As String) As clsLinhas_Receita
Dim mClsLinhas_Receita As new clsLinhas_Receita

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand
Dim mRDR As SqlDataReader

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()
mCMD.Parameters.AddWithValue("@pCod_Medicamento",pCod_Medicamento)


mStrSQL="SELECT "
mStrSQL+="ISNULL(Cod_Medicamento,'') As Cod_Medicamento,"
mStrSQL+="ISNULL(Quantidade,0) As Quantidade,"
mStrSQL+="ISNULL(Cod_Receita,'') As Cod_Receita,"
mStrSQL+="ISNULL(FLG_Ativo,1) As FLG_Ativo "
mStrSQL+="FROM Linhas_Receita "
mStrSQL+="WHERE FLG_Ativo=1 "
mStrSQL+="AND Cod_Medicamento=@pCod_Medicamento"


mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

mRDR = mCMD.ExecuteReader

IF mRDR.Read() Then


With mClsLinhas_Receita
.Cod_Medicamento = mRDR.GetString(mRDR.GetOrdinal("Cod_Medicamento"))
.Quantidade = mRDR.Getvalue(mRDR.GetOrdinal("Quantidade"))
.Cod_Receita = mRDR.GetString(mRDR.GetOrdinal("Cod_Receita"))
.FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
End With


End IF
mRDR.Close()
mDB.Close()

Return mClsLinhas_Receita
End Function 


''' <summary>
'''      Function ModificaLinhas_Receita(ByVal pClsLinhas_Receita As ClsLinhas_Receita) Método para Modificar a TABELA Linhas_Receita
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <returns>
'''      Boolean
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function ModificaLinhas_Receita(ByVal pClsLinhas_Receita As ClsLinhas_Receita) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mCMD.Parameters.Clear()
mCMD.Parameters.AddWithValue("@pCod_Medicamento",pClsLinhas_Receita.Cod_Medicamento.Substring(0,IIf(Len(pClsLinhas_Receita.Cod_Medicamento)> 5, 5,Len(pClsLinhas_Receita.Cod_Medicamento))))
mCMD.Parameters.AddWithValue("@pQuantidade",pClsLinhas_Receita.Quantidade)
mCMD.Parameters.AddWithValue("@pCod_Receita",pClsLinhas_Receita.Cod_Receita.Substring(0,IIf(Len(pClsLinhas_Receita.Cod_Receita)> 5, 5,Len(pClsLinhas_Receita.Cod_Receita))))


mStrSQL="UPDATE Linhas_Receita SET "
mStrSQL+="Quantidade=@pQuantidade,"
mStrSQL+="Cod_Receita=@pCod_Receita "
mStrSQL+="WHERE Cod_Medicamento=@pCod_Medicamento"


mDB.ConnectionString = My.Settings.Connection
mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
Catch ex As Exception
Msgbox("ModificaLinhas_Receita:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 


''' <summary>
'''      Function GravaLinhas_Receita(ByVal pNovoLinhas_Receita As ClsLinhas_Receita) Método para Gravar a TABELA Linhas_Receita
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <returns>
'''      Boolean
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function GravaLinhas_Receita(ByVal pNovoLinhas_Receita As ClsLinhas_Receita) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()


mCMD.Parameters.AddWithValue("@pCod_Medicamento",pNovoLinhas_Receita.Cod_Medicamento.Substring(0,IIf(Len(pNovoLinhas_Receita.Cod_Medicamento)> 5, 5,Len(pNovoLinhas_Receita.Cod_Medicamento))))
mCMD.Parameters.AddWithValue("@pQuantidade",pNovoLinhas_Receita.Quantidade)
mCMD.Parameters.AddWithValue("@pCod_Receita",pNovoLinhas_Receita.Cod_Receita.Substring(0,IIf(Len(pNovoLinhas_Receita.Cod_Receita)> 5, 5,Len(pNovoLinhas_Receita.Cod_Receita))))
mCMD.Parameters.AddWithValue("@pFLG_Ativo",pNovoLinhas_Receita.FLG_Ativo)


mStrSQL="INSERT INTO Linhas_Receita "
mStrSQL+="("
mStrSQL+="Cod_Medicamento,"
mStrSQL+="Quantidade,"
mStrSQL+="Cod_Receita,"
mStrSQL+="FLG_Ativo "
mStrSQL+=") "
mStrSQL+="VALUES "
mStrSQL+="("
mStrSQL+="@pCod_Medicamento,"
mStrSQL+="@pQuantidade,"
mStrSQL+="@pCod_Receita,"
mStrSQL+="1"
mStrSQL+=")"


mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
'ClsEmpresas.GravaContador(enCont.Linhas_Receita)'<<<<-------- Verificar se é  preciso...
Catch ex As Exception
Msgbox("GravaLinhas_Receita:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 


''' <summary>
'''      Function ApagaLinhas_Receita(ByVal pCod_Medicamento As String) Método para Apagar um Registo da Tabela Linhas_Receita
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <returns>
'''      Boolean
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function ApagaLinhas_Receita(ByVal pCod_Medicamento As String) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mCMD.Parameters.Clear()

mCMD.Parameters.AddWithValue("@pCod_Medicamento", pCod_Medicamento)


mStrSQL="UPDATE Linhas_Receita SET "
mStrSQL+="FLG_Ativo=0 "
mStrSQL+="WHERE Cod_Medicamento=@pCod_Medicamento"


mDB.ConnectionString = My.Settings.Connection
mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
Catch ex As Exception
Msgbox("ApagaLinhas_Receita:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 
End Class



''' <summary>
'''      Classe Linhas_ReceitaComparer 
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class Linhas_ReceitaComparer 
Implements IEqualityComparer(Of clsLinhas_Receita)

Public Function Equals1(ByVal x As clsLinhas_Receita, ByVal y As clsLinhas_Receita) As Boolean Implements IEqualityComparer(Of clsLinhas_Receita).Equals

If x Is y Then Return True

If x Is Nothing OrElse y Is Nothing Then Return False

Return (x.Cod_Medicamento = y.Cod_Medicamento) ' AndAlso (x.Quantidade = y.Quantidade)
End Function

Public Function GetHashCode1(ByVal pCls As clsLinhas_Receita) As Integer Implements IEqualityComparer(Of clsLinhas_Receita).GetHashCode

If pCls Is Nothing Then Return 0

'Dim Hash_ClsLinhas_Receita_Quantidade = pCls.Quantidade.GetHashCode()
Dim Hash_ClsLinhas_Receita_Cod_Medicamento = pCls.Cod_Medicamento.GetHashCode()

Return Hash_ClsLinhas_Receita_Cod_Medicamento 'Xor Hash_ClsLinhas_Receita_Quantidade
End Function
End Class
