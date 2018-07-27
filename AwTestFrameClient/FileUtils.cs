using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwTestFrameClient
{
    class FileUtils
    {
        public static List<string> getAllfolderName()
        {
            List<string> mList = new List<string>();
            DirectoryInfo folder = new DirectoryInfo(Directory.GetCurrentDirectory() + "/TestCase");
            foreach (DirectoryInfo folderName in folder.GetDirectories())
            {
                string fileList = getFileName(folderName.Name);
                if (fileList.Equals("1"))
                {
                    mList.Add(folderName.Name);
                }
            }
            return mList;
        }

        public static string getFileName(string folderName)
        {
            string num = "0";
            DirectoryInfo folder = new DirectoryInfo(Directory.GetCurrentDirectory() + "/TestCase/" + folderName);
            foreach (FileInfo file in folder.GetFiles("main.xlsx"))
            {
                num = "1";
            }
            return num;
        }

        public static List<string> getAllFileName(string folderName)
        {
            List<string> mList = new List<string>();
            DirectoryInfo folder = new DirectoryInfo("./TestCase/" + folderName + "/apps");
            if (folder.GetFiles("*.apk").Length > 0)
            {
                foreach (FileInfo file in folder.GetFiles("*.apk"))
                {
                    mList.Add(file.Name);
                }
            }
            return mList;
        }
    }
}
