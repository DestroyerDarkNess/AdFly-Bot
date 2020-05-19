'+-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+'
'| Theme : DevPoint Theme              |'
'| Date : 09/06/2015                   |'
'| Coded By : Qassam Sniper            |'
'| Version : 1.0                       |'
'| Forums : www.dev-point.com/Qassam   |'
'+-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+'

Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class DevButton
    Inherits Control

    Enum MouseState
        None = 0
        Over = 1
        Down = 2
    End Enum

    Enum xButtonColor
        Blue = 0
        Red = 1
    End Enum


    Private NewButtonColor As xButtonColor = xButtonColor.Blue
    Public Property ButtonColor() As xButtonColor
        Get
            Return NewButtonColor
        End Get
        Set(ByVal value As xButtonColor)
            NewButtonColor = value
        End Set
    End Property


    Private State As MouseState = MouseState.None

    Public Sub New()
        Me.Size = New Size(95, 30)
        Me.Font = New Font("Segoe UI", 10)
    End Sub


    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down
        Me.Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over
        Me.Invalidate()
    End Sub
    Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over
        Me.Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)

        Dim FirstColor As Color
        Dim SecondColor As Color
        Dim FrameColor As Color
        Dim FontColor As Color

        If newButtonColor = xButtonColor.Blue Then
            FirstColor = Color.FromArgb(86, 152, 217)
            SecondColor = Color.FromArgb(48, 114, 179)
            FrameColor = Color.FromArgb(42, 101, 160)
            FontColor = Color.FromArgb(0, 77, 143)
        ElseIf newButtonColor = xButtonColor.Red Then
            FirstColor = Color.FromArgb(219, 94, 88)
            SecondColor = Color.FromArgb(179, 54, 48)
            FrameColor = Color.FromArgb(181, 63, 58)
            FontColor = Color.FromArgb(153, 0, 0)
        End If

        Dim Rect As New System.Drawing.Rectangle(0, 0, e.ClipRectangle.Width, e.ClipRectangle.Height)

        Dim G As Graphics = e.Graphics

        Dim TextWidth As Single = g.MeasureString(NewText, NewFont).Width
        Dim TextHeight As Single = g.MeasureString(NewText, NewFont).Height

        Select Case State

            Case MouseState.None

                Dim GradientBrush As New LinearGradientBrush(New Point(0, 0), New Point(0, Me.Height), Color.FromArgb(243, 243, 243), Color.FromArgb(236, 236, 236))
                G.FillRectangle(GradientBrush, Rect)
                G.DrawRectangle(New Pen(Color.FromArgb(212, 212, 212)), New Rectangle(0, 0, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1))
                G.DrawString(NewText, NewFont, New SolidBrush(FontColor), New PointF((e.ClipRectangle.Width - TextWidth) / 2, (e.ClipRectangle.Height - TextHeight) / 2))

            Case MouseState.Over

                Dim GradientBrush As New LinearGradientBrush(New Point(0, 0), New Point(0, Me.Height), FirstColor, SecondColor)
                G.FillRectangle(gradientBrush, Rect)
                G.DrawRectangle(New Pen(FrameColor), New Rectangle(0, 0, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1))
                G.DrawString(NewText, NewFont, Brushes.White, New PointF((e.ClipRectangle.Width - TextWidth) / 2, (e.ClipRectangle.Height - TextHeight) / 2))

            Case MouseState.Down
                Dim GradientBrush As New LinearGradientBrush(New Point(0, 0), New Point(0, Me.Height), SecondColor, FirstColor)
                G.FillRectangle(gradientBrush, Rect)
                G.DrawRectangle(New Pen(FrameColor), New Rectangle(0, 0, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1))
                G.DrawString(NewText, NewFont, Brushes.White, New PointF((e.ClipRectangle.Width - TextWidth) / 2, (e.ClipRectangle.Height - TextHeight) / 2))

        End Select


        MyBase.OnPaint(e)
        G.Dispose()
    End Sub

    Dim NewText As String
    Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
            NewText = value
            Me.Invalidate()
        End Set
    End Property

    Dim NewFont As Font = New Font("Segoe UI", 10)
    Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            NewFont = value
            MyBase.Font = NewFont
        End Set
    End Property
