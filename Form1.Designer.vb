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
        LIBone = New ListBox()
        BTNshow = New Button()
        BTNclear = New Button()
        BTNexit = New Button()
        SuspendLayout()
        ' 
        ' LIBone
        ' 
        LIBone.FormattingEnabled = True
        LIBone.ItemHeight = 15
        LIBone.Location = New Point(317, 124)
        LIBone.Name = "LIBone"
        LIBone.Size = New Size(120, 94)
        LIBone.TabIndex = 0
        ' 
        ' BTNshow
        ' 
        BTNshow.Location = New Point(110, 346)
        BTNshow.Name = "BTNshow"
        BTNshow.Size = New Size(114, 55)
        BTNshow.TabIndex = 1
        BTNshow.Text = "Show Me!"
        BTNshow.UseVisualStyleBackColor = True
        ' 
        ' BTNclear
        ' 
        BTNclear.Location = New Point(317, 346)
        BTNclear.Name = "BTNclear"
        BTNclear.Size = New Size(95, 55)
        BTNclear.TabIndex = 2
        BTNclear.Text = "Clear"
        BTNclear.UseVisualStyleBackColor = True
        ' 
        ' BTNexit
        ' 
        BTNexit.Location = New Point(521, 346)
        BTNexit.Name = "BTNexit"
        BTNexit.Size = New Size(109, 55)
        BTNexit.TabIndex = 3
        BTNexit.Text = "Exit"
        BTNexit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BTNexit)
        Controls.Add(BTNclear)
        Controls.Add(BTNshow)
        Controls.Add(LIBone)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents LIBone As ListBox
    Friend WithEvents BTNshow As Button
    Friend WithEvents BTNclear As Button
    Friend WithEvents BTNexit As Button

End Class
