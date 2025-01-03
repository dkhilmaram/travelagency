Public Class UserForm
    Private Const V As Boolean = True
    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Automatically generate columns based on the Flight structure
        DgvFlights.AutoGenerateColumns = V
    End Sub
    Private Sub btnSearchFlights_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim destination = TxtDestination.Text
        Dim dateFilter As Date
        Dim filteredFlights As List(Of SharedData.Flight)

        ' Filter flights by destination and date (if provided)
        If String.IsNullOrWhiteSpace(TxtSeats.Text) OrElse Not Date.TryParse(TxtSeats.Text, dateFilter) Then
            filteredFlights = SharedData.Flights.Where(Function(f) f.Destination.ToLower().Contains(destination.ToLower())).ToList()
        Else
            filteredFlights = SharedData.Flights.Where(Function(f) f.Destination.ToLower().Contains(destination.ToLower()) AndAlso f.DateTime.Date = dateFilter.Date).ToList()
        End If

        ' Update the DataGridView
        DgvFlights.DataSource = Nothing
        DgvFlights.DataSource = filteredFlights
    End Sub
    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles BtnBook.Click
        If DgvFlights.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a flight.", "Error")
            Return
        End If
        Dim newFlight As New Flight() With {
        .FlightNumber = TxtFlightNumber.Text,
        .Destination = TxtDestination.Text,
        .Seats = CInt(TxtSeats.Text),
        .BookedBy = ""
    }
        SharedData.Flights.Add(newFlight)
        MessageBox.Show("Flight added successfully!", "Success")

        ' Get selected flight
        Dim selectedFlight As SharedData.Flight = CType(DgvFlights.SelectedRows(0).DataBoundItem, SharedData.Flight)
        Dim selectedFlightIndex = SharedData.Flights.IndexOf(selectedFlight)

        ' Check seat availability
        If SharedData.Flights(selectedFlightIndex).Seats <= 0 Then
            MessageBox.Show("No seats available for this flight.", "Error")
            Return
        End If

        ' Get user details and update flight
        Dim bookedBy = $"{TxtName.Text} {TxtSurname.Text} (Phone: {TxtSurname.Text})"
        selectedFlight.Seats -= 1
        selectedFlight.BookedBy = bookedBy

        MessageBox.Show($"Flight booked successfully by {bookedBy}.", "Success")


        MessageBox.Show($"Flight booked successfully by {bookedBy}.", "Success")
    End Sub

    Private Sub DgvFlights_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvFlights.CellContentClick

    End Sub
End Class
