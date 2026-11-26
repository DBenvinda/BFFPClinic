Imports System.Windows.Automation
Imports DevExpress.Charts.Native
Imports DevExpress.DataProcessing.InMemoryDataProcessor.AddSurrogateOperationAlgorithm
Imports DevExpress.Pdf.Native
Imports DevExpress.XtraBars.Docking
Imports Infragistics.Win.UltraWinGrid

Public Class frmMarcações
    Dim mLista As New List(Of ClsMarcacoes)

    Dim mClsAppointment As New ClsAppointments
    Dim mClsMarcacao As New ClsMarcacoes


    Dim mIndex_Salas As Integer = 0
    Dim mIndex_Medicos As Integer = 0
    Dim mIndex_TM As Integer = 0
    Dim mIndex_Utentes As Integer = 0
    Dim mIndex_Especialides As Integer = 0
    Dim mIndex_Status As Integer = 0

    Dim mLista_Salas As New List(Of ClsSalas)
    Dim mLista_Medicos As New List(Of ClsEntidades)
    Dim mLista_Tipos_Marcacao As New List(Of ClsTipos_Marcacao)
    Dim mLista_Utentes As New List(Of ClsEntidades)
    Dim mLista_Especialidades As New List(Of ClsEspecialidades)

    Dim mlista_Status As New List(Of ClsStatuses)
    Dim mlista_Estado As New List(Of ClsLabels)

    Private mHI As DateTime
    Private mHF As DateTime

    Dim mstatus As Integer

    Private Sub frmMarcacoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        getmlistas()

        mLista = ClsMarcacoes.GetMarcacoes

        mNav = New clsNav(mLista.Count)

        UC_NAV11.mFRM = Me

        SetupComps(True)
        UC_NAV11.Load_Status()
        UC_NAV11.SetupNav()
        LoadRegistos()


        With ucCod_TipoMarcacao
            .DataSource = ClsTipos_Marcacao.GetTipos_Marcacao
            .DisplayLayout.Bands(0).Columns(2).Hidden = True

        End With

        With ucCod_Medico
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
            .DisplayLayout.Bands(0).Columns(19).Hidden = True

        End With
        With ucCod_Utente
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
            .DisplayLayout.Bands(0).Columns(19).Hidden = True
        End With
        With ucCod_Especialidade
            .DataSource = ClsEspecialidades.GetEspecialidades()
            .DisplayLayout.Bands(0).Columns(2).Hidden = True
        End With

        With ucCod_Sala
            .DataSource = ClsSalas.GetSalas
            .DisplayLayout.Bands(0).Columns(2).Hidden = True

        End With
        With ucStatus
            .DataSource = ClsStatuses.GetStatuses
            .DisplayLayout.Bands(0).Columns(1).Hidden = True
            .DisplayLayout.Bands(0).Columns(2).Hidden = True
        End With
        Me.Text = "Manutenção da Tabela de Marcacoes"

        '-------------------------------
        'Exemplo de ProgressBar
        '-------------------------------
        'upBar.Maximum = mNav.Max_Registos
        'upBar.Minimum = 1
        'upBar.Value = mNav.RegistoAtual
        '-------------------------------


        '-------------------------------
        'Exemplo de Combo...
        '-------------------------------

        '-----------------
        'ucPaises
        '-----------------
        'ucPaises.DataSource = clsPaises.GetPaises
        'ucPaises.DisplayMember = "Pais"
        'ucPaises.ValueMember = "Cod_Pais"

        '----------------------------------------------------------------------------------------------
        ' Como se faz um Filtro da Lista de Clientes?
        ' 
        ' A mLista que contém a lista de Marcacoes
        ' pode ser filtrada através do método
        ' FiltrarMarcacoes com o parâmetro da ClsMarcacoes
        ' 
        ' É preciso criar uma variável do tipo ClsMarcacoes
        ' e chamar o método FiltrarMarcacoes com esse parâmetro:
        '
        '   Dim mclsFiltro as New clsMarcacoes with {.Cod_Marcacao=txtCod_Marcacao.Text, .FLG_Tipo_Marcacao=txtFLG_Tipo_Marcacao.Text}
        '   Dim mListaFiltro = clsMarcacoes.FiltrarMarcacoes(mclsFiltro)
        '----------------------------------------------------------------------------------------------

        '-----------------
        'ucPaises
        '-----------------
        'ucPaises.DataSource = clsPaises.GetPaises
        'ucPaises.DisplayMember = "Pais"
        'ucPaises.ValueMember = "Cod_Pais"


    End Sub

    Sub getmlistas()
        mLista_Especialidades = ClsEspecialidades.GetEspecialidades
        mLista_Medicos = ClsEntidades.GetEntidadesBy_FLG("M")
        mLista_Salas = ClsSalas.GetSalas
        mLista_Tipos_Marcacao = ClsTipos_Marcacao.GetTipos_Marcacao
        mLista_Utentes = ClsEntidades.GetEntidadesBy_FLG("U")
        mlista_Estado = ClsLabels.GetLabels

        mlista_Status = ClsStatuses.GetStatuses
    End Sub

    Sub SetupComps(ByVal pBool As Boolean)
        Me.Cod_MarcacaoTextEdit.ReadOnly = True
        Me.UtentesTextEdit.ReadOnly = True
        Me.MedicosTextEdit.ReadOnly = True
        Me.TipoMarcacaoTextEdit.ReadOnly = True
        Me.EspecialidadeTextEdit.ReadOnly = True
        Me.SalasTextEdit.ReadOnly = True
        Me.statusTextEdit.ReadOnly = True

        Me.id_statusTextEdit.ReadOnly = True
        If Not pBool Then
            If Me.UC_NAV11.mNovo Then
                Me.Cod_MarcacaoTextEdit.Focus()
            Else
                Me.FLG_Tipo_MarcacaoTextEdit.Focus()
            End If
        End If
        ucCod_Especialidade.Visible = Not pBool
        ucCod_Medico.Visible = Not pBool
        ucCod_Sala.Visible = Not pBool

        ucCod_TipoMarcacao.Visible = Not pBool
        ucCod_Utente.Visible = Not pBool
        ucStatus.Visible = Not pBool



        FLG_Tipo_MarcacaoTextEdit.ReadOnly = pBool
        Cod_Tipo_MarcacaoTextEdit.ReadOnly = pBool
        Cod_UtenteTextEdit.ReadOnly = pBool
        Cod_MedicoTextEdit.ReadOnly = pBool
        Cod_SalaTextEdit.ReadOnly = pBool
        Cod_EspecialidadeTextEdit.ReadOnly = pBool
        id_statusTextEdit.ReadOnly = pBool
        FLG_AtivoCheckEdit.ReadOnly = pBool
        FLG_AtivoCheckEdit.Visible = False
        tbDescription.ReadOnly = pBool
        edtLabel.ReadOnly = pBool
        edtLabel.BackColor = Color.White
        tbDescription.BackColor = Color.White



        Get_UCS(pBool)

        '------------------------------
        'Exemplo da eventual UltraCmbo 
        '------------------------------
        'Me.PaisUltraCombo.ReadOnly = pBool

    End Sub

    Sub LoadRegistos()
        LimpaTXT()
        If mNav.Registo_Atual > 0 Then
            With mLista(mNav.Registo_Atual - 1)
                FLG_Tipo_MarcacaoTextEdit.Text = .FLG_Tipo_Marcacao
                Cod_Tipo_MarcacaoTextEdit.Text = .Cod_Tipo_Marcacao
                Cod_UtenteTextEdit.Text = .Cod_Utente
                Cod_MedicoTextEdit.Text = .Cod_Medico
                Cod_SalaTextEdit.Text = .Cod_Sala
                Cod_EspecialidadeTextEdit.Text = .Cod_Especialidade
                id_statusTextEdit.Text = .Status.ToString
                '-------------------------
                ' Cod_Marcacao
                '-------------------------
                Cod_MarcacaoTextEdit.Text = .Cod_Marcacao

                UtentesTextEdit.Text = .Utente
                MedicosTextEdit.Text = .Medico
                SalasTextEdit.Text = .Sala
                TipoMarcacaoTextEdit.Text = .Tipos_Marcacao
                id_statusTextEdit.Text = .status_Nome
                FLG_AtivoCheckEdit.Checked = .FLG_Ativo
                tbDescription.Text = .Observacoes
                EspecialidadeTextEdit.Text = .Especialidades
                statusTextEdit.Text = .Status
                'edtLabel.Text = ClsAppointments
                '-------------------------------
                'Exemplo para as Combos...
                '-------------------------------
                'ucPaises.Text = clsPaises.GetPaisbyCod(.Cod_Pais).Pais
            End With
            '-------------------------------
            'upBar.Value = mNav.Registo_Atual
            '-------------------------------

        End If

    End Sub

    Sub LimpaTXT()



        EspecialidadeTextEdit.Text = ""
        TipoMarcacaoTextEdit.Text = ""
        MedicosTextEdit.Text = ""
        UtentesTextEdit.Text = ""
        SalasTextEdit.Text = ""
        statusTextEdit.Text = ""
        tbDescription.Text = ""


        ucCod_Especialidade.Value = ""
        ucCod_Medico.Value = ""
        ucCod_Sala.Value = ""
        ucCod_TipoMarcacao.Value = ""
        ucCod_Utente.Value = ""
        ucStatus.Value = ""

        FLG_Tipo_MarcacaoTextEdit.Text = ""
        Cod_Tipo_MarcacaoTextEdit.Text = ""
        Cod_UtenteTextEdit.Text = ""
        Cod_MedicoTextEdit.Text = ""
        Cod_SalaTextEdit.Text = ""
        Cod_EspecialidadeTextEdit.Text = ""
        id_statusTextEdit.Text = ""
        edtLabel.Text = ""
        '-------------------------------
        Cod_MarcacaoTextEdit.Text = ""
        FLG_AtivoCheckEdit.Checked = 1
    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        'Dim mCls As New ClsMarcacoes
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mClsMarcacao
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
            .Dia = DateTime.Parse(edtStartDate.DateTime)
            .Hora_Inicio = DateTime.Parse(edtEndTime.Time)
            .Hora_Fim = DateTime.Parse(edtEndTime.Time)
            .FLG_Tipo_Marcacao = FLG_Tipo_MarcacaoTextEdit.Text
            .Cod_Tipo_Marcacao = Cod_Tipo_MarcacaoTextEdit.Text
            .Cod_Utente = Cod_UtenteTextEdit.Text
            .Cod_Medico = Cod_MedicoTextEdit.Text
            .Cod_Sala = Cod_SalaTextEdit.Text
            .Cod_Especialidade = Cod_EspecialidadeTextEdit.Text
            .Status = CInt(id_statusTextEdit.Text)
            .Observacoes = tbDescription.Text
            .FLG_Ativo = FLG_AtivoCheckEdit.Checked
            .Observacoes = tbDescription.Text
        End With

        If pbNovo Then
            mFLG_Gravou = ClsMarcacoes.GravaMarcacoes(mClsMarcacao)
        Else
            mFLG_Gravou = ClsMarcacoes.ModificaMarcacoes(mClsMarcacao)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV11.mNovo = False
                mLista = ClsMarcacoes.GetMarcacoes
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Marcacao = mClsMarcacao.Cod_Marcacao) + 1
                LoadRegistos()
                gravaAppointments(pbNovo)

                '---------------------------
                'upBar.Maximum = mNav.Max_Registos
                'upBar.Value = mNav.Registo_Atual
            Else
                mLista = ClsMarcacoes.GetMarcacoes
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mRegisto_Atual
                LoadRegistos()
                gravaAppointments(pbNovo)
            End If
        Else
            MsgBox("Erro na gravação:")
        End If
    End Sub

    Sub gravaAppointments(ByVal pbNovo As Boolean)
        Dim mFLG_Gravou As Boolean = False

        Dim mRegisto_Atual As Integer = mNav.Registo_Atual
        With mClsAppointment

            .customField1 = mClsMarcacao.Cod_Marcacao
            .AllDay = chkAllDay.Checked
            .Description = tbDescription.Text
            .Label = edtLabel.SelectedIndex + 1
            .Location = SalasTextEdit.Text

            'DateTime.Parse- converter para 24 horas

            '.QueryEndDate = edtEndDate.DateTime.AddHours(edtEndTime.Time.Hour)
            '.QueryEndDate = .QueryEndDate.AddMinutes(edtEndTime.Time.Minute)

            '.QueryStartDate = edtStartDate.DateTime.AddHours(edtStartTime.Time.Hour)
            '.QueryStartDate = .QueryStartDate.AddHours(edtStartTime.Time.Minute)

            '.StartDate = .QueryStartDate

            '.EndDate = .QueryEndDate 'DateTime.Parse(edtEndDate.DateTime) 'edtEndDate.DateTime
            Get_Datas()
            .QueryEndDate = mHF
            .QueryStartDate = mHI
            .EndDate = mHF
            .StartDate = mHI

            .RecurrenceInfo = ""

            .ReminderInfo = ""
            .ResourceID = 1
            .ResourceIDs = ""

            .Status = mstatus
            .Subject = EspecialidadeTextEdit.Text
            .TimeZoneId = ""
            .Type = 0
            .Description = tbDescription.Text

        End With

        If pbNovo Then
            mFLG_Gravou = ClsAppointments.GravaAppointments(mClsAppointment)
        Else
            mFLG_Gravou = ClsAppointments.ModificaAppointments(mClsAppointment)
        End If


        If mFLG_Gravou Then
            LoadRegistos()

        Else
            MsgBox("Erro na gravação:")
        End If


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
        mHI = mHI.AddHours(CInt(edtEndTime.Time.Hour))
        mHI = mHI.AddMinutes(CInt(edtEndTime.Time.Minute))

        mHF = edtEndDate.DateTime
        mHF = mHF.AddHours(CInt(edtEndTime.Time.Hour))
        mHF = mHF.AddMinutes(CInt(edtEndTime.Time.Minute))

    End Sub

    Sub Apaga_Registo()
        Try
            ClsMarcacoes.ApagaMarcacoes(mLista(mNav.Registo_Atual - 1).Cod_Marcacao)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsMarcacoes.GetMarcacoes
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub


    Private Sub ucEspecialidades_AfterCloseup(sender As Object, e As EventArgs) Handles ucCod_Especialidade.Leave ',ucEspecialidades.AfterCloseUp
        If ucCod_Especialidade.Value <> "" Then
            EspecialidadeTextEdit.Text = ucCod_Especialidade.SelectedRow.Cells("Designacao").Text
            Cod_EspecialidadeTextEdit.Text = ucCod_Especialidade.SelectedRow.Cells("Cod_Especialidade").Text
        End If
    End Sub
    Private Sub ucUtentes_AfterCloseup(sender As Object, e As EventArgs) Handles ucCod_Utente.Leave ',ucUtentes.AfterCloseUp
        If ucCod_Utente.Value <> "" Then
            UtentesTextEdit.Text = ucCod_Utente.SelectedRow.Cells("Nome").Text
            Cod_UtenteTextEdit.Text = ucCod_Utente.SelectedRow.Cells("Cod_Entidade").Text
        End If
    End Sub
    Private Sub ucMedicos_AfterCloseup(sender As Object, e As EventArgs) Handles ucCod_Medico.Leave ',ucMedicos.AfterCloseUp
        If ucCod_Medico.Value <> "" Then
            MedicosTextEdit.Text = ucCod_Medico.SelectedRow.Cells("Nome").Text
            Cod_MedicoTextEdit.Text = ucCod_Medico.SelectedRow.Cells("Cod_Entidade").Text
        End If
    End Sub
    Private Sub ucMarcacoes_AfterCloseup(sender As Object, e As EventArgs) Handles ucCod_TipoMarcacao.Leave ',ucMacacoes.AfterCloseUp
        If ucCod_TipoMarcacao.Value <> "" Then
            TipoMarcacaoTextEdit.Text = ucCod_TipoMarcacao.SelectedRow.Cells("Designacao").Text
            Cod_Tipo_MarcacaoTextEdit.Text = ucCod_TipoMarcacao.SelectedRow.Cells("Cod_Tipo_Marcacao").Text
            FLG_Tipo_MarcacaoTextEdit.Text = TipoMarcacaoTextEdit.Text.Substring(0, 1)
        End If
    End Sub
    Private Sub ucSalas_AfterCloseup(sender As Object, e As EventArgs) Handles ucCod_Sala.Leave ',ucSalas.AfterCloseUp
        If ucCod_Sala.Value <> "" Then
            SalasTextEdit.Text = ucCod_Sala.SelectedRow.Cells("Designacao").Text
            Cod_SalaTextEdit.Text = ucCod_Sala.SelectedRow.Cells("Cod_sala").Text
        End If
    End Sub
    Private Sub ucStatus_AfterCloseup(sender As Object, e As EventArgs) Handles ucStatus.Leave ',ucStatus.AfterCloseUp
        If ucStatus.Value <> "" Then
            mstatus = ucStatus.SelectedRow.Index + 1
            id_statusTextEdit.Text = ucStatus.SelectedRow.Cells("Status_Nome").Text
            id_statusTextEdit.Text = ucStatus.SelectedRow.Cells("id").Text
        End If
    End Sub
    Sub Get_UCS(pNovo As Boolean)
        getmlistas()

        If pNovo Then
            mIndex_Salas = 0
            mIndex_TM = 0
            mIndex_Utentes = 0
            mIndex_Especialides = 0
            mIndex_Medicos = 0
            mIndex_Status = 0
        Else
            mIndex_Salas = mLista_Salas.FindIndex(Function(x) x.Cod_Sala = mClsMarcacao.Cod_Sala) + 1
            mIndex_TM = mLista_Tipos_Marcacao.FindIndex(Function(x) x.Cod_Tipo_Marcacao = mClsMarcacao.Cod_Tipo_Marcacao) + 1
            mIndex_Utentes = mLista_Utentes.FindIndex(Function(x) x.Cod_Entidade = mClsMarcacao.Cod_Utente) + 1
            mIndex_Especialides = mLista_Especialidades.FindIndex(Function(x) x.Cod_Especialidade = mClsMarcacao.Cod_Especialidade) + 1
            mIndex_Medicos = mLista_Medicos.FindIndex(Function(x) x.Cod_Entidade = mClsMarcacao.Cod_Medico) + 1
            'mindex_Exames = mlista_exames.FindIndex(Function(x) x.Cod_Exame = mClsMarcacao.Cod_Exame) + 1
            mIndex_Status = mlista_Status.FindIndex(Function(x) x.Status_Nome = mClsMarcacao.status_Nome) + 1
        End If

        With Me.ucCod_TipoMarcacao
            .DataSource = mLista_Tipos_Marcacao
            .DisplayMember = "Cod_Tipo_Marcacao"
            .Rows(mIndex_TM).Selected = True
            ucCod_TipoMarcacao.Value = Cod_Tipo_MarcacaoTextEdit.Text
        End With

        With Me.ucCod_Especialidade
            .DataSource = mLista_Especialidades
            .DisplayMember = "Cod_Especialidade"
            .Rows(mIndex_Especialides).Selected = True
            ucCod_Especialidade.Value = Cod_EspecialidadeTextEdit.Text
        End With

        With Me.ucCod_Medico
            .DataSource = mLista_Medicos
            .DisplayMember = "Cod_Entidade"
            .Rows(mIndex_Medicos).Selected = True
            ucCod_Medico.Value = Cod_MedicoTextEdit.Text
        End With

        With Me.ucCod_Sala
            .DataSource = mLista_Salas
            .DisplayMember = "Cod_Sala"
            .Rows(mIndex_Salas).Selected = True
            ucCod_Sala.Value = Cod_SalaTextEdit.Text
        End With

        With Me.ucCod_Utente
            .DataSource = mLista_Utentes
            .DisplayMember = "Cod_Entidade"
            .Rows(mIndex_Utentes).Selected = True
            ucCod_Utente.Value = Cod_UtenteTextEdit.Text
        End With

        With Me.ucStatus
            .DataSource = mlista_Status
            .DisplayMember = "Status_Nome"
            .Rows(mIndex_Status).Selected = True
            ucStatus.Value = id_statusTextEdit.Text
        End With

    End Sub

End Class