Imports MySql.Data.MySqlClient


Public Class staffReceipt
    Public conn As MySqlConnection = New MySqlConnection("server=localhost;userid=root;password=1234;database=salesmonitoringsystem")

    Private Sub TextSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("Select * from tbl_products", conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dataTbl As New DataTable
            Dim dtSet As New DataSet

            adapter.Fill(dtSet, "products")
            'dtSet.Tables.Add(dataTbl)
            Dim col As New AutoCompleteStringCollection
            For i = 0 To dtSet.Tables(0).Rows.Count - 1
                col.Add(dtSet.Tables(0).Rows(i)(0).ToString)

            Next

            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtSearch.AutoCompleteCustomSource = col
            txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

        conn.Close()


    End Sub
End Class