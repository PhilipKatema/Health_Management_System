<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class All_Registered_Employees
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Staff_Health_ManagementDataSet = New EMPLOYEE_HEALTH_MANAGEMENT_SYSTEM.Staff_Health_ManagementDataSet()
        Me.GeneralDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralDataTableAdapter = New EMPLOYEE_HEALTH_MANAGEMENT_SYSTEM.Staff_Health_ManagementDataSetTableAdapters.GeneralDataTableAdapter()
        Me.StaffDepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateRegisteredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateofBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telephone1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telephone2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NationalityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EducationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HIVStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARTStartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBHistoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBDiagnosisDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBTreatmentHistoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Staff_Health_ManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StaffDepartmentDataGridViewTextBoxColumn, Me.ClientIDDataGridViewTextBoxColumn, Me.DateRegisteredDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.DateofBirthDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.Telephone1DataGridViewTextBoxColumn, Me.Telephone2DataGridViewTextBoxColumn, Me.NationalityDataGridViewTextBoxColumn, Me.EducationDataGridViewTextBoxColumn, Me.HIVStatusDataGridViewTextBoxColumn, Me.ARTStartDateDataGridViewTextBoxColumn, Me.TBHistoryDataGridViewTextBoxColumn, Me.TBDiagnosisDateDataGridViewTextBoxColumn, Me.TBTreatmentHistoryDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GeneralDataBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(968, 151)
        Me.DataGridView1.TabIndex = 0
        '
        'Staff_Health_ManagementDataSet
        '
        Me.Staff_Health_ManagementDataSet.DataSetName = "Staff_Health_ManagementDataSet"
        Me.Staff_Health_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GeneralDataBindingSource
        '
        Me.GeneralDataBindingSource.DataMember = "GeneralData"
        Me.GeneralDataBindingSource.DataSource = Me.Staff_Health_ManagementDataSet
        '
        'GeneralDataTableAdapter
        '
        Me.GeneralDataTableAdapter.ClearBeforeFill = True
        '
        'StaffDepartmentDataGridViewTextBoxColumn
        '
        Me.StaffDepartmentDataGridViewTextBoxColumn.DataPropertyName = "Staff_Department"
        Me.StaffDepartmentDataGridViewTextBoxColumn.HeaderText = "Staff_Department"
        Me.StaffDepartmentDataGridViewTextBoxColumn.Name = "StaffDepartmentDataGridViewTextBoxColumn"
        '
        'ClientIDDataGridViewTextBoxColumn
        '
        Me.ClientIDDataGridViewTextBoxColumn.DataPropertyName = "Client_ID"
        Me.ClientIDDataGridViewTextBoxColumn.HeaderText = "Client_ID"
        Me.ClientIDDataGridViewTextBoxColumn.Name = "ClientIDDataGridViewTextBoxColumn"
        '
        'DateRegisteredDataGridViewTextBoxColumn
        '
        Me.DateRegisteredDataGridViewTextBoxColumn.DataPropertyName = "Date_Registered"
        Me.DateRegisteredDataGridViewTextBoxColumn.HeaderText = "Date_Registered"
        Me.DateRegisteredDataGridViewTextBoxColumn.Name = "DateRegisteredDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        '
        'DateofBirthDataGridViewTextBoxColumn
        '
        Me.DateofBirthDataGridViewTextBoxColumn.DataPropertyName = "Date_of_Birth"
        Me.DateofBirthDataGridViewTextBoxColumn.HeaderText = "Date_of_Birth"
        Me.DateofBirthDataGridViewTextBoxColumn.Name = "DateofBirthDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'Telephone1DataGridViewTextBoxColumn
        '
        Me.Telephone1DataGridViewTextBoxColumn.DataPropertyName = "Telephone 1"
        Me.Telephone1DataGridViewTextBoxColumn.HeaderText = "Telephone 1"
        Me.Telephone1DataGridViewTextBoxColumn.Name = "Telephone1DataGridViewTextBoxColumn"
        '
        'Telephone2DataGridViewTextBoxColumn
        '
        Me.Telephone2DataGridViewTextBoxColumn.DataPropertyName = "Telephone 2"
        Me.Telephone2DataGridViewTextBoxColumn.HeaderText = "Telephone 2"
        Me.Telephone2DataGridViewTextBoxColumn.Name = "Telephone2DataGridViewTextBoxColumn"
        '
        'NationalityDataGridViewTextBoxColumn
        '
        Me.NationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality"
        Me.NationalityDataGridViewTextBoxColumn.HeaderText = "Nationality"
        Me.NationalityDataGridViewTextBoxColumn.Name = "NationalityDataGridViewTextBoxColumn"
        '
        'EducationDataGridViewTextBoxColumn
        '
        Me.EducationDataGridViewTextBoxColumn.DataPropertyName = "Education"
        Me.EducationDataGridViewTextBoxColumn.HeaderText = "Education"
        Me.EducationDataGridViewTextBoxColumn.Name = "EducationDataGridViewTextBoxColumn"
        '
        'HIVStatusDataGridViewTextBoxColumn
        '
        Me.HIVStatusDataGridViewTextBoxColumn.DataPropertyName = "HIV_Status"
        Me.HIVStatusDataGridViewTextBoxColumn.HeaderText = "HIV_Status"
        Me.HIVStatusDataGridViewTextBoxColumn.Name = "HIVStatusDataGridViewTextBoxColumn"
        '
        'ARTStartDateDataGridViewTextBoxColumn
        '
        Me.ARTStartDateDataGridViewTextBoxColumn.DataPropertyName = "ART_Start_Date"
        Me.ARTStartDateDataGridViewTextBoxColumn.HeaderText = "ART_Start_Date"
        Me.ARTStartDateDataGridViewTextBoxColumn.Name = "ARTStartDateDataGridViewTextBoxColumn"
        '
        'TBHistoryDataGridViewTextBoxColumn
        '
        Me.TBHistoryDataGridViewTextBoxColumn.DataPropertyName = "TB_History"
        Me.TBHistoryDataGridViewTextBoxColumn.HeaderText = "TB_History"
        Me.TBHistoryDataGridViewTextBoxColumn.Name = "TBHistoryDataGridViewTextBoxColumn"
        '
        'TBDiagnosisDateDataGridViewTextBoxColumn
        '
        Me.TBDiagnosisDateDataGridViewTextBoxColumn.DataPropertyName = "TB_Diagnosis_Date"
        Me.TBDiagnosisDateDataGridViewTextBoxColumn.HeaderText = "TB_Diagnosis_Date"
        Me.TBDiagnosisDateDataGridViewTextBoxColumn.Name = "TBDiagnosisDateDataGridViewTextBoxColumn"
        '
        'TBTreatmentHistoryDataGridViewTextBoxColumn
        '
        Me.TBTreatmentHistoryDataGridViewTextBoxColumn.DataPropertyName = "TB_Treatment_History"
        Me.TBTreatmentHistoryDataGridViewTextBoxColumn.HeaderText = "TB_Treatment_History"
        Me.TBTreatmentHistoryDataGridViewTextBoxColumn.Name = "TBTreatmentHistoryDataGridViewTextBoxColumn"
        '
        'All_Registered_Employees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 261)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "All_Registered_Employees"
        Me.Text = "All_Registered_Employees"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Staff_Health_ManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Staff_Health_ManagementDataSet As EMPLOYEE_HEALTH_MANAGEMENT_SYSTEM.Staff_Health_ManagementDataSet
    Friend WithEvents GeneralDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GeneralDataTableAdapter As EMPLOYEE_HEALTH_MANAGEMENT_SYSTEM.Staff_Health_ManagementDataSetTableAdapters.GeneralDataTableAdapter
    Friend WithEvents StaffDepartmentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateRegisteredDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateofBirthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telephone1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telephone2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NationalityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EducationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HIVStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ARTStartDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TBHistoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TBDiagnosisDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TBTreatmentHistoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
