Imports System.IO

Public Class Form1

    Dim cosas(0) As String

    Dim operando As Boolean = False
    Dim operador As Char = ""

    Dim n1 As Double = 0
    Dim n2 As Double = 0
    Dim n3 As Double = 0

    Private Sub num0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles num0.Click
        tx1.Text = (tx1.Text + "0")
    End Sub

    Private Sub num1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles num1.Click
        tx1.Text = (tx1.Text + "1")
    End Sub

    Private Sub num2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles num2.Click
        tx1.Text = (tx1.Text + "2")
    End Sub

    Private Sub num3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles num3.Click
        tx1.Text = (tx1.Text + "3")
    End Sub

    Private Sub num4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles num4.Click
        tx1.Text = (tx1.Text + "4")
    End Sub

    Private Sub num5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles num5.Click
        tx1.Text = (tx1.Text + "5")
    End Sub

    Private Sub num6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles num6.Click
        tx1.Text = (tx1.Text + "6")
    End Sub

    Private Sub num7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles num7.Click
        tx1.Text = (tx1.Text + "7")
    End Sub

    Private Sub num8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles num8.Click
        tx1.Text = (tx1.Text + "8")
    End Sub

    Private Sub num9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles num9.Click
        tx1.Text = (tx1.Text + "9")
    End Sub

    Private Sub point_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles point.Click
        tx1.Text = (tx1.Text + ",")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If operando = True Then
            calcular()
        End If
        tx1.Text = (tx1.Text + "/")
        operador = "/"
        operando = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If operando = True Then
            calcular()
        End If
        tx1.Text = (tx1.Text + "+")
        operador = "+"
        operando = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If operando = True Then
            calcular()
        End If
        tx1.Text = (tx1.Text + "-")
        operador = "-"
        operando = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If operando = True Then
            calcular()
        End If
        tx1.Text = (tx1.Text + "x")
        operador = "x"
        operando = True
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        calcular()
    End Sub

    Private Sub calcular()

        operando = False

        Dim aux As String = (tx1.Text.Split(operador))(0)

        n1 = Convert.ToDouble(aux)

        aux = (tx1.Text.Split(operador))(1)

        n2 = Convert.ToDouble(aux)

        Select Case operador
            Case "+"
                n3 = n1 + n2
                Exit Select
            Case "-"
                n3 = n1 - n2
                Exit Select
            Case "/"
                n3 = n1 / n2
            Case "x"
                n3 = n1 * n2
                Exit Select
        End Select

        cosas(cosas.Length - 1) = (tx1.Text + "=" + Str(n3))
        ReDim Preserve cosas(cosas.Length)
        cosas(cosas.Length - 1) = "."

        tx1.Text = Str(n3)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cosas(0) = "."

        If File.Exists("C:\Users\Usuario\items.txt") Then

            Dim line As String

            Dim sr As StreamReader

            Try
                sr = My.Computer.FileSystem.OpenTextFileReader("C:\Users\Usuario\items.txt")

                line = sr.ReadLine()
                While line <> ""

                    cosas(cosas.Length - 1) = line

                    ReDim Preserve cosas(cosas.Length)

                    cosas(cosas.Length - 1) = "."

                    line = sr.ReadLine()

                End While

                sr.Close()
            Catch ex As Exception
            End Try
            updat()
        End If
    End Sub

    Private Sub updat()
        lista.Items.Clear()
        For Each element As String In cosas
            lista.Items.Add(element)
        Next
    End Sub
    
    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        updat()
    End Sub

    Private Sub save()

        Dim sw As StreamWriter = New StreamWriter("C:\Users\Usuario\items.txt")

        Dim x As Integer = 0
        While x < cosas.Length - 1

            sw.WriteLine(cosas(x))

            x = x + 1
        End While

        sw.Close()

    End Sub

End Class
