Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim arreglo2 As Array
        Dim arreglo3 As Array
        Dim i As Int32
        Dim nombres() As String = {"Medico cirujano partero", "Ingenieria Industrial", "Seconf", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""}
        'Dim escuelas() As String={}
        'Dim ubicacion() As String={}
        arreglo2 = TEST.valores
        Dim mayor As Double
        For j = 0 To 2
            mayor = 0
            For i = 0 To arreglo2.Length - 1
                If (mayor < arreglo2(i)) Then
                    mayor = arreglo2(i)
                End If
            Next i
            For i = 0 To arreglo2.Length - 1
                If (arreglo2(i) = mayor) Then
                    TextBox1.Text = TextBox1.Text + vbCrLf + "Carreras:" + nombres(i) '+"Centro Universitario: "+escuelas(i)+"Ubicación: "+ubicacion(i)
                    arreglo2(i) = 0
                End If



            Next i
        Next j






    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click




    End Sub
End Class