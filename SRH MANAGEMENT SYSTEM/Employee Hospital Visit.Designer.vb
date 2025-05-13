<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_Hospital_Visit
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtinstitution = New System.Windows.Forms.TextBox()
        Me.datevisit = New System.Windows.Forms.DateTimePicker()
        Me.txtconditions = New System.Windows.Forms.TextBox()
        Me.txttreatment = New System.Windows.Forms.TextBox()
        Me.txtbill = New System.Windows.Forms.TextBox()
        Me.cbopaid = New System.Windows.Forms.ComboBox()
        Me.datepaid = New System.Windows.Forms.DateTimePicker()
        Me.txtremarks = New System.Windows.Forms.TextBox()
        Me.ADD = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GeneralDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Staff_Health_ManagementDataSet = New EMPLOYEE_HEALTH_MANAGEMENT_SYSTEM.Staff_Health_ManagementDataSet()
        Me.GeneralDataTableAdapter = New EMPLOYEE_HEALTH_MANAGEMENT_SYSTEM.Staff_Health_ManagementDataSetTableAdapters.GeneralDataTableAdapter()
        Me.GeneralDataBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralDataBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboname = New System.Windows.Forms.ComboBox()
        Me.GeneralDataBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralDataBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffHealthManagementDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralDataBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralDataBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralDataBindingSource7 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.GeneralDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Staff_Health_ManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDataBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDataBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDataBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDataBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffHealthManagementDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDataBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDataBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDataBindingSource7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EMPLOYEE HOSPITAL VISIT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Employee Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name of Institution:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Visit Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Conditions:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Treatment given:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 342)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Bill Amount:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(224, 342)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Paid?"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(338, 342)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "If Yes, Payment Date:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 377)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Remarks:"
        '
        'txtinstitution
        '
        Me.txtinstitution.Location = New System.Drawing.Point(112, 95)
        Me.txtinstitution.Name = "txtinstitution"
        Me.txtinstitution.Size = New System.Drawing.Size(208, 20)
        Me.txtinstitution.TabIndex = 11
        '
        'datevisit
        '
        Me.datevisit.Location = New System.Drawing.Point(112, 140)
        Me.datevisit.Name = "datevisit"
        Me.datevisit.Size = New System.Drawing.Size(208, 20)
        Me.datevisit.TabIndex = 12
        '
        'txtconditions
        '
        Me.txtconditions.Location = New System.Drawing.Point(112, 188)
        Me.txtconditions.Multiline = True
        Me.txtconditions.Name = "txtconditions"
        Me.txtconditions.Size = New System.Drawing.Size(208, 49)
        Me.txtconditions.TabIndex = 13
        '
        'txttreatment
        '
        Me.txttreatment.Location = New System.Drawing.Point(112, 264)
        Me.txttreatment.Multiline = True
        Me.txttreatment.Name = "txttreatment"
        Me.txttreatment.Size = New System.Drawing.Size(208, 49)
        Me.txttreatment.TabIndex = 14
        '
        'txtbill
        '
        Me.txtbill.Location = New System.Drawing.Point(112, 339)
        Me.txtbill.Name = "txtbill"
        Me.txtbill.Size = New System.Drawing.Size(95, 20)
        Me.txtbill.TabIndex = 15
        '
        'cbopaid
        '
        Me.cbopaid.FormattingEnabled = True
        Me.cbopaid.Items.AddRange(New Object() {"YES", "NO"})
        Me.cbopaid.Location = New System.Drawing.Point(261, 338)
        Me.cbopaid.Name = "cbopaid"
        Me.cbopaid.Size = New System.Drawing.Size(59, 21)
        Me.cbopaid.TabIndex = 16
        '
        'datepaid
        '
        Me.datepaid.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datepaid.Location = New System.Drawing.Point(454, 339)
        Me.datepaid.Name = "datepaid"
        Me.datepaid.Size = New System.Drawing.Size(87, 20)
        Me.datepaid.TabIndex = 17
        '
        'txtremarks
        '
        Me.txtremarks.Location = New System.Drawing.Point(112, 377)
        Me.txtremarks.Multiline = True
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.Size = New System.Drawing.Size(208, 49)
        Me.txtremarks.TabIndex = 18
        '
        'ADD
        '
        Me.ADD.Location = New System.Drawing.Point(409, 72)
        Me.ADD.Name = "ADD"
        Me.ADD.Size = New System.Drawing.Size(117, 43)
        Me.ADD.TabIndex = 19
        Me.ADD.Text = "ADD"
        Me.ADD.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(409, 140)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 48)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Go to Monitoring tools"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(409, 215)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 48)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Go back to Switchboard"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GeneralDataBindingSource
        '
        Me.GeneralDataBindingSource.DataMember = "GeneralData"
        Me.GeneralDataBindingSource.DataSource = Me.Staff_Health_ManagementDataSet
        '
        'Staff_Health_ManagementDataSet
        '
        Me.Staff_Health_ManagementDataSet.DataSetName = "Staff_Health_ManagementDataSet"
        Me.Staff_Health_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GeneralDataTableAdapter
        '
        Me.GeneralDataTableAdapter.ClearBeforeFill = True
        '
        'GeneralDataBindingSource1
        '
        Me.GeneralDataBindingSource1.DataMember = "GeneralData"
        Me.GeneralDataBindingSource1.DataSource = Me.Staff_Health_ManagementDataSet
        '
        'GeneralDataBindingSource2
        '
        Me.GeneralDataBindingSource2.DataMember = "GeneralData"
        Me.GeneralDataBindingSource2.DataSource = Me.Staff_Health_ManagementDataSet
        '
        'cboname
        '
        Me.cboname.FormattingEnabled = True
        Me.cboname.Location = New System.Drawing.Point(112, 48)
        Me.cboname.Name = "cboname"
        Me.cboname.Size = New System.Drawing.Size(208, 21)
        Me.cboname.TabIndex = 10
        '
        'GeneralDataBindingSource4
        '
        Me.GeneralDataBindingSource4.DataMember = "GeneralData"
        Me.GeneralDataBindingSource4.DataSource = Me.Staff_Health_ManagementDataSet
        '
        'GeneralDataBindingSource3
        '
        Me.GeneralDataBindingSource3.DataMember = "GeneralData"
        Me.GeneralDataBindingSource3.DataSource = Me.Staff_Health_ManagementDataSet
        '
        'StaffHealthManagementDataSetBindingSource
        '
        Me.StaffHealthManagementDataSetBindingSource.DataSource = Me.Staff_Health_ManagementDataSet
        Me.StaffHealthManagementDataSetBindingSource.Position = 0
        '
        'GeneralDataBindingSource5
        '
        Me.GeneralDataBindingSource5.DataMember = "GeneralData"
        Me.GeneralDataBindingSource5.DataSource = Me.StaffHealthManagementDataSetBindingSource
        '
        'GeneralDataBindingSource6
        '
        Me.GeneralDataBindingSource6.DataMember = "GeneralData"
        Me.GeneralDataBindingSource6.DataSource = Me.Staff_Health_ManagementDataSet
        '
        'GeneralDataBindingSource7
        '
        Me.GeneralDataBindingSource7.DataMember = "GeneralData"
        Me.GeneralDataBindingSource7.DataSource = Me.Staff_Health_ManagementDataSet
        '
        'Employee_Hospital_Visit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 438)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ADD)
        Me.Controls.Add(Me.txtremarks)
        Me.Controls.Add(Me.datepaid)
        Me.Controls.Add(Me.cbopaid)
        Me.Controls.Add(Me.txtbill)
        Me.Controls.Add(Me.txttreatment)
        Me.Controls.Add(Me.txtconditions)
        Me.Controls.Add(Me.datevisit)
        Me.Controls.Add(Me.txtinstitution)
        Me.Controls.Add(Me.cboname)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Employee_Hospital_Visit"
        Me.Text = "Employee_Hospital_Visit"
        CType(Me.GeneralDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Staff_Health_ManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDataBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDataBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDataBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDataBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffHealthManagementDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDataBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDataBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDataBindingSource7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Staff_Health_ManagementDataSet As EMPLOYEE_HEALTH_MANAGEMENT_SYSTEM.Staff_Health_ManagementDataSet
    Friend WithEvents GeneralDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GeneralDataTableAdapter As EMPLOYEE_HEALTH_MANAGEMENT_SYSTEM.Staff_Health_ManagementDataSetTableAdapters.GeneralDataTableAdapter
    Friend WithEvents txtinstitution As System.Windows.Forms.TextBox
    Friend WithEvents datevisit As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtconditions As System.Windows.Forms.TextBox
    Friend WithEvents txttreatment As System.Windows.Forms.TextBox
    Friend WithEvents txtbill As System.Windows.Forms.TextBox
    Friend WithEvents cbopaid As System.Windows.Forms.ComboBox
    Friend WithEvents datepaid As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtremarks As System.Windows.Forms.TextBox
    Friend WithEvents ADD As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GeneralDataBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents GeneralDataBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents cboname As System.Windows.Forms.ComboBox
    Friend WithEvents GeneralDataBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents GeneralDataBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents GeneralDataBindingSource5 As System.Windows.Forms.BindingSource
    Friend WithEvents StaffHealthManagementDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GeneralDataBindingSource7 As System.Windows.Forms.BindingSource
    Friend WithEvents GeneralDataBindingSource6 As System.Windows.Forms.BindingSource
End Class
