'Danielle Allan
'5/2/16
'Allows user to record payroll for different kinds of employees'
'Has all GUI stuff & Allows user to record payroll'
'Wags imma miss you'

Public Class Form1
    Dim employees(10) As Employee
    'Creating an array'
    Dim employeeadded As Integer = -1
    'Making it start counting at one to the normal person'
    Dim salary As Integer

    Class Employee
        'Creating the abstract class named employee'
        Public A_Rate As Double
        Public A_Hour As Double
        Public Property Name() As String
        Public WriteOnly Property Rate() As Double
            Set(value As Double)
                A_Rate = value
            End Set
        End Property

        Public WriteOnly Property Hour() As Double
            Set(value As Double)
                A_Hour = value
            End Set
        End Property

        Overridable Function Grosspay() As Double
            'creating a gross pay method'
            Dim time As Double
            time = (A_Hour * A_Rate)
            Return time

        End Function
    End Class
    Class FullTime
        Inherits Employee

        Overrides Function Grosspay() As Double
            'Overriding the gross pay method'
            Dim time As Double
            time = A_Rate
            Return time
        End Function
    End Class

    Private Sub menuexit_Click(sender As Object, e As EventArgs) Handles menuexit.Click
        'Closes the program
        Me.Close()
    End Sub

    Private Sub menuabout_Click(sender As Object, e As EventArgs) Handles menuabout.Click
        'shows the about box'
        AboutBox1.Show()
    End Sub

    Private Sub btnrecord_Click(sender As Object, e As EventArgs) Handles btnrecord.Click
        Dim worker As Employee
        If radiosalary.Checked Then
            worker = New FullTime()
            salary += 1
        Else
            worker = New Employee()
        End If
        worker.Name = txtname.Text
        worker.Hour = CDbl(txthours.Text)
        worker.Rate = CDbl(txtrate.Text)
        employeeAdded += 1
        employees(employeeadded) = worker

        txtname.Clear()
        txthours.Clear()
        txtrate.Clear()
        MessageBox.Show("Employee " & employeeadded + 1 &
                         " recorded!")
        txtname.Focus()
    End Sub

    Private Sub btndisplay_Click(sender As Object, e As EventArgs) Handles btndisplay.Click
        ReDim Preserve employees(employeeadded)
        Dim query = From worker In employees
                    Select worker.Name, worker.A_Hour, worker.A_Rate, worker.Grosspay
        dgvdisplay.DataSource = query.ToList
        dgvdisplay.CurrentCell = Nothing
        dgvdisplay.Columns("Name").HeaderText = "Employee Name"
        dgvdisplay.Columns("A_Rate").HeaderText = "Rate"
        dgvdisplay.Columns("A_Hour").HeaderText = "Hours worked"
        txtname.Focus()


    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        lstreport.Items.Add("Total number of employees: " & employeeadded + 1)
        Dim query = From worker In employees
                    Select worker.Grosspay
        lstreport.Items.Add("Total number of salary:" & query.Sum.ToString)
        Dim query2 = From worker In employees
                     Select worker.A_Hour
        lstreport.Items.Add("Average hours worked:" & query2.Average.ToString)
        lstreport.Items.Add("Total of salaried employees:" & salary)

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        lstreport.Items.Add("Total number of employees: " & employeeadded + 1)
        Dim query = From worker In employees
                    Select worker.Grosspay
        lstreport.Items.Add("Total number of salary:" & query.Sum.ToString)
        Dim query2 = From worker In employees
                     Select worker.A_Hour
        lstreport.Items.Add("Average hours worked:" & query2.Average.ToString)
        lstreport.Items.Add("Total of salaried employees:" & salary)
    End Sub

    Private Sub menurecord_Click(sender As Object, e As EventArgs) Handles menurecord.Click
        Dim worker As Employee
        If radiosalary.Checked Then
            worker = New FullTime()
            salary += 1
        Else
            worker = New Employee()
        End If
        worker.Name = txtname.Text
        worker.Hour = CDbl(txthours.Text)
        worker.Rate = CDbl(txtrate.Text)
        employeeadded += 1
        employees(employeeadded) = worker

        txtname.Clear()
        txthours.Clear()
        txtrate.Clear()
        MessageBox.Show("Employee " & employeeadded + 1 &
                         " recorded!")
        txtname.Focus()
    End Sub

    Private Sub DisplayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayToolStripMenuItem.Click

    End Sub
End Class
