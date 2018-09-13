<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Me.colorPicker1 = New ElaColorChooser.ElaColorPicker()
        Me.SuspendLayout()
        '
        'colorPicker1
        '
        Me.colorPicker1.Appearance = ElaColorChooser.ElaColorPicker.ColorPickerAppearance.EditableComboBox
        Me.colorPicker1.Location = New System.Drawing.Point(114, 101)
        Me.colorPicker1.Name = "colorPicker1"
        Me.colorPicker1.Size = New System.Drawing.Size(238, 23)
        Me.colorPicker1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 332)
        Me.Controls.Add(Me.colorPicker1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents colorPicker1 As ElaColorChooser.ElaColorPicker
End Class
