Imports MySql.Data.MySqlClient


Public Class LogIn
    Private cs As String = "Database=hmsystem; Data Source=localhost; User Id=root; Password=nothing"
    Private conn As New MySqlConnection(cs)
    Private cmd As MySqlCommand
    Private da As New MySqlDataAdapter
    Private dt As New DataTable


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SignUp.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If tbUname.Text = String.Empty Or tbPassword.Text = String.Empty Then
            MsgBox("Empty Username or Password", MsgBoxStyle.Exclamation)
        Else
            Dim query As String = "SELECT * FROM users where username = @uname"
            'With cmd
            '.Connection = conn
            '.CommandText = query
            '.Parameters.AddWithValue("@uname", tbUname.Text)
            'End With
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@uname", tbUname.Text)
            With da
                .SelectCommand = cmd
                .Fill(dt)
            End With
            If dt.Rows.Count > 0 Then
                If dt.Rows(0).Item(3) = tbPassword.Text Then
                    MsgBox("Welcome " & tbUname.Text, MsgBoxStyle.Information)
                    Me.Hide()
                    Transaction.Show()
                Else
                    MsgBox("Incorrect Password", MsgBoxStyle.Exclamation)
                End If

            Else
                MsgBox("User does not exist", MsgBoxStyle.Exclamation)

            End If
        End If

    End Sub
End Class
