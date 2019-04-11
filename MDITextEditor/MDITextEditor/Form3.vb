Option Strict On

' Author:           Tyler Segovia
' Student Number:   100708131
' File Name:        NETD2201_Lab3_TylerSegovia
' Created:          2019-02-20
' Version:          1.0
' Description:      This program requests the number of units
'                   shipped for each day for the week, and 
'                   displays the average for that week. It 
'                   does this for three different employees, 
'                   and then calculates the total daily average.

Public Class AverageUnitsShippedForm

#Region "Variable and Constant Declaration"
    Const MIN_VALUE As Integer = 0                      ' minimum possible grade 
    Const MAX_VALUE As Integer = 1000                   ' maximum possible grade

    'stores user input for units shipped for every day of the week'
    Dim dailyUnitsShipped(2, 6) As Integer
    'a counter for the day of the week'
    Dim weekDay As Integer = 1
    'a number to identify each employee'
    Dim employeeId As Integer = 1
    'holds the total average units shipped 
    Dim averageDay As Double

#End Region

#Region "Functions and Subs"

    ''' <summary>
    '''     Validates inputed user data
    ''' </summary>
    ''' <param name="input">User input to be validated</param>
    ''' <returns>Whether the input was valid or invalid as boolean</returns>
    Function validateInput(ByVal input As String) As Boolean
        Dim inputNumber As Double                   ' holds user input as a double
        Dim isValidInput As Boolean = False         ' holds true/false if user input is valid

        Try
            inputNumber = CInt(input)                           ' try to cast input as an integer
            If (input.Equals(inputNumber.ToString)) Then        ' determines if input is a whole number
                If (inputNumber >= MIN_VALUE AndAlso inputNumber <= MAX_VALUE) Then
                    '                                           ' determines if input is within allowed range
                    isValidInput = True                         ' input is valid
                Else
                    ' outputs an error message box'
                    MessageBox.Show("Please enter a number between 0 and 1000!")
                End If
            End If
        Catch ex As Exception
            ' input is not valid
            ' outputs an error message box'
            MessageBox.Show("Please enter a real, whole number!")
            ' selects text to simplify re-entry'
            txtUnitsInput.SelectAll()
        End Try

        Return isValidInput     ' return that input is or is not valid
    End Function

    ''' <summary>
    '''     Calculates the average value of a provided array
    ''' </summary>
    Sub calculateAverageDay()

        'calculate the average and round it to two decimal places'

        Dim runningTotal As Double ' Holds a running total of the values in the array

        For employeeId = 0 To 2 ' Loop through the array
            For weekDay = 0 To 6 ' Loop through the array
                runningTotal += dailyUnitsShipped(employeeId, weekDay) ' Add the current value to the running total
            Next
        Next

        averageDay = Math.Round(runningTotal / 21, 2) ' Return the average value of the array, rounded to 2 decimal places
    End Sub

    ''' <summary>
    '''     Validates inputed user data
    ''' </summary>
    ''' <param name="employeeNumber">User input to be validated</param>
    ''' <returns>Whether the input was valid or invalid as boolean</returns>
    Function calculateAverageForEmployee(ByVal employeeNumber As Integer) As Double
        'calculate the average and round it to two decimal places'

        Dim runningTotal As Double ' Holds a running total of the values in the array
        Dim employeeAverage As Double ' a double to hold the average for the week for an employee
        Dim dayCounter As Integer ' increments through the days of the week

        For dayCounter = 0 To 6 ' Loop through the array
            runningTotal += dailyUnitsShipped(employeeNumber, dayCounter) ' Add the current value to the running total
        Next

        employeeAverage = Math.Round(runningTotal / 7, 2) ' Return the average value of the array, rounded to 2 decimal places

        Return employeeAverage     ' return that input is or is not valid
    End Function

#End Region

#Region "Event Handlers"

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exit the application
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Resets the application
        txtUnitsInput.Text = ""
        txtEmployee1Display.Text = ""
        txtEmployee2Display.Text = ""
        txtEmployee3Display.Text = ""
        lblEmployee1Average.Text = ""
        lblEmployee2Average.Text = ""
        lblEmployee3Average.Text = ""
        lblTotalAverage.Text = ""

        lblDayCounter.Text = "Day 1"
        weekDay = 1
        employeeId = 1
        Array.Clear(dailyUnitsShipped, 0, dailyUnitsShipped.Length)
        txtUnitsInput.Focus()
        txtUnitsInput.ReadOnly = False
        btnEnter.Enabled = True
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        If employeeId <= 3 Then

            'Decides whether program should process another day, or calculate the average'
            If weekDay <= 7 Then

                If validateInput(txtUnitsInput.Text) Then
                    'convert the user input to integer, and store it in an array'
                    dailyUnitsShipped(employeeId - 1, weekDay - 1) = Convert.ToInt16(txtUnitsInput.Text)

                    If employeeId = 1 Then
                        If weekDay = 1 Then
                            'display the entry in txtDailyUnitsList'
                            txtEmployee1Display.Text = dailyUnitsShipped(employeeId - 1, weekDay - 1).ToString
                        Else
                            'keep previous entries and add new entry onto new line of textbox'
                            txtEmployee1Display.Text = txtEmployee1Display.Text & vbCrLf & dailyUnitsShipped(employeeId - 1, weekDay - 1).ToString
                        End If
                    ElseIf employeeId = 2 Then
                        If weekDay = 1 Then
                            'display the entry in txtDailyUnitsList'
                            txtEmployee2Display.Text = dailyUnitsShipped(employeeId - 1, weekDay - 1).ToString
                        Else
                            'keep previous entries and add new entry onto new line of textbox'
                            txtEmployee2Display.Text = txtEmployee2Display.Text & vbCrLf & dailyUnitsShipped(employeeId - 1, weekDay - 1).ToString
                        End If
                    ElseIf employeeId = 3 Then
                        If weekDay = 1 Then
                            'display the entry in txtDailyUnitsList'
                            txtEmployee3Display.Text = dailyUnitsShipped(employeeId - 1, weekDay - 1).ToString
                        Else
                            'keep previous entries and add new entry onto new line of textbox'
                            txtEmployee3Display.Text = txtEmployee3Display.Text & vbCrLf & dailyUnitsShipped(employeeId - 1, weekDay - 1).ToString
                        End If
                    End If

                    'clear the input textbox'
                    txtUnitsInput.Text = ""

                    'add 1 to the counter to prompt the next day'
                    weekDay = weekDay + 1

                End If

                If weekDay <= 7 Then
                    'change day of week in label for next entry'
                    lblDayCounter.Text = "Day " & weekDay

                    'set focus to input text box and select text
                    txtUnitsInput.Focus()
                    txtUnitsInput.SelectAll()
                Else
                    'set the input textbox to read only'
                    txtUnitsInput.ReadOnly = True
                    'sets the focus to the enter button'
                    btnEnter.Focus()
                End If

            Else

                'output employee average for each employee in respective labels
                'calls function to calculate average
                Select Case employeeId
                    Case 1
                        lblEmployee1Average.Text = "Average: " & calculateAverageForEmployee(employeeId - 1).ToString()
                    Case 2
                        lblEmployee2Average.Text = "Average: " & calculateAverageForEmployee(employeeId - 1).ToString()
                    Case Else
                        lblEmployee3Average.Text = "Average: " & calculateAverageForEmployee(employeeId - 1).ToString()
                End Select

                'increment to next employee and set weekDay back to 1
                employeeId += 1
                weekDay = 1

                If employeeId <= 3 Then
                    'change day of week in label for next entry'
                    lblDayCounter.Text = "Day " & weekDay

                    'set the input textbox to write'
                    txtUnitsInput.ReadOnly = False

                    'set focus to input text box
                    txtUnitsInput.Focus()
                Else
                    'sets the focus to the enter button'
                    btnEnter.Focus()
                End If

            End If

        Else
            'prompt the sub routine to calculate average
            calculateAverageDay()

            'display the average in lblAverageOutput'
            lblTotalAverage.Text = "Average per day: " & averageDay
            'disables the enter button'
            btnEnter.Enabled = False
            'sets the focus to the reset button'
            btnReset.Focus()
        End If
    End Sub

#End Region

End Class
