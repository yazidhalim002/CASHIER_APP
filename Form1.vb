Imports System.Runtime.Intrinsics.X86

Public Class Form1
    Dim montant As Integer = 0
    Private Sub ONCE_Click(sender As Object, e As EventArgs) Handles ONCE.Click
        Dim item As String = list.SelectedItem
        orders.Items.Add(item & " x 1")
        If item = "jus d'orange" Then
            montant += 11
        ElseIf item = "jus de peche" Then
            montant += 13
        ElseIf item = "jus de panachi" Then
            montant += 15
        ElseIf item = "cafée cream" Then
            montant += 7
        ElseIf item = "cafée au lait" Then
            montant += 7
        ElseIf item = "lait au chocolat" Then
            montant += 8
        ElseIf item = "cafée italy" Then
            montant += 7
        ElseIf item = "lavazza" Then
            montant += 12
        ElseIf item = "cafée glassée" Then
            montant += 13
        ElseIf item = "chocolat chaude" Then
            montant += 20
        ElseIf item = "boisson gazeux" Then
            montant += 8
        ElseIf item = "crépe" Then
            montant += 9
        ElseIf item = "macaron" Then
            montant += 3
        ElseIf item = "croissant" Then
            montant += 2
        ElseIf item = "schneck" Then
            montant += 2
        End If
        price.Text = montant
    End Sub

    Private Sub TWICE_Click(sender As Object, e As EventArgs) Handles TWICE.Click
        Dim item As String = list.SelectedItem
        orders.Items.Add(item & " x 2")
        If item = "jus d'orange" Then
            montant += 11 * 2
        ElseIf item = "jus de peche" Then
            montant += 13 * 2
        ElseIf item = "jus de panachi" Then
            montant += 15 * 2
        ElseIf item = "cafée cream" Then
            montant += 7 * 2
        ElseIf item = "cafée au lait" Then
            montant += 7 * 2
        ElseIf item = "lait au chocolat" Then
            montant += 8 * 2
        ElseIf item = "cafée italy" Then
            montant += 7 * 2
        ElseIf item = "lavazza" Then
            montant += 12 * 2
        ElseIf item = "cafée glassée" Then
            montant += 13 * 2
        ElseIf item = "chocolat chaude" Then
            montant += 20 * 2
        ElseIf item = "boisson gazeux" Then
            montant += 8 * 2
        ElseIf item = "crépe" Then
            montant += 9 * 2
        ElseIf item = "macaron" Then
            montant += 3 * 2
        ElseIf item = "croissant" Then
            montant += 2 * 2
        ElseIf item = "schneck" Then
            montant += 2 * 2
        End If
        price.Text = montant
    End Sub

    Private Sub THIRD_Click(sender As Object, e As EventArgs) Handles THIRD.Click
        Dim item As String = list.SelectedItem
        orders.Items.Add(item & " x 3")
        If item = "jus d'orange" Then
            montant += 11 * 3
        ElseIf item = "jus de peche" Then
            montant += 13 * 3
        ElseIf item = "jus de panachi" Then
            montant += 15 * 3
        ElseIf item = "cafée cream" Then
            montant += 7 * 3
        ElseIf item = "cafée au lait" Then
            montant += 7 * 3
        ElseIf item = "lait au chocolat" Then
            montant += 8 * 3
        ElseIf item = "cafée italy" Then
            montant += 7 * 3
        ElseIf item = "lavazza" Then
            montant += 12 * 3
        ElseIf item = "cafée glassée" Then
            montant += 13 * 3
        ElseIf item = "chocolat chaude" Then
            montant += 20 * 3
        ElseIf item = "boisson gazeux" Then
            montant += 8 * 3
        ElseIf item = "crépe" Then
            montant += 9 * 3
        ElseIf item = "macaron" Then
            montant += 3 * 3
        ElseIf item = "croissant" Then
            montant += 2 * 3
        ElseIf item = "schneck" Then
            montant += 2 * 3
        End If
        price.Text = montant
    End Sub

    Private Sub DELETE_Click(sender As Object, e As EventArgs) Handles DELETE.Click
        Dim item As String = orders.SelectedItem
        orders.Items.Remove(item)
        If item = "jus d'orange x 1" Then
            montant -= 11
        ElseIf item = "jus de peche x 1" Then
            montant -= 13
        ElseIf item = "jus de panachi x 1" Then
            montant -= 15
        ElseIf item = "cafée cream x 1" Then
            montant -= 7
        ElseIf item = "cafée au lait x 1" Then
            montant -= 7
        ElseIf item = "lait au chocolat x 1" Then
            montant -= 8
        ElseIf item = "cafée italy x 1" Then
            montant -= 7
        ElseIf item = "lavazza x 1" Then
            montant -= 12
        ElseIf item = "cafée glassée x 1" Then
            montant -= 13
        ElseIf item = "chocolat chaude x 1" Then
            montant -= 20
        ElseIf item = "boisson gazeux x 1" Then
            montant -= 8
        ElseIf item = "crépe x 1" Then
            montant -= 9
        ElseIf item = "macaron x 1" Then
            montant -= 3
        ElseIf item = "croissant x 1" Then
            montant -= 2
        ElseIf item = "schneck x 1" Then
            montant -= 2
        ElseIf item = "jus d'orange x 2" Then
            montant -= 11 * 2
        ElseIf item = "jus de peche x 2" Then
            montant -= 13 * 2
        ElseIf item = "jus de panachi x 2" Then
            montant -= 15 * 2
        ElseIf item = "cafée cream x 2" Then
            montant -= 7 * 2
        ElseIf item = "cafée au lait x 2" Then
            montant -= 7 * 2
        ElseIf item = "lait au chocolat x 2" Then
            montant -= 8 * 2
        ElseIf item = "cafée italy x 2" Then
            montant -= 7 * 2
        ElseIf item = "lavazza x 2" Then
            montant -= 12 * 2
        ElseIf item = "cafée glassée x 2" Then
            montant -= 13 * 2
        ElseIf item = "chocolat chaude x 2" Then
            montant -= 20 * 2
        ElseIf item = "boisson gazeux x 2" Then
            montant -= 8 * 2
        ElseIf item = "crépe x 2" Then
            montant -= 9 * 2
        ElseIf item = "macaron x 2" Then
            montant -= 3 * 2
        ElseIf item = "croissant x 2" Then
            montant -= 2 * 2
        ElseIf item = "schneck x 2" Then
            montant -= 2 * 2
        ElseIf item = "jus d'orange x 3" Then
            montant -= 11 * 3
        ElseIf item = "jus de peche x 3" Then
            montant -= 13 * 3
        ElseIf item = "jus de panachi x 3" Then
            montant -= 15 * 3
        ElseIf item = "cafée cream x 3" Then
            montant -= 7 * 3
        ElseIf item = "cafée au lait x 3" Then
            montant -= 7 * 3
        ElseIf item = "lait au chocolat x 3" Then
            montant -= 8 * 3
        ElseIf item = "cafée italy x 3" Then
            montant -= 7 * 3
        ElseIf item = "lavazza x 3" Then
            montant -= 12 * 3
        ElseIf item = "cafée glassée x 3" Then
            montant -= 13 * 3
        ElseIf item = "chocolat chaude x 3" Then
            montant -= 20 * 3
        ElseIf item = "boisson gazeux x 3" Then
            montant -= 8 * 3
        ElseIf item = "crépe x 3" Then
            montant -= 9 * 3
        ElseIf item = "macaron x 3" Then
            montant -= 3 * 3
        ElseIf item = "croissant x 3" Then
            montant -= 2 * 3
        ElseIf item = "schneck x 3" Then
            montant -= 2 * 3
        End If
        price.Text = montant
    End Sub
End Class