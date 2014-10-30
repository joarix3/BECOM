Option Infer On
Imports EntitiesLayer

Imports System.Text.RegularExpressions
Public Class FrmModificarCarrera

    'Dim objValidaciones As New Validaciones()
    Dim formAnterior As Form
    Dim idCarrera As Integer
    Public Sub New(pformAnterior As Form, pidCarrera As Integer)
        idCarrera = pidCarrera
        InitializeComponent()
        formAnterior = pformAnterior
    End Sub

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        If cdCarrera.ShowDialog = DialogResult.OK Then
            pnColor.BackColor = cdCarrera.Color
        End If
    End Sub

    Private Sub FrmModificarCarrera_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        formAnterior.Show()
        Me.Hide()
    End Sub
    Public Sub validarDatosCargados()
        txtCodigo_Leave(txtCodigo, Nothing)
        txtNombre_Leave(txtNombre, Nothing)
        txtBecasOtorgables_Leave(txtBecasOtorgables, Nothing)

    End Sub

    Private Sub FrmModificarCarrera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rellenarTextBox()
        validarDatosCargados()
    End Sub
   
    Private Sub rellenarTextBox()
        Dim objCarrera As Carrera
        objCarrera = gestorCarrera.ObtenerCarreraPorId(idCarrera)
        txtCodigo.Text = objCarrera.Codigo
        txtNombre.Text = objCarrera.Nombre
        Dim col As Color = ColourFromData(objCarrera.Color)
        pnColor.BackColor = col
        txtBecasOtorgables.Text = objCarrera.BecasOtor
        cmbEstado.Items.Add("Activo")
        cmbEstado.Items.Add("Inactivo")
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If validarEspaciosBlanco() = True Then
            If validarCamposFormulario() = True Then
                modificarCarrera()
            Else

            End If
        Else

        End If
    End Sub


    Private Function validarEspaciosBlanco() As Boolean
        Dim permitido = False

        For Each textBox As TextBox In Me.Controls.OfType(Of TextBox)()
            If String.IsNullOrEmpty(textBox.Text) Then
                lblEspaciosEnBlanco.Visible = True
                permitido = False
            Else
                lblEspaciosEnBlanco.Visible = False
                permitido = True
            End If
        Next
        Return permitido
    End Function

    Private Function validarCamposFormulario() As Boolean
        Dim listaCampos As New List(Of Boolean)
        Dim permitido As Boolean

        For Each validacion As Label In Me.Controls.OfType(Of Label)()
            If IsNumeric(validacion.Tag) = True Then
                If validacion.Visible = True Then
                    If validacion.Image.Equals(campoIncorrecto) Then
                        listaCampos.Add(False)
                    Else
                        listaCampos.Add(True)
                    End If
                End If
            End If
        Next

        permitido = corroborarDatos(listaCampos)

        Return permitido
    End Function

    Private Function corroborarDatos(plistaCampos As List(Of Boolean))
        Dim datosCorrectos As Boolean
        For Each permiso As Boolean In plistaCampos
            If (permiso.Equals(False)) Then
                datosCorrectos = False
                Exit For
            Else
                datosCorrectos = True
            End If
        Next
        Return datosCorrectos
    End Function





    Private Sub txtCodigo_Leave(sender As Object, e As EventArgs) Handles txtCodigo.Leave
        If validaciones.validarCamposTexto(txtCodigo) = True Then
            lblCodigoV.Image = campoCorrecto
            lblCodigoV.Visible = True
        Else
            lblCodigoV.Image = campoIncorrecto
            lblCodigoV.Visible = True
        End If
    End Sub
    Private Sub txtNombre_Leave(sender As Object, e As EventArgs) Handles txtNombre.Leave
        If validaciones.validarCamposTexto(txtNombre) = True Then
            lblNombreV.Image = campoCorrecto
            lblNombreV.Visible = True
        Else
            lblNombreV.Image = campoIncorrecto
            lblNombreV.Visible = True
        End If
    End Sub

    Private Sub txtBecasOtorgables_Leave(sender As Object, e As EventArgs) Handles txtBecasOtorgables.Leave
        If validaciones.validarCamposNumericos(txtBecasOtorgables) = True Then
            lblBecas.Image = campoCorrecto
            lblBecas.Visible = True
        Else
            lblBecas.Image = campoIncorrecto
            lblBecas.Visible = True
        End If
    End Sub
    Private Sub modificarCarrera()
        Dim codigo As String = txtCodigo.Text
        Dim nombre As String = txtNombre.Text
        Dim director As Integer = comboDirector.SelectedItem
        Dim color As String = cdCarrera.Color.ToString
        Dim becasOtor As Integer = txtBecasOtorgables.Text
        Dim estadoInt As Integer = 1
        Dim aceptado As String = "El curso se modificó correctamente"
        If cmbEstado.Text = "Activo" Then
            estadoInt = 1
        ElseIf cmbEstado.Text = "Inactivo" Then
            estadoInt = 2
        End If
        gestorCarrera.modificarCarrera(idCarrera, codigo, nombre, 2, color, becasOtor, estadoInt)
        gestorCarrera.guardarCambios()
        Dim popUpAgregado As PopAgregado = New PopAgregado(aceptado)
        popUpAgregado.Show()
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