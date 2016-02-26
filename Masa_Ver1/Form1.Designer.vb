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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.EnterNewFlights = New Masa_Ver1.EnterNewFlights()
        Me.FlightsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlightsTableAdapter = New Masa_Ver1.EnterNewFlightsTableAdapters.FlightsTableAdapter()
        Me.TableAdapterManager = New Masa_Ver1.EnterNewFlightsTableAdapters.TableAdapterManager()
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
        Me.Instructor_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Passenger_nameTextBox = New System.Windows.Forms.TextBox()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Flight_refnumLabel = New System.Windows.Forms.Label()
        Glider_Pilot_NameLabel = New System.Windows.Forms.Label()
        Instructor_nameLabel = New System.Windows.Forms.Label()
        Passenger_nameLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        CType(Me.EnterNewFlights, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(24, 49)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1025, 479)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Location = New System.Drawing.Point(4, 33)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1017, 442)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "OD/AOD/Tow Pilot Info"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.FlightsBindingNavigator)
        Me.TabPage2.Controls.Add(Flight_refnumLabel)
        Me.TabPage2.Controls.Add(Me.Flight_refnumTextBox)
        Me.TabPage2.Controls.Add(Glider_Pilot_NameLabel)
        Me.TabPage2.Controls.Add(Me.Glider_Pilot_NameComboBox)
        Me.TabPage2.Controls.Add(Instructor_nameLabel)
        Me.TabPage2.Controls.Add(Me.Instructor_nameTextBox)
        Me.TabPage2.Controls.Add(Passenger_nameLabel)
        Me.TabPage2.Controls.Add(Me.Passenger_nameTextBox)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Location = New System.Drawing.Point(4, 33)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1017, 442)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Enter New Flights"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(155, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(371, 24)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Experimenting w/ Binding, ok to delete"
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 33)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1017, 442)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Print Invoices"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.Location = New System.Drawing.Point(4, 33)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1017, 442)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Add Pilot Names"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.TabControl2)
        Me.TabPage5.Controls.Add(Me.Button2)
        Me.TabPage5.Controls.Add(Me.Button1)
        Me.TabPage5.Location = New System.Drawing.Point(4, 33)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1017, 442)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Admin Stuff"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Controls.Add(Me.TabPage7)
        Me.TabControl2.Controls.Add(Me.TabPage8)
        Me.TabControl2.Controls.Add(Me.TabPage9)
        Me.TabControl2.Location = New System.Drawing.Point(3, 3)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(898, 436)
        Me.TabControl2.TabIndex = 17
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 33)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(890, 399)
        Me.TabPage6.TabIndex = 0
        Me.TabPage6.Text = "Members"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'TabPage7
        '
        Me.TabPage7.AutoScroll = True
        Me.TabPage7.Location = New System.Drawing.Point(4, 33)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(890, 399)
        Me.TabPage7.TabIndex = 1
        Me.TabPage7.Text = "Aircraft"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'TabPage8
        '
        Me.TabPage8.Location = New System.Drawing.Point(4, 33)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(890, 399)
        Me.TabPage8.TabIndex = 2
        Me.TabPage8.Text = "Airport"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'TabPage9
        '
        Me.TabPage9.AutoScroll = True
        Me.TabPage9.Location = New System.Drawing.Point(4, 33)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(890, 399)
        Me.TabPage9.TabIndex = 3
        Me.TabPage9.Text = "Flights"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(912, 339)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 70)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Save DB Changes"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(907, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 46)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Edit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(68, 128)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(213, 24)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Parent/(name list, etc)"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(592, 128)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(229, 24)
        Me.Label18.TabIndex = 61
        Me.Label18.Text = "Child/Edit a NEW Flight"
        '
        'EnterNewFlights
        '
        Me.EnterNewFlights.DataSetName = "EnterNewFlights"
        Me.EnterNewFlights.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FlightsBindingSource
        '
        Me.FlightsBindingSource.DataMember = "Flights"
        Me.FlightsBindingSource.DataSource = Me.EnterNewFlights
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
        Me.TableAdapterManager.UpdateOrder = Masa_Ver1.EnterNewFlightsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FlightsBindingNavigator
        '
        Me.FlightsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FlightsBindingNavigator.BindingSource = Me.FlightsBindingSource
        Me.FlightsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FlightsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FlightsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.FlightsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FlightsBindingNavigatorSaveItem, Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.PrintToolStripButton, Me.toolStripSeparator, Me.CutToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.toolStripSeparator1, Me.HelpToolStripButton})
        Me.FlightsBindingNavigator.Location = New System.Drawing.Point(477, 88)
        Me.FlightsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FlightsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FlightsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FlightsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FlightsBindingNavigator.Name = "FlightsBindingNavigator"
        Me.FlightsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FlightsBindingNavigator.Size = New System.Drawing.Size(474, 25)
        Me.FlightsBindingNavigator.TabIndex = 5
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
        Flight_refnumLabel.Location = New System.Drawing.Point(489, 184)
        Flight_refnumLabel.Name = "Flight_refnumLabel"
        Flight_refnumLabel.Size = New System.Drawing.Size(139, 24)
        Flight_refnumLabel.TabIndex = 61
        Flight_refnumLabel.Text = "Flight refnum:"
        '
        'Flight_refnumTextBox
        '
        Me.Flight_refnumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "Flight_refnum", True))
        Me.Flight_refnumTextBox.Location = New System.Drawing.Point(744, 181)
        Me.Flight_refnumTextBox.Name = "Flight_refnumTextBox"
        Me.Flight_refnumTextBox.Size = New System.Drawing.Size(200, 29)
        Me.Flight_refnumTextBox.TabIndex = 62
        '
        'Glider_Pilot_NameLabel
        '
        Glider_Pilot_NameLabel.AutoSize = True
        Glider_Pilot_NameLabel.Location = New System.Drawing.Point(489, 219)
        Glider_Pilot_NameLabel.Name = "Glider_Pilot_NameLabel"
        Glider_Pilot_NameLabel.Size = New System.Drawing.Size(179, 24)
        Glider_Pilot_NameLabel.TabIndex = 63
        Glider_Pilot_NameLabel.Text = "Glider Pilot Name:"
        '
        'Glider_Pilot_NameComboBox
        '
        Me.Glider_Pilot_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "Glider_Pilot_Name", True))
        Me.Glider_Pilot_NameComboBox.FormattingEnabled = True
        Me.Glider_Pilot_NameComboBox.Location = New System.Drawing.Point(744, 216)
        Me.Glider_Pilot_NameComboBox.Name = "Glider_Pilot_NameComboBox"
        Me.Glider_Pilot_NameComboBox.Size = New System.Drawing.Size(200, 32)
        Me.Glider_Pilot_NameComboBox.TabIndex = 64
        '
        'Instructor_nameLabel
        '
        Instructor_nameLabel.AutoSize = True
        Instructor_nameLabel.Location = New System.Drawing.Point(489, 257)
        Instructor_nameLabel.Name = "Instructor_nameLabel"
        Instructor_nameLabel.Size = New System.Drawing.Size(160, 24)
        Instructor_nameLabel.TabIndex = 65
        Instructor_nameLabel.Text = "Instructor name:"
        '
        'Instructor_nameTextBox
        '
        Me.Instructor_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "Instructor_name", True))
        Me.Instructor_nameTextBox.Location = New System.Drawing.Point(744, 254)
        Me.Instructor_nameTextBox.Name = "Instructor_nameTextBox"
        Me.Instructor_nameTextBox.Size = New System.Drawing.Size(200, 29)
        Me.Instructor_nameTextBox.TabIndex = 66
        '
        'Passenger_nameLabel
        '
        Passenger_nameLabel.AutoSize = True
        Passenger_nameLabel.Location = New System.Drawing.Point(489, 292)
        Passenger_nameLabel.Name = "Passenger_nameLabel"
        Passenger_nameLabel.Size = New System.Drawing.Size(173, 24)
        Passenger_nameLabel.TabIndex = 67
        Passenger_nameLabel.Text = "Passenger name:"
        '
        'Passenger_nameTextBox
        '
        Me.Passenger_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FlightsBindingSource, "Passenger_name", True))
        Me.Passenger_nameTextBox.Location = New System.Drawing.Point(744, 289)
        Me.Passenger_nameTextBox.Name = "Passenger_nameTextBox"
        Me.Passenger_nameTextBox.Size = New System.Drawing.Size(200, 29)
        Me.Passenger_nameTextBox.TabIndex = 68
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton.Text = "&New"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenToolStripButton.Text = "&Open"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintToolStripButton.Text = "&Print"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'CutToolStripButton
        '
        Me.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), System.Drawing.Image)
        Me.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripButton.Name = "CutToolStripButton"
        Me.CutToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CutToolStripButton.Text = "C&ut"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CopyToolStripButton.Text = "&Copy"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), System.Drawing.Image)
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PasteToolStripButton.Text = "&Paste"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.HelpToolStripButton.Text = "He&lp"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FlightsBindingSource, "Glider_Pilot_Name", True))
        Me.ComboBox1.DataSource = Me.FlightsBindingSource
        Me.ComboBox1.DisplayMember = "Glider_Pilot_Name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(72, 184)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 32)
        Me.ComboBox1.TabIndex = 69
        Me.ComboBox1.ValueMember = "Glider_Pilot_Name"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 666)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Flight Sheet Entry"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        CType(Me.EnterNewFlights, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents EnterNewFlights As EnterNewFlights
    Friend WithEvents FlightsBindingSource As BindingSource
    Friend WithEvents FlightsTableAdapter As EnterNewFlightsTableAdapters.FlightsTableAdapter
    Friend WithEvents TableAdapterManager As EnterNewFlightsTableAdapters.TableAdapterManager
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
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents NewToolStripButton As ToolStripButton
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents PrintToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents CutToolStripButton As ToolStripButton
    Friend WithEvents CopyToolStripButton As ToolStripButton
    Friend WithEvents PasteToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents HelpToolStripButton As ToolStripButton
    Friend WithEvents Flight_refnumTextBox As TextBox
    Friend WithEvents Glider_Pilot_NameComboBox As ComboBox
    Friend WithEvents Instructor_nameTextBox As TextBox
    Friend WithEvents Passenger_nameTextBox As TextBox
End Class
