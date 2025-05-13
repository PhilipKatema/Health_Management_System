<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hospital_Records
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
        Me.EmployeeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InstitutionNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConditionsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatePaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemarksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HospitalRecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Staff_Health_ManagementDataSet = New EMPLOYEE_HEALTH_MANAGEMENT_SYSTEM.Staff_Health_ManagementDataSet()
        Me.HospitalRecordsTableAdapter = New EMPLOYEE_HEALTH_MANAGEMENT_SYSTEM.Staff_Health_ManagementDataSetTableAdapters.HospitalRecordsTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HospitalRecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Staff_Health_ManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeNameDataGridViewTextBoxColumn, Me.InstitutionNameDataGridViewTextBoxColumn, Me.VisitDateDataGridViewTextBoxColumn, Me.ConditionsDataGridViewTextBoxColumn, Me.TreatmentDataGridViewTextBoxColumn, Me.BillDataGridViewTextBoxColumn, Me.PaidDataGridViewTextBoxColumn, Me.DatePaidDataGridViewTextBoxColumn, Me.RemarksDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HospitalRecordsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(944, 292)
        Me.DataGridView1.TabIndex = 0
        '
        'EmployeeNameDataGridViewTextBoxColumn
        '
        Me.EmployeeNameDataGridViewTextBoxColumn.DataPropertyName = "Employee_Name"
        Me.EmployeeNameDataGridViewTextBoxColumn.HeaderText = "Employee_Name"
        Me.EmployeeNameDataGridViewTextBoxColumn.Name = "EmployeeNameDataGridViewTextBoxColumn"
        '
        'InstitutionNameDataGridViewTextBoxColumn
        '
        Me.InstitutionNameDataGridViewTextBoxColumn.DataPropertyName = "Institution_Name"
        Me.InstitutionNameDataGridViewTextBoxColumn.HeaderText = "Institution_Name"
        Me.InstitutionNameDataGridViewTextBoxColumn.Name = "InstitutionNameDataGridViewTextBoxColumn"
        '
        'VisitDateDataGridViewTextBoxColumn
        '
        Me.VisitDateDataGridViewTextBoxColumn.DataPropertyName = "Visit_Date"
        Me.VisitDateDataGridViewTextBoxColumn.HeaderText = "Visit_Date"
        Me.VisitDateDataGridViewTextBoxColumn.Name = "VisitDateDataGridViewTextBoxColumn"
        '
        'ConditionsDataGridViewTextBoxColumn
        '
        Me.ConditionsDataGridViewTextBoxColumn.DataPropertyName = "Conditions"
        Me.ConditionsDataGridViewTextBoxColumn.HeaderText = "Conditions"
        Me.ConditionsDataGridViewTextBoxColumn.Name = "ConditionsDataGridViewTextBoxColumn"
        '
        'TreatmentDataGridViewTextBoxColumn
        '
        Me.TreatmentDataGridViewTextBoxColumn.DataPropertyName = "Treatment"
        Me.TreatmentDataGridViewTextBoxColumn.HeaderText = "Treatment"
        Me.TreatmentDataGridViewTextBoxColumn.Name = "TreatmentDataGridViewTextBoxColumn"
        '
        'BillDataGridViewTextBoxColumn
        '
        Me.BillDataGridViewTextBoxColumn.DataPropertyName = "Bill"
        Me.BillDataGridViewTextBoxColumn.HeaderText = "Bill"
        Me.BillDataGridViewTextBoxColumn.Name = "BillDataGridViewTextBoxColumn"
        '
        'PaidDataGridViewTextBoxColumn
        '
        Me.PaidDataGridViewTextBoxColumn.DataPropertyName = "Paid"
        Me.PaidDataGridViewTextBoxColumn.HeaderText = "Paid"
        Me.PaidDataGridViewTextBoxColumn.Name = "PaidDataGridViewTextBoxColumn"
        '
        'DatePaidDataGridViewTextBoxColumn
        '
        Me.DatePaidDataGridViewTextBoxColumn.DataPropertyName = "Date_Paid"
        Me.DatePaidDataGridViewTextBoxColumn.HeaderText = "Date_Paid"
        Me.DatePaidDataGridViewTextBoxColumn.Name = "DatePaidDataGridViewTextBoxColumn"
        '
        'RemarksDataGridViewTextBoxColumn
        '
        Me.RemarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks"
        Me.RemarksDataGridViewTextBoxColumn.HeaderText = "Remarks"
        Me.RemarksDataGridViewTextBoxColumn.Name = "RemarksDataGridViewTextBoxColumn"
        '
        'HospitalRecordsBindingSource
        '
        Me.HospitalRecordsBindingSource.DataMember = "HospitalRecords"
        Me.HospitalRecordsBindingSource.DataSource = Me.Staff_Health_ManagementDataSet
        '
        'Staff_Health_ManagementDataSet
        '
        Me.Staff_Health_ManagementDataSet.DataSetName = "Staff_Health_ManagementDataSet"
        Me.Staff_Health_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HospitalRecordsTableAdapter
        '
        Me.HospitalRecordsTableAdapter.ClearBeforeFill = True
        '
        'Hospital_Records
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 425)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Hospital_Records"
        Me.Text = "Hospital_Records"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HospitalRecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Staff_Health_ManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Staff_Health_ManagementDataSet As EMPLOYEE_HEALTH_MANAGEMENT_SYSTEM.Staff_Health_ManagementDataSet
    Friend WithEvents HospitalRecordsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HospitalRecordsTableAdapter As EMPLOYEE_HEALTH_MANAGEMENT_SYSTEM.Staff_Health_ManagementDataSetTableAdapters.HospitalRecordsTableAdapter
    Friend WithEvents EmployeeNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InstitutionNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VisitDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConditionsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TreatmentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BillDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatePaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemarksDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
