'Tori Gomez
'RCET0265   
'Spring 2021
'Diner Menu Program
'
Option Explicit On
Option Strict On
Public Class DinerMenuForm
    'Sub hides Order button and progressbar when no food is selected.
    Private Sub DinerMenuForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        OrderButton.Visible = False
        OrderdProgressBar.Visible = False
    End Sub
    'Sub Displays the Soup of the Day entree 
    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DisplaySpecialLabel.Text = "~ Soup of the Day ~" & vbNewLine _
            & vbNewLine & "~ Meatlovers Cream of Pizza Soup ~"
        OrderButton.Visible = True
    End Sub
    'Sub Displays the Chef's Special entree 
    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        DisplaySpecialLabel.Text = "~ Chef Gomez Special ~" & vbNewLine _
            & vbNewLine & "~ Tapatio Heat Pizza Salad ~" & vbNewLine _
            & "Buffalo Hot Chichken Wing meat without antibiotics," _
            & " Romaine, Mango Pineapple salsa tossed in Tapatio ranch dressing," _
            & " topped with Cotija Cheese, Jalapenos, and drizzled with Tapatio" _
            & " all in a Homemade Pizza dough crust bowl."
        OrderButton.Visible = True
    End Sub
    'Sub Displays the Daily Fish entree 
    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        DisplaySpecialLabel.Text = "~ Daily Fish ~" & vbNewLine _
            & vbNewLine & "~ Dragon Crab Kin Sushi Calzone ~" & vbNewLine _
            & "Freshly sliced Dragon Crab Kin sushi rolls and" _
            & " our signature gourmet Rice and Avacodo blend smothered" _
            & " in homemade Soy Heat Sauce and wrapped in a Seaweed green crust."
        OrderButton.Visible = True
    End Sub
    'Sub to order food when user selected food
    Private Sub OrderButton_Click(sender As Object, e As EventArgs) Handles OrderButton.Click
        OrderdProgressBar.Visible = True
        ProgressBarLoad()
        MsgBox("Thanks for your order!")
        Me.Close()
    End Sub
    'Sub loads the progress bar to send out order
    Sub ProgressBarLoad()
        For i = 0 To 10
            OrderdProgressBar.PerformStep()
        Next
    End Sub
    'Sub closes the program
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
