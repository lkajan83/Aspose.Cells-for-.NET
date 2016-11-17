﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GridDesktop.Examples.WorkingWithGrid;
using GridDesktop.Examples.Articles;
using GridDesktop.Examples.WorkingWithWorksheet;

namespace GridDesktop.Examples
{
    public partial class RunExamples : Form
    {
        public RunExamples()
        {
            InitializeComponent();
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm != this)
                {
                    frm.Close();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copyAndPasteRowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyAndPasteRows frmCopyPasteRows = new CopyAndPasteRows();
            frmCopyPasteRows.MdiParent = this;
            frmCopyPasteRows.Show();
        }

        private void dataBindingFeaturesInWorksheetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBindingFeature frmDataBindingFeatures = new DataBindingFeature();
            frmDataBindingFeatures.MdiParent = this;
            frmDataBindingFeatures.Show();
        }

        private void managingContextMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagingContextMenu frmManagingContextMenu = new ManagingContextMenu();
            frmManagingContextMenu.MdiParent = this;
            frmManagingContextMenu.Show();
        }

        private void openingExcelFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpeningExcelFile frmOpeningExcelFile = new OpeningExcelFile();
            frmOpeningExcelFile.MdiParent = this;
            frmOpeningExcelFile.Show();
        }

        private void savingExcelFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavingExcelFile frmSavingExcelFile = new SavingExcelFile();
            frmSavingExcelFile.MdiParent = this;
            frmSavingExcelFile.Show();
        }

        private void gridDesktopEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridDesktopEvents frmGridDesktopEvents = new GridDesktopEvents();
            frmGridDesktopEvents.MdiParent = this;
            frmGridDesktopEvents.Show();
        }

        private void accessingWorksheetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccessingWorksheets frmAccessingWorksheets = new AccessingWorksheets();
            frmAccessingWorksheets.MdiParent = this;
            frmAccessingWorksheets.Show();
        }

        private void addORInsertWorksheetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddInsertWorksheet frmAddInsertWorksheet = new AddInsertWorksheet();
            frmAddInsertWorksheet.MdiParent = this;
            frmAddInsertWorksheet.Show();
        }

        private void removeAWorksheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveWorksheet frmRemoveWorksheet = new RemoveWorksheet();
            frmRemoveWorksheet.MdiParent = this;
            frmRemoveWorksheet.Show();
        }

        private void renameAWorksheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenameWorksheet frmRenameWorksheet = new RenameWorksheet();
            frmRenameWorksheet.MdiParent = this;
            frmRenameWorksheet.Show();
        }

        private void importDataFromDataTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportDataFromDataTable frmImportData = new ImportDataFromDataTable();
            frmImportData.MdiParent = this;
            frmImportData.Show();
        }

        private void exportDataToDataTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportDataToDataTable frmExportData = new ExportDataToDataTable();
            frmExportData.MdiParent = this;
            frmExportData.Show();
        }

        private void workingWithValidationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ValidationInWorksheets frmValidations = new ValidationInWorksheets();
            frmValidations.MdiParent = this;
            frmValidations.Show();
        }

        private void sortDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortData frmSortData = new SortData();
            frmSortData.MdiParent = this;
            frmSortData.Show();
        }

        private void managingHyperlinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagingHyperlinks frmHyperlinks = new ManagingHyperlinks();
            frmHyperlinks.MdiParent = this;
            frmHyperlinks.Show();
        }

        private void managingPicturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagingPictures frmManagingPictures = new ManagingPictures();
            frmManagingPictures.MdiParent = this;
            frmManagingPictures.Show();
        }

        private void managingCommentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagingComments frmManagingComments = new ManagingComments();
            frmManagingComments.MdiParent = this;
            frmManagingComments.Show();
        }

        private void addingCellControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddingCellControls frmAddingCellControls = new AddingCellControls();
            frmAddingCellControls.MdiParent = this;
            frmAddingCellControls.Show();
        }

        private void managingCellControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagingCellControls frmManagingCellControls = new ManagingCellControls();
            frmManagingCellControls.MdiParent = this;
            frmManagingCellControls.Show();
        }

        private void showHideScrolBarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayHideScrolBars frmDisplayHideScrols = new DisplayHideScrolBars();
            frmDisplayHideScrols.MdiParent = this;
            frmDisplayHideScrols.Show();
        }

        private void movingWorksheetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovingWorksheets frmMovingWorksheets = new MovingWorksheets();
            frmMovingWorksheets.MdiParent = this;
            frmMovingWorksheets.Show();
        }

        private void readingDataValidationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadingDataValidations frmDataValidations = new ReadingDataValidations();
            frmDataValidations.MdiParent = this;
            frmDataValidations.Show();
        }

        private void zoomingInOrOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoomingInOut frmZoomingInOut = new ZoomingInOut();
            frmZoomingInOut.MdiParent = this;
            frmZoomingInOut.Show();
        }
    }
}