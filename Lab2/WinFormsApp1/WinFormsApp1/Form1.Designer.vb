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
        LabelR1 = New Label()
        TextBoxR1 = New TextBox()
        RadioButtonSeries = New RadioButton()
        ButtonCalculate = New Button()
        LabelR2 = New Label()
        LabelR3 = New Label()
        LabelR4 = New Label()
        TextBoxR2 = New TextBox()
        TextBoxR3 = New TextBox()
        TextBoxR4 = New TextBox()
        RadioButtonParallel = New RadioButton()
        LabelResult = New Label()
        LabelError = New Label()
        SuspendLayout()
        ' 
        ' LabelR1
        ' 
        LabelR1.AutoSize = True
        LabelR1.Location = New Point(34, 44)
        LabelR1.Name = "LabelR1"
        LabelR1.Size = New Size(20, 15)
        LabelR1.TabIndex = 0
        LabelR1.Text = "R1"
        ' 
        ' TextBoxR1
        ' 
        TextBoxR1.Location = New Point(149, 41)
        TextBoxR1.Name = "TextBoxR1"
        TextBoxR1.Size = New Size(100, 23)
        TextBoxR1.TabIndex = 1
        ' 
        ' RadioButtonSeries
        ' 
        RadioButtonSeries.AutoSize = True
        RadioButtonSeries.Location = New Point(354, 78)
        RadioButtonSeries.Name = "RadioButtonSeries"
        RadioButtonSeries.Size = New Size(55, 19)
        RadioButtonSeries.TabIndex = 2
        RadioButtonSeries.TabStop = True
        RadioButtonSeries.Text = "Series"
        RadioButtonSeries.UseVisualStyleBackColor = True
        ' 
        ' ButtonCalculate
        ' 
        ButtonCalculate.Location = New Point(165, 209)
        ButtonCalculate.Name = "ButtonCalculate"
        ButtonCalculate.Size = New Size(75, 23)
        ButtonCalculate.TabIndex = 3
        ButtonCalculate.Text = "Calculate"
        ButtonCalculate.UseVisualStyleBackColor = True
        ' 
        ' LabelR2
        ' 
        LabelR2.AutoSize = True
        LabelR2.Location = New Point(34, 82)
        LabelR2.Name = "LabelR2"
        LabelR2.Size = New Size(20, 15)
        LabelR2.TabIndex = 0
        LabelR2.Text = "R2"
        ' 
        ' LabelR3
        ' 
        LabelR3.AutoSize = True
        LabelR3.Location = New Point(34, 117)
        LabelR3.Name = "LabelR3"
        LabelR3.Size = New Size(20, 15)
        LabelR3.TabIndex = 0
        LabelR3.Text = "R3"
        ' 
        ' LabelR4
        ' 
        LabelR4.AutoSize = True
        LabelR4.Location = New Point(34, 152)
        LabelR4.Name = "LabelR4"
        LabelR4.Size = New Size(20, 15)
        LabelR4.TabIndex = 0
        LabelR4.Text = "R4"
        ' 
        ' TextBoxR2
        ' 
        TextBoxR2.Location = New Point(149, 74)
        TextBoxR2.Name = "TextBoxR2"
        TextBoxR2.Size = New Size(100, 23)
        TextBoxR2.TabIndex = 1
        ' 
        ' TextBoxR3
        ' 
        TextBoxR3.Location = New Point(149, 117)
        TextBoxR3.Name = "TextBoxR3"
        TextBoxR3.Size = New Size(100, 23)
        TextBoxR3.TabIndex = 1
        ' 
        ' TextBoxR4
        ' 
        TextBoxR4.Location = New Point(149, 150)
        TextBoxR4.Name = "TextBoxR4"
        TextBoxR4.Size = New Size(100, 23)
        TextBoxR4.TabIndex = 1
        ' 
        ' RadioButtonParallel
        ' 
        RadioButtonParallel.AutoSize = True
        RadioButtonParallel.Location = New Point(354, 113)
        RadioButtonParallel.Name = "RadioButtonParallel"
        RadioButtonParallel.Size = New Size(63, 19)
        RadioButtonParallel.TabIndex = 2
        RadioButtonParallel.TabStop = True
        RadioButtonParallel.Text = "Parallel"
        RadioButtonParallel.UseVisualStyleBackColor = True
        ' 
        ' LabelResult
        ' 
        LabelResult.AutoSize = True
        LabelResult.Location = New Point(34, 286)
        LabelResult.Name = "LabelResult"
        LabelResult.Size = New Size(39, 15)
        LabelResult.TabIndex = 0
        LabelResult.Text = "Result"
        ' 
        ' LabelError
        ' 
        LabelError.AutoSize = True
        LabelError.Location = New Point(354, 286)
        LabelError.Name = "LabelError"
        LabelError.Size = New Size(32, 15)
        LabelError.TabIndex = 0
        LabelError.Text = "Error"
        LabelError.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonCalculate)
        Controls.Add(RadioButtonParallel)
        Controls.Add(RadioButtonSeries)
        Controls.Add(TextBoxR4)
        Controls.Add(TextBoxR2)
        Controls.Add(TextBoxR3)
        Controls.Add(TextBoxR1)
        Controls.Add(LabelError)
        Controls.Add(LabelResult)
        Controls.Add(LabelR4)
        Controls.Add(LabelR3)
        Controls.Add(LabelR2)
        Controls.Add(LabelR1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelR1 As Label
    Friend WithEvents TextBoxR1 As TextBox
    Friend WithEvents RadioButtonSeries As RadioButton
    Friend WithEvents ButtonCalculate As Button
    Friend WithEvents LabelR2 As Label
    Friend WithEvents LabelR3 As Label
    Friend WithEvents LabelR4 As Label
    Friend WithEvents TextBoxR2 As TextBox
    Friend WithEvents TextBoxR3 As TextBox
    Friend WithEvents TextBoxR4 As TextBox
    Friend WithEvents RadioButtonParallel As RadioButton
    Friend WithEvents LabelResult As Label
    Friend WithEvents LabelError As Label

End Class
