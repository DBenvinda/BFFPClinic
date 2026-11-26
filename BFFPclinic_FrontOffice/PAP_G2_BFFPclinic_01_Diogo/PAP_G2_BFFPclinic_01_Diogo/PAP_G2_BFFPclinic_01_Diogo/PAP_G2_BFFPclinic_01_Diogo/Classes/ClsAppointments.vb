
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsAppointments Classe da Tabela Appointments
'''      Gerado em 31/01/2024 10:35:35
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class ClsAppointments


' -----------------------------------------
' Property's da tabela Appointments
' -----------------------------------------

Public Property UniqueID As Integer										' SQL_Type: int
Public Property Type As Integer											' SQL_Type: int
Public Property StartDate As Date										' SQL_Type: datetime
Public Property EndDate As Date											' SQL_Type: datetime
Public Property QueryStartDate As Date									' SQL_Type: datetime
Public Property QueryEndDate As Date									' SQL_Type: datetime
Public Property AllDay As Boolean										' SQL_Type: bit
Public Property Description As String									' Len: -1 - SQL_Type: nvarchar
Public Property Status As Integer										' SQL_Type: int
Public Property Label As Integer										' SQL_Type: int
Public Property ResourceID As Integer									' SQL_Type: int
Public Property ResourceIDs As String									' Len: -1 - SQL_Type: nvarchar
Public Property ReminderInfo As String									' Len: -1 - SQL_Type: nvarchar
Public Property RecurrenceInfo As String								' Len: -1 - SQL_Type: nvarchar
Public Property TimeZoneId As String									' Len: -1 - SQL_Type: nvarchar
Public Property Subject As String										' Len: 50 - SQL_Type: nvarchar
Public Property Location As String                                      ' Len: 50 - SQL_Type: nvarchar
    Public Property customField1 As String                                  ' Len: -1 - SQL_Type: nvarchar

    Public Property customField2 As String                                  ' Len: -1 - SQL_Type: nvarchar


    Sub New()
End Sub


'--------------------------------------------
' Exemplo de criador de Código por contador
' Para ser usado no caso de o Cdigo ser gerado
' e o contador existir na tabela Empresas
'---------------------------------------------

'Friend Shared Function GetNovoCodigo() As String

'Return "A" & ClsEmpresas.GetContador(enCont.Appointments).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

'End Function


''' <summary>
'''      Function GetAppointments() Método para devolver a Lista de Appointments
'''      Gerado em 31/01/2024 10:35:35
''' </summary>
''' <returns>
'''      mListaAppointments
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function GetAppointments() As List(Of clsAppointments)
Dim mListaAppointments As new List(Of clsAppointments)

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand
Dim mRDR As SqlDataReader

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()

mStrSQL="SELECT "
mStrSQL+="ISNULL(UniqueID,0) As UniqueID,"
mStrSQL+="ISNULL(Type,0) As Type,"
mStrSQL+="ISNULL(StartDate,0) As StartDate,"
mStrSQL+="ISNULL(EndDate,0) As EndDate,"
mStrSQL+="ISNULL(QueryStartDate,0) As QueryStartDate,"
mStrSQL+="ISNULL(QueryEndDate,0) As QueryEndDate,"
mStrSQL+="ISNULL(AllDay,1) As AllDay,"
mStrSQL+="ISNULL(Description,'') As Description,"
mStrSQL+="ISNULL(Status,0) As Status,"
mStrSQL+="ISNULL(Label,0) As Label,"
mStrSQL+="ISNULL(ResourceID,0) As ResourceID,"
mStrSQL+="ISNULL(ResourceIDs,'') As ResourceIDs,"
mStrSQL+="ISNULL(ReminderInfo,'') As ReminderInfo,"
mStrSQL+="ISNULL(RecurrenceInfo,'') As RecurrenceInfo,"
mStrSQL+="ISNULL(TimeZoneId,'') As TimeZoneId,"
mStrSQL+="ISNULL(Subject,'') As Subject,"
mStrSQL+="ISNULL(Location,'') As Location,"
mStrSQL+="ISNULL(customField1,'') As customField1 "
mStrSQL+="FROM Appointments "
mStrSQL+="WHERE FLG_Ativo=1"


mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

mRDR = mCMD.ExecuteReader

While mRDR.Read()

Dim mClsAppointments As New ClsAppointments

With mClsAppointments
.UniqueID = mRDR.Getvalue(mRDR.GetOrdinal("UniqueID"))
.Type = mRDR.Getvalue(mRDR.GetOrdinal("Type"))
.StartDate = mRDR.GetDateTime(mRDR.GetOrdinal("StartDate"))
.EndDate = mRDR.GetDateTime(mRDR.GetOrdinal("EndDate"))
.QueryStartDate = mRDR.GetDateTime(mRDR.GetOrdinal("QueryStartDate"))
.QueryEndDate = mRDR.GetDateTime(mRDR.GetOrdinal("QueryEndDate"))
.AllDay = mRDR.GetBoolean(mRDR.GetOrdinal("AllDay"))
.Description = mRDR.GetString(mRDR.GetOrdinal("Description"))
.Status = mRDR.Getvalue(mRDR.GetOrdinal("Status"))
.Label = mRDR.Getvalue(mRDR.GetOrdinal("Label"))
.ResourceID = mRDR.Getvalue(mRDR.GetOrdinal("ResourceID"))
.ResourceIDs = mRDR.GetString(mRDR.GetOrdinal("ResourceIDs"))
.ReminderInfo = mRDR.GetString(mRDR.GetOrdinal("ReminderInfo"))
.RecurrenceInfo = mRDR.GetString(mRDR.GetOrdinal("RecurrenceInfo"))
.TimeZoneId = mRDR.GetString(mRDR.GetOrdinal("TimeZoneId"))
.Subject = mRDR.GetString(mRDR.GetOrdinal("Subject"))
.Location = mRDR.GetString(mRDR.GetOrdinal("Location"))
                .customField1 = mRDR.GetString(mRDR.GetOrdinal("customField1"))
                .customField2 = mRDR.GetString(mRDR.GetOrdinal("customField2"))
            End With


mListaAppointments.add(mClsAppointments)

End While

mRDR.Close()
mDB.Close()

Return mListaAppointments
End Function


    ''' <summary>
    '''      Function GetAppointmentsByCod(ByVal pUniqueID As Integer) Método para decolver uma Classe de Appointments
    '''      Gerado em 31/01/2024 10:35:35
    ''' </summary>
    ''' <returns>
    '''      mClsAppointments
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    ''' 
    Public Shared Function GetAppointmentsByCod_Marcacao(ByVal pCod_Marcacao As String) As ClsAppointments
        Dim mClsAppointments As New ClsAppointments

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Marcacao", pCod_Marcacao)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(UniqueID,0) As UniqueID,"
        mStrSQL += "ISNULL(Type,0) As Type,"
        mStrSQL += "ISNULL(StartDate,0) As StartDate,"
        mStrSQL += "ISNULL(EndDate,0) As EndDate,"
        mStrSQL += "ISNULL(QueryStartDate,0) As QueryStartDate,"
        mStrSQL += "ISNULL(QueryEndDate,0) As QueryEndDate,"
        mStrSQL += "ISNULL(AllDay,1) As AllDay,"
        mStrSQL += "ISNULL(Description,'') As Description,"
        mStrSQL += "ISNULL(Status,0) As Status,"
        mStrSQL += "ISNULL(Label,0) As Label,"
        mStrSQL += "ISNULL(ResourceID,0) As ResourceID,"
        mStrSQL += "ISNULL(ResourceIDs,'') As ResourceIDs,"
        mStrSQL += "ISNULL(ReminderInfo,'') As ReminderInfo,"
        mStrSQL += "ISNULL(RecurrenceInfo,'') As RecurrenceInfo,"
        mStrSQL += "ISNULL(TimeZoneId,'') As TimeZoneId,"
        mStrSQL += "ISNULL(Subject,'') As Subject,"
        mStrSQL += "ISNULL(Location,'') As Location,"
        mStrSQL += "ISNULL(customField1,'') As customField1,"
        mStrSQL += "ISNULL(customField2,'') As customField2 "
        mStrSQL += "FROM Appointments "
        mStrSQL += "WHERE customField1=@pCod_Marcacao"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsAppointments
                .UniqueID = mRDR.GetValue(mRDR.GetOrdinal("UniqueID"))
                .Type = mRDR.GetValue(mRDR.GetOrdinal("Type"))
                .StartDate = mRDR.GetDateTime(mRDR.GetOrdinal("StartDate"))
                .EndDate = mRDR.GetDateTime(mRDR.GetOrdinal("EndDate"))
                .QueryStartDate = mRDR.GetDateTime(mRDR.GetOrdinal("QueryStartDate"))
                .QueryEndDate = mRDR.GetDateTime(mRDR.GetOrdinal("QueryEndDate"))
                .AllDay = mRDR.GetBoolean(mRDR.GetOrdinal("AllDay"))
                .Description = mRDR.GetString(mRDR.GetOrdinal("Description"))
                .Status = mRDR.GetValue(mRDR.GetOrdinal("Status"))
                .Label = mRDR.GetValue(mRDR.GetOrdinal("Label"))
                .ResourceID = mRDR.GetValue(mRDR.GetOrdinal("ResourceID"))
                .ResourceIDs = mRDR.GetString(mRDR.GetOrdinal("ResourceIDs"))
                .ReminderInfo = mRDR.GetString(mRDR.GetOrdinal("ReminderInfo"))
                .RecurrenceInfo = mRDR.GetString(mRDR.GetOrdinal("RecurrenceInfo"))
                .TimeZoneId = mRDR.GetString(mRDR.GetOrdinal("TimeZoneId"))
                .Subject = mRDR.GetString(mRDR.GetOrdinal("Subject"))
                .Location = mRDR.GetString(mRDR.GetOrdinal("Location"))
                .customField1 = mRDR.GetString(mRDR.GetOrdinal("customField1"))
                .customField2 = mRDR.GetString(mRDR.GetOrdinal("customField2"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsAppointments
    End Function

    Public Shared Function GetAppointmentsBy_Subject(ByVal pSubject As String, pcod_TM As String) As List(Of ClsAppointments)
        Dim mListaAppointments As New List(Of ClsAppointments)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pSubject", pSubject)
        mCMD.Parameters.AddWithValue("@pcod_TM", pcod_TM)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(UniqueID,0) As UniqueID,"
        mStrSQL += "ISNULL(Type,0) As Type,"
        mStrSQL += "ISNULL(StartDate,0) As StartDate,"
        mStrSQL += "ISNULL(EndDate,0) As EndDate,"
        mStrSQL += "ISNULL(QueryStartDate,0) As QueryStartDate,"
        mStrSQL += "ISNULL(QueryEndDate,0) As QueryEndDate,"
        mStrSQL += "ISNULL(AllDay,1) As AllDay,"
        mStrSQL += "ISNULL(Description,'') As Description,"
        mStrSQL += "ISNULL(Status,0) As Status,"
        mStrSQL += "ISNULL(Label,0) As Label,"
        mStrSQL += "ISNULL(ResourceID,0) As ResourceID,"
        mStrSQL += "ISNULL(ResourceIDs,'') As ResourceIDs,"
        mStrSQL += "ISNULL(ReminderInfo,'') As ReminderInfo,"
        mStrSQL += "ISNULL(RecurrenceInfo,'') As RecurrenceInfo,"
        mStrSQL += "ISNULL(TimeZoneId,'') As TimeZoneId,"
        mStrSQL += "ISNULL(Subject,'') As Subject,"
        mStrSQL += "ISNULL(Location,'') As Location,"
        mStrSQL += "ISNULL(customField1,'') As customField1,"
        mStrSQL += "ISNULL(customField2,'') As customField2 "
        mStrSQL += "FROM Appointments "
        mStrSQL += "WHERE Subject=@pSubject and customfield2=@pcod_TM"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsAppointments As New ClsAppointments

            With mClsAppointments
                .UniqueID = mRDR.GetValue(mRDR.GetOrdinal("UniqueID"))
                .Type = mRDR.GetValue(mRDR.GetOrdinal("Type"))
                .StartDate = mRDR.GetDateTime(mRDR.GetOrdinal("StartDate"))
                .EndDate = mRDR.GetDateTime(mRDR.GetOrdinal("EndDate"))
                .QueryStartDate = mRDR.GetDateTime(mRDR.GetOrdinal("QueryStartDate"))
                .QueryEndDate = mRDR.GetDateTime(mRDR.GetOrdinal("QueryEndDate"))
                .AllDay = mRDR.GetBoolean(mRDR.GetOrdinal("AllDay"))
                .Description = mRDR.GetString(mRDR.GetOrdinal("Description"))
                .Status = mRDR.GetValue(mRDR.GetOrdinal("Status"))
                .Label = mRDR.GetValue(mRDR.GetOrdinal("Label"))
                .ResourceID = mRDR.GetValue(mRDR.GetOrdinal("ResourceID"))
                .ResourceIDs = mRDR.GetString(mRDR.GetOrdinal("ResourceIDs"))
                .ReminderInfo = mRDR.GetString(mRDR.GetOrdinal("ReminderInfo"))
                .RecurrenceInfo = mRDR.GetString(mRDR.GetOrdinal("RecurrenceInfo"))
                .TimeZoneId = mRDR.GetString(mRDR.GetOrdinal("TimeZoneId"))
                .Subject = mRDR.GetString(mRDR.GetOrdinal("Subject"))
                .Location = mRDR.GetString(mRDR.GetOrdinal("Location"))
                .customField1 = mRDR.GetString(mRDR.GetOrdinal("customField1"))
                .customField2 = mRDR.GetString(mRDR.GetOrdinal("customField2"))
            End With


            mListaAppointments.Add(mClsAppointments)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaAppointments
    End Function
    Public Shared Function GetAppointmentsByCod(ByVal pUniqueID As Integer) As clsAppointments
Dim mClsAppointments As new clsAppointments

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand
Dim mRDR As SqlDataReader

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()
mCMD.Parameters.AddWithValue("@pUniqueID",pUniqueID)


mStrSQL="SELECT "
mStrSQL+="ISNULL(UniqueID,0) As UniqueID,"
mStrSQL+="ISNULL(Type,0) As Type,"
mStrSQL+="ISNULL(StartDate,0) As StartDate,"
mStrSQL+="ISNULL(EndDate,0) As EndDate,"
mStrSQL+="ISNULL(QueryStartDate,0) As QueryStartDate,"
mStrSQL+="ISNULL(QueryEndDate,0) As QueryEndDate,"
mStrSQL+="ISNULL(AllDay,1) As AllDay,"
mStrSQL+="ISNULL(Description,'') As Description,"
mStrSQL+="ISNULL(Status,0) As Status,"
mStrSQL+="ISNULL(Label,0) As Label,"
mStrSQL+="ISNULL(ResourceID,0) As ResourceID,"
mStrSQL+="ISNULL(ResourceIDs,'') As ResourceIDs,"
mStrSQL+="ISNULL(ReminderInfo,'') As ReminderInfo,"
mStrSQL+="ISNULL(RecurrenceInfo,'') As RecurrenceInfo,"
mStrSQL+="ISNULL(TimeZoneId,'') As TimeZoneId,"
mStrSQL+="ISNULL(Subject,'') As Subject,"
mStrSQL+="ISNULL(Location,'') As Location,"
        mStrSQL += "ISNULL(customField1,'') As customField1, "
        mStrSQL += "ISNULL(customField1,'') As customField1 "
        mStrSQL +="FROM Appointments "
mStrSQL+="WHERE FLG_Ativo=1 "
mStrSQL+="AND UniqueID=@pUniqueID"


mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

mRDR = mCMD.ExecuteReader

IF mRDR.Read() Then


With mClsAppointments
.UniqueID = mRDR.Getvalue(mRDR.GetOrdinal("UniqueID"))
.Type = mRDR.Getvalue(mRDR.GetOrdinal("Type"))
.StartDate = mRDR.GetDateTime(mRDR.GetOrdinal("StartDate"))
.EndDate = mRDR.GetDateTime(mRDR.GetOrdinal("EndDate"))
.QueryStartDate = mRDR.GetDateTime(mRDR.GetOrdinal("QueryStartDate"))
.QueryEndDate = mRDR.GetDateTime(mRDR.GetOrdinal("QueryEndDate"))
.AllDay = mRDR.GetBoolean(mRDR.GetOrdinal("AllDay"))
.Description = mRDR.GetString(mRDR.GetOrdinal("Description"))
.Status = mRDR.Getvalue(mRDR.GetOrdinal("Status"))
.Label = mRDR.Getvalue(mRDR.GetOrdinal("Label"))
.ResourceID = mRDR.Getvalue(mRDR.GetOrdinal("ResourceID"))
.ResourceIDs = mRDR.GetString(mRDR.GetOrdinal("ResourceIDs"))
.ReminderInfo = mRDR.GetString(mRDR.GetOrdinal("ReminderInfo"))
.RecurrenceInfo = mRDR.GetString(mRDR.GetOrdinal("RecurrenceInfo"))
.TimeZoneId = mRDR.GetString(mRDR.GetOrdinal("TimeZoneId"))
.Subject = mRDR.GetString(mRDR.GetOrdinal("Subject"))
.Location = mRDR.GetString(mRDR.GetOrdinal("Location"))
                .customField1 = mRDR.GetString(mRDR.GetOrdinal("customField1"))
                .customField2 = mRDR.GetString(mRDR.GetOrdinal("customField2"))
            End With


End IF
mRDR.Close()
mDB.Close()

Return mClsAppointments
End Function


    ''' <summary>
    '''      Function ModificaAppointments(ByVal pClsAppointments As ClsAppointments) Método para Modificar a TABELA Appointments
    '''      Gerado em 31/01/2024 10:35:35
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function ModificaAppointments(ByVal pClsAppointments As ClsAppointments) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pUniqueID", pClsAppointments.UniqueID)
        mCMD.Parameters.AddWithValue("@pType", pClsAppointments.Type)
        mCMD.Parameters.AddWithValue("@pStartDate", pClsAppointments.StartDate)
        mCMD.Parameters.AddWithValue("@pEndDate", pClsAppointments.EndDate)
        mCMD.Parameters.AddWithValue("@pQueryStartDate", pClsAppointments.QueryStartDate)
        mCMD.Parameters.AddWithValue("@pQueryEndDate", pClsAppointments.QueryEndDate)
        mCMD.Parameters.AddWithValue("@pAllDay", pClsAppointments.AllDay)
        mCMD.Parameters.AddWithValue("@pDescription", pClsAppointments.Description) '.Substring(0,IIf(Len(pClsAppointments.Description)>-1,-1,Len(pClsAppointments.Description))))
        mCMD.Parameters.AddWithValue("@pStatus", pClsAppointments.Status)
        mCMD.Parameters.AddWithValue("@pLabel", pClsAppointments.Label)
        mCMD.Parameters.AddWithValue("@pResourceID", pClsAppointments.ResourceID)
        mCMD.Parameters.AddWithValue("@pResourceIDs", pClsAppointments.ResourceIDs) '.Substring(0,IIf(Len(pClsAppointments.ResourceIDs)>-1,-1,Len(pClsAppointments.ResourceIDs))))
        mCMD.Parameters.AddWithValue("@pReminderInfo", pClsAppointments.ReminderInfo) '.Substring(0,IIf(Len(pClsAppointments.ReminderInfo)>-1,-1,Len(pClsAppointments.ReminderInfo))))
        mCMD.Parameters.AddWithValue("@pRecurrenceInfo", pClsAppointments.RecurrenceInfo) '.Substring(0,IIf(Len(pClsAppointments.RecurrenceInfo)>-1,-1,Len(pClsAppointments.RecurrenceInfo))))
        mCMD.Parameters.AddWithValue("@pTimeZoneId", pClsAppointments.TimeZoneId) '.Substring(0,IIf(Len(pClsAppointments.TimeZoneId)>-1,-1,Len(pClsAppointments.TimeZoneId))))
        mCMD.Parameters.AddWithValue("@pSubject", pClsAppointments.Subject.Substring(0, IIf(Len(pClsAppointments.Subject) > 50, 50, Len(pClsAppointments.Subject))))
        mCMD.Parameters.AddWithValue("@pLocation", pClsAppointments.Location.Substring(0, IIf(Len(pClsAppointments.Location) > 50, 50, Len(pClsAppointments.Location))))


        mStrSQL = "UPDATE Appointments SET "
        mStrSQL += "Type=@pType,"
        mStrSQL += "StartDate=@pStartDate,"
        mStrSQL += "EndDate=@pEndDate,"
        mStrSQL += "QueryStartDate=@pQueryStartDate,"
        mStrSQL += "QueryEndDate=@pQueryEndDate,"
        mStrSQL += "AllDay=@pAllDay,"
        mStrSQL += "Description=@pDescription,"
        mStrSQL += "Status=@pStatus,"
        mStrSQL += "Label=@pLabel,"
        mStrSQL += "ResourceID=@pResourceID,"
        mStrSQL += "ResourceIDs=@pResourceIDs,"
        mStrSQL += "ReminderInfo=@pReminderInfo,"
        mStrSQL += "RecurrenceInfo=@pRecurrenceInfo,"
        mStrSQL += "TimeZoneId=@pTimeZoneId,"
        mStrSQL += "Subject=@pSubject,"
        mStrSQL += "Location=@pLocation "
        mStrSQL += "WHERE UniqueID=@pUniqueID"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            Msgbox("ModificaAppointments:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function

    Public Shared Function Atualiza_Status(ByVal pCod_Marcacao As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Marcacao", pCod_Marcacao)


        mStrSQL = "UPDATE Appointments SET "
        mStrSQL += "Status=2 "
        mStrSQL += "WHERE Customfield1=@pCod_Marcacao"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaMarcacoes:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
    Public Shared Function update_hour(ByVal pH_Inicio As DateTime, ByVal pH_Fim As DateTime, ByVal pUniqueID As Integer) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pUniqueID", pUniqueID)
        mCMD.Parameters.AddWithValue("@pStartDate", pH_Inicio)
        mCMD.Parameters.AddWithValue("@pEndDate", pH_Fim)
        mCMD.Parameters.AddWithValue("@pQueryStartDate", pH_Inicio)
        mCMD.Parameters.AddWithValue("@pQueryEndDate", pH_Fim)



        mStrSQL = "UPDATE Appointments SET "
        mStrSQL += "StartDate=@pStartDate,"
        mStrSQL += "EndDate=@pEndDate,"
        mStrSQL += "QueryStartDate=@pQueryStartDate,"
        mStrSQL += "QueryEndDate=@pQueryEndDate "
        mStrSQL += "WHERE UniqueID=@pUniqueID"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaAppointments:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaAppointments(ByVal pNovoAppointments As ClsAppointments) Método para Gravar a TABELA Appointments
    '''      Gerado em 31/01/2024 10:35:35
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function GravaAppointments(ByVal pNovoAppointments As ClsAppointments) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()


        'mCMD.Parameters.AddWithValue("@pUniqueID",pNovoAppointments.UniqueID)
        mCMD.Parameters.AddWithValue("@pType",pNovoAppointments.Type)
mCMD.Parameters.AddWithValue("@pStartDate",pNovoAppointments.StartDate)
mCMD.Parameters.AddWithValue("@pEndDate",pNovoAppointments.EndDate)
mCMD.Parameters.AddWithValue("@pQueryStartDate",pNovoAppointments.QueryStartDate)
mCMD.Parameters.AddWithValue("@pQueryEndDate",pNovoAppointments.QueryEndDate)
mCMD.Parameters.AddWithValue("@pAllDay",pNovoAppointments.AllDay)
        mCMD.Parameters.AddWithValue("@pDescription", pNovoAppointments.Description) '.Substring(0,IIf(Len(pNovoAppointments.Description)>-1,-1,Len(pNovoAppointments.Description))))
        mCMD.Parameters.AddWithValue("@pStatus",pNovoAppointments.Status)
mCMD.Parameters.AddWithValue("@pLabel",pNovoAppointments.Label)
mCMD.Parameters.AddWithValue("@pResourceID",pNovoAppointments.ResourceID)
        mCMD.Parameters.AddWithValue("@pResourceIDs", pNovoAppointments.ResourceIDs) '.Substring(0,IIf(Len(pNovoAppointments.ResourceIDs)>-1,-1,Len(pNovoAppointments.ResourceIDs))))
        mCMD.Parameters.AddWithValue("@pReminderInfo", pNovoAppointments.ReminderInfo) '.Substring(0,IIf(Len(pNovoAppointments.ReminderInfo)>-1,-1,Len(pNovoAppointments.ReminderInfo))))
        mCMD.Parameters.AddWithValue("@pRecurrenceInfo", pNovoAppointments.RecurrenceInfo) '.Substring(0,IIf(Len(pNovoAppointments.RecurrenceInfo)>-1,-1,Len(pNovoAppointments.RecurrenceInfo))))
        mCMD.Parameters.AddWithValue("@pTimeZoneId", pNovoAppointments.TimeZoneId) '.Substring(0,IIf(Len(pNovoAppointments.TimeZoneId)>-1,-1,Len(pNovoAppointments.TimeZoneId))))
        mCMD.Parameters.AddWithValue("@pSubject",pNovoAppointments.Subject.Substring(0,IIf(Len(pNovoAppointments.Subject)> 50, 50,Len(pNovoAppointments.Subject))))
mCMD.Parameters.AddWithValue("@pLocation",pNovoAppointments.Location.Substring(0,IIf(Len(pNovoAppointments.Location)> 50, 50,Len(pNovoAppointments.Location))))
        mCMD.Parameters.AddWithValue("@pcustomField1", pNovoAppointments.customField1) '.Substring(0,IIf(Len(pNovoAppointments.customField1)>-1,-1,Len(pNovoAppointments.customField1))))
        mCMD.Parameters.AddWithValue("@pcustomField2", pNovoAppointments.customField2) '.Substring(0,IIf(Len(pNovoAppointments.customField1)>-1,-1,Len(pNovoAppointments.customField1))))


        mStrSQL ="INSERT INTO Appointments "
mStrSQL+="("
        'mStrSQL+="UniqueID,"
        mStrSQL +="Type,"
mStrSQL+="StartDate,"
mStrSQL+="EndDate,"
mStrSQL+="QueryStartDate,"
mStrSQL+="QueryEndDate,"
mStrSQL+="AllDay,"
mStrSQL+="Description,"
mStrSQL+="Status,"
mStrSQL+="Label,"
mStrSQL+="ResourceID,"
mStrSQL+="ResourceIDs,"
mStrSQL+="ReminderInfo,"
mStrSQL+="RecurrenceInfo,"
mStrSQL+="TimeZoneId,"
mStrSQL+="Subject,"
mStrSQL+="Location,"
        mStrSQL += "customField1,"
        mStrSQL += "customField2 "
        mStrSQL +=") "
mStrSQL+="VALUES "
mStrSQL+="("
        'mStrSQL+="@pUniqueID,"
        mStrSQL +="@pType,"
mStrSQL+="@pStartDate,"
mStrSQL+="@pEndDate,"
mStrSQL+="@pQueryStartDate,"
mStrSQL+="@pQueryEndDate,"
mStrSQL+="@pAllDay,"
mStrSQL+="@pDescription,"
mStrSQL+="@pStatus,"
mStrSQL+="@pLabel,"
mStrSQL+="@pResourceID,"
mStrSQL+="@pResourceIDs,"
mStrSQL+="@pReminderInfo,"
mStrSQL+="@pRecurrenceInfo,"
mStrSQL+="@pTimeZoneId,"
mStrSQL+="@pSubject,"
mStrSQL+="@pLocation,"
        mStrSQL += "@pcustomField1,"
        mStrSQL += "@pcustomField2 "
        mStrSQL +=")"


mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
'ClsEmpresas.GravaContador(enCont.Appointments)'<<<<-------- Verificar se é  preciso...
Catch ex As Exception
Msgbox("GravaAppointments:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 


''' <summary>
'''      Function ApagaAppointments(ByVal pUniqueID As Integer) Método para Apagar um Registo da Tabela Appointments
'''      Gerado em 31/01/2024 10:35:35
''' </summary>
''' <returns>
'''      Boolean
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function ApagaAppointments(ByVal pUniqueID As Integer) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mCMD.Parameters.Clear()

mCMD.Parameters.AddWithValue("@pUniqueID", pUniqueID)


mStrSQL="UPDATE Appointments SET "
mStrSQL+="FLG_Ativo=0 "
mStrSQL+="WHERE UniqueID=@pUniqueID"


mDB.ConnectionString = My.Settings.Connection
mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
Catch ex As Exception
Msgbox("ApagaAppointments:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 
End Class

