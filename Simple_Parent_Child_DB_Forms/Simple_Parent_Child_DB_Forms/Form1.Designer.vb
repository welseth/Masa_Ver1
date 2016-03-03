<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Member_refnumLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim InstructorLabel As System.Windows.Forms.Label
        Dim Tow_PilotLabel As System.Windows.Forms.Label
        Dim MASA_MemberLabel As System.Windows.Forms.Label
        Dim Guest_MemberLabel As System.Windows.Forms.Label
        Dim Flight_refnumLabel As System.Windows.Forms.Label
        Dim Glider_Pilot_NameLabel As System.Windows.Forms.Label
        Dim Instructor_nameLabel As System.Windows.Forms.Label
        Dim Passenger_nameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MASA_allDataSet = New Simple_Parent_Child_DB_Forms.MASA_allDataSet()
        Me.FlightsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlightsTableAdapter = New Simple_Parent_Child_DB_Forms.MASA_allDataSetTableAdapters.FlightsTableAdapter()
        Me.FlightsTableAdapterManager = New Simple_Parent_Child_DB_Forms.MASA_allDataSetTableAdapters.TableAdapterManager()
        Me.GliderPilotNameMembersTableAdapter = New Simple_Parent_Child_DB_Forms.MASA_allDataSetTableAdapters.MembersTableAdapter()
        Me.GliderPilotNameMembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InstructorDataSet = New Simple_Parent_Child_DB_Forms.InstructorDataSet()
        Me.InstructorNameMembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InstructorNameMembersTableAdapter = New Simple_Parent_Child_DB_Forms.InstructorDataSetTableAdapters.MembersTableAdapter()
        Me.InstructorNameTableAdapterManager = New Simple_Parent_Child_DB_Forms.InstructorDataSetTableAdapters.TableAdapterManager()
        Me.InstructorNameMembersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InstructorDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.NameComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Member_refnumTextBox = New System.Windows.Forms.TextBox()
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Me.InstructorCheckBox = New System.Windows.Forms.CheckBox()
        Me.Tow_PilotCheckBox = New System.Windows.Forms.CheckBox()
        Me.MASA_MemberCheckBox = New System.Windows.Forms.CheckBox()
        Me.Guest_MemberCheckBox = New System.Windows.Forms.CheckBox()
        Me.Flight_refnumTextBox = New System.Windows.Forms.TextBox()
        Me.Glider_Pilot_NameComboBox = New System.Windows.Forms.ComboBox()
        Me.Passenger_nameComboBox = New System.Windows.Forms.ComboBox()
        Me.FlightsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlightsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.FlightsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Member_refnumLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        InstructorLabel = New System.Windows.Forms.Label()
        Tow_PilotLabel = New System.Windows.Forms.Label()
        MASA_MemberLabel = New System.Windows.Forms.Label()
        Guest_MemberLabel = New System.Windows.Forms.Label()
        Flight_refnumLabel = New System.Windows.Forms.Label()
        Glider_Pilot_NameLabel = New System.Windows.Forms.Label()
        Instructor_nameLabel = New System.Windows.Forms.Label()
        Passenger_nameLabel = New System.Windows.Forms.Label()
        CType(Me.MASA_allDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlightsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GliderPilotNameMembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstructorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstructorNameMembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstructorNameMembersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstructorDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.FlightsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlightsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlightsBindingNavigator.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Member_refnumLabel
        '
        Member_refnumLabel.AutoSize = True
        Member_refnumLabel.Location = New System.Drawing.Point(496, 46)
        Member_refnumLabel.Name = "Member_refnumLabel"
        Member_refnumLabel.Size = New System.Drawing.Size(83, 13)
        Member_refnumLabel.TabIndex = 34
        Member_refnumLabel.Text = "Member refnum:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(496, 72)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 36
        NameLabel.Text = "Name:"
        '
        'InstructorLabel
        '
        InstructorLabel.AutoSize = True
        InstructorLabel.Location = New System.Drawing.Point(496, 101)
        InstructorLabel.Name = "InstructorLabel"
        InstructorLabel.Size = New System.Drawing.Size(54, 13)
        InstructorLabel.TabIndex = 38
        InstructorLabel.Text = "Instructor:"
        '
        'Tow_PilotLabel
        '
        Tow_PilotLabel.AutoSize = True
        Tow_PilotLabel.Location = New System.Drawing.Point(496, 131)
        Tow_PilotLabel.Name = "Tow_PilotLabel"
        Tow_PilotLabel.Size = New System.Drawing.Size(54, 13)
        Tow_PilotLabel.TabIndex = 40
        Tow_PilotLabel.Text = "Tow Pilot:"
        '
        'MASA_MemberLabel
        '
        MASA_MemberLabel.AutoSize = True
        MASA_MemberLabel.Location = New System.Drawing.Point(496, 161)
        MASA_MemberLabel.Name = "MASA_MemberLabel"
        MASA_MemberLabel.Size = New System.Drawing.Size(81, 13)
        MASA_MemberLabel.TabIndex = 42
        MASA_MemberLabel.Text = "MASA Member:"
        '
        'Guest_MemberLabel
        '
        Guest_MemberLabel.AutoSize = True
        Guest_MemberLabel.Location = New System.Drawing.Point(496, 191)
        Guest_MemberLabel.Name = "Guest_MemberLabel"
        Guest_MemberLabel.Size = New System.Drawing.Size(79, 13)
        Guest_MemberLabel.TabIndex = 44
        Guest_MemberLabel.Text = "Guest Member:"
        '
        'Flight_refnumLabel
        '
        Flight_refnumLabel.AutoSize = True
        Flight_refnumLabel.Location = New System.Drawing.Point(12, 49)
        Flight_refnumLabel.Name = "Flight_refnumLabel"
        Flight_refnumLabel.Size = New System.Drawing.Size(70, 13)
        Flight_refnumLabel.TabIndex = 27
        Flight_refnumLabel.Text = "Flight refnum:"
        '
        'Glider_Pilot_NameLabel
        '
        Glider_Pilot_NameLabel.AutoSize = True
        Glider_Pilot_NameLabel.Location = New System.Drawing.Point(12, 75)
        Glider_Pilot_NameLabel.Name = "Glider_Pilot_NameLabel"
        Glider_Pilot_NameLabel.Size = New System.Drawing.Size(91, 13)
        Glider_Pilot_NameLabel.TabIndex = 29
        Glider_Pilot_NameLabel.Text = "Glider Pilot Name:"
        '
        'Instructor_nameLabel
        '
        Instructor_nameLabel.AutoSize = True
        Instructor_nameLabel.Location = New System.Drawing.Point(12, 102)
        Instructor_nameLabel.Name = "Instructor_nameLabel"
        Instructor_nameLabel.Size = New System.Drawing.Size(83, 13)
        Instructor_nameLabel.TabIndex = 31
        Instructor_nameLabel.Text = "Instructor name:"
        '
        'Passenger_nameLabel
        '
        Passenger_nameLabel.AutoSize = True
        Passenger_nameLabel.Location = New System.Drawing.Point(12, 129)
        Passenger_nameLabel.Name = "Passenger_nameLabel"
        Passenger_nameLabel.Size = New System.Drawing.Size(89, 13)
        Passenger_nameLabel.TabIndex = 32
        Passenger_nameLabel.Text = "Passenger name:"
        '
        'MASA_allDataSet
        '
        Me.MASA_allDataSet.DataSetName = "MASA_allDataSet"
        Me.MASA_allDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FlightsBindingSource
        '
        Me.FlightsBindingSource.DataMember = "Flights"
        Me.FlightsBindingSource.DataSource = Me.MASA_allDataSet
        '
        'FlightsTableAdapter
        '
        Me.FlightsTableAdapter.ClearBeforeFill = True
        '
        'FlightsTableAdapterManager
        '
        Me.FlightsTableAdapterManager.AircraftTableAdapter = Nothing
        Me.FlightsTableAdapterManager.AirportTableAdapter = Nothing
        Me.FlightsTableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.FlightsTableAdapterManager.FlightsTableAdapter = Me.FlightsTableAdapter
        Me.FlightsTableAdapterManager.MembersTableAdapter = Me.GliderPilotNameMembersTableAdapter
        Me.FlightsTableAdapterManager.UpdateOrder = Simple_Parent_Child_DB_Forms.MASA_allDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GliderPilotNameMembersTableAdapter
        '
        Me.GliderPilotNameMembersTableAdapter.ClearBeforeFill = True
        '
        'GliderPilotNameMembersBindingSource
        '
        Me.GliderPilotNameMembersBindingSource.DataMember = "Members"
        Me.GliderPilotNameMembersBindingSource.DataSource = Me.MASA_allDataSet
        '
        'InstructorDataSet
        '
        Me.InstructorDataSet.DataSetName = "InstructorDataSet"
        Me.InstructorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InstructorNameMembersBindingSource
        '
        Me.InstructorNameMembersBindingSource.DataMember = "Members"
        Me.InstructorNameMembersBindingSource.DataSource = Me.InstructorDataSet
        '
        'InstructorNameMembersTableAdapter
        '
        Me.InstructorNameMembersTableAdapter.ClearBeforeFill = True
        '
        'InstructorNameTableAdapterManager
        '
        Me.InstructorNameTableAdapterManager.AircraftTableAdapter = Nothing
        Me.InstructorNameTableAdapterManager.AirportTableAdapter = Nothing
        Me.InstructorNameTableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.InstructorNameTableAdapterManager.FlightsTableAdapter = Nothing
        Me.InstructorNameTableAdapterManager.MembersTableAdapter = Me.InstructorNameMembersTableAdapter
        Me.InstructorNameTableAdapterManager.UpdateOrder = Simple_Parent_Child_DB_Forms.InstructorDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'InstructorNameMembersBindingSource1
        '
        Me.InstructorNameMembersBindingSource1.DataMember = "Members"
        Me.InstructorNameMembersBindingSource1.DataSource = Me.InstructorDataSetBindingSource
        '
        'InstructorDataSetBindingSource
        '
        Me.InstructorDataSetBindingSource.DataSource = Me.InstructorDataSet
        Me.InstructorDataSetBindingSource.Position = 0
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(845, 418)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.NameComboBox1)
        Me.TabPage1.Controls.Add(Member_refnumLabel)
        Me.TabPage1.Controls.Add(Me.Member_refnumTextBox)
        Me.TabPage1.Controls.Add(NameLabel)
        Me.TabPage1.Controls.Add(Me.NameComboBox)
        Me.TabPage1.Controls.Add(InstructorLabel)
        Me.TabPage1.Controls.Add(Me.InstructorCheckBox)
        Me.TabPage1.Controls.Add(Tow_PilotLabel)
        Me.TabPage1.Controls.Add(Me.Tow_PilotCheckBox)
        Me.TabPage1.Controls.Add(MASA_MemberLabel)
        Me.TabPage1.Controls.Add(Me.MASA_MemberCheckBox)
        Me.TabPage1.Controls.Add(Guest_MemberLabel)
        Me.TabPage1.Controls.Add(Me.Guest_MemberCheckBox)
        Me.TabPage1.Controls.Add(Flight_refnumLabel)
        Me.TabPage1.Controls.Add(Me.Flight_refnumTextBox)
        Me.TabPage1.Controls.Add(Glider_Pilot_NameLabel)
        Me.TabPage1.Controls.Add(Me.Glider_Pilot_NameComboBox)
        Me.TabPage1.Controls.Add(Instructor_nameLabel)
        Me.TabPage1.Controls.Add(Passenger_nameLabel)
        Me.TabPage1.Controls.Add(Me.Passenger_nameComboBox)
        Me.TabPage1.Controls.Add(Me.FlightsDataGridView)
        Me.TabPage1.Controls.Add(Me.FlightsBindingNavigator)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(845, 418)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'NameComboBox1
        '
        Me.NameComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InstructorNameMembersBindingSource, "Name", True))
        Me.NameComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FlightsBindingSource, "Instructor_name", True))
        Me.NameComboBox1.DataSource = Me.InstructorNameMembersBindingSource1
        Me.NameComboBox1.DisplayMember = "Name"
        Me.NameComboBox1.FormattingEnabled = True
        Me.NameComboBox1.Location = New System.Drawing.Point(146, 99)
        Me.NameComboBox1.Name = "NameComboBox1"
        Me.NameComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.NameComboBox1.TabIndex = 46
        Me.NameComboBox1.ValueMember = "Member_refnum"
        '
        'Member_refnumTextBox
        '
        Me.Member_refnumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GliderPilotNameMembersBindingSource, "Member_refnum", True))
        Me.Member_refnumTextBox.Location = New System.Drawing.Point(585, 43)
        Me.Member_refnumTextBox.Name = "Member_refnumTextBox"
        Me.Member_refnumTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Member_refnumTextBox.TabIndex = 35
        '
        'NameComboBox
        '
        Me.NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GliderPilotNameMembersBindingSource, "Name", True))
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.Location = New System.Drawing.Point(585, 69)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(121, 21)
        Me.NameComboBox.TabIndex = 37
        '
        'InstructorCheckBox
        '
        Me.InstructorCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.GliderPilotNameMembersBindingSource, "Instructor", True))
        Me.InstructorCheckBox.Location = New System.Drawing.Point(585, 96)
        Me.InstructorCheckBox.Name = "InstructorCheckBox"
        Me.InstructorCheckBox.Size = New System.Drawing.Size(121, 24)
        Me.InstructorCheckBox.TabIndex = 39
        Me.InstructorCheckBox.Text = "CheckBox1"
        Me.InstructorCheckBox.UseVisualStyleBackColor = True
        '
        'Tow_PilotCheckBox
        '
        Me.Tow_PilotCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.GliderPilotNameMembersBindingSource, "Tow Pilot", True))
        Me.Tow_PilotCheckBox.Location = New System.Drawing.Point(585, 126)
        Me.Tow_PilotCheckBox.Name = "Tow_PilotCheckBox"
        Me.Tow_PilotCheckBox.Size = New System.Drawing.Size(121, 24)
        Me.Tow_PilotCheckBox.TabIndex = 41
        Me.Tow_PilotCheckBox.Text = "CheckBox1"
        Me.Tow_PilotCheckBox.UseVisualStyleBackColor = True
        '
        'MASA_MemberCheckBox
        '
        Me.MASA_MemberCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.GliderPilotNameMembersBindingSource, "MASA_Member", True))
        Me.MASA_MemberCheckBox.Location = New System.Drawing.Point(585, 156)
        Me.MASA_MemberCheckBox.Name = "MASA_MemberCheckBox"
        Me.MASA_MemberCheckBox.Size = New System.Drawing.Size(121, 24)
        Me.MASA_MemberCheckBox.TabIndex = 43
        Me.MASA_MemberCheckBox.Text = "CheckBox1"
        Me.MASA_MemberCheckBox.UseVisualStyleBackColor = True
        '
        'Guest_MemberCheckBox
        '
        Me.Guest_MemberCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.GliderPilotNameMembersBindingSource, "Guest_Member", True))
        Me.Guest_MemberCheckBox.Location = New System.Drawing.Point(585, 186)
        Me.Guest_MemberCheckBox.Name = "Guest_MemberCheckBox"
        Me.Guest_MemberCheckBox.Size = New System.Drawing.Size(121, 24)
        Me.Guest_MemberCheckBox.TabIndex = 45
        Me.Guest_MemberCheckBox.Text = "CheckBox1"
        Me.Guest_MemberCheckBox.UseVisualStyleBackColor = True
        '
        'Flight_refnumTextBox
        '
        Me.Flight_refnumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "Flight_refnum", True))
        Me.Flight_refnumTextBox.Enabled = False
        Me.Flight_refnumTextBox.Location = New System.Drawing.Point(146, 46)
        Me.Flight_refnumTextBox.Name = "Flight_refnumTextBox"
        Me.Flight_refnumTextBox.Size = New System.Drawing.Size(76, 20)
        Me.Flight_refnumTextBox.TabIndex = 28
        '
        'Glider_Pilot_NameComboBox
        '
        Me.Glider_Pilot_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GliderPilotNameMembersBindingSource, "Name", True))
        Me.Glider_Pilot_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FlightsBindingSource, "Glider_Pilot_Name", True))
        Me.Glider_Pilot_NameComboBox.DataSource = Me.GliderPilotNameMembersBindingSource
        Me.Glider_Pilot_NameComboBox.DisplayMember = "Name"
        Me.Glider_Pilot_NameComboBox.FormattingEnabled = True
        Me.Glider_Pilot_NameComboBox.Location = New System.Drawing.Point(146, 72)
        Me.Glider_Pilot_NameComboBox.Name = "Glider_Pilot_NameComboBox"
        Me.Glider_Pilot_NameComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Glider_Pilot_NameComboBox.TabIndex = 30
        Me.Glider_Pilot_NameComboBox.ValueMember = "Member_refnum"
        '
        'Passenger_nameComboBox
        '
        Me.Passenger_nameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "Passenger_name", True))
        Me.Passenger_nameComboBox.FormattingEnabled = True
        Me.Passenger_nameComboBox.Location = New System.Drawing.Point(146, 126)
        Me.Passenger_nameComboBox.Name = "Passenger_nameComboBox"
        Me.Passenger_nameComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Passenger_nameComboBox.TabIndex = 33
        '
        'FlightsDataGridView
        '
        Me.FlightsDataGridView.AutoGenerateColumns = False
        Me.FlightsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FlightsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn27})
        Me.FlightsDataGridView.DataSource = Me.FlightsBindingSource
        Me.FlightsDataGridView.Location = New System.Drawing.Point(15, 245)
        Me.FlightsDataGridView.Name = "FlightsDataGridView"
        Me.FlightsDataGridView.Size = New System.Drawing.Size(711, 151)
        Me.FlightsDataGridView.TabIndex = 26
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Flight_refnum"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Flight_refnum"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Glider_Pilot_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Glider_Pilot_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Instructor_name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Instructor_name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Passenger_name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Passenger_name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "OD1"
        Me.DataGridViewTextBoxColumn5.HeaderText = "OD1"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "OD2"
        Me.DataGridViewTextBoxColumn6.HeaderText = "OD2"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "OD3"
        Me.DataGridViewTextBoxColumn7.HeaderText = "OD3"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "AOD1"
        Me.DataGridViewTextBoxColumn8.HeaderText = "AOD1"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "AOD2"
        Me.DataGridViewTextBoxColumn9.HeaderText = "AOD2"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "TowPilot1"
        Me.DataGridViewTextBoxColumn10.HeaderText = "TowPilot1"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "TowPilot2"
        Me.DataGridViewTextBoxColumn11.HeaderText = "TowPilot2"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "TowPilot3"
        Me.DataGridViewTextBoxColumn12.HeaderText = "TowPilot3"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "TowPlane1"
        Me.DataGridViewTextBoxColumn13.HeaderText = "TowPlane1"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "TowPlane2"
        Me.DataGridViewTextBoxColumn14.HeaderText = "TowPlane2"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Glider_takeoff_time"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Glider_takeoff_time"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Glider_landing_time"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Glider_landing_time"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Tow_takeoff_time"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Tow_takeoff_time"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Tow_landing_time"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Tow_landing_time"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Altitude_towed"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Altitude_towed"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Rope_break"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Rope_break"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Airport_name"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Airport_name"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Flight_minutes"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Flight_minutes"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "First_name_on_invoice"
        Me.DataGridViewTextBoxColumn24.HeaderText = "First_name_on_invoice"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Split_cost"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Split_cost"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Percent_1st_check"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Percent_1st_check"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "Second_name_on_invoice"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Second_name_on_invoice"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Penalty_charge"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Penalty_charge"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Cost_this_flight"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Cost_this_flight"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'FlightsBindingNavigator
        '
        Me.FlightsBindingNavigator.AddNewItem = Nothing
        Me.FlightsBindingNavigator.BindingSource = Me.FlightsBindingSource
        Me.FlightsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FlightsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FlightsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.FlightsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FlightsBindingNavigatorSaveItem})
        Me.FlightsBindingNavigator.Location = New System.Drawing.Point(38, 9)
        Me.FlightsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FlightsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FlightsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FlightsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FlightsBindingNavigator.Name = "FlightsBindingNavigator"
        Me.FlightsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FlightsBindingNavigator.Size = New System.Drawing.Size(277, 25)
        Me.FlightsBindingNavigator.TabIndex = 25
        Me.FlightsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
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
        'FlightsBindingNavigatorSaveItem
        '
        Me.FlightsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FlightsBindingNavigatorSaveItem.Image = CType(resources.GetObject("FlightsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FlightsBindingNavigatorSaveItem.Name = "FlightsBindingNavigatorSaveItem"
        Me.FlightsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.FlightsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(853, 444)
        Me.TabControl1.TabIndex = 26
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 455)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.MASA_allDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlightsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GliderPilotNameMembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstructorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstructorNameMembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstructorNameMembersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstructorDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.FlightsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlightsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlightsBindingNavigator.ResumeLayout(False)
        Me.FlightsBindingNavigator.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MASA_allDataSet As MASA_allDataSet
    Friend WithEvents FlightsBindingSource As BindingSource
    Friend WithEvents FlightsTableAdapter As MASA_allDataSetTableAdapters.FlightsTableAdapter
    Friend WithEvents FlightsTableAdapterManager As MASA_allDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GliderPilotNameMembersTableAdapter As MASA_allDataSetTableAdapters.MembersTableAdapter
    Friend WithEvents GliderPilotNameMembersBindingSource As BindingSource
    Friend WithEvents InstructorDataSet As InstructorDataSet
    Friend WithEvents InstructorNameMembersBindingSource As BindingSource
    Friend WithEvents InstructorNameMembersTableAdapter As InstructorDataSetTableAdapters.MembersTableAdapter
    Friend WithEvents InstructorNameTableAdapterManager As InstructorDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InstructorNameMembersBindingSource1 As BindingSource
    Friend WithEvents InstructorDataSetBindingSource As BindingSource
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents NameComboBox1 As ComboBox
    Friend WithEvents Member_refnumTextBox As TextBox
    Friend WithEvents NameComboBox As ComboBox
    Friend WithEvents InstructorCheckBox As CheckBox
    Friend WithEvents Tow_PilotCheckBox As CheckBox
    Friend WithEvents MASA_MemberCheckBox As CheckBox
    Friend WithEvents Guest_MemberCheckBox As CheckBox
    Friend WithEvents Flight_refnumTextBox As TextBox
    Friend WithEvents Glider_Pilot_NameComboBox As ComboBox
    Friend WithEvents Passenger_nameComboBox As ComboBox
    Friend WithEvents FlightsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents FlightsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents FlightsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
End Class
