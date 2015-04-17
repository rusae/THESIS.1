Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class SignUp
    Private cs As String = "Database=hmsystem; Data Source=localhost; User Id=root; Password=root"
    Private conn As New MySqlConnection(cs)
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub SignUp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            conn.Open()
            Dim cmd As MySqlCommand
            Dim query As String = "INSERT INTO users(name, username, password) VALUES (@name, @username, @password)"
            cmd = New MySqlCommand(query, conn)
            Dim nameexp As New Regex("^[a-z A-Z]+$")
            Dim passexp As New Regex("^[a-z A-Z0-9]+$")
            If nameexp.IsMatch(tbName.Text) And nameexp.IsMatch(tbUname.Text) And passexp.IsMatch(tbPassword.Text) Then
                cmd.Parameters.AddWithValue("@name", tbName.Text)
                cmd.Parameters.AddWithValue("@username", tbUname.Text)
                cmd.Parameters.AddWithValue("@password", tbPassword.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Registration Successful", MsgBoxStyle.Information)
                Me.Hide()
            Else
                MsgBox("Some character inputs are not allowed", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("Could not connect to the Database", MsgBoxStyle.Critical)
        Finally
            conn.Close()

        End Try

    End Sub
End Class