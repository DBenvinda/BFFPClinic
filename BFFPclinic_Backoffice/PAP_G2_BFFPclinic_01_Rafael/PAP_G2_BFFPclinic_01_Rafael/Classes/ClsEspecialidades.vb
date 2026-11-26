
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsEspecialidades Classe da Tabela Especialidades
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class ClsEspecialidades


' -----------------------------------------
' Property's da tabela Especialidades
' -----------------------------------------

Public Property Cod_Especialidade As String                             ' Len:  5 - SQL_Type: nvarchar
    Public Property Designacao As String                                    ' Len: 30 - SQL_Type: nvarchar

    Public Property FLG_Exames As Boolean

    Public Property FLG_Operacoes As Boolean

    Public Property FLG_Consultas As Boolean

    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
End Sub


Friend Shared Function GetNovoCodigo() As String

        Return "ES" & ClsEmpresas.GetContador(enCont.Especialidades).ToString("000") ' <-------------- VERIFICAR O Nº de ZEROS

    End Function


''' <summary>
'''      Function GetEspecialidades() Método para devolver a Lista de Especialidades
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <returns>
'''      mListaEspecialidades
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function GetEspecialidades() As List(Of clsEspecialidades)
Dim mListaEspecialidades As new List(Of clsEspecialidades)

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand
Dim mRDR As SqlDataReader

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()

mStrSQL="SELECT "
mStrSQL+="ISNULL(Cod_Especialidade,'') As Cod_Especialidade,"
mStrSQL+="ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo,"
        mStrSQL += "ISNULL(FLG_Exames,1) As FLG_Exames,"
        mStrSQL += "ISNULL(FLG_Operações,1) As FLG_Operações,"
        mStrSQL += "ISNULL(FLG_Consultas,1) As FLG_Consultas "
        mStrSQL += "FROM Especialidades "
        mStrSQL +="WHERE FLG_Ativo=1"


mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

mRDR = mCMD.ExecuteReader

While mRDR.Read()

Dim mClsEspecialidades As New ClsEspecialidades

With mClsEspecialidades
.Cod_Especialidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Especialidade"))
.Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
                .FLG_Exames = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Exames"))
                .FLG_Operacoes = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Operações"))
                .FLG_Consultas = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Consultas"))
            End With


mListaEspecialidades.add(mClsEspecialidades)

End While

mRDR.Close()
mDB.Close()

Return mListaEspecialidades
End Function 

''' <summary>
'''      Function FiltrarEspecialidades Método para Filtrar os campos da lista de Especialidades
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <returns>
'''      mListaEspecialidades
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function FiltrarEspecialidades(ByVal pFiltro As ClsEspecialidades) As List(Of clsEspecialidades)
Dim mListaEspecialidades As new List(Of clsEspecialidades)
Dim mLista As new List(Of clsEspecialidades)

mListaEspecialidades = GetEspecialidades()

mLista = mListaEspecialidades.FindAll(Function(x) _
x.Cod_Especialidade.Contains(pFiltro.Cod_Especialidade) 
)
'-----------------------------------------------------
'Pode Colocar em cima mais colunas como esta abaixo...
'-----------------------------------------------------
 ' AND x.Designacao.Contains(pFiltro.Designacao) 

Return mLista
End Function 


