using CatFactNetwise.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CatFactNetwise.Services
{
    public class FileService: IFileService
    {
        string Path = @"C:\aaa\MyTest.txt";
        public bool ExistFile()
        {
            var result = File.Exists(Path);
            return result;
        }

        public void MessageWriteToFile(string text)
        {
            if (!ExistFile())
            {
                AddTextToFile(WriteToFile.FirstTime, text);
            }
            else
            {
                AddTextToFile(WriteToFile.AddToExisting, text);
            }
        }
        public void AddTextToFile(WriteToFile writeToFile, string text)
        {
            
            if (writeToFile == WriteToFile.FirstTime)
            {
                using (StreamWriter sw = File.CreateText(Path))
                {
                    sw.WriteLine(text);
                }
            }
            else
            {
                if (!File.ReadLines(Path).Any(line => line.Contains(text)))
                {
                    using (StreamWriter sw = File.AppendText(Path))
                    {
                        sw.WriteLine(text);

                    }
                }
            }
          
        }


    }
}
