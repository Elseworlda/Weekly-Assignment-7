Public Class Form1
    Dim inputVariable As Decimal
    Const perSong As Decimal = 2.99
    Const perHour As Decimal = 8.99
    Dim totalCost As Decimal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnTotal.Visible = False
        btnClear.Visible = False
        txtInput.Visible = False
        lblSubheader.Visible = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            lblSubheader.Text = "Number of Karaoke Songs: "
            lblSubheader.Visible = True
            btnClear.Visible = True
            btnTotal.Visible = True
            txtInput.Visible = True
            lblTotalCost.Visible = True
        ElseIf ComboBox1.SelectedIndex = 1 Then
            lblSubheader.Text = "Hourly Rental of Karaoke Room: "
            lblSubheader.Visible = True
            btnClear.Visible = True
            btnTotal.Visible = True
            txtInput.Visible = True
            lblTotalCost.Visible = True
        End If
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        If IsNumeric(txtInput.Text) Then
            inputVariable = Convert.ToDecimal(txtInput.Text)
            If ComboBox1.SelectedIndex = 0 Then
                totalCost = (inputVariable * perSong)
                lblTotalCost.Text = "Total Cost of Karaoke Night: " & totalCost.ToString("C2")
            ElseIf ComboBox1.SelectedIndex = 1 Then
                totalCost = (inputVariable * perHour)
                lblTotalCost.Text = "Total Cost of Karaoke Night: " & totalCost.ToString("C2")
            End If
        Else
            lblTotalCost.Text = "Input must be a number"
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        btnTotal.Visible = False
        btnClear.Visible = False
        txtInput.Visible = False
        txtInput.Text = ""
        lblSubheader.Visible = False
        lblTotalCost.Visible = False
        lblTotalCost.Text = ""
    End Sub
End Class