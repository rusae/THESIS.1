Imports System.Windows.Forms

Public Class MDIParent1


    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CheckOutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CheckOutToolStripMenuItem.Click
        checkout.Show()
    End Sub

    Private Sub CheckInToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CheckInToolStripMenuItem.Click
        Transaction.Show()
    End Sub
End Class
