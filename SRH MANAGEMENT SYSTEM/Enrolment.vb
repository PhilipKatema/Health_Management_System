Imports System.Data.OleDb

Public Class Enrolment
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtaddress.TextChanged

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.txtaddress.Text = ""
        Me.txtID.Text = ""
        Me.txtname.Text = ""
        Me.txtnum1.Text = ""
        Me.txtnum2.Text = ""
        Me.txtsurname.Text = ""
        Me.cbodept.Text = ""
        Me.cboedu.Text = ""
        Me.cbonat.Text = ""
        Me.cbohiv.Text = ""
        Me.cbotb.Text = ""
        Me.txttbhis.Text = ""

    End Sub

    Private Sub Enrolment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
        dataFile = "C:\Users\PHILLIP\Documents\Staff Health Management.mdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "Insert into GeneralData([Client_ID],[Address],[Telephone 1],[Telephone 2],[Nationality],[Education],[Staff_Department],[Date_Registered],[First_Name],[Surname],[Date_of_Birth],[HIV_Status],[ART_Start_Date],[TB_History],[TB_Diagnosis_Date],[TB_Treatment_History]) Values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.Parameters.Add(New OleDbParameter("Client_ID", CType(txtID.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Address", CType(txtaddress.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Telephone 1", CType(txtnum1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Telephone 2", CType(txtnum2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Nationality", CType(cbonat.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Education", CType(cboedu.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Staff_Department", CType(cbodept.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Date_Registered", CType(Datereg.Text, Date)))
        cmd.Parameters.Add(New OleDbParameter("First_Name", CType(txtname.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Surname", CType(txtsurname.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Date_Of_Birth", CType(Datedob.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HIV_Status", CType(cbohiv.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("ART_Start_Date", CType(datehiv.Text, Date)))
        cmd.Parameters.Add(New OleDbParameter("TB_History", CType(cbotb.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("TB_Diagnosis_Date", CType(datetb.Text, Date)))
        cmd.Parameters.Add(New OleDbParameter("TB_Treatment_History", CType(txttbhis.Text, String)))

        Try

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            txtaddress.Clear()
            txtID.Clear()
            txtname.Clear()
            txtnum1.Clear()
            txtnum2.Clear()
            txtsurname.Clear()
            txttbhis.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class