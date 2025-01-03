<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        BtnSearch = New Button()
        TxtDestination = New TextBox()
        DgvFlights = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        BtnBook = New Button()
        TxtSeats = New TextBox()
        TxtName = New TextBox()
        TxtSurname = New TextBox()
        TxtPhone = New TextBox()
        TxtFlightnumber = New TextBox()
        CType(DgvFlights, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnSearch
        ' 
        BtnSearch.Location = New Point(569, 12)
        BtnSearch.Name = "BtnSearch"
        BtnSearch.Size = New Size(94, 29)
        BtnSearch.TabIndex = 0
        BtnSearch.Text = "Search"
        ' 
        ' TxtDestination
        ' 
        TxtDestination.Location = New Point(298, 13)
        TxtDestination.Name = "TxtDestination"
        TxtDestination.Size = New Size(125, 27)
        TxtDestination.TabIndex = 1
        ' 
        ' DgvFlights
        ' 
        DgvFlights.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvFlights.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        DgvFlights.Location = New Point(5, 115)
        DgvFlights.Name = "DgvFlights"
        DgvFlights.RowHeadersWidth = 51
        DgvFlights.Size = New Size(798, 288)
        DgvFlights.TabIndex = 2
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Flightnumber"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Destination"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Datetime"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "seats"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "price"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "bookedby"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.Width = 125
        ' 
        ' BtnBook
        ' 
        BtnBook.Location = New Point(569, 409)
        BtnBook.Name = "BtnBook"
        BtnBook.Size = New Size(143, 29)
        BtnBook.TabIndex = 3
        BtnBook.Text = "Book"
        ' 
        ' TxtSeats
        ' 
        TxtSeats.Location = New Point(438, 12)
        TxtSeats.Name = "TxtSeats"
        TxtSeats.Size = New Size(125, 27)
        TxtSeats.TabIndex = 4
        ' 
        ' TxtName
        ' 
        TxtName.Location = New Point(71, 411)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(125, 27)
        TxtName.TabIndex = 5
        ' 
        ' TxtSurname
        ' 
        TxtSurname.Location = New Point(203, 411)
        TxtSurname.Name = "TxtSurname"
        TxtSurname.Size = New Size(125, 27)
        TxtSurname.TabIndex = 6
        ' 
        ' TxtPhone
        ' 
        TxtPhone.Location = New Point(334, 410)
        TxtPhone.Name = "TxtPhone"
        TxtPhone.Size = New Size(125, 27)
        TxtPhone.TabIndex = 7
        ' 
        ' TxtFlightnumber
        ' 
        TxtFlightnumber.Location = New Point(167, 14)
        TxtFlightnumber.Name = "TxtFlightnumber"
        TxtFlightnumber.Size = New Size(125, 27)
        TxtFlightnumber.TabIndex = 8
        ' 
        ' UserForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TxtFlightnumber)
        Controls.Add(TxtPhone)
        Controls.Add(TxtSurname)
        Controls.Add(TxtName)
        Controls.Add(TxtSeats)
        Controls.Add(BtnBook)
        Controls.Add(DgvFlights)
        Controls.Add(TxtDestination)
        Controls.Add(BtnSearch)
        Name = "UserForm"
        Text = "UserForm"
        CType(DgvFlights, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnSearch As Button
    Friend WithEvents TxtDestination As TextBox
    Friend WithEvents DgvFlights As DataGridView
    Friend WithEvents BtnBook As Button
    Friend WithEvents TxtSeats As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtSurname As TextBox
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents TxtFlightnumber As TextBox
End Class
