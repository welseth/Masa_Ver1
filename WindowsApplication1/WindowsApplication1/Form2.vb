' this is one example of binding forms to foreign keys.  Source is:
'  http://www.dreamincode.net/forums/topic/158096-binding-foreign-key-to-combobox/
'
'I have 2 tables

'Locations
'  location_refnbr(pk)
'  location_name
'  office_refnbr(fk)


'Offices
'  office_refnbr(pk)
'  office_name


Public Class Form2
    Private _LocationID As Integer
    Private FormIsLoading As Boolean

    'constructor You will see in Form one we will call the Form2 with a parameter
    Public Sub New(ByVal LocationID As Integer)
        _LocationID = LocationID
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'find out if the form is loading, if yes, ignore the "SelectedIndexChanged"
        'event of the ComboBox
        FormIsLoading = True

        'TODO: This line of code loads data into the 'DataSet1.Locations' table. You can move, or remove it, as needed.
        Me.OfficesTableAdapter.Fill(Me.DataSet1.Offices)

        'set the combobox to the datasources
        Me.ComboBox1.DataSource = Me.OfficesBindingSource
        Me.ComboBox1.DisplayMember = "office_name"
        Me.ComboBox1.ValueMember = "office_refnbr"

        'get all locations
        Me.LocationsTableAdapter.Fill(Me.DataSet1.Locations)

        'bind the locations to the comboboxes "SelectedValue"
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LocationsBindingSource, "office_refnbr", True))

        'find the Location From the Previous Form
        Dim Position As Integer = Me.LocationsBindingSource.Find("location_refnbr", _LocationID)
        If Position <> -1 Then
            Me.LocationsBindingSource.Position = Position
        End If

        'allow the combobox to do its work again.
        FormIsLoading = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        'if the form is not loading and the user changes the Office, we want to save
        If FormIsLoading = False Then
            'first validate all controls
            Me.Validate()
            'tell the bindingsource to go to end edit mode
            Me.LocationsBindingSource.EndEdit()
            'update the locations
            Me.LocationsTableAdapter.Update(Me.DataSet1.Locations)
        End If
    End Sub
End Class

