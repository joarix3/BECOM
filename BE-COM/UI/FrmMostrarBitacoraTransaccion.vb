Imports EntitiesLayer
Imports System.IO
Imports System.Data
Imports System.Reflection
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class FrmMostrarBitacoraTransaccion
    Public direccionExportar As String = "C:\Users\Mario\Desktop\Nueva carpeta\"
    Dim formAnterior As Form
    Public Sub New(pformAnterior As Form)
        InitializeComponent()
        formAnterior = pformAnterior
    End Sub
    Private Sub btnMin_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub FrmMostrarBitacoraTransaccion_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub FrmMostrarBitacoraTransaccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtgBitacoraTransaccion.DataSource = gestorBitacora.obtenerBitacoraTransaccion()
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        formAnterior.Show()
        Me.Hide()
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click, btnExportar.Click
        'Creating iTextSharp Table from the DataTable data
        Dim pdfTable As New PdfPTable(dtgBitacoraTransaccion.ColumnCount)
        pdfTable.DefaultCell.Padding = 4
        pdfTable.WidthPercentage = 60
        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT
        pdfTable.DefaultCell.BorderWidth = 1

        'Adding Header row
        For Each column As DataGridViewColumn In dtgBitacoraTransaccion.Columns
            Dim cell As New PdfPCell(New Phrase(column.HeaderText))
            cell.BackgroundColor = New iTextSharp.text.BaseColor(240, 240, 240)
            pdfTable.AddCell(cell)
        Next

        'Adding DataRow
        For Each row As DataGridViewRow In dtgBitacoraTransaccion.Rows
            For Each cell As DataGridViewCell In row.Cells
                pdfTable.AddCell(cell.Value.ToString())
            Next
        Next

        'Exporting to PDF
        Try
            Dim folderPath As String = direccionExportar
            If Not Directory.Exists(folderPath) Then
                Directory.CreateDirectory(folderPath)
            End If
            Using stream As New FileStream(folderPath & "BitacoraTransaccion.pdf", FileMode.Create)
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
End Class