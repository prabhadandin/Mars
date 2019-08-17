using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowPages
{
    public class ConstantUtils
    {
        //Base Url
        public static string Url = "http://www.skillswap.pro/";

        //ScreenshotPath
        //public static string ScreenshotPath = @"G:\IC_Projects\Mars\SpecflowTests-Base\SpecflowTests\SpecflowPages\TestReports\Screenshots\";
        public static string ScreenshotPath = Directory.GetCurrentDirectory();


        //ExtentReportsPath
        public static string ReportsPath = Directory.GetCurrentDirectory();

        //ReportXML Path
        public static string ReportXMLPath = Directory.GetCurrentDirectory();



    }
}
