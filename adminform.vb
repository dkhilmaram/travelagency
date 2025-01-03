Public Class adminform
    Private Sub btnAddFlight_Click(sender As Object, e As EventArgs) Handles btnAddFlight.Click
        Try
            ' Create a new flight
            Dim flight As New SharedData.Flight With {
                .FlightNumber = TxtFlightNumber.Text,
                .Destination = TxtDestination.Text,
                .DateTime = DateTime.Parse(TxtDatetime.Text),
                .Seats = Integer.Parse(TxtSeats.Text),
                .Price = Decimal.Parse(TxtPrice.Text),
                .BookedBy = Nothing
            }

            ' Add the flight to the shared list
            SharedData.Flights.Add(flight)
            MessageBox.Show("Flight added successfully.", "Success")
            Dim userlogin As New userlogin()
            userlogin.Show()
            Me.Hide()


            ' Clear input fields
            TxtFlightNumber.Clear()
            txtDestination.Clear()
            TxtDatetime.Clear()
            TxtSeats.Clear()
            TxtPrice.Clear()

        Catch ex As Exception
            MessageBox.Show("Invalid input. Please try again.", "Error")

        End Try
    End Sub

    Private Sub adminform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