''' <summary>
'''      Function GetEspecialidadesByCod(ByVal pCod_Especialidade As String) Método para decolver uma Classe de Especialidades
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <returns>
'''      mClsEspecialidades
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function GetEspecialidadesByCod(ByVal pCod_Especialidade As String) As clsEspecialidades
Dim mClsEspecialidades As new clsEspecialidades

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand
Dim mRDR As SqlDataReader

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()
mCMD.Parameters.AddWithValue("@pCod_Especialidade",pCod_Especialidade)


mStrSQL="SELECT "
mStrSQL+="ISNULL(Cod_Especialidade,'') As Cod_Especialidade,"
mStrSQL+="ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo,"
        mStrSQL += "ISNULL(FLG_Exames,1) As FLG_Exames,"
        mStrSQL += "ISNULL(FLG_Operações,1) As FLG_Operações,"
        mStrSQL += "ISNULL(FLG_Consultas,1) As FLG_Consultas "
        mStrSQL +="FROM Especialidades "
mStrSQL+="WHERE FLG_Ativo=1 "
mStrSQL+="AND Cod_Especialidade=@pCod_Especialidade"


mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

mRDR = mCMD.ExecuteReader

IF mRDR.Read() Then


With mClsEspecialidades
.Cod_Especialidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Especialidade"))
.Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
                .FLG_Exames = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Exames"))
                .FLG_Operacoes = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Operações"))
                .FLG_Consultas = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Consultas"))
            End With


End IF
mRDR.Close()
mDB.Close()

Return mClsEspecialidades
End Function 


''' <summary>
'''      Function ModificaEspecialidades(ByVal pClsEspecialidades As ClsEspecialidades) Método para Modificar a TABELA Especialidades
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <returns>
'''      Boolean
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function ModificaEspecialidades(ByVal pClsEspecialidades As ClsEspecialidades) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mCMD.Parameters.Clear()
mCMD.Parameters.AddWithValue("@pCod_Especialidade",pClsEspecialidades.Cod_Especialidade.Substring(0,IIf(Len(pClsEspecialidades.Cod_Especialidade)> 5, 5,Len(pClsEspecialidades.Cod_Especialidade))))
mCMD.Parameters.AddWithValue("@pDesignacao",pClsEspecialidades.Designacao.Substring(0,IIf(Len(pClsEspecialidades.Designacao)> 30, 30,Len(pClsEspecialidades.Designacao))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pClsEspecialidades.FLG_Ativo)
        mCMD.Parameters.AddWithValue("@pFLG_Exames", pClsEspecialidades.FLG_Exames)
        mCMD.Parameters.AddWithValue("@pFLG_Operações", pClsEspecialidades.FLG_Operacoes)
        mCMD.Parameters.AddWithValue("@pFLG_Consultas", pClsEspecialidades.FLG_Consultas)

        mStrSQL ="UPDATE Especialidades SET "
        mStrSQL += "Designacao=@pDesignacao,"
        mStrSQL += "FLG_Exames=@pFLG_Exames,"
        mStrSQL += "FLG_Operações=@pFLG_Operações,"
        mStrSQL += "FLG_Consultas=@pFLG_Consultas "
        mStrSQL +="WHERE Cod_Especialidade=@pCod_Especialidade"


mDB.ConnectionString = My.Settings.Connection
mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
Catch ex As Exception
Msgbox("ModificaEspecialidades:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 


''' <summary>
'''      Function GravaEspecialidades(ByVal pNovoEspecialidades As ClsEspecialidades) Método para Gravar a TABELA Especialidades
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <returns>
'''      Boolean
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function GravaEspecialidades(ByVal pNovoEspecialidades As ClsEspecialidades) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()


mCMD.Parameters.AddWithValue("@pCod_Especialidade",pNovoEspecialidades.Cod_Especialidade.Substring(0,IIf(Len(pNovoEspecialidades.Cod_Especialidade)> 5, 5,Len(pNovoEspecialidades.Cod_Especialidade))))
mCMD.Parameters.AddWithValue("@pDesignacao",pNovoEspecialidades.Designacao.Substring(0,IIf(Len(pNovoEspecialidades.Designacao)> 30, 30,Len(pNovoEspecialidades.Designacao))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoEspecialidades.FLG_Ativo)
        mCMD.Parameters.AddWithValue("@pFLG_Exames", pNovoEspecialidades.FLG_Exames)
        mCMD.Parameters.AddWithValue("@pFLG_Operações", pNovoEspecialidades.FLG_Operacoes)
        mCMD.Parameters.AddWithValue("@pFLG_Consultas", pNovoEspecialidades.FLG_Consultas)


        mStrSQL ="INSERT INTO Especialidades "
mStrSQL+="("
mStrSQL+="Cod_Especialidade,"
mStrSQL+="Designacao,"
        mStrSQL += "FLG_Ativo,"
        mStrSQL += "FLG_Exames,"
        mStrSQL += "FLG_Operações,"
        mStrSQL += "FLG_Consultas "
        mStrSQL +=") "
mStrSQL+="VALUES "
mStrSQL+="("
mStrSQL+="@pCod_Especialidade,"
        mStrSQL += "@pDesignacao,"
        mStrSQL += "@pFLG_Exames,"
        mStrSQL += "@pFLG_Operações,"
        mStrSQL += "@pFLG_Consultas "

        mStrSQL +="1"
mStrSQL+=")"


mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
ClsEmpresas.GravaContador(enCont.Especialidades)
Catch ex As Exception
Msgbox("GravaEspecialidades:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 


''' <summary>
'''      Function ApagaEspecialidades(ByVal pCod_Especialidade As String) Método para Apagar um Registo da Tabela Especialidades
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <returns>
'''      Boolean
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Shared Function ApagaEspecialidades(ByVal pCod_Especialidade As String) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mCMD.Parameters.Clear()

mCMD.Parameters.AddWithValue("@pCod_Especialidade", pCod_Especialidade)


mStrSQL="UPDATE Especialidades SET "
        mStrSQL += "FLG_Ativo=0,"
        mStrSQL += "FLG_Exames=0,"
        mStrSQL += "FLG_Operações=0,"
        mStrSQL += "FLG_Consultas=0 "
        mStrSQL +="WHERE Cod_Especialidade=@pCod_Especialidade"


mDB.ConnectionString = My.Settings.Connection
mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
Catch ex As Exception
Msgbox("ApagaEspecialidades:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 
End Class



''' <summary>
'''      Classe EspecialidadesComparer 
'''      Gerado em 31/01/2024 10:35:37
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class EspecialidadesComparer 
Implements IEqualityComparer(Of clsEspecialidades)

Public Function Equals1(ByVal x As clsEspecialidades, ByVal y As clsEspecialidades) As Boolean Implements IEqualityComparer(Of clsEspecialidades).Equals

If x Is y Then Return True

If x Is Nothing OrElse y Is Nothing Then Return False

Return (x.Cod_Especialidade = y.Cod_Especialidade) ' AndAlso (x.Designacao = y.Designacao)
End Function

Public Function GetHashCode1(ByVal pCls As clsEspecialidades) As Integer Implements IEqualityComparer(Of clsEspecialidades).GetHashCode

If pCls Is Nothing Then Return 0

'Dim Hash_ClsEspecialidades_Designacao = pCls.Designacao.GetHashCode()
Dim Hash_ClsEspecialidades_Cod_Especialidade = pCls.Cod_Especialidade.GetHashCode()

Return Hash_ClsEspecialidades_Cod_Especialidade 'Xor Hash_ClsEspecialidades_Designacao
End Function
End Class
