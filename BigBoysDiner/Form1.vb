Public Class Login
    Private adminLogWindow As Object
    Private staffWindow As Object

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles adminLogin.Click
        adminLogWindow = New adminConfirm()
        adminLogWindow.showDialog()
    
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles staffLogin.Click
        staffWindow = New staffReceipt()
        Me.Hide()
        staffWindow.show()


    End Sub

    Private Sub Lbl_Click(sender As Object, e As EventArgs) Handles LinkLabel1.Click

        Dim answers As Integer = MessageBox.show("Are you sure you want to quit?", "Closing Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If answers = DialogResult.Yes Then
            Me.close()
        ElseIf answers= DialogResult.No Then
            
        End If

            
    End Sub
End Class