End Class

Public Class DevSkin
    Inherits ContainerControl


    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim G As Graphics = e.Graphics

        G.FillRectangle(New SolidBrush(Color.FromArgb(255, 255, 255)), New Rectangle(0, 0, Me.Width, Me.Height))
        G.DrawRectangle(New Pen(Color.FromArgb(228, 228, 228), 1), New Rectangle(3, 50, Me.Width - 6, Me.Height - 54))


        Dim gradientBrush1 As New LinearGradientBrush(New Point(0, 0), New Point(2, 0), Color.FromArgb(234, 234, 234), Color.FromArgb(240, 240, 240))
        G.FillRectangle(gradientBrush1, New Rectangle(Me.Width - 2, 0, 2, Me.Height))


        Dim gradientBrush2 As New LinearGradientBrush(New Point(0, 0), New Point(0, 2), Color.FromArgb(234, 234, 234), Color.FromArgb(240, 240, 240))
        G.FillRectangle(gradientBrush2, New Rectangle(0, Me.Height - 2, Me.Width, 2))

        Dim gradientBrush3 As New LinearGradientBrush(New Point(0, 0), New Point(2, 0), Color.FromArgb(240, 240, 240), Color.FromArgb(234, 234, 234))
        G.FillRectangle(gradientBrush3, New Rectangle(0, 0, 2, Me.Height))


        G.FillRectangle(New SolidBrush(Color.FromArgb(49, 79, 124)), New Rectangle(0, 0, Me.Width, 50))

        Dim TextHeight As Single = g.MeasureString(NewText, New Font("Segoe UI", 12)).Height
        G.DrawString(NewText, New Font("Segoe UI", 12), Brushes.White, New Point(50, (50 - TextHeight) / 2))


        MyBase.OnPaint(e)
        G.Dispose()
    End Sub

    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        Me.Invalidate()
        MyBase.OnResize(e)
    End Sub

    Private MousePoint As New Point(0, 0)
    Private IsDown As Boolean = False

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        If e.Button = Windows.Forms.MouseButtons.Left And New Rectangle(0, 0, Width, 50).Contains(e.Location) Then
            IsDown = True
            MousePoint = e.Location
        End If
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        IsDown = False
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        If IsDown Then
            Me.Parent.Location = MousePosition - MousePoint
        End If
    End Sub

    Dim P As New PictureBox
    Public Sub New()
        P.Size = New Size(40, 40)
        P.Location = New Point(5, 5)
        P.BackColor = Color.Transparent
        P.SizeMode = PictureBoxSizeMode.StretchImage
        Me.Controls.Add(P)
    End Sub

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        Me.ParentForm.FormBorderStyle = FormBorderStyle.None
        Me.ParentForm.AllowTransparency = False
        Me.ParentForm.TransparencyKey = Color.Fuchsia
        Me.ParentForm.FindForm.StartPosition = FormStartPosition.CenterScreen
        Me.Dock = DockStyle.Fill
        Me.Invalidate()
    End Sub

    Private NewHeaderLogo As Image = Nothing

    Public Property HeaderLogo() As Image
        Get
            Return NewHeaderLogo
        End Get
        Set(ByVal value As Image)
            NewHeaderLogo = value
            P.Image = NewHeaderLogo
        End Set
    End Property

    Dim NewText As String

    Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
            NewText = value
            Me.Invalidate()
        End Set
    End Property
End Class

Public Class DevLabel
    Inherits Label

    Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)
        MyBase.OnTextChanged(e)
        Me.Invalidate()
    End Sub

    Sub New()
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.Font = New Font("Segoe UI", 9)
        Me.ForeColor = Color.FromArgb(0, 77, 143)
        Me.BackColor = Color.Transparent
        Me.Text = Text
    End Sub
