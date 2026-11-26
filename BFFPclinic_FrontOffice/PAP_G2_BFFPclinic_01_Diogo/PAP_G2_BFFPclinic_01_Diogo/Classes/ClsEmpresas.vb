
Imports System.Data.SqlClient


Public Enum enCont As Integer

    Clientes
    Fornecedores
    utentes
    Medicos
    Rececionistas
    Administradores
    Produtos
    Servicos
    IVA
    Especialidades
    Tipos_Doc
    Tipos_Marcacao
    Tipos_Pagamento
    Operacoes
    Exames
    Consultas
    Doc
    Salas
    Series
    Enderecos
End Enum


''' <summary>
'''      Classe ClsEmpresas Classe da Tabela Empresas
'''      Gerado em 31/01/2024 10:35:36
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class ClsEmpresas


    ' -----------------------------------------
    ' Property's da tabela Empresas
    ' -----------------------------------------

    Public Property Cod_Empresa As String                                   ' Len:  1 - SQL_Type: nvarchar
    Public Property Nome As String                                          ' Len: 50 - SQL_Type: nvarchar
    Public Property Endereco As String                                      ' Len: 50 - SQL_Type: nvarchar
    Public Property Pais As String                                          ' Len: 30 - SQL_Type: nvarchar
    Public Property Cod_Postal As String                                    ' Len:  8 - SQL_Type: nvarchar
    Public Property Localidade As String                                    ' Len: 50 - SQL_Type: nvarchar
    Public Property Email As String                                         ' Len: 50 - SQL_Type: nvarchar
    Public Property www As String                                           ' Len: 50 - SQL_Type: nvarchar
    Public Property Num_Telefone As String                                  ' Len:  9 - SQL_Type: nvarchar
    Public Property Num_Telemovel As String                                 ' Len:  9 - SQL_Type: nvarchar
    Public Property Capital_Social As String                                ' Len: 14 - SQL_Type: nvarchar
    Public Property Registo_Comercial As String                             ' Len: 30 - SQL_Type: nvarchar
    Public Property Matricula_CRC As String                                 ' Len: 20 - SQL_Type: nvarchar
    Public Property Data_Constituicao As Date                               ' SQL_Type: smalldatetime
    Public Property NIF As String                                           ' Len:  9 - SQL_Type: nvarchar
    Public Property Contador_Clientes As Integer                            ' SQL_Type: smallint
    Public Property Contador_Fornecedores As Integer                        ' SQL_Type: smallint
    Public Property Contador_Medicos As Integer                             ' SQL_Type: smallint
    Public Property Contador_Utentes As Integer                             ' SQL_Type: smallint
    Public Property Contador_Rececionistas As Integer                             ' SQL_Type: smallint
    Public Property Contador_Administradores As Integer                             ' SQL_Type: smallint
    Public Property Contador_Produtos As Integer                            ' SQL_Type: smallint
    Public Property Contador_Servicos As Integer                            ' SQL_Type: smallint
    Public Property Contador_IVA As Integer                                 ' SQL_Type: smallint

    Public Property Contador_Especialidades As Integer                      ' SQL_Type: smallint

    Public Property Contador_Tipos_Marcacao As Integer                      ' SQL_Type: smallint

    Public Property Contador_Tipos_Pagamento As Integer                     ' SQL_Type: smallint
    Public Property Contador_Operacoes As Integer                           ' SQL_Type: smallint
    Public Property Contador_Exames As Integer                              ' SQL_Type: smallint
    Public Property Contador_Consultas As Integer
    Public Property Contador_Doc As Integer ' SQL_Type: smallint
    Public Property Contador_Salas As Integer
    Public Property Contador_Series As Integer
    Public Property Ano_Trabalho As String                                  ' Len:  4 - SQL_Type: nvarchar
    Public Property Hora_Abertura As String                                 ' Len:  5 - SQL_Type: nvarchar
    Public Property Hora_Fecho As String                                    ' Len:  5 - SQL_Type: nvarchar
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    ' Friend Shared Function GetNovoCodigo() As String

    'Return "E" & ClsEmpresas.GetContador(enCont.Empresas).ToString("000") ' <-------------- VERIFICAR O Nº de ZEROS

    '  End Function

    ''' <summary>
    '''      Function GetContador (ByVal pEnum as Encont) - Método para devolver o contador específico guardado na Tabela Empresas
    '''      Gerado em 31/01/2024 10:35:36
    ''' </summary>
    ''' <returns>
    '''      Contador guardado + 1
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Friend Shared Function GetContador(pEnum As enCont) As Integer
        Dim mReturn As Integer = 0


        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Contador_Clientes,0) As Contador_Clientes,"
        mStrSQL += "ISNULL(Contador_Fornecedores,0) As Contador_Fornecedores,"
        mStrSQL += "ISNULL(Contador_Medicos,0) As Contador_Medicos,"
        mStrSQL += "ISNULL(Contador_Utentes,0) As Contador_Utentes,"
        mStrSQL += "ISNULL(Contador_Rececionistas,0) As Contador_Rececionistas,"
        mStrSQL += "ISNULL(Contador_Administradores,0) As Contador_Administradores,"
        mStrSQL += "ISNULL(Contador_Produtos,0) As Contador_Produtos,"
        mStrSQL += "ISNULL(Contador_Servicos,0) As Contador_Servicos,"
        mStrSQL += "ISNULL(Contador_IVA,0) As Contador_IVA,"

        mStrSQL += "ISNULL(Contador_Especialidades,0) As Contador_Especialidades,"

        mStrSQL += "ISNULL(Contador_Tipos_Marcacao,0) As Contador_Tipos_Marcacao,"

        mStrSQL += "ISNULL(Contador_Tipos_Pagamento,0) As Contador_Tipos_Pagamento,"
        mStrSQL += "ISNULL(Contador_Doc,0) As Contador_Doc,"

        mStrSQL += "ISNULL(Contador_Operacoes,0) As Contador_Operacoes,"
        mStrSQL += "ISNULL(Contador_Exames,0) As Contador_Exames,"
        mStrSQL += "ISNULL(Contador_Consultas,0) As Contador_Consultas,"
        mStrSQL += "ISNULL(Contador_Salas,0) As Contador_Salas,"
        mStrSQL += "ISNULL(Contador_Series,0) As Contador_Series "
        mStrSQL += "FROM Empresas "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Empresa='1'"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then

            Select Case pEnum

                Case enCont.Clientes
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Clientes"))
                Case enCont.Fornecedores
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Fornecedores"))
                Case enCont.Medicos
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Medicos"))
                Case enCont.utentes
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Utentes"))
                Case enCont.Rececionistas
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Rececionistas"))
                Case enCont.Administradores
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Administradores"))
                Case enCont.Produtos
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Produtos"))
                Case enCont.Servicos
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Servicos"))
                Case enCont.IVA
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_IVA"))
                Case enCont.Especialidades
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Especialidades"))
                Case enCont.Tipos_Marcacao
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Tipos_Marcacao"))
                Case enCont.Tipos_Pagamento
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Tipos_Pagamento"))
                Case enCont.Operacoes
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Operacoes"))
                Case enCont.Exames
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Exames"))
                Case enCont.Consultas
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Consultas"))
                Case enCont.Doc
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Doc"))
                Case enCont.Salas
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Salas"))
                Case enCont.Series
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Series"))

            End Select

        End If
        mRDR.Close()
        mDB.Close()

        Return mReturn + 1
    End Function


    Friend Shared Function GravaAnoAtual(mAnoAtual As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pAnoAtual", mAnoAtual)

        mStrSQL = "UPDATE Empresas SET "
        mStrSQL += "Ano_Trabalho=@pAnoAtual "
        mStrSQL += "WHERE Cod_Empresa='1'"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("GravaAno:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn
    End Function
    ''' <summary>
    '''      Function GravaContador (ByVal pEnum as Encont) - Método para Gravar o Contador específico na Tabela Empresas
    '''      Gerado em 31/01/2024 10:35:36
    ''' </summary>
    ''' <returns>
    '''      True ou False
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Friend Shared Function GravaContador(pEnum As enCont) As Integer
        Dim mReturn As Boolean = True


        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mStrSQL = "UPDATE Empresas SET "
        Select Case pEnum
            Case enCont.Clientes
                mStrSQL += "Contador_Clientes= Contador_Clientes+1 "
            Case enCont.Fornecedores
                mStrSQL += "Contador_Fornecedores= Contador_Fornecedores+1 "
            Case enCont.Medicos
                mStrSQL += "Contador_Medicos= Contador_Medicos+1 "
            Case enCont.utentes
                mStrSQL += "Contador_Utentes= Contador_Utentes+1 "
            Case enCont.Rececionistas
                mStrSQL += "Contador_Utentes= Contador_Rececionistas+1 "
            Case enCont.Administradores
                mStrSQL += "Contador_Utentes= Contador_Administradores+1 "
            Case enCont.Produtos
                mStrSQL += "Contador_Produtos= Contador_Produtos+1 "
            Case enCont.Servicos
                mStrSQL += "Contador_Servicos= Contador_Servicos+1 "
            Case enCont.IVA
                mStrSQL += "Contador_IVA= Contador_IVA+1 "
            Case enCont.Especialidades
                mStrSQL += "Contador_Especialidades= Contador_Especialidades+1 "
            Case enCont.Tipos_Doc
                mStrSQL += "Contador_Tipos_Doc= Contador_Tipos_Doc+1 "
            Case enCont.Tipos_Marcacao
                mStrSQL += "Contador_Tipos_Marcacao= Contador_Tipos_Marcacao+1 "
            Case enCont.Tipos_Pagamento
                mStrSQL += "Contador_Tipos_Pagamento= Contador_Tipos_Pagamento+1 "
            Case enCont.Operacoes
                mStrSQL += "Contador_Operacoes= Contador_Operacoes+1 "
            Case enCont.Exames
                mStrSQL += "Contador_Exames= Contador_Exames+1 "
            Case enCont.Consultas
                mStrSQL += "Contador_Consultas= Contador_Consultas+1 "
            Case enCont.Doc
                mStrSQL += "Contador_Doc= Contador_Doc+1 "
            Case enCont.Salas
                mStrSQL += "Contador_Salas= Contador_Salas+1 "
            Case enCont.Series
                mStrSQL += "Contador_Series= Contador_Series+1 "
        End Select
        mStrSQL += "WHERE Cod_Empresa='1'"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("GravaContador:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn
    End Function


    ''' <summary>
    '''      Function GetEmpresas() Método para devolver a Lista de Empresas
    '''      Gerado em 31/01/2024 10:35:36
    ''' </summary>
    ''' <returns>
    '''      mListaEmpresas
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function GetEmpresas() As List(Of ClsEmpresas)
        Dim mListaEmpresas As New List(Of ClsEmpresas)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Empresa,'') As Cod_Empresa,"
        mStrSQL += "ISNULL(Nome,'') As Nome,"
        mStrSQL += "ISNULL(Endereco,'') As Endereco,"
        mStrSQL += "ISNULL(Pais,'PT') As Pais,"
        mStrSQL += "ISNULL(Cod_Postal,'') As Cod_Postal,"
        mStrSQL += "ISNULL(Localidade,'') As Localidade,"
        mStrSQL += "ISNULL(Email,'') As Email,"
        mStrSQL += "ISNULL(www,'paulo.luis.etla.pt') As www,"
        mStrSQL += "ISNULL(Num_Telefone,'') As Num_Telefone,"
        mStrSQL += "ISNULL(Num_Telemovel,'') As Num_Telemovel,"
        mStrSQL += "ISNULL(Capital_Social,'') As Capital_Social,"
        mStrSQL += "ISNULL(Registo_Comercial,'') As Registo_Comercial,"
        mStrSQL += "ISNULL(Matricula_CRC,'') As Matricula_CRC,"
        mStrSQL += "ISNULL(Data_Constituicao,0) As Data_Constituicao,"
        mStrSQL += "ISNULL(NIF,'') As NIF,"
        mStrSQL += "ISNULL(Contador_Clientes,0) As Contador_Clientes,"
        mStrSQL += "ISNULL(Contador_Fornecedores,0) As Contador_Fornecedores,"
        mStrSQL += "ISNULL(Contador_Empregados,0) As Contador_Empregados,"
        mStrSQL += "ISNULL(Contador_Medicos,0) As Contador_Medicos,"
        mStrSQL += "ISNULL(Contador_Utentes,0) As Contador_Utentes,"
        mStrSQL += "ISNULL(Contador_Rececionistas,0) As Contador_Rececionistas,"
        mStrSQL += "ISNULL(Contador_Administradores,0) As Contador_Administradores,"
        mStrSQL += "ISNULL(Contador_Produtos,0) As Contador_Produtos,"
        mStrSQL += "ISNULL(Contador_Servicos,0) As Contador_Servicos,"
        mStrSQL += "ISNULL(Contador_IVA,0) As Contador_IVA,"

        mStrSQL += "ISNULL(Contador_Especialidades,0) As Contador_Especialidades,"

        mStrSQL += "ISNULL(Contador_Tipos_Marcacao,0) As Contador_Tipos_Marcacao,"

        mStrSQL += "ISNULL(Contador_Tipos_Pagamento,0) As Contador_Tipos_Pagamento,"
        mStrSQL += "ISNULL(Contador_Operacoes,0) As Contador_Operacoes,"
        mStrSQL += "ISNULL(Contador_Exames,0) As Contador_Exames,"
        mStrSQL += "ISNULL(Contador_Consultas,0) As Contador_Consultas,"
        mStrSQL += "ISNULL(Contador_Doc,0) As Contador_Doc,"
        mStrSQL += "ISNULL(Contador_Salas,0) As Contador_Salas,"
        mStrSQL += "ISNULL(Contador_Series,0) As Contador_Series,"
        mStrSQL += "ISNULL(Ano_Trabalho,2016) As Ano_Trabalho,"
        mStrSQL += "ISNULL(Hora_Abertura,'') As Hora_Abertura,"
        mStrSQL += "ISNULL(Hora_Fecho,'') As Hora_Fecho,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo"
        mStrSQL += "FROM Empresas "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsEmpresas As New ClsEmpresas

            With mClsEmpresas
                .Cod_Empresa = mRDR.GetString(mRDR.GetOrdinal("Cod_Empresa"))
                .Nome = mRDR.GetString(mRDR.GetOrdinal("Nome"))
                .Endereco = mRDR.GetString(mRDR.GetOrdinal("Endereco"))
                .Pais = mRDR.GetString(mRDR.GetOrdinal("Pais"))
                .Cod_Postal = mRDR.GetString(mRDR.GetOrdinal("Cod_Postal"))
                .Localidade = mRDR.GetString(mRDR.GetOrdinal("Localidade"))
                .Email = mRDR.GetString(mRDR.GetOrdinal("Email"))
                .www = mRDR.GetString(mRDR.GetOrdinal("www"))
                .Num_Telefone = mRDR.GetString(mRDR.GetOrdinal("Num_Telefone"))
                .Num_Telemovel = mRDR.GetString(mRDR.GetOrdinal("Num_Telemovel"))
                .Capital_Social = mRDR.GetString(mRDR.GetOrdinal("Capital_Social"))
                .Registo_Comercial = mRDR.GetString(mRDR.GetOrdinal("Registo_Comercial"))
                .Matricula_CRC = mRDR.GetString(mRDR.GetOrdinal("Matricula_CRC"))
                .Data_Constituicao = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Constituicao"))
                .NIF = mRDR.GetString(mRDR.GetOrdinal("NIF"))
                .Contador_Clientes = mRDR.GetValue(mRDR.GetOrdinal("Contador_Clientes"))
                .Contador_Fornecedores = mRDR.GetValue(mRDR.GetOrdinal("Contador_Fornecedores"))
                .Contador_Medicos = mRDR.GetValue(mRDR.GetOrdinal("Contador_Medicos"))
                .Contador_Utentes = mRDR.GetValue(mRDR.GetOrdinal("Contador_Utentes"))
                .Contador_Rececionistas = mRDR.GetValue(mRDR.GetOrdinal("Contador_Rececionistas"))
                .Contador_Administradores = mRDR.GetValue(mRDR.GetOrdinal("Contador_Administradores"))
                .Contador_Produtos = mRDR.GetValue(mRDR.GetOrdinal("Contador_Produtos"))
                .Contador_Servicos = mRDR.GetValue(mRDR.GetOrdinal("Contador_Servicos"))
                .Contador_IVA = mRDR.GetValue(mRDR.GetOrdinal("Contador_IVA"))

                .Contador_Especialidades = mRDR.GetValue(mRDR.GetOrdinal("Contador_Especialidades"))

                .Contador_Tipos_Marcacao = mRDR.GetValue(mRDR.GetOrdinal("Contador_Tipos_Marcacao"))

                .Contador_Tipos_Pagamento = mRDR.GetValue(mRDR.GetOrdinal("Contador_Tipos_Pagamento"))
                .Contador_Operacoes = mRDR.GetValue(mRDR.GetOrdinal("Contador_Operacoes"))
                .Contador_Exames = mRDR.GetValue(mRDR.GetOrdinal("Contador_Exames"))
                .Contador_Consultas = mRDR.GetValue(mRDR.GetOrdinal("Contador_Consultas"))
                .Contador_Doc = mRDR.GetValue(mRDR.GetOrdinal("Contador_Doc"))
                .Contador_Salas = mRDR.GetValue(mRDR.GetOrdinal("Contador_Salas"))
                .Contador_Series = mRDR.GetValue(mRDR.GetOrdinal("Contador_Series"))
                .Ano_Trabalho = mRDR.GetString(mRDR.GetOrdinal("Ano_Trabalho"))
                .Hora_Abertura = mRDR.GetString(mRDR.GetOrdinal("Hora_Abertura"))
                .Hora_Fecho = mRDR.GetString(mRDR.GetOrdinal("Hora_Fecho"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaEmpresas.Add(mClsEmpresas)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaEmpresas
    End Function

    ''' <summary>
    '''      Function FiltrarEmpresas Método para Filtrar os campos da lista de Empresas
    '''      Gerado em 31/01/2024 10:35:36
    ''' </summary>
    ''' <returns>
    '''      mListaEmpresas
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function FiltrarEmpresas(ByVal pFiltro As ClsEmpresas) As List(Of ClsEmpresas)
        Dim mListaEmpresas As New List(Of ClsEmpresas)
        Dim mLista As New List(Of ClsEmpresas)

        mListaEmpresas = GetEmpresas()

        mLista = mListaEmpresas.FindAll(Function(x) _
        x.Cod_Empresa.Contains(pFiltro.Cod_Empresa)
        )
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Nome.Contains(pFiltro.Nome) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetEmpresasByCod(ByVal pCod_Empresa As String) Método para decolver uma Classe de Empresas
    '''      Gerado em 31/01/2024 10:35:36
    ''' </summary>
    ''' <returns>
    '''      mClsEmpresas
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function GetEmpresasByCod(ByVal pCod_Empresa As String) As ClsEmpresas
        Dim mClsEmpresas As New ClsEmpresas

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Empresa", pCod_Empresa)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Empresa,'') As Cod_Empresa,"
        mStrSQL += "ISNULL(Nome,'') As Nome,"
        mStrSQL += "ISNULL(Endereco,'') As Endereco,"
        mStrSQL += "ISNULL(Pais,'PT') As Pais,"
        mStrSQL += "ISNULL(Cod_Postal,'') As Cod_Postal,"
        mStrSQL += "ISNULL(Localidade,'') As Localidade,"
        mStrSQL += "ISNULL(Email,'') As Email,"
        mStrSQL += "ISNULL(www,'paulo.luis.etla.pt') As www,"
        mStrSQL += "ISNULL(Num_Telefone,'') As Num_Telefone,"
        mStrSQL += "ISNULL(Num_Telemovel,'') As Num_Telemovel,"
        mStrSQL += "ISNULL(Capital_Social,'') As Capital_Social,"
        mStrSQL += "ISNULL(Registo_Comercial,'') As Registo_Comercial,"
        mStrSQL += "ISNULL(Matricula_CRC,'') As Matricula_CRC,"
        mStrSQL += "ISNULL(Data_Constituicao,0) As Data_Constituicao,"
        mStrSQL += "ISNULL(NIF,'') As NIF,"
        mStrSQL += "ISNULL(Contador_Clientes,0) As Contador_Clientes,"
        mStrSQL += "ISNULL(Contador_Fornecedores,0) As Contador_Fornecedores,"
        mStrSQL += "ISNULL(Contador_Medicos,0) As Contador_Medicos,"
        mStrSQL += "ISNULL(Contador_Utentes,0) As Contador_Utentes,"
        mStrSQL += "ISNULL(Contador_Produtos,0) As Contador_Produtos,"
        mStrSQL += "ISNULL(Contador_Servicos,0) As Contador_Servicos,"
        mStrSQL += "ISNULL(Contador_IVA,0) As Contador_IVA,"

        mStrSQL += "ISNULL(Contador_Especialidades,0) As Contador_Especialidades,"

        mStrSQL += "ISNULL(Contador_Tipos_Marcacao,0) As Contador_Tipos_Marcacao,"

        mStrSQL += "ISNULL(Contador_Tipos_Pagamento,0) As Contador_Tipos_Pagamento,"
        mStrSQL += "ISNULL(Contador_Operacoes,0) As Contador_Operacoes,"
        mStrSQL += "ISNULL(Contador_Exames,0) As Contador_Exames,"
        mStrSQL += "ISNULL(Contador_Consultas,0) As Contador_Consultas,"
        mStrSQL += "ISNULL(Contador_Doc,0) As Contador_Doc,"
        mStrSQL += "ISNULL(Contador_Salas,0) As Contador_Salas,"
        mStrSQL += "ISNULL(Contador_Series,0) As Contador_Series,"
        mStrSQL += "ISNULL(Ano_Trabalho,2016) As Ano_Trabalho,"
        mStrSQL += "ISNULL(Hora_Abertura,'') As Hora_Abertura,"
        mStrSQL += "ISNULL(Hora_Fecho,'') As Hora_Fecho,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Empresas "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Empresa=@pCod_Empresa"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsEmpresas
                .Cod_Empresa = mRDR.GetString(mRDR.GetOrdinal("Cod_Empresa"))
                .Nome = mRDR.GetString(mRDR.GetOrdinal("Nome"))
                .Endereco = mRDR.GetString(mRDR.GetOrdinal("Endereco"))
                .Pais = mRDR.GetString(mRDR.GetOrdinal("Pais"))
                .Cod_Postal = mRDR.GetString(mRDR.GetOrdinal("Cod_Postal"))
                .Localidade = mRDR.GetString(mRDR.GetOrdinal("Localidade"))
                .Email = mRDR.GetString(mRDR.GetOrdinal("Email"))
                .www = mRDR.GetString(mRDR.GetOrdinal("www"))
                .Num_Telefone = mRDR.GetString(mRDR.GetOrdinal("Num_Telefone"))
                .Num_Telemovel = mRDR.GetString(mRDR.GetOrdinal("Num_Telemovel"))
                .Capital_Social = mRDR.GetString(mRDR.GetOrdinal("Capital_Social"))
                .Registo_Comercial = mRDR.GetString(mRDR.GetOrdinal("Registo_Comercial"))
                .Matricula_CRC = mRDR.GetString(mRDR.GetOrdinal("Matricula_CRC"))
                .Data_Constituicao = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Constituicao"))
                .NIF = mRDR.GetString(mRDR.GetOrdinal("NIF"))
                .Contador_Clientes = mRDR.GetValue(mRDR.GetOrdinal("Contador_Clientes"))
                .Contador_Fornecedores = mRDR.GetValue(mRDR.GetOrdinal("Contador_Fornecedores"))

                .Contador_Medicos = mRDR.GetValue(mRDR.GetOrdinal("Contador_Medicos"))
                .Contador_Utentes = mRDR.GetValue(mRDR.GetOrdinal("Contador_Utentes"))
                .Contador_Produtos = mRDR.GetValue(mRDR.GetOrdinal("Contador_Produtos"))
                .Contador_Servicos = mRDR.GetValue(mRDR.GetOrdinal("Contador_Servicos"))
                .Contador_IVA = mRDR.GetValue(mRDR.GetOrdinal("Contador_IVA"))

                .Contador_Especialidades = mRDR.GetValue(mRDR.GetOrdinal("Contador_Especialidades"))

                .Contador_Tipos_Marcacao = mRDR.GetValue(mRDR.GetOrdinal("Contador_Tipos_Marcacao"))

                .Contador_Tipos_Pagamento = mRDR.GetValue(mRDR.GetOrdinal("Contador_Tipos_Pagamento"))
                .Contador_Operacoes = mRDR.GetValue(mRDR.GetOrdinal("Contador_Operacoes"))
                .Contador_Exames = mRDR.GetValue(mRDR.GetOrdinal("Contador_Exames"))
                .Contador_Consultas = mRDR.GetValue(mRDR.GetOrdinal("Contador_Consultas"))
                .Contador_Doc = mRDR.GetValue(mRDR.GetOrdinal("Contador_Doc"))
                .Contador_Salas = mRDR.GetValue(mRDR.GetOrdinal("Contador_Salas"))
                .Contador_Series = mRDR.GetValue(mRDR.GetOrdinal("Contador_Series"))
                .Ano_Trabalho = mRDR.GetString(mRDR.GetOrdinal("Ano_Trabalho"))
                .Hora_Abertura = mRDR.GetString(mRDR.GetOrdinal("Hora_Abertura"))
                .Hora_Fecho = mRDR.GetString(mRDR.GetOrdinal("Hora_Fecho"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsEmpresas
    End Function


    ''' <summary>
    '''      Function ModificaEmpresas(ByVal pClsEmpresas As ClsEmpresas) Método para Modificar a TABELA Empresas
    '''      Gerado em 31/01/2024 10:35:36
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function ModificaEmpresas(ByVal pClsEmpresas As ClsEmpresas) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Empresa", pClsEmpresas.Cod_Empresa.Substring(0, IIf(Len(pClsEmpresas.Cod_Empresa) > 1, 1, Len(pClsEmpresas.Cod_Empresa))))
        mCMD.Parameters.AddWithValue("@pNome", pClsEmpresas.Nome.Substring(0, IIf(Len(pClsEmpresas.Nome) > 50, 50, Len(pClsEmpresas.Nome))))
        mCMD.Parameters.AddWithValue("@pEndereco", pClsEmpresas.Endereco.Substring(0, IIf(Len(pClsEmpresas.Endereco) > 50, 50, Len(pClsEmpresas.Endereco))))
        mCMD.Parameters.AddWithValue("@pPais", pClsEmpresas.Pais.Substring(0, IIf(Len(pClsEmpresas.Pais) > 30, 30, Len(pClsEmpresas.Pais))))
        mCMD.Parameters.AddWithValue("@pCod_Postal", pClsEmpresas.Cod_Postal.Substring(0, IIf(Len(pClsEmpresas.Cod_Postal) > 8, 8, Len(pClsEmpresas.Cod_Postal))))
        mCMD.Parameters.AddWithValue("@pLocalidade", pClsEmpresas.Localidade.Substring(0, IIf(Len(pClsEmpresas.Localidade) > 50, 50, Len(pClsEmpresas.Localidade))))
        mCMD.Parameters.AddWithValue("@pEmail", pClsEmpresas.Email.Substring(0, IIf(Len(pClsEmpresas.Email) > 50, 50, Len(pClsEmpresas.Email))))
        mCMD.Parameters.AddWithValue("@pwww", pClsEmpresas.www.Substring(0, IIf(Len(pClsEmpresas.www) > 50, 50, Len(pClsEmpresas.www))))
        mCMD.Parameters.AddWithValue("@pNum_Telefone", pClsEmpresas.Num_Telefone.Substring(0, IIf(Len(pClsEmpresas.Num_Telefone) > 9, 9, Len(pClsEmpresas.Num_Telefone))))
        mCMD.Parameters.AddWithValue("@pNum_Telemovel", pClsEmpresas.Num_Telemovel.Substring(0, IIf(Len(pClsEmpresas.Num_Telemovel) > 9, 9, Len(pClsEmpresas.Num_Telemovel))))
        mCMD.Parameters.AddWithValue("@pCapital_Social", pClsEmpresas.Capital_Social.Substring(0, IIf(Len(pClsEmpresas.Capital_Social) > 14, 14, Len(pClsEmpresas.Capital_Social))))
        mCMD.Parameters.AddWithValue("@pRegisto_Comercial", pClsEmpresas.Registo_Comercial.Substring(0, IIf(Len(pClsEmpresas.Registo_Comercial) > 30, 30, Len(pClsEmpresas.Registo_Comercial))))
        mCMD.Parameters.AddWithValue("@pMatricula_CRC", pClsEmpresas.Matricula_CRC.Substring(0, IIf(Len(pClsEmpresas.Matricula_CRC) > 20, 20, Len(pClsEmpresas.Matricula_CRC))))
        mCMD.Parameters.AddWithValue("@pData_Constituicao", pClsEmpresas.Data_Constituicao)
        mCMD.Parameters.AddWithValue("@pNIF", pClsEmpresas.NIF.Substring(0, IIf(Len(pClsEmpresas.NIF) > 9, 9, Len(pClsEmpresas.NIF))))
        mCMD.Parameters.AddWithValue("@pContador_Clientes", pClsEmpresas.Contador_Clientes)
        mCMD.Parameters.AddWithValue("@pContador_Fornecedores", pClsEmpresas.Contador_Fornecedores)

        mCMD.Parameters.AddWithValue("@pContador_Medicos", pClsEmpresas.Contador_Medicos)
        mCMD.Parameters.AddWithValue("@pContador_Utentes", pClsEmpresas.Contador_Utentes)
        mCMD.Parameters.AddWithValue("@pContador_Produtos", pClsEmpresas.Contador_Produtos)
        mCMD.Parameters.AddWithValue("@pContador_Servicos", pClsEmpresas.Contador_Servicos)
        mCMD.Parameters.AddWithValue("@pContador_IVA", pClsEmpresas.Contador_IVA)

        mCMD.Parameters.AddWithValue("@pContador_Especialidades", pClsEmpresas.Contador_Especialidades)

        mCMD.Parameters.AddWithValue("@pContador_Tipos_Marcacao", pClsEmpresas.Contador_Tipos_Marcacao)

        mCMD.Parameters.AddWithValue("@pContador_Tipos_Pagamento", pClsEmpresas.Contador_Tipos_Pagamento)
        mCMD.Parameters.AddWithValue("@pContador_Operacoes", pClsEmpresas.Contador_Operacoes)
        mCMD.Parameters.AddWithValue("@pContador_Exames", pClsEmpresas.Contador_Exames)
        mCMD.Parameters.AddWithValue("@pContador_Consultas", pClsEmpresas.Contador_Consultas)
        mCMD.Parameters.AddWithValue("@pContador_Doc", pClsEmpresas.Contador_Doc)
        mCMD.Parameters.AddWithValue("@pContador_Salas", pClsEmpresas.Contador_Salas)
        mCMD.Parameters.AddWithValue("@pContador_Series", pClsEmpresas.Contador_Series)
        mCMD.Parameters.AddWithValue("@pAno_Trabalho", pClsEmpresas.Ano_Trabalho.Substring(0, IIf(Len(pClsEmpresas.Ano_Trabalho) > 4, 4, Len(pClsEmpresas.Ano_Trabalho))))
        mCMD.Parameters.AddWithValue("@pHora_Abertura", pClsEmpresas.Hora_Abertura.Substring(0, IIf(Len(pClsEmpresas.Hora_Abertura) > 5, 5, Len(pClsEmpresas.Hora_Abertura))))
        mCMD.Parameters.AddWithValue("@pHora_Fecho", pClsEmpresas.Hora_Fecho.Substring(0, IIf(Len(pClsEmpresas.Hora_Fecho) > 5, 5, Len(pClsEmpresas.Hora_Fecho))))


        mStrSQL = "UPDATE Empresas SET "
        mStrSQL += "Nome=@pNome,"
        mStrSQL += "Endereco=@pEndereco,"
        mStrSQL += "Pais=@pPais,"
        mStrSQL += "Cod_Postal=@pCod_Postal,"
        mStrSQL += "Localidade=@pLocalidade,"
        mStrSQL += "Email=@pEmail,"
        mStrSQL += "www=@pwww,"
        mStrSQL += "Num_Telefone=@pNum_Telefone,"
        mStrSQL += "Num_Telemovel=@pNum_Telemovel,"
        mStrSQL += "Capital_Social=@pCapital_Social,"
        mStrSQL += "Registo_Comercial=@pRegisto_Comercial,"
        mStrSQL += "Matricula_CRC=@pMatricula_CRC,"
        mStrSQL += "Data_Constituicao=@pData_Constituicao,"
        mStrSQL += "NIF=@pNIF,"
        mStrSQL += "Contador_Clientes=@pContador_Clientes,"
        mStrSQL += "Contador_Fornecedores=@pContador_Fornecedores,"
        mStrSQL += "Contador_Empregados=@pContador_Empregados,"
        mStrSQL += "Contador_Medicos=@pContador_Medicos,"
        mStrSQL += "Contador_Utentes=@pContador_Utentes,"
        mStrSQL += "Contador_Produtos=@pContador_Produtos,"
        mStrSQL += "Contador_Servicos=@pContador_Servicos,"
        mStrSQL += "Contador_IVA=@pContador_IVA,"

        mStrSQL += "Contador_Especialidades=@pContador_Especialidades,"

        mStrSQL += "Contador_Tipos_Marcacao=@pContador_Tipos_Marcacao,"

        mStrSQL += "Contador_Tipos_Pagamento=@pContador_Tipos_Pagamento,"
        mStrSQL += "Contador_Operacoes=@pContador_Operacoes,"
        mStrSQL += "Contador_Exames=@pContador_Exames,"
        mStrSQL += "Contador_Consultas=@pContador_Consultas,"
        mStrSQL += "Contador_Doc=@pContador_Doc,"
        mStrSQL += "Contador_Salas=@pContador_Salas,"
        mStrSQL += "Contador_Series=@pContador_Series,"
        mStrSQL += "Ano_Trabalho=@pAno_Trabalho,"
        mStrSQL += "Hora_Abertura=@pHora_Abertura,"
        mStrSQL += "Hora_Fecho=@pHora_Fecho "
        mStrSQL += "WHERE Cod_Empresa=@pCod_Empresa"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaEmpresas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaEmpresas(ByVal pNovoEmpresas As ClsEmpresas) Método para Gravar a TABELA Empresas
    '''      Gerado em 31/01/2024 10:35:36
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function GravaEmpresas(ByVal pNovoEmpresas As ClsEmpresas) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Empresa", pNovoEmpresas.Cod_Empresa.Substring(0, IIf(Len(pNovoEmpresas.Cod_Empresa) > 1, 1, Len(pNovoEmpresas.Cod_Empresa))))
        mCMD.Parameters.AddWithValue("@pNome", pNovoEmpresas.Nome.Substring(0, IIf(Len(pNovoEmpresas.Nome) > 50, 50, Len(pNovoEmpresas.Nome))))
        mCMD.Parameters.AddWithValue("@pEndereco", pNovoEmpresas.Endereco.Substring(0, IIf(Len(pNovoEmpresas.Endereco) > 50, 50, Len(pNovoEmpresas.Endereco))))
        mCMD.Parameters.AddWithValue("@pPais", pNovoEmpresas.Pais.Substring(0, IIf(Len(pNovoEmpresas.Pais) > 30, 30, Len(pNovoEmpresas.Pais))))
        mCMD.Parameters.AddWithValue("@pCod_Postal", pNovoEmpresas.Cod_Postal.Substring(0, IIf(Len(pNovoEmpresas.Cod_Postal) > 8, 8, Len(pNovoEmpresas.Cod_Postal))))
        mCMD.Parameters.AddWithValue("@pLocalidade", pNovoEmpresas.Localidade.Substring(0, IIf(Len(pNovoEmpresas.Localidade) > 50, 50, Len(pNovoEmpresas.Localidade))))
        mCMD.Parameters.AddWithValue("@pEmail", pNovoEmpresas.Email.Substring(0, IIf(Len(pNovoEmpresas.Email) > 50, 50, Len(pNovoEmpresas.Email))))
        mCMD.Parameters.AddWithValue("@pwww", pNovoEmpresas.www.Substring(0, IIf(Len(pNovoEmpresas.www) > 50, 50, Len(pNovoEmpresas.www))))
        mCMD.Parameters.AddWithValue("@pNum_Telefone", pNovoEmpresas.Num_Telefone.Substring(0, IIf(Len(pNovoEmpresas.Num_Telefone) > 9, 9, Len(pNovoEmpresas.Num_Telefone))))
        mCMD.Parameters.AddWithValue("@pNum_Telemovel", pNovoEmpresas.Num_Telemovel.Substring(0, IIf(Len(pNovoEmpresas.Num_Telemovel) > 9, 9, Len(pNovoEmpresas.Num_Telemovel))))
        mCMD.Parameters.AddWithValue("@pCapital_Social", pNovoEmpresas.Capital_Social.Substring(0, IIf(Len(pNovoEmpresas.Capital_Social) > 14, 14, Len(pNovoEmpresas.Capital_Social))))
        mCMD.Parameters.AddWithValue("@pRegisto_Comercial", pNovoEmpresas.Registo_Comercial.Substring(0, IIf(Len(pNovoEmpresas.Registo_Comercial) > 30, 30, Len(pNovoEmpresas.Registo_Comercial))))
        mCMD.Parameters.AddWithValue("@pMatricula_CRC", pNovoEmpresas.Matricula_CRC.Substring(0, IIf(Len(pNovoEmpresas.Matricula_CRC) > 20, 20, Len(pNovoEmpresas.Matricula_CRC))))
        mCMD.Parameters.AddWithValue("@pData_Constituicao", pNovoEmpresas.Data_Constituicao)
        mCMD.Parameters.AddWithValue("@pNIF", pNovoEmpresas.NIF.Substring(0, IIf(Len(pNovoEmpresas.NIF) > 9, 9, Len(pNovoEmpresas.NIF))))
        mCMD.Parameters.AddWithValue("@pContador_Clientes", pNovoEmpresas.Contador_Clientes)
        mCMD.Parameters.AddWithValue("@pContador_Fornecedores", pNovoEmpresas.Contador_Fornecedores)
        mCMD.Parameters.AddWithValue("@pContador_Medicos", pNovoEmpresas.Contador_Medicos)
        mCMD.Parameters.AddWithValue("@pContador_Utentes", pNovoEmpresas.Contador_Utentes)
        mCMD.Parameters.AddWithValue("@pContador_Produtos", pNovoEmpresas.Contador_Produtos)
        mCMD.Parameters.AddWithValue("@pContador_Servicos", pNovoEmpresas.Contador_Servicos)
        mCMD.Parameters.AddWithValue("@pContador_IVA", pNovoEmpresas.Contador_IVA)

        mCMD.Parameters.AddWithValue("@pContador_Especialidades", pNovoEmpresas.Contador_Especialidades)

        mCMD.Parameters.AddWithValue("@pContador_Tipos_Marcacao", pNovoEmpresas.Contador_Tipos_Marcacao)

        mCMD.Parameters.AddWithValue("@pContador_Tipos_Pagamento", pNovoEmpresas.Contador_Tipos_Pagamento)
        mCMD.Parameters.AddWithValue("@pContador_Operacoes", pNovoEmpresas.Contador_Operacoes)
        mCMD.Parameters.AddWithValue("@pContador_Exames", pNovoEmpresas.Contador_Exames)
        mCMD.Parameters.AddWithValue("@pContador_Consultas", pNovoEmpresas.Contador_Consultas)
        mCMD.Parameters.AddWithValue("@pContador_Doc", pNovoEmpresas.Contador_Doc)
        mCMD.Parameters.AddWithValue("@pContador_Salas", pNovoEmpresas.Contador_Salas)
        mCMD.Parameters.AddWithValue("@pContador_Series", pNovoEmpresas.Contador_Series)
        mCMD.Parameters.AddWithValue("@pAno_Trabalho", pNovoEmpresas.Ano_Trabalho.Substring(0, IIf(Len(pNovoEmpresas.Ano_Trabalho) > 4, 4, Len(pNovoEmpresas.Ano_Trabalho))))
        mCMD.Parameters.AddWithValue("@pHora_Abertura", pNovoEmpresas.Hora_Abertura.Substring(0, IIf(Len(pNovoEmpresas.Hora_Abertura) > 5, 5, Len(pNovoEmpresas.Hora_Abertura))))
        mCMD.Parameters.AddWithValue("@pHora_Fecho", pNovoEmpresas.Hora_Fecho.Substring(0, IIf(Len(pNovoEmpresas.Hora_Fecho) > 5, 5, Len(pNovoEmpresas.Hora_Fecho))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoEmpresas.FLG_Ativo)


        mStrSQL = "INSERT INTO Empresas "
        mStrSQL += "("
        mStrSQL += "Cod_Empresa,"
        mStrSQL += "Nome,"
        mStrSQL += "Endereco,"
        mStrSQL += "Pais,"
        mStrSQL += "Cod_Postal,"
        mStrSQL += "Localidade,"
        mStrSQL += "Email,"
        mStrSQL += "www,"
        mStrSQL += "Num_Telefone,"
        mStrSQL += "Num_Telemovel,"
        mStrSQL += "Capital_Social,"
        mStrSQL += "Registo_Comercial,"
        mStrSQL += "Matricula_CRC,"
        mStrSQL += "Data_Constituicao,"
        mStrSQL += "NIF,"
        mStrSQL += "Contador_Clientes,"
        mStrSQL += "Contador_Fornecedores,"
        mStrSQL += "Contador_Empregados,"
        mStrSQL += "Contador_Medicos,"
        mStrSQL += "Contador_Utentes,"
        mStrSQL += "Contador_Produtos,"
        mStrSQL += "Contador_Servicos,"
        mStrSQL += "Contador_IVA,"

        mStrSQL += "Contador_Especialidades,"

        mStrSQL += "Contador_Tipos_Marcacao,"

        mStrSQL += "Contador_Tipos_Pagamento,"
        mStrSQL += "Contador_Operacoes,"
        mStrSQL += "Contador_Exames,"
        mStrSQL += "Contador_Consultas,"
        mStrSQL += "Contador_Doc,"
        mStrSQL += "Contador_Salas,"
        mStrSQL += "Contador_Series,"
        mStrSQL += "Ano_Trabalho,"
        mStrSQL += "Hora_Abertura,"
        mStrSQL += "Hora_Fecho,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Empresa,"
        mStrSQL += "@pNome,"
        mStrSQL += "@pEndereco,"
        mStrSQL += "@pPais,"
        mStrSQL += "@pCod_Postal,"
        mStrSQL += "@pLocalidade,"
        mStrSQL += "@pEmail,"
        mStrSQL += "@pwww,"
        mStrSQL += "@pNum_Telefone,"
        mStrSQL += "@pNum_Telemovel,"
        mStrSQL += "@pCapital_Social,"
        mStrSQL += "@pRegisto_Comercial,"
        mStrSQL += "@pMatricula_CRC,"
        mStrSQL += "@pData_Constituicao,"
        mStrSQL += "@pNIF,"
        mStrSQL += "@pContador_Clientes,"
        mStrSQL += "@pContador_Fornecedores,"
        mStrSQL += "@pContador_Empregados,"
        mStrSQL += "@pContador_Medicos,"
        mStrSQL += "@pContador_Utentes,"
        mStrSQL += "@pContador_Produtos,"
        mStrSQL += "@pContador_Servicos,"
        mStrSQL += "@pContador_IVA,"

        mStrSQL += "@pContador_Especialidades,"

        mStrSQL += "@pContador_Tipos_Marcacao,"

        mStrSQL += "@pContador_Tipos_Pagamento,"
        mStrSQL += "@pContador_Operacoes,"
        mStrSQL += "@pContador_Exames,"
        mStrSQL += "@pContador_Consultas,"
        mStrSQL += "@pContador_Doc,"
        mStrSQL += "@pContador_Salas,"
        mStrSQL += "@pContador_Series,"
        mStrSQL += "@pAno_Trabalho,"
        mStrSQL += "@pHora_Abertura,"
        mStrSQL += "@pHora_Fecho,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Empresas)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaEmpresas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaEmpresas(ByVal pCod_Empresa As String) Método para Apagar um Registo da Tabela Empresas
    '''      Gerado em 31/01/2024 10:35:36
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function ApagaEmpresas(ByVal pCod_Empresa As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Empresa", pCod_Empresa)


        mStrSQL = "UPDATE Empresas SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Empresa=@pCod_Empresa"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaEmpresas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe EmpresasComparer 
'''      Gerado em 31/01/2024 10:35:36
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class EmpresasComparer
    Implements IEqualityComparer(Of ClsEmpresas)

    Public Function Equals1(ByVal x As ClsEmpresas, ByVal y As ClsEmpresas) As Boolean Implements IEqualityComparer(Of ClsEmpresas).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Empresa = y.Cod_Empresa) ' AndAlso (x.Nome = y.Nome)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsEmpresas) As Integer Implements IEqualityComparer(Of ClsEmpresas).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsEmpresas_Nome = pCls.Nome.GetHashCode()
        Dim Hash_ClsEmpresas_Cod_Empresa = pCls.Cod_Empresa.GetHashCode()

        Return Hash_ClsEmpresas_Cod_Empresa 'Xor Hash_ClsEmpresas_Nome
    End Function
End Class
