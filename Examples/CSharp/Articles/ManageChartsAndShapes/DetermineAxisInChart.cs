﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspose.Cells.Charts;

namespace Aspose.Cells.Examples.CSharp.Articles.ManageChartsAndShapes
{
    public class DetermineAxisInChart
    {
        public static void Run()
        {
            // ExStart:DetermineAxisInChart
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // Create workbook object
            Workbook workbook = new Workbook(dataDir + "source.xlsx");

            // Access the first worksheet
            Worksheet worksheet = workbook.Worksheets[0];

            // Access the chart
            Chart chart = worksheet.Charts[0];

            //Determine which axis exists in chart
            bool ret = chart.HasAxis(AxisType.Category, true);
            Console.WriteLine("Has Primary Category Axis: " + ret);

            ret = chart.HasAxis(AxisType.Category, false);
            Console.WriteLine("Has Secondary Category Axis: " + ret);

            ret = chart.HasAxis(AxisType.Value, true);
            Console.WriteLine("Has Primary Value Axis: " + ret);

            ret = chart.HasAxis(AxisType.Value, false);
            Console.WriteLine("Has Seconary Value Axis: " + ret);
            // ExEnd:DetermineAxisInChart
        }
    }
}
