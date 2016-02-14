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
        Dim Passenger_nameLabel As System.Windows.Forms.Label
        Dim TowPilot1Label As System.Windows.Forms.Label
        Dim TowPilot2Label As System.Windows.Forms.Label
        Dim TowPilot3Label As System.Windows.Forms.Label
        Dim TowPlane1Label As System.Windows.Forms.Label
        Dim TowPlane2Label As System.Windows.Forms.Label
        Dim Altitude_towedLabel As System.Windows.Forms.Label
        Dim Flight_minutesLabel As System.Windows.Forms.Label
        Dim First_name_on_invoiceLabel As System.Windows.Forms.Label
        Dim Split_costLabel As System.Windows.Forms.Label
        Dim Second_name_on_invoiceLabel As System.Windows.Forms.Label
        Dim Penalty_chargeLabel As System.Windows.Forms.Label
        Dim Cost_this_flightLabel As System.Windows.Forms.Label
        Dim Rope_breakLabel1 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim NameLabel1 As System.Windows.Forms.Label
        Dim Percent_1st_checkLabel1 As System.Windows.Forms.Label
        Me.Glider_takeoff_timeLabel = New System.Windows.Forms.Label()
        Me.Glider_landing_timeLabel = New System.Windows.Forms.Label()
        Me.Tow_takeoff_timeLabel = New System.Windows.Forms.Label()
        Me.Tow_landing_timeLabel = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.OD2ComboBox = New System.Windows.Forms.ComboBox()
        Me.MembersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MASA_allDataSet = New Masa_Ver1.MASA_allDataSet()
        Me.ODComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Rope_breakCheckBox = New System.Windows.Forms.CheckBox()
        Me.FlightsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Glider_takeoff_timeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Glider_landing_timeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Tow_takeoff_timeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Tow_landing_timeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Altitude_towedTextBox = New System.Windows.Forms.TextBox()
        Me.Flight_minutesTextBox = New System.Windows.Forms.TextBox()
        Me.Split_costCheckBox = New System.Windows.Forms.CheckBox()
        Me.Percent_1st_checkTextBox = New System.Windows.Forms.TextBox()
        Me.Penalty_chargeCheckBox = New System.Windows.Forms.CheckBox()
        Me.Cost_this_flightTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.AircraftBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AircraftTableAdapter = New Masa_Ver1.MASA_allDataSetTableAdapters.AircraftTableAdapter()
        Me.TableAdapterManager = New Masa_Ver1.MASA_allDataSetTableAdapters.TableAdapterManager()
        Me.MembersTableAdapter = New Masa_Ver1.MASA_allDataSetTableAdapters.MembersTableAdapter()
        Me.FlightsTableAdapter = New Masa_Ver1.MASA_allDataSetTableAdapters.FlightsTableAdapter()
        Me.MembersBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MembersBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InstructorNameComboBox2 = New System.Windows.Forms.ComboBox()
        Me.GliderPilotComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MembersBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FirstInvoiceNameComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MembersBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Percent_1st_checkTextBox1 = New System.Windows.Forms.TextBox()
        Passenger_nameLabel = New System.Windows.Forms.Label()
        TowPilot1Label = New System.Windows.Forms.Label()
        TowPilot2Label = New System.Windows.Forms.Label()
        TowPilot3Label = New System.Windows.Forms.Label()
        TowPlane1Label = New System.Windows.Forms.Label()
        TowPlane2Label = New System.Windows.Forms.Label()
        Altitude_towedLabel = New System.Windows.Forms.Label()
        Flight_minutesLabel = New System.Windows.Forms.Label()
        First_name_on_invoiceLabel = New System.Windows.Forms.Label()
        Split_costLabel = New System.Windows.Forms.Label()
        Second_name_on_invoiceLabel = New System.Windows.Forms.Label()
        Penalty_chargeLabel = New System.Windows.Forms.Label()
        Cost_this_flightLabel = New System.Windows.Forms.Label()
        Rope_breakLabel1 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        NameLabel1 = New System.Windows.Forms.Label()
        Percent_1st_checkLabel1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.MembersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MASA_allDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.FlightsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AircraftBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Passenger_nameLabel
        '
        Passenger_nameLabel.AutoSize = True
        Passenger_nameLabel.Location = New System.Drawing.Point(29, 97)
        Passenger_nameLabel.Name = "Passenger_nameLabel"
        Passenger_nameLabel.Size = New System.Drawing.Size(173, 24)
        Passenger_nameLabel.TabIndex = 6
        Passenger_nameLabel.Text = "Passenger name:"
        '
        'TowPilot1Label
        '
        TowPilot1Label.AutoSize = True
        TowPilot1Label.Location = New System.Drawing.Point(29, 136)
        TowPilot1Label.Name = "TowPilot1Label"
        TowPilot1Label.Size = New System.Drawing.Size(113, 24)
        TowPilot1Label.TabIndex = 18
        TowPilot1Label.Text = "Tow Pilot1:"
        '
        'TowPilot2Label
        '
        TowPilot2Label.AutoSize = True
        TowPilot2Label.Location = New System.Drawing.Point(29, 171)
        TowPilot2Label.Name = "TowPilot2Label"
        TowPilot2Label.Size = New System.Drawing.Size(113, 24)
        TowPilot2Label.TabIndex = 20
        TowPilot2Label.Text = "Tow Pilot2:"
        '
        'TowPilot3Label
        '
        TowPilot3Label.AutoSize = True
        TowPilot3Label.Location = New System.Drawing.Point(29, 206)
        TowPilot3Label.Name = "TowPilot3Label"
        TowPilot3Label.Size = New System.Drawing.Size(113, 24)
        TowPilot3Label.TabIndex = 22
        TowPilot3Label.Text = "Tow Pilot3:"
        '
        'TowPlane1Label
        '
        TowPlane1Label.AutoSize = True
        TowPlane1Label.Location = New System.Drawing.Point(29, 241)
        TowPlane1Label.Name = "TowPlane1Label"
        TowPlane1Label.Size = New System.Drawing.Size(126, 24)
        TowPlane1Label.TabIndex = 24
        TowPlane1Label.Text = "Tow Plane1:"
        '
        'TowPlane2Label
        '
        TowPlane2Label.AutoSize = True
        TowPlane2Label.Location = New System.Drawing.Point(29, 276)
        TowPlane2Label.Name = "TowPlane2Label"
        TowPlane2Label.Size = New System.Drawing.Size(126, 24)
        TowPlane2Label.TabIndex = 26
        TowPlane2Label.Text = "Tow Plane2:"
        '
        'Altitude_towedLabel
        '
        Altitude_towedLabel.AutoSize = True
        Altitude_towedLabel.Location = New System.Drawing.Point(549, 98)
        Altitude_towedLabel.Name = "Altitude_towedLabel"
        Altitude_towedLabel.Size = New System.Drawing.Size(148, 24)
        Altitude_towedLabel.TabIndex = 38
        Altitude_towedLabel.Text = "Altitude towed:"
        '
        'Flight_minutesLabel
        '
        Flight_minutesLabel.AutoSize = True
        Flight_minutesLabel.Location = New System.Drawing.Point(552, 444)
        Flight_minutesLabel.Name = "Flight_minutesLabel"
        Flight_minutesLabel.Size = New System.Drawing.Size(147, 24)
        Flight_minutesLabel.TabIndex = 44
        Flight_minutesLabel.Text = "Flight minutes:"
        '
        'First_name_on_invoiceLabel
        '
        First_name_on_invoiceLabel.AutoSize = True
        First_name_on_invoiceLabel.Location = New System.Drawing.Point(549, 238)
        First_name_on_invoiceLabel.Name = "First_name_on_invoiceLabel"
        First_name_on_invoiceLabel.Size = New System.Drawing.Size(217, 24)
        First_name_on_invoiceLabel.TabIndex = 46
        First_name_on_invoiceLabel.Text = "First name on invoice:"
        '
        'Split_costLabel
        '
        Split_costLabel.AutoSize = True
        Split_costLabel.Location = New System.Drawing.Point(549, 275)
        Split_costLabel.Name = "Split_costLabel"
        Split_costLabel.Size = New System.Drawing.Size(100, 24)
        Split_costLabel.TabIndex = 48
        Split_costLabel.Text = "Split cost:"
        '
        'Second_name_on_invoiceLabel
        '
        Second_name_on_invoiceLabel.AutoSize = True
        Second_name_on_invoiceLabel.Location = New System.Drawing.Point(549, 343)
        Second_name_on_invoiceLabel.Name = "Second_name_on_invoiceLabel"
        Second_name_on_invoiceLabel.Size = New System.Drawing.Size(249, 24)
        Second_name_on_invoiceLabel.TabIndex = 52
        Second_name_on_invoiceLabel.Text = "Second name on invoice:"
        '
        'Penalty_chargeLabel
        '
        Penalty_chargeLabel.AutoSize = True
        Penalty_chargeLabel.Location = New System.Drawing.Point(553, 171)
        Penalty_chargeLabel.Name = "Penalty_chargeLabel"
        Penalty_chargeLabel.Size = New System.Drawing.Size(207, 24)
        Penalty_chargeLabel.TabIndex = 54
        Penalty_chargeLabel.Text = "Kept Rental Too long"
        '
        'Cost_this_flightLabel
        '
        Cost_this_flightLabel.AutoSize = True
        Cost_this_flightLabel.Location = New System.Drawing.Point(552, 483)
        Cost_this_flightLabel.Name = "Cost_this_flightLabel"
        Cost_this_flightLabel.Size = New System.Drawing.Size(145, 24)
        Cost_this_flightLabel.TabIndex = 56
        Cost_this_flightLabel.Text = "Cost this flight:"
        '
        'Rope_breakLabel1
        '
        Rope_breakLabel1.AutoSize = True
        Rope_breakLabel1.Location = New System.Drawing.Point(553, 138)
        Rope_breakLabel1.Name = "Rope_breakLabel1"
        Rope_breakLabel1.Size = New System.Drawing.Size(124, 24)
        Rope_breakLabel1.TabIndex = 57
        Rope_breakLabel1.Text = "Rope break:"
        '
        'Label14
        '
        Label14.Location = New System.Drawing.Point(0, 0)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(100, 23)
        Label14.TabIndex = 62
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(29, 21)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(179, 24)
        NameLabel.TabIndex = 59
        NameLabel.Text = "Glider Pilot Name:"
        '
        'NameLabel1
        '
        NameLabel1.AutoSize = True
        NameLabel1.Location = New System.Drawing.Point(29, 60)
        NameLabel1.Name = "NameLabel1"
        NameLabel1.Size = New System.Drawing.Size(163, 24)
        NameLabel1.TabIndex = 60
        NameLabel1.Text = "Instructor Name:"
        '
        'Glider_takeoff_timeLabel
        '
        Me.Glider_takeoff_timeLabel.AutoSize = True
        Me.Glider_takeoff_timeLabel.Location = New System.Drawing.Point(22, 347)
        Me.Glider_takeoff_timeLabel.Name = "Glider_takeoff_timeLabel"
        Me.Glider_takeoff_timeLabel.Size = New System.Drawing.Size(183, 24)
        Me.Glider_takeoff_timeLabel.TabIndex = 30
        Me.Glider_takeoff_timeLabel.Text = "Glider takeoff time:"
        '
        'Glider_landing_timeLabel
        '
        Me.Glider_landing_timeLabel.AutoSize = True
        Me.Glider_landing_timeLabel.Location = New System.Drawing.Point(20, 382)
        Me.Glider_landing_timeLabel.Name = "Glider_landing_timeLabel"
        Me.Glider_landing_timeLabel.Size = New System.Drawing.Size(192, 24)
        Me.Glider_landing_timeLabel.TabIndex = 32
        Me.Glider_landing_timeLabel.Text = "Glider landing time:"
        '
        'Tow_takeoff_timeLabel
        '
        Me.Tow_takeoff_timeLabel.AutoSize = True
        Me.Tow_takeoff_timeLabel.Location = New System.Drawing.Point(549, 29)
        Me.Tow_takeoff_timeLabel.Name = "Tow_takeoff_timeLabel"
        Me.Tow_takeoff_timeLabel.Size = New System.Drawing.Size(167, 24)
        Me.Tow_takeoff_timeLabel.TabIndex = 34
        Me.Tow_takeoff_timeLabel.Text = "Tow takeoff time:"
        '
        'Tow_landing_timeLabel
        '
        Me.Tow_landing_timeLabel.AutoSize = True
        Me.Tow_landing_timeLabel.Location = New System.Drawing.Point(549, 64)
        Me.Tow_landing_timeLabel.Name = "Tow_landing_timeLabel"
        Me.Tow_landing_timeLabel.Size = New System.Drawing.Size(176, 24)
        Me.Tow_landing_timeLabel.TabIndex = 36
        Me.Tow_landing_timeLabel.Text = "Tow landing time:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(20, 37)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(265, 26)
        Me.DateTimePicker1.TabIndex = 0
        Me.DateTimePicker1.Value = New Date(2016, 2, 13, 18, 41, 42, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Operations Director"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(73, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1191, 638)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.OD2ComboBox)
        Me.TabPage1.Controls.Add(Me.ODComboBox1)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.DateTimePicker1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 33)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1183, 601)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "OD/AOD/Tow Pilot Info"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'OD2ComboBox
        '
        Me.OD2ComboBox.DataSource = Me.MembersBindingSource1
        Me.OD2ComboBox.DisplayMember = "Name"
        Me.OD2ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OD2ComboBox.FormattingEnabled = True
        Me.OD2ComboBox.Location = New System.Drawing.Point(20, 166)
        Me.OD2ComboBox.Name = "OD2ComboBox"
        Me.OD2ComboBox.Size = New System.Drawing.Size(300, 28)
        Me.OD2ComboBox.TabIndex = 15
        Me.OD2ComboBox.ValueMember = "Member_refnum"
        '
        'MembersBindingSource1
        '
        Me.MembersBindingSource1.DataMember = "Members"
        Me.MembersBindingSource1.DataSource = Me.MASA_allDataSet
        '
        'MASA_allDataSet
        '
        Me.MASA_allDataSet.DataSetName = "MASA_allDataSet"
        Me.MASA_allDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ODComboBox1
        '
        Me.ODComboBox1.DataSource = Me.MembersBindingSource
        Me.ODComboBox1.DisplayMember = "Name"
        Me.ODComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ODComboBox1.FormattingEnabled = True
        Me.ODComboBox1.Location = New System.Drawing.Point(20, 101)
        Me.ODComboBox1.Name = "ODComboBox1"
        Me.ODComboBox1.Size = New System.Drawing.Size(300, 28)
        Me.ODComboBox1.TabIndex = 15
        Me.ODComboBox1.ValueMember = "Member_refnum"
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "Members"
        Me.MembersBindingSource.DataSource = Me.MASA_allDataSet
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(555, 212)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 20)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Comments"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(555, 192)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 20)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Airport name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(555, 174)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 20)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Tow Plane 2"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(555, 154)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 20)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Tow Plane"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(555, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Tow Pilot 3"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(555, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Tow Pilot 2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(555, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Tow Pilot"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(555, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(181, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Operations Director 3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(555, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Assistant OD 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(555, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Assistant OD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Operations Director 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Today's Date"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Percent_1st_checkLabel1)
        Me.TabPage2.Controls.Add(Me.Percent_1st_checkTextBox1)
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.FirstInvoiceNameComboBox1)
        Me.TabPage2.Controls.Add(Me.InstructorNameComboBox2)
        Me.TabPage2.Controls.Add(Me.GliderPilotComboBox1)
        Me.TabPage2.Controls.Add(NameLabel1)
        Me.TabPage2.Controls.Add(NameLabel)
        Me.TabPage2.Controls.Add(Label14)
        Me.TabPage2.Controls.Add(Rope_breakLabel1)
        Me.TabPage2.Controls.Add(Me.Rope_breakCheckBox)
        Me.TabPage2.Controls.Add(Passenger_nameLabel)
        Me.TabPage2.Controls.Add(TowPilot1Label)
        Me.TabPage2.Controls.Add(TowPilot2Label)
        Me.TabPage2.Controls.Add(TowPilot3Label)
        Me.TabPage2.Controls.Add(TowPlane1Label)
        Me.TabPage2.Controls.Add(TowPlane2Label)
        Me.TabPage2.Controls.Add(Me.Glider_takeoff_timeLabel)
        Me.TabPage2.Controls.Add(Me.Glider_takeoff_timeDateTimePicker)
        Me.TabPage2.Controls.Add(Me.Glider_landing_timeLabel)
        Me.TabPage2.Controls.Add(Me.Glider_landing_timeDateTimePicker)
        Me.TabPage2.Controls.Add(Me.Tow_takeoff_timeLabel)
        Me.TabPage2.Controls.Add(Me.Tow_takeoff_timeDateTimePicker)
        Me.TabPage2.Controls.Add(Me.Tow_landing_timeLabel)
        Me.TabPage2.Controls.Add(Me.Tow_landing_timeDateTimePicker)
        Me.TabPage2.Controls.Add(Altitude_towedLabel)
        Me.TabPage2.Controls.Add(Me.Altitude_towedTextBox)
        Me.TabPage2.Controls.Add(Flight_minutesLabel)
        Me.TabPage2.Controls.Add(Me.Flight_minutesTextBox)
        Me.TabPage2.Controls.Add(First_name_on_invoiceLabel)
        Me.TabPage2.Controls.Add(Split_costLabel)
        Me.TabPage2.Controls.Add(Me.Split_costCheckBox)
        Me.TabPage2.Controls.Add(Me.Percent_1st_checkTextBox)
        Me.TabPage2.Controls.Add(Second_name_on_invoiceLabel)
        Me.TabPage2.Controls.Add(Penalty_chargeLabel)
        Me.TabPage2.Controls.Add(Me.Penalty_chargeCheckBox)
        Me.TabPage2.Controls.Add(Cost_this_flightLabel)
        Me.TabPage2.Controls.Add(Me.Cost_this_flightTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 33)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1183, 601)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Enter New Flights"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Rope_breakCheckBox
        '
        Me.Rope_breakCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.FlightsBindingSource, "Rope_break", True))
        Me.Rope_breakCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rope_breakCheckBox.Location = New System.Drawing.Point(807, 133)
        Me.Rope_breakCheckBox.Name = "Rope_breakCheckBox"
        Me.Rope_breakCheckBox.Size = New System.Drawing.Size(150, 24)
        Me.Rope_breakCheckBox.TabIndex = 58
        Me.Rope_breakCheckBox.Text = "(Check for yes)"
        Me.Rope_breakCheckBox.UseVisualStyleBackColor = True
        '
        'FlightsBindingSource
        '
        Me.FlightsBindingSource.DataMember = "Flights"
        Me.FlightsBindingSource.DataSource = Me.MASA_allDataSet
        '
        'Glider_takeoff_timeDateTimePicker
        '
        Me.Glider_takeoff_timeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FlightsBindingSource, "Glider_takeoff_time", True))
        Me.Glider_takeoff_timeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Glider_takeoff_timeDateTimePicker.Location = New System.Drawing.Point(284, 343)
        Me.Glider_takeoff_timeDateTimePicker.Name = "Glider_takeoff_timeDateTimePicker"
        Me.Glider_takeoff_timeDateTimePicker.ShowUpDown = True
        Me.Glider_takeoff_timeDateTimePicker.Size = New System.Drawing.Size(200, 29)
        Me.Glider_takeoff_timeDateTimePicker.TabIndex = 31
        '
        'Glider_landing_timeDateTimePicker
        '
        Me.Glider_landing_timeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FlightsBindingSource, "Glider_landing_time", True))
        Me.Glider_landing_timeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Glider_landing_timeDateTimePicker.Location = New System.Drawing.Point(284, 378)
        Me.Glider_landing_timeDateTimePicker.Name = "Glider_landing_timeDateTimePicker"
        Me.Glider_landing_timeDateTimePicker.ShowUpDown = True
        Me.Glider_landing_timeDateTimePicker.Size = New System.Drawing.Size(200, 29)
        Me.Glider_landing_timeDateTimePicker.TabIndex = 33
        '
        'Tow_takeoff_timeDateTimePicker
        '
        Me.Tow_takeoff_timeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FlightsBindingSource, "Tow_takeoff_time", True))
        Me.Tow_takeoff_timeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Tow_takeoff_timeDateTimePicker.Location = New System.Drawing.Point(804, 25)
        Me.Tow_takeoff_timeDateTimePicker.Name = "Tow_takeoff_timeDateTimePicker"
        Me.Tow_takeoff_timeDateTimePicker.ShowUpDown = True
        Me.Tow_takeoff_timeDateTimePicker.Size = New System.Drawing.Size(200, 29)
        Me.Tow_takeoff_timeDateTimePicker.TabIndex = 35
        '
        'Tow_landing_timeDateTimePicker
        '
        Me.Tow_landing_timeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FlightsBindingSource, "Tow_landing_time", True))
        Me.Tow_landing_timeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Tow_landing_timeDateTimePicker.Location = New System.Drawing.Point(804, 60)
        Me.Tow_landing_timeDateTimePicker.Name = "Tow_landing_timeDateTimePicker"
        Me.Tow_landing_timeDateTimePicker.ShowUpDown = True
        Me.Tow_landing_timeDateTimePicker.Size = New System.Drawing.Size(200, 29)
        Me.Tow_landing_timeDateTimePicker.TabIndex = 37
        '
        'Altitude_towedTextBox
        '
        Me.Altitude_towedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "Altitude_towed", True))
        Me.Altitude_towedTextBox.Location = New System.Drawing.Point(804, 95)
        Me.Altitude_towedTextBox.Name = "Altitude_towedTextBox"
        Me.Altitude_towedTextBox.Size = New System.Drawing.Size(200, 29)
        Me.Altitude_towedTextBox.TabIndex = 39
        '
        'Flight_minutesTextBox
        '
        Me.Flight_minutesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "Flight_minutes", True))
        Me.Flight_minutesTextBox.Location = New System.Drawing.Point(807, 441)
        Me.Flight_minutesTextBox.Name = "Flight_minutesTextBox"
        Me.Flight_minutesTextBox.Size = New System.Drawing.Size(200, 29)
        Me.Flight_minutesTextBox.TabIndex = 45
        '
        'Split_costCheckBox
        '
        Me.Split_costCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.FlightsBindingSource, "Split_cost", True))
        Me.Split_costCheckBox.Location = New System.Drawing.Point(804, 270)
        Me.Split_costCheckBox.Name = "Split_costCheckBox"
        Me.Split_costCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.Split_costCheckBox.TabIndex = 49
        Me.Split_costCheckBox.Text = "Split Cost"
        Me.Split_costCheckBox.UseVisualStyleBackColor = True
        '
        'Percent_1st_checkTextBox
        '
        Me.Percent_1st_checkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "Percent_1st_check", True))
        Me.Percent_1st_checkTextBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.Percent_1st_checkTextBox.Location = New System.Drawing.Point(3, 3)
        Me.Percent_1st_checkTextBox.Name = "Percent_1st_checkTextBox"
        Me.Percent_1st_checkTextBox.Size = New System.Drawing.Size(1177, 29)
        Me.Percent_1st_checkTextBox.TabIndex = 51
        '
        'Penalty_chargeCheckBox
        '
        Me.Penalty_chargeCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.FlightsBindingSource, "Penalty_charge", True))
        Me.Penalty_chargeCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Penalty_chargeCheckBox.Location = New System.Drawing.Point(807, 168)
        Me.Penalty_chargeCheckBox.Name = "Penalty_chargeCheckBox"
        Me.Penalty_chargeCheckBox.Size = New System.Drawing.Size(202, 24)
        Me.Penalty_chargeCheckBox.TabIndex = 55
        Me.Penalty_chargeCheckBox.Text = "(Check for yes)"
        Me.Penalty_chargeCheckBox.UseVisualStyleBackColor = True
        '
        'Cost_this_flightTextBox
        '
        Me.Cost_this_flightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "Cost_this_flight", True))
        Me.Cost_this_flightTextBox.Location = New System.Drawing.Point(807, 480)
        Me.Cost_this_flightTextBox.Name = "Cost_this_flightTextBox"
        Me.Cost_this_flightTextBox.Size = New System.Drawing.Size(200, 29)
        Me.Cost_this_flightTextBox.TabIndex = 57
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 33)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1183, 601)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Print Invoices"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 33)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1183, 601)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Add Pilot Names"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 33)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1183, 601)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Admin Stuff"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'AircraftBindingSource
        '
        Me.AircraftBindingSource.DataMember = "Aircraft"
        Me.AircraftBindingSource.DataSource = Me.MASA_allDataSet
        '
        'AircraftTableAdapter
        '
        Me.AircraftTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AircraftTableAdapter = Me.AircraftTableAdapter
        Me.TableAdapterManager.AirportTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FlightsTableAdapter = Nothing
        Me.TableAdapterManager.MembersTableAdapter = Me.MembersTableAdapter
        Me.TableAdapterManager.UpdateOrder = Masa_Ver1.MASA_allDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'FlightsTableAdapter
        '
        Me.FlightsTableAdapter.ClearBeforeFill = True
        '
        'MembersBindingSource2
        '
        Me.MembersBindingSource2.DataMember = "Members"
        Me.MembersBindingSource2.DataSource = Me.MASA_allDataSet
        '
        'MembersBindingSource3
        '
        Me.MembersBindingSource3.DataMember = "Members"
        Me.MembersBindingSource3.DataSource = Me.MASA_allDataSet
        '
        'InstructorNameComboBox2
        '
        Me.InstructorNameComboBox2.DataSource = Me.MembersBindingSource3
        Me.InstructorNameComboBox2.DisplayMember = "Name"
        Me.InstructorNameComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstructorNameComboBox2.FormattingEnabled = True
        Me.InstructorNameComboBox2.Location = New System.Drawing.Point(233, 64)
        Me.InstructorNameComboBox2.Name = "InstructorNameComboBox2"
        Me.InstructorNameComboBox2.Size = New System.Drawing.Size(300, 28)
        Me.InstructorNameComboBox2.TabIndex = 64
        Me.InstructorNameComboBox2.ValueMember = "Member_refnum"
        '
        'GliderPilotComboBox1
        '
        Me.GliderPilotComboBox1.DataSource = Me.MembersBindingSource2
        Me.GliderPilotComboBox1.DisplayMember = "Name"
        Me.GliderPilotComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GliderPilotComboBox1.FormattingEnabled = True
        Me.GliderPilotComboBox1.Location = New System.Drawing.Point(233, 21)
        Me.GliderPilotComboBox1.Name = "GliderPilotComboBox1"
        Me.GliderPilotComboBox1.Size = New System.Drawing.Size(300, 28)
        Me.GliderPilotComboBox1.TabIndex = 63
        Me.GliderPilotComboBox1.ValueMember = "Member_refnum"
        '
        'MembersBindingSource4
        '
        Me.MembersBindingSource4.DataMember = "Members"
        Me.MembersBindingSource4.DataSource = Me.MASA_allDataSet
        '
        'FirstInvoiceNameComboBox1
        '
        Me.FirstInvoiceNameComboBox1.DataSource = Me.MembersBindingSource4
        Me.FirstInvoiceNameComboBox1.DisplayMember = "Name"
        Me.FirstInvoiceNameComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstInvoiceNameComboBox1.FormattingEnabled = True
        Me.FirstInvoiceNameComboBox1.Location = New System.Drawing.Point(804, 234)
        Me.FirstInvoiceNameComboBox1.Name = "FirstInvoiceNameComboBox1"
        Me.FirstInvoiceNameComboBox1.Size = New System.Drawing.Size(300, 28)
        Me.FirstInvoiceNameComboBox1.TabIndex = 65
        Me.FirstInvoiceNameComboBox1.ValueMember = "Member_refnum"
        '
        'MembersBindingSource5
        '
        Me.MembersBindingSource5.DataMember = "Members"
        Me.MembersBindingSource5.DataSource = Me.MASA_allDataSet
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.MembersBindingSource5
        Me.ComboBox1.DisplayMember = "Name"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(804, 347)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(300, 28)
        Me.ComboBox1.TabIndex = 66
        Me.ComboBox1.ValueMember = "Member_refnum"
        '
        'Percent_1st_checkLabel1
        '
        Percent_1st_checkLabel1.AutoSize = True
        Percent_1st_checkLabel1.Location = New System.Drawing.Point(549, 310)
        Percent_1st_checkLabel1.Name = "Percent_1st_checkLabel1"
        Percent_1st_checkLabel1.Size = New System.Drawing.Size(182, 24)
        Percent_1st_checkLabel1.TabIndex = 66
        Percent_1st_checkLabel1.Text = "Percent 1st check:"
        '
        'Percent_1st_checkTextBox1
        '
        Me.Percent_1st_checkTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "Percent_1st_check", True))
        Me.Percent_1st_checkTextBox1.Location = New System.Drawing.Point(804, 305)
        Me.Percent_1st_checkTextBox1.Name = "Percent_1st_checkTextBox1"
        Me.Percent_1st_checkTextBox1.Size = New System.Drawing.Size(100, 29)
        Me.Percent_1st_checkTextBox1.TabIndex = 67
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1347, 670)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Flight Sheet Entry"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.MembersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MASA_allDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.FlightsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AircraftBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents MASA_allDataSet As MASA_allDataSet
    Friend WithEvents AircraftBindingSource As BindingSource
    Friend WithEvents AircraftTableAdapter As MASA_allDataSetTableAdapters.AircraftTableAdapter
    Friend WithEvents TableAdapterManager As MASA_allDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MembersTableAdapter As MASA_allDataSetTableAdapters.MembersTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ODComboBox1 As ComboBox
    Friend WithEvents MembersBindingSource As BindingSource
    Friend WithEvents OD2ComboBox As ComboBox
    Friend WithEvents MembersBindingSource1 As BindingSource
    Friend WithEvents FlightsBindingSource As BindingSource
    Friend WithEvents FlightsTableAdapter As MASA_allDataSetTableAdapters.FlightsTableAdapter
    Friend WithEvents Glider_takeoff_timeDateTimePicker As DateTimePicker
    Friend WithEvents Glider_landing_timeDateTimePicker As DateTimePicker
    Friend WithEvents Tow_takeoff_timeDateTimePicker As DateTimePicker
    Friend WithEvents Tow_landing_timeDateTimePicker As DateTimePicker
    Friend WithEvents Altitude_towedTextBox As TextBox
    Friend WithEvents Flight_minutesTextBox As TextBox
    Friend WithEvents Split_costCheckBox As CheckBox
    Friend WithEvents Percent_1st_checkTextBox As TextBox
    Friend WithEvents Penalty_chargeCheckBox As CheckBox
    Friend WithEvents Cost_this_flightTextBox As TextBox
    Friend WithEvents Glider_takeoff_timeLabel As Label
    Friend WithEvents Glider_landing_timeLabel As Label
    Friend WithEvents Tow_takeoff_timeLabel As Label
    Friend WithEvents Tow_landing_timeLabel As Label
    Friend WithEvents Rope_breakCheckBox As CheckBox
    Friend WithEvents MembersBindingSource2 As BindingSource
    Friend WithEvents InstructorNameComboBox2 As ComboBox
    Friend WithEvents MembersBindingSource3 As BindingSource
    Friend WithEvents GliderPilotComboBox1 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MembersBindingSource5 As BindingSource
    Friend WithEvents FirstInvoiceNameComboBox1 As ComboBox
    Friend WithEvents MembersBindingSource4 As BindingSource
    Friend WithEvents Percent_1st_checkTextBox1 As TextBox
End Class
