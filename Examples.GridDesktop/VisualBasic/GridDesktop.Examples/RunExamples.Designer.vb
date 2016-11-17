Partial Class RunExamples
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Me.menuStrip = New System.Windows.Forms.MenuStrip()
		Me.articlesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.copyAndPasteRowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.dataBindingFeaturesInWorksheetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.workingWithGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.managingContextMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.openingExcelFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.savingExcelFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.gridDesktopEventsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.workingWithWorksheetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.accessingWorksheetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.addORInsertWorksheetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.removeAWorksheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.renameAWorksheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.importDataFromDataTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.workingWithRowsAndColumnsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.workingWithCellsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.closeAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.exportDataToDataTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.workingWithValidationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.sortDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.managingHyperlinksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.managingPicturesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.managingCommentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.addingCellControlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.managingCellControlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.showHideScrolBarsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.movingWorksheetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.readingDataValidationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.zoomingInOrOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.menuStrip.SuspendLayout()
		Me.SuspendLayout()
		' 
		' menuStrip
		' 
		Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.articlesToolStripMenuItem, Me.workingWithGridToolStripMenuItem, Me.workingWithWorksheetsToolStripMenuItem, Me.workingWithRowsAndColumnsToolStripMenuItem, Me.workingWithCellsToolStripMenuItem, Me.closeAllToolStripMenuItem, _
			Me.exitToolStripMenuItem})
		Me.menuStrip.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip.Name = "menuStrip"
		Me.menuStrip.Size = New System.Drawing.Size(854, 24)
		Me.menuStrip.TabIndex = 1
		Me.menuStrip.Text = "menuStrip1"
		' 
		' articlesToolStripMenuItem
		' 
		Me.articlesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.copyAndPasteRowsToolStripMenuItem, Me.dataBindingFeaturesInWorksheetsToolStripMenuItem})
		Me.articlesToolStripMenuItem.Name = "articlesToolStripMenuItem"
		Me.articlesToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
		Me.articlesToolStripMenuItem.Text = "Articles"
		' 
		' copyAndPasteRowsToolStripMenuItem
		' 
		Me.copyAndPasteRowsToolStripMenuItem.Name = "copyAndPasteRowsToolStripMenuItem"
		Me.copyAndPasteRowsToolStripMenuItem.Size = New System.Drawing.Size(266, 22)
		Me.copyAndPasteRowsToolStripMenuItem.Text = "Copy And Paste Rows"
		AddHandler Me.copyAndPasteRowsToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.copyAndPasteRowsToolStripMenuItem_Click)
		' 
		' dataBindingFeaturesInWorksheetsToolStripMenuItem
		' 
		Me.dataBindingFeaturesInWorksheetsToolStripMenuItem.Name = "dataBindingFeaturesInWorksheetsToolStripMenuItem"
		Me.dataBindingFeaturesInWorksheetsToolStripMenuItem.Size = New System.Drawing.Size(266, 22)
		Me.dataBindingFeaturesInWorksheetsToolStripMenuItem.Text = "Data Binding Features in Worksheets"
		AddHandler Me.dataBindingFeaturesInWorksheetsToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.dataBindingFeaturesInWorksheetsToolStripMenuItem_Click)
		' 
		' workingWithGridToolStripMenuItem
		' 
		Me.workingWithGridToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.managingContextMenuToolStripMenuItem, Me.openingExcelFileToolStripMenuItem, Me.savingExcelFileToolStripMenuItem, Me.gridDesktopEventsToolStripMenuItem})
		Me.workingWithGridToolStripMenuItem.Name = "workingWithGridToolStripMenuItem"
		Me.workingWithGridToolStripMenuItem.Size = New System.Drawing.Size(117, 20)
		Me.workingWithGridToolStripMenuItem.Text = "Working With Grid"
		' 
		' managingContextMenuToolStripMenuItem
		' 
		Me.managingContextMenuToolStripMenuItem.Name = "managingContextMenuToolStripMenuItem"
		Me.managingContextMenuToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
		Me.managingContextMenuToolStripMenuItem.Text = "Managing Context Menu"
		AddHandler Me.managingContextMenuToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.managingContextMenuToolStripMenuItem_Click)
		' 
		' openingExcelFileToolStripMenuItem
		' 
		Me.openingExcelFileToolStripMenuItem.Name = "openingExcelFileToolStripMenuItem"
		Me.openingExcelFileToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
		Me.openingExcelFileToolStripMenuItem.Text = "Opening Excel File"
		AddHandler Me.openingExcelFileToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.openingExcelFileToolStripMenuItem_Click)
		' 
		' savingExcelFileToolStripMenuItem
		' 
		Me.savingExcelFileToolStripMenuItem.Name = "savingExcelFileToolStripMenuItem"
		Me.savingExcelFileToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
		Me.savingExcelFileToolStripMenuItem.Text = "Saving Excel File"
		AddHandler Me.savingExcelFileToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.savingExcelFileToolStripMenuItem_Click)
		' 
		' gridDesktopEventsToolStripMenuItem
		' 
		Me.gridDesktopEventsToolStripMenuItem.Name = "gridDesktopEventsToolStripMenuItem"
		Me.gridDesktopEventsToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
		Me.gridDesktopEventsToolStripMenuItem.Text = "GridDesktop Events"
		AddHandler Me.gridDesktopEventsToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.gridDesktopEventsToolStripMenuItem_Click)
		' 
		' workingWithWorksheetsToolStripMenuItem
		' 
		Me.workingWithWorksheetsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.accessingWorksheetsToolStripMenuItem, Me.addORInsertWorksheetsToolStripMenuItem, Me.removeAWorksheetToolStripMenuItem, Me.renameAWorksheetToolStripMenuItem, Me.importDataFromDataTableToolStripMenuItem, Me.exportDataToDataTableToolStripMenuItem, _
			Me.workingWithValidationsToolStripMenuItem, Me.sortDataToolStripMenuItem, Me.managingHyperlinksToolStripMenuItem, Me.managingPicturesToolStripMenuItem, Me.managingCommentsToolStripMenuItem, Me.addingCellControlsToolStripMenuItem, _
			Me.managingCellControlsToolStripMenuItem, Me.showHideScrolBarsToolStripMenuItem, Me.movingWorksheetsToolStripMenuItem, Me.readingDataValidationsToolStripMenuItem, Me.zoomingInOrOutToolStripMenuItem})
		Me.workingWithWorksheetsToolStripMenuItem.Name = "workingWithWorksheetsToolStripMenuItem"
		Me.workingWithWorksheetsToolStripMenuItem.Size = New System.Drawing.Size(151, 20)
		Me.workingWithWorksheetsToolStripMenuItem.Text = "Working With Worksheet"
		' 
		' accessingWorksheetsToolStripMenuItem
		' 
		Me.accessingWorksheetsToolStripMenuItem.Name = "accessingWorksheetsToolStripMenuItem"
		Me.accessingWorksheetsToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
		Me.accessingWorksheetsToolStripMenuItem.Text = "Accessing Worksheets"
		AddHandler Me.accessingWorksheetsToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.accessingWorksheetsToolStripMenuItem_Click)
		' 
		' addORInsertWorksheetsToolStripMenuItem
		' 
		Me.addORInsertWorksheetsToolStripMenuItem.Name = "addORInsertWorksheetsToolStripMenuItem"
		Me.addORInsertWorksheetsToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
		Me.addORInsertWorksheetsToolStripMenuItem.Text = "Add OR Insert Worksheets"
		AddHandler Me.addORInsertWorksheetsToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.addORInsertWorksheetsToolStripMenuItem_Click)
		' 
		' removeAWorksheetToolStripMenuItem
		' 
		Me.removeAWorksheetToolStripMenuItem.Name = "removeAWorksheetToolStripMenuItem"
		Me.removeAWorksheetToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
		Me.removeAWorksheetToolStripMenuItem.Text = "Remove A Worksheet"
		AddHandler Me.removeAWorksheetToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.removeAWorksheetToolStripMenuItem_Click)
		' 
		' renameAWorksheetToolStripMenuItem
		' 
		Me.renameAWorksheetToolStripMenuItem.Name = "renameAWorksheetToolStripMenuItem"
		Me.renameAWorksheetToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
		Me.renameAWorksheetToolStripMenuItem.Text = "Rename A Worksheet"
		AddHandler Me.renameAWorksheetToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.renameAWorksheetToolStripMenuItem_Click)
		' 
		' importDataFromDataTableToolStripMenuItem
		' 
		Me.importDataFromDataTableToolStripMenuItem.Name = "importDataFromDataTableToolStripMenuItem"
		Me.importDataFromDataTableToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
		Me.importDataFromDataTableToolStripMenuItem.Text = "Import Data From DataTable"
		AddHandler Me.importDataFromDataTableToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.importDataFromDataTableToolStripMenuItem_Click)
		' 
		' workingWithRowsAndColumnsToolStripMenuItem
		' 
		Me.workingWithRowsAndColumnsToolStripMenuItem.Name = "workingWithRowsAndColumnsToolStripMenuItem"
		Me.workingWithRowsAndColumnsToolStripMenuItem.Size = New System.Drawing.Size(197, 20)
		Me.workingWithRowsAndColumnsToolStripMenuItem.Text = "Working With Rows and Columns"
		' 
		' workingWithCellsToolStripMenuItem
		' 
		Me.workingWithCellsToolStripMenuItem.Name = "workingWithCellsToolStripMenuItem"
		Me.workingWithCellsToolStripMenuItem.Size = New System.Drawing.Size(120, 20)
		Me.workingWithCellsToolStripMenuItem.Text = "Working With Cells"
		' 
		' closeAllToolStripMenuItem
		' 
		Me.closeAllToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
		Me.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem"
		Me.closeAllToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
		Me.closeAllToolStripMenuItem.Text = "Close All"
		AddHandler Me.closeAllToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.closeAllToolStripMenuItem_Click)
		' 
		' exitToolStripMenuItem
		' 
		Me.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Red
		Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
		Me.exitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
		Me.exitToolStripMenuItem.Text = "Exit"
		AddHandler Me.exitToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.exitToolStripMenuItem_Click)
		' 
		' exportDataToDataTableToolStripMenuItem
		' 
		Me.exportDataToDataTableToolStripMenuItem.Name = "exportDataToDataTableToolStripMenuItem"
		Me.exportDataToDataTableToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
		Me.exportDataToDataTableToolStripMenuItem.Text = "Export Data To DataTable"
		AddHandler Me.exportDataToDataTableToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.exportDataToDataTableToolStripMenuItem_Click)
		' 
		' workingWithValidationsToolStripMenuItem
		' 
		Me.workingWithValidationsToolStripMenuItem.Name = "workingWithValidationsToolStripMenuItem"
		Me.workingWithValidationsToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
		Me.workingWithValidationsToolStripMenuItem.Text = "Working With Validations"
		AddHandler Me.workingWithValidationsToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.workingWithValidationsToolStripMenuItem_Click)
		' 
		' sortDataToolStripMenuItem
		' 
		Me.sortDataToolStripMenuItem.Name = "sortDataToolStripMenuItem"
		Me.sortDataToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
		Me.sortDataToolStripMenuItem.Text = "Sort Data"
		AddHandler Me.sortDataToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.sortDataToolStripMenuItem_Click)
		' 
		' managingHyperlinksToolStripMenuItem
		' 
		Me.managingHyperlinksToolStripMenuItem.Name = "managingHyperlinksToolStripMenuItem"
		Me.managingHyperlinksToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
		Me.managingHyperlinksToolStripMenuItem.Text = "Managing Hyperlinks"
		AddHandler Me.managingHyperlinksToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.managingHyperlinksToolStripMenuItem_Click)
		' 
		' managingPicturesToolStripMenuItem
		' 
		Me.managingPicturesToolStripMenuItem.Name = "managingPicturesToolStripMenuItem"
		Me.managingPicturesToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
		Me.managingPicturesToolStripMenuItem.Text = "Managing Pictures"
		AddHandler Me.managingPicturesToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.managingPicturesToolStripMenuItem_Click)
		' 
		' managingCommentsToolStripMenuItem
		' 
		Me.managingCommentsToolStripMenuItem.Name = "managingCommentsToolStripMenuItem"
		Me.managingCommentsToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
		Me.managingCommentsToolStripMenuItem.Text = "Managing Comments"
		AddHandler Me.managingCommentsToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.managingCommentsToolStripMenuItem_Click)
		' 
		' addingCellControlsToolStripMenuItem
		' 
		Me.addingCellControlsToolStripMenuItem.Name = "addingCellControlsToolStripMenuItem"
		Me.addingCellControlsToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
		Me.addingCellControlsToolStripMenuItem.Text = "Adding Cell Controls"
		AddHandler Me.addingCellControlsToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.addingCellControlsToolStripMenuItem_Click)
		' 
		' managingCellControlsToolStripMenuItem
		' 
		Me.managingCellControlsToolStripMenuItem.Name = "managingCellControlsToolStripMenuItem"
		Me.managingCellControlsToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
		Me.managingCellControlsToolStripMenuItem.Text = "Managing Cell Controls"
		AddHandler Me.managingCellControlsToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.managingCellControlsToolStripMenuItem_Click)
		' 
		' showHideScrolBarsToolStripMenuItem
		' 
		Me.showHideScrolBarsToolStripMenuItem.Name = "showHideScrolBarsToolStripMenuItem"
		Me.showHideScrolBarsToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
		Me.showHideScrolBarsToolStripMenuItem.Text = "Show Hide Scrol Bars"
		AddHandler Me.showHideScrolBarsToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.showHideScrolBarsToolStripMenuItem_Click)
		' 
		' movingWorksheetsToolStripMenuItem
		' 
		Me.movingWorksheetsToolStripMenuItem.Name = "movingWorksheetsToolStripMenuItem"
		Me.movingWorksheetsToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
		Me.movingWorksheetsToolStripMenuItem.Text = "Moving Worksheets"
		AddHandler Me.movingWorksheetsToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.movingWorksheetsToolStripMenuItem_Click)
		' 
		' readingDataValidationsToolStripMenuItem
		' 
		Me.readingDataValidationsToolStripMenuItem.Name = "readingDataValidationsToolStripMenuItem"
		Me.readingDataValidationsToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
		Me.readingDataValidationsToolStripMenuItem.Text = "Reading Data Validations"
		AddHandler Me.readingDataValidationsToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.readingDataValidationsToolStripMenuItem_Click)
		' 
		' zoomingInOrOutToolStripMenuItem
		' 
		Me.zoomingInOrOutToolStripMenuItem.Name = "zoomingInOrOutToolStripMenuItem"
		Me.zoomingInOrOutToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
		Me.zoomingInOrOutToolStripMenuItem.Text = "Zooming In or Out"
		AddHandler Me.zoomingInOrOutToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.zoomingInOrOutToolStripMenuItem_Click)
		' 
		' RunExamples
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(854, 530)
		Me.Controls.Add(Me.menuStrip)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.IsMdiContainer = True
		Me.MainMenuStrip = Me.menuStrip
		Me.Name = "RunExamples"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Aspose.Cells for .NET GridDesktop Examples"
		Me.menuStrip.ResumeLayout(False)
		Me.menuStrip.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private menuStrip As System.Windows.Forms.MenuStrip
	Private articlesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private workingWithGridToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private workingWithWorksheetsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private workingWithRowsAndColumnsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private workingWithCellsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private copyAndPasteRowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private dataBindingFeaturesInWorksheetsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private closeAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private managingContextMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private openingExcelFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private savingExcelFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private gridDesktopEventsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private accessingWorksheetsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private addORInsertWorksheetsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private removeAWorksheetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private renameAWorksheetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private importDataFromDataTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private exportDataToDataTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private workingWithValidationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private sortDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private managingHyperlinksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private managingPicturesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private managingCommentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private addingCellControlsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private managingCellControlsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private showHideScrolBarsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private movingWorksheetsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private readingDataValidationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private zoomingInOrOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

