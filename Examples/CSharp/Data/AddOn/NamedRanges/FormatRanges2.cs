using System.IO;

using Aspose.Cells;
using System.Drawing;

namespace Aspose.Cells.Examples.CSharp.Data.AddOn.NamedRanges
{
    public class FormatRanges2
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // Create directory if it is not already present.
            bool IsExists = System.IO.Directory.Exists(dataDir);
            if (!IsExists)
                System.IO.Directory.CreateDirectory(dataDir);

            // Instantiating a Workbook object
            Workbook workbook = new Workbook();

            // Clears the worksheets
            workbook.Worksheets.Clear();

            // Adding a new worksheet to the Workbook object
            workbook.Worksheets.Add();

            // Obtaining the reference of the newly added worksheet by passing its sheet index
            Worksheet worksheet = workbook.Worksheets[0];

            // Accessing the "A1" cell from the worksheet
            Cell cell = worksheet.Cells["A1"];

            // Adding some value to the "A1" cell
            cell.PutValue("Hello World From Aspose");

            // Creating a range of cells starting from "A1" cell to 3rd column in a row
            Range range = worksheet.Cells.CreateRange(0, 0, 1, 3);

            // Adding a thick top border with blue line
            range.SetOutlineBorder(BorderType.TopBorder, CellBorderType.Thick, Color.Blue);

            // Adding a thick bottom border with blue line
            range.SetOutlineBorder(BorderType.BottomBorder, CellBorderType.Thick, Color.Blue);

            // Adding a thick left border with blue line
            range.SetOutlineBorder(BorderType.LeftBorder, CellBorderType.Thick, Color.Blue);

            // Adding a thick right border with blue line
            range.SetOutlineBorder(BorderType.RightBorder, CellBorderType.Thick, Color.Blue);

            // Saving the Excel file
            workbook.Save(dataDir + "book1.out.xls"); 
            // ExEnd:1
        }
    }
}
