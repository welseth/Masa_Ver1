Public Class Form1
    Private Sub FlightsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FlightsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FlightsBindingSource.EndEdit()
        Me.FlightsTableAdapterManager.UpdateAll(Me.MASA_allDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InstructorDataSet.Members' table. You can move, or remove it, as needed.
        Me.InstructorNameMembersTableAdapter.Fill(Me.InstructorDataSet.Members)
        'TODO: This line of code loads data into the 'MASA_allDataSet.Members' table. You can move, or remove it, as needed.
        Me.GliderPilotNameMembersTableAdapter.Fill(Me.MASA_allDataSet.Members)
        'TODO: This line of code loads data into the 'MASA_allDataSet.Flights' table. You can move, or remove it, as needed.
        Me.FlightsTableAdapter.Fill(Me.MASA_allDataSet.Flights)

    End Sub

    Private Sub MembersBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles GliderPilotNameMembersBindingSource.CurrentChanged

    End Sub
End Class
