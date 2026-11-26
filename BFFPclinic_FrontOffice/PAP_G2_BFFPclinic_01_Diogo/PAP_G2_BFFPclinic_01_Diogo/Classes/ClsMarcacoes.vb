
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsMarcacoes Classe da Tabela Marcacoes
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class ClsMarcacoes


    ' -----------------------------------------
    ' Property's da tabela Marcacoes
    ' -----------------------------------------

    Public Property Cod_Marcacao As String                                  ' Len:  5 - SQL_Type: nvarchar
    Public Property FLG_Tipo_Marcacao As String                             ' Len:  1 - SQL_Type: nvarchar
    Public Property Cod_Tipo_Marcacao As String                             ' Len:  5 - SQL_Type: nvarchar

    Public ReadOnly Property Tipos_Marcacao As String
        Get
            Return ClsTipos_Marcacao.GetTipos_MarcacaoByCod(Cod_Tipo_Marcacao).Designacao
        End Get
    End Property

    Public Property Cod_Utente As String
    Public ReadOnly Property Utente As String                                ' Len:  5 - SQL_Type: nvarchar
        Get
            Return ClsEntidades.GetEntidadesByCod(Cod_Utente).Nome
        End Get
    End Property
    Public Property Cod_Medico As String
    Public ReadOnly Property Medico As String                                    ' Len:  5 - SQL_Type: nvarchar
        Get
            Return ClsEntidades.GetEntidadesByCod(Cod_Medico).Nome
        End Get
    End Property
    Public Property Cod_Sala As String
    Public ReadOnly Property Sala As String                                      ' Len:  5 - SQL_Type: nvarchar
        Get
            Return ClsSalas.GetSalasByCod(Cod_Sala).Designacao
        End Get
    End Property
    Public Property Cod_Especialidade As String
    Public ReadOnly Property Especialidade As String                             ' Len:  5 - SQL_Type: nvarchar
        Get
            Return ClsEspecialidades.GetEspecialidadesByCod(Cod_Especialidade).Designacao
        End Get
    End Property


    Public Property Cod_Artigo As String
    Public ReadOnly Property Artigo As String                                     ' Len:  5 - SQL_Type: nvarchar
        Get
            Return ClsArtigos.GetArtigosByCod(Cod_Artigo).Designacao
        End Get
    End Property

    Public Property Dia As Date                                           ' SQL_Type: smalldatetime
    Public Property Hora_Inicio As Date                                    ' SQL_Type: smalldatetime
    Public Property Hora_Fim As Date                                    ' SQL_Type: smalldatetime
    Public Property Status As Integer                                       ' SQL_Type: smallint
    Public ReadOnly Property status_Nome As String                                     ' Len:  5 - SQL_Type: nvarchar
        Get
            Return ClsStatuses.GetStatusesByCod(Status).Status_Nome
        End Get
    End Property
    Public Property Observacoes As String                                   ' Len:240 - SQL_Type: nvarchar
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    Friend Shared Function GetNovoCodigo(pFLG_Tipo_Marcacao) As String
        Dim mreturn As String = ""

        Select Case pFLG_Tipo_Marcacao
            Case "O"
                mreturn = "O" & ClsEmpresas.GetContador(enCont.Operacoes).ToString("0000") ' <-------------- VERIFICAR O Nº de ZEROS
            Case "E"
                mreturn = "E" & ClsEmpresas.GetContador(enCont.Exames).ToString("0000") ' <-------------- VERIFICAR O Nº de ZEROS
            Case "C"
                mreturn = "C" & ClsEmpresas.GetContador(enCont.Consultas).ToString("0000") ' <-------------- VERIFICAR O Nº de ZEROS

        End Select

        Return mreturn

    End Function


    ''' <summary>
    '''      Function GetMarcacoes() Método para devolver a Lista de Marcacoes
    '''      Gerado em 31/01/2024 10:35:37
    ''' </summary>
    ''' <returns>
    '''      mListaMarcacoes
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    ''' 
    Public Shared Function GetLista_Cod_Artigos(ByVal pCod_Utente As String) As List(Of ClsMarcacoes)
        Dim mLista_Cod_Artigos As New List(Of ClsMarcacoes)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Utente", pCod_Utente)

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Marcacao,'') As Cod_Marcacao,"
        mStrSQL += "ISNULL(FLG_Tipo_Marcacao,'') As FLG_Tipo_Marcacao,"
        mStrSQL += "ISNULL(Cod_Tipo_Marcacao,'') As Cod_Tipo_Marcacao,"
        mStrSQL += "ISNULL(Cod_Utente,'') As Cod_Utente,"
        mStrSQL += "ISNULL(Cod_Medico,'') As Cod_Medico,"
        mStrSQL += "ISNULL(Cod_Sala,'') As Cod_Sala,"
        mStrSQL += "ISNULL(Cod_Especialidade,'') As Cod_Especialidade,"

        mStrSQL += "ISNULL(Cod_Artigo,'') As Cod_Artigo,"
        mStrSQL += "ISNULL(Dia,0) As Dia,"
        mStrSQL += "ISNULL(Hora_Inicio,0) As Hora_Inicio,"
        mStrSQL += "ISNULL(Hora_Fim,0) As Hora_Fim,"
        mStrSQL += "ISNULL(Status,0) As Status,"
        mStrSQL += "ISNULL(Observacoes,'') As Observacoes,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Marcacoes "
        mStrSQL += "WHERE FLG_Ativo=1 and Cod_Utente = @pcod_Utente and status = 1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsMarcacoes As New ClsMarcacoes

            With mClsMarcacoes
                .Cod_Marcacao = mRDR.GetString(mRDR.GetOrdinal("Cod_Marcacao"))
                .FLG_Tipo_Marcacao = mRDR.GetString(mRDR.GetOrdinal("FLG_Tipo_Marcacao"))
                .Cod_Tipo_Marcacao = mRDR.GetString(mRDR.GetOrdinal("Cod_Tipo_Marcacao"))
                .Cod_Utente = mRDR.GetString(mRDR.GetOrdinal("Cod_Utente"))
                .Cod_Medico = mRDR.GetString(mRDR.GetOrdinal("Cod_Medico"))
                .Cod_Sala = mRDR.GetString(mRDR.GetOrdinal("Cod_Sala"))
                .Cod_Especialidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Especialidade"))

                .Cod_Artigo = mRDR.GetString(mRDR.GetOrdinal("Cod_Artigo"))
                .Dia = mRDR.GetDateTime(mRDR.GetOrdinal("Dia"))
                .Hora_Inicio = mRDR.GetDateTime(mRDR.GetOrdinal("Hora_Inicio"))
                .Hora_Fim = mRDR.GetDateTime(mRDR.GetOrdinal("Hora_Fim"))
                .Status = mRDR.GetValue(mRDR.GetOrdinal("Status"))
                .Observacoes = mRDR.GetString(mRDR.GetOrdinal("Observacoes"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mLista_Cod_Artigos.Add(mClsMarcacoes)


        End While

        mRDR.Close()
        mDB.Close()

        Return mLista_Cod_Artigos
    End Function
    Public Shared Function GetMarcacoes() As List(Of ClsMarcacoes)
        Dim mListaMarcacoes As New List(Of ClsMarcacoes)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Marcacao,'') As Cod_Marcacao,"
        mStrSQL += "ISNULL(FLG_Tipo_Marcacao,'') As FLG_Tipo_Marcacao,"
        mStrSQL += "ISNULL(Cod_Tipo_Marcacao,'') As Cod_Tipo_Marcacao,"
        mStrSQL += "ISNULL(Cod_Utente,'') As Cod_Utente,"
        mStrSQL += "ISNULL(Cod_Medico,'') As Cod_Medico,"
        mStrSQL += "ISNULL(Cod_Sala,'') As Cod_Sala,"
        mStrSQL += "ISNULL(Cod_Especialidade,'') As Cod_Especialidade,"
        mStrSQL += "ISNULL(Cod_Exame,'') As Cod_Exame,"
        mStrSQL += "ISNULL(Cod_Artigo,'') As Cod_Artigo,"
        mStrSQL += "ISNULL(Dia,0) As Dia,"
        mStrSQL += "ISNULL(Hora_Inicio,0) As Hora_Inicio,"
        mStrSQL += "ISNULL(Hora_Fim,0) As Hora_Fim,"
        mStrSQL += "ISNULL(Status,0) As Status,"
        mStrSQL += "ISNULL(Observacoes,'') As Observacoes,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Marcacoes "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsMarcacoes As New ClsMarcacoes

            With mClsMarcacoes
                .Cod_Marcacao = mRDR.GetString(mRDR.GetOrdinal("Cod_Marcacao"))
                .FLG_Tipo_Marcacao = mRDR.GetString(mRDR.GetOrdinal("FLG_Tipo_Marcacao"))
                .Cod_Tipo_Marcacao = mRDR.GetString(mRDR.GetOrdinal("Cod_Tipo_Marcacao"))
                .Cod_Utente = mRDR.GetString(mRDR.GetOrdinal("Cod_Utente"))
                .Cod_Medico = mRDR.GetString(mRDR.GetOrdinal("Cod_Medico"))
                .Cod_Sala = mRDR.GetString(mRDR.GetOrdinal("Cod_Sala"))
                .Cod_Especialidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Especialidade"))

                .Cod_Artigo = mRDR.GetString(mRDR.GetOrdinal("Cod_Artigo"))
                .Dia = mRDR.GetDateTime(mRDR.GetOrdinal("Dia"))
                .Hora_Inicio = mRDR.GetDateTime(mRDR.GetOrdinal("Hora_Inicio"))
                .Hora_Fim = mRDR.GetDateTime(mRDR.GetOrdinal("Hora_Fim"))
                .Status = mRDR.GetValue(mRDR.GetOrdinal("Status"))
                .Observacoes = mRDR.GetString(mRDR.GetOrdinal("Observacoes"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaMarcacoes.Add(mClsMarcacoes)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaMarcacoes
    End Function

    ''' <summary>
    '''      Function FiltrarMarcacoes Método para Filtrar os campos da lista de Marcacoes
    '''      Gerado em 31/01/2024 10:35:37
    ''' </summary>
    ''' <returns>
    '''      mListaMarcacoes
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function FiltrarMarcacoes(ByVal pFiltro As ClsMarcacoes) As List(Of ClsMarcacoes)
        Dim mListaMarcacoes As New List(Of ClsMarcacoes)
        Dim mLista As New List(Of ClsMarcacoes)

        mListaMarcacoes = GetMarcacoes()

        mLista = mListaMarcacoes.FindAll(Function(x) _
x.Cod_Marcacao.Contains(pFiltro.Cod_Marcacao)
)
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.FLG_Tipo_Marcacao.Contains(pFiltro.FLG_Tipo_Marcacao) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetMarcacoesByCod(ByVal pCod_Marcacao As String) Método para decolver uma Classe de Marcacoes
    '''      Gerado em 31/01/2024 10:35:37
    ''' </summary>
    ''' <returns>
    '''      mClsMarcacoes
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function GetMarcacoesByCod(ByVal pCod_Marcacao As String) As ClsMarcacoes
        Dim mClsMarcacoes As New ClsMarcacoes

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Marcacao", pCod_Marcacao)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Marcacao,'') As Cod_Marcacao,"
        mStrSQL += "ISNULL(FLG_Tipo_Marcacao,'') As FLG_Tipo_Marcacao,"
        mStrSQL += "ISNULL(Cod_Tipo_Marcacao,'') As Cod_Tipo_Marcacao,"
        mStrSQL += "ISNULL(Cod_Utente,'') As Cod_Utente,"
        mStrSQL += "ISNULL(Cod_Medico,'') As Cod_Medico,"
        mStrSQL += "ISNULL(Cod_Sala,'') As Cod_Sala,"
        mStrSQL += "ISNULL(Cod_Especialidade,'') As Cod_Especialidade,"

        mStrSQL += "ISNULL(Cod_Artigo,'') As Cod_Artigo,"
        mStrSQL += "ISNULL(Dia,0) As Dia,"
        mStrSQL += "ISNULL(Hora_Inicio,0) As Hora_Inicio,"
        mStrSQL += "ISNULL(Hora_Fim,0) As Hora_Fim,"
        mStrSQL += "ISNULL(Status,0) As Status,"
        mStrSQL += "ISNULL(Observacoes,'') As Observacoes,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Marcacoes "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Marcacao=@pCod_Marcacao"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsMarcacoes
                .Cod_Marcacao = mRDR.GetString(mRDR.GetOrdinal("Cod_Marcacao"))
                .FLG_Tipo_Marcacao = mRDR.GetString(mRDR.GetOrdinal("FLG_Tipo_Marcacao"))
                .Cod_Tipo_Marcacao = mRDR.GetString(mRDR.GetOrdinal("Cod_Tipo_Marcacao"))
                .Cod_Utente = mRDR.GetString(mRDR.GetOrdinal("Cod_Utente"))
                .Cod_Medico = mRDR.GetString(mRDR.GetOrdinal("Cod_Medico"))
                .Cod_Sala = mRDR.GetString(mRDR.GetOrdinal("Cod_Sala"))
                .Cod_Especialidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Especialidade"))

                .Cod_Artigo = mRDR.GetString(mRDR.GetOrdinal("Cod_Artigo"))
                .Dia = mRDR.GetDateTime(mRDR.GetOrdinal("Dia"))
                .Hora_Inicio = mRDR.GetDateTime(mRDR.GetOrdinal("Hora_Inicio"))
                .Hora_Fim = mRDR.GetDateTime(mRDR.GetOrdinal("Hora_Fim"))
                .Status = mRDR.GetValue(mRDR.GetOrdinal("Status"))
                .Observacoes = mRDR.GetString(mRDR.GetOrdinal("Observacoes"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsMarcacoes
    End Function


    ''' <summary>
    '''      Function ModificaMarcacoes(ByVal pClsMarcacoes As ClsMarcacoes) Método para Modificar a TABELA Marcacoes
    '''      Gerado em 31/01/2024 10:35:37
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function ModificaMarcacoes(ByVal pClsMarcacoes As ClsMarcacoes) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Marcacao", pClsMarcacoes.Cod_Marcacao.Substring(0, IIf(Len(pClsMarcacoes.Cod_Marcacao) > 5, 5, Len(pClsMarcacoes.Cod_Marcacao))))
        mCMD.Parameters.AddWithValue("@pFLG_Tipo_Marcacao", pClsMarcacoes.FLG_Tipo_Marcacao.Substring(0, IIf(Len(pClsMarcacoes.FLG_Tipo_Marcacao) > 1, 1, Len(pClsMarcacoes.FLG_Tipo_Marcacao))))
        mCMD.Parameters.AddWithValue("@pCod_Tipo_Marcacao", pClsMarcacoes.Cod_Tipo_Marcacao.Substring(0, IIf(Len(pClsMarcacoes.Cod_Tipo_Marcacao) > 5, 5, Len(pClsMarcacoes.Cod_Tipo_Marcacao))))
        mCMD.Parameters.AddWithValue("@pCod_Utente", pClsMarcacoes.Cod_Utente.Substring(0, IIf(Len(pClsMarcacoes.Cod_Utente) > 5, 5, Len(pClsMarcacoes.Cod_Utente))))
        mCMD.Parameters.AddWithValue("@pCod_Medico", pClsMarcacoes.Cod_Medico.Substring(0, IIf(Len(pClsMarcacoes.Cod_Medico) > 5, 5, Len(pClsMarcacoes.Cod_Medico))))
        mCMD.Parameters.AddWithValue("@pCod_Sala", pClsMarcacoes.Cod_Sala.Substring(0, IIf(Len(pClsMarcacoes.Cod_Sala) > 5, 5, Len(pClsMarcacoes.Cod_Sala))))
        mCMD.Parameters.AddWithValue("@pCod_Especialidade", pClsMarcacoes.Cod_Especialidade.Substring(0, IIf(Len(pClsMarcacoes.Cod_Especialidade) > 5, 5, Len(pClsMarcacoes.Cod_Especialidade))))
        mCMD.Parameters.AddWithValue("@pCod_Artigo", pClsMarcacoes.Cod_Artigo.Substring(0, IIf(Len(pClsMarcacoes.Cod_Artigo) > 8, 8, Len(pClsMarcacoes.Cod_Artigo))))
        mCMD.Parameters.AddWithValue("@pDia", pClsMarcacoes.Dia)
        mCMD.Parameters.AddWithValue("@pHora_Inicio", pClsMarcacoes.Hora_Inicio)
        mCMD.Parameters.AddWithValue("@pHora_Fim", pClsMarcacoes.Hora_Fim)
        mCMD.Parameters.AddWithValue("@pStatus", pClsMarcacoes.Status)
        mCMD.Parameters.AddWithValue("@pObservacoes", pClsMarcacoes.Observacoes.Substring(0, IIf(Len(pClsMarcacoes.Observacoes) > 240, 240, Len(pClsMarcacoes.Observacoes))))


        mStrSQL = "UPDATE Marcacoes SET "
        mStrSQL += "FLG_Tipo_Marcacao=@pFLG_Tipo_Marcacao,"
        mStrSQL += "Cod_Tipo_Marcacao=@pCod_Tipo_Marcacao,"
        mStrSQL += "Cod_Utente=@pCod_Utente,"
        mStrSQL += "Cod_Medico=@pCod_Medico,"
        mStrSQL += "Cod_Sala=@pCod_Sala,"
        mStrSQL += "Cod_Especialidade=@pCod_Especialidade,"

        mStrSQL += "Cod_Artigo=@pCod_Artigo,"
        mStrSQL += "Dia=@pDia,"
        mStrSQL += "Hora_Inicio=@pHora_Inicio,"
        mStrSQL += "Hora_Fim=@pHora_Fim,"
        mStrSQL += "Status=@pStatus,"
        mStrSQL += "Observacoes=@pObservacoes "
        mStrSQL += "WHERE Cod_Marcacao=@pCod_Marcacao"


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

    Public Shared Function Atualiza_Status(ByVal pCod_Marcacao As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Marcacao", pCod_Marcacao)


        mStrSQL = "UPDATE Marcacoes SET "
        mStrSQL += "Status=2 "
        mStrSQL += "WHERE Cod_Marcacao=@pCod_Marcacao"


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


    ''' <summary>
    '''      Function GravaMarcacoes(ByVal pNovoMarcacoes As ClsMarcacoes) Método para Gravar a TABELA Marcacoes
    '''      Gerado em 31/01/2024 10:35:37
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function GravaMarcacoes(ByVal pNovoMarcacoes As ClsMarcacoes) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Marcacao", pNovoMarcacoes.Cod_Marcacao.Substring(0, IIf(Len(pNovoMarcacoes.Cod_Marcacao) > 5, 5, Len(pNovoMarcacoes.Cod_Marcacao))))
        mCMD.Parameters.AddWithValue("@pFLG_Tipo_Marcacao", pNovoMarcacoes.FLG_Tipo_Marcacao.Substring(0, IIf(Len(pNovoMarcacoes.FLG_Tipo_Marcacao) > 1, 1, Len(pNovoMarcacoes.FLG_Tipo_Marcacao))))
        mCMD.Parameters.AddWithValue("@pCod_Tipo_Marcacao", pNovoMarcacoes.Cod_Tipo_Marcacao.Substring(0, IIf(Len(pNovoMarcacoes.Cod_Tipo_Marcacao) > 5, 5, Len(pNovoMarcacoes.Cod_Tipo_Marcacao))))
        mCMD.Parameters.AddWithValue("@pCod_Utente", pNovoMarcacoes.Cod_Utente.Substring(0, IIf(Len(pNovoMarcacoes.Cod_Utente) > 5, 5, Len(pNovoMarcacoes.Cod_Utente))))
        mCMD.Parameters.AddWithValue("@pCod_Medico", pNovoMarcacoes.Cod_Medico.Substring(0, IIf(Len(pNovoMarcacoes.Cod_Medico) > 5, 5, Len(pNovoMarcacoes.Cod_Medico))))
        mCMD.Parameters.AddWithValue("@pCod_Sala", pNovoMarcacoes.Cod_Sala.Substring(0, IIf(Len(pNovoMarcacoes.Cod_Sala) > 5, 5, Len(pNovoMarcacoes.Cod_Sala))))
        mCMD.Parameters.AddWithValue("@pCod_Especialidade", pNovoMarcacoes.Cod_Especialidade.Substring(0, IIf(Len(pNovoMarcacoes.Cod_Especialidade) > 5, 5, Len(pNovoMarcacoes.Cod_Especialidade))))
        mCMD.Parameters.AddWithValue("@pCod_Artigo", pNovoMarcacoes.Cod_Artigo.Substring(0, IIf(Len(pNovoMarcacoes.Cod_Artigo) > 8, 8, Len(pNovoMarcacoes.Cod_Artigo))))
        mCMD.Parameters.AddWithValue("@pDia", pNovoMarcacoes.Dia)
        mCMD.Parameters.AddWithValue("@pHora_Inicio", pNovoMarcacoes.Hora_Inicio)
        mCMD.Parameters.AddWithValue("@pHora_Fim", pNovoMarcacoes.Hora_Fim)
        mCMD.Parameters.AddWithValue("@pStatus", pNovoMarcacoes.Status)
        mCMD.Parameters.AddWithValue("@pObservacoes", pNovoMarcacoes.Observacoes.Substring(0, IIf(Len(pNovoMarcacoes.Observacoes) > 240, 240, Len(pNovoMarcacoes.Observacoes))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoMarcacoes.FLG_Ativo)


        mStrSQL = "INSERT INTO Marcacoes "
        mStrSQL += "("
        mStrSQL += "Cod_Marcacao,"
        mStrSQL += "FLG_Tipo_Marcacao,"
        mStrSQL += "Cod_Tipo_Marcacao,"
        mStrSQL += "Cod_Utente,"
        mStrSQL += "Cod_Medico,"
        mStrSQL += "Cod_Sala,"
        mStrSQL += "Cod_Especialidade,"

        mStrSQL += "Cod_Artigo,"
        mStrSQL += "Dia,"
        mStrSQL += "Hora_Inicio,"
        mStrSQL += "Hora_Fim,"
        mStrSQL += "Status,"
        mStrSQL += "Observacoes,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Marcacao,"
        mStrSQL += "@pFLG_Tipo_Marcacao,"
        mStrSQL += "@pCod_Tipo_Marcacao,"
        mStrSQL += "@pCod_Utente,"
        mStrSQL += "@pCod_Medico,"
        mStrSQL += "@pCod_Sala,"
        mStrSQL += "@pCod_Especialidade,"

        mStrSQL += "@pCod_Artigo,"
        mStrSQL += "@pDia,"
        mStrSQL += "@pHora_Inicio,"
        mStrSQL += "@pHora_Fim,"
        mStrSQL += "@pStatus,"
        mStrSQL += "@pObservacoes,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            Select Case pNovoMarcacoes.FLG_Tipo_Marcacao
                Case "O"
                    ClsEmpresas.GravaContador(enCont.Operacoes) '<<<<-------- Verificar se é  preciso...
                Case "C"
                    ClsEmpresas.GravaContador(enCont.Consultas) '<<<<-------- Verificar se é  preciso...
                Case "E"
                    ClsEmpresas.GravaContador(enCont.Exames) '<<<<-------- Verificar se é  preciso...

            End Select


        Catch ex As Exception
            MsgBox("GravaMarcacoes:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaMarcacoes(ByVal pCod_Marcacao As String) Método para Apagar um Registo da Tabela Marcacoes
    '''      Gerado em 31/01/2024 10:35:37
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function ApagaMarcacoes(ByVal pCod_Marcacao As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Marcacao", pCod_Marcacao)


        mStrSQL = "UPDATE Marcacoes SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Marcacao=@pCod_Marcacao"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaMarcacoes:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe MarcacoesComparer 
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class MarcacoesComparer
    Implements IEqualityComparer(Of ClsMarcacoes)

    Public Function Equals1(ByVal x As ClsMarcacoes, ByVal y As ClsMarcacoes) As Boolean Implements IEqualityComparer(Of ClsMarcacoes).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Marcacao = y.Cod_Marcacao) ' AndAlso (x.FLG_Tipo_Marcacao = y.FLG_Tipo_Marcacao)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsMarcacoes) As Integer Implements IEqualityComparer(Of ClsMarcacoes).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsMarcacoes_FLG_Tipo_Marcacao = pCls.FLG_Tipo_Marcacao.GetHashCode()
        Dim Hash_ClsMarcacoes_Cod_Marcacao = pCls.Cod_Marcacao.GetHashCode()

        Return Hash_ClsMarcacoes_Cod_Marcacao 'Xor Hash_ClsMarcacoes_FLG_Tipo_Marcacao
    End Function
End Class
