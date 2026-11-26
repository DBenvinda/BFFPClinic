Public Class frmListaEnderecos

    Dim mListaEnderecos As New List(Of ClsEnderecos)
    Private Sub btnVolta_Entidades_Click(sender As Object, e As EventArgs) Handles btnVolta_Entidades.Click
        Close()
    End Sub

    Private Sub Lista_EnderecosUltraGrid_Click(sender As Object, e As EventArgs) Handles Lista_EnderecosUltraGrid.DoubleClick
        frmEnderecos.Visible = True
        ' frmMain.Load_Menu(enMenu.Enderecos)
    End Sub

    Private Sub frmListaEnderecos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'I21_G2DataSet2.Enderecos' table. You can move, or remove it, as needed.
        Lista_EnderecosUltraGrid.DataSource = mListaEnderecos
        Lista_EnderecosUltraGrid.Refresh()

    End Sub
End Class