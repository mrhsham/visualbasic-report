<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View
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
        Me.RPTView = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'RPTView
        '
        Me.RPTView.ActiveViewIndex = -1
        Me.RPTView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RPTView.Cursor = System.Windows.Forms.Cursors.Default
        Me.RPTView.DisplayStatusBar = False
        Me.RPTView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RPTView.Location = New System.Drawing.Point(0, 0)
        Me.RPTView.Name = "RPTView"
        Me.RPTView.Size = New System.Drawing.Size(487, 237)
        Me.RPTView.TabIndex = 0
        Me.RPTView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 237)
        Me.Controls.Add(Me.RPTView)
        Me.Name = "View"
        Me.Text = "View"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RPTView As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
