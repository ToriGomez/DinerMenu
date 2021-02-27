<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DinerMenuForm
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
        Me.components = New System.ComponentModel.Container()
        Me.DinerNameLabel = New System.Windows.Forms.Label()
        Me.SoupButton = New System.Windows.Forms.Button()
        Me.SaladButton = New System.Windows.Forms.Button()
        Me.FishButton = New System.Windows.Forms.Button()
        Me.DisplaySpecialLabel = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DisplayGroupBox = New System.Windows.Forms.GroupBox()
        Me.OrderButton = New System.Windows.Forms.Button()
        Me.OrderdProgressBar = New System.Windows.Forms.ProgressBar()
        Me.TheGomezPizzeriaToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.DisplayGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'DinerNameLabel
        '
        Me.DinerNameLabel.AutoSize = True
        Me.DinerNameLabel.Font = New System.Drawing.Font("Niagara Engraved", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DinerNameLabel.Location = New System.Drawing.Point(142, -13)
        Me.DinerNameLabel.Name = "DinerNameLabel"
        Me.DinerNameLabel.Size = New System.Drawing.Size(812, 171)
        Me.DinerNameLabel.TabIndex = 0
        Me.DinerNameLabel.Text = "The Gomez Pizzeria"
        '
        'SoupButton
        '
        Me.SoupButton.BackColor = System.Drawing.Color.SeaShell
        Me.SoupButton.Font = New System.Drawing.Font("Niagara Engraved", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoupButton.Location = New System.Drawing.Point(115, 621)
        Me.SoupButton.Name = "SoupButton"
        Me.SoupButton.Size = New System.Drawing.Size(226, 138)
        Me.SoupButton.TabIndex = 1
        Me.SoupButton.Text = "&Soup"
        Me.SoupButton.UseVisualStyleBackColor = False
        '
        'SaladButton
        '
        Me.SaladButton.BackColor = System.Drawing.Color.SeaShell
        Me.SaladButton.Font = New System.Drawing.Font("Niagara Engraved", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaladButton.Location = New System.Drawing.Point(369, 621)
        Me.SaladButton.Name = "SaladButton"
        Me.SaladButton.Size = New System.Drawing.Size(223, 138)
        Me.SaladButton.TabIndex = 2
        Me.SaladButton.Text = "S&alad"
        Me.SaladButton.UseVisualStyleBackColor = False
        '
        'FishButton
        '
        Me.FishButton.BackColor = System.Drawing.Color.SeaShell
        Me.FishButton.Font = New System.Drawing.Font("Niagara Engraved", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FishButton.Location = New System.Drawing.Point(621, 621)
        Me.FishButton.Name = "FishButton"
        Me.FishButton.Size = New System.Drawing.Size(223, 138)
        Me.FishButton.TabIndex = 3
        Me.FishButton.Text = "F&ish"
        Me.FishButton.UseVisualStyleBackColor = False
        '
        'DisplaySpecialLabel
        '
        Me.DisplaySpecialLabel.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplaySpecialLabel.Location = New System.Drawing.Point(6, 27)
        Me.DisplaySpecialLabel.Name = "DisplaySpecialLabel"
        Me.DisplaySpecialLabel.Size = New System.Drawing.Size(1050, 425)
        Me.DisplaySpecialLabel.TabIndex = 0
        Me.DisplaySpecialLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Font = New System.Drawing.Font("Niagara Engraved", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(869, 634)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(154, 104)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'DisplayGroupBox
        '
        Me.DisplayGroupBox.Controls.Add(Me.OrderButton)
        Me.DisplayGroupBox.Controls.Add(Me.OrderdProgressBar)
        Me.DisplayGroupBox.Controls.Add(Me.DisplaySpecialLabel)
        Me.DisplayGroupBox.Location = New System.Drawing.Point(32, 129)
        Me.DisplayGroupBox.Name = "DisplayGroupBox"
        Me.DisplayGroupBox.Size = New System.Drawing.Size(1062, 471)
        Me.DisplayGroupBox.TabIndex = 4
        Me.DisplayGroupBox.TabStop = False
        '
        'OrderButton
        '
        Me.OrderButton.Font = New System.Drawing.Font("Niagara Engraved", 15.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderButton.Location = New System.Drawing.Point(52, 373)
        Me.OrderButton.Name = "OrderButton"
        Me.OrderButton.Size = New System.Drawing.Size(161, 79)
        Me.OrderButton.TabIndex = 1
        Me.OrderButton.Text = "&Order"
        Me.OrderButton.UseVisualStyleBackColor = True
        '
        'OrderdProgressBar
        '
        Me.OrderdProgressBar.Location = New System.Drawing.Point(804, 423)
        Me.OrderdProgressBar.Name = "OrderdProgressBar"
        Me.OrderdProgressBar.Size = New System.Drawing.Size(252, 29)
        Me.OrderdProgressBar.TabIndex = 2
        '
        'DinerMenuForm
        '
        Me.AcceptButton = Me.OrderButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(1183, 811)
        Me.Controls.Add(Me.DisplayGroupBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.FishButton)
        Me.Controls.Add(Me.SaladButton)
        Me.Controls.Add(Me.SoupButton)
        Me.Controls.Add(Me.DinerNameLabel)
        Me.Name = "DinerMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The Gomez Pizzeria"
        Me.DisplayGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DinerNameLabel As Label
    Friend WithEvents SoupButton As Button
    Friend WithEvents SaladButton As Button
    Friend WithEvents FishButton As Button
    Friend WithEvents DisplaySpecialLabel As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents DisplayGroupBox As GroupBox
    Friend WithEvents OrderButton As Button
    Friend WithEvents OrderdProgressBar As ProgressBar
    Friend WithEvents TheGomezPizzeriaToolTip As ToolTip
End Class
