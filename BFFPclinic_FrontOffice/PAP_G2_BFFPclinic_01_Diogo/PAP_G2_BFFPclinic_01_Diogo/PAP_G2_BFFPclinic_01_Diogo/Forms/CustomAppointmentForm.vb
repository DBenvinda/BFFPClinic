Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms
Imports DevExpress.Pdf.Native.BouncyCastle.Asn1.Pkcs
Imports DevExpress.Utils
Imports DevExpress.Utils.Controls
Imports DevExpress.Utils.Internal
Imports DevExpress.Utils.Menu
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Native
Imports DevExpress.XtraReports.Diagnostics
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Internal
Imports DevExpress.XtraScheduler.Localization
Imports DevExpress.XtraScheduler.Native
Imports DevExpress.XtraScheduler.UI
Imports Infragistics.Win.UltraWinTabs

Partial Public Class CustomAppointmentForm
    Inherits DevExpress.XtraEditors.XtraForm
    Implements IDXManagerPopupMenu


    Private m_openRecurrenceForm As Boolean
    Private ReadOnly m_storage As ISchedulerStorage
    Private ReadOnly m_control As SchedulerControl
    Private m_recurringSvgImage As SvgImage
    Private m_normalSvgImage As SvgImage
    Private ReadOnly m_controller As AppointmentFormController
    Private m_menuManager As IDXMenuManager

    '----------------------------------------------------------------------
    'Dim mCod_Medico As String = String.Empty
    'Dim mCod_Especialidade As String = String.Empty
    'Dim mCod_Tipo_Marcacao As String = String.Empty
    'Dim mCod_Utente As String = String.Empty
    'Dim mCod_Marcacao As String = String.Empty
    ' Dim mCod_Sala As String = String.Empty

    'Dim mNome_Medico As String = String.Empty
    'Dim mEspecialidade As String = String.Empty
    'Dim mTipo_Marcacao As String = String.Empty
    'Dim mNome_Utente As String = String.Empty
    'Dim mSala As String = String.Empty


    Dim mclsMarcacao As New ClsMarcacoes
    Dim mclsAppointment As New ClsAppointments


    Dim mIndex_Salas As Integer = 0
    Dim mIndex_Medicos As Integer = 0
    Dim mIndex_TM As Integer = 0
    Dim mIndex_Utentes As Integer = 0
    Dim mIndex_Especialides As Integer = 0

    Dim Mindex_Artigo As Integer = 0

    Dim mLista_Salas As New List(Of ClsSalas)
    Dim mLista_Medicos As New List(Of ClsEntidades)
    Dim mLista_Tipos_Marcacao As New List(Of ClsTipos_Marcacao)
    Dim mLista_Utentes As New List(Of ClsEntidades)
    Dim mLista_Especialidades As New List(Of ClsEspecialidades)

    Dim mlista_Artigos As New List(Of ClsArtigos)
    Dim mcod_TM As String

    Private mHI As DateTime
    Private mHF As DateTime

    Private Sub CustomAppointmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'EspecialidadeTextEdit.Text = Me.Tag
        '' ExameTextEdit.Text = Me.Tag
        'Cod_EspecialidadeTextEdit.Text = ClsEspecialidades.getCodEspecialidade_bydesignacao(Me.Tag)
        '' Cod_ExameTextEdit.Text = ClsTipos_Exames.GetTipos_ExamesBydesiignacao(Me.Tag)
        'Cod_TIpo_MarcacaoTextEdit.Text = mcod_TM
        'TipoMarcacaoTextEdit.Text = ClsTipos_Marcacao.GetTipos_MarcacaoByCod(mcod_TM).Designacao

        'If Not IsNewAppointment Then
        '    mclsMarcacao = ClsMarcacoes.GetMarcacoesByCod(Controller.EditedAppointmentCopy.CustomFields("Cod_Marcacao"))
        '    Get_UCS(False)
        'Else
        '    Get_UCS(True)

        'End If

        'If IsNewAppointment Then
        '    SetupComps(False)


        '    load_Medicos_TE()
        '    load_Salas_TE()
        '    load_Utentes_TE()
        '    load_Artigos_TE()
        'Else
        '    SetupComps(True)
        '    Load_Registos()
        'End If



    End Sub

    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment)
        Me.New(control, apt, False, "")
    End Sub
    Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment, ByVal openRecurrenceForm As Boolean, ByVal pCod_TM As String)
        Guard.ArgumentNotNull(control, "control")
        Guard.ArgumentNotNull(control.DataStorage, "control.DataStorage")
        Guard.ArgumentNotNull(apt, "apt")

        Me.m_openRecurrenceForm = openRecurrenceForm
        Me.m_controller = CreateController(control, apt)
        Me.mcod_TM = pCod_TM
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        SetupPredefinedConstraints()

        LoadIcons()

        Me.m_control = control
        Me.m_storage = control.DataStorage

        Me.edtShowTimeAs.Storage = Me.m_storage
        Me.edtLabel.Storage = Me.m_storage
        'Me.edtResource.SchedulerControl = control
        'Me.edtResource.Storage = Me.m_storage
        'Me.edtResources.SchedulerControl = control

        SubscribeControllerEvents(Controller)
        SubscribeEditorsEvents()
        BindControllerToControls()
    End Sub

    Protected Overrides ReadOnly Property ShowMode() As FormShowMode
        Get
            Return FormShowMode.AfterInitialization
        End Get
    End Property
    <Browsable(False)>
    Public Property MenuManager() As IDXMenuManager
        Get
            Return Me.m_menuManager
        End Get
        Private Set(ByVal value As IDXMenuManager)
            Me.m_menuManager = value
        End Set
    End Property
    Protected Friend ReadOnly Property Controller() As AppointmentFormController
        Get
            Return Me.m_controller
        End Get
    End Property
    Protected Friend ReadOnly Property Control() As SchedulerControl
        Get
            Return Me.m_control
        End Get
    End Property
    Protected Friend ReadOnly Property Storage() As ISchedulerStorage
        Get
            Return Me.m_storage
        End Get
    End Property
    Protected Friend ReadOnly Property IsNewAppointment() As Boolean
        Get
            Return If(Me.m_controller IsNot Nothing, Me.m_controller.IsNewAppointment, True)
        End Get
    End Property
    Protected Friend ReadOnly Property RecurringSvgImage() As SvgImage
        Get
            Return m_recurringSvgImage
        End Get
    End Property
    Protected Friend ReadOnly Property NormalSvgImage() As SvgImage
        Get
            Return m_normalSvgImage
        End Get
    End Property
    <Browsable(False), EditorBrowsable(EditorBrowsableState.Never)>
    Public Property SvgImage() As SvgImage
        Get
            Return IconOptions.SvgImage
        End Get
        Set(ByVal value As SvgImage)
            IconOptions.SvgImage = value
        End Set
    End Property
    Protected Friend ReadOnly Property OpenRecurrenceForm() As Boolean
        Get
            Return Me.m_openRecurrenceForm
        End Get
    End Property
    <DXDescription("DevExpress.XtraScheduler.UI.AppointmentForm,ReadOnly"), DXCategory(CategoryName.Behavior), DefaultValue(False)>
    Public Property [ReadOnly]() As Boolean
        Get
            Return Controller IsNot Nothing AndAlso Controller.ReadOnly
        End Get
        Set(ByVal value As Boolean)
            If Controller.ReadOnly = value Then
                Return
            End If
            Controller.ReadOnly = value
        End Set
    End Property

    Public Overridable Sub LoadFormData(ByVal appointment As Appointment)

        If appointment.CustomFields("Cod_Marcacao") IsNot Nothing And Not appointment.CustomFields("Cod_Marcacao") = "" Then

            'mclsMarcacao.Cod_Marcacao = appointment.CustomFields("Cod_Marcacao").ToString
            mclsMarcacao = ClsMarcacoes.GetMarcacoesByCod(appointment.CustomFields("Cod_Marcacao").ToString)

            get_mListas()

            'mCod_Utente = mclsMarcacao.Cod_Utente
            'mCod_Sala = mclsMarcacao.Cod_Sala
            'mCod_Tipo_Marcacao = mclsMarcacao.Cod_Tipo_Marcacao
            'mCod_Especialidade = mclsMarcacao.Cod_Especialidade
            'mCod_Medico = mclsMarcacao.Cod_Medico
            '
            '
            'mSala = mclsMarcacao.Sala
            'mIndex_Salas = mLista_Salas.FindIndex(Function(x) x.Cod_Sala = mCod_Sala)
            '
            'mNome_Utente = mclsMarcacao.Utente
            'mIndex_Utentes = mLista_Utentes.FindIndex(Function(x) x.Cod_Entidade = mCod_Utente)
            '
            'mTipo_Marcacao = mclsMarcacao.Tipos_Marcacao
            'mIndex_TM = mLista_Tipos_Marcacao.FindIndex(Function(x) x.Cod_Tipo_Marcacao = mCod_Tipo_Marcacao)
            '
            'mNome_Medico = mclsMarcacao.Medico
            'mIndex_Medicos = mLista_Medicos.FindIndex(Function(x) x.Cod_Entidade = mCod_Medico)


            mHI = edtStartDate.Text
            mHF = edtEndDate.Text

            mHI = mHI.AddHours(CInt(edtStartTime.Text.Substring(0, 2)))
            mHI = mHI.AddMinutes(CInt(edtStartTime.Text.Substring(3, 2)))

            Dim mHoras As Integer = CInt(edtEndTime.Text.Substring(0, 2))
            Dim mMinutos As Integer = CInt(edtEndTime.Text.Substring(3, 2))

            mHF = mHF.AddHours(mHoras)
            mHF = mHF.AddMinutes(mMinutos)




            tbDescription.Text = Display_Descriptions()
            mclsMarcacao.Observacoes = tbDescription.Text

            Get_Datas()

            Get_UCS(False)

            'Me.ucTM.Focus()
        Else
            'Me.edtResource.SelectedIndex = 1

            mHI = edtStartDate.Text
            mHI = mHI.AddHours(CInt(edtStartTime.Text.Substring(0, 2)))
            mHI = mHI.AddMinutes(CInt(edtStartTime.Text.Substring(3, 2)))

            mHF = edtEndDate.Text
            mHF = mHF.AddHours(CInt(edtEndTime.Text.Substring(0, 2)))
            mHF = mHF.AddMinutes(CInt(edtEndTime.Text.Substring(3, 2)))

            mclsMarcacao = New ClsMarcacoes
            With mclsMarcacao
                .FLG_Tipo_Marcacao = mcod_TM.Substring(0, 1)
                .Cod_Marcacao = ClsMarcacoes.GetNovoCodigo(.FLG_Tipo_Marcacao)
                .Cod_Utente = "U0001"
                .Cod_Medico = "M0001"
                mlista_Artigos = ClsArtigos.GetArtigosFiltrados(ClsEspecialidades.getCodEspecialidade_bydesignacao(Me.Tag), mcod_TM)
                .Cod_Artigo = mlista_Artigos(0).Cod_Artigo
                .Cod_Sala = ucSalas.SelectedText
                .Cod_Tipo_Marcacao = mcod_TM
                .Hora_Inicio = mHI
                .Hora_Fim = mHF
                .Dia = edtStartDate.Text

                .Cod_Especialidade = Me.Tag

                .Observacoes = .Utente + " / " + .Sala + " / " + .Artigo + " / " + .Medico
                .FLG_Ativo = 1
            End With


            '.Status = enStatus.Agendada
            '}

            get_mListas()
            Get_UCS(True)
            Display_Descriptions()
            'Me.ucTM.Focus()
        End If
        '------------------------------

    End Sub

    Sub get_mListas()
        mLista_Especialidades = ClsEspecialidades.GetEspecialidades
        mLista_Medicos = ClsEntidades.GetEntidadesBy_FLG("M")
        mLista_Salas = ClsSalas.GetSalas
        mLista_Tipos_Marcacao = ClsTipos_Marcacao.GetTipos_Marcacao
        mLista_Utentes = ClsEntidades.GetEntidadesBy_FLG("U")
        mlista_Artigos = ClsArtigos.GetArtigosFiltrados(ClsEspecialidades.getCodEspecialidade_bydesignacao(Me.Tag), mcod_TM)
    End Sub
    Sub Get_Datas()

        'mHI = edtStartDate.Text
        'mHI = mHI.AddHours(CInt(edtStartTime.Text.Substring(0, 2)))
        'mHI = mHI.AddMinutes(CInt(edtStartTime.Text.Substring(3, 2)))
        '
        'mHF = edtEndDate.Text
        'mHF = mHF.AddHours(CInt(edtEndTime.Text.Substring(0, 2)))
        'mHF = mHF.AddMinutes(CInt(edtEndTime.Text.Substring(3, 2)))
        '
        'With mclsMarcacao
        '    .Hora_Inicio = mHI
        '    .Hora_Fim = mHF
        '    .Dia = edtStartDate.Text
        'End With
        mHI = edtStartDate.DateTime
        mHI = mHI.AddHours(CInt(edtStartTime.Time.Hour))
        mHI = mHI.AddMinutes(CInt(edtStartTime.Time.Minute))

        mHF = edtEndDate.DateTime
        mHF = mHF.AddHours(CInt(edtEndTime.Time.Hour))
        mHF = mHF.AddMinutes(CInt(edtEndTime.Time.Minute))

    End Sub
    Function Display_Descriptions() As String

        Dim mReturn As String = String.Empty

        With mclsMarcacao
            mReturn = "Utente: " + .Utente + vbCrLf + " Sala: " + .Sala + vbCrLf + " Artigo: " + .Artigo + vbCrLf + " Medico: " + .Medico
            tbDescription.Text = mReturn
        End With
        Return mReturn
    End Function

    Sub Get_UCS(pNovo As Boolean)
        getmlistas()

        If pNovo Then
            mIndex_Salas = 0
            mIndex_TM = 0
            mIndex_Utentes = 0
            mIndex_Especialides = 0
            mIndex_Medicos = 0

            Mindex_Artigo = 0
        Else
            mIndex_Salas = mLista_Salas.FindIndex(Function(x) x.Cod_Sala = mclsMarcacao.Cod_Sala) + 1
            mIndex_TM = mLista_Tipos_Marcacao.FindIndex(Function(x) x.Cod_Tipo_Marcacao = mclsMarcacao.Cod_Tipo_Marcacao) + 1
            mIndex_Utentes = mLista_Utentes.FindIndex(Function(x) x.Cod_Entidade = mclsMarcacao.Cod_Utente) + 1
            mIndex_Especialides = mLista_Especialidades.FindIndex(Function(x) x.Cod_Especialidade = mclsMarcacao.Cod_Especialidade) + 1
            mIndex_Medicos = mLista_Medicos.FindIndex(Function(x) x.Cod_Entidade = mclsMarcacao.Cod_Medico) + 1

            Mindex_Artigo = mlista_Artigos.FindIndex(Function(x) x.Cod_Artigo = mclsMarcacao.Cod_Artigo) + 1
        End If

        'With ucTM
        '    .DataSource = ClsTipos_Marcacao.GetTipos_Marcacao
        '    .DisplayLayout.Bands(0).Columns(2).Hidden = True
        '    .Rows(mIndex_TM).Selected = True

        'End With

        With ucMedicos
            .DataSource = ClsEntidades.GetEntidadesBy_FLG("M")
            .DisplayLayout.Bands(0).Columns(0).Hidden = False
            .DisplayLayout.Bands(0).Columns(1).Hidden = True
            .DisplayLayout.Bands(0).Columns(2).Hidden = False
            .DisplayLayout.Bands(0).Columns(3).Hidden = True
            .DisplayLayout.Bands(0).Columns(4).Hidden = True
            .DisplayLayout.Bands(0).Columns(5).Hidden = True
            .DisplayLayout.Bands(0).Columns(6).Hidden = True
            .DisplayLayout.Bands(0).Columns(7).Hidden = True
            .DisplayLayout.Bands(0).Columns(8).Hidden = True
            .DisplayLayout.Bands(0).Columns(9).Hidden = True
            .DisplayLayout.Bands(0).Columns(10).Hidden = True
            .DisplayLayout.Bands(0).Columns(11).Hidden = False
            .DisplayLayout.Bands(0).Columns(12).Hidden = True
            .DisplayLayout.Bands(0).Columns(13).Hidden = True
            .DisplayLayout.Bands(0).Columns(14).Hidden = True
            .DisplayLayout.Bands(0).Columns(15).Hidden = True
            .DisplayLayout.Bands(0).Columns(16).Hidden = True
            .DisplayLayout.Bands(0).Columns(17).Hidden = True
            .DisplayLayout.Bands(0).Columns(18).Hidden = True
            ' .DisplayLayout.Bands(0).Columns(19).Hidden = True
            .Rows(mIndex_Medicos).Selected = True
        End With
        With ucUtentes
            .DataSource = ClsEntidades.GetEntidadesBy_FLG("U")
            .DisplayLayout.Bands(0).Columns(0).Hidden = False
            .DisplayLayout.Bands(0).Columns(1).Hidden = True
            .DisplayLayout.Bands(0).Columns(2).Hidden = False
            .DisplayLayout.Bands(0).Columns(3).Hidden = True
            .DisplayLayout.Bands(0).Columns(4).Hidden = True
            .DisplayLayout.Bands(0).Columns(5).Hidden = True
            .DisplayLayout.Bands(0).Columns(6).Hidden = True
            .DisplayLayout.Bands(0).Columns(7).Hidden = True
            .DisplayLayout.Bands(0).Columns(8).Hidden = True
            .DisplayLayout.Bands(0).Columns(9).Hidden = True
            .DisplayLayout.Bands(0).Columns(10).Hidden = True
            .DisplayLayout.Bands(0).Columns(11).Hidden = True
            .DisplayLayout.Bands(0).Columns(12).Hidden = True
            .DisplayLayout.Bands(0).Columns(13).Hidden = True
            .DisplayLayout.Bands(0).Columns(14).Hidden = True
            .DisplayLayout.Bands(0).Columns(15).Hidden = True
            .DisplayLayout.Bands(0).Columns(16).Hidden = True
            .DisplayLayout.Bands(0).Columns(17).Hidden = True
            .DisplayLayout.Bands(0).Columns(18).Hidden = True
            '.DisplayLayout.Bands(0).Columns(19).Hidden = True
            .Rows(mIndex_Utentes).Selected = True
        End With
        ' With ucEspecialidades
        '     .DataSource = ClsEspecialidades.GetEspecialidades()
        '     .DisplayLayout.Bands(0).Columns(2).Hidden = True
        ' End With
        'With ucExame
        '    .DataSource = ClsTipos_Exames.GetTipos_Exames()
        '    .DisplayLayout.Bands(0).Columns(2).Hidden = True
        '    .Rows(mindex_Exames).Selected = True
        'End With
        With ucSalas
            .DataSource = ClsSalas.GetSalas
            .DisplayLayout.Bands(0).Columns(2).Hidden = True
            .Rows(mIndex_Salas).Selected = True
        End With
        With ucArtigos
            .DataSource = ClsArtigos.GetArtigosFiltrados(ClsEspecialidades.getCodEspecialidade_bydesignacao(Me.Tag), mcod_TM)
            .DisplayLayout.Bands(0).Columns(0).Hidden = False
            .DisplayLayout.Bands(0).Columns(1).Hidden = True
            .DisplayLayout.Bands(0).Columns(2).Hidden = True
            .DisplayLayout.Bands(0).Columns(3).Hidden = True
            .DisplayLayout.Bands(0).Columns(4).Hidden = False
            'If mlista_Artigos.Count > 0 Then
            '.DisplayLayout.Bands(0).Columns(4).AutoSizeMode = True
            'End If
            .DisplayLayout.Bands(0).Columns(5).Hidden = True
            .DisplayLayout.Bands(0).Columns(6).Hidden = True
            .DisplayLayout.Bands(0).Columns(7).Hidden = True
            .DisplayLayout.Bands(0).Columns(8).Hidden = True
            .DisplayLayout.Bands(0).Columns(9).Hidden = True
            .DisplayLayout.Bands(0).Columns(10).Hidden = True
            .DisplayLayout.Bands(0).Columns(11).Hidden = True
            .DisplayLayout.Bands(0).Columns(12).Hidden = True
            .DisplayLayout.Bands(0).Columns(13).Hidden = True
            If mlista_Artigos.Count > 0 Then
                .Rows(Mindex_Artigo).Selected = True
            End If


        End With '

        With edtShowTimeAs
            .SelectedIndex = 1

        End With

        With edtLabel
            .SelectedIndex = 0
        End With


    End Sub



    Public Overridable Function SaveFormData(ByVal appointment As Appointment) As Boolean
        appointment.CustomFields("Cod_Marcacao") = mclsMarcacao.Cod_Marcacao

        If IsNewAppointment Then
            If Not ClsMarcacoes.GravaMarcacoes(mclsMarcacao) Then
                MsgBox("Não consegui gravar o novo")
            Else
                If Not ClsAppointments.GravaAppointments(appointment) Then
                    MsgBox("Não consegui gravar o novo")
                Else
                    Grava(True)
                End If
            End If
        Else
            If Not ClsMarcacoes.ModificaMarcacoes(mclsMarcacao) Then
                MsgBox("Não consegui Modificar")
            Else
                If Not ClsAppointments.ModificaAppointments(appointment) Then
                    MsgBox("Não consegui Modificar")
                Else
                    Grava(False)
                End If
            End If
        End If

        Return True

        Return True
    End Function


    Public Overridable Function IsAppointmentChanged(ByVal appointment As Appointment) As Boolean
        If mclsMarcacao.Cod_Marcacao = appointment.CustomFields("Cod_Marcacao").ToString Then 'OrElse (Cod_Medico = appointment.CustomFields("Cod_Medico").ToString) OrElse (Cod_Utente = appointment.CustomFields("Cod_Utente").ToString) OrElse (Cod_Tipo_Marcacao = appointment.CustomFields("Cod_Tipo_Marcacao").ToString) Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Overridable Sub SetMenuManager(ByVal menuManager As IDXMenuManager)
        MenuManagerUtils.SetMenuManager(Controls, menuManager)
        Me.m_menuManager = menuManager
    End Sub

    Protected Friend Overridable Sub SetupPredefinedConstraints()
        Me.tbProgress.Properties.Minimum = AppointmentProcessValues.Min
        Me.tbProgress.Properties.Maximum = AppointmentProcessValues.Max
        Me.tbProgress.Properties.SmallChange = AppointmentProcessValues.Step
        'Me.edtResources.Visible = True
    End Sub
    Protected Overridable Sub BindControllerToControls()
        BindControllerToIcon()

        BindProperties(Me.tbDescription, "Text", "Description")
        'BindProperties(Me.edtShowTimeAs, "editvalue", "Status")
        BindProperties(Me.edtStartDate, "EditValue", "DisplayStartDate")
        BindProperties(Me.edtStartDate, "Enabled", "IsDateTimeEditable")
        BindProperties(Me.edtStartTime, "EditValue", "DisplayStartTime")
        BindProperties(Me.edtStartTime, "Visible", "IsTimeVisible")
        BindProperties(Me.edtStartTime, "Enabled", "IsTimeVisible")
        BindProperties(Me.edtEndDate, "EditValue", "DisplayEndDate", DataSourceUpdateMode.Never)
        BindProperties(Me.edtEndDate, "Enabled", "IsDateTimeEditable", DataSourceUpdateMode.Never)
        BindProperties(Me.edtEndTime, "EditValue", "DisplayEndTime", DataSourceUpdateMode.Never)
        BindProperties(Me.edtEndTime, "Visible", "IsTimeVisible", DataSourceUpdateMode.Never)
        BindProperties(Me.edtEndTime, "Enabled", "IsTimeVisible", DataSourceUpdateMode.Never)
        BindProperties(Me.chkAllDay, "Checked", "AllDay")
        BindProperties(Me.chkAllDay, "Enabled", "IsDateTimeEditable")

        ''BindProperties(Me.edtResource, "ResourceId", "ResourceId")
        ' BindProperties(Me.edtResource, "Enabled", "CanEditResource")
        ' BindToBoolPropertyAndInvert(Me.edtResource, "Visible", "ResourceSharing")

        ' BindProperties(Me.edtResources, "ResourceIds", "ResourceIds")
        ' BindProperties(Me.edtResources, "Visible", "ResourceSharing")
        ' BindProperties(Me.edtResources, "Enabled", "CanEditResource")
        ' BindProperties(Me.lblResource, "Enabled", "CanEditResource")
        '
        ' BindProperties(Me.edtLabel, "Label", "Label")
        ' BindProperties(Me.chkReminder, "Enabled", "ReminderVisible")
        ' BindProperties(Me.chkReminder, "Visible", "ReminderVisible")
        ' BindProperties(Me.chkReminder, "Checked", "HasReminder")
        ' BindProperties(Me.cbReminder, "Enabled", "HasReminder")
        ' BindProperties(Me.cbReminder, "Visible", "ReminderVisible")
        ' BindProperties(Me.cbReminder, "Duration", "ReminderTimeBeforeStart")

        BindProperties(Me.tbProgress, "Value", "PercentComplete")
        BindProperties(Me.lblPercentCompleteValue, "Text", "PercentComplete", AddressOf ObjectToStringConverter)
        BindProperties(Me.progressPanel, "Visible", "ShouldEditTaskProgress")
        BindToBoolPropertyAndInvert(Me.btnOk, "Enabled", "ReadOnly")
        BindToBoolPropertyAndInvert(Me.btnRecurrence, "Enabled", "ReadOnly")
        BindProperties(Me.btnDelete, "Enabled", "CanDeleteAppointment")
        BindProperties(Me.btnRecurrence, "Visible", "ShouldShowRecurrenceButton")
    End Sub
    Protected Overridable Sub BindControllerToIcon()
        Dim binding As New Binding("SvgImage", Controller, "AppointmentType")
        AddHandler binding.Format, AddressOf AppointmentTypeToIconConverter
        DataBindings.Add(binding)
    End Sub
    Protected Overridable Sub ObjectToStringConverter(ByVal o As Object, ByVal e As ConvertEventArgs)
        e.Value = e.Value.ToString()
    End Sub
    Protected Overridable Sub AppointmentTypeToIconConverter(ByVal o As Object, ByVal e As ConvertEventArgs)
        Dim type As AppointmentType = CType(e.Value, AppointmentType)
        If type.Equals(AppointmentType.Pattern) Then
            e.Value = RecurringSvgImage
        Else
            e.Value = NormalSvgImage
        End If
    End Sub
    Protected Overridable Sub BindProperties(ByVal target As Control, ByVal targetProperty As String, ByVal sourceProperty As String)
        BindProperties(target, targetProperty, sourceProperty, DataSourceUpdateMode.OnPropertyChanged)
    End Sub
    Protected Overridable Sub BindProperties(ByVal target As Control, ByVal targetProperty As String, ByVal sourceProperty As String, ByVal updateMode As DataSourceUpdateMode)
        target.DataBindings.Add(targetProperty, Controller, sourceProperty, True, updateMode)
    End Sub
    Protected Overridable Sub BindProperties(ByVal target As Control, ByVal targetProperty As String, ByVal sourceProperty As String, ByVal objectToStringConverter As ConvertEventHandler)
        Dim binding As New Binding(targetProperty, Controller, sourceProperty, True)
        AddHandler binding.Format, objectToStringConverter
        target.DataBindings.Add(binding)
    End Sub
    Protected Overridable Sub BindToBoolPropertyAndInvert(ByVal target As Control, ByVal targetProperty As String, ByVal sourceProperty As String)
        target.DataBindings.Add(New BoolInvertBinding(targetProperty, Controller, sourceProperty))
    End Sub
    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)
        If Controller Is Nothing Then
            Return
        End If
        DataBindings.Add("Text", Controller, "Caption")
        SubscribeControlsEvents()
        LoadFormData(Controller.EditedAppointmentCopy)
        RecalculateLayoutOfControlsAffectedByProgressPanel()


        EspecialidadeTextEdit.Text = Me.Tag
        ' ExameTextEdit.Text = Me.Tag
        Cod_EspecialidadeTextEdit.Text = ClsEspecialidades.getCodEspecialidade_bydesignacao(Me.Tag)
        ' Cod_ExameTextEdit.Text = ClsTipos_Exames.GetTipos_ExamesBydesiignacao(Me.Tag)
        Cod_TIpo_MarcacaoTextEdit.Text = mcod_TM
        TipoMarcacaoTextEdit.Text = ClsTipos_Marcacao.GetTipos_MarcacaoByCod(mcod_TM).Designacao

        If Not IsNewAppointment Then
            mclsMarcacao = ClsMarcacoes.GetMarcacoesByCod(Controller.EditedAppointmentCopy.CustomFields("Cod_Marcacao"))
            Get_UCS(False)
        Else
            Get_UCS(True)

        End If

        If IsNewAppointment Then
            SetupComps(False)


            load_Medicos_TE()
            load_Salas_TE()
            load_Utentes_TE()
            load_Artigos_TE()
        Else
            SetupComps(True)
            Load_Registos()
        End If
    End Sub
    Protected Overridable Function CreateController(ByVal control As SchedulerControl, ByVal apt As Appointment) As AppointmentFormController
        Return New AppointmentFormController(control, apt)
    End Function
    Private Sub SubscribeEditorsEvents()
        'AddHandler Me.cbReminder.EditValueChanging, AddressOf OnCbReminderEditValueChanging
    End Sub
    Private Sub SubscribeControllerEvents(ByVal controller As AppointmentFormController)
        If controller Is Nothing Then
            Return
        End If
        AddHandler controller.PropertyChanged, AddressOf OnControllerPropertyChanged
    End Sub
    Private Sub OnControllerPropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
        If e.PropertyName = "ReadOnly" Then
            UpdateReadonly()
        End If
    End Sub
    Protected Overridable Sub UpdateReadonly()
        If Controller Is Nothing Then
            Return
        End If
        Dim controls As IList(Of Control) = GetAllControls(Me)
        For Each control As Control In controls
            Dim editor As BaseEdit = TryCast(control, BaseEdit)
            If editor Is Nothing Then
                Continue For
            End If
            editor.ReadOnly = Controller.ReadOnly
        Next control
        Me.btnOk.Enabled = Not Controller.ReadOnly
        Me.btnRecurrence.Enabled = Not Controller.ReadOnly
    End Sub

    Private Function GetAllControls(ByVal rootControl As Control) As List(Of Control)
        Dim result As New List(Of Control)()
        For Each control As Control In rootControl.Controls
            result.Add(control)
            Dim childControls As IList(Of Control) = GetAllControls(control)
            result.AddRange(childControls)
        Next control
        Return result
    End Function
    Protected Friend Overridable Sub LoadIcons()
        Dim asm As System.Reflection.Assembly = GetType(Appointment).Assembly
        Me.m_recurringSvgImage = ResourceImageHelper.CreateSvgImageFromResources(SchedulerSvgImageNames.NewRecurringAppointment, asm)
        Me.m_normalSvgImage = ResourceImageHelper.CreateSvgImageFromResources(SchedulerSvgImageNames.NewAppointment, asm)
    End Sub
    Protected Friend Overridable Sub SubscribeControlsEvents()
        AddHandler edtEndDate.Validating, AddressOf OnEdtEndDateValidating
        AddHandler edtEndDate.InvalidValue, AddressOf OnEdtEndDateInvalidValue
        AddHandler edtEndTime.Validating, AddressOf OnEdtEndTimeValidating
        AddHandler edtEndTime.InvalidValue, AddressOf OnEdtEndTimeInvalidValue
        'AddHandler cbReminder.InvalidValue, AddressOf OnCbReminderInvalidValue
        'AddHandler cbReminder.Validating, AddressOf OnCbReminderValidating
        AddHandler edtStartDate.Validating, AddressOf OnEdtStartDateValidating
        AddHandler edtStartDate.InvalidValue, AddressOf OnEdtStartDateInvalidValue
        AddHandler edtStartTime.Validating, AddressOf OnEdtStartTimeValidating
        AddHandler edtStartTime.InvalidValue, AddressOf OnEdtStartTimeInvalidValue
    End Sub
    Protected Friend Overridable Sub UnsubscribeControlsEvents()
        RemoveHandler edtEndDate.Validating, AddressOf OnEdtEndDateValidating
        RemoveHandler edtEndDate.InvalidValue, AddressOf OnEdtEndDateInvalidValue
        RemoveHandler edtEndTime.Validating, AddressOf OnEdtEndTimeValidating
        RemoveHandler edtEndTime.InvalidValue, AddressOf OnEdtEndTimeInvalidValue
        ' RemoveHandler cbReminder.InvalidValue, AddressOf OnCbReminderInvalidValue
        ' RemoveHandler cbReminder.Validating, AddressOf OnCbReminderValidating
        RemoveHandler edtStartDate.Validating, AddressOf OnEdtStartDateValidating
        RemoveHandler edtStartDate.InvalidValue, AddressOf OnEdtStartDateInvalidValue
        RemoveHandler edtStartTime.Validating, AddressOf OnEdtStartTimeValidating
        RemoveHandler edtStartTime.InvalidValue, AddressOf OnEdtStartTimeInvalidValue
    End Sub
    Private Sub OnBtnOkClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnOk.Click
        'OnOkButton()

        frmMarcacoes.SchedulerDataStorage1.RefreshData()
        Me.Close()
    End Sub

    Private Sub btnGrava_Click(sender As Object, e As EventArgs) Handles btnGrava.Click
        If IsNewAppointment Then
            Grava(True)
        Else
            Grava(False)
        End If
        SetupComps(True)
        LoadRegistos()

    End Sub
    Protected Friend Overridable Sub OnEdtStartTimeInvalidValue(ByVal sender As Object, ByVal e As InvalidValueExceptionEventArgs)
        e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval)
    End Sub
    Protected Friend Overridable Sub OnEdtStartTimeValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
        e.Cancel = Not Controller.ValidateLimitInterval(Me.edtStartDate.DateTime.Date, Me.edtStartTime.Time.TimeOfDay, Me.edtEndDate.DateTime.Date, Me.edtEndTime.Time.TimeOfDay)
    End Sub
    Protected Friend Overridable Sub OnEdtStartDateInvalidValue(ByVal sender As Object, ByVal e As InvalidValueExceptionEventArgs)
        e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval)
    End Sub
    Protected Friend Overridable Sub OnEdtStartDateValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
        e.Cancel = Not Controller.ValidateLimitInterval(Me.edtStartDate.DateTime.Date, Me.edtStartTime.Time.TimeOfDay, Me.edtEndDate.DateTime.Date, Me.edtEndTime.Time.TimeOfDay)
    End Sub
    Protected Friend Overridable Sub OnEdtEndDateValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
        e.Cancel = Not IsValidInterval()
        If (Not e.Cancel) Then
            Me.edtEndDate.DataBindings("EditValue").WriteValue()
        End If
    End Sub
    Protected Friend Overridable Sub OnEdtEndDateInvalidValue(ByVal sender As Object, ByVal e As InvalidValueExceptionEventArgs)
        If (Not AppointmentFormControllerBase.ValidateInterval(Me.edtStartDate.DateTime.Date, Me.edtStartTime.Time.TimeOfDay, Me.edtEndDate.DateTime.Date, Me.edtEndTime.Time.TimeOfDay)) Then
            e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidEndDate)
        Else
            e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval)
        End If
    End Sub
    Protected Friend Overridable Sub OnEdtEndTimeValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
        e.Cancel = Not IsValidInterval()
        If (Not e.Cancel) Then
            Me.edtEndTime.DataBindings("EditValue").WriteValue()
        End If
    End Sub
    Protected Friend Overridable Sub OnEdtEndTimeInvalidValue(ByVal sender As Object, ByVal e As InvalidValueExceptionEventArgs)
        If (Not AppointmentFormControllerBase.ValidateInterval(Me.edtStartDate.DateTime.Date, Me.edtStartTime.Time.TimeOfDay, Me.edtEndDate.DateTime.Date, Me.edtEndTime.Time.TimeOfDay)) Then
            e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidEndDate)
        Else
            e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval)
        End If
    End Sub
    Protected Friend Overridable Function IsValidInterval() As Boolean
        Return AppointmentFormControllerBase.ValidateInterval(Me.edtStartDate.DateTime.Date, Me.edtStartTime.Time.TimeOfDay, Me.edtEndDate.DateTime.Date, Me.edtEndTime.Time.TimeOfDay) AndAlso Controller.ValidateLimitInterval(Me.edtStartDate.DateTime.Date, Me.edtStartTime.Time.TimeOfDay, Me.edtEndDate.DateTime.Date, Me.edtEndTime.Time.TimeOfDay)
    End Function
    Protected Friend Overridable Sub OnOkButton()
        If (Not ValidateDateAndTime()) Then
            Return
        End If
        If (Not SaveFormData(Controller.EditedAppointmentCopy)) Then
            Return
        End If
        If (Not Controller.IsConflictResolved()) Then
            ShowMessageBox(SchedulerLocalizer.GetString(SchedulerStringId.Msg_Conflict), Controller.GetMessageBoxCaption(SchedulerStringId.Msg_Conflict), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If IsAppointmentChanged(Controller.EditedAppointmentCopy) OrElse Controller.IsAppointmentChanged() OrElse Controller.IsNewAppointment Then
            Controller.ApplyChanges()
        End If

        DialogResult = System.Windows.Forms.DialogResult.OK

    End Sub
    Private Function ValidateDateAndTime() As Boolean
        Me.edtEndDate.DoValidate()
        Me.edtEndTime.DoValidate()
        Me.edtStartDate.DoValidate()
        Me.edtStartTime.DoValidate()

        Return String.IsNullOrEmpty(Me.edtEndTime.ErrorText) AndAlso String.IsNullOrEmpty(Me.edtEndDate.ErrorText) AndAlso String.IsNullOrEmpty(Me.edtStartDate.ErrorText) AndAlso String.IsNullOrEmpty(Me.edtStartTime.ErrorText)
    End Function
    Protected Friend Overridable Function ShowMessageBox(ByVal text As String, ByVal caption As String, ByVal buttons As MessageBoxButtons, ByVal icon As MessageBoxIcon) As DialogResult
        Return XtraMessageBox.Show(Me, text, caption, buttons, icon)
    End Function
    Private Sub OnBtnDeleteClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        OnDeleteButton()
    End Sub
    Protected Friend Overridable Sub OnDeleteButton()
        If IsNewAppointment Then
            Return
        End If

        Controller.DeleteAppointment()

        DialogResult = System.Windows.Forms.DialogResult.Abort
        Close()
    End Sub
    Private Sub OnBtnRecurrenceClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnRecurrence.Click
        OnRecurrenceButton()
    End Sub
    Protected Friend Overridable Sub OnRecurrenceButton()
        If (Not Controller.ShouldShowRecurrenceButton) Then
            Return
        End If

        Dim patternCopy As Appointment = Controller.PrepareToRecurrenceEdit()

        Dim result As DialogResult
        Using form As Form = CreateAppointmentRecurrenceForm(patternCopy, Control.OptionsView.FirstDayOfWeek)
            result = ShowRecurrenceForm(form)
        End Using

        If result = System.Windows.Forms.DialogResult.Abort Then
            Controller.RemoveRecurrence()
        ElseIf result = System.Windows.Forms.DialogResult.OK Then
            Controller.ApplyRecurrence(patternCopy)
        End If
    End Sub
    Protected Overridable Function ShowRecurrenceForm(ByVal form As Form) As DialogResult
        Return form.ShowDialog(Me)
    End Function
    Protected Friend Overridable Function CreateAppointmentRecurrenceForm(ByVal patternCopy As Appointment, ByVal firstDayOfWeek As DevExpress.XtraScheduler.FirstDayOfWeek) As Form
        Dim form As New AppointmentRecurrenceForm(patternCopy, firstDayOfWeek, Controller)
        form.SetMenuManager(MenuManager)
        form.LookAndFeel.ParentLookAndFeel = LookAndFeel
        form.ShowExceptionsRemoveMsgBox = Me.m_controller.AreExceptionsPresent()
        Return form
    End Function
    Friend Sub OnAppointmentFormActivated(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Activated
        If Me.m_openRecurrenceForm Then
            Me.m_openRecurrenceForm = False
            OnRecurrenceButton()
        End If
    End Sub
    Protected Friend Overridable Sub OnCbReminderValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
        '  Dim span As TimeSpan = Me.cbReminder.Duration
        ' e.Cancel = (span = TimeSpan.MinValue) OrElse (span.Ticks < 0)
        'If (Not e.Cancel) Then
        'Me.cbReminder.DataBindings("Duration").WriteValue()
        'End If
    End Sub
    Protected Friend Overridable Sub OnCbReminderInvalidValue(ByVal sender As Object, ByVal e As InvalidValueExceptionEventArgs)
        e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidReminderTimeBeforeStart)
    End Sub
    Protected Friend Overridable Sub RecalculateLayoutOfControlsAffectedByProgressPanel()
        If Me.progressPanel.Visible Then
            Return
        End If
        Dim intDeltaY As Integer = Me.progressPanel.Height
        Me.tbDescription.Location = New Point(Me.tbDescription.Location.X, Me.tbDescription.Location.Y - intDeltaY)
        Me.tbDescription.Size = New Size(Me.tbDescription.Size.Width, Me.tbDescription.Size.Height + intDeltaY)
    End Sub
    Private Sub OnCbReminderEditValueChanging(ByVal sender As Object, ByVal e As ChangingEventArgs)
        If TypeOf e.NewValue Is TimeSpan Then
            Return
        End If
        Dim stringValue As String = TryCast(e.NewValue, String)
        Dim duration As TimeSpan = HumanReadableTimeSpanHelper.Parse(stringValue)
        If duration.Ticks < 0 Then
            e.NewValue = TimeSpan.FromTicks(0)
        End If
    End Sub



    Sub Load_Registos()
        LimpaTXT()

        With mclsMarcacao
                FLG_Tipo_MarcacaoTextEdit.Text = .FLG_Tipo_Marcacao
            ' Cod_TIpo_MarcacaoTextEdit.Text = .Cod_Tipo_Marcacao
            Cod_UtenteTextEdit.Text = .Cod_Utente
                Cod_MedicoTextEdit.Text = .Cod_Medico
            Cod_SalaTextEdit.Text = .Cod_Sala
            codArtigoTextEdit.Text = .Cod_Artigo
            'Cod_EspecialidadeTextEdit.Text = .Cod_Especialidade
            'Cod_ExameTextEdit.Text = .Cod_Exame
            edtStartDate.DateTime = .Dia
                edtStartTime.Text = .Hora_Inicio
                edtEndTime.Text = .Hora_Fim
                edtShowTimeAs.SelectedIndex = .Status.ToString
                tbDescription.Text = .Observacoes
            '-------------------------
            ' Cod_Marcacao
            '-------------------------
            Cod_MarcacaoTextEdit.Text = .Cod_Marcacao

            UtentesTextEdit.Text = .Utente
                MedicosTextEdit.Text = .Medico
            'ExameTextEdit.Text = .Exame
            SalasTextEdit.Text = .Sala
            'EspecialidadeTextEdit.Text = .Especialidade
            'TipoMarcacaoTextEdit.Text = .Tipos_Marcacao
            StatusTextEdit.Text = .status_Nome
            ArtigoTextEdit.Text = .Artigo



            '-------------------------------
            'Exemplo para as Combos...
            '-------------------------------
            'ucPaises.Text = clsPaises.GetPaisbyCod(.Cod_Pais).Pais
        End With
        '-------------------------------
        'upBar.Value = mNav.Registo_Atual
        '-------------------------------



    End Sub

    Private Sub CustomAppointmentForm_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged

    End Sub

    Sub InsertConsulta()

    End Sub

    Sub UpdateConsulta()

    End Sub

    '------------------------------------------------------------------------------------------------------------------------
    'subs da clsMarcaçoes
    '------------------------------------------------------------------------------------------------------------------------



    Sub getmlistas()
        'mlistaMedicos = ClsEntidades.GetNomesEntidadesBy_FLG("M")
        'mlistaUtentes = ClsEntidades.GetNomesEntidadesBy_FLG("U")
        'mlistaTipos_Marcacao.Add()
        'mlistaSalas.Add()
        'mlistaEspecialidades.Add()
    End Sub

    Sub SetupComps(ByVal pBool As Boolean)
        Me.Cod_MarcacaoTextEdit.ReadOnly = True

        'ucTM.Visible = Not pBool
        'ucEspecialidades.Visible = Not pBool
        ucUtentes.Visible = Not pBool
        'ucExame.Visible = Not pBool
        ucSalas.Visible = Not pBool
        ucMedicos.Visible = Not pBool
        'ucStatus.Visible = Not pBool
        ucArtigos.Visible = Not pBool

        FLG_Tipo_MarcacaoTextEdit.ReadOnly = pBool
        Cod_TIpo_MarcacaoTextEdit.ReadOnly = pBool
        Cod_UtenteTextEdit.ReadOnly = pBool
        Cod_MedicoTextEdit.ReadOnly = pBool
        Cod_SalaTextEdit.ReadOnly = pBool
        Cod_EspecialidadeTextEdit.ReadOnly = True
        'Cod_ExameTextEdit.ReadOnly = pBool
        codArtigoTextEdit.ReadOnly = pBool

        UtentesTextEdit.ReadOnly = pBool
        MedicosTextEdit.ReadOnly = pBool
        TipoMarcacaoTextEdit.ReadOnly = pBool
        EspecialidadeTextEdit.ReadOnly = True
        SalasTextEdit.ReadOnly = pBool
        'ExameTextEdit.ReadOnly = pBool
        ArtigoTextEdit.ReadOnly = pBool

        edtEndDate.ReadOnly = pBool
        edtEndTime.ReadOnly = pBool
        edtLabel.ReadOnly = pBool
        ' edtResource.ReadOnly = pBool
        ' edtResources.ReadOnly = pBool
        edtShowTimeAs.ReadOnly = pBool
        edtStartDate.ReadOnly = pBool
        edtStartTime.ReadOnly = pBool


        btnModifica.Visible = pBool
        btnCancel.Visible = Not pBool
        btnDelete.Visible = pBool
        btnGrava.Visible = Not pBool
        btnOk.Visible = pBool
        'btnRecurrence.Visible = False 'Not pBool

        'DiaDateEdit.ReadOnly = pBool
        'Hora_InicioTimeEdit.ReadOnly = pBool
        'Hora_FimTimeEdit.ReadOnly = pBool
        'id_StatusTextEdit.ReadOnly = pBool
        'ObservacoesTextEdit.ReadOnly = pBool

        '------------------------------
        'Exemplo da eventual UltraCmbo 
        '------------------------------
        'Me.PaisUltraCombo.ReadOnly = pBool

    End Sub

    Sub LoadRegistos()
        LimpaTXT()

        With mclsMarcacao
            FLG_Tipo_MarcacaoTextEdit.Text = .FLG_Tipo_Marcacao
            Cod_TIpo_MarcacaoTextEdit.Text = .Cod_Tipo_Marcacao
            Cod_UtenteTextEdit.Text = .Cod_Utente
            Cod_MedicoTextEdit.Text = .Cod_Medico
            Cod_SalaTextEdit.Text = .Cod_Sala
            Cod_EspecialidadeTextEdit.Text = .Cod_Especialidade
            codArtigoTextEdit.Text = .Cod_Artigo
            'Cod_ExameTextEdit.Text = .Cod_Exame
            codStatusTextEdit.Text = .Status

            'DiaDateEdit.Text = .Dia
            'Hora_InicioTimeEdit.Text = .Hora_Inicio
            'Hora_FimTimeEdit.Text = .Hora_Fim
            'id_StatusTextEdit.Text = .Status.ToString
            'ObservacoesTextEdit.Text = .Observacoes
            '-------------------------
            ' Cod_Marcacao
            '-------------------------
            Cod_MarcacaoTextEdit.Text = .Cod_Marcacao

            ArtigoTextEdit.Text = .Artigo
            UtentesTextEdit.Text = .Utente
            MedicosTextEdit.Text = .Medico
            'ExameTextEdit.Text = .Exame
            SalasTextEdit.Text = .Sala
            EspecialidadeTextEdit.Text = .Especialidade
            TipoMarcacaoTextEdit.Text = .Tipos_Marcacao
            StatusTextEdit.Text = .status_Nome
            tbDescription.Text = .Observacoes


            '-------------------------------
            'Exemplo para as Combos...
            '-------------------------------
            'ucPaises.Text = clsPaises.GetPaisbyCod(.Cod_Pais).Pais
        End With
        '-------------------------------
        'upBar.Value = mNav.Registo_Atual
        '-------------------------------



    End Sub

    Sub LimpaTXT()



        'ExameTextEdit.Text = ""
        'EspecialidadeTextEdit.Text = ""
        'TipoMarcacaoTextEdit.Text = ""
        MedicosTextEdit.Text = ""
        UtentesTextEdit.Text = ""
        SalasTextEdit.Text = ""
        StatusTextEdit.Text = ""
        tbDescription.Text = ""
        ArtigoTextEdit.Text = ""

        'ucEspecialidades.Value = ""
        'ucTM.Value = ""
        ucMedicos.Value = ""
        ucUtentes.Value = ""
        ucSalas.Value = ""
        'ucExame.Value = ""
        ucArtigos.Value = ""
        'edtShowTimeAs.Text = ""

        FLG_Tipo_MarcacaoTextEdit.Text = ""
        'Cod_TIpo_MarcacaoTextEdit.Text = ""
        Cod_UtenteTextEdit.Text = ""
        Cod_MedicoTextEdit.Text = ""
        Cod_SalaTextEdit.Text = ""
        codArtigoTextEdit.Text = ""
        'Cod_ExameTextEdit.Text = ""

        '-------------------------------
        Cod_MarcacaoTextEdit.Text = ""
    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False

        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mclsMarcacao
            If pbNovo Then
                '--------------------------------------
                'Método Não criado na CLASSE 
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Marcacao = ClsMarcacoes.GetNovoCodigo(FLG_Tipo_MarcacaoTextEdit.Text)
                '--------------------------------------
            Else
                '--------------------------------------
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Marcacao = Cod_MarcacaoTextEdit.Text
            End If
            '----------------------------------
            'Aqui VERIFICAR Todos os CAMPOS
            '  Não tem por ex. o FLG_Ativo...
            '----------------------------------
            .FLG_Tipo_Marcacao = FLG_Tipo_MarcacaoTextEdit.Text
            .Cod_Tipo_Marcacao = Cod_TIpo_MarcacaoTextEdit.Text
            .Cod_Utente = Cod_UtenteTextEdit.Text
            .Cod_Medico = Cod_MedicoTextEdit.Text
            .Cod_Sala = Cod_SalaTextEdit.Text
            .Cod_Especialidade = Cod_EspecialidadeTextEdit.Text
            '.Cod_Exame = Cod_ExameTextEdit.Text
            .Cod_Artigo = codArtigoTextEdit.Text
            .Dia = DateTime.Parse(edtStartDate.DateTime)
            .Hora_Inicio = DateTime.Parse(edtStartTime.Time)
            .Hora_Fim = DateTime.Parse(edtEndTime.Time)

            .Status = edtShowTimeAs.SelectedIndex
            .Observacoes = tbDescription.Text
        End With

        If pbNovo Then
            mFLG_Gravou = ClsMarcacoes.GravaMarcacoes(mclsMarcacao)
        Else
            mFLG_Gravou = ClsMarcacoes.ModificaMarcacoes(mclsMarcacao)
        End If


        If mFLG_Gravou Then
            gravaAppointments(pbNovo)
        Else
            MsgBox("Erro na gravação:")
        End If
    End Sub

    Sub gravaAppointments(ByVal pbNovo As Boolean)
        Dim mFLG_Gravou As Boolean = False

        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mclsAppointment

            .customField1 = mclsMarcacao.Cod_Marcacao
            .AllDay = chkAllDay.Checked
            .Description = tbDescription.Text
            .Label = edtLabel.SelectedIndex + 1
            .Location = SalasTextEdit.Text


            Get_Datas()
            .QueryEndDate = mHF
            .QueryStartDate = mHI
            .EndDate = mHF
            .StartDate = mHI



            If m_openRecurrenceForm = True Then
                .RecurrenceInfo = Controller.EditedPattern.RecurrenceInfo.ToString
            Else
                .RecurrenceInfo = ""
            End If
            .ReminderInfo = ""
            .ResourceID = 1
            .ResourceIDs = ""
            .Status = edtShowTimeAs.SelectedIndex
            .Subject = EspecialidadeTextEdit.Text
            .TimeZoneId = ""
            .Type = 0
            .customField2 = mcod_TM
        End With

        If pbNovo Then
            mFLG_Gravou = ClsAppointments.GravaAppointments(mclsAppointment)
        Else
            mFLG_Gravou = ClsAppointments.ModificaAppointments(mclsAppointment)
        End If


        If mFLG_Gravou Then
            LoadRegistos()
        Else
            MsgBox("Erro na gravação:")
        End If


        frmMain.Open_frmMarcacoes(mclsMarcacao.Especialidade, mclsMarcacao.Cod_Tipo_Marcacao)
    End Sub


    Sub Apaga_Registo()
        Try
            ClsMarcacoes.ApagaMarcacoes(mclsMarcacao.Cod_Marcacao)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try


        LoadRegistos()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    'Private Sub ucEspecialidades_AfterCloseup(sender As Object, e As EventArgs) Handles ucEspecialidades.AfterCloseUp, ucEspecialidades.Leave
    '    EspecialidadeTextEdit.Text = ucEspecialidades.SelectedRow.Cells("Designacao").Text
    '    Cod_EspecialidadeTextEdit.Text = ucEspecialidades.SelectedRow.Cells("Cod_Especialidade").Text
    'End Sub
    Private Sub ucUtentes_AfterCloseup(sender As Object, e As EventArgs) Handles ucUtentes.AfterCloseUp, ucUtentes.Leave
        load_Utentes_TE()
    End Sub
    Private Sub load_Utentes_TE()
        UtentesTextEdit.Text = ucUtentes.SelectedRow.Cells("Nome").Text
        Cod_UtenteTextEdit.Text = ucUtentes.SelectedRow.Cells("Cod_Entidade").Text
        mclsMarcacao.Cod_Utente = ucUtentes.SelectedRow.Cells("Cod_Entidade").Text
        Display_Descriptions()
    End Sub
    Private Sub ucMedicos_AfterCloseup(sender As Object, e As EventArgs) Handles ucMedicos.AfterCloseUp, ucMedicos.Leave
        load_Medicos_TE()
    End Sub
    Private Sub load_Medicos_TE()
        MedicosTextEdit.Text = ucMedicos.SelectedRow.Cells("Nome").Text
        Cod_MedicoTextEdit.Text = ucMedicos.SelectedRow.Cells("Cod_Entidade").Text
        mclsMarcacao.Cod_Medico = ucMedicos.SelectedRow.Cells("Cod_Entidade").Text
        Display_Descriptions()
    End Sub
    Private Sub ucMarcacoes_AfterCloseup(sender As Object, e As EventArgs)
        load_Marcacoes_TE()
    End Sub
    Private Sub load_Marcacoes_TE()
        'TipoMarcacaoTextEdit.Text = ucTM.SelectedRow.Cells("Designacao").Text
        'Cod_TIpo_MarcacaoTextEdit.Text = ucTM.SelectedRow.Cells("Cod_Tipo_Marcacao").Text
        FLG_Tipo_MarcacaoTextEdit.Text = TipoMarcacaoTextEdit.Text.Substring(0, 1)
    End Sub
    Private Sub ucSalas_AfterCloseup(sender As Object, e As EventArgs) Handles ucSalas.AfterCloseUp, ucSalas.Leave
        load_Salas_TE()
    End Sub
    Private Sub load_Salas_TE()
        SalasTextEdit.Text = ucSalas.SelectedRow.Cells("Designacao").Text
        Cod_SalaTextEdit.Text = ucSalas.SelectedRow.Cells("Cod_sala").Text
        mclsMarcacao.Cod_Sala = ucSalas.SelectedRow.Cells("Cod_sala").Text
        Display_Descriptions()
    End Sub
    Private Sub ucexame_AfterCloseup(sender As Object, e As EventArgs)
        load_Exame_TE()
    End Sub
    Private Sub load_Exame_TE()
        'ExameTextEdit.Text = ucExame.SelectedRow.Cells("Designacao").Text
        'Cod_ExameTextEdit.Text = ucExame.SelectedRow.Cells("Cod_Exame").Text
    End Sub

    Private Sub ucArtigos_AfterCloseup(sender As Object, e As EventArgs) Handles ucArtigos.AfterCloseUp, ucArtigos.Leave
        load_Artigos_TE()
    End Sub
    Private Sub load_Artigos_TE()
        ArtigoTextEdit.Text = ucArtigos.SelectedRow.Cells("Designacao").Text
        codArtigoTextEdit.Text = ucArtigos.SelectedRow.Cells("Cod_Artigo").Text
        mclsMarcacao.Cod_Artigo = ucArtigos.SelectedRow.Cells("Cod_Artigo").Text
        Display_Descriptions()
    End Sub

    Private Sub btnModifica_Click(sender As Object, e As EventArgs) Handles btnModifica.Click
        SetupComps(False)
    End Sub

    'Private Sub ucStatus_AfterCloseup(sender As Object, e As EventArgs) Handles ucStatus.AfterCloseUp, ucStatus.Leave
    '    StatusTextEdit.Text = ucStatus.SelectedRow.Cells("Status_Nome").Text
    '    id_StatusTextEdit.Text = ucStatus.SelectedRow.Cells("id").Text
    ' End Sub

    '------------------------------------------------------------------------------------------------------------------------
    ' fim subs da clsMarcaçoes
    '------------------------------------------------------------------------------------------------------------------------


End Class