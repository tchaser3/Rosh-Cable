<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreatePartNumberID
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCreatedTransactionID = New System.Windows.Forms.TextBox()
        Me.cboPrimaryKey = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(37, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 36)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Created Transaction ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(37, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Primary Key"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCreatedTransactionID
        '
        Me.txtCreatedTransactionID.Location = New System.Drawing.Point(152, 81)
        Me.txtCreatedTransactionID.Name = "txtCreatedTransactionID"
        Me.txtCreatedTransactionID.Size = New System.Drawing.Size(121, 20)
        Me.txtCreatedTransactionID.TabIndex = 10
        '
        'cboPrimaryKey
        '
        Me.cboPrimaryKey.FormattingEnabled = True
        Me.cboPrimaryKey.Location = New System.Drawing.Point(152, 46)
        Me.cboPrimaryKey.Name = "cboPrimaryKey"
        Me.cboPrimaryKey.Size = New System.Drawing.Size(121, 21)
        Me.cboPrimaryKey.TabIndex = 9
        '
        'CreatePartNumberID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 166)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCreatedTransactionID)
        Me.Controls.Add(Me.cboPrimaryKey)
        Me.Name = "CreatePartNumberID"
        Me.Text = "CreatePartNumberID"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCreatedTransactionID As System.Windows.Forms.TextBox
    Friend WithEvents cboPrimaryKey As System.Windows.Forms.ComboBox
End Class
