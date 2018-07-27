using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwTestFrameClient
{
    class ExcelUtils
    {
        public static XSSFWorkbook GetWorkBook(string TestCaseName)
        {
            XSSFWorkbook workbook;
            FileStream fileStream;
            string path = "./testCase/" + TestCaseName + "/main.xlsx";
            fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            workbook = new XSSFWorkbook(fileStream);  //xlsx数据读入workbook  
            fileStream.Close();
            workbook.Close();
            return workbook;

        }

        public static int GetRunCaseNum(string fileName)
        {
            XSSFWorkbook workbook = GetWorkBook(fileName);
            ISheet sheet = workbook.GetSheet("TestCases");
            int LastRowNum = sheet.LastRowNum + 1;
            IRow row;
            int RunCaseCount = 0;
            for (int i = 1; i < LastRowNum; i++)  //获取测试用例 
            {
                row = sheet.GetRow(i);   //row读入第i行数据  
                if (row != null)
                {
                    string cellValue = row.GetCell(0).ToString().ToLower(); //获取i行j列数据  
                    if (cellValue.Equals("y"))
                    {
                        RunCaseCount++;
                    }
                }
            }
            return RunCaseCount;
        }

        public static List<string> GetDevicesName()
        {
            List<string> mList = new List<string>();
            string path = "./devices/AndroidDevices.xlsx";
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            XSSFWorkbook workbook = new XSSFWorkbook(fileStream);  //xlsx数据读入workbook  
            fileStream.Close();
            workbook.Close();
            int count = workbook.NumberOfSheets;
            for (int i = 0; i < count; i++)
            {
                mList.Add(workbook.GetSheetAt(i).SheetName);
            }
            return mList;
        }
    }
}
