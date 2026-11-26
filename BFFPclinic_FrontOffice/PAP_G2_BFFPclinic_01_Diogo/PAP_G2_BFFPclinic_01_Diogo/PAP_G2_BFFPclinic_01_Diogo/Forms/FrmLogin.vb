Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraRichEdit.Import.OpenXml

Public Class FrmLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    'Public Utilizador As String


    Public Sub BtnEntrar_click(sender As Object, e As EventArgs) Handles BtnEntrar.Click
        entrar()
    End Sub

    Sub entrar()
        Dim Pass As String = PasswordTextBox.Text
        Dim user As String = UsernameTextBox.Text
        Try

            If UsernameTextBox.Text <> "" And PasswordTextBox.Text <> "" Then
                If ClsEntidades.TestaEntidadesbyuser(user, Pass) Then
                    'Dim frm1 As New frmMain()
                    'User = UsernameTextBox.Text
                    frmMain.Show()
                    frmMain.Utilizador = user
                    frmMain.preenche_Utilizador()
                    Me.Hide()
                Else
                    MsgBox("Utilizador ou Palavra_Passe incorreto, Tente Novamente")
                    PasswordTextBox.Text = ""
                    PasswordTextBox.Focus()
                End If
            Else
                MsgBox("Tente Novamente")

                UsernameTextBox.Focus()
            End If
        Catch ex As Exception
            MsgBox("Utilizador ou Palavra_Passe incorreto, Tente Novamente")
            UsernameTextBox.Focus()
            PasswordTextBox.Text = ""
            UsernameTextBox.Text = ""
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        frmMain.Close()
    End Sub

    Private Sub FrmLogin_Load() Handles MyBase.Load
        BtnEntrar.FlatAppearance.BorderSize = 0
        PasswordTextBox.UseSystemPasswordChar = True
    End Sub
    Private Sub OlhoA_PictureBox_Click(sender As Object, e As EventArgs) Handles OlhoA_PictureBox.Click
        If OlhoA_PictureBox.Tag = 1 Then
            PasswordTextBox.UseSystemPasswordChar = True
            OlhoA_PictureBox.Tag = 0
            OlhoA_PictureBox.Image = My.Resources.OlhoA
        Else
            PasswordTextBox.UseSystemPasswordChar = False
            OlhoA_PictureBox.Tag = 1
            OlhoA_PictureBox.Image = My.Resources.OlhoF
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            entrar()
        End If
    End Sub

    Private Sub FrmLogin_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub
End Class
