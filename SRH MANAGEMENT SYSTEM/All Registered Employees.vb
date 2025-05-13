Public Class All_Registered_Employees

    Private Sub All_Registered_Employees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Staff_Health_ManagementDataSet.GeneralData' table. You can move, or remove it, as needed.
        Me.GeneralDataTableAdapter.Fill(Me.Staff_Health_ManagementDataSet.GeneralData)

    End Sub
End Class