<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PanelCabecera = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonMinimizar = New System.Windows.Forms.Button()
        Me.ButtonCerrar = New System.Windows.Forms.Button()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.LabelvTy = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BoxTimer = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LabelhProcess = New System.Windows.Forms.Label()
        Me.LabelHmax = New System.Windows.Forms.Label()
        Me.LabelVprocess = New System.Windows.Forms.Label()
        Me.LabeltVue = New System.Windows.Forms.Label()
        Me.LabelvTx = New System.Windows.Forms.Label()
        Me.LabelY = New System.Windows.Forms.Label()
        Me.LabelX = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BoxGravedad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BoxAngulo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BoxVini = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Boxy0 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BoxX0 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonReinicio = New System.Windows.Forms.Button()
        Me.ButtonProcesar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pelota = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PicturePiso = New System.Windows.Forms.PictureBox()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pelota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicturePiso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelCabecera.Controls.Add(Me.Button1)
        Me.PanelCabecera.Controls.Add(Me.Label1)
        Me.PanelCabecera.Controls.Add(Me.ButtonMinimizar)
        Me.PanelCabecera.Controls.Add(Me.ButtonCerrar)
        Me.PanelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PanelCabecera.Name = "PanelCabecera"
        Me.PanelCabecera.Size = New System.Drawing.Size(717, 40)
        Me.PanelCabecera.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(841, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(8, 8)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(502, 33)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Simulación Movimiento Parabólico"
        '
        'ButtonMinimizar
        '
        Me.ButtonMinimizar.FlatAppearance.BorderSize = 0
        Me.ButtonMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMinimizar.Image = Global.ParabolicMotionSimulation.My.Resources.Resources.Icono_Minimizar
        Me.ButtonMinimizar.Location = New System.Drawing.Point(638, -3)
        Me.ButtonMinimizar.Name = "ButtonMinimizar"
        Me.ButtonMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.ButtonMinimizar.TabIndex = 5
        Me.ButtonMinimizar.UseVisualStyleBackColor = True
        '
        'ButtonCerrar
        '
        Me.ButtonCerrar.FlatAppearance.BorderSize = 0
        Me.ButtonCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.ButtonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCerrar.Image = Global.ParabolicMotionSimulation.My.Resources.Resources.Icono_cerrar_FN
        Me.ButtonCerrar.Location = New System.Drawing.Point(674, -3)
        Me.ButtonCerrar.Name = "ButtonCerrar"
        Me.ButtonCerrar.Size = New System.Drawing.Size(40, 40)
        Me.ButtonCerrar.TabIndex = 3
        Me.ButtonCerrar.UseVisualStyleBackColor = True
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.Orange
        Me.PanelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelMenu.Controls.Add(Me.LabelvTy)
        Me.PanelMenu.Controls.Add(Me.Label16)
        Me.PanelMenu.Controls.Add(Me.BoxTimer)
        Me.PanelMenu.Controls.Add(Me.Label14)
        Me.PanelMenu.Controls.Add(Me.LabelhProcess)
        Me.PanelMenu.Controls.Add(Me.LabelHmax)
        Me.PanelMenu.Controls.Add(Me.LabelVprocess)
        Me.PanelMenu.Controls.Add(Me.LabeltVue)
        Me.PanelMenu.Controls.Add(Me.LabelvTx)
        Me.PanelMenu.Controls.Add(Me.LabelY)
        Me.PanelMenu.Controls.Add(Me.LabelX)
        Me.PanelMenu.Controls.Add(Me.Label13)
        Me.PanelMenu.Controls.Add(Me.Label12)
        Me.PanelMenu.Controls.Add(Me.Label11)
        Me.PanelMenu.Controls.Add(Me.Label10)
        Me.PanelMenu.Controls.Add(Me.Label9)
        Me.PanelMenu.Controls.Add(Me.Label8)
        Me.PanelMenu.Controls.Add(Me.Label7)
        Me.PanelMenu.Controls.Add(Me.BoxGravedad)
        Me.PanelMenu.Controls.Add(Me.Label6)
        Me.PanelMenu.Controls.Add(Me.BoxAngulo)
        Me.PanelMenu.Controls.Add(Me.Label5)
        Me.PanelMenu.Controls.Add(Me.BoxVini)
        Me.PanelMenu.Controls.Add(Me.Label4)
        Me.PanelMenu.Controls.Add(Me.Boxy0)
        Me.PanelMenu.Controls.Add(Me.Label3)
        Me.PanelMenu.Controls.Add(Me.BoxX0)
        Me.PanelMenu.Controls.Add(Me.Label2)
        Me.PanelMenu.Controls.Add(Me.ButtonReinicio)
        Me.PanelMenu.Controls.Add(Me.ButtonProcesar)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelMenu.Location = New System.Drawing.Point(0, 314)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(717, 186)
        Me.PanelMenu.TabIndex = 1
        '
        'LabelvTy
        '
        Me.LabelvTy.AutoSize = True
        Me.LabelvTy.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelvTy.ForeColor = System.Drawing.Color.White
        Me.LabelvTy.Location = New System.Drawing.Point(546, 58)
        Me.LabelvTy.Name = "LabelvTy"
        Me.LabelvTy.Size = New System.Drawing.Size(15, 26)
        Me.LabelvTy.TabIndex = 40
        Me.LabelvTy.Text = "."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(508, 58)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 26)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "v(t)y"
        '
        'BoxTimer
        '
        Me.BoxTimer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BoxTimer.Location = New System.Drawing.Point(306, 105)
        Me.BoxTimer.Name = "BoxTimer"
        Me.BoxTimer.Size = New System.Drawing.Size(38, 13)
        Me.BoxTimer.TabIndex = 38
        Me.BoxTimer.Text = "10"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(194, 100)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 26)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Intervalo Tiempo"
        '
        'LabelhProcess
        '
        Me.LabelhProcess.AutoSize = True
        Me.LabelhProcess.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelhProcess.ForeColor = System.Drawing.Color.White
        Me.LabelhProcess.Location = New System.Drawing.Point(546, 157)
        Me.LabelhProcess.Name = "LabelhProcess"
        Me.LabelhProcess.Size = New System.Drawing.Size(15, 26)
        Me.LabelhProcess.TabIndex = 36
        Me.LabelhProcess.Text = "."
        '
        'LabelHmax
        '
        Me.LabelHmax.AutoSize = True
        Me.LabelHmax.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHmax.ForeColor = System.Drawing.Color.White
        Me.LabelHmax.Location = New System.Drawing.Point(546, 136)
        Me.LabelHmax.Name = "LabelHmax"
        Me.LabelHmax.Size = New System.Drawing.Size(15, 26)
        Me.LabelHmax.TabIndex = 35
        Me.LabelHmax.Text = "."
        '
        'LabelVprocess
        '
        Me.LabelVprocess.AutoSize = True
        Me.LabelVprocess.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVprocess.ForeColor = System.Drawing.Color.White
        Me.LabelVprocess.Location = New System.Drawing.Point(546, 105)
        Me.LabelVprocess.Name = "LabelVprocess"
        Me.LabelVprocess.Size = New System.Drawing.Size(15, 26)
        Me.LabelVprocess.TabIndex = 34
        Me.LabelVprocess.Text = "."
        '
        'LabeltVue
        '
        Me.LabeltVue.AutoSize = True
        Me.LabeltVue.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabeltVue.ForeColor = System.Drawing.Color.White
        Me.LabeltVue.Location = New System.Drawing.Point(546, 79)
        Me.LabeltVue.Name = "LabeltVue"
        Me.LabeltVue.Size = New System.Drawing.Size(15, 26)
        Me.LabeltVue.TabIndex = 33
        Me.LabeltVue.Text = "."
        '
        'LabelvTx
        '
        Me.LabelvTx.AutoSize = True
        Me.LabelvTx.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelvTx.ForeColor = System.Drawing.Color.White
        Me.LabelvTx.Location = New System.Drawing.Point(546, 34)
        Me.LabelvTx.Name = "LabelvTx"
        Me.LabelvTx.Size = New System.Drawing.Size(15, 26)
        Me.LabelvTx.TabIndex = 32
        Me.LabelvTx.Text = "."
        '
        'LabelY
        '
        Me.LabelY.AutoSize = True
        Me.LabelY.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelY.ForeColor = System.Drawing.Color.White
        Me.LabelY.Location = New System.Drawing.Point(546, 16)
        Me.LabelY.Name = "LabelY"
        Me.LabelY.Size = New System.Drawing.Size(15, 26)
        Me.LabelY.TabIndex = 31
        Me.LabelY.Text = "."
        '
        'LabelX
        '
        Me.LabelX.AutoSize = True
        Me.LabelX.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX.ForeColor = System.Drawing.Color.White
        Me.LabelX.Location = New System.Drawing.Point(546, -3)
        Me.LabelX.Name = "LabelX"
        Me.LabelX.Size = New System.Drawing.Size(15, 26)
        Me.LabelX.TabIndex = 30
        Me.LabelX.Text = "."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(464, 158)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 26)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "h(mProcess)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(491, 136)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 26)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "h(max)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(467, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 26)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "t(Vprocess)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(486, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 26)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "t(vuelo)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(508, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 26)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "v(t)x"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(508, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 26)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "y(t)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(508, -3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 26)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "x(t)"
        '
        'BoxGravedad
        '
        Me.BoxGravedad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BoxGravedad.Location = New System.Drawing.Point(40, 147)
        Me.BoxGravedad.Name = "BoxGravedad"
        Me.BoxGravedad.Size = New System.Drawing.Size(42, 13)
        Me.BoxGravedad.TabIndex = 22
        Me.BoxGravedad.Text = "9.8"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(11, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 26)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "g"
        '
        'BoxAngulo
        '
        Me.BoxAngulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BoxAngulo.Location = New System.Drawing.Point(40, 113)
        Me.BoxAngulo.Name = "BoxAngulo"
        Me.BoxAngulo.Size = New System.Drawing.Size(42, 13)
        Me.BoxAngulo.TabIndex = 20
        Me.BoxAngulo.Text = "45"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(11, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 26)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "a"
        '
        'BoxVini
        '
        Me.BoxVini.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BoxVini.Location = New System.Drawing.Point(40, 78)
        Me.BoxVini.Name = "BoxVini"
        Me.BoxVini.Size = New System.Drawing.Size(42, 13)
        Me.BoxVini.TabIndex = 18
        Me.BoxVini.Text = "160"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 26)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Vini"
        '
        'Boxy0
        '
        Me.Boxy0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Boxy0.Location = New System.Drawing.Point(40, 45)
        Me.Boxy0.Name = "Boxy0"
        Me.Boxy0.Size = New System.Drawing.Size(42, 13)
        Me.Boxy0.TabIndex = 16
        Me.Boxy0.Text = "40"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(11, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 26)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "y0"
        '
        'BoxX0
        '
        Me.BoxX0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BoxX0.Location = New System.Drawing.Point(40, 12)
        Me.BoxX0.Name = "BoxX0"
        Me.BoxX0.Size = New System.Drawing.Size(42, 13)
        Me.BoxX0.TabIndex = 14
        Me.BoxX0.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(11, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 26)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "x0"
        '
        'ButtonReinicio
        '
        Me.ButtonReinicio.FlatAppearance.BorderSize = 0
        Me.ButtonReinicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonReinicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.ButtonReinicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonReinicio.Image = Global.ParabolicMotionSimulation.My.Resources.Resources.actualizar
        Me.ButtonReinicio.Location = New System.Drawing.Point(306, 127)
        Me.ButtonReinicio.Name = "ButtonReinicio"
        Me.ButtonReinicio.Size = New System.Drawing.Size(57, 54)
        Me.ButtonReinicio.TabIndex = 8
        Me.ButtonReinicio.Text = "Reiniciar"
        Me.ButtonReinicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonReinicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonReinicio.UseVisualStyleBackColor = True
        '
        'ButtonProcesar
        '
        Me.ButtonProcesar.FlatAppearance.BorderSize = 0
        Me.ButtonProcesar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonProcesar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.ButtonProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonProcesar.Image = Global.ParabolicMotionSimulation.My.Resources.Resources.reproduce_el_video
        Me.ButtonProcesar.Location = New System.Drawing.Point(243, 129)
        Me.ButtonProcesar.Name = "ButtonProcesar"
        Me.ButtonProcesar.Size = New System.Drawing.Size(57, 54)
        Me.ButtonProcesar.TabIndex = 7
        Me.ButtonProcesar.Text = "Procesar"
        Me.ButtonProcesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonProcesar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonProcesar.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ParabolicMotionSimulation.My.Resources.Resources.bas
        Me.PictureBox2.Location = New System.Drawing.Point(534, 46)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(180, 262)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'pelota
        '
        Me.pelota.Image = Global.ParabolicMotionSimulation.My.Resources.Resources.baloncesto1
        Me.pelota.Location = New System.Drawing.Point(63, 226)
        Me.pelota.Name = "pelota"
        Me.pelota.Size = New System.Drawing.Size(35, 33)
        Me.pelota.TabIndex = 2
        Me.pelota.TabStop = False
        '
        'Timer1
        '
        '
        'PicturePiso
        '
        Me.PicturePiso.BackColor = System.Drawing.Color.DimGray
        Me.PicturePiso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicturePiso.Location = New System.Drawing.Point(63, 303)
        Me.PicturePiso.Name = "PicturePiso"
        Me.PicturePiso.Size = New System.Drawing.Size(652, 10)
        Me.PicturePiso.TabIndex = 4
        Me.PicturePiso.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(717, 500)
        Me.Controls.Add(Me.PicturePiso)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.pelota)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelCabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 100)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pelota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicturePiso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelCabecera As Panel
    Friend WithEvents ButtonMinimizar As Button
    Friend WithEvents ButtonCerrar As Button
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonReinicio As Button
    Friend WithEvents ButtonProcesar As Button
    Friend WithEvents pelota As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BoxX0 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BoxGravedad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BoxAngulo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BoxVini As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Boxy0 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PicturePiso As PictureBox
    Friend WithEvents LabelhProcess As Label
    Friend WithEvents LabelHmax As Label
    Friend WithEvents LabelVprocess As Label
    Friend WithEvents LabeltVue As Label
    Friend WithEvents LabelvTx As Label
    Friend WithEvents LabelY As Label
    Friend WithEvents LabelX As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BoxTimer As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents LabelvTy As Label
    Friend WithEvents Timer3 As Timer
End Class