End Class

Public Class DevControlBox
    Inherits Control

    Enum MouseState
        None = 0
        Over = 1
        Down = 2
    End Enum


    Enum xBoxType
        Close = 0
        Max = 1
        Min = 2
    End Enum

    Private State As MouseState = MouseState.None

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down
        Me.Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over
        Me.Invalidate()
    End Sub
    Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over
        Me.Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim G As Graphics = e.Graphics

        Dim OverColor As Color
        Dim NoneColor As Color
        Dim DownColor As Color
        Dim FrameColor As Color
        Dim BoxText As String = String.Empty

        Select Case newBoxType

            Case xBoxType.Close
                OverColor = Color.FromArgb(255, 64, 64)
                NoneColor = Color.FromArgb(224, 60, 49)
                DownColor = Color.FromArgb(227, 0, 34)
                FrameColor = Color.FromArgb(255, 40, 0)
                BoxText = "r"
            Case xBoxType.Max
                OverColor = Color.FromArgb(30, 144, 255)
                NoneColor = Color.FromArgb(0, 114, 187)
                DownColor = Color.FromArgb(0, 115, 207)
                FrameColor = Color.FromArgb(30, 144, 255)

                If FindForm.WindowState = FormWindowState.Maximized Then
                    BoxText = "2"
                Else
                    BoxText = "1"
                End If
            Case xBoxType.Min
                OverColor = Color.FromArgb(30, 144, 255)
                NoneColor = Color.FromArgb(0, 114, 187)
                DownColor = Color.FromArgb(0, 115, 207)
                FrameColor = Color.FromArgb(30, 144, 255)
                BoxText = "0"
        End Select

        Dim TextWidth As Single = G.MeasureString(BoxText, New Font("Marlett", 12)).Width
        Dim TextHeight As Single = G.MeasureString(BoxText, New Font("Marlett", 12)).Height

        Select Case State

            Case MouseState.Over

                G.FillRectangle(New SolidBrush(OverColor), Me.ClientRectangle)
                G.DrawString(BoxText, New Font("Marlett", 12), Brushes.White, New Point((Me.Width - TextWidth) / 2, (Me.Height - TextHeight) / 2))
                G.DrawRectangle(New Pen(FrameColor), New Rectangle(0, 0, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1))

            Case MouseState.None
                G.FillRectangle(New SolidBrush(NoneColor), Me.ClientRectangle)
                G.DrawString(BoxText, New Font("Marlett", 12), Brushes.White, New Point((Me.Width - TextWidth) / 2, (Me.Height - TextHeight) / 2))
                G.DrawRectangle(New Pen(FrameColor), New Rectangle(0, 0, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1))

            Case MouseState.Down
                G.FillRectangle(New SolidBrush(DownColor), Me.ClientRectangle)
                G.DrawString(BoxText, New Font("Marlett", 12), Brushes.White, New Point((Me.Width - TextWidth) / 2, (Me.Height - TextHeight) / 2))
                G.DrawRectangle(New Pen(FrameColor), New Rectangle(0, 0, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1))

        End Select

        MyBase.OnPaint(e)
        G.Dispose()
    End Sub


    Dim NewBoxType As xBoxType = xBoxType.Close
    Public Property BoxType() As xBoxType
        Get
            Return NewBoxType
        End Get
        Set(ByVal value As xBoxType)
            NewBoxType = value
        End Set
    End Property


    Public Sub New()
        Me.Size = New Size(22, 22)
        Me.Anchor = AnchorStyles.Top Or AnchorStyles.Right
    End Sub

    Protected Overrides Sub OnClick(ByVal e As System.EventArgs)

        Select Case NewBoxType
            Case xBoxType.Close
                Me.FindForm.Close()
            Case xBoxType.Max
                If Me.FindForm.WindowState = FormWindowState.Normal Then
                    Me.FindForm.WindowState = FormWindowState.Maximized
                ElseIf Me.FindForm.WindowState = FormWindowState.Maximized Then
                    Me.FindForm.WindowState = FormWindowState.Normal
                End If
            Case xBoxType.Min
                Me.FindForm.WindowState = FormWindowState.Minimized
        End Select
        Me.Invalidate()
        MyBase.OnClick(e)
    End Sub
