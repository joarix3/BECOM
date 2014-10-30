'Clase para mostrar los roles de la aplicación.
Option Infer On
Imports EntitiesLayer
Imports System.Text.RegularExpressions

Public Class FrmInformacionCarrera
    Dim formAnterior As Form
    Dim idCarrera As String
    Public Sub New(pformAnterior As Form, pid As String)
        InitializeComponent()
        formAnterior = pformAnterior
        idCarrera = pid
    End Sub
    Private Sub btnMin_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub FrmInformacionCarrera_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub


    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        formAnterior.Show()
        Me.Hide()
    End Sub




    Private Sub FrmInformacionCarrera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ingresarDatos()
    End Sub
    Private Sub ingresarDatos()
        Dim objCarrera As Carrera
        objCarrera = gestorCarrera.ObtenerCarreraPorId(idCarrera)
        lblNombreCarrera.Text = objCarrera.Nombre
        txtCodigo.Text = objCarrera.Codigo
        txtNombre.Text = objCarrera.Nombre
        Dim col As Color = ColourFromData(objCarrera.Color)
        pnColor.BackColor = col
        txtBecasOtorgables.Text = objCarrera.BecasOtor
        Dim estadoInt As Integer = objCarrera.Estado
        Dim estadoString As String
        If estadoInt = 1 Then
            estadoString = "Activo"
        ElseIf estadoInt = 2 Then
            estadoString = "Inactivo"
        End If
        txtEstado.Text = estadoString
    End Sub

    Public Shared Function ColourFromData(s As String) As Color
        Dim fallbackColour = Color.Black

        If Not s.StartsWith("color", StringComparison.OrdinalIgnoreCase) Then
            Return fallbackColour
        End If

        ' Extract whatever is between the brackets.
        Dim re = New Regex("\[(.+?)]")
        Dim colorNameMatch = re.Match(s)
        If Not colorNameMatch.Success Then
            Return fallbackColour
        End If

        Dim colourName = colorNameMatch.Groups(1).Value

        ' Get the names of the known colours.
        'TODO: If this function is called frequently, consider creating allColours as a variable with a larger scope.
        Dim allColours = [Enum].GetNames(GetType(System.Drawing.KnownColor))

        ' Attempt a case-insensitive match to the known colours.
        Dim nameOfColour = allColours.FirstOrDefault(Function(c) String.Compare(c, colourName, StringComparison.OrdinalIgnoreCase) = 0)

        If Not String.IsNullOrEmpty(nameOfColour) Then
            Return Color.FromName(nameOfColour)
        End If

        ' Was not a named colour. Parse for ARGB values.
        re = New Regex("A=(\d+).*?R=(\d+).*?G=(\d+).*?B=(\d+)", RegexOptions.IgnoreCase)
        Dim componentMatches = re.Match(colourName)

        If componentMatches.Success Then

            Dim a = Integer.Parse(componentMatches.Groups(1).Value)
            Dim r = Integer.Parse(componentMatches.Groups(2).Value)
            Dim g = Integer.Parse(componentMatches.Groups(3).Value)
            Dim b = Integer.Parse(componentMatches.Groups(4).Value)

            Dim maxValue = 255

            If a > maxValue OrElse r > maxValue OrElse g > maxValue OrElse b > maxValue Then
                Return fallbackColour
            End If

            Return System.Drawing.Color.FromArgb(a, r, g, b)

        End If

        Return fallbackColour

    End Function

 
End Class