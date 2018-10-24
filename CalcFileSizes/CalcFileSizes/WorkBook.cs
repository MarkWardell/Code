using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace CalcFileSizes
{
    public class WorkBook
    {
        public bool OpenWorkBook(string path)
        {
            bool bretval = false;
            if  (File.Exists(path))
            {
                try { 
                    ClosedXML.Excel.IXLWorkbook wb = new ClosedXML.Excel.XLWorkbook(path);

                    foreach (var ws in wb.Worksheets)
                    {
                        Console.WriteLine(ws.Name);
                        processWS(ws);
                    }
                    wb.SaveAs(@"D:\\Metrics\\Sizes.xlsx");
                    if (wb != null)
                        bretval = true;
                }
                catch
                {
                    bretval = false;
                }
                
            }
            return bretval;
        }

        private void processWS(IXLWorksheet ws)
        {
            foreach(var r in ws.Rows())
            {
                string fName = r.Cell(1).Value.ToString();
                if (File.Exists(fName))
                {
                    FileInfo fi = new FileInfo(fName);
                    long size = fi.Length;
                    r.Cell(2).Value = size;

                }
            }
        }
    }
}