End Class


Public Class DevTextBox
    Inherits Control

    Dim T As New TextBox

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim G As Graphics = e.Graphics
        G.DrawRectangle(New Pen(Color.FromArgb(212, 212, 212)), New Rectangle(0, 0, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1))

        MyBase.OnPaint(e)
    End Sub

    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        If MultiLine = True Then
            T.Size = New Size(Me.Width - 8, Me.Height - 8)
        Else
            Me.Height = T.Height + 8
            T.Width = Me.Width - 8
        End If
        MyBase.OnResize(e)
    End Sub

    Public Sub New()
        T.BorderStyle = Windows.Forms.BorderStyle.None
        T.Font = New Font("Segoe UI", 9)
        T.ForeColor = Color.FromArgb(0, 77, 143)
        T.Location = New Point(4, 4)
        Me.Font = New Font("Segoe UI", 9)
        'Me.Size = New Size(T.Width + 8, T.Height + 8)
        Me.Width = 160
        OnResize(Nothing)
        T.BackColor = Color.FromArgb(240, 240, 240)
        Me.Controls.Add(T)
    End Sub


    Private NewMutliLine As Boolean = False
    Public Property MultiLine() As Boolean
        Get
            Return NewMutliLine
        End Get
        Set(ByVal value As Boolean)
            NewMutliLine = value
            T.Multiline = NewMutliLine
            OnResize(Nothing)
        End Set
    End Property


    Private NewTextAlign As HorizontalAlignment = HorizontalAlignment.Left
    Property TextAlign() As HorizontalAlignment
        Get
            Return NewTextAlign
        End Get
        Set(ByVal value As HorizontalAlignment)
            NewTextAlign = value
            If T IsNot Nothing Then
                T.TextAlign = value
            End If
        End Set
    End Property
    Private NewMaxLength As Integer = 32767

    Property MaxLength() As Integer
        Get
            Return NewMaxLength
        End Get
        Set(ByVal value As Integer)
            NewMaxLength = value
            If T IsNot Nothing Then
                T.MaxLength = value
            End If
        End Set
    End Property
    Private NewReadOnly As Boolean

    Property [ReadOnly]() As Boolean
        Get
            Return NewReadOnly
        End Get
        Set(ByVal value As Boolean)
            NewReadOnly = value
            If T IsNot Nothing Then
                T.ReadOnly = value
            End If
        End Set
    End Property
    Private NewUseSystemPasswordChar As Boolean

    Property UseSystemPasswordChar() As Boolean
        Get
            Return NewUseSystemPasswordChar
        End Get
        Set(ByVal value As Boolean)
            NewUseSystemPasswordChar = value
            If T IsNot Nothing Then
                T.UseSystemPasswordChar = value
            End If
        End Set
    End Property

    Overrides Property Text As String
        Get
            Return T.Text
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
            If T IsNot Nothing Then
                T.Text = value
            End If
        End Set
    End Property


    Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            MyBase.Font = value
            If T IsNot Nothing Then
                T.Font = value
                OnResize(Nothing)
            End If
        End Set
    End Property
End Class

