Imports System.Windows.Forms

Public Class frmParent

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("You will be logged out, proceed?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim dashboardForm As New frmDashboard()
        dashboardForm.TopLevel = False
        dashboardForm.FormBorderStyle = FormBorderStyle.None
        dashboardForm.Dock = DockStyle.Fill
        pnlChild.Controls.Clear()
        pnlChild.Controls.Add(dashboardForm)
        dashboardForm.Show()
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        Dim customersForm As New frmCustomers()
        customersForm.TopLevel = False
        customersForm.FormBorderStyle = FormBorderStyle.None
        customersForm.Dock = DockStyle.Fill
        pnlChild.Controls.Clear()
        pnlChild.Controls.Add(customersForm)
        customersForm.Show()
    End Sub

    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click
        Dim ordersForm As New frmOrders()
        ordersForm.TopLevel = False
        ordersForm.FormBorderStyle = FormBorderStyle.None
        ordersForm.Dock = DockStyle.Fill
        pnlChild.Controls.Clear()
        pnlChild.Controls.Add(ordersForm)
        ordersForm.Show()
    End Sub

    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        Dim transactionForm As New frmTransaction()
        transactionForm.TopLevel = False
        transactionForm.FormBorderStyle = FormBorderStyle.None
        transactionForm.Dock = DockStyle.Fill
        pnlChild.Controls.Clear()
        pnlChild.Controls.Add(transactionForm)
        transactionForm.Show()
    End Sub

    Private Sub btnStock_Click(sender As Object, e As EventArgs) Handles btnStock.Click
        Dim stockForm As New frmStock()
        stockForm.TopLevel = False
        stockForm.FormBorderStyle = FormBorderStyle.None
        stockForm.Dock = DockStyle.Fill
        pnlChild.Controls.Clear()
        pnlChild.Controls.Add(stockForm)
        stockForm.Show()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Dim reportsForm As New frmReports()
        reportsForm.TopLevel = False
        reportsForm.FormBorderStyle = FormBorderStyle.None
        reportsForm.Dock = DockStyle.Fill
        pnlChild.Controls.Clear()
        pnlChild.Controls.Add(reportsForm)
        reportsForm.Show()
    End Sub
End Class
