
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsLabels Classe da Tabela Labels
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class ClsLabels


' -----------------------------------------
' Property's da tabela Labels
' -----------------------------------------

Public Property Label_ID As Integer										' SQL_Type: int
Public Property Label_Color As String									' Len: 30 - SQL_Type: nvarchar
Public Property Label_Nome As String									' Len: 30 - SQL_Type: nvarchar
Public Property Label_Menu As String									' Len: 30 - SQL_Type: nvarchar


Sub New()
End Sub


'--------------------------------------------
' Exemplo de criador de Código por contador
' Para ser usado no caso de o Cdigo ser gerado
' e o contador existir na tabela Empresas
'---------------------------------------------

'Friend Shared Function GetNovoCodigo() As String

'Return "L" & ClsEmpresas.GetContador(enCont.Labels).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

'End Function


''' <summary>
'''      Function GetLabels() Método para devolver a Lista de Labels
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <returns>
'''      mListaLabels
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function GetLabels() As List(Of clsLabels)
Dim mListaLabels As new List(Of clsLabels)

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand
Dim mRDR As SqlDataReader

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()

mStrSQL="SELECT "
mStrSQL+="ISNULL(Label_ID,0) As Label_ID,"
mStrSQL+="ISNULL(Label_Color,'') As Label_Color,"
mStrSQL+="ISNULL(Label_Nome,'') As Label_Nome,"
mStrSQL+="ISNULL(Label_Menu,'') As Label_Menu "
        mStrSQL += "FROM Labels"



        mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

mRDR = mCMD.ExecuteReader

While mRDR.Read()

Dim mClsLabels As New ClsLabels

With mClsLabels
.Label_ID = mRDR.Getvalue(mRDR.GetOrdinal("Label_ID"))
.Label_Color = mRDR.GetString(mRDR.GetOrdinal("Label_Color"))
.Label_Nome = mRDR.GetString(mRDR.GetOrdinal("Label_Nome"))
.Label_Menu = mRDR.GetString(mRDR.GetOrdinal("Label_Menu"))
End With


mListaLabels.add(mClsLabels)

End While

mRDR.Close()
mDB.Close()

Return mListaLabels
End Function 


''' <summary>
'''      Function GetLabelsByCod(ByVal pLabel_ID As Integer) Método para decolver uma Classe de Labels
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <returns>
'''      mClsLabels
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function GetLabelsByCod(ByVal pLabel_ID As Integer) As clsLabels
Dim mClsLabels As new clsLabels

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand
Dim mRDR As SqlDataReader

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()
mCMD.Parameters.AddWithValue("@pLabel_ID",pLabel_ID)


mStrSQL="SELECT "
mStrSQL+="ISNULL(Label_ID,0) As Label_ID,"
mStrSQL+="ISNULL(Label_Color,'') As Label_Color,"
mStrSQL+="ISNULL(Label_Nome,'') As Label_Nome,"
mStrSQL+="ISNULL(Label_Menu,'') As Label_Menu "
mStrSQL+="FROM Labels "
mStrSQL+="WHERE FLG_Ativo=1 "
mStrSQL+="AND Label_ID=@pLabel_ID"


mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

mRDR = mCMD.ExecuteReader

IF mRDR.Read() Then


With mClsLabels
.Label_ID = mRDR.Getvalue(mRDR.GetOrdinal("Label_ID"))
.Label_Color = mRDR.GetString(mRDR.GetOrdinal("Label_Color"))
.Label_Nome = mRDR.GetString(mRDR.GetOrdinal("Label_Nome"))
.Label_Menu = mRDR.GetString(mRDR.GetOrdinal("Label_Menu"))
End With


End IF
mRDR.Close()
mDB.Close()

Return mClsLabels
End Function 


''' <summary>
'''      Function ModificaLabels(ByVal pClsLabels As ClsLabels) Método para Modificar a TABELA Labels
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <returns>
'''      Boolean
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function ModificaLabels(ByVal pClsLabels As ClsLabels) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mCMD.Parameters.Clear()
mCMD.Parameters.AddWithValue("@pLabel_ID",pClsLabels.Label_ID)
mCMD.Parameters.AddWithValue("@pLabel_Color",pClsLabels.Label_Color.Substring(0,IIf(Len(pClsLabels.Label_Color)> 30, 30,Len(pClsLabels.Label_Color))))
mCMD.Parameters.AddWithValue("@pLabel_Nome",pClsLabels.Label_Nome.Substring(0,IIf(Len(pClsLabels.Label_Nome)> 30, 30,Len(pClsLabels.Label_Nome))))


mStrSQL="UPDATE Labels SET "
mStrSQL+="Label_Color=@pLabel_Color,"
mStrSQL+="Label_Nome=@pLabel_Nome "
mStrSQL+="WHERE Label_ID=@pLabel_ID"


mDB.ConnectionString = My.Settings.Connection
mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
Catch ex As Exception
Msgbox("ModificaLabels:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 


''' <summary>
'''      Function GravaLabels(ByVal pNovoLabels As ClsLabels) Método para Gravar a TABELA Labels
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <returns>
'''      Boolean
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function GravaLabels(ByVal pNovoLabels As ClsLabels) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()


mCMD.Parameters.AddWithValue("@pLabel_ID",pNovoLabels.Label_ID)
mCMD.Parameters.AddWithValue("@pLabel_Color",pNovoLabels.Label_Color.Substring(0,IIf(Len(pNovoLabels.Label_Color)> 30, 30,Len(pNovoLabels.Label_Color))))
mCMD.Parameters.AddWithValue("@pLabel_Nome",pNovoLabels.Label_Nome.Substring(0,IIf(Len(pNovoLabels.Label_Nome)> 30, 30,Len(pNovoLabels.Label_Nome))))
mCMD.Parameters.AddWithValue("@pLabel_Menu",pNovoLabels.Label_Menu.Substring(0,IIf(Len(pNovoLabels.Label_Menu)> 30, 30,Len(pNovoLabels.Label_Menu))))


mStrSQL="INSERT INTO Labels "
mStrSQL+="("
mStrSQL+="Label_ID,"
mStrSQL+="Label_Color,"
mStrSQL+="Label_Nome,"
mStrSQL+="Label_Menu "
mStrSQL+=") "
mStrSQL+="VALUES "
mStrSQL+="("
mStrSQL+="@pLabel_ID,"
mStrSQL+="@pLabel_Color,"
mStrSQL+="@pLabel_Nome,"
mStrSQL+="@pLabel_Menu "
mStrSQL+=")"


mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
'ClsEmpresas.GravaContador(enCont.Labels)'<<<<-------- Verificar se é  preciso...
Catch ex As Exception
Msgbox("GravaLabels:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 


''' <summary>
'''      Function ApagaLabels(ByVal pLabel_ID As Integer) Método para Apagar um Registo da Tabela Labels
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <returns>
'''      Boolean
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function ApagaLabels(ByVal pLabel_ID As Integer) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mCMD.Parameters.Clear()

mCMD.Parameters.AddWithValue("@pLabel_ID", pLabel_ID)


mStrSQL="UPDATE Labels SET "
mStrSQL+="FLG_Ativo=0 "
mStrSQL+="WHERE Label_ID=@pLabel_ID"


mDB.ConnectionString = My.Settings.Connection
mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
Catch ex As Exception
Msgbox("ApagaLabels:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 
End Class

