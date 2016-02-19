Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Locations' table. You can move, or remove it, as needed.
        Me.LocationsTableAdapter.Fill(Me.DataSet1.Locations)
        Me.cboLocations.DataSource = Me.LocationsBindingSource
        Me.cboLocations.DisplayMember = "location_name"
        Me.cboLocations.ValueMember = "location_refnbr"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'see we pass the SelectedValue, which is actually the ValueMember
        'but make sure the user has actually selected something
        If cboLocations.SelectedIndex = -1 Then
            MessageBox.Show("No Location Selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'leave here since there is no location
            Exit Sub
        End If
        'open the Form2
        Dim MyOffices As New Form2(cboLocations.SelectedValue)
        MyOffices.ShowDialog()
    End Sub
End Class




