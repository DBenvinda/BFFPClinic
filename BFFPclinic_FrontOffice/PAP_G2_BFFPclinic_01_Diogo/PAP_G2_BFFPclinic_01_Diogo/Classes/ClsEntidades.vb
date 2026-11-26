
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsEntidades Classe da Tabela Entidades
'''      Gerado em 31/01/2024 10:35:36
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class ClsEntidades


    ' -----------------------------------------
    ' Property's da tabela Entidades
    ' -----------------------------------------

    Public Property Cod_Entidade As String                                  ' Len:  5 - SQL_Type: nvarchar
    Public Property FLG_Entidade As String                                  ' Len:  1 - SQL_Type: nvarchar
    Public Property Nome As String                                          ' Len: 80 - SQL_Type: nvarchar
    Public Property Cod_Pais As String                                      ' Len:  2 - SQL_Type: nvarchar
    Public ReadOnly Property Pais As String
        Get
            Return ClsPaises.GetPaisesByCod(Cod_Pais).Pais
        End Get
    End Property
    Public Property Num_Telefone As String                                  ' Len: 15 - SQL_Type: nvarchar
    Public Property Num_Telemovel As String                                 ' Len: 15 - SQL_Type: nvarchar
    Public Property Email As String                                         ' Len: 80 - SQL_Type: nvarchar
    Public Property NIF As String                                           ' Len: 20 - SQL_Type: nvarchar
    Public Property Data_Registo As Date                                    ' SQL_Type: smalldatetime
    Public Property Cod_Especialidade As String                             ' Len:  5 - SQL_Type: nvarchar
    Public ReadOnly Property Especialidade As String
        Get
            Especialidade = ClsEspecialidades.GetEspecialidadesByCod(Cod_Especialidade).Designacao
        End Get
    End Property
    Public Property Utilizador As String                                    ' Len: 10 - SQL_Type: nvarchar
    Public Property Palavra_Passe As String                                 ' Len: 20 - SQL_Type: nvarchar
    Public Property Num_Utente_Saude As String                              ' Len:  9 - SQL_Type: nvarchar
    Public Property Fotografia As String                                    ' Len: 50 - SQL_Type: nvarchar

    Public ReadOnly Property Lista_Enderecos As List(Of ClsEnderecos)
        Get
            Return ClsEnderecos.GetEnderecos(Cod_Entidade)
        End Get
    End Property

    Public ReadOnly Property Endereco As ClsEnderecos
        Get
            Return If(Cod_Entidade = "", Nothing, Lista_Enderecos(0))
        End Get
    End Property

    Public ReadOnly Property Contador_Enderecos As Integer
        Get
            Return Lista_Enderecos.FindAll(Function(x) x.Descritivo <> "").Count
        End Get
    End Property
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    'Friend Shared Function GetNovoCodigo() As String

    'Return "E" & ClsEmpresas.GetContador(enCont.Entidades).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

    'End Function

    Friend Shared Function GetNovoCodigo(pFLG_Entidade As String) As String
        Dim mENC As New enCont

        mENC = GetEncont(pFLG_Entidade)


        Return pFLG_Entidade & ClsEmpresas.GetContador(mENC).ToString("0000") ' <-------------- VERIFICAR O Nº de ZEROS

    End Function
    ''' <summary>
    '''      Function GetEntidades() Método para devolver a Lista de Entidades
    '''      Gerado em 31/01/2024 10:35:36
    ''' </summary>
    ''' <returns>
    '''      mListaEntidades
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    ''' 
    Public Shared Function GetEntidades() As List(Of ClsEntidades)
        Dim mListaEntidades As New List(Of ClsEntidades)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Entidade,'') As Cod_Entidade,"
        mStrSQL += "ISNULL(FLG_Entidade,'') As FLG_Entidade,"
        mStrSQL += "ISNULL(Nome,'') As Nome,"
        mStrSQL += "ISNULL(Cod_Pais,'') As Cod_Pais,"
        mStrSQL += "ISNULL(Num_Telefone,'') As Num_Telefone,"
        mStrSQL += "ISNULL(Num_Telemovel,'') As Num_Telemovel,"
        mStrSQL += "ISNULL(Email,'') As Email,"
        mStrSQL += "ISNULL(NIF,'') As NIF,"
        mStrSQL += "ISNULL(Data_Registo,0) As Data_Registo,"
        mStrSQL += "ISNULL(Cod_Especialidade,'') As Cod_Especialidade,"
        mStrSQL += "ISNULL(Utilizador,'') As Utilizador,"
        mStrSQL += "ISNULL(Palavra_Passe,'') As Palavra_Passe,"
        mStrSQL += "ISNULL(Num_Utente_Saude,'') As Num_Utente_Saude,"
        mStrSQL += "ISNULL(Fotografia,'') As Fotografia,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Entidades "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND FLG_Entidade= 'C' OR FLG_Entidade = 'U'"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsEntidades As New ClsEntidades

            With mClsEntidades
                .Cod_Entidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Entidade"))
                .FLG_Entidade = mRDR.GetString(mRDR.GetOrdinal("FLG_Entidade"))
                .Nome = mRDR.GetString(mRDR.GetOrdinal("Nome"))
                .Cod_Pais = mRDR.GetString(mRDR.GetOrdinal("Cod_Pais"))
                .Num_Telefone = mRDR.GetString(mRDR.GetOrdinal("Num_Telefone"))
                .Num_Telemovel = mRDR.GetString(mRDR.GetOrdinal("Num_Telemovel"))
                .Email = mRDR.GetString(mRDR.GetOrdinal("Email"))
                .NIF = mRDR.GetString(mRDR.GetOrdinal("NIF"))
                .Data_Registo = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Registo"))
                .Cod_Especialidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Especialidade"))
                .Utilizador = mRDR.GetString(mRDR.GetOrdinal("Utilizador"))
                .Palavra_Passe = mRDR.GetString(mRDR.GetOrdinal("Palavra_Passe"))
                .Num_Utente_Saude = mRDR.GetString(mRDR.GetOrdinal("Num_Utente_Saude"))
                .Fotografia = mRDR.GetString(mRDR.GetOrdinal("Fotografia"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaEntidades.Add(mClsEntidades)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaEntidades
    End Function

    Public Shared Function TestaEntidadesbyuser(pUser As String, pPass As String) As Boolean
        Dim mClsEntidades As New ClsEntidades
        Dim mreturn As Boolean = False
        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader



        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pUser", pUser)

        mStrSQL = "SELECT "

        mStrSQL += "ISNULL(Utilizador,'') As Utilizador,"
        mStrSQL += "ISNULL(Palavra_Passe,'') As Palavra_Passe "
        mStrSQL += "FROM Entidades "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Utilizador=@pUser"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader



        If mRDR.Read() Then


            With mClsEntidades
                .Palavra_Passe = mRDR.GetString(mRDR.GetOrdinal("Palavra_Passe"))
                .Utilizador = mRDR.GetString(mRDR.GetOrdinal("Utilizador"))
            End With

            mreturn = (mClsEntidades.Palavra_Passe = pPass)


        End If
        mRDR.Close()
        mDB.Close()

        Return mreturn
    End Function
    'Public Shared Function GetFLG_Entidadebyuser(pUser As String) As Boolean
    '    Dim mClsEntidades As New ClsEntidades
    '    Dim mreturn As Boolean = False
    '    Dim mStrSQL As String
    '    Dim mDB As New SqlConnection
    '    Dim mCMD As New SqlCommand
    '    Dim mRDR As SqlDataReader
    '
    '
    '
    '    mDB.ConnectionString = My.Settings.Connection
    '    mCMD.Parameters.Clear()
    '    mCMD.Parameters.AddWithValue("@pUser", pUser)
    '
    '    mStrSQL = "SELECT "
    '
    '    mStrSQL += "ISNULL(Utilizador,'') As Utilizador,"
    '    mStrSQL += "ISNULL(FLG_Entidade,'') As FLG_Entidade "
    '    mStrSQL += "FROM Entidades "
    '    mStrSQL += "WHERE FLG_Ativo=1 "
    '    mStrSQL += "AND Utilizador=@pUser"
    '
    '
    '    mCMD.CommandText = mStrSQL
    '    mDB.Open()
    '    mCMD.Connection = mDB
    '
    '    mRDR = mCMD.ExecuteReader
    '
    '
    '
    '    If mRDR.Read() Then
    '
    '
    '        With mClsEntidades
    '            .FLG_Entidade = mRDR.GetString(mRDR.GetOrdinal("FLG_Entidade"))
    '            .Utilizador = mRDR.GetString(mRDR.GetOrdinal("Utilizador"))
    '        End With
    '
    '        mreturn = mClsEntidades.FLG_Entidade
    '
    '
    '    End If
    '    mRDR.Close()
    '    mDB.Close()
    '
    '    Return mreturn
    'End Function
    Public Shared Function GetEntidadesBy_FLG(ByVal pFLG_Entidade As String) As List(Of ClsEntidades)
        Dim mListaEntidades As New List(Of ClsEntidades)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@FLG_Entidade", pFLG_Entidade)

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Entidade,'') As Cod_Entidade,"
        mStrSQL += "ISNULL(FLG_Entidade,'') As FLG_Entidade,"
        mStrSQL += "ISNULL(Nome,'') As Nome,"
        mStrSQL += "ISNULL(Cod_Pais,'') As Cod_Pais,"
        mStrSQL += "ISNULL(Num_Telefone,'') As Num_Telefone,"
        mStrSQL += "ISNULL(Num_Telemovel,'') As Num_Telemovel,"
        mStrSQL += "ISNULL(Email,'') As Email,"
        mStrSQL += "ISNULL(NIF,'') As NIF,"
        mStrSQL += "ISNULL(Data_Registo,0) As Data_Registo,"
        mStrSQL += "ISNULL(Cod_Especialidade,'') As Cod_Especialidade,"
        mStrSQL += "ISNULL(Utilizador,'') As Utilizador,"
        mStrSQL += "ISNULL(Palavra_Passe,'') As Palavra_Passe,"
        mStrSQL += "ISNULL(Num_Utente_Saude,'') As Num_Utente_Saude,"
        mStrSQL += "ISNULL(Fotografia,'') As Fotografia,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Entidades "
        mStrSQL += "WHERE FLG_Ativo=1 and FLG_Entidade=@FLG_Entidade"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsEntidades As New ClsEntidades

            With mClsEntidades
                .Cod_Entidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Entidade"))
                .FLG_Entidade = mRDR.GetString(mRDR.GetOrdinal("FLG_Entidade"))
                .Nome = mRDR.GetString(mRDR.GetOrdinal("Nome"))
                .Cod_Pais = mRDR.GetString(mRDR.GetOrdinal("Cod_Pais"))
                .Num_Telefone = mRDR.GetString(mRDR.GetOrdinal("Num_Telefone"))
                .Num_Telemovel = mRDR.GetString(mRDR.GetOrdinal("Num_Telemovel"))
                .Email = mRDR.GetString(mRDR.GetOrdinal("Email"))
                .NIF = mRDR.GetString(mRDR.GetOrdinal("NIF"))
                .Data_Registo = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Registo"))
                .Cod_Especialidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Especialidade"))
                .Utilizador = mRDR.GetString(mRDR.GetOrdinal("Utilizador"))
                .Palavra_Passe = mRDR.GetString(mRDR.GetOrdinal("Palavra_Passe"))
                .Num_Utente_Saude = mRDR.GetString(mRDR.GetOrdinal("Num_Utente_Saude"))
                .Fotografia = mRDR.GetString(mRDR.GetOrdinal("Fotografia"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaEntidades.Add(mClsEntidades)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaEntidades
    End Function
    'Public Shared Function GetNomesEntidadesBy_FLG(ByVal pFLG_Entidade As String) As List(Of String)
    '    Dim mListaNomesEntidades As New List(Of String)

    '    Dim mStrSQL As String
    '    Dim mDB As New SqlConnection
    '    Dim mCMD As New SqlCommand
    '    Dim mRDR As SqlDataReader

    '    mDB.ConnectionString = My.Settings.Connection
    '    mCMD.Parameters.Clear()
    '    mCMD.Parameters.AddWithValue("@FLG_Entidade", pFLG_Entidade)

    '    mStrSQL = "SELECT "
    '    mStrSQL += "ISNULL(Nome,'') As Nome "
    '    mStrSQL += "FROM Entidades "
    '    mStrSQL += "WHERE FLG_Ativo=1 and FLG_Entidade=@FLG_Entidade"


    '    mCMD.CommandText = mStrSQL
    '    mDB.Open()
    '    mCMD.Connection = mDB

    '    mRDR = mCMD.ExecuteReader

    '    While mRDR.Read()

    '        Dim mNome As String = ""

    '        mNome = mRDR.GetString(mRDR.GetOrdinal("Nome"))

    '        mListaNomesEntidades.Add(mNome)

    '    End While

    '    mRDR.Close()
    '    mDB.Close()

    '    Return mListaNomesEntidades
    'End Function

    ''' <summary>
    '''      Function FiltrarEntidades Método para Filtrar os campos da lista de Entidades
    '''      Gerado em 31/01/2024 10:35:36
    ''' </summary>
    ''' <returns>
    '''      mListaEntidades
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function FiltrarEntidades(ByVal pFiltro As ClsEntidades) As List(Of ClsEntidades)
        Dim mListaEntidades As New List(Of ClsEntidades)
        Dim mLista As New List(Of ClsEntidades)

        mListaEntidades = GetEntidades()

        mLista = mListaEntidades.FindAll(Function(x) _
x.Cod_Entidade.Contains(pFiltro.Cod_Entidade)
)
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.FLG_Entidade.Contains(pFiltro.FLG_Entidade) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetEntidadesByCod(ByVal pCod_Entidade As String) Método para decolver uma Classe de Entidades
    '''      Gerado em 31/01/2024 10:35:36
    ''' </summary>
    ''' <returns>
    '''      mClsEntidades
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function GetEntidadesByCod(ByVal pCod_Entidade As String) As ClsEntidades
        Dim mClsEntidades As New ClsEntidades

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Entidade", pCod_Entidade)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Entidade,'') As Cod_Entidade,"
        mStrSQL += "ISNULL(FLG_Entidade,'') As FLG_Entidade,"
        mStrSQL += "ISNULL(Nome,'') As Nome,"
        mStrSQL += "ISNULL(Cod_Pais,'') As Cod_Pais,"
        mStrSQL += "ISNULL(Num_Telefone,'') As Num_Telefone,"
        mStrSQL += "ISNULL(Num_Telemovel,'') As Num_Telemovel,"
        mStrSQL += "ISNULL(Email,'') As Email,"
        mStrSQL += "ISNULL(NIF,'') As NIF,"
        mStrSQL += "ISNULL(Data_Registo,0) As Data_Registo,"
        mStrSQL += "ISNULL(Cod_Especialidade,'') As Cod_Especialidade,"
        mStrSQL += "ISNULL(Utilizador,'') As Utilizador,"
        mStrSQL += "ISNULL(Palavra_Passe,'') As Palavra_Passe,"
        mStrSQL += "ISNULL(Num_Utente_Saude,'') As Num_Utente_Saude,"
        mStrSQL += "ISNULL(Fotografia,'') As Fotografia,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Entidades "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Entidade=@pCod_Entidade"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsEntidades
                .Cod_Entidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Entidade"))
                .FLG_Entidade = mRDR.GetString(mRDR.GetOrdinal("FLG_Entidade"))
                .Nome = mRDR.GetString(mRDR.GetOrdinal("Nome"))
                .Cod_Pais = mRDR.GetString(mRDR.GetOrdinal("Cod_Pais"))
                .Num_Telefone = mRDR.GetString(mRDR.GetOrdinal("Num_Telefone"))
                .Num_Telemovel = mRDR.GetString(mRDR.GetOrdinal("Num_Telemovel"))
                .Email = mRDR.GetString(mRDR.GetOrdinal("Email"))
                .NIF = mRDR.GetString(mRDR.GetOrdinal("NIF"))
                .Data_Registo = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Registo"))
                .Cod_Especialidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Especialidade"))
                .Utilizador = mRDR.GetString(mRDR.GetOrdinal("Utilizador"))
                .Palavra_Passe = mRDR.GetString(mRDR.GetOrdinal("Palavra_Passe"))
                .Num_Utente_Saude = mRDR.GetString(mRDR.GetOrdinal("Num_Utente_Saude"))
                .Fotografia = mRDR.GetString(mRDR.GetOrdinal("Fotografia"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsEntidades
    End Function

    Public Shared Function GetEspecialidadebyUtilizador(ByVal pUtilizador As String) As String
        Dim mCod_Especialidade As String
        Dim mEspecialidade As String

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pUtilizador", pUtilizador)


        mStrSQL = "SELECT "

        mStrSQL += "ISNULL(Cod_Especialidade,'') As Cod_Especialidade "

        mStrSQL += "FROM Entidades "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Utilizador=@pUtilizador"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then

            mCod_Especialidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Especialidade"))

        End If
        mEspecialidade = ClsEspecialidades.GetEspecialidadesByCod(mCod_Especialidade).Designacao
        mRDR.Close()
        mDB.Close()

        Return mEspecialidade
    End Function

    ''' <summary>
    '''      Function ModificaEntidades(ByVal pClsEntidades As ClsEntidades) Método para Modificar a TABELA Entidades
    '''      Gerado em 31/01/2024 10:35:37
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function ModificaEntidades(ByVal pClsEntidades As ClsEntidades) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Entidade", pClsEntidades.Cod_Entidade.Substring(0, IIf(Len(pClsEntidades.Cod_Entidade) > 5, 5, Len(pClsEntidades.Cod_Entidade))))
        mCMD.Parameters.AddWithValue("@pFLG_Entidade", pClsEntidades.FLG_Entidade.Substring(0, IIf(Len(pClsEntidades.FLG_Entidade) > 1, 1, Len(pClsEntidades.FLG_Entidade))))
        mCMD.Parameters.AddWithValue("@pNome", pClsEntidades.Nome.Substring(0, IIf(Len(pClsEntidades.Nome) > 80, 80, Len(pClsEntidades.Nome))))
        mCMD.Parameters.AddWithValue("@pCod_Pais", pClsEntidades.Cod_Pais.Substring(0, IIf(Len(pClsEntidades.Cod_Pais) > 2, 2, Len(pClsEntidades.Cod_Pais))))
        mCMD.Parameters.AddWithValue("@pNum_Telefone", pClsEntidades.Num_Telefone.Substring(0, IIf(Len(pClsEntidades.Num_Telefone) > 15, 15, Len(pClsEntidades.Num_Telefone))))
        mCMD.Parameters.AddWithValue("@pNum_Telemovel", pClsEntidades.Num_Telemovel.Substring(0, IIf(Len(pClsEntidades.Num_Telemovel) > 15, 15, Len(pClsEntidades.Num_Telemovel))))
        mCMD.Parameters.AddWithValue("@pEmail", pClsEntidades.Email.Substring(0, IIf(Len(pClsEntidades.Email) > 80, 80, Len(pClsEntidades.Email))))
        mCMD.Parameters.AddWithValue("@pNIF", pClsEntidades.NIF.Substring(0, IIf(Len(pClsEntidades.NIF) > 20, 20, Len(pClsEntidades.NIF))))
        mCMD.Parameters.AddWithValue("@pData_Registo", pClsEntidades.Data_Registo)
        mCMD.Parameters.AddWithValue("@pCod_Especialidade", pClsEntidades.Cod_Especialidade.Substring(0, IIf(Len(pClsEntidades.Cod_Especialidade) > 5, 5, Len(pClsEntidades.Cod_Especialidade))))
        mCMD.Parameters.AddWithValue("@pUtilizador", pClsEntidades.Utilizador.Substring(0, IIf(Len(pClsEntidades.Utilizador) > 10, 10, Len(pClsEntidades.Utilizador))))
        mCMD.Parameters.AddWithValue("@pPalavra_Passe", pClsEntidades.Palavra_Passe.Substring(0, IIf(Len(pClsEntidades.Palavra_Passe) > 20, 20, Len(pClsEntidades.Palavra_Passe))))
        mCMD.Parameters.AddWithValue("@pNum_Utente_Saude", pClsEntidades.Num_Utente_Saude.Substring(0, IIf(Len(pClsEntidades.Num_Utente_Saude) > 9, 9, Len(pClsEntidades.Num_Utente_Saude))))
        mCMD.Parameters.AddWithValue("@pFotografia", pClsEntidades.Fotografia.Substring(0, IIf(Len(pClsEntidades.Fotografia) > 50, 50, Len(pClsEntidades.Fotografia))))


        mStrSQL = "UPDATE Entidades SET "
        mStrSQL += "FLG_Entidade=@pFLG_Entidade,"
        mStrSQL += "Nome=@pNome,"
        mStrSQL += "Cod_Pais=@pCod_Pais,"
        mStrSQL += "Num_Telefone=@pNum_Telefone,"
        mStrSQL += "Num_Telemovel=@pNum_Telemovel,"
        mStrSQL += "Email=@pEmail,"
        mStrSQL += "NIF=@pNIF,"
        mStrSQL += "Data_Registo=@pData_Registo,"
        mStrSQL += "Cod_Especialidade=@pCod_Especialidade,"
        mStrSQL += "Utilizador=@pUtilizador,"
        mStrSQL += "Palavra_Passe=@pPalavra_Passe,"
        mStrSQL += "Num_Utente_Saude=@pNum_Utente_Saude,"
        mStrSQL += "Fotografia=@pFotografia "
        mStrSQL += "WHERE Cod_Entidade=@pCod_Entidade"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaEntidades:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaEntidades(ByVal pNovoEntidades As ClsEntidades) Método para Gravar a TABELA Entidades
    '''      Gerado em 31/01/2024 10:35:37
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    ''' 

    Private Shared Function GetEncont(pFLG_Entidade As String) As enCont
        Dim mReturn As enCont

        Select Case pFLG_Entidade
            Case "C"
                mReturn = enCont.Clientes
            Case "F"
                mReturn = enCont.Fornecedores
            Case "R"
                mReturn = enCont.Rececionistas
            Case "A"
                mReturn = enCont.Administradores
            Case "M"
                mReturn = enCont.Medicos
            Case "U"
                mReturn = enCont.utentes

        End Select

        Return mReturn
    End Function
    Public Shared Function GravaEntidades(ByVal pNovoEntidades As ClsEntidades) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Entidade", pNovoEntidades.Cod_Entidade.Substring(0, IIf(Len(pNovoEntidades.Cod_Entidade) > 5, 5, Len(pNovoEntidades.Cod_Entidade))))
        mCMD.Parameters.AddWithValue("@pFLG_Entidade", pNovoEntidades.FLG_Entidade.Substring(0, IIf(Len(pNovoEntidades.FLG_Entidade) > 1, 1, Len(pNovoEntidades.FLG_Entidade))))
        mCMD.Parameters.AddWithValue("@pNome", pNovoEntidades.Nome.Substring(0, IIf(Len(pNovoEntidades.Nome) > 80, 80, Len(pNovoEntidades.Nome))))
        mCMD.Parameters.AddWithValue("@pCod_Pais", pNovoEntidades.Cod_Pais.Substring(0, IIf(Len(pNovoEntidades.Cod_Pais) > 2, 2, Len(pNovoEntidades.Cod_Pais))))
        mCMD.Parameters.AddWithValue("@pNum_Telefone", pNovoEntidades.Num_Telefone.Substring(0, IIf(Len(pNovoEntidades.Num_Telefone) > 15, 15, Len(pNovoEntidades.Num_Telefone))))
        mCMD.Parameters.AddWithValue("@pNum_Telemovel", pNovoEntidades.Num_Telemovel.Substring(0, IIf(Len(pNovoEntidades.Num_Telemovel) > 15, 15, Len(pNovoEntidades.Num_Telemovel))))
        mCMD.Parameters.AddWithValue("@pEmail", pNovoEntidades.Email.Substring(0, IIf(Len(pNovoEntidades.Email) > 80, 80, Len(pNovoEntidades.Email))))
        mCMD.Parameters.AddWithValue("@pNIF", pNovoEntidades.NIF.Substring(0, IIf(Len(pNovoEntidades.NIF) > 20, 20, Len(pNovoEntidades.NIF))))
        mCMD.Parameters.AddWithValue("@pData_Registo", pNovoEntidades.Data_Registo)
        mCMD.Parameters.AddWithValue("@pCod_Especialidade", pNovoEntidades.Cod_Especialidade.Substring(0, IIf(Len(pNovoEntidades.Cod_Especialidade) > 5, 5, Len(pNovoEntidades.Cod_Especialidade))))
        mCMD.Parameters.AddWithValue("@pUtilizador", pNovoEntidades.Utilizador.Substring(0, IIf(Len(pNovoEntidades.Utilizador) > 10, 10, Len(pNovoEntidades.Utilizador))))
        mCMD.Parameters.AddWithValue("@pPalavra_Passe", pNovoEntidades.Palavra_Passe.Substring(0, IIf(Len(pNovoEntidades.Palavra_Passe) > 20, 20, Len(pNovoEntidades.Palavra_Passe))))
        mCMD.Parameters.AddWithValue("@pNum_Utente_Saude", pNovoEntidades.Num_Utente_Saude.Substring(0, IIf(Len(pNovoEntidades.Num_Utente_Saude) > 9, 9, Len(pNovoEntidades.Num_Utente_Saude))))
        mCMD.Parameters.AddWithValue("@pFotografia", pNovoEntidades.Fotografia.Substring(0, IIf(Len(pNovoEntidades.Fotografia) > 50, 50, Len(pNovoEntidades.Fotografia))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoEntidades.FLG_Ativo)


        mStrSQL = "INSERT INTO Entidades "
        mStrSQL += "("
        mStrSQL += "Cod_Entidade,"
        mStrSQL += "FLG_Entidade,"
        mStrSQL += "Nome,"
        mStrSQL += "Cod_Pais,"
        mStrSQL += "Num_Telefone,"
        mStrSQL += "Num_Telemovel,"
        mStrSQL += "Email,"
        mStrSQL += "NIF,"
        mStrSQL += "Data_Registo,"
        mStrSQL += "Cod_Especialidade,"
        mStrSQL += "Utilizador,"
        mStrSQL += "Palavra_Passe,"
        mStrSQL += "Num_Utente_Saude,"
        mStrSQL += "Fotografia,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Entidade,"
        mStrSQL += "@pFLG_Entidade,"
        mStrSQL += "@pNome,"
        mStrSQL += "@pCod_Pais,"
        mStrSQL += "@pNum_Telefone,"
        mStrSQL += "@pNum_Telemovel,"
        mStrSQL += "@pEmail,"
        mStrSQL += "@pNIF,"
        mStrSQL += "@pData_Registo,"
        mStrSQL += "@pCod_Especialidade,"
        mStrSQL += "@pUtilizador,"
        mStrSQL += "@pPalavra_Passe,"
        mStrSQL += "@pNum_Utente_Saude,"
        mStrSQL += "@pFotografia,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()

            Select Case pNovoEntidades.FLG_Entidade
                Case "U"
                    ClsEmpresas.GravaContador(enCont.utentes)'<<<<-------- Verificar se é  preciso...
                Case "R"
                    ClsEmpresas.GravaContador(enCont.Rececionistas)'<<<<-------- Verificar se é  preciso...
                Case "A"
                    ClsEmpresas.GravaContador(enCont.Administradores)'<<<<-------- Verificar se é  preciso...
                Case "M"
                    ClsEmpresas.GravaContador(enCont.Medicos)'<<<<-------- Verificar se é  preciso...
                Case "C"
                    ClsEmpresas.GravaContador(enCont.Clientes)'<<<<-------- Verificar se é  preciso...
                Case "F"
                    ClsEmpresas.GravaContador(enCont.Fornecedores) '<<<<-------- Verificar se é  preciso...
            End Select

        Catch ex As Exception
            MsgBox("GravaEntidades:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaEntidades(ByVal pCod_Entidade As String) Método para Apagar um Registo da Tabela Entidades
    '''      Gerado em 31/01/2024 10:35:37
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function ApagaEntidades(ByVal pCod_Entidade As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Entidade", pCod_Entidade)


        mStrSQL = "UPDATE Entidades SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Entidade=@pCod_Entidade"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaEntidades:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe EntidadesComparer 
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class EntidadesComparer
    Implements IEqualityComparer(Of ClsEntidades)

    Public Function Equals1(ByVal x As ClsEntidades, ByVal y As ClsEntidades) As Boolean Implements IEqualityComparer(Of ClsEntidades).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Entidade = y.Cod_Entidade) ' AndAlso (x.FLG_Entidade = y.FLG_Entidade)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsEntidades) As Integer Implements IEqualityComparer(Of ClsEntidades).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsEntidades_FLG_Entidade = pCls.FLG_Entidade.GetHashCode()
        Dim Hash_ClsEntidades_Cod_Entidade = pCls.Cod_Entidade.GetHashCode()

        Return Hash_ClsEntidades_Cod_Entidade 'Xor Hash_ClsEntidades_FLG_Entidade
    End Function
End Class
