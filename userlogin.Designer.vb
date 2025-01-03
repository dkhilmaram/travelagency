<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userlogin
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
        Label1 = New Label()
        Label2 = New Label()
        BtnLogin = New Button()
        TxtUserName = New TextBox()
        TxtPassword = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(282, 76)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 20)
        Label1.TabIndex = 0
        Label1.Text = "Enter Name :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(282, 162)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 20)
        Label2.TabIndex = 1
        Label2.Text = "Enter Password :"
        ' 
        ' BtnLogin
        ' 
        BtnLogin.Location = New Point(333, 272)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(94, 29)
        BtnLogin.TabIndex = 2
        BtnLogin.Text = "Login"
        BtnLogin.UseVisualStyleBackColor = True
        ' 
        ' TxtUserName
        ' 
        TxtUserName.Location = New Point(282, 112)
        TxtUserName.Name = "TxtUserName"
        TxtUserName.Size = New Size(221, 27)
        TxtUserName.TabIndex = 3
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Location = New Point(282, 206)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.Size = New Size(221, 27)
        TxtPassword.TabIndex = 4
        ' 
        ' userlogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TxtPassword)
        Controls.Add(TxtUserName)
        Controls.Add(BtnLogin)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "userlogin"
        Text = "userlogin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnLogin As Button
    Friend WithEvents TxtUserName As TextBox
    Friend WithEvents TxtPassword As TextBox
End Class
