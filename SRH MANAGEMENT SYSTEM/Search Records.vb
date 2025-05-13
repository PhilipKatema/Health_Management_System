Public Class Search_Records

    Private Sub GeneralDataBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralDataBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.GeneralDataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Staff_Health_ManagementDataSet)

    End Sub

    Private Sub Search_Records_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Staff_Health_ManagementDataSet.GeneralData' table. You can move, or remove it, as needed.
        'Me.GeneralDataTableAdapter.Fill(Me.Staff_Health_ManagementDataSet.GeneralData)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Dim search As String = "%" + txtsearch.Text + "%"

        Me.GeneralDataTableAdapter.FillBySearchName(Me.Staff_Health_ManagementDataSet.GeneralData, search, search)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Enrolment.Show()
    End Sub
End Class