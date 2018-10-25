<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.staffLogin = New System.Windows.Forms.Button()
        Me.adminLogin = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'staffLogin
        '
        Me.staffLogin.BackColor = System.Drawing.Color.IndianRed
        resources.ApplyResources(Me.staffLogin, "staffLogin")
        Me.staffLogin.ForeColor = System.Drawing.Color.Maroon
        Me.staffLogin.Name = "staffLogin"
        Me.staffLogin.UseVisualStyleBackColor = False
        '
        'adminLogin
        '
        resources.ApplyResources(Me.adminLogin, "adminLogin")
        Me.adminLogin.BackColor = System.Drawing.Color.IndianRed
        Me.adminLogin.ForeColor = System.Drawing.Color.Maroon
        Me.adminLogin.Name = "adminLogin"
        Me.adminLogin.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        resources.ApplyResources(Me.LinkLabel1, "LinkLabel1")
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.White
        '
        'Login
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.LinkLabel1
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.adminLogin)
        Me.Controls.Add(Me.staffLogin)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents staffLogin As Button
    Friend WithEvents adminLogin As Button
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
