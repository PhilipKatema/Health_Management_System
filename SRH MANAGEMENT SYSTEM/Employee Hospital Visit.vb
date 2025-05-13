Imports System.Data.OleDb

Public Class Employee_Hospital_Visit
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub Employee_Hospital_Visit_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbopaid.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Monitoring_Tools.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub ADD_Click(sender As Object, e As EventArgs) Handles ADD.Click
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
        dataFile = "C:\Users\PHILLIP\Documents\Staff Health Management.mdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "Insert into HospitalRecords([Employee_Name],[Institution_Name],[Visit_Date],[Conditions],[Treatment],[Bill],[Paid],[Date_Paid],[Remarks]) Values (?,?,?,?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.Parameters.Add(New OleDbParameter("Employee_Name", CType(cboname.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Institution_Name", CType(txtinstitution.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Visit_Date", CType(datevisit.Text, Date)))
        cmd.Parameters.Add(New OleDbParameter("Conditions", CType(txtconditions.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Treatment", CType(txttreatment.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Bill", CType(txtbill.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Paid", CType(cbopaid.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Date_Paid", CType(datepaid.Text, Date)))
        cmd.Parameters.Add(New OleDbParameter("Remarks", CType(txtremarks.Text, String)))

        Try

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            txtbill.Clear()
            txtconditions.Clear()
            txtinstitution.Clear()
            txtremarks.Clear()
            txttreatment.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub cboname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboname.SelectedIndexChanged

    End Sub
End Class