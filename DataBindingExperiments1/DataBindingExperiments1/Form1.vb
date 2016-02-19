
' This example is from:  http://www.vb-tips.com/DataBindingEvents.aspx
'
'The Binding Events helps you To Set your data In the proper way In your controls. 
'This is a kind of standard routine for a textbox on one site of the binding And a 
'datetime column from a datarow/datatable On the other site.

'The sample needs only a form With a textbox And two buttons dragged On it

'(The sample Is based on VB10SP1 And newer style). 

'Be aware this sample is made with version VB10SP1
'for VSN versions before that you should add Byval in the passing attributes 
'To try this you can create a new project with one textbox and two buttons
'with default names on it. 
'The sample shows 3 dates from which the second is nothing and then shows spaces
'Don't forget to change the dates to see what happens

Public Class Form1
    Private DTable As New DataTable
    Private WithEvents MyBinding As Binding
    Private Sub Form1_Load(ByVal sender As System.Object,
        ByVal e As System.EventArgs) Handles Me.Load
        'In memory creation of a testtable
        DTable.Columns.Add("DateField", GetType(System.DateTime))
        DTable.LoadDataRow(New Object() {New DateTime(2011, 11, 1)}, True)
        DTable.LoadDataRow(New Object() {New DateTime(2011, 11, 2)}, True)
        DTable.LoadDataRow(New Object() {New DateTime(2011, 11, 3)}, True)
        DTable.LoadDataRow(New Object() {New DateTime(2011, 11, 4)}, True)

        'Set the binding
        MyBinding = New Binding("Text", DTable, "DateField")
        TextBox1.DataBindings.Add(MyBinding)
        'Give the buttons a name
        Button1.Text = "Forward"
        Button2.Text = "Backward"
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, e As EventArgs) Handles Button1.Click
        'forward
        If BindingContext(DTable).Position < DTable.Rows.Count Then
            BindingContext(DTable).Position += 1
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        'backward
        If BindingContext(DTable).Position > 0 Then
            BindingContext(DTable).Position -= 1
        End If
    End Sub

    Private Sub Format(sender As Object, e As ConvertEventArgs) Handles MyBinding.Format
        If e.Value Is DBNull.Value Then
            e.Value = ""
        Else
            e.Value = CDate(e.Value).ToString("d")
        End If
    End Sub

    Private Sub Parse(ByVal sender As Object, e As ConvertEventArgs) Handles MyBinding.Parse
        If e.Value.ToString = "" Then
            e.Value = DBNull.Value
        Else
            e.Value = CDate(e.Value)
        End If
    End Sub

End Class



