<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParent))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlSideBar = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnStock = New System.Windows.Forms.Button()
        Me.btnTransaction = New System.Windows.Forms.Button()
        Me.btnOrders = New System.Windows.Forms.Button()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlChild = New System.Windows.Forms.Panel()
        Me.pnlSideBar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSideBar
        '
        Me.pnlSideBar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlSideBar.Controls.Add(Me.btnLogout)
        Me.pnlSideBar.Controls.Add(Me.btnReports)
        Me.pnlSideBar.Controls.Add(Me.btnStock)
        Me.pnlSideBar.Controls.Add(Me.btnTransaction)
        Me.pnlSideBar.Controls.Add(Me.btnOrders)
        Me.pnlSideBar.Controls.Add(Me.btnCustomers)
        Me.pnlSideBar.Controls.Add(Me.btnDashboard)
        Me.pnlSideBar.Controls.Add(Me.PictureBox1)
        Me.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSideBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSideBar.Name = "pnlSideBar"
        Me.pnlSideBar.Size = New System.Drawing.Size(109, 453)
        Me.pnlSideBar.TabIndex = 9
        '
        'btnLogout
        '
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.Location = New System.Drawing.Point(0, 415)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(109, 38)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReports.Location = New System.Drawing.Point(0, 309)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(109, 38)
        Me.btnReports.TabIndex = 6
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnStock
        '
        Me.btnStock.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStock.Location = New System.Drawing.Point(0, 271)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Size = New System.Drawing.Size(109, 38)
        Me.btnStock.TabIndex = 5
        Me.btnStock.Text = "Stock"
        Me.btnStock.UseVisualStyleBackColor = True
        '
        'btnTransaction
        '
        Me.btnTransaction.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTransaction.Location = New System.Drawing.Point(0, 233)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Size = New System.Drawing.Size(109, 38)
        Me.btnTransaction.TabIndex = 4
        Me.btnTransaction.Text = "Transaction"
        Me.btnTransaction.UseVisualStyleBackColor = True
        '
        'btnOrders
        '
        Me.btnOrders.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOrders.Location = New System.Drawing.Point(0, 195)
        Me.btnOrders.Name = "btnOrders"
        Me.btnOrders.Size = New System.Drawing.Size(109, 38)
        Me.btnOrders.TabIndex = 3
        Me.btnOrders.Text = "Orders"
        Me.btnOrders.UseVisualStyleBackColor = True
        '
        'btnCustomers
        '
        Me.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCustomers.Location = New System.Drawing.Point(0, 157)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(109, 38)
        Me.btnCustomers.TabIndex = 2
        Me.btnCustomers.Text = "Customers"
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.Location = New System.Drawing.Point(0, 119)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(109, 38)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pnlChild
        '
        Me.pnlChild.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlChild.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlChild.Location = New System.Drawing.Point(109, 0)
        Me.pnlChild.Name = "pnlChild"
        Me.pnlChild.Size = New System.Drawing.Size(523, 453)
        Me.pnlChild.TabIndex = 10
        '
        'frmParent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.pnlChild)
        Me.Controls.Add(Me.pnlSideBar)
        Me.IsMdiContainer = True
        Me.Name = "frmParent"
        Me.Text = "Karolih Solutions"
        Me.pnlSideBar.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents pnlSideBar As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnStock As Button
    Friend WithEvents btnTransaction As Button
    Friend WithEvents btnOrders As Button
    Friend WithEvents btnCustomers As Button
    Friend WithEvents pnlChild As Panel
End Class
