Option Strict On

Public Class Form1
    Private Sub btnCalculateTR_Click(sender As Object, e As EventArgs) Handles btnCalculateTR.Click

        'Set variables to a decimal value'

        Dim decTotalGTR As Decimal
        Dim decAdultGTR As Decimal
        Dim decChildGTR As Decimal
        Dim decTotalNTR As Decimal
        Dim decAdultNTR As Decimal
        Dim decChildNTR As Decimal
        Dim decTotalSold As Decimal
        Dim decAdultSold As Decimal
        Dim decChildSold As Decimal

        'Set variable to 0.2 for the 20% net revenue'

        Const decPercent As Decimal = CDec(0.2)

        Try
            'Calculate the total revenue from the adult ticket sales'

            decAdultGTR = CDec(txtAdultPrice.Text) * CDec(txtAdultSold.Text)

            'Convert the decimal number to a string' 

            txtAdultGTR.Text = decAdultGTR.ToString("c2")

            'Calculate the total revenue from child ticket saels'

            decChildGTR = CDec(txtChildPrice.Text) * CDec(txtChildSold.Text)
            txtChildGTR.Text = decChildGTR.ToString("c2")
            decTotalGTR = decAdultGTR + decChildGTR
            txtTotalGTR.Text = decTotalGTR.ToString("c2")

            'Calculate the net revenue at 20% of gross revenue'

            decAdultNTR = CDec(txtAdultGTR.Text) * decPercent
            txtAdultNTR.Text = decAdultNTR.ToString("c2")
            decChildNTR = CDec(txtChildGTR.Text) * decPercent
            txtChildNTR.Text = decChildNTR.ToString("c2")
            decTotalNTR = decAdultNTR + decChildNTR
            txtTotalNTR.Text = decTotalNTR.ToString("c2")

        Catch ex As Exception
            MessageBox.Show("Must enter a numeric value")
        End Try

        decTotalSold = decAdultSold + decChildSold
        txtTotalSold.Text = decTotalSold.ToString()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clear our the data entered by clicking the clear button' 

        txtAdultPrice.Clear()
        txtAdultSold.Clear()
        txtChildPrice.Clear()
        txtChildSold.Clear()
        txtAdultGTR.Clear()
        txtChildGTR.Clear()
        txtTotalGTR.Clear()
        txtAdultNTR.Clear()
        txtChildNTR.Clear()
        txtTotalNTR.Clear()

        'Use .Focus to bring the tab to the top'

        txtAdultPrice.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Use .close to exit out of the program' 

        Me.Close()

    End Sub

End Class
