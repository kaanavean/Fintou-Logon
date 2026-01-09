<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        GestureBar_Image = New PictureBox()
        Clock_Hours = New Label()
        Clock_Minutes = New Label()
        Clock_Date = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Battery_Percent = New Label()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        System_Timer = New Timer(components)
        Pointer = New Timer(components)
        Battery_Status = New Timer(components)
        CType(GestureBar_Image, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GestureBar_Image
        ' 
        GestureBar_Image.Anchor = AnchorStyles.Bottom
        GestureBar_Image.BackgroundImage = My.Resources.Resources.gesturebutton_home
        GestureBar_Image.BackgroundImageLayout = ImageLayout.Stretch
        GestureBar_Image.Location = New Point(450, 780)
        GestureBar_Image.Name = "GestureBar_Image"
        GestureBar_Image.Size = New Size(300, 6)
        GestureBar_Image.TabIndex = 0
        GestureBar_Image.TabStop = False
        ' 
        ' Clock_Hours
        ' 
        Clock_Hours.Anchor = AnchorStyles.Right
        Clock_Hours.BackColor = Color.Transparent
        Clock_Hours.Font = New Font("Adam Medium", 71.99999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Clock_Hours.ForeColor = Color.White
        Clock_Hours.Location = New Point(877, 300)
        Clock_Hours.Name = "Clock_Hours"
        Clock_Hours.Size = New Size(180, 80)
        Clock_Hours.TabIndex = 1
        Clock_Hours.Text = "23"
        Clock_Hours.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Clock_Minutes
        ' 
        Clock_Minutes.Anchor = AnchorStyles.Right
        Clock_Minutes.BackColor = Color.Transparent
        Clock_Minutes.Font = New Font("Adam Medium", 71.99999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Clock_Minutes.ForeColor = Color.White
        Clock_Minutes.Location = New Point(877, 415)
        Clock_Minutes.Name = "Clock_Minutes"
        Clock_Minutes.Size = New Size(180, 80)
        Clock_Minutes.TabIndex = 2
        Clock_Minutes.Text = "27"
        Clock_Minutes.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Clock_Date
        ' 
        Clock_Date.Anchor = AnchorStyles.Right
        Clock_Date.BackColor = Color.Transparent
        Clock_Date.Font = New Font("Adam Medium", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Clock_Date.ForeColor = Color.White
        Clock_Date.Location = New Point(782, 513)
        Clock_Date.Name = "Clock_Date"
        Clock_Date.Size = New Size(370, 45)
        Clock_Date.TabIndex = 3
        Clock_Date.Text = "2. November"
        Clock_Date.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Bottom
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Adam Medium", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DarkGray
        Label4.Location = New Point(450, 740)
        Label4.Name = "Label4"
        Label4.Size = New Size(300, 32)
        Label4.TabIndex = 4
        Label4.Text = "Swipe to unlock"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("SF UI Display Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(15, 6)
        Label5.Name = "Label5"
        Label5.Size = New Size(126, 30)
        Label5.TabIndex = 5
        Label5.Text = "Surface Go"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Battery_Percent
        ' 
        Battery_Percent.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Battery_Percent.BackColor = Color.Transparent
        Battery_Percent.Font = New Font("SF UI Display Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Battery_Percent.ForeColor = Color.White
        Battery_Percent.Location = New Point(1115, 6)
        Battery_Percent.Name = "Battery_Percent"
        Battery_Percent.Size = New Size(70, 30)
        Battery_Percent.TabIndex = 6
        Battery_Percent.Text = "100%"
        Battery_Percent.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources.lock
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(577, 67)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(46, 46)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Adam Medium", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(450, 125)
        Label7.Name = "Label7"
        Label7.Size = New Size(300, 32)
        Label7.TabIndex = 8
        Label7.Text = "Searching for a face"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' System_Timer
        ' 
        System_Timer.Enabled = True
        System_Timer.Interval = 1000
        ' 
        ' Pointer
        ' 
        Pointer.Enabled = True
        ' 
        ' Battery_Status
        ' 
        Battery_Status.Enabled = True
        Battery_Status.Interval = 1
        ' 
        ' MainScreen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        BackgroundImage = My.Resources.Resources.bcg
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1200, 800)
        Controls.Add(Label7)
        Controls.Add(PictureBox1)
        Controls.Add(Battery_Percent)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Clock_Date)
        Controls.Add(Clock_Minutes)
        Controls.Add(Clock_Hours)
        Controls.Add(GestureBar_Image)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "MainScreen"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main"
        CType(GestureBar_Image, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GestureBar_Image As PictureBox
    Friend WithEvents Clock_Hours As Label
    Friend WithEvents Clock_Minutes As Label
    Friend WithEvents Clock_Date As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Battery_Percent As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents System_Timer As Timer
    Friend WithEvents Pointer As Timer
    Friend WithEvents Battery_Status As Timer

End Class
