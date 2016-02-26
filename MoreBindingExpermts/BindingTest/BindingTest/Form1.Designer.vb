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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim Flight_refnumLabel As System.Windows.Forms.Label
        Dim Glider_Pilot_NameLabel As System.Windows.Forms.Label
        Dim Instructor_nameLabel As System.Windows.Forms.Label
        Dim Passenger_nameLabel As System.Windows.Forms.Label
        Dim Member_refnumLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim InstructorLabel As System.Windows.Forms.Label
        Dim Tow_PilotLabel As System.Windows.Forms.Label
        Dim MASA_MemberLabel As System.Windows.Forms.Label
        Dim Guest_MemberLabel As System.Windows.Forms.Label
        Dim Member_refnumLabel1 As System.Windows.Forms.Label
        Dim NameLabel1 As System.Windows.Forms.Label
        Dim InstructorLabel1 As System.Windows.Forms.Label
        Dim Tow_PilotLabel1 As System.Windows.Forms.Label
        Dim MASA_MemberLabel1 As System.Windows.Forms.Label
        Dim Guest_MemberLabel1 As System.Windows.Forms.Label
        Me.AddFlights = New BindingTest.AddFlights()
        Me.FlightsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlightsTableAdapter = New BindingTest.AddFlightsTableAdapters.FlightsTableAdapter()
        Me.TableAdapterManager = New BindingTest.AddFlightsTableAdapters.TableAdapterManager()
        Me.FlightsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.FlightsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Flight_refnumTextBox = New System.Windows.Forms.TextBox()
        Me.Glider_Pilot_NameComboBox = New System.Windows.Forms.ComboBox()
        Me.Instructor_nameComboBox = New System.Windows.Forms.ComboBox()
        Me.Passenger_nameComboBox = New System.Windows.Forms.ComboBox()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MembersTableAdapter = New BindingTest.AddFlightsTableAdapters.MembersTableAdapter()
        Me.Member_refnumTextBox = New System.Windows.Forms.TextBox()
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Me.InstructorCheckBox = New System.Windows.Forms.CheckBox()
        Me.Tow_PilotCheckBox = New System.Windows.Forms.CheckBox()
        Me.MASA_MemberCheckBox = New System.Windows.Forms.CheckBox()
        Me.Guest_MemberCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Member_refnumTextBox1 = New System.Windows.Forms.TextBox()
        Me.NameComboBox1 = New System.Windows.Forms.ComboBox()
        Me.InstructorCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Tow_PilotCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.MASA_MemberCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Guest_MemberCheckBox1 = New System.Windows.Forms.CheckBox()
        Flight_refnumLabel = New System.Windows.Forms.Label()
        Glider_Pilot_NameLabel = New System.Windows.Forms.Label()
        Instructor_nameLabel = New System.Windows.Forms.Label()
        Passenger_nameLabel = New System.Windows.Forms.Label()
        Member_refnumLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        InstructorLabel = New System.Windows.Forms.Label()
        Tow_PilotLabel = New System.Windows.Forms.Label()
        MASA_MemberLabel = New System.Windows.Forms.Label()
        Guest_MemberLabel = New System.Windows.Forms.Label()
        Member_refnumLabel1 = New System.Windows.Forms.Label()
        NameLabel1 = New System.Windows.Forms.Label()
        InstructorLabel1 = New System.Windows.Forms.Label()
        Tow_PilotLabel1 = New System.Windows.Forms.Label()
        MASA_MemberLabel1 = New System.Windows.Forms.Label()
        Guest_MemberLabel1 = New System.Windows.Forms.Label()
        CType(Me.AddFlights, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlightsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlightsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlightsBindingNavigator.SuspendLayout()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddFlights
        '
        Me.AddFlights.DataSetName = "AddFlights"
        Me.AddFlights.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FlightsBindingSource
        '
        Me.FlightsBindingSource.DataMember = "Flights"
        Me.FlightsBindingSource.DataSource = Me.AddFlights
        '
        'FlightsTableAdapter
        '
        Me.FlightsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AircraftTableAdapter = Nothing
        Me.TableAdapterManager.AirportTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FlightsTableAdapter = Me.FlightsTableAdapter
        Me.TableAdapterManager.MembersTableAdapter = Me.MembersTableAdapter
        Me.TableAdapterManager.UpdateOrder = BindingTest.AddFlightsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FlightsBindingNavigator
        '
        Me.FlightsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FlightsBindingNavigator.BindingSource = Me.FlightsBindingSource
        Me.FlightsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FlightsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FlightsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FlightsBindingNavigatorSaveItem})
        Me.FlightsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FlightsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FlightsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FlightsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FlightsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FlightsBindingNavigator.Name = "FlightsBindingNavigator"
        Me.FlightsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FlightsBindingNavigator.Size = New System.Drawing.Size(1096, 25)
        Me.FlightsBindingNavigator.TabIndex = 0
        Me.FlightsBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'FlightsBindingNavigatorSaveItem
        '
        Me.FlightsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FlightsBindingNavigatorSaveItem.Image = CType(resources.GetObject("FlightsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FlightsBindingNavigatorSaveItem.Name = "FlightsBindingNavigatorSaveItem"
        Me.FlightsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.FlightsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Flight_refnumLabel
        '
        Flight_refnumLabel.AutoSize = True
        Flight_refnumLabel.Location = New System.Drawing.Point(276, 86)
        Flight_refnumLabel.Name = "Flight_refnumLabel"
        Flight_refnumLabel.Size = New System.Drawing.Size(70, 13)
        Flight_refnumLabel.TabIndex = 1
        Flight_refnumLabel.Text = "Flight refnum:"
        '
        'Flight_refnumTextBox
        '
        Me.Flight_refnumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "Flight_refnum", True))
        Me.Flight_refnumTextBox.Location = New System.Drawing.Point(410, 83)
        Me.Flight_refnumTextBox.Name = "Flight_refnumTextBox"
        Me.Flight_refnumTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Flight_refnumTextBox.TabIndex = 2
        '
        'Glider_Pilot_NameLabel
        '
        Glider_Pilot_NameLabel.AutoSize = True
        Glider_Pilot_NameLabel.Location = New System.Drawing.Point(276, 112)
        Glider_Pilot_NameLabel.Name = "Glider_Pilot_NameLabel"
        Glider_Pilot_NameLabel.Size = New System.Drawing.Size(91, 13)
        Glider_Pilot_NameLabel.TabIndex = 3
        Glider_Pilot_NameLabel.Text = "Glider Pilot Name:"
        '
        'Glider_Pilot_NameComboBox
        '
        Me.Glider_Pilot_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "Glider_Pilot_Name", True))
        Me.Glider_Pilot_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FlightsBindingSource, "Glider_Pilot_Name", True))
        Me.Glider_Pilot_NameComboBox.DataSource = Me.MembersBindingSource
        Me.Glider_Pilot_NameComboBox.DisplayMember = "Name"
        Me.Glider_Pilot_NameComboBox.FormattingEnabled = True
        Me.Glider_Pilot_NameComboBox.Location = New System.Drawing.Point(410, 109)
        Me.Glider_Pilot_NameComboBox.Name = "Glider_Pilot_NameComboBox"
        Me.Glider_Pilot_NameComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Glider_Pilot_NameComboBox.TabIndex = 4
        Me.Glider_Pilot_NameComboBox.ValueMember = "Member_refnum"
        '
        'Instructor_nameLabel
        '
        Instructor_nameLabel.AutoSize = True
        Instructor_nameLabel.Location = New System.Drawing.Point(276, 139)
        Instructor_nameLabel.Name = "Instructor_nameLabel"
        Instructor_nameLabel.Size = New System.Drawing.Size(83, 13)
        Instructor_nameLabel.TabIndex = 5
        Instructor_nameLabel.Text = "Instructor name:"
        '
        'Instructor_nameComboBox
        '
        Me.Instructor_nameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "Instructor_name", True))
        Me.Instructor_nameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FlightsBindingSource, "Instructor_name", True))
        Me.Instructor_nameComboBox.DataSource = Me.MembersBindingSource
        Me.Instructor_nameComboBox.DisplayMember = "Name"
        Me.Instructor_nameComboBox.FormattingEnabled = True
        Me.Instructor_nameComboBox.Location = New System.Drawing.Point(410, 136)
        Me.Instructor_nameComboBox.Name = "Instructor_nameComboBox"
        Me.Instructor_nameComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Instructor_nameComboBox.TabIndex = 6
        Me.Instructor_nameComboBox.ValueMember = "Member_refnum"
        '
        'Passenger_nameLabel
        '
        Passenger_nameLabel.AutoSize = True
        Passenger_nameLabel.Location = New System.Drawing.Point(276, 166)
        Passenger_nameLabel.Name = "Passenger_nameLabel"
        Passenger_nameLabel.Size = New System.Drawing.Size(89, 13)
        Passenger_nameLabel.TabIndex = 7
        Passenger_nameLabel.Text = "Passenger name:"
        '
        'Passenger_nameComboBox
        '
        Me.Passenger_nameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "Passenger_name", True))
        Me.Passenger_nameComboBox.FormattingEnabled = True
        Me.Passenger_nameComboBox.Location = New System.Drawing.Point(410, 163)
        Me.Passenger_nameComboBox.Name = "Passenger_nameComboBox"
        Me.Passenger_nameComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Passenger_nameComboBox.TabIndex = 8
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "Members"
        Me.MembersBindingSource.DataSource = Me.AddFlights
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'Member_refnumLabel
        '
        Member_refnumLabel.AutoSize = True
        Member_refnumLabel.Location = New System.Drawing.Point(93, 297)
        Member_refnumLabel.Name = "Member_refnumLabel"
        Member_refnumLabel.Size = New System.Drawing.Size(83, 13)
        Member_refnumLabel.TabIndex = 9
        Member_refnumLabel.Text = "Member refnum:"
        '
        'Member_refnumTextBox
        '
        Me.Member_refnumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "Member_refnum", True))
        Me.Member_refnumTextBox.Location = New System.Drawing.Point(182, 294)
        Me.Member_refnumTextBox.Name = "Member_refnumTextBox"
        Me.Member_refnumTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Member_refnumTextBox.TabIndex = 10
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(93, 323)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 11
        NameLabel.Text = "Name:"
        '
        'NameComboBox
        '
        Me.NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "Name", True))
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.Location = New System.Drawing.Point(182, 320)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(121, 21)
        Me.NameComboBox.TabIndex = 12
        '
        'InstructorLabel
        '
        InstructorLabel.AutoSize = True
        InstructorLabel.Location = New System.Drawing.Point(93, 352)
        InstructorLabel.Name = "InstructorLabel"
        InstructorLabel.Size = New System.Drawing.Size(54, 13)
        InstructorLabel.TabIndex = 13
        InstructorLabel.Text = "Instructor:"
        '
        'InstructorCheckBox
        '
        Me.InstructorCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MembersBindingSource, "Instructor", True))
        Me.InstructorCheckBox.Location = New System.Drawing.Point(182, 347)
        Me.InstructorCheckBox.Name = "InstructorCheckBox"
        Me.InstructorCheckBox.Size = New System.Drawing.Size(121, 24)
        Me.InstructorCheckBox.TabIndex = 14
        Me.InstructorCheckBox.Text = "CheckBox1"
        Me.InstructorCheckBox.UseVisualStyleBackColor = True
        '
        'Tow_PilotLabel
        '
        Tow_PilotLabel.AutoSize = True
        Tow_PilotLabel.Location = New System.Drawing.Point(93, 382)
        Tow_PilotLabel.Name = "Tow_PilotLabel"
        Tow_PilotLabel.Size = New System.Drawing.Size(54, 13)
        Tow_PilotLabel.TabIndex = 15
        Tow_PilotLabel.Text = "Tow Pilot:"
        '
        'Tow_PilotCheckBox
        '
        Me.Tow_PilotCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MembersBindingSource, "Tow Pilot", True))
        Me.Tow_PilotCheckBox.Location = New System.Drawing.Point(182, 377)
        Me.Tow_PilotCheckBox.Name = "Tow_PilotCheckBox"
        Me.Tow_PilotCheckBox.Size = New System.Drawing.Size(121, 24)
        Me.Tow_PilotCheckBox.TabIndex = 16
        Me.Tow_PilotCheckBox.Text = "CheckBox1"
        Me.Tow_PilotCheckBox.UseVisualStyleBackColor = True
        '
        'MASA_MemberLabel
        '
        MASA_MemberLabel.AutoSize = True
        MASA_MemberLabel.Location = New System.Drawing.Point(93, 412)
        MASA_MemberLabel.Name = "MASA_MemberLabel"
        MASA_MemberLabel.Size = New System.Drawing.Size(81, 13)
        MASA_MemberLabel.TabIndex = 17
        MASA_MemberLabel.Text = "MASA Member:"
        '
        'MASA_MemberCheckBox
        '
        Me.MASA_MemberCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MembersBindingSource, "MASA_Member", True))
        Me.MASA_MemberCheckBox.Location = New System.Drawing.Point(182, 407)
        Me.MASA_MemberCheckBox.Name = "MASA_MemberCheckBox"
        Me.MASA_MemberCheckBox.Size = New System.Drawing.Size(121, 24)
        Me.MASA_MemberCheckBox.TabIndex = 18
        Me.MASA_MemberCheckBox.Text = "CheckBox1"
        Me.MASA_MemberCheckBox.UseVisualStyleBackColor = True
        '
        'Guest_MemberLabel
        '
        Guest_MemberLabel.AutoSize = True
        Guest_MemberLabel.Location = New System.Drawing.Point(93, 442)
        Guest_MemberLabel.Name = "Guest_MemberLabel"
        Guest_MemberLabel.Size = New System.Drawing.Size(79, 13)
        Guest_MemberLabel.TabIndex = 19
        Guest_MemberLabel.Text = "Guest Member:"
        '
        'Guest_MemberCheckBox
        '
        Me.Guest_MemberCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MembersBindingSource, "Guest_Member", True))
        Me.Guest_MemberCheckBox.Location = New System.Drawing.Point(182, 437)
        Me.Guest_MemberCheckBox.Name = "Guest_MemberCheckBox"
        Me.Guest_MemberCheckBox.Size = New System.Drawing.Size(121, 24)
        Me.Guest_MemberCheckBox.TabIndex = 20
        Me.Guest_MemberCheckBox.Text = "CheckBox1"
        Me.Guest_MemberCheckBox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(407, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "This column was dragged fm AddFlights data source"
        '
        'Member_refnumLabel1
        '
        Member_refnumLabel1.AutoSize = True
        Member_refnumLabel1.Location = New System.Drawing.Point(423, 295)
        Member_refnumLabel1.Name = "Member_refnumLabel1"
        Member_refnumLabel1.Size = New System.Drawing.Size(83, 13)
        Member_refnumLabel1.TabIndex = 22
        Member_refnumLabel1.Text = "Member refnum:"
        '
        'Member_refnumTextBox1
        '
        Me.Member_refnumTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "Member_refnum", True))
        Me.Member_refnumTextBox1.Location = New System.Drawing.Point(512, 292)
        Me.Member_refnumTextBox1.Name = "Member_refnumTextBox1"
        Me.Member_refnumTextBox1.Size = New System.Drawing.Size(121, 20)
        Me.Member_refnumTextBox1.TabIndex = 23
        '
        'NameLabel1
        '
        NameLabel1.AutoSize = True
        NameLabel1.Location = New System.Drawing.Point(423, 321)
        NameLabel1.Name = "NameLabel1"
        NameLabel1.Size = New System.Drawing.Size(38, 13)
        NameLabel1.TabIndex = 24
        NameLabel1.Text = "Name:"
        '
        'NameComboBox1
        '
        Me.NameComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "Name", True))
        Me.NameComboBox1.FormattingEnabled = True
        Me.NameComboBox1.Location = New System.Drawing.Point(512, 318)
        Me.NameComboBox1.Name = "NameComboBox1"
        Me.NameComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.NameComboBox1.TabIndex = 25
        '
        'InstructorLabel1
        '
        InstructorLabel1.AutoSize = True
        InstructorLabel1.Location = New System.Drawing.Point(423, 350)
        InstructorLabel1.Name = "InstructorLabel1"
        InstructorLabel1.Size = New System.Drawing.Size(54, 13)
        InstructorLabel1.TabIndex = 26
        InstructorLabel1.Text = "Instructor:"
        '
        'InstructorCheckBox1
        '
        Me.InstructorCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MembersBindingSource, "Instructor", True))
        Me.InstructorCheckBox1.Location = New System.Drawing.Point(512, 345)
        Me.InstructorCheckBox1.Name = "InstructorCheckBox1"
        Me.InstructorCheckBox1.Size = New System.Drawing.Size(121, 24)
        Me.InstructorCheckBox1.TabIndex = 27
        Me.InstructorCheckBox1.Text = "CheckBox1"
        Me.InstructorCheckBox1.UseVisualStyleBackColor = True
        '
        'Tow_PilotLabel1
        '
        Tow_PilotLabel1.AutoSize = True
        Tow_PilotLabel1.Location = New System.Drawing.Point(423, 380)
        Tow_PilotLabel1.Name = "Tow_PilotLabel1"
        Tow_PilotLabel1.Size = New System.Drawing.Size(54, 13)
        Tow_PilotLabel1.TabIndex = 28
        Tow_PilotLabel1.Text = "Tow Pilot:"
        '
        'Tow_PilotCheckBox1
        '
        Me.Tow_PilotCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MembersBindingSource, "Tow Pilot", True))
        Me.Tow_PilotCheckBox1.Location = New System.Drawing.Point(512, 375)
        Me.Tow_PilotCheckBox1.Name = "Tow_PilotCheckBox1"
        Me.Tow_PilotCheckBox1.Size = New System.Drawing.Size(121, 24)
        Me.Tow_PilotCheckBox1.TabIndex = 29
        Me.Tow_PilotCheckBox1.Text = "CheckBox1"
        Me.Tow_PilotCheckBox1.UseVisualStyleBackColor = True
        '
        'MASA_MemberLabel1
        '
        MASA_MemberLabel1.AutoSize = True
        MASA_MemberLabel1.Location = New System.Drawing.Point(423, 410)
        MASA_MemberLabel1.Name = "MASA_MemberLabel1"
        MASA_MemberLabel1.Size = New System.Drawing.Size(81, 13)
        MASA_MemberLabel1.TabIndex = 30
        MASA_MemberLabel1.Text = "MASA Member:"
        '
        'MASA_MemberCheckBox1
        '
        Me.MASA_MemberCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MembersBindingSource, "MASA_Member", True))
        Me.MASA_MemberCheckBox1.Location = New System.Drawing.Point(512, 405)
        Me.MASA_MemberCheckBox1.Name = "MASA_MemberCheckBox1"
        Me.MASA_MemberCheckBox1.Size = New System.Drawing.Size(121, 24)
        Me.MASA_MemberCheckBox1.TabIndex = 31
        Me.MASA_MemberCheckBox1.Text = "CheckBox1"
        Me.MASA_MemberCheckBox1.UseVisualStyleBackColor = True
        '
        'Guest_MemberLabel1
        '
        Guest_MemberLabel1.AutoSize = True
        Guest_MemberLabel1.Location = New System.Drawing.Point(423, 440)
        Guest_MemberLabel1.Name = "Guest_MemberLabel1"
        Guest_MemberLabel1.Size = New System.Drawing.Size(79, 13)
        Guest_MemberLabel1.TabIndex = 32
        Guest_MemberLabel1.Text = "Guest Member:"
        '
        'Guest_MemberCheckBox1
        '
        Me.Guest_MemberCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MembersBindingSource, "Guest_Member", True))
        Me.Guest_MemberCheckBox1.Location = New System.Drawing.Point(512, 435)
        Me.Guest_MemberCheckBox1.Name = "Guest_MemberCheckBox1"
        Me.Guest_MemberCheckBox1.Size = New System.Drawing.Size(121, 24)
        Me.Guest_MemberCheckBox1.TabIndex = 33
        Me.Guest_MemberCheckBox1.Text = "CheckBox1"
        Me.Guest_MemberCheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1096, 1045)
        Me.Controls.Add(Member_refnumLabel1)
        Me.Controls.Add(Me.Member_refnumTextBox1)
        Me.Controls.Add(NameLabel1)
        Me.Controls.Add(Me.NameComboBox1)
        Me.Controls.Add(InstructorLabel1)
        Me.Controls.Add(Me.InstructorCheckBox1)
        Me.Controls.Add(Tow_PilotLabel1)
        Me.Controls.Add(Me.Tow_PilotCheckBox1)
        Me.Controls.Add(MASA_MemberLabel1)
        Me.Controls.Add(Me.MASA_MemberCheckBox1)
        Me.Controls.Add(Guest_MemberLabel1)
        Me.Controls.Add(Me.Guest_MemberCheckBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Member_refnumLabel)
        Me.Controls.Add(Me.Member_refnumTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameComboBox)
        Me.Controls.Add(InstructorLabel)
        Me.Controls.Add(Me.InstructorCheckBox)
        Me.Controls.Add(Tow_PilotLabel)
        Me.Controls.Add(Me.Tow_PilotCheckBox)
        Me.Controls.Add(MASA_MemberLabel)
        Me.Controls.Add(Me.MASA_MemberCheckBox)
        Me.Controls.Add(Guest_MemberLabel)
        Me.Controls.Add(Me.Guest_MemberCheckBox)
        Me.Controls.Add(Flight_refnumLabel)
        Me.Controls.Add(Me.Flight_refnumTextBox)
        Me.Controls.Add(Glider_Pilot_NameLabel)
        Me.Controls.Add(Me.Glider_Pilot_NameComboBox)
        Me.Controls.Add(Instructor_nameLabel)
        Me.Controls.Add(Me.Instructor_nameComboBox)
        Me.Controls.Add(Passenger_nameLabel)
        Me.Controls.Add(Me.Passenger_nameComboBox)
        Me.Controls.Add(Me.FlightsBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AddFlights, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlightsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlightsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlightsBindingNavigator.ResumeLayout(False)
        Me.FlightsBindingNavigator.PerformLayout()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddFlights As AddFlights
    Friend WithEvents FlightsBindingSource As BindingSource
    Friend WithEvents FlightsTableAdapter As AddFlightsTableAdapters.FlightsTableAdapter
    Friend WithEvents TableAdapterManager As AddFlightsTableAdapters.TableAdapterManager
    Friend WithEvents FlightsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
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
    Friend WithEvents MembersTableAdapter As AddFlightsTableAdapters.MembersTableAdapter
    Friend WithEvents Flight_refnumTextBox As TextBox
    Friend WithEvents Glider_Pilot_NameComboBox As ComboBox
    Friend WithEvents Instructor_nameComboBox As ComboBox
    Friend WithEvents Passenger_nameComboBox As ComboBox
    Friend WithEvents MembersBindingSource As BindingSource
    Friend WithEvents Member_refnumTextBox As TextBox
    Friend WithEvents NameComboBox As ComboBox
    Friend WithEvents InstructorCheckBox As CheckBox
    Friend WithEvents Tow_PilotCheckBox As CheckBox
    Friend WithEvents MASA_MemberCheckBox As CheckBox
    Friend WithEvents Guest_MemberCheckBox As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Member_refnumTextBox1 As TextBox
    Friend WithEvents NameComboBox1 As ComboBox
    Friend WithEvents InstructorCheckBox1 As CheckBox
    Friend WithEvents Tow_PilotCheckBox1 As CheckBox
    Friend WithEvents MASA_MemberCheckBox1 As CheckBox
    Friend WithEvents Guest_MemberCheckBox1 As CheckBox
End Class
