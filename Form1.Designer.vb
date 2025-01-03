<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BtnLogin = New Button()
        Label1 = New Label()
        Txtusername = New TextBox()
        Label2 = New Label()
        TxtPassword = New TextBox()
        SuspendLayout()
        ' 
        ' BtnLogin
        ' 
        BtnLogin.Location = New Point(345, 213)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(106, 29)
        BtnLogin.TabIndex = 0
        BtnLogin.Text = "Login"
        BtnLogin.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(302, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 20)
        Label1.TabIndex = 1
        Label1.Text = "Enter name:"
        ' 
        ' Txtusername
        ' 
        Txtusername.Location = New Point(302, 68)
        Txtusername.Name = "Txtusername"
        Txtusername.Size = New Size(197, 27)
        Txtusername.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(302, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 20)
        Label2.TabIndex = 3
        Label2.Text = "Enter password:"
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Location = New Point(302, 152)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.Size = New Size(197, 27)
        TxtPassword.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TxtPassword)
        Controls.Add(Label2)
        Controls.Add(Txtusername)
        Controls.Add(Label1)
        Controls.Add(BtnLogin)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Txtusername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPassword As TextBox

End Class
