
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsStatuses Classe da Tabela Statuses
'''      Gerado em 31/01/2024 10:35:38
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class ClsStatuses


    ' -----------------------------------------
    ' Property's da tabela Statuses
    ' -----------------------------------------
    Public Property id As Integer
    Public Property Status_Nome As String									' Len: 30 - SQL_Type: nvarchar
Public Property Status_Brush As String									' Len: 30 - SQL_Type: nvarchar
Public Property Status_Menu As String									' Len: 30 - SQL_Type: nvarchar


Sub New()
End Sub


'--------------------------------------------
' Exemplo de criador de Código por contador
' Para ser usado no caso de o Cdigo ser gerado
' e o contador existir na tabela Empresas
'---------------------------------------------

'Friend Shared Function GetNovoCodigo() As String

'Return "S" & ClsEmpresas.GetContador(enCont.Statuses).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

'End Function


''' <summary>
'''      Function GetStatuses() Método para devolver a Lista de Statuses
'''      Gerado em 31/01/2024 10:35:38
''' </summary>
''' <returns>
'''      mListaStatuses
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function GetStatuses() As List(Of clsStatuses)
Dim mListaStatuses As new List(Of clsStatuses)

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand
Dim mRDR As SqlDataReader

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(id,1) As id,"
        mStrSQL +="ISNULL(Status_Nome,'') As Status_Nome,"
mStrSQL+="ISNULL(Status_Brush,'') As Status_Brush,"
mStrSQL+="ISNULL(Status_Menu,'') As Status_Menu "
mStrSQL+="FROM Statuses "



        mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

mRDR = mCMD.ExecuteReader

While mRDR.Read()

Dim mClsStatuses As New ClsStatuses

            With mClsStatuses
                .id = mRDR.GetValue(mRDR.GetOrdinal("id"))
                .Status_Nome = mRDR.GetString(mRDR.GetOrdinal("Status_Nome"))
                .Status_Brush = mRDR.GetString(mRDR.GetOrdinal("Status_Brush"))
                .Status_Menu = mRDR.GetString(mRDR.GetOrdinal("Status_Menu"))
            End With


            mListaStatuses.add(mClsStatuses)

End While

mRDR.Close()
mDB.Close()

Return mListaStatuses
End Function


    ''' <summary>
    '''      Function GetStatusesByCod(ByVal pStatus_Nome As String) Método para decolver uma Classe de Statuses
    '''      Gerado em 31/01/2024 10:35:38
    ''' </summary>
    ''' <returns>
    '''      mClsStatuses
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function GetStatusesByCod(ByVal pId As Integer) As ClsStatuses
        Dim mClsStatuses As New ClsStatuses

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pId", pId)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(id,1) As id,"
        mStrSQL += "ISNULL(Status_Nome,'') As Status_Nome,"
        mStrSQL += "ISNULL(Status_Brush,'') As Status_Brush,"
        mStrSQL += "ISNULL(Status_Menu,'') As Status_Menu "
        mStrSQL += "FROM Statuses "
        mStrSQL += "WHERE id=@pId "



        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsStatuses
                .id = mRDR.GetValue(mRDR.GetOrdinal("id"))
                .Status_Nome = mRDR.GetString(mRDR.GetOrdinal("Status_Nome"))
                .Status_Brush = mRDR.GetString(mRDR.GetOrdinal("Status_Brush"))
                .Status_Menu = mRDR.GetString(mRDR.GetOrdinal("Status_Menu"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsStatuses
    End Function
    Public Shared Function GetStatusesByName(ByVal pStatus_Nome As String) As ClsStatuses
        Dim mClsStatuses As New ClsStatuses

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pStatus_Nome", pStatus_Nome)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(id,1) As id,"
        mStrSQL += "ISNULL(Status_Nome,'') As Status_Nome,"
        mStrSQL += "ISNULL(Status_Brush,'') As Status_Brush,"
        mStrSQL += "ISNULL(Status_Menu,'') As Status_Menu "
        mStrSQL += "FROM Statuses "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Status_Nome=@pStatus_Nome"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsStatuses
                .id = mRDR.GetValue(mRDR.GetOrdinal("id"))
                .Status_Nome = mRDR.GetString(mRDR.GetOrdinal("Status_Nome"))
                .Status_Brush = mRDR.GetString(mRDR.GetOrdinal("Status_Brush"))
                .Status_Menu = mRDR.GetString(mRDR.GetOrdinal("Status_Menu"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsStatuses
    End Function


    ''' <summary>
    '''      Function ModificaStatuses(ByVal pClsStatuses As ClsStatuses) Método para Modificar a TABELA Statuses
    '''      Gerado em 31/01/2024 10:35:38
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function ModificaStatuses(ByVal pClsStatuses As ClsStatuses) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mCMD.Parameters.Clear()
mCMD.Parameters.AddWithValue("@pStatus_Nome",pClsStatuses.Status_Nome.Substring(0,IIf(Len(pClsStatuses.Status_Nome)> 30, 30,Len(pClsStatuses.Status_Nome))))
mCMD.Parameters.AddWithValue("@pStatus_Brush",pClsStatuses.Status_Brush.Substring(0,IIf(Len(pClsStatuses.Status_Brush)> 30, 30,Len(pClsStatuses.Status_Brush))))


