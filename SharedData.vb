' Module for shared data
Module SharedData
    ' Define flight structure
    Public Structure Flight
        Public FlightNumber As String
        Public Destination As String
        Public DateTime As Date
        Public Seats As Integer
        Public Price As Decimal
        Public BookedBy As String ' For storing user details after booking
    End Structure

    ' Shared list of flights
    Public Flights As New List(Of Flight)
End Module
