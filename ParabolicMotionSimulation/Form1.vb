Public Class Form1

    'Variables de entrada
    Dim x0, y0 As Integer 'posicion inicial en x0 y y0 (enteros)
    Dim Vini, a As Integer 'velocidad inicial y angulo en grados (enteros)
    Dim g As Double 'gravedad (decimal)
    Dim t As Double
    Dim x, y, Vx, Vy, Tv, VPro, hmax, hmaxProc As Double
    Dim piso As Integer 'piso
    Dim alto As Integer ' tamaño objeto
    Dim coox As Integer 'coordenada x de suelo
    Dim intervalo_timer As Integer

    Private Sub BoxX0_TextChanged(sender As Object, e As EventArgs) Handles BoxX0.TextChanged
        pelota.Left = coox + Val(BoxX0.Text)
    End Sub
    Private Sub Boxy0_TextChanged(sender As Object, e As EventArgs) Handles Boxy0.TextChanged
        pelota.Top = piso - alto - Val(Boxy0.Text)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        y = -0.5 * g * t * t + Vini * Math.Sin(a) * t + y0
        Vy = -g * t + Vini * Math.Sin(a)
        x = Vini * Math.Cos(a) * t + x0
        Vx = Vini * Math.Cos(a)
        'Tv = 2 * (Vini * Math.Sin(a) / g)
        'hmax = (Vini * Vini * Math.Sin(a) * Math.Sin(a) / 2 * g)

        LabelY.Text = y
        LabelX.Text = x
        LabelvTx.Text = Vx
        LabelvTy.Text = Vy

        'LabeltVue.Text = Tv
        '   LabelVprocess.Text =
        'LabelHmax.Text = hmax
        '  LabelhProcess.Text =

        pelota.Location = New Point(x + coox, piso - y - alto)

        'Form3.Chart1.Series(0).Points.AddXY(t, y)
        'Form3.Chart1.Series(1).Points.AddXY(t, vy)
        'Form3.Chart2.Series(0).Points.AddXY(t, x)
        'Form3.Chart2.Series(1).Points.AddXY(t, vx)

        t += 0.09
        If y <= 0 Then
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub ButtonProcesar_Click(sender As Object, e As EventArgs) Handles ButtonProcesar.Click
        y0 = Boxy0.Text
        x0 = BoxX0.Text
        Vini = BoxVini.Text
        a = ToRadians() BoxAngulo.Text
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

    Private Sub ToRadians(grade As Integer) As Double
        Return (grade * Math.PI) / 180
    End Sub

End Class
