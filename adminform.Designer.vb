<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminform
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
        TxtFlightNumber = New TextBox()
        TxtDestination = New TextBox()
        TxtDatetime = New TextBox()
        TxtSeats = New TextBox()
        TxtPrice = New TextBox()
        BtnAddFlight = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' TxtFlightNumber
        ' 
        TxtFlightNumber.Location = New Point(268, 86)
        TxtFlightNumber.Name = "TxtFlightNumber"
        TxtFlightNumber.Size = New Size(197, 27)
        TxtFlightNumber.TabIndex = 0
        ' 
        ' TxtDestination
        ' 
        TxtDestination.Location = New Point(268, 139)
        TxtDestination.Name = "TxtDestination"
        TxtDestination.Size = New Size(197, 27)
        TxtDestination.TabIndex = 1
        ' 
        ' TxtDatetime
        ' 
        TxtDatetime.Location = New Point(268, 200)
        TxtDatetime.Name = "TxtDatetime"
        TxtDatetime.Size = New Size(197, 27)
        TxtDatetime.TabIndex = 2
        ' 
        ' TxtSeats
        ' 
        TxtSeats.Location = New Point(268, 260)
        TxtSeats.Name = "TxtSeats"
        TxtSeats.Size = New Size(197, 27)
        TxtSeats.TabIndex = 3
        ' 
        ' TxtPrice
        ' 
        TxtPrice.Location = New Point(268, 323)
        TxtPrice.Name = "TxtPrice"
        TxtPrice.Size = New Size(197, 27)
        TxtPrice.TabIndex = 4
        ' 
        ' BtnAddFlight
        ' 
        BtnAddFlight.Location = New Point(300, 384)
        BtnAddFlight.Name = "BtnAddFlight"
        BtnAddFlight.Size = New Size(139, 29)
        BtnAddFlight.TabIndex = 5
        BtnAddFlight.Text = "Addflight"
        BtnAddFlight.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(268, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 20)
        Label1.TabIndex = 6
        Label1.Text = "Flight number:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(268, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 20)
        Label2.TabIndex = 7
        Label2.Text = "Destination :" & vbCrLf
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(268, 177)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 20)
        Label3.TabIndex = 8
        Label3.Text = "Date :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(268, 237)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 20)
        Label4.TabIndex = 9
        Label4.Text = "Seat :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(268, 300)
        Label5.Name = "Label5"
        Label5.Size = New Size(48, 20)
        Label5.TabIndex = 10
        Label5.Text = "Price :"
        ' 
        ' adminform
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnAddFlight)
        Controls.Add(TxtPrice)
        Controls.Add(TxtSeats)
        Controls.Add(TxtDatetime)
        Controls.Add(TxtDestination)
        Controls.Add(TxtFlightNumber)
        Name = "adminform"
        Text = "adminform"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtFlightNumber As TextBox
    Friend WithEvents TxtDestination As TextBox
    Friend WithEvents TxtDatetime As TextBox
    Friend WithEvents TxtSeats As TextBox
    Friend WithEvents TxtPrice As TextBox
    Friend WithEvents BtnAddFlight As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
