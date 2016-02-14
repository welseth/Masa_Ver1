Public Class Form1

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'MASA_allDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.MASA_allDataSet.Members)
        'TODO: This line of code loads data into the 'MASA_allDataSet.Aircraft' table. You can move, or remove it, as needed.
        Me.AircraftTableAdapter.Fill(Me.MASA_allDataSet.Aircraft)

        'Below line sets the date/time picker to default to TODAY on form load.  It will let the user change the date
        ' but it defaults to now when the form opens.
        DateTimePicker1.Value = DateTime.Now
    End Sub





    '' Below text is SAMPLE way to populate text box from a DB.  Does NOT work yet, needs work.
    'Ctrl + K + C to comment
    '    Ctrl + K + U to uncomment
    ' testing Git!!
    'another change, this is for the branch
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
