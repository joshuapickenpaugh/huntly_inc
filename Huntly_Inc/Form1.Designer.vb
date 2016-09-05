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
        Me.txtGrossSales = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSalesReturns = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCostOfGoodsSold = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblGrossProfitRatio = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Gross sales:"
        '
        'txtGrossSales
        '
        Me.txtGrossSales.Location = New System.Drawing.Point(12, 25)
        Me.txtGrossSales.Name = "txtGrossSales"
        Me.txtGrossSales.Size = New System.Drawing.Size(100, 20)
        Me.txtGrossSales.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Sales returns:"
        '
        'txtSalesReturns
        '
        Me.txtSalesReturns.Location = New System.Drawing.Point(161, 25)
        Me.txtSalesReturns.Name = "txtSalesReturns"
        Me.txtSalesReturns.Size = New System.Drawing.Size(100, 20)
        Me.txtSalesReturns.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(295, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Cost of goods sold:"
        '
        'txtCostOfGoodsSold
        '
        Me.txtCostOfGoodsSold.Location = New System.Drawing.Point(298, 25)
        Me.txtCostOfGoodsSold.Name = "txtCostOfGoodsSold"
        Me.txtCostOfGoodsSold.Size = New System.Drawing.Size(100, 20)
        Me.txtCostOfGoodsSold.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(158, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Gross Profit Ratio:"
        '
        'lblGrossProfitRatio
        '
        Me.lblGrossProfitRatio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGrossProfitRatio.Location = New System.Drawing.Point(161, 121)
        Me.lblGrossProfitRatio.Name = "lblGrossProfitRatio"
        Me.lblGrossProfitRatio.Size = New System.Drawing.Size(100, 23)
        Me.lblGrossProfitRatio.TabIndex = 7
        Me.lblGrossProfitRatio.Text = " "
        Me.lblGrossProfitRatio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(46, 201)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 8
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(294, 201)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 305)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblGrossProfitRatio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCostOfGoodsSold)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSalesReturns)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtGrossSales)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Huntly, Inc."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtGrossSales As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSalesReturns As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCostOfGoodsSold As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblGrossProfitRatio As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
End Class
