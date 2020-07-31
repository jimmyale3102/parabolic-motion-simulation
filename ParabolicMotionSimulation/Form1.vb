Public Class Form1

    'Variables de entrada
    Dim x0, y0 As Integer 'posicion inicial en x0 y y0 (enteros)
    Dim Vini, a As Integer 'velocidad inicial y angulo en grados (enteros)
    Dim g As Double 'gravedad (decimal)
    Dim t, totalTime As Double
    Dim x, y, Vx, Vy, Tv, VPro, hmax, hmaxProc As Double
    Dim piso As Integer 'piso
    Dim alto As Integer ' tamaño objeto
    Dim coox As Integer 'coordenada x de suelo
    Dim rebote As Integer 'Cantidad de rebotes
    Dim intervalo_timer As Integer



    Private Sub BoxX0_TextChanged(sender As Object, e As EventArgs) Handles BoxX0.TextChanged
        pelota.Left = coox + Val(BoxX0.Text)
    End Sub
    Private Sub Boxy0_TextChanged(sender As Object, e As EventArgs) Handles Boxy0.TextChanged
        pelota.Top = piso - alto - Val(Boxy0.Text)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'y = -0.5 * g * t * t + Vini * Math.Sin(a) * t + y0
        y = (Vini * Math.Sin(a) * t) - (0.5 * g * t * t) + y0
        x = (Vini * Math.Cos(a) * t) + x0
        Vy = (Vini * Math.Sin(a)) - (g * t)
        Vx = Vini * Math.Cos(a) * t
        Tv = (2 * Vini * Math.Sin(a)) / g
        VPro = Tv * t
        hmax = (Vini * Vini * Math.Sin(a)) / (2 * g)
        hmaxProc = hmax * y


        LabelY.Text = Math.Round(y, 2)
        LabelX.Text = Math.Round(x, 2)
        LabelvTx.Text = Math.Round(Vx, 2)
        LabelvTy.Text = Math.Round(Vy, 2)
        LabeltVue.Text = Math.Round(Tv, 2)
        LabelVprocess.Text = Math.Round(VPro, 2)
        LabelHmax.Text = Math.Round(hmax, 2)
        LabelhProcess.Text = Math.Round(hmaxProc, 2)

        pelota.Location = New Point(x + coox, piso - y - alto)

        Graficas.Chart1.Series(0).Points.AddXY(totalTime, x)
        Graficas.Chart2.Series(0).Points.AddXY(totalTime, y)
        Graficas.Chart3.Series(0).Points.AddXY(totalTime, Vx)
        Graficas.Chart4.Series(0).Points.AddXY(totalTime, Vy)

        t += 0.01
        totalTime += t
        If y <= 0 Then
            If rebote < 2 Then
                rebote += 1
                y0 = 1
                x0 = pelota.Location.X - coox
                t = 0
                Vini /= 2
            Else
                Timer1.Enabled = False
            End If
        End If
    End Sub



    Private Sub ButtonProcesar_Click(sender As Object, e As EventArgs) Handles ButtonProcesar.Click
        rebote = 0
        y0 = Boxy0.Text
        x0 = BoxX0.Text
        Vini = BoxVini.Text
        a = ToRadians(BoxAngulo.Text)
        g = BoxGravedad.Text
        intervalo_timer = BoxTimer.Text
        Timer1.Interval = intervalo_timer
        Timer1.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Graficas.Show()
        piso = PicturePiso.Location.Y
        alto = pelota.Height
        coox = PicturePiso.Location.X
        t = 0
        totalTime = t
    End Sub
    Private Sub ButtonReinicio_Click(sender As Object, e As EventArgs) Handles ButtonReinicio.Click
        Application.Restart()
    End Sub
    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Application.Exit()
    End Sub

    Private Sub ButtonMinimizar_Click(sender As Object, e As EventArgs) Handles ButtonMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Function ToRadians(grade As Integer) As Double
        Return (grade * Math.PI) / 180
    End Function

End Class
