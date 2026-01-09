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
        GestureBar_Image = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        CType(GestureBar_Image, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GestureBar_Image
        ' 
        GestureBar_Image.BackgroundImage = My.Resources.Resources.gesturebutton_home
        GestureBar_Image.BackgroundImageLayout = ImageLayout.Stretch
        GestureBar_Image.Location = New Point(450, 780)
        GestureBar_Image.Name = "GestureBar_Image"
        GestureBar_Image.Size = New Size(300, 6)
        GestureBar_Image.TabIndex = 0
        GestureBar_Image.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Adam Medium", 71.99999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(877, 300)
        Label1.Name = "Label1"
        Label1.Size = New Size(180, 80)
        Label1.TabIndex = 1
        Label1.Text = "23"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Adam Medium", 71.99999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(877, 415)
        Label2.Name = "Label2"
        Label2.Size = New Size(180, 80)
        Label2.TabIndex = 2
        Label2.Text = "27"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Adam Medium", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(782, 513)
        Label3.Name = "Label3"
        Label3.Size = New Size(370, 45)
        Label3.TabIndex = 3
        Label3.Text = "2. November"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
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
        ' Label6
        ' 
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("SF UI Display Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(1115, 6)
        Label6.Name = "Label6"
        Label6.Size = New Size(70, 30)
        Label6.TabIndex = 6
        Label6.Text = "100%"
        Label6.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' PictureBox1
        ' 
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
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label

End Class
