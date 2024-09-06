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
        labelA = New Label()
        textBoxA = New TextBox()
        calculateButton = New Button()
        labelB = New Label()
        labelC = New Label()
        textBoxB = New TextBox()
        textBoxC = New TextBox()
        labelResultAngleC = New Label()
        labelResultSideA = New Label()
        labelResultSideB = New Label()
        textBoxResultAngleC = New TextBox()
        textBoxResultSideB = New TextBox()
        textBoxResultSideA = New TextBox()
        SuspendLayout()
        ' 
        ' labelA
        ' 
        labelA.AutoSize = True
        labelA.Location = New Point(37, 9)
        labelA.Name = "labelA"
        labelA.Size = New Size(49, 15)
        labelA.TabIndex = 0
        labelA.Text = "Angle A"
        ' 
        ' textBoxA
        ' 
        textBoxA.Location = New Point(120, 1)
        textBoxA.Name = "textBoxA"
        textBoxA.Size = New Size(100, 23)
        textBoxA.TabIndex = 1
        ' 
        ' calculateButton
        ' 
        calculateButton.Location = New Point(135, 115)
        calculateButton.Name = "calculateButton"
        calculateButton.Size = New Size(75, 23)
        calculateButton.TabIndex = 2
        calculateButton.Text = "Calculate"
        calculateButton.UseVisualStyleBackColor = True
        ' 
        ' labelB
        ' 
        labelB.AutoSize = True
        labelB.FlatStyle = FlatStyle.Flat
        labelB.Location = New Point(37, 39)
        labelB.Name = "labelB"
        labelB.Size = New Size(48, 15)
        labelB.TabIndex = 3
        labelB.Text = "Angle B"
        ' 
        ' labelC
        ' 
        labelC.AutoSize = True
        labelC.Location = New Point(39, 73)
        labelC.Name = "labelC"
        labelC.Size = New Size(38, 15)
        labelC.TabIndex = 4
        labelC.Text = "Side c"
        ' 
        ' textBoxB
        ' 
        textBoxB.Location = New Point(120, 36)
        textBoxB.Name = "textBoxB"
        textBoxB.Size = New Size(100, 23)
        textBoxB.TabIndex = 1
        ' 
        ' textBoxC
        ' 
        textBoxC.Location = New Point(120, 70)
        textBoxC.Name = "textBoxC"
        textBoxC.Size = New Size(100, 23)
        textBoxC.TabIndex = 1
        ' 
        ' labelResultAngleC
        ' 
        labelResultAngleC.AutoSize = True
        labelResultAngleC.Location = New Point(37, 181)
        labelResultAngleC.Name = "labelResultAngleC"
        labelResultAngleC.Size = New Size(65, 15)
        labelResultAngleC.TabIndex = 6
        labelResultAngleC.Text = "Angle C (°)"
        ' 
        ' labelResultSideA
        ' 
        labelResultSideA.AutoSize = True
        labelResultSideA.Location = New Point(37, 222)
        labelResultSideA.Name = "labelResultSideA"
        labelResultSideA.Size = New Size(75, 15)
        labelResultSideA.TabIndex = 6
        labelResultSideA.Text = "Side a (units)"
        ' 
        ' labelResultSideB
        ' 
        labelResultSideB.AutoSize = True
        labelResultSideB.Location = New Point(37, 259)
        labelResultSideB.Name = "labelResultSideB"
        labelResultSideB.Size = New Size(79, 15)
        labelResultSideB.TabIndex = 6
        labelResultSideB.Text = "Side b (units):"
        ' 
        ' textBoxResultAngleC
        ' 
        textBoxResultAngleC.Location = New Point(120, 181)
        textBoxResultAngleC.Name = "textBoxResultAngleC"
        textBoxResultAngleC.Size = New Size(100, 23)
        textBoxResultAngleC.TabIndex = 1
        ' 
        ' textBoxResultSideB
        ' 
        textBoxResultSideB.Location = New Point(122, 256)
        textBoxResultSideB.Name = "textBoxResultSideB"
        textBoxResultSideB.Size = New Size(100, 23)
        textBoxResultSideB.TabIndex = 1
        ' 
        ' textBoxResultSideA
        ' 
        textBoxResultSideA.Location = New Point(120, 219)
        textBoxResultSideA.Name = "textBoxResultSideA"
        textBoxResultSideA.Size = New Size(100, 23)
        textBoxResultSideA.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(547, 416)
        Controls.Add(labelResultSideB)
        Controls.Add(labelResultSideA)
        Controls.Add(labelResultAngleC)
        Controls.Add(labelC)
        Controls.Add(labelB)
        Controls.Add(calculateButton)
        Controls.Add(textBoxResultSideA)
        Controls.Add(textBoxResultSideB)
        Controls.Add(textBoxResultAngleC)
        Controls.Add(textBoxC)
        Controls.Add(textBoxB)
        Controls.Add(textBoxA)
        Controls.Add(labelA)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents labelA As Label
    Friend WithEvents lblAngleA As TextBox
    Friend WithEvents calculateButton As Button
    Friend WithEvents labelB As Label
    Friend WithEvents labelC As Label
    Friend WithEvents lblSideB As TextBox
    Friend WithEvents lblSideC As TextBox
    Friend WithEvents lblAngleB As TextBox
    Friend WithEvents lblAngleC As TextBox
    Friend WithEvents textBoxA As TextBox
    Friend WithEvents textBoxB As TextBox
    Friend WithEvents textBoxC As TextBox
    Friend WithEvents labelResultAngleC As Label
    Friend WithEvents labelResultSideA As Label
    Friend WithEvents labelResultSideB As Label
    Friend WithEvents textBoxResultAngleC As TextBox
    Friend WithEvents textBoxResultSideB As TextBox
    Friend WithEvents textBoxResultSideA As TextBox

End Class
