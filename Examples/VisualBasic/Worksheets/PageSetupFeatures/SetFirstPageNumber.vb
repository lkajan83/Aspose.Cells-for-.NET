﻿Imports System.IO
Imports Aspose.Cells

Namespace Worksheets.PageSetupFeatures
    Public Class SetFirstPageNumber
        Public Shared Sub Run()
            ' ExStart:1
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Instantiating a Workbook object
            Dim workbook As New Workbook()

            ' Accessing the first worksheet in the Excel file
            Dim worksheet As Worksheet = workbook.Worksheets(0)

            ' Setting the first page number of the worksheet pages
            worksheet.PageSetup.FirstPageNumber = 2

            ' Save the Workbook.
            workbook.Save(dataDir & Convert.ToString("SetFirstPageNumber_out.xls"))
            ' ExEnd:1
        End Sub
    End Class
End Namespace