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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnReceiveCable = New System.Windows.Forms.Button()
        Me.btnIssueCable = New System.Windows.Forms.Button()
        Me.btnReturnCable = New System.Windows.Forms.Button()
        Me.btnAddPartNumber = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCableAvailability = New System.Windows.Forms.Button()
        Me.btnCableUsage = New System.Windows.Forms.Button()
        Me.btnCableInTheField = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(276, 221)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(125, 57)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnReceiveCable
        '
        Me.btnReceiveCable.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceiveCable.Location = New System.Drawing.Point(12, 95)
        Me.btnReceiveCable.Name = "btnReceiveCable"
        Me.btnReceiveCable.Size = New System.Drawing.Size(125, 57)
        Me.btnReceiveCable.TabIndex = 0
        Me.btnReceiveCable.Text = "Receive Cable"
        Me.btnReceiveCable.UseVisualStyleBackColor = True
        '
        'btnIssueCable
        '
        Me.btnIssueCable.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssueCable.Location = New System.Drawing.Point(145, 95)
        Me.btnIssueCable.Name = "btnIssueCable"
        Me.btnIssueCable.Size = New System.Drawing.Size(125, 57)
        Me.btnIssueCable.TabIndex = 1
        Me.btnIssueCable.Text = "Issue Cable"
        Me.btnIssueCable.UseVisualStyleBackColor = True
        '
        'btnReturnCable
        '
        Me.btnReturnCable.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnCable.Location = New System.Drawing.Point(278, 95)
        Me.btnReturnCable.Name = "btnReturnCable"
        Me.btnReturnCable.Size = New System.Drawing.Size(125, 57)
        Me.btnReturnCable.TabIndex = 2
        Me.btnReturnCable.Text = "Return Cable"
        Me.btnReturnCable.UseVisualStyleBackColor = True
        '
        'btnAddPartNumber
        '
        Me.btnAddPartNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPartNumber.Location = New System.Drawing.Point(12, 158)
        Me.btnAddPartNumber.Name = "btnAddPartNumber"
        Me.btnAddPartNumber.Size = New System.Drawing.Size(125, 57)
        Me.btnAddPartNumber.TabIndex = 3
        Me.btnAddPartNumber.Text = "Add Part Number"
        Me.btnAddPartNumber.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.Location = New System.Drawing.Point(145, 221)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(125, 57)
        Me.btnReports.TabIndex = 7
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(391, 39)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Rosh Cable Main Menu"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCableAvailability
        '
        Me.btnCableAvailability.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCableAvailability.Location = New System.Drawing.Point(145, 158)
        Me.btnCableAvailability.Name = "btnCableAvailability"
        Me.btnCableAvailability.Size = New System.Drawing.Size(125, 57)
        Me.btnCableAvailability.TabIndex = 4
        Me.btnCableAvailability.Text = "Cable Availablility"
        Me.btnCableAvailability.UseVisualStyleBackColor = True
        '
        'btnCableUsage
        '
        Me.btnCableUsage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCableUsage.Location = New System.Drawing.Point(278, 158)
        Me.btnCableUsage.Name = "btnCableUsage"
        Me.btnCableUsage.Size = New System.Drawing.Size(125, 57)
        Me.btnCableUsage.TabIndex = 5
        Me.btnCableUsage.Text = "Cable Usage"
        Me.btnCableUsage.UseVisualStyleBackColor = True
        '
        'btnCableInTheField
        '
        Me.btnCableInTheField.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCableInTheField.Location = New System.Drawing.Point(12, 221)
        Me.btnCableInTheField.Name = "btnCableInTheField"
        Me.btnCableInTheField.Size = New System.Drawing.Size(125, 57)
        Me.btnCableInTheField.TabIndex = 6
        Me.btnCableInTheField.Text = "Cable In The Field"
        Me.btnCableInTheField.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 297)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCableInTheField)
        Me.Controls.Add(Me.btnCableUsage)
        Me.Controls.Add(Me.btnCableAvailability)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnAddPartNumber)
        Me.Controls.Add(Me.btnReturnCable)
        Me.Controls.Add(Me.btnIssueCable)
        Me.Controls.Add(Me.btnReceiveCable)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnReceiveCable As System.Windows.Forms.Button
    Friend WithEvents btnIssueCable As System.Windows.Forms.Button
    Friend WithEvents btnReturnCable As System.Windows.Forms.Button
    Friend WithEvents btnAddPartNumber As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCableAvailability As System.Windows.Forms.Button
    Friend WithEvents btnCableUsage As System.Windows.Forms.Button
    Friend WithEvents btnCableInTheField As System.Windows.Forms.Button

End Class
