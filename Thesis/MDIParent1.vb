Imports System.Windows.Forms

Public Class MDIParent1


    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CheckInToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles CheckInToolStripMenuItem1.Click
        Transaction.Show()

    End Sub

    Private Sub CheckOutToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles CheckOutToolStripMenuItem1.Click
        checkout.Show()

    End Sub

    Private Sub CancelTransactionToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles CancelTransactionToolStripMenuItem1.Click
        Form2.Show()

    End Sub
End Class
