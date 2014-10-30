'Clase para mostrar los roles de la aplicación.
Imports EntitiesLayer
Imports System.IO
Imports System.Data
Imports System.Reflection
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class FrmMostrarBitacoraErrores
    Public direccionExportar As String = "C:\Users\Mario\Desktop\Nueva carpeta\"
    Dim formAnterior As Form
    Public Sub New(pformAnterior As Form)
        InitializeComponent()
        formAnterior = pformAnterior
    End Sub
    Private Sub btnMin_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub FrmMostrarBitacoraErrores_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub FrmMostrarBitacoraErrores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtgBitacoraErrores.DataSource = gestorBitacora.obtenerBitacoraError()
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        formAnterior.Show()
        Me.Hide()
    End Sub
    ''' <summary>
    ''' El tbnExportar, hace que exporte a pdf los datos que obtiene en el dataGridView.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click, btnExportar.Click
        'Crea iTextSharp Table desde la data del tableData
        Dim pdfTable As New PdfPTable(dtgBitacoraErrores.ColumnCount)
        pdfTable.DefaultCell.Padding = 4
        pdfTable.WidthPercentage = 60
        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT
        pdfTable.DefaultCell.BorderWidth = 1

        'Aqui agrega el header
        For Each column As DataGridViewColumn In dtgBitacoraErrores.Columns
            Dim cell As New PdfPCell(New Phrase(column.HeaderText))
            cell.BackgroundColor = New iTextSharp.text.BaseColor(240, 240, 240)
            pdfTable.AddCell(cell)
        Next

        'Aqui agrega el datarow
        For Each row As DataGridViewRow In dtgBitacoraErrores.Rows
            For Each cell As DataGridViewCell In row.Cells
                pdfTable.AddCell(cell.Value.ToString())
            Next
        Next

        'Metodo para exportar a pdf
        Try
            Dim folderPath As String = direccionExportar 'carpeta donde envia el pdf 
            If Not Directory.Exists(folderPath) Then
                Directory.CreateDirectory(folderPath)
            End If
            Using stream As New FileStream(folderPath & "BitacoraError.pdf", FileMode.Create)
                Dim pdfDoc As New Document(PageSize.A2, 10.0F, 10.0F, 10.0F, 0.0F)
                PdfWriter.GetInstance(pdfDoc, stream)
                pdfDoc.Open()
                pdfDoc.Add(pdfTable)
                pdfDoc.Close()
                stream.Close()
            End Using
            PopExportadoExitoso.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dtgBitacoraErrores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgBitacoraErrores.CellContentClick

    End Sub

End Class