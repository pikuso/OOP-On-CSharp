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
        LabelA = New Label()
        TextBoxA = New TextBox()
        ButtonCalculate = New Button()
        LabelB = New Label()
        LabelC = New Label()
        LabelError = New Label()
        TextBoxB = New TextBox()
        TextBoxR = New TextBox()
        TextBoxC = New TextBox()
        LabelResult = New Label()
        LabelR = New Label()
        SuspendLayout()
        ' 
        ' LabelA
        ' 
        LabelA.AutoSize = True
        LabelA.Location = New Point(28, 27)
        LabelA.Name = "LabelA"
        LabelA.Size = New Size(15, 15)
        LabelA.TabIndex = 0
        LabelA.Text = "A"
        ' 
        ' TextBoxA
        ' 
        TextBoxA.Location = New Point(120, 19)
        TextBoxA.Name = "TextBoxA"
        TextBoxA.Size = New Size(100, 23)
        TextBoxA.TabIndex = 1
        ' 
        ' ButtonCalculate
        ' 
        ButtonCalculate.Location = New Point(136, 166)
        ButtonCalculate.Name = "ButtonCalculate"
        ButtonCalculate.Size = New Size(75, 23)
        ButtonCalculate.TabIndex = 2
        ButtonCalculate.Text = "Calculate"
        ButtonCalculate.UseVisualStyleBackColor = True
        ' 
        ' LabelB
        ' 
        LabelB.AutoSize = True
        LabelB.Location = New Point(28, 57)
        LabelB.Name = "LabelB"
        LabelB.Size = New Size(14, 15)
        LabelB.TabIndex = 0
        LabelB.Text = "B"
        ' 
        ' LabelC
        ' 
        LabelC.AutoSize = True
        LabelC.Location = New Point(28, 90)
        LabelC.Name = "LabelC"
        LabelC.Size = New Size(15, 15)
        LabelC.TabIndex = 0
        LabelC.Text = "C"
        ' 
        ' LabelError
        ' 
        LabelError.AutoSize = True
        LabelError.Location = New Point(28, 285)
        LabelError.Name = "LabelError"
        LabelError.Size = New Size(32, 15)
        LabelError.TabIndex = 0
        LabelError.Text = "Error"
        LabelError.Visible = False
        ' 
        ' TextBoxB
        ' 
        TextBoxB.Location = New Point(120, 54)
        TextBoxB.Name = "TextBoxB"
        TextBoxB.Size = New Size(100, 23)
        TextBoxB.TabIndex = 1
        ' 
        ' TextBoxR
        ' 
        TextBoxR.Location = New Point(120, 123)
        TextBoxR.Name = "TextBoxR"
        TextBoxR.Size = New Size(100, 23)
        TextBoxR.TabIndex = 1
        ' 
        ' TextBoxC
        ' 
        TextBoxC.Location = New Point(120, 90)
        TextBoxC.Name = "TextBoxC"
        TextBoxC.Size = New Size(100, 23)
        TextBoxC.TabIndex = 1
        ' 
        ' LabelResult
        ' 
        LabelResult.AutoSize = True
        LabelResult.Location = New Point(28, 245)
        LabelResult.Name = "LabelResult"
        LabelResult.Size = New Size(39, 15)
        LabelResult.TabIndex = 0
        LabelResult.Text = "Result"
        ' 
        ' LabelR
        ' 
        LabelR.AutoSize = True
        LabelR.Location = New Point(27, 131)
        LabelR.Name = "LabelR"
        LabelR.Size = New Size(14, 15)
        LabelR.TabIndex = 0
        LabelR.Text = "R"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonCalculate)
        Controls.Add(TextBoxC)
        Controls.Add(TextBoxR)
        Controls.Add(TextBoxB)
        Controls.Add(TextBoxA)
        Controls.Add(LabelResult)
        Controls.Add(LabelError)
        Controls.Add(LabelR)
        Controls.Add(LabelC)
        Controls.Add(LabelB)
        Controls.Add(LabelA)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelA As Label
    Friend WithEvents TextBoxA As TextBox
    Friend WithEvents ButtonCalculate As Button
    Friend WithEvents LabelB As Label
    Friend WithEvents LabelC As Label
    Friend WithEvents LabelError As Label
    Friend WithEvents TextBoxB As TextBox
    Friend WithEvents TextBoxR As TextBox
    Friend WithEvents TextBoxC As TextBox
    Friend WithEvents LabelResult As Label
    Friend WithEvents LabelR As Label

End Class
