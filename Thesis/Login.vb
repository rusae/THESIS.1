Imports MySql.Data.MySqlClient


Public Class LogIn
    Private cs As String = "Database=hmsystem; Data Source=localhost; User Id=root; Password=nothing"
    Private conn As New MySqlConnection(cs)

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim cmd As MySqlCommand
        Dim scm As String = "SELECT VERSION()"
        cmd = New MySqlCommand(scm, conn)
        MsgBox(Convert.ToString(cmd.ExecuteScalar()))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MDIParent1.Show()
    End Sub
End Class