Public Class DevNumeric
    Inherits Control

    Dim WithEvents LU As New Label
    Dim WithEvents LD As New Label
    Dim WithEvents T As New TextBox


    <DllImport("user32")> _
    Private Shared Function HideCaret(ByVal hWnd As IntPtr) As Integer
    End Function

    Public Sub New()
        Me.Size = New Size(70, 30)

        LU.Size = New Size(24, 14)
        LD.Size = New Size(24, 14)
        T.Size = New Size(44, 28)

        LU.Location = New Point(Me.Width - LU.Width - 1, 1)
        LD.Location = New Point(Me.Width - LD.Width - 1, 15)
        T.Location = New Point(1, (Me.Height - T.Height) / 2)

        LU.Text = "+"
        LD.Text = "-"

        LU.TextAlign = ContentAlignment.MiddleCenter
        LD.TextAlign = ContentAlignment.MiddleCenter

        LU.BackColor = Color.FromArgb(0, 114, 187)
        LD.BackColor = Color.FromArgb(0, 114, 187)


        T.BorderStyle = BorderStyle.None
        T.BackColor = Color.FromArgb(240, 240, 240)


        LU.ForeColor = Color.White
        LD.ForeColor = Color.White
        T.ForeColor = Color.FromArgb(0, 77, 143)

        T.ReadOnly = True
        T.TextAlign = HorizontalAlignment.Center
        T.Font = New Font("Segoe UI", 10)

        Me.Controls.AddRange({LU, LD, T})

    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim G As Graphics = e.Graphics

        G.DrawRectangle(New Pen(Color.FromArgb(212, 212, 212)), New Rectangle(0, 0, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1))

        MyBase.OnPaint(e)
        G.Dispose()
    End Sub

    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        Me.Size = New Size(70, 30)
        MyBase.OnResize(e)
    End Sub

    Private Sub LD_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LD.MouseDown
        LD.BackColor = Color.FromArgb(0, 115, 207)
        If CInt(T.Text) > newMinValue Then
            T.Text = CInt(T.Text) - 1
            Value = CInt(T.Text)
        End If
    End Sub

    Private Sub LD_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles LD.MouseEnter
        LD.BackColor = Color.FromArgb(30, 144, 255)
    End Sub

    Private Sub LD_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LD.MouseLeave
        LD.BackColor = Color.FromArgb(0, 114, 187)
    End Sub

    Private Sub LD_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LD.MouseUp
        LD_MouseEnter(Nothing, Nothing)
    End Sub

    Private Sub LU_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LU.MouseDown
        LU.BackColor = Color.FromArgb(0, 115, 207)
        If CInt(T.Text) < newMaxValue Then
            T.Text = CInt(T.Text) + 1
            Value = CInt(T.Text)
        End If
    End Sub

    Private Sub LU_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles LU.MouseEnter
        LU.BackColor = Color.FromArgb(30, 144, 255)
    End Sub

    Private Sub LU_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LU.MouseLeave
        LU.BackColor = Color.FromArgb(0, 114, 187)
    End Sub

    Private Sub LU_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LU.MouseUp
        LU_MouseEnter(Nothing, Nothing)
    End Sub

    Private Sub T_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles T.GotFocus
        HideCaret(T.Handle)
    End Sub

    Private NewMaxValue As Integer = 100
    Public Property MaxValue() As Integer
        Get
            Return NewMaxValue
        End Get
        Set(ByVal value As Integer)
            If value > NewMinValue Then
                NewMaxValue = value
            End If
        End Set
    End Property

    Private NewMinValue As Integer = 0
    Public Property MinValue() As Integer
        Get
            Return NewMinValue
        End Get
        Set(ByVal value As Integer)
            If value < NewMaxValue Then
                NewMinValue = value
            End If
        End Set
    End Property


    Private NewValue As Integer
    Public Property Value() As Integer
        Get
            Return NewValue
        End Get
        Set(ByVal value As Integer)
            NewValue = value
            T.Text = value
        End Set
    End Property

End Class

'+-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+'
'| Theme : DevPoint Theme              |'
'| Date : 09/06/2015                   |'
'| Coded By : Qassam Sniper            |'
'| Version : 1.0                       |'
'| Forums : www.dev-point.com/Qassam   |'
'+-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+'