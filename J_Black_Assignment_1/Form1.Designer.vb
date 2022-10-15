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
        Me.lblAdultSales = New System.Windows.Forms.Label()
        Me.lblPPT = New System.Windows.Forms.Label()
        Me.txtAdultPrice = New System.Windows.Forms.TextBox()
        Me.lblAdultTickets = New System.Windows.Forms.Label()
        Me.txtAdultSold = New System.Windows.Forms.TextBox()
        Me.lblCPPT = New System.Windows.Forms.Label()
        Me.PPT2 = New System.Windows.Forms.Label()
        Me.txtChildPrice = New System.Windows.Forms.TextBox()
        Me.lblChildTickets = New System.Windows.Forms.Label()
        Me.txtChildSold = New System.Windows.Forms.TextBox()
        Me.lblGrossRev = New System.Windows.Forms.Label()
        Me.lblNetRev = New System.Windows.Forms.Label()
        Me.lblAGTRSales = New System.Windows.Forms.Label()
        Me.lblCGTRSales = New System.Windows.Forms.Label()
        Me.txtAdultGTR = New System.Windows.Forms.TextBox()
        Me.txtChildGTR = New System.Windows.Forms.TextBox()
        Me.lblANTRSales = New System.Windows.Forms.Label()
        Me.txtAdultNTR = New System.Windows.Forms.TextBox()
        Me.lblCNTRSales = New System.Windows.Forms.Label()
        Me.txtChildNTR = New System.Windows.Forms.TextBox()
        Me.lblTotalGrossGTR = New System.Windows.Forms.Label()
        Me.txtTotalGTR = New System.Windows.Forms.TextBox()
        Me.lblTotalNet = New System.Windows.Forms.Label()
        Me.txtTotalNTR = New System.Windows.Forms.TextBox()
        Me.btnCalculateTR = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.lblTotalSold = New System.Windows.Forms.Label()
        Me.txtTotalSold = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblAdultSales
        '
        Me.lblAdultSales.AutoSize = True
        Me.lblAdultSales.Location = New System.Drawing.Point(12, 126)
        Me.lblAdultSales.Name = "lblAdultSales"
        Me.lblAdultSales.Size = New System.Drawing.Size(136, 20)
        Me.lblAdultSales.TabIndex = 0
        Me.lblAdultSales.Text = "Adult Ticket Sales"
        Me.lblAdultSales.UseWaitCursor = True
        '
        'lblPPT
        '
        Me.lblPPT.AutoSize = True
        Me.lblPPT.Location = New System.Drawing.Point(84, 168)
        Me.lblPPT.Name = "lblPPT"
        Me.lblPPT.Size = New System.Drawing.Size(122, 20)
        Me.lblPPT.TabIndex = 1
        Me.lblPPT.Text = "&Price Per Ticket:"
        Me.lblPPT.UseWaitCursor = True
        '
        'txtAdultPrice
        '
        Me.txtAdultPrice.Location = New System.Drawing.Point(212, 165)
        Me.txtAdultPrice.Name = "txtAdultPrice"
        Me.txtAdultPrice.Size = New System.Drawing.Size(115, 26)
        Me.txtAdultPrice.TabIndex = 2
        Me.txtAdultPrice.UseWaitCursor = True
        '
        'lblAdultTickets
        '
        Me.lblAdultTickets.AutoEllipsis = True
        Me.lblAdultTickets.AutoSize = True
        Me.lblAdultTickets.Location = New System.Drawing.Point(107, 206)
        Me.lblAdultTickets.Name = "lblAdultTickets"
        Me.lblAdultTickets.Size = New System.Drawing.Size(99, 20)
        Me.lblAdultTickets.TabIndex = 3
        Me.lblAdultTickets.Text = "&Tickets Sold:"
        Me.lblAdultTickets.UseWaitCursor = True
        '
        'txtAdultSold
        '
        Me.txtAdultSold.Location = New System.Drawing.Point(212, 203)
        Me.txtAdultSold.Name = "txtAdultSold"
        Me.txtAdultSold.Size = New System.Drawing.Size(115, 26)
        Me.txtAdultSold.TabIndex = 4
        Me.txtAdultSold.UseWaitCursor = True
        '
        'lblCPPT
        '
        Me.lblCPPT.AutoSize = True
        Me.lblCPPT.Location = New System.Drawing.Point(401, 126)
        Me.lblCPPT.Name = "lblCPPT"
        Me.lblCPPT.Size = New System.Drawing.Size(134, 20)
        Me.lblCPPT.TabIndex = 5
        Me.lblCPPT.Text = "Child Ticket Sales"
        Me.lblCPPT.UseWaitCursor = True
        '
        'PPT2
        '
        Me.PPT2.AutoSize = True
        Me.PPT2.Location = New System.Drawing.Point(413, 171)
        Me.PPT2.Name = "PPT2"
        Me.PPT2.Size = New System.Drawing.Size(122, 20)
        Me.PPT2.TabIndex = 6
        Me.PPT2.Text = "P&rice Per Ticket:"
        Me.PPT2.UseWaitCursor = True
        '
        'txtChildPrice
        '
        Me.txtChildPrice.Location = New System.Drawing.Point(541, 162)
        Me.txtChildPrice.Name = "txtChildPrice"
        Me.txtChildPrice.Size = New System.Drawing.Size(115, 26)
        Me.txtChildPrice.TabIndex = 7
        Me.txtChildPrice.UseWaitCursor = True
        '
        'lblChildTickets
        '
        Me.lblChildTickets.AutoEllipsis = True
        Me.lblChildTickets.AutoSize = True
        Me.lblChildTickets.Location = New System.Drawing.Point(436, 206)
        Me.lblChildTickets.Name = "lblChildTickets"
        Me.lblChildTickets.Size = New System.Drawing.Size(99, 20)
        Me.lblChildTickets.TabIndex = 8
        Me.lblChildTickets.Text = "Tic&kets Sold:"
        Me.lblChildTickets.UseWaitCursor = True
        '
        'txtChildSold
        '
        Me.txtChildSold.Location = New System.Drawing.Point(541, 200)
        Me.txtChildSold.Name = "txtChildSold"
        Me.txtChildSold.Size = New System.Drawing.Size(115, 26)
        Me.txtChildSold.TabIndex = 9
        Me.txtChildSold.UseWaitCursor = True
        '
        'lblGrossRev
        '
        Me.lblGrossRev.AutoSize = True
        Me.lblGrossRev.Location = New System.Drawing.Point(12, 260)
        Me.lblGrossRev.Name = "lblGrossRev"
        Me.lblGrossRev.Size = New System.Drawing.Size(166, 20)
        Me.lblGrossRev.TabIndex = 10
        Me.lblGrossRev.Text = "Gross Ticket Revenue"
        Me.lblGrossRev.UseWaitCursor = True
        '
        'lblNetRev
        '
        Me.lblNetRev.AutoSize = True
        Me.lblNetRev.Location = New System.Drawing.Point(401, 260)
        Me.lblNetRev.Name = "lblNetRev"
        Me.lblNetRev.Size = New System.Drawing.Size(148, 20)
        Me.lblNetRev.TabIndex = 11
        Me.lblNetRev.Text = "Net Ticket Revenue"
        Me.lblNetRev.UseWaitCursor = True
        '
        'lblAGTRSales
        '
        Me.lblAGTRSales.AutoSize = True
        Me.lblAGTRSales.Location = New System.Drawing.Point(68, 312)
        Me.lblAGTRSales.Name = "lblAGTRSales"
        Me.lblAGTRSales.Size = New System.Drawing.Size(140, 20)
        Me.lblAGTRSales.TabIndex = 12
        Me.lblAGTRSales.Text = "Adult Ticket Sales:"
        Me.lblAGTRSales.UseWaitCursor = True
        '
        'lblCGTRSales
        '
        Me.lblCGTRSales.AutoSize = True
        Me.lblCGTRSales.Location = New System.Drawing.Point(68, 347)
        Me.lblCGTRSales.Name = "lblCGTRSales"
        Me.lblCGTRSales.Size = New System.Drawing.Size(138, 20)
        Me.lblCGTRSales.TabIndex = 13
        Me.lblCGTRSales.Text = "Child Ticket Sales:"
        Me.lblCGTRSales.UseWaitCursor = True
        '
        'txtAdultGTR
        '
        Me.txtAdultGTR.Location = New System.Drawing.Point(212, 306)
        Me.txtAdultGTR.Name = "txtAdultGTR"
        Me.txtAdultGTR.Size = New System.Drawing.Size(115, 26)
        Me.txtAdultGTR.TabIndex = 14
        Me.txtAdultGTR.UseWaitCursor = True
        '
        'txtChildGTR
        '
        Me.txtChildGTR.Location = New System.Drawing.Point(212, 341)
        Me.txtChildGTR.Name = "txtChildGTR"
        Me.txtChildGTR.Size = New System.Drawing.Size(115, 26)
        Me.txtChildGTR.TabIndex = 15
        Me.txtChildGTR.UseWaitCursor = True
        '
        'lblANTRSales
        '
        Me.lblANTRSales.AutoSize = True
        Me.lblANTRSales.Location = New System.Drawing.Point(395, 312)
        Me.lblANTRSales.Name = "lblANTRSales"
        Me.lblANTRSales.Size = New System.Drawing.Size(140, 20)
        Me.lblANTRSales.TabIndex = 16
        Me.lblANTRSales.Text = "Adult Ticket Sales:"
        Me.lblANTRSales.UseWaitCursor = True
        '
        'txtAdultNTR
        '
        Me.txtAdultNTR.Location = New System.Drawing.Point(541, 309)
        Me.txtAdultNTR.Name = "txtAdultNTR"
        Me.txtAdultNTR.Size = New System.Drawing.Size(115, 26)
        Me.txtAdultNTR.TabIndex = 17
        Me.txtAdultNTR.UseWaitCursor = True
        '
        'lblCNTRSales
        '
        Me.lblCNTRSales.AutoSize = True
        Me.lblCNTRSales.Location = New System.Drawing.Point(397, 347)
        Me.lblCNTRSales.Name = "lblCNTRSales"
        Me.lblCNTRSales.Size = New System.Drawing.Size(138, 20)
        Me.lblCNTRSales.TabIndex = 18
        Me.lblCNTRSales.Text = "Child Ticket Sales:"
        Me.lblCNTRSales.UseWaitCursor = True
        '
        'txtChildNTR
        '
        Me.txtChildNTR.Location = New System.Drawing.Point(541, 341)
        Me.txtChildNTR.Name = "txtChildNTR"
        Me.txtChildNTR.Size = New System.Drawing.Size(115, 26)
        Me.txtChildNTR.TabIndex = 19
        Me.txtChildNTR.UseWaitCursor = True
        '
        'lblTotalGrossGTR
        '
        Me.lblTotalGrossGTR.AutoSize = True
        Me.lblTotalGrossGTR.Location = New System.Drawing.Point(48, 370)
        Me.lblTotalGrossGTR.Name = "lblTotalGrossGTR"
        Me.lblTotalGrossGTR.Size = New System.Drawing.Size(162, 40)
        Me.lblTotalGrossGTR.TabIndex = 20
        Me.lblTotalGrossGTR.Text = "Total Gross Revenue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "          for Ticket Sales:"
        Me.lblTotalGrossGTR.UseWaitCursor = True
        '
        'txtTotalGTR
        '
        Me.txtTotalGTR.Location = New System.Drawing.Point(212, 384)
        Me.txtTotalGTR.Name = "txtTotalGTR"
        Me.txtTotalGTR.Size = New System.Drawing.Size(115, 26)
        Me.txtTotalGTR.TabIndex = 21
        Me.txtTotalGTR.UseWaitCursor = True
        '
        'lblTotalNet
        '
        Me.lblTotalNet.AutoSize = True
        Me.lblTotalNet.Location = New System.Drawing.Point(389, 370)
        Me.lblTotalNet.Name = "lblTotalNet"
        Me.lblTotalNet.Size = New System.Drawing.Size(146, 40)
        Me.lblTotalNet.TabIndex = 22
        Me.lblTotalNet.Text = "Total Net Revenue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      for Ticket Sales:"
        Me.lblTotalNet.UseWaitCursor = True
        '
        'txtTotalNTR
        '
        Me.txtTotalNTR.Location = New System.Drawing.Point(541, 384)
        Me.txtTotalNTR.Name = "txtTotalNTR"
        Me.txtTotalNTR.Size = New System.Drawing.Size(115, 26)
        Me.txtTotalNTR.TabIndex = 23
        Me.txtTotalNTR.UseWaitCursor = True
        '
        'btnCalculateTR
        '
        Me.btnCalculateTR.Location = New System.Drawing.Point(52, 519)
        Me.btnCalculateTR.Name = "btnCalculateTR"
        Me.btnCalculateTR.Size = New System.Drawing.Size(212, 61)
        Me.btnCalculateTR.TabIndex = 24
        Me.btnCalculateTR.Text = "&Calculate Ticket Revenue"
        Me.btnCalculateTR.UseVisualStyleBackColor = True
        Me.btnCalculateTR.UseWaitCursor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(308, 519)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(150, 61)
        Me.btnClear.TabIndex = 25
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        Me.btnClear.UseWaitCursor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(506, 519)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 61)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        Me.btnExit.UseWaitCursor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 46)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(275, 26)
        Me.DateTimePicker1.TabIndex = 27
        Me.DateTimePicker1.UseWaitCursor = True
        '
        'lblTotalSold
        '
        Me.lblTotalSold.AutoSize = True
        Me.lblTotalSold.Location = New System.Drawing.Point(68, 444)
        Me.lblTotalSold.Name = "lblTotalSold"
        Me.lblTotalSold.Size = New System.Drawing.Size(138, 40)
        Me.lblTotalSold.TabIndex = 28
        Me.lblTotalSold.Text = "Total Tickets Sold " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                    Today:"
        Me.lblTotalSold.UseWaitCursor = True
        '
        'txtTotalSold
        '
        Me.txtTotalSold.Location = New System.Drawing.Point(212, 458)
        Me.txtTotalSold.Name = "txtTotalSold"
        Me.txtTotalSold.Size = New System.Drawing.Size(115, 26)
        Me.txtTotalSold.TabIndex = 29
        Me.txtTotalSold.UseWaitCursor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalculateTR
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(720, 632)
        Me.Controls.Add(Me.txtTotalSold)
        Me.Controls.Add(Me.lblTotalSold)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateTR)
        Me.Controls.Add(Me.txtTotalNTR)
        Me.Controls.Add(Me.lblTotalNet)
        Me.Controls.Add(Me.txtTotalGTR)
        Me.Controls.Add(Me.lblTotalGrossGTR)
        Me.Controls.Add(Me.txtChildNTR)
        Me.Controls.Add(Me.lblCNTRSales)
        Me.Controls.Add(Me.txtAdultNTR)
        Me.Controls.Add(Me.lblANTRSales)
        Me.Controls.Add(Me.txtChildGTR)
        Me.Controls.Add(Me.txtAdultGTR)
        Me.Controls.Add(Me.lblCGTRSales)
        Me.Controls.Add(Me.lblAGTRSales)
        Me.Controls.Add(Me.lblNetRev)
        Me.Controls.Add(Me.lblGrossRev)
        Me.Controls.Add(Me.txtChildSold)
        Me.Controls.Add(Me.lblChildTickets)
        Me.Controls.Add(Me.txtChildPrice)
        Me.Controls.Add(Me.PPT2)
        Me.Controls.Add(Me.lblCPPT)
        Me.Controls.Add(Me.txtAdultSold)
        Me.Controls.Add(Me.lblAdultTickets)
        Me.Controls.Add(Me.txtAdultPrice)
        Me.Controls.Add(Me.lblPPT)
        Me.Controls.Add(Me.lblAdultSales)
        Me.Name = "Form1"
        Me.Text = "Theater Revenue by Joel Black"
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAdultSales As Label
    Friend WithEvents lblPPT As Label
    Friend WithEvents txtAdultPrice As TextBox
    Friend WithEvents lblAdultTickets As Label
    Friend WithEvents txtAdultSold As TextBox
    Friend WithEvents lblCPPT As Label
    Friend WithEvents PPT2 As Label
    Friend WithEvents txtChildPrice As TextBox
    Friend WithEvents lblChildTickets As Label
    Friend WithEvents txtChildSold As TextBox
    Friend WithEvents lblGrossRev As Label
    Friend WithEvents lblNetRev As Label
    Friend WithEvents lblAGTRSales As Label
    Friend WithEvents lblCGTRSales As Label
    Friend WithEvents txtAdultGTR As TextBox
    Friend WithEvents txtChildGTR As TextBox
    Friend WithEvents lblANTRSales As Label
    Friend WithEvents txtAdultNTR As TextBox
    Friend WithEvents lblCNTRSales As Label
    Friend WithEvents txtChildNTR As TextBox
    Friend WithEvents lblTotalGrossGTR As Label
    Friend WithEvents txtTotalGTR As TextBox
    Friend WithEvents lblTotalNet As Label
    Friend WithEvents txtTotalNTR As TextBox
    Friend WithEvents btnCalculateTR As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents lblTotalSold As Label
    Friend WithEvents txtTotalSold As TextBox
End Class
