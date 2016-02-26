Public Class Form1


    Private Sub FlightsBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles FlightsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FlightsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AddFlights)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AddFlights.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.AddFlights.Members)
        'TODO: This line of code loads data into the 'AddFlights.Flights' table. You can move, or remove it, as needed.
        Me.FlightsTableAdapter.Fill(Me.AddFlights.Flights)

    End Sub


End Class
