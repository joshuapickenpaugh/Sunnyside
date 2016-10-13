<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.rdoWholesale = New System.Windows.Forms.RadioButton()
        Me.rdoRetailer = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Units ordered:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoRetailer)
        Me.GroupBox1.Controls.Add(Me.rdoWholesale)
        Me.GroupBox1.Location = New System.Drawing.Point(160, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(134, 94)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer type:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(126, 20)
        Me.TextBox1.TabIndex = 3
        '
        'rdoWholesale
        '
        Me.rdoWholesale.AutoSize = True
        Me.rdoWholesale.Location = New System.Drawing.Point(19, 26)
        Me.rdoWholesale.Name = "rdoWholesale"
        Me.rdoWholesale.Size = New System.Drawing.Size(75, 17)
        Me.rdoWholesale.TabIndex = 0
        Me.rdoWholesale.TabStop = True
        Me.rdoWholesale.Text = "&Wholesale"
        Me.rdoWholesale.UseVisualStyleBackColor = True
        '
        'rdoRetailer
        '
        Me.rdoRetailer.AutoSize = True
        Me.rdoRetailer.Location = New System.Drawing.Point(19, 60)
        Me.rdoRetailer.Name = "rdoRetailer"
        Me.rdoRetailer.Size = New System.Drawing.Size(61, 17)
        Me.rdoRetailer.TabIndex = 1
        Me.rdoRetailer.TabStop = True
        Me.rdoRetailer.Text = "&Retailer"
        Me.rdoRetailer.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(135, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "TOTAL:"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(12, 148)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(292, 104)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 261)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sunnyside Products"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoRetailer As RadioButton
    Friend WithEvents rdoWholesale As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotal As Label
End Class
