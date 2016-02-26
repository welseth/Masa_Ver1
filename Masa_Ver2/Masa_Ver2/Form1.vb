Public Class Form1
    Private Sub FlightsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FlightsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FlightsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NewFlightsSavedHere)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewFlightsSavedHere.Flights' table. You can move, or remove it, as needed.
        Me.FlightsTableAdapter.Fill(Me.NewFlightsSavedHere.Flights)

    End Sub
End Class
