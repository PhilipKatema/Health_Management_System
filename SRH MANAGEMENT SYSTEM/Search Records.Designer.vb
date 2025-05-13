<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_Records
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Search_Records))
        Me.GeneralDataBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.GeneralDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Staff_Health_ManagementDataSet = New EMPLOYEE_HEALTH_MANAGEMENT_SYSTEM.Staff_Health_ManagementDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.GeneralDataBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.GeneralDataDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GeneralDataTableAdapter = New EMPLOYEE_HEALTH_MANAGEMENT_SYSTEM.Staff_Health_ManagementDataSetTableAdapters.GeneralDataTableAdapter()
        Me.TableAdapterManager = New EMPLOYEE_HEALTH_MANAGEMENT_SYSTEM.Staff_Health_ManagementDataSetTableAdapters.TableAdapterManager()
        CType(Me.GeneralDataBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GeneralDataBindingNavigator.SuspendLayout()
        CType(Me.GeneralDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Staff_Health_ManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralDataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GeneralDataBindingNavigator
        '
        Me.GeneralDataBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.GeneralDataBindingNavigator.BindingSource = Me.GeneralDataBindingSource
        Me.GeneralDataBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.GeneralDataBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.GeneralDataBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.GeneralDataBindingNavigatorSaveItem})
        Me.GeneralDataBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GeneralDataBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.GeneralDataBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.GeneralDataBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.GeneralDataBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.GeneralDataBindingNavigator.Name = "GeneralDataBindingNavigator"
        Me.GeneralDataBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.GeneralDataBindingNavigator.Size = New System.Drawing.Size(804, 25)
        Me.GeneralDataBindingNavigator.TabIndex = 0
        Me.GeneralDataBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'GeneralDataBindingNavigatorSaveItem
        '
        Me.GeneralDataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GeneralDataBindingNavigatorSaveItem.Image = CType(resources.GetObject("GeneralDataBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GeneralDataBindingNavigatorSaveItem.Name = "GeneralDataBindingNavigatorSaveItem"
        Me.GeneralDataBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.GeneralDataBindingNavigatorSaveItem.Text = "Save Data"
        '
        'GeneralDataDataGridView
        '
        Me.GeneralDataDataGridView.AutoGenerateColumns = False
        Me.GeneralDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GeneralDataDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.GeneralDataDataGridView.DataSource = Me.GeneralDataBindingSource
        Me.GeneralDataDataGridView.Location = New System.Drawing.Point(12, 97)
        Me.GeneralDataDataGridView.Name = "GeneralDataDataGridView"
        Me.GeneralDataDataGridView.Size = New System.Drawing.Size(642, 259)
        Me.GeneralDataDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Staff_Department"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Staff_Department"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Client_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Client_ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Date_Registered"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Date_Registered"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "First_Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Surname"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Date_of_Birth"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Date_of_Birth"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(12, 57)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(202, 20)
        Me.txtsearch.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(237, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(680, 97)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 48)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "ADD NEW EMPLOYEE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GeneralDataTableAdapter
        '
        Me.GeneralDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GeneralDataTableAdapter = Me.GeneralDataTableAdapter
        Me.TableAdapterManager.UpdateOrder = EMPLOYEE_HEALTH_MANAGEMENT_SYSTEM.Staff_Health_ManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Search_Records
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(804, 382)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.GeneralDataDataGridView)
        Me.Controls.Add(Me.GeneralDataBindingNavigator)
        Me.Name = "Search_Records"
        Me.Text = "Search_Records"
        CType(Me.GeneralDataBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GeneralDataBindingNavigator.ResumeLayout(False)
        Me.GeneralDataBindingNavigator.PerformLayout()
        CType(Me.GeneralDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Staff_Health_ManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralDataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Staff_Health_ManagementDataSet As EMPLOYEE_HEALTH_MANAGEMENT_SYSTEM.Staff_Health_ManagementDataSet
    Friend WithEvents GeneralDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GeneralDataTableAdapter As EMPLOYEE_HEALTH_MANAGEMENT_SYSTEM.Staff_Health_ManagementDataSetTableAdapters.GeneralDataTableAdapter
    Friend WithEvents TableAdapterManager As EMPLOYEE_HEALTH_MANAGEMENT_SYSTEM.Staff_Health_ManagementDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GeneralDataBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GeneralDataBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents GeneralDataDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
