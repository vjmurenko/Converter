using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Word;
using System.Xml.Linq;
using System.Threading;

namespace Converter.BL
{
    public interface IFileManager
    {

        List<string> GetContent(string filePathE);
        string Filter(List<string> list);
        void SaveContent(string content, string filePathW);
        bool IsExist(string filePath);
        void SaveLog(string log, string fileParthL);
        string WriteLog(string message);


    }
    public class FileManager : IFileManager
    {
        private readonly Encoding _defaultEncoding = Encoding.GetEncoding(1251);

        public List<string> GetContent(string filePath)
        {

            string buffer;
            List<string> list = new List<string>();


            Microsoft.Office.Interop.Excel.Application ObjExcel = new Microsoft.Office.Interop.Excel.Application();
            System.Diagnostics.Process excelProc = System.Diagnostics.Process.GetProcessesByName("EXCEL").Last();
            Microsoft.Office.Interop.Excel.Workbook ObjWorkBook = ObjExcel.Workbooks.Open
            (filePath, 0, true, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet;
            ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];

            for (int i = 1; i < 20; i++)
            {

                Microsoft.Office.Interop.Excel.Range range = ObjWorkSheet.get_Range("A" + i.ToString(), "A" + i.ToString());
                buffer = range.Text.ToString();

                if (Regex.IsMatch(buffer, "^$"))
                {
                    continue;
                }
                list.Add(buffer);

            }

            ObjWorkBook.Close();
            ObjExcel.Quit();
            excelProc.Kill();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(ObjExcel);
            ObjWorkBook = null;
            ObjExcel = null;
            ObjWorkSheet = null;
            GC.Collect();

            return list;
        }

        public string Filter(List<string> list)
        {
           
            string number = null;
            string symbol = null;
            foreach (string buffer in list)
            {
                if (Regex.IsMatch(buffer, @"\D"))
                {
                    symbol += buffer + " ";
                }

                if (Regex.IsMatch(buffer, @"\D\d"))
                {

                    Regex regex = new Regex("[0-9]{1}");
                    Match match = regex.Match(buffer);

                    if (Regex.IsMatch(buffer, @"^[0-9]/D"))
                    {
                        number += buffer.Remove(4) + "-";
                    }
                    else
                    {
                        if ((buffer.Length - match.Index) > 4)
                        {                           
                            number += buffer.Substring(match.Index).Remove(4) + "-";
                        }

                        else
                        {
                            number += buffer.Substring(match.Index) + "-";
                        }
                    }


                }
                else if (Regex.IsMatch(buffer, @"^[0-9]{1}") && buffer.Length > 4)
                {
                    number += buffer.Remove(4) + "-";
                }

                else if (Regex.IsMatch(buffer, @"^[0-9]{1,1}"))
                {
                    number += buffer + "-";
                }


            }
            number = number.Substring(0, number.Length - 1);
            symbol = symbol.Substring(0, symbol.Length - 1);
            return number + "\n" + symbol;
        }

        public void SaveContent(string content, string filePathW)
        {
            object missing = System.Reflection.Missing.Value;
            object start1 = 0;
            object end1 = 0;

            Application WordApp = new Application();
            Document adoc = WordApp.Documents.Add(ref missing, ref missing, ref missing, ref missing);
            Range rng = adoc.Range(ref start1, ref missing);

            rng.InsertAfter(content);
            object filename = filePathW;
            adoc.SaveAs(ref filename, ref missing, ref missing, ref missing, ref missing, ref missing,
              ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
             ref missing, ref missing, ref missing);


            adoc.Close();
            WordApp.Quit();
            adoc = null;
            WordApp = null;

            GC.Collect();


        }

        public bool IsExist(string filePath)
        {
            bool isExist = File.Exists(filePath);
            return isExist;
        }

        public string WriteLog(string message)
        {
            return DateTime.Now + "  " + message + '\r' + '\n';
        }

        public void SaveLog(string log, string fileParthL)
        {
            File.WriteAllText(fileParthL, log, _defaultEncoding);
        }
    }
}
