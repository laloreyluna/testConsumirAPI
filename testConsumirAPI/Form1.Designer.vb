<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnAPIJson = New System.Windows.Forms.Button()
        Me.btnAPIParametro = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(51, 30)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(169, 20)
        Me.txtID.TabIndex = 0
        '
        'btnAPIJson
        '
        Me.btnAPIJson.Location = New System.Drawing.Point(25, 98)
        Me.btnAPIJson.Name = "btnAPIJson"
        Me.btnAPIJson.Size = New System.Drawing.Size(179, 23)
        Me.btnAPIJson.TabIndex = 1
        Me.btnAPIJson.Text = "Consumir API Json"
        Me.btnAPIJson.UseVisualStyleBackColor = True
        '
        'btnAPIParametro
        '
        Me.btnAPIParametro.Location = New System.Drawing.Point(223, 98)
        Me.btnAPIParametro.Name = "btnAPIParametro"
        Me.btnAPIParametro.Size = New System.Drawing.Size(152, 23)
        Me.btnAPIParametro.TabIndex = 2
        Me.btnAPIParametro.Text = "Consumir API Parametro"
        Me.btnAPIParametro.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 142)
        Me.Controls.Add(Me.btnAPIParametro)
        Me.Controls.Add(Me.btnAPIJson)
        Me.Controls.Add(Me.txtID)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents btnAPIJson As Button
    Friend WithEvents btnAPIParametro As Button
End Class
