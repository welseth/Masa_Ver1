<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim Flight_refnumLabel As System.Windows.Forms.Label
        Dim Glider_Pilot_NameLabel As System.Windows.Forms.Label
        Dim Instructor_nameLabel As System.Windows.Forms.Label
        Dim Passenger_nameLabel As System.Windows.Forms.Label
        Dim OD1Label As System.Windows.Forms.Label
        Dim OD2Label As System.Windows.Forms.Label
        Dim OD3Label As System.Windows.Forms.Label
        Dim AOD1Label As System.Windows.Forms.Label
        Dim AOD2Label As System.Windows.Forms.Label
        Dim TowPilot1Label As System.Windows.Forms.Label
        Dim TowPilot2Label As System.Windows.Forms.Label
        Dim TowPilot3Label As System.Windows.Forms.Label
        Dim TowPlane1Label As System.Windows.Forms.Label
        Dim TowPlane2Label As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim Glider_takeoff_timeLabel As System.Windows.Forms.Label
        Dim Glider_landing_timeLabel As System.Windows.Forms.Label
        Dim Tow_takeoff_timeLabel As System.Windows.Forms.Label
        Dim Tow_landing_timeLabel As System.Windows.Forms.Label
        Dim Altitude_towedLabel As System.Windows.Forms.Label
        Dim Rope_breakLabel As System.Windows.Forms.Label
        Dim Airport_nameLabel As System.Windows.Forms.Label
        Dim Flight_minutesLabel As System.Windows.Forms.Label
        Dim First_name_on_invoiceLabel As System.Windows.Forms.Label
        Dim Split_costLabel As System.Windows.Forms.Label
        Dim Percent_1st_checkLabel As System.Windows.Forms.Label
        Dim Second_name_on_invoiceLabel As System.Windows.Forms.Label
        Dim Penalty_chargeLabel As System.Windows.Forms.Label
        Dim Cost_this_flightLabel As System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.NewFlightsSavedHere = New Masa_Ver2.NewFlightsSavedHere()
        Me.FlightsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlightsTableAdapter = New Masa_Ver2.NewFlightsSavedHereTableAdapters.FlightsTableAdapter()
        Me.TableAdapterManager = New Masa_Ver2.NewFlightsSavedHereTableAdapters.TableAdapterManager()
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
        Me.OD1ComboBox = New System.Windows.Forms.ComboBox()
        Me.OD2ComboBox = New System.Windows.Forms.ComboBox()
        Me.OD3ComboBox = New System.Windows.Forms.ComboBox()
        Me.AOD1ComboBox = New System.Windows.Forms.ComboBox()
        Me.AOD2ComboBox = New System.Windows.Forms.ComboBox()
        Me.TowPilot1ComboBox = New System.Windows.Forms.ComboBox()
        Me.TowPilot2ComboBox = New System.Windows.Forms.ComboBox()
        Me.TowPilot3ComboBox = New System.Windows.Forms.ComboBox()
        Me.TowPlane1ComboBox = New System.Windows.Forms.ComboBox()
        Me.TowPlane2ComboBox = New System.Windows.Forms.ComboBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Glider_takeoff_timeTextBox = New System.Windows.Forms.TextBox()
        Me.Glider_landing_timeTextBox = New System.Windows.Forms.TextBox()
        Me.Tow_takeoff_timeTextBox = New System.Windows.Forms.TextBox()
        Me.Tow_landing_timeTextBox = New System.Windows.Forms.TextBox()
        Me.Altitude_towedTextBox = New System.Windows.Forms.TextBox()
        Me.Rope_breakTextBox = New System.Windows.Forms.TextBox()
        Me.Airport_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Flight_minutesTextBox = New System.Windows.Forms.TextBox()
        Me.First_name_on_invoiceComboBox = New System.Windows.Forms.ComboBox()
        Me.Split_costCheckBox = New System.Windows.Forms.CheckBox()
        Me.Percent_1st_checkTextBox = New System.Windows.Forms.TextBox()
        Me.Second_name_on_invoiceComboBox = New System.Windows.Forms.ComboBox()
        Me.Penalty_chargeCheckBox = New System.Windows.Forms.CheckBox()
        Me.Cost_this_flightTextBox = New System.Windows.Forms.TextBox()
        Flight_refnumLabel = New System.Windows.Forms.Label()
        Glider_Pilot_NameLabel = New System.Windows.Forms.Label()
        Instructor_nameLabel = New System.Windows.Forms.Label()
        Passenger_nameLabel = New System.Windows.Forms.Label()
        OD1Label = New System.Windows.Forms.Label()
        OD2Label = New System.Windows.Forms.Label()
        OD3Label = New System.Windows.Forms.Label()
        AOD1Label = New System.Windows.Forms.Label()
        AOD2Label = New System.Windows.Forms.Label()
        TowPilot1Label = New System.Windows.Forms.Label()
        TowPilot2Label = New System.Windows.Forms.Label()
        TowPilot3Label = New System.Windows.Forms.Label()
        TowPlane1Label = New System.Windows.Forms.Label()
        TowPlane2Label = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        Glider_takeoff_timeLabel = New System.Windows.Forms.Label()
        Glider_landing_timeLabel = New System.Windows.Forms.Label()
        Tow_takeoff_timeLabel = New System.Windows.Forms.Label()
        Tow_landing_timeLabel = New System.Windows.Forms.Label()
        Altitude_towedLabel = New System.Windows.Forms.Label()
        Rope_breakLabel = New System.Windows.Forms.Label()
        Airport_nameLabel = New System.Windows.Forms.Label()
        Flight_minutesLabel = New System.Windows.Forms.Label()
        First_name_on_invoiceLabel = New System.Windows.Forms.Label()
        Split_costLabel = New System.Windows.Forms.Label()
        Percent_1st_checkLabel = New System.Windows.Forms.Label()
        Second_name_on_invoiceLabel = New System.Windows.Forms.Label()
        Penalty_chargeLabel = New System.Windows.Forms.Label()
        Cost_this_flightLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.NewFlightsSavedHere, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlightsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlightsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlightsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(46, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1016, 545)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1008, 519)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "OD/AOD/Pilot Info"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.FlightsBindingNavigator)
        Me.TabPage2.Controls.Add(Flight_refnumLabel)
        Me.TabPage2.Controls.Add(Me.Flight_refnumTextBox)
        Me.TabPage2.Controls.Add(Glider_Pilot_NameLabel)
        Me.TabPage2.Controls.Add(Me.Glider_Pilot_NameComboBox)
        Me.TabPage2.Controls.Add(Instructor_nameLabel)
        Me.TabPage2.Controls.Add(Me.Instructor_nameComboBox)
        Me.TabPage2.Controls.Add(Passenger_nameLabel)
        Me.TabPage2.Controls.Add(Me.Passenger_nameComboBox)
        Me.TabPage2.Controls.Add(OD1Label)
        Me.TabPage2.Controls.Add(Me.OD1ComboBox)
        Me.TabPage2.Controls.Add(OD2Label)
        Me.TabPage2.Controls.Add(Me.OD2ComboBox)
        Me.TabPage2.Controls.Add(OD3Label)
        Me.TabPage2.Controls.Add(Me.OD3ComboBox)
        Me.TabPage2.Controls.Add(AOD1Label)
        Me.TabPage2.Controls.Add(Me.AOD1ComboBox)
        Me.TabPage2.Controls.Add(AOD2Label)
        Me.TabPage2.Controls.Add(Me.AOD2ComboBox)
        Me.TabPage2.Controls.Add(TowPilot1Label)
        Me.TabPage2.Controls.Add(Me.TowPilot1ComboBox)
        Me.TabPage2.Controls.Add(TowPilot2Label)
        Me.TabPage2.Controls.Add(Me.TowPilot2ComboBox)
        Me.TabPage2.Controls.Add(TowPilot3Label)
        Me.TabPage2.Controls.Add(Me.TowPilot3ComboBox)
        Me.TabPage2.Controls.Add(TowPlane1Label)
        Me.TabPage2.Controls.Add(Me.TowPlane1ComboBox)
        Me.TabPage2.Controls.Add(TowPlane2Label)
        Me.TabPage2.Controls.Add(Me.TowPlane2ComboBox)
        Me.TabPage2.Controls.Add(DateLabel)
        Me.TabPage2.Controls.Add(Me.DateDateTimePicker)
        Me.TabPage2.Controls.Add(Glider_takeoff_timeLabel)
        Me.TabPage2.Controls.Add(Me.Glider_takeoff_timeTextBox)
        Me.TabPage2.Controls.Add(Glider_landing_timeLabel)
        Me.TabPage2.Controls.Add(Me.Glider_landing_timeTextBox)
        Me.TabPage2.Controls.Add(Tow_takeoff_timeLabel)
        Me.TabPage2.Controls.Add(Me.Tow_takeoff_timeTextBox)
        Me.TabPage2.Controls.Add(Tow_landing_timeLabel)
        Me.TabPage2.Controls.Add(Me.Tow_landing_timeTextBox)
        Me.TabPage2.Controls.Add(Altitude_towedLabel)
        Me.TabPage2.Controls.Add(Me.Altitude_towedTextBox)
        Me.TabPage2.Controls.Add(Rope_breakLabel)
        Me.TabPage2.Controls.Add(Me.Rope_breakTextBox)
        Me.TabPage2.Controls.Add(Airport_nameLabel)
        Me.TabPage2.Controls.Add(Me.Airport_nameTextBox)
        Me.TabPage2.Controls.Add(Flight_minutesLabel)
        Me.TabPage2.Controls.Add(Me.Flight_minutesTextBox)
        Me.TabPage2.Controls.Add(First_name_on_invoiceLabel)
        Me.TabPage2.Controls.Add(Me.First_name_on_invoiceComboBox)
        Me.TabPage2.Controls.Add(Split_costLabel)
        Me.TabPage2.Controls.Add(Me.Split_costCheckBox)
        Me.TabPage2.Controls.Add(Percent_1st_checkLabel)
        Me.TabPage2.Controls.Add(Me.Percent_1st_checkTextBox)
        Me.TabPage2.Controls.Add(Second_name_on_invoiceLabel)
        Me.TabPage2.Controls.Add(Me.Second_name_on_invoiceComboBox)
        Me.TabPage2.Controls.Add(Penalty_chargeLabel)
        Me.TabPage2.Controls.Add(Me.Penalty_chargeCheckBox)
        Me.TabPage2.Controls.Add(Cost_this_flightLabel)
        Me.TabPage2.Controls.Add(Me.Cost_this_flightTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1008, 519)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Enter New Flights"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1008, 519)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Print Invoices"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1008, 519)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Add Pilot Names"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1008, 519)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Admin Stuff"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'NewFlightsSavedHere
        '
        Me.NewFlightsSavedHere.DataSetName = "NewFlightsSavedHere"
        Me.NewFlightsSavedHere.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FlightsBindingSource
        '
        Me.FlightsBindingSource.DataMember = "Flights"
        Me.FlightsBindingSource.DataSource = Me.NewFlightsSavedHere
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
        Me.TableAdapterManager.MembersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Masa_Ver2.NewFlightsSavedHereTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FlightsBindingNavigator
        '
        Me.FlightsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FlightsBindingNavigator.BindingSource = Me.FlightsBindingSource
        Me.FlightsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FlightsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FlightsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.FlightsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FlightsBindingNavigatorSaveItem})
        Me.FlightsBindingNavigator.Location = New System.Drawing.Point(89, 12)
        Me.FlightsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FlightsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FlightsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FlightsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FlightsBindingNavigator.Name = "FlightsBindingNavigator"
        Me.FlightsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FlightsBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.FlightsBindingNavigator.TabIndex = 1
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
        Flight_refnumLabel.Location = New System.Drawing.Point(86, 53)
        Flight_refnumLabel.Name = "Flight_refnumLabel"
        Flight_refnumLabel.Size = New System.Drawing.Size(70, 13)
        Flight_refnumLabel.TabIndex = 0
        Flight_refnumLabel.Text = "Flight refnum:"
        '
        'Flight_refnumTextBox
        '
        Me.Flight_refnumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "Flight_refnum", True))
        Me.Flight_refnumTextBox.Location = New System.Drawing.Point(220, 50)
        Me.Flight_refnumTextBox.Name = "Flight_refnumTextBox"
        Me.Flight_refnumTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Flight_refnumTextBox.TabIndex = 1
        '
        'Glider_Pilot_NameLabel
        '
        Glider_Pilot_NameLabel.AutoSize = True
        Glider_Pilot_NameLabel.Location = New System.Drawing.Point(86, 79)
        Glider_Pilot_NameLabel.Name = "Glider_Pilot_NameLabel"
        Glider_Pilot_NameLabel.Size = New System.Drawing.Size(91, 13)
        Glider_Pilot_NameLabel.TabIndex = 2
        Glider_Pilot_NameLabel.Text = "Glider Pilot Name:"
        '
        'Glider_Pilot_NameComboBox
        '
        Me.Glider_Pilot_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "Glider_Pilot_Name", True))
        Me.Glider_Pilot_NameComboBox.FormattingEnabled = True
        Me.Glider_Pilot_NameComboBox.Location = New System.Drawing.Point(220, 76)
        Me.Glider_Pilot_NameComboBox.Name = "Glider_Pilot_NameComboBox"
        Me.Glider_Pilot_NameComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Glider_Pilot_NameComboBox.TabIndex = 3
        '
        'Instructor_nameLabel
        '
        Instructor_nameLabel.AutoSize = True
        Instructor_nameLabel.Location = New System.Drawing.Point(86, 106)
        Instructor_nameLabel.Name = "Instructor_nameLabel"
        Instructor_nameLabel.Size = New System.Drawing.Size(83, 13)
        Instructor_nameLabel.TabIndex = 4
        Instructor_nameLabel.Text = "Instructor name:"
        '
        'Instructor_nameComboBox
        '
        Me.Instructor_nameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "Instructor_name", True))
        Me.Instructor_nameComboBox.FormattingEnabled = True
        Me.Instructor_nameComboBox.Location = New System.Drawing.Point(220, 103)
        Me.Instructor_nameComboBox.Name = "Instructor_nameComboBox"
        Me.Instructor_nameComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Instructor_nameComboBox.TabIndex = 5
        '
        'Passenger_nameLabel
        '
        Passenger_nameLabel.AutoSize = True
        Passenger_nameLabel.Location = New System.Drawing.Point(86, 133)
        Passenger_nameLabel.Name = "Passenger_nameLabel"
        Passenger_nameLabel.Size = New System.Drawing.Size(89, 13)
        Passenger_nameLabel.TabIndex = 6
        Passenger_nameLabel.Text = "Passenger name:"
        '
        'Passenger_nameComboBox
        '
        Me.Passenger_nameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "Passenger_name", True))
        Me.Passenger_nameComboBox.FormattingEnabled = True
        Me.Passenger_nameComboBox.Location = New System.Drawing.Point(220, 130)
        Me.Passenger_nameComboBox.Name = "Passenger_nameComboBox"
        Me.Passenger_nameComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Passenger_nameComboBox.TabIndex = 7
        '
        'OD1Label
        '
        OD1Label.AutoSize = True
        OD1Label.Location = New System.Drawing.Point(86, 160)
        OD1Label.Name = "OD1Label"
        OD1Label.Size = New System.Drawing.Size(32, 13)
        OD1Label.TabIndex = 8
        OD1Label.Text = "OD1:"
        '
        'OD1ComboBox
        '
        Me.OD1ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "OD1", True))
        Me.OD1ComboBox.FormattingEnabled = True
        Me.OD1ComboBox.Location = New System.Drawing.Point(220, 157)
        Me.OD1ComboBox.Name = "OD1ComboBox"
        Me.OD1ComboBox.Size = New System.Drawing.Size(200, 21)
        Me.OD1ComboBox.TabIndex = 9
        '
        'OD2Label
        '
        OD2Label.AutoSize = True
        OD2Label.Location = New System.Drawing.Point(86, 187)
        OD2Label.Name = "OD2Label"
        OD2Label.Size = New System.Drawing.Size(32, 13)
        OD2Label.TabIndex = 10
        OD2Label.Text = "OD2:"
        '
        'OD2ComboBox
        '
        Me.OD2ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "OD2", True))
        Me.OD2ComboBox.FormattingEnabled = True
        Me.OD2ComboBox.Location = New System.Drawing.Point(220, 184)
        Me.OD2ComboBox.Name = "OD2ComboBox"
        Me.OD2ComboBox.Size = New System.Drawing.Size(200, 21)
        Me.OD2ComboBox.TabIndex = 11
        '
        'OD3Label
        '
        OD3Label.AutoSize = True
        OD3Label.Location = New System.Drawing.Point(86, 214)
        OD3Label.Name = "OD3Label"
        OD3Label.Size = New System.Drawing.Size(32, 13)
        OD3Label.TabIndex = 12
        OD3Label.Text = "OD3:"
        '
        'OD3ComboBox
        '
        Me.OD3ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "OD3", True))
        Me.OD3ComboBox.FormattingEnabled = True
        Me.OD3ComboBox.Location = New System.Drawing.Point(220, 211)
        Me.OD3ComboBox.Name = "OD3ComboBox"
        Me.OD3ComboBox.Size = New System.Drawing.Size(200, 21)
        Me.OD3ComboBox.TabIndex = 13
        '
        'AOD1Label
        '
        AOD1Label.AutoSize = True
        AOD1Label.Location = New System.Drawing.Point(86, 241)
        AOD1Label.Name = "AOD1Label"
        AOD1Label.Size = New System.Drawing.Size(39, 13)
        AOD1Label.TabIndex = 14
        AOD1Label.Text = "AOD1:"
        '
        'AOD1ComboBox
        '
        Me.AOD1ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "AOD1", True))
        Me.AOD1ComboBox.FormattingEnabled = True
        Me.AOD1ComboBox.Location = New System.Drawing.Point(220, 238)
        Me.AOD1ComboBox.Name = "AOD1ComboBox"
        Me.AOD1ComboBox.Size = New System.Drawing.Size(200, 21)
        Me.AOD1ComboBox.TabIndex = 15
        '
        'AOD2Label
        '
        AOD2Label.AutoSize = True
        AOD2Label.Location = New System.Drawing.Point(86, 268)
        AOD2Label.Name = "AOD2Label"
        AOD2Label.Size = New System.Drawing.Size(39, 13)
        AOD2Label.TabIndex = 16
        AOD2Label.Text = "AOD2:"
        '
        'AOD2ComboBox
        '
        Me.AOD2ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "AOD2", True))
        Me.AOD2ComboBox.FormattingEnabled = True
        Me.AOD2ComboBox.Location = New System.Drawing.Point(220, 265)
        Me.AOD2ComboBox.Name = "AOD2ComboBox"
        Me.AOD2ComboBox.Size = New System.Drawing.Size(200, 21)
        Me.AOD2ComboBox.TabIndex = 17
        '
        'TowPilot1Label
        '
        TowPilot1Label.AutoSize = True
        TowPilot1Label.Location = New System.Drawing.Point(86, 295)
        TowPilot1Label.Name = "TowPilot1Label"
        TowPilot1Label.Size = New System.Drawing.Size(60, 13)
        TowPilot1Label.TabIndex = 18
        TowPilot1Label.Text = "Tow Pilot1:"
        '
        'TowPilot1ComboBox
        '
        Me.TowPilot1ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "TowPilot1", True))
        Me.TowPilot1ComboBox.FormattingEnabled = True
        Me.TowPilot1ComboBox.Location = New System.Drawing.Point(220, 292)
        Me.TowPilot1ComboBox.Name = "TowPilot1ComboBox"
        Me.TowPilot1ComboBox.Size = New System.Drawing.Size(200, 21)
        Me.TowPilot1ComboBox.TabIndex = 19
        '
        'TowPilot2Label
        '
        TowPilot2Label.AutoSize = True
        TowPilot2Label.Location = New System.Drawing.Point(86, 322)
        TowPilot2Label.Name = "TowPilot2Label"
        TowPilot2Label.Size = New System.Drawing.Size(60, 13)
        TowPilot2Label.TabIndex = 20
        TowPilot2Label.Text = "Tow Pilot2:"
        '
        'TowPilot2ComboBox
        '
        Me.TowPilot2ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "TowPilot2", True))
        Me.TowPilot2ComboBox.FormattingEnabled = True
        Me.TowPilot2ComboBox.Location = New System.Drawing.Point(220, 319)
        Me.TowPilot2ComboBox.Name = "TowPilot2ComboBox"
        Me.TowPilot2ComboBox.Size = New System.Drawing.Size(200, 21)
        Me.TowPilot2ComboBox.TabIndex = 21
        '
        'TowPilot3Label
        '
        TowPilot3Label.AutoSize = True
        TowPilot3Label.Location = New System.Drawing.Point(86, 349)
        TowPilot3Label.Name = "TowPilot3Label"
        TowPilot3Label.Size = New System.Drawing.Size(60, 13)
        TowPilot3Label.TabIndex = 22
        TowPilot3Label.Text = "Tow Pilot3:"
        '
        'TowPilot3ComboBox
        '
        Me.TowPilot3ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "TowPilot3", True))
        Me.TowPilot3ComboBox.FormattingEnabled = True
        Me.TowPilot3ComboBox.Location = New System.Drawing.Point(220, 346)
        Me.TowPilot3ComboBox.Name = "TowPilot3ComboBox"
        Me.TowPilot3ComboBox.Size = New System.Drawing.Size(200, 21)
        Me.TowPilot3ComboBox.TabIndex = 23
        '
        'TowPlane1Label
        '
        TowPlane1Label.AutoSize = True
        TowPlane1Label.Location = New System.Drawing.Point(86, 376)
        TowPlane1Label.Name = "TowPlane1Label"
        TowPlane1Label.Size = New System.Drawing.Size(67, 13)
        TowPlane1Label.TabIndex = 24
        TowPlane1Label.Text = "Tow Plane1:"
        '
        'TowPlane1ComboBox
        '
        Me.TowPlane1ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "TowPlane1", True))
        Me.TowPlane1ComboBox.FormattingEnabled = True
        Me.TowPlane1ComboBox.Location = New System.Drawing.Point(220, 373)
        Me.TowPlane1ComboBox.Name = "TowPlane1ComboBox"
        Me.TowPlane1ComboBox.Size = New System.Drawing.Size(200, 21)
        Me.TowPlane1ComboBox.TabIndex = 25
        '
        'TowPlane2Label
        '
        TowPlane2Label.AutoSize = True
        TowPlane2Label.Location = New System.Drawing.Point(86, 403)
        TowPlane2Label.Name = "TowPlane2Label"
        TowPlane2Label.Size = New System.Drawing.Size(67, 13)
        TowPlane2Label.TabIndex = 26
        TowPlane2Label.Text = "Tow Plane2:"
        '
        'TowPlane2ComboBox
        '
        Me.TowPlane2ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "TowPlane2", True))
        Me.TowPlane2ComboBox.FormattingEnabled = True
        Me.TowPlane2ComboBox.Location = New System.Drawing.Point(220, 400)
        Me.TowPlane2ComboBox.Name = "TowPlane2ComboBox"
        Me.TowPlane2ComboBox.Size = New System.Drawing.Size(200, 21)
        Me.TowPlane2ComboBox.TabIndex = 27
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(86, 431)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(33, 13)
        DateLabel.TabIndex = 28
        DateLabel.Text = "Date:"
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FlightsBindingSource, "Date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(220, 427)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateDateTimePicker.TabIndex = 29
        '
        'Glider_takeoff_timeLabel
        '
        Glider_takeoff_timeLabel.AutoSize = True
        Glider_takeoff_timeLabel.Location = New System.Drawing.Point(484, 56)
        Glider_takeoff_timeLabel.Name = "Glider_takeoff_timeLabel"
        Glider_takeoff_timeLabel.Size = New System.Drawing.Size(95, 13)
        Glider_takeoff_timeLabel.TabIndex = 30
        Glider_takeoff_timeLabel.Text = "Glider takeoff time:"
        '
        'Glider_takeoff_timeTextBox
        '
        Me.Glider_takeoff_timeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "Glider_takeoff_time", True))
        Me.Glider_takeoff_timeTextBox.Location = New System.Drawing.Point(618, 53)
        Me.Glider_takeoff_timeTextBox.Name = "Glider_takeoff_timeTextBox"
        Me.Glider_takeoff_timeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Glider_takeoff_timeTextBox.TabIndex = 31
        '
        'Glider_landing_timeLabel
        '
        Glider_landing_timeLabel.AutoSize = True
        Glider_landing_timeLabel.Location = New System.Drawing.Point(484, 82)
        Glider_landing_timeLabel.Name = "Glider_landing_timeLabel"
        Glider_landing_timeLabel.Size = New System.Drawing.Size(96, 13)
        Glider_landing_timeLabel.TabIndex = 32
        Glider_landing_timeLabel.Text = "Glider landing time:"
        '
        'Glider_landing_timeTextBox
        '
        Me.Glider_landing_timeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "Glider_landing_time", True))
        Me.Glider_landing_timeTextBox.Location = New System.Drawing.Point(618, 79)
        Me.Glider_landing_timeTextBox.Name = "Glider_landing_timeTextBox"
        Me.Glider_landing_timeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Glider_landing_timeTextBox.TabIndex = 33
        '
        'Tow_takeoff_timeLabel
        '
        Tow_takeoff_timeLabel.AutoSize = True
        Tow_takeoff_timeLabel.Location = New System.Drawing.Point(484, 108)
        Tow_takeoff_timeLabel.Name = "Tow_takeoff_timeLabel"
        Tow_takeoff_timeLabel.Size = New System.Drawing.Size(89, 13)
        Tow_takeoff_timeLabel.TabIndex = 34
        Tow_takeoff_timeLabel.Text = "Tow takeoff time:"
        '
        'Tow_takeoff_timeTextBox
        '
        Me.Tow_takeoff_timeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "Tow_takeoff_time", True))
        Me.Tow_takeoff_timeTextBox.Location = New System.Drawing.Point(618, 105)
        Me.Tow_takeoff_timeTextBox.Name = "Tow_takeoff_timeTextBox"
        Me.Tow_takeoff_timeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Tow_takeoff_timeTextBox.TabIndex = 35
        '
        'Tow_landing_timeLabel
        '
        Tow_landing_timeLabel.AutoSize = True
        Tow_landing_timeLabel.Location = New System.Drawing.Point(484, 134)
        Tow_landing_timeLabel.Name = "Tow_landing_timeLabel"
        Tow_landing_timeLabel.Size = New System.Drawing.Size(90, 13)
        Tow_landing_timeLabel.TabIndex = 36
        Tow_landing_timeLabel.Text = "Tow landing time:"
        '
        'Tow_landing_timeTextBox
        '
        Me.Tow_landing_timeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "Tow_landing_time", True))
        Me.Tow_landing_timeTextBox.Location = New System.Drawing.Point(618, 131)
        Me.Tow_landing_timeTextBox.Name = "Tow_landing_timeTextBox"
        Me.Tow_landing_timeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Tow_landing_timeTextBox.TabIndex = 37
        '
        'Altitude_towedLabel
        '
        Altitude_towedLabel.AutoSize = True
        Altitude_towedLabel.Location = New System.Drawing.Point(484, 160)
        Altitude_towedLabel.Name = "Altitude_towedLabel"
        Altitude_towedLabel.Size = New System.Drawing.Size(77, 13)
        Altitude_towedLabel.TabIndex = 38
        Altitude_towedLabel.Text = "Altitude towed:"
        '
        'Altitude_towedTextBox
        '
        Me.Altitude_towedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "Altitude_towed", True))
        Me.Altitude_towedTextBox.Location = New System.Drawing.Point(618, 157)
        Me.Altitude_towedTextBox.Name = "Altitude_towedTextBox"
        Me.Altitude_towedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Altitude_towedTextBox.TabIndex = 39
        '
        'Rope_breakLabel
        '
        Rope_breakLabel.AutoSize = True
        Rope_breakLabel.Location = New System.Drawing.Point(484, 186)
        Rope_breakLabel.Name = "Rope_breakLabel"
        Rope_breakLabel.Size = New System.Drawing.Size(66, 13)
        Rope_breakLabel.TabIndex = 40
        Rope_breakLabel.Text = "Rope break:"
        '
        'Rope_breakTextBox
        '
        Me.Rope_breakTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "Rope_break", True))
        Me.Rope_breakTextBox.Location = New System.Drawing.Point(618, 183)
        Me.Rope_breakTextBox.Name = "Rope_breakTextBox"
        Me.Rope_breakTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Rope_breakTextBox.TabIndex = 41
        '
        'Airport_nameLabel
        '
        Airport_nameLabel.AutoSize = True
        Airport_nameLabel.Location = New System.Drawing.Point(484, 212)
        Airport_nameLabel.Name = "Airport_nameLabel"
        Airport_nameLabel.Size = New System.Drawing.Size(69, 13)
        Airport_nameLabel.TabIndex = 42
        Airport_nameLabel.Text = "Airport name:"
        '
        'Airport_nameTextBox
        '
        Me.Airport_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "Airport_name", True))
        Me.Airport_nameTextBox.Location = New System.Drawing.Point(618, 209)
        Me.Airport_nameTextBox.Name = "Airport_nameTextBox"
        Me.Airport_nameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Airport_nameTextBox.TabIndex = 43
        '
        'Flight_minutesLabel
        '
        Flight_minutesLabel.AutoSize = True
        Flight_minutesLabel.Location = New System.Drawing.Point(484, 238)
        Flight_minutesLabel.Name = "Flight_minutesLabel"
        Flight_minutesLabel.Size = New System.Drawing.Size(74, 13)
        Flight_minutesLabel.TabIndex = 44
        Flight_minutesLabel.Text = "Flight minutes:"
        '
        'Flight_minutesTextBox
        '
        Me.Flight_minutesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "Flight_minutes", True))
        Me.Flight_minutesTextBox.Location = New System.Drawing.Point(618, 235)
        Me.Flight_minutesTextBox.Name = "Flight_minutesTextBox"
        Me.Flight_minutesTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Flight_minutesTextBox.TabIndex = 45
        '
        'First_name_on_invoiceLabel
        '
        First_name_on_invoiceLabel.AutoSize = True
        First_name_on_invoiceLabel.Location = New System.Drawing.Point(484, 264)
        First_name_on_invoiceLabel.Name = "First_name_on_invoiceLabel"
        First_name_on_invoiceLabel.Size = New System.Drawing.Size(110, 13)
        First_name_on_invoiceLabel.TabIndex = 46
        First_name_on_invoiceLabel.Text = "First name on invoice:"
        '
        'First_name_on_invoiceComboBox
        '
        Me.First_name_on_invoiceComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "First_name_on_invoice", True))
        Me.First_name_on_invoiceComboBox.FormattingEnabled = True
        Me.First_name_on_invoiceComboBox.Location = New System.Drawing.Point(618, 261)
        Me.First_name_on_invoiceComboBox.Name = "First_name_on_invoiceComboBox"
        Me.First_name_on_invoiceComboBox.Size = New System.Drawing.Size(200, 21)
        Me.First_name_on_invoiceComboBox.TabIndex = 47
        '
        'Split_costLabel
        '
        Split_costLabel.AutoSize = True
        Split_costLabel.Location = New System.Drawing.Point(484, 293)
        Split_costLabel.Name = "Split_costLabel"
        Split_costLabel.Size = New System.Drawing.Size(53, 13)
        Split_costLabel.TabIndex = 48
        Split_costLabel.Text = "Split cost:"
        '
        'Split_costCheckBox
        '
        Me.Split_costCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.FlightsBindingSource, "Split_cost", True))
        Me.Split_costCheckBox.Location = New System.Drawing.Point(618, 288)
        Me.Split_costCheckBox.Name = "Split_costCheckBox"
        Me.Split_costCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.Split_costCheckBox.TabIndex = 49
        Me.Split_costCheckBox.Text = "CheckBox1"
        Me.Split_costCheckBox.UseVisualStyleBackColor = True
        '
        'Percent_1st_checkLabel
        '
        Percent_1st_checkLabel.AutoSize = True
        Percent_1st_checkLabel.Location = New System.Drawing.Point(484, 321)
        Percent_1st_checkLabel.Name = "Percent_1st_checkLabel"
        Percent_1st_checkLabel.Size = New System.Drawing.Size(97, 13)
        Percent_1st_checkLabel.TabIndex = 50
        Percent_1st_checkLabel.Text = "Percent 1st check:"
        '
        'Percent_1st_checkTextBox
        '
        Me.Percent_1st_checkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "Percent_1st_check", True))
        Me.Percent_1st_checkTextBox.Location = New System.Drawing.Point(618, 318)
        Me.Percent_1st_checkTextBox.Name = "Percent_1st_checkTextBox"
        Me.Percent_1st_checkTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Percent_1st_checkTextBox.TabIndex = 51
        '
        'Second_name_on_invoiceLabel
        '
        Second_name_on_invoiceLabel.AutoSize = True
        Second_name_on_invoiceLabel.Location = New System.Drawing.Point(484, 347)
        Second_name_on_invoiceLabel.Name = "Second_name_on_invoiceLabel"
        Second_name_on_invoiceLabel.Size = New System.Drawing.Size(128, 13)
        Second_name_on_invoiceLabel.TabIndex = 52
        Second_name_on_invoiceLabel.Text = "Second name on invoice:"
        '
        'Second_name_on_invoiceComboBox
        '
        Me.Second_name_on_invoiceComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "Second_name_on_invoice", True))
        Me.Second_name_on_invoiceComboBox.FormattingEnabled = True
        Me.Second_name_on_invoiceComboBox.Location = New System.Drawing.Point(618, 344)
        Me.Second_name_on_invoiceComboBox.Name = "Second_name_on_invoiceComboBox"
        Me.Second_name_on_invoiceComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Second_name_on_invoiceComboBox.TabIndex = 53
        '
        'Penalty_chargeLabel
        '
        Penalty_chargeLabel.AutoSize = True
        Penalty_chargeLabel.Location = New System.Drawing.Point(484, 376)
        Penalty_chargeLabel.Name = "Penalty_chargeLabel"
        Penalty_chargeLabel.Size = New System.Drawing.Size(81, 13)
        Penalty_chargeLabel.TabIndex = 54
        Penalty_chargeLabel.Text = "Penalty charge:"
        '
        'Penalty_chargeCheckBox
        '
        Me.Penalty_chargeCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.FlightsBindingSource, "Penalty_charge", True))
        Me.Penalty_chargeCheckBox.Location = New System.Drawing.Point(618, 371)
        Me.Penalty_chargeCheckBox.Name = "Penalty_chargeCheckBox"
        Me.Penalty_chargeCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.Penalty_chargeCheckBox.TabIndex = 55
        Me.Penalty_chargeCheckBox.Text = "CheckBox1"
        Me.Penalty_chargeCheckBox.UseVisualStyleBackColor = True
        '
        'Cost_this_flightLabel
        '
        Cost_this_flightLabel.AutoSize = True
        Cost_this_flightLabel.Location = New System.Drawing.Point(484, 404)
        Cost_this_flightLabel.Name = "Cost_this_flightLabel"
        Cost_this_flightLabel.Size = New System.Drawing.Size(75, 13)
        Cost_this_flightLabel.TabIndex = 56
        Cost_this_flightLabel.Text = "Cost this flight:"
        '
        'Cost_this_flightTextBox
        '
        Me.Cost_this_flightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "Cost_this_flight", True))
        Me.Cost_this_flightTextBox.Location = New System.Drawing.Point(618, 401)
        Me.Cost_this_flightTextBox.Name = "Cost_this_flightTextBox"
        Me.Cost_this_flightTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cost_this_flightTextBox.TabIndex = 57
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1114, 613)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.NewFlightsSavedHere, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlightsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlightsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlightsBindingNavigator.ResumeLayout(False)
        Me.FlightsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents NewFlightsSavedHere As NewFlightsSavedHere
    Friend WithEvents FlightsBindingSource As BindingSource
    Friend WithEvents FlightsTableAdapter As NewFlightsSavedHereTableAdapters.FlightsTableAdapter
    Friend WithEvents TableAdapterManager As NewFlightsSavedHereTableAdapters.TableAdapterManager
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
    Friend WithEvents Flight_refnumTextBox As TextBox
    Friend WithEvents Glider_Pilot_NameComboBox As ComboBox
    Friend WithEvents Instructor_nameComboBox As ComboBox
    Friend WithEvents Passenger_nameComboBox As ComboBox
    Friend WithEvents OD1ComboBox As ComboBox
    Friend WithEvents OD2ComboBox As ComboBox
    Friend WithEvents OD3ComboBox As ComboBox
    Friend WithEvents AOD1ComboBox As ComboBox
    Friend WithEvents AOD2ComboBox As ComboBox
    Friend WithEvents TowPilot1ComboBox As ComboBox
    Friend WithEvents TowPilot2ComboBox As ComboBox
    Friend WithEvents TowPilot3ComboBox As ComboBox
    Friend WithEvents TowPlane1ComboBox As ComboBox
    Friend WithEvents TowPlane2ComboBox As ComboBox
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents Glider_takeoff_timeTextBox As TextBox
    Friend WithEvents Glider_landing_timeTextBox As TextBox
    Friend WithEvents Tow_takeoff_timeTextBox As TextBox
    Friend WithEvents Tow_landing_timeTextBox As TextBox
    Friend WithEvents Altitude_towedTextBox As TextBox
    Friend WithEvents Rope_breakTextBox As TextBox
    Friend WithEvents Airport_nameTextBox As TextBox
    Friend WithEvents Flight_minutesTextBox As TextBox
    Friend WithEvents First_name_on_invoiceComboBox As ComboBox
    Friend WithEvents Split_costCheckBox As CheckBox
    Friend WithEvents Percent_1st_checkTextBox As TextBox
    Friend WithEvents Second_name_on_invoiceComboBox As ComboBox
    Friend WithEvents Penalty_chargeCheckBox As CheckBox
    Friend WithEvents Cost_this_flightTextBox As TextBox
End Class
