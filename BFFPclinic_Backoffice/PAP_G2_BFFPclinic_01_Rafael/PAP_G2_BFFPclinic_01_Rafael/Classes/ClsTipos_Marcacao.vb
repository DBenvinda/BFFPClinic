
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsTipos_Marcacao Classe da Tabela Tipos_Marcacao
'''      Gerado em 31/01/2024 10:35:38
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class ClsTipos_Marcacao


' -----------------------------------------
' Property's da tabela Tipos_Marcacao
' -----------------------------------------

Public Property Cod_Tipo_Marcacao As String								' Len:  5 - SQL_Type: nvarchar
Public Property Designacao As String									' Len: 20 - SQL_Type: nvarchar
Public Property FLG_Ativo As Boolean									' SQL_Type: bit


Sub New()
End Sub


Friend Shared Function GetNovoCodigo() As String

        Return "TM" & ClsEmpresas.GetContador(enCont.Tipos_Marcacao).ToString("000") ' <-------------- VERIFICAR O Nº de ZEROS

    End Function


''' <summary>
'''      Function GetTipos_Marcacao() Método para devolver a Lista de Tipos_Marcacao
'''      Gerado em 31/01/2024 10:35:38
''' </summary>
''' <returns>
'''      mListaTipos_Marcacao
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function GetTipos_Marcacao() As List(Of clsTipos_Marcacao)
Dim mListaTipos_Marcacao As new List(Of clsTipos_Marcacao)

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand
Dim mRDR As SqlDataReader

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()

mStrSQL="SELECT "
mStrSQL+="ISNULL(Cod_Tipo_Marcacao,'') As Cod_Tipo_Marcacao,"
mStrSQL+="ISNULL(Designacao,'') As Designacao,"
mStrSQL+="ISNULL(FLG_Ativo,1) As FLG_Ativo "
mStrSQL+="FROM Tipos_Marcacao "
mStrSQL+="WHERE FLG_Ativo=1"


mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

mRDR = mCMD.ExecuteReader

While mRDR.Read()

Dim mClsTipos_Marcacao As New ClsTipos_Marcacao

With mClsTipos_Marcacao
.Cod_Tipo_Marcacao = mRDR.GetString(mRDR.GetOrdinal("Cod_Tipo_Marcacao"))
.Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
.FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
End With


mListaTipos_Marcacao.add(mClsTipos_Marcacao)

End While

mRDR.Close()
mDB.Close()

Return mListaTipos_Marcacao
End Function 

''' <summary>
'''      Function FiltrarTipos_Marcacao Método para Filtrar os campos da lista de Tipos_Marcacao
'''      Gerado em 31/01/2024 10:35:38
''' </summary>
''' <returns>
'''      mListaTipos_Marcacao
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function FiltrarTipos_Marcacao(ByVal pFiltro As ClsTipos_Marcacao) As List(Of clsTipos_Marcacao)
Dim mListaTipos_Marcacao As new List(Of clsTipos_Marcacao)
Dim mLista As new List(Of clsTipos_Marcacao)

mListaTipos_Marcacao = GetTipos_Marcacao()

mLista = mListaTipos_Marcacao.FindAll(Function(x) _
x.Cod_Tipo_Marcacao.Contains(pFiltro.Cod_Tipo_Marcacao) 
)
'-----------------------------------------------------
'Pode Colocar em cima mais colunas como esta abaixo...
'-----------------------------------------------------
 ' AND x.Designacao.Contains(pFiltro.Designacao) 

Return mLista
End Function 


''' <summary>
'''      Function GetTipos_MarcacaoByCod(ByVal pCod_Tipo_Marcacao As String) Método para decolver uma Classe de Tipos_Marcacao
'''      Gerado em 31/01/2024 10:35:38
''' </summary>
''' <returns>
'''      mClsTipos_Marcacao
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function GetTipos_MarcacaoByCod(ByVal pCod_Tipo_Marcacao As String) As clsTipos_Marcacao
Dim mClsTipos_Marcacao As new clsTipos_Marcacao

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand
Dim mRDR As SqlDataReader

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()
mCMD.Parameters.AddWithValue("@pCod_Tipo_Marcacao",pCod_Tipo_Marcacao)


mStrSQL="SELECT "
mStrSQL+="ISNULL(Cod_Tipo_Marcacao,'') As Cod_Tipo_Marcacao,"
mStrSQL+="ISNULL(Designacao,'') As Designacao,"
mStrSQL+="ISNULL(FLG_Ativo,1) As FLG_Ativo "
mStrSQL+="FROM Tipos_Marcacao "
mStrSQL+="WHERE FLG_Ativo=1 "
mStrSQL+="AND Cod_Tipo_Marcacao=@pCod_Tipo_Marcacao"


mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

mRDR = mCMD.ExecuteReader

IF mRDR.Read() Then


With mClsTipos_Marcacao
.Cod_Tipo_Marcacao = mRDR.GetString(mRDR.GetOrdinal("Cod_Tipo_Marcacao"))
.Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
.FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
End With


End IF
mRDR.Close()
mDB.Close()

Return mClsTipos_Marcacao
End Function 


''' <summary>
'''      Function ModificaTipos_Marcacao(ByVal pClsTipos_Marcacao As ClsTipos_Marcacao) Método para Modificar a TABELA Tipos_Marcacao
'''      Gerado em 31/01/2024 10:35:38
''' </summary>
''' <returns>
'''      Boolean
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function ModificaTipos_Marcacao(ByVal pClsTipos_Marcacao As ClsTipos_Marcacao) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mCMD.Parameters.Clear()
mCMD.Parameters.AddWithValue("@pCod_Tipo_Marcacao",pClsTipos_Marcacao.Cod_Tipo_Marcacao.Substring(0,IIf(Len(pClsTipos_Marcacao.Cod_Tipo_Marcacao)> 5, 5,Len(pClsTipos_Marcacao.Cod_Tipo_Marcacao))))
mCMD.Parameters.AddWithValue("@pDesignacao",pClsTipos_Marcacao.Designacao.Substring(0,IIf(Len(pClsTipos_Marcacao.Designacao)> 20, 20,Len(pClsTipos_Marcacao.Designacao))))


mStrSQL="UPDATE Tipos_Marcacao SET "
mStrSQL+="Designacao=@pDesignacao "
mStrSQL+="WHERE Cod_Tipo_Marcacao=@pCod_Tipo_Marcacao"


mDB.ConnectionString = My.Settings.Connection
mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
Catch ex As Exception
Msgbox("ModificaTipos_Marcacao:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 


''' <summary>
'''      Function GravaTipos_Marcacao(ByVal pNovoTipos_Marcacao As ClsTipos_Marcacao) Método para Gravar a TABELA Tipos_Marcacao
'''      Gerado em 31/01/2024 10:35:38
''' </summary>
''' <returns>
'''      Boolean
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function GravaTipos_Marcacao(ByVal pNovoTipos_Marcacao As ClsTipos_Marcacao) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()


mCMD.Parameters.AddWithValue("@pCod_Tipo_Marcacao",pNovoTipos_Marcacao.Cod_Tipo_Marcacao.Substring(0,IIf(Len(pNovoTipos_Marcacao.Cod_Tipo_Marcacao)> 5, 5,Len(pNovoTipos_Marcacao.Cod_Tipo_Marcacao))))
mCMD.Parameters.AddWithValue("@pDesignacao",pNovoTipos_Marcacao.Designacao.Substring(0,IIf(Len(pNovoTipos_Marcacao.Designacao)> 20, 20,Len(pNovoTipos_Marcacao.Designacao))))
mCMD.Parameters.AddWithValue("@pFLG_Ativo",pNovoTipos_Marcacao.FLG_Ativo)


mStrSQL="INSERT INTO Tipos_Marcacao "
mStrSQL+="("
mStrSQL+="Cod_Tipo_Marcacao,"
mStrSQL+="Designacao,"
mStrSQL+="FLG_Ativo "
mStrSQL+=") "
mStrSQL+="VALUES "
mStrSQL+="("
mStrSQL+="@pCod_Tipo_Marcacao,"
mStrSQL+="@pDesignacao,"
mStrSQL+="1"
mStrSQL+=")"


mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
ClsEmpresas.GravaContador(enCont.Tipos_Marcacao)
Catch ex As Exception
Msgbox("GravaTipos_Marcacao:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 


''' <summary>
'''      Function ApagaTipos_Marcacao(ByVal pCod_Tipo_Marcacao As String) Método para Apagar um Registo da Tabela Tipos_Marcacao
'''      Gerado em 31/01/2024 10:35:38
''' </summary>
''' <returns>
'''      Boolean
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function ApagaTipos_Marcacao(ByVal pCod_Tipo_Marcacao As String) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mCMD.Parameters.Clear()

mCMD.Parameters.AddWithValue("@pCod_Tipo_Marcacao", pCod_Tipo_Marcacao)


mStrSQL="UPDATE Tipos_Marcacao SET "
mStrSQL+="FLG_Ativo=0 "
mStrSQL+="WHERE Cod_Tipo_Marcacao=@pCod_Tipo_Marcacao"


mDB.ConnectionString = My.Settings.Connection
mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
Catch ex As Exception
Msgbox("ApagaTipos_Marcacao:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 
End Class



''' <summary>
'''      Classe Tipos_MarcacaoComparer 
'''      Gerado em 31/01/2024 10:35:38
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class Tipos_MarcacaoComparer 
Implements IEqualityComparer(Of clsTipos_Marcacao)

Public Function Equals1(ByVal x As clsTipos_Marcacao, ByVal y As clsTipos_Marcacao) As Boolean Implements IEqualityComparer(Of clsTipos_Marcacao).Equals

If x Is y Then Return True

If x Is Nothing OrElse y Is Nothing Then Return False

Return (x.Cod_Tipo_Marcacao = y.Cod_Tipo_Marcacao) ' AndAlso (x.Designacao = y.Designacao)
End Function

Public Function GetHashCode1(ByVal pCls As clsTipos_Marcacao) As Integer Implements IEqualityComparer(Of clsTipos_Marcacao).GetHashCode

If pCls Is Nothing Then Return 0

'Dim Hash_ClsTipos_Marcacao_Designacao = pCls.Designacao.GetHashCode()
Dim Hash_ClsTipos_Marcacao_Cod_Tipo_Marcacao = pCls.Cod_Tipo_Marcacao.GetHashCode()

Return Hash_ClsTipos_Marcacao_Cod_Tipo_Marcacao 'Xor Hash_ClsTipos_Marcacao_Designacao
End Function
End Class
