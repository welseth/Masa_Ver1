Public Class Form1

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'EnterNewFlights.Flights' table. You can move, or remove it, as needed.
        Me.FlightsTableAdapter.Fill(Me.EnterNewFlights.Flights)
        'TODO: This line of code loads data into the 'EnterNewFlights_MemberNames.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.EnterNewFlights_MemberNames.Members)
        'TODO: This line of code loads data into the 'Binding2.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter13.Fill(Me.Binding2.Members)
        'TODO: This line of code loads data into the 'Binding2.Airport' table. You can move, or remove it, as needed.
        Me.AirportTableAdapter2.Fill(Me.Binding2.Airport)
        'TODO: This line of code loads data into the 'TowPilot3.Flights' table. You can move, or remove it, as needed.
        Me.FlightsTableAdapter2.Fill(Me.TowPilot3.Flights)
        'TODO: This line of code loads data into the 'BindingExperiment1.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter12.Fill(Me.ExperimentBinding1.Members)
        'TODO: This line of code loads data into the 'EditAllFlights.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter11.Fill(Me.EditAllFlights.Members)
        'TODO: This line of code loads data into the 'MASA_allDataSet.Flights' table. You can move, or remove it, as needed.
        Me.FlightsTableAdapter1.Fill(Me.MASA_allDataSet.Flights)
        'TODO: This line of code loads data into the 'EditAllFlights.Flights' table. You can move, or remove it, as needed.
        Me.FlightsTableAdapter.Fill(Me.EditAllFlights.Flights)
        'TODO: This line of code loads data into the 'EditAllAirport.Airport' table. You can move, or remove it, as needed.
        Me.AirportTableAdapter1.Fill(Me.EditAllAirport.Airport)
        'TODO: This line of code loads data into the 'EditAllAircraft.Aircraft' table. You can move, or remove it, as needed.
        Me.AircraftTableAdapter2.Fill(Me.EditAllAircraft.Aircraft)
        'TODO: This line of code loads data into the 'EditAllMembs.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter10.Fill(Me.EditAllMembs.Members)
        'TODO: This line of code loads data into the 'EditPilotNames.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter9.Fill(Me.EditPilotNames.Members)
        'TODO: This line of code loads data into the 'Airport1.Airport' table. You can move, or remove it, as needed.
        Me.AirportTableAdapter.Fill(Me.Airport1.Airport)
        'TODO: This line of code loads data into the 'TowPlane2.Aircraft' table. You can move, or remove it, as needed.
        Me.AircraftTableAdapter1.Fill(Me.TowPlane2.Aircraft)
        'TODO: This line of code loads data into the 'Airport1.Aircraft' table. You can move, or remove it, as needed.
        Me.AircraftTableAdapter.Fill(Me.Airport1.Aircraft)
        'TODO: This line of code loads data into the 'TowPilot3.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter8.Fill(Me.TowPilot3.Members)
        'TODO: This line of code loads data into the 'TowPilot2.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter7.Fill(Me.TowPilot2.Members)
        'TODO: This line of code loads data into the 'TowPilot1.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter6.Fill(Me.TowPilot1.Members)
        'TODO: This line of code loads data into the 'AOD2.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter5.Fill(Me.AOD2.Members)
        'TODO: This line of code loads data into the 'AOD1.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter4.Fill(Me.AOD1.Members)
        'TODO: This line of code loads data into the 'OD3.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter3.Fill(Me.OD3.Members)
        'TODO: This line of code loads data into the 'OD2.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter2.Fill(Me.OD2.Members)
        'TODO: This line of code loads data into the 'OD1.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter1.Fill(Me.OD1.Members)
        'TODO: This line of code loads data into the 'MASA_allDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.MASA_allDataSet.Members)

        'set the date/time picker to default to TODAY on form load.  Will let the user change the date
        ' but it defaults to now.
        DateTimePicker1.Value = DateTime.Now
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MembersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MembersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MASA_allDataSet)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NameComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub NameComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NameComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub NameComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub TabPage7_Click(sender As Object, e As EventArgs) Handles TabPage7.Click

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub TabPage8_Click(sender As Object, e As EventArgs) Handles TabPage8.Click

    End Sub

    Private Sub MembersBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MembersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EnterNewFlights_MemberNames)

    End Sub

    Private Sub FlightsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FlightsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FlightsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EnterNewFlights)

    End Sub


    '' Below text is SAMPLE way to populate text box from a DB.  Does NOT work yet, needs work.
    'Ctrl + K + C to comment
    '    Ctrl + K + U to uncomment
    ' testing Git!!
    'Public Class frmDataTable
    '    Private Sub frmDataTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '        Dim dt As New DataTable With {.TableName = "MyTable"}
    '        dt.Columns.Add(New DataColumn With {.ColumnName = "Identifier",
    '                                            .DataType = GetType(Int32),
    '                                            .AutoIncrement = True,
    '                                            .AutoIncrementStep = 100,
    '                                            .AutoIncrementSeed = 100})

    '        dt.Columns.Add(New DataColumn With {.ColumnName = "Name",
    '                                            .DataType = GetType(String)})

    '        dt.Columns.Add(New DataColumn With {.ColumnName = "ExtraData",
    '                                            .DataType = GetType(String)})


    '        dt.Rows.Add(New Object() {Nothing, "One", "Extra 1"})
    '        dt.Rows.Add(New Object() {Nothing, "Two", "Extra 2"})
    '        dt.Rows.Add(New Object() {Nothing, "Three", "Extra 3"})
    '        dt.Rows.Add(New Object() {Nothing, "Four", "Extra 4"})
    '        dt.Rows.Add(New Object() {Nothing, "Five", "Extra 5"})

    '        clbCheckedListBox.DataSource = dt
    '        clbCheckedListBox.DisplayMember = "Name"

    '    End Sub

    '    Private Sub cmdGetChecked_Click(sender As Object, e As EventArgs) Handles cmdGetChecked.Click
    '        If clbCheckedListBox.CheckedItems.Count > 0 Then
    '            Dim sb As New System.Text.StringBuilder
    '            For Each drv As DataRowView In clbCheckedListBox.CheckedItems
    '                sb.AppendLine(String.Join(",", drv.Row.ItemArray))
    '            Next
    '            MessageBox.Show(sb.ToString)
    '        End If
    '    End Sub
    'End Class


End Class
