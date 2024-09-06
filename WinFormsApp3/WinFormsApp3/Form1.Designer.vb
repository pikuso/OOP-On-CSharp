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
        textBoxName = New TextBox()
        buttonShowGreeting = New Button()
        pictureBoxSignature = New PictureBox()
        labelGreeting = New Label()
        PicSign = New PictureBox()
        CType(pictureBoxSignature, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicSign, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' textBoxName
        ' 
        textBoxName.BackColor = Color.LavenderBlush
        textBoxName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        textBoxName.Location = New Point(347, 57)
        textBoxName.Name = "textBoxName"
        textBoxName.Size = New Size(100, 29)
        textBoxName.TabIndex = 0
        ' 
        ' buttonShowGreeting
        ' 
        buttonShowGreeting.BackgroundImageLayout = ImageLayout.Center
        buttonShowGreeting.Location = New Point(360, 111)
        buttonShowGreeting.Name = "buttonShowGreeting"
        buttonShowGreeting.Size = New Size(75, 23)
        buttonShowGreeting.TabIndex = 2
        buttonShowGreeting.Text = "Show Greeting"
        buttonShowGreeting.UseVisualStyleBackColor = True
        ' 
        ' pictureBoxSignature
        ' 
        pictureBoxSignature.Image = My.Resources.Resources.zalya
        pictureBoxSignature.Location = New Point(12, 179)
        pictureBoxSignature.Name = "pictureBoxSignature"
        pictureBoxSignature.Size = New Size(232, 246)
        pictureBoxSignature.TabIndex = 2
        pictureBoxSignature.TabStop = False
        pictureBoxSignature.Visible = False
        ' 
        ' labelGreeting
        ' 
        labelGreeting.AutoSize = True
        labelGreeting.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        labelGreeting.Location = New Point(500, 162)
        labelGreeting.Name = "labelGreeting"
        labelGreeting.Size = New Size(73, 21)
        labelGreeting.TabIndex = 3
        labelGreeting.Text = "Greeting"
        ' 
        ' PicSign
        ' 
        PicSign.Image = My.Resources.Resources.Volodymyr_Zelensky_signature
        PicSign.Location = New Point(133, 266)
        PicSign.Name = "PicSign"
        PicSign.Size = New Size(419, 307)
        PicSign.TabIndex = 4
        PicSign.TabStop = False
        PicSign.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(854, 661)
        Controls.Add(labelGreeting)
        Controls.Add(pictureBoxSignature)
        Controls.Add(buttonShowGreeting)
        Controls.Add(textBoxName)
        Controls.Add(PicSign)
        Name = "Form1"
        SizeGripStyle = SizeGripStyle.Show
        Text = "Form1"
        TopMost = True
        CType(pictureBoxSignature, ComponentModel.ISupportInitialize).EndInit()
        CType(PicSign, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents textBoxName As TextBox
    Friend WithEvents buttonShowGreeting As Button
    Friend WithEvents pictureBoxSignature As PictureBox
    Friend WithEvents labelGreeting As Label
    Friend WithEvents PicSign As PictureBox

End Class
