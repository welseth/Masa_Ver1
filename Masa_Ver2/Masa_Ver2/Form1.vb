Public Class Form1
    Private Sub FlightsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FlightsBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.FlightsBindingSource.EndEdit()
            Me.FlightsTableAdapterManager.UpdateAll(Me.NewFlightsSavedHere)
            MsgBox("Update Successful")

        Catch ex As Exception
            MsgBox("Update failed...")
        End Try

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FlightsInstructorName.Members' table. You can move, or remove it, as needed.
        Me.InstructorTableAdapter.Fill(Me.InstructorName.Members)
        'TODO: This line of code loads data into the 'FlightsGliderPilotName.Members' table. You can move, or remove it, as needed.
        Me.GliderPilotNameTableAdapter.Fill(Me.FlightsGliderPilotName.Members)
        'TODO: This line of code loads data into the 'NewFlightsSavedHere.Flights' table. You can move, or remove it, as needed.
        Me.FlightsTableAdapter.Fill(Me.NewFlightsSavedHere.Flights)

    End Sub


End Class
