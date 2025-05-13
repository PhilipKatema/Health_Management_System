Public Class Hospital_Records

    Private Sub Hospital_Records_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Staff_Health_ManagementDataSet.HospitalRecords' table. You can move, or remove it, as needed.
        Me.HospitalRecordsTableAdapter.Fill(Me.Staff_Health_ManagementDataSet.HospitalRecords)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class