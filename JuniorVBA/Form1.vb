Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim var As String
        var = TextBox1.Text'ici j'attribut à la variable *var* la valeur de la textBox appelé *saisie* plus haut'

        'puis je commence la convertion cryptage'
        var = var.Replace(" ", "60")  'pour convertir l'espace en chiffre selon le tableau k tu as envoyé'
        var = var.Replace("b", "48")
        var = var.Replace("o", "50")
        var = var.Replace("n", "40")
        var = var.Replace("j", "42")
        var = var.Replace("o", "50")
        var = var.Replace("u", "26")
        var = var.Replace("r", "36")
        TextBox1.Text = var
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim var As String
        var = TextBox1.Text
        'ici j'attribut à la variable *var* la valeur de la textBox appelé *saisie* plus haut'

        'puis je commence la convertion decryptage'
        var = var.Replace("60", " ")  'pour convertir 60 en espace selon le tableau k tu as envoyé'
        var = var.Replace("48", "b")
        var = var.Replace("50", "o")
        var = var.Replace("40", "n")
        var = var.Replace("42", "j")
        var = var.Replace("50", "o")
        var = var.Replace("26", "u")
        var = var.Replace("36", "r")
        TextBox1.Text = var
    End Sub
End Class
