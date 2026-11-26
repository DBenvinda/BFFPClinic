Imports DevExpress.Data.Helpers
Imports DevExpress.XtraReports.Serialization
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Drawing
Public Class frmMarcacoes

    Dim mCod_Consulta_Mudado As String = String.Empty
    Dim mlista As New List(Of ClsAppointments)
    Public Property mcod_TM As String
    Private Sub frmMarcacoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        marcacoesload()
    End Sub

    Public Sub marcacoesload()
        'SchedulerControl1.drag
        mlista = ClsAppointments.GetAppointmentsBy_Subject(Me.Tag, mcod_TM)
        SchedulerDataStorage1.Appointments.DataSource = mlista


        'TODO: This line of code loads data into the 'I21_G2DataSet4.Labels' table. You can move, or remove it, as needed.
        Me.LabelsTableAdapter.Fill(Me.I21_G2DataSet4.Labels)
        'TODO: This line of code loads data into the 'I21_G2DataSet4.Statuses' table. You can move, or remove it, as needed.
        Me.StatusesTableAdapter.Fill(Me.I21_G2DataSet4.Statuses)
        'TODO: This line of code loads data into the 'I21_G2DataSet4.Resources' table. You can move, or remove it, as needed.
        Me.ResourcesTableAdapter.Fill(Me.I21_G2DataSet4.Resources)
        'TODO: This line of code loads data into the 'I21_G2DataSet4.Appointments' table. You can move, or remove it, as needed.
        Me.AppointmentsTableAdapter.Fill(Me.I21_G2DataSet4.Appointments)
        'TODO: This line of code loads data into the 'I21_G2DataSet4.Appointments' table. You can move, or remove it, as needed.

        'SchedulerControl1.DataStorage.Appointments.Filter = "[Subject] = (" & Me.Tag & ")"
        'SchedulerControl1.DataStorage.Appointments.Filter = "[Label] = 10"

        mCod_Consulta_Mudado = String.Empty

        With Me.SchedulerControl1
            .WorkWeekView.ShowWorkTimeOnly = True
            .Start = Date.Now
        End With
    End Sub
    Private Sub SchedulerDataStorage1_AppointmentsChanged(sender As Object, e As DevExpress.XtraScheduler.PersistentObjectsEventArgs) Handles SchedulerDataStorage1.AppointmentsChanged


        AppointmentsTableAdapter.Update(I21_G2DataSet4)
        I21_G2DataSet4.AcceptChanges()

        If mCod_Consulta_Mudado IsNot String.Empty Then


            Dim mApp As New ClsAppointments
            mApp = ClsAppointments.GetAppointmentsByCod_Marcacao(mCod_Consulta_Mudado)
            Dim mClsMarcacao As New ClsMarcacoes
            mClsMarcacao = ClsMarcacoes.GetMarcacoesByCod(mCod_Consulta_Mudado)
            With mClsMarcacao
                .Dia = ClsUtils.GetDataSH(mApp.StartDate)
                .Hora_Inicio = mApp.StartDate
                .Hora_Fim = mApp.EndDate

            End With
            Dim mSim As Boolean
            mSim = ClsMarcacoes.ModificaMarcacoes(mClsMarcacao)
            If mSim = False Then
                MsgBox("Não Gravei....")
            End If

        End If
        mCod_Consulta_Mudado = String.Empty
        '--------------------------------------
        Dim mappointment As Appointment
        Dim novaEtiqueta As Integer
        Dim MclsApp As ClsAppointments

        For Each obj As Object In e.Objects
            If TypeOf obj Is Appointment Then
                mappointment = DirectCast(obj, Appointment)
                ' Verifique as propriedades relevantes do compromisso aqui...
                ' Por exemplo:
                novaEtiqueta = mappointment.LabelKey
                ' Faça o que for necessário com a nova etiqueta...
            End If
        Next
        MclsApp = ClsAppointments.GetAppointmentsByCod_Marcacao(mappointment.CustomFields(0))
        MclsApp.Label = novaEtiqueta

        ClsAppointments.ModificaAppointments(MclsApp)

    End Sub

    Private Sub SchedulerDataStorage1_AP_INSERT_DELETEED(sender As Object, e As DevExpress.XtraScheduler.PersistentObjectsEventArgs) Handles SchedulerDataStorage1.AppointmentsInserted, SchedulerDataStorage1.AppointmentsDeleted
        AppointmentsTableAdapter.Update(I21_G2DataSet4)
        I21_G2DataSet4.AcceptChanges()

    End Sub

    Private Sub SchedulerDataStorage1_AppointmentChanging(sender As Object, e As PersistentObjectCancelEventArgs) ' Handles SchedulerDataStorage1.AppointmentChanging
        'Dim advArgs As AdvPersistentObjectCancelEventArgs = CType(e, AdvPersistentObjectCancelEventArgs)
        '
        'If advArgs.PropertyName = "Start" Then
        '    mCod_Consulta_Mudado = advArgs.Object.CustomFields(0).ToString
        '
        'End If
        'I21_G2DataSet4.AcceptChanges()
        Dim novaEtiqueta As String
        Dim advArgs As AdvPersistentObjectCancelEventArgs = DirectCast(e, AdvPersistentObjectCancelEventArgs)
        If advArgs.PropertyName = "Label" AndAlso advArgs.NewValue IsNot Nothing Then
            ' O novo valor da etiqueta está disponível em advArgs.NewValue
            novaEtiqueta = advArgs.NewValue.ToString()
            ' Faça o que for necessário com a nova etiqueta...
        End If

        Dim mappointment As ClsAppointments = ClsAppointments.GetAppointmentsByCod_Marcacao(e.Object.CustomFields.Item(0))
        mappointment.Label = novaEtiqueta

        ClsAppointments.ModificaAppointments(mappointment)



    End Sub

    Private Sub SchedulerControl1_EditAppointmentFormShowing(sender As Object, e As DevExpress.XtraScheduler.AppointmentFormEventArgs) Handles SchedulerControl1.EditAppointmentFormShowing
        Dim scheduler As DevExpress.XtraScheduler.SchedulerControl = CType(sender, DevExpress.XtraScheduler.SchedulerControl)
        Dim form As PAP_G2_BFFPclinic_01_Diogo.CustomAppointmentForm = New PAP_G2_BFFPclinic_01_Diogo.CustomAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm, mcod_TM)
        Try
            form.Tag = Me.Tag
            e.DialogResult = form.ShowDialog
            e.Handled = True

        Finally
            form.Dispose()

        End Try

    End Sub

    Private Sub filterControlForAppointments_FilterStringChanged(sender As Object, e As EventArgs)
        '  SchedulerControl1.DataStorage.Appointments.Filter = filterControlForAppointments.FilterString
        If sender.filterstring = "" Then

        End If
    End Sub

    Private Sub filterControlForAppointments_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub schedulerControl1_AppointmentDrop(ByVal sender As Object, ByVal e As AppointmentDragEventArgs) Handles SchedulerControl1.AppointmentDrop
        ' Get the appointment being dragged
        Dim mappointment As Appointment = e.EditedAppointment

        ' Get the new start time of the appointment after dropping
        ' Dim newStartTime As DateTime = appointment.End

        ' You can now use newStartTime to determine the hour where the appointment was dropped
        ' Dim hour As Integer = newStartTime.Hour
        Dim hora_Inicio As DateTime = e.HitInterval.Start
        Dim hora_fim As DateTime = e.HitInterval.End

        ' Do something with the hour, for example, display it

        MessageBox.Show("Appointment start hour: " & hora_Inicio)
        MessageBox.Show("Appointment end hour: " & hora_fim)

        ClsAppointments.update_hour(hora_Inicio, hora_fim, mappointment.CustomFields(1))
        'SchedulerDataStorage1.RefreshData()



    End Sub









    'Private Sub SchedulerControl1_DragDrop(sender As Object, e As DragEventArgs) Handles SchedulerControl1.DragDrop
    '    ' Recupere os dados do evento de drag and drop, se necessário
    '    Dim data As String = e.Data.GetData(DataFormats.Text).ToString()

    '    ' Obtenha a posição onde o item foi solto
    '    Dim newPosition As Point = SchedulerControl1.PointToClient(New Point(e.X, e.Y))

    '    ' Obtenha o intervalo de tempo da visualização ativa
    '    Dim newDateTime As Date = SchedulerControl1.GetDateTimeFromPoint(newPosition)

    'End Sub

End Class