mStrSQL="UPDATE Statuses SET "
mStrSQL+="Status_Brush=@pStatus_Brush "
mStrSQL+="WHERE Status_Nome=@pStatus_Nome"


mDB.ConnectionString = My.Settings.Connection
mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
Catch ex As Exception
Msgbox("ModificaStatuses:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 


''' <summary>
'''      Function GravaStatuses(ByVal pNovoStatuses As ClsStatuses) Método para Gravar a TABELA Statuses
'''      Gerado em 31/01/2024 10:35:38
''' </summary>
''' <returns>
'''      Boolean
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function GravaStatuses(ByVal pNovoStatuses As ClsStatuses) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()


mCMD.Parameters.AddWithValue("@pStatus_Nome",pNovoStatuses.Status_Nome.Substring(0,IIf(Len(pNovoStatuses.Status_Nome)> 30, 30,Len(pNovoStatuses.Status_Nome))))
mCMD.Parameters.AddWithValue("@pStatus_Brush",pNovoStatuses.Status_Brush.Substring(0,IIf(Len(pNovoStatuses.Status_Brush)> 30, 30,Len(pNovoStatuses.Status_Brush))))
mCMD.Parameters.AddWithValue("@pStatus_Menu",pNovoStatuses.Status_Menu.Substring(0,IIf(Len(pNovoStatuses.Status_Menu)> 30, 30,Len(pNovoStatuses.Status_Menu))))


mStrSQL="INSERT INTO Statuses "
mStrSQL+="("
mStrSQL+="Status_Nome,"
mStrSQL+="Status_Brush,"
mStrSQL+="Status_Menu "
mStrSQL+=") "
mStrSQL+="VALUES "
mStrSQL+="("
mStrSQL+="@pStatus_Nome,"
mStrSQL+="@pStatus_Brush,"
mStrSQL+="@pStatus_Menu "
mStrSQL+=")"


mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
'ClsEmpresas.GravaContador(enCont.Statuses)'<<<<-------- Verificar se é  preciso...
Catch ex As Exception
Msgbox("GravaStatuses:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 


''' <summary>
'''      Function ApagaStatuses(ByVal pStatus_Nome As String) Método para Apagar um Registo da Tabela Statuses
'''      Gerado em 31/01/2024 10:35:38
''' </summary>
''' <returns>
'''      Boolean
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function ApagaStatuses(ByVal pStatus_Nome As String) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mCMD.Parameters.Clear()

mCMD.Parameters.AddWithValue("@pStatus_Nome", pStatus_Nome)


mStrSQL="UPDATE Statuses SET "
mStrSQL+="FLG_Ativo=0 "
mStrSQL+="WHERE Status_Nome=@pStatus_Nome"


mDB.ConnectionString = My.Settings.Connection
mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
Catch ex As Exception
Msgbox("ApagaStatuses:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 
End Class

