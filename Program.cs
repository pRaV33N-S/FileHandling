using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string fFolder = "D:\\Raven\\Practice Exercise\\";
            string newDir;
            Console.WriteLine("Enter New Directory Name");
            newDir = Console.ReadLine();
            string fPath = fFolder + newDir;
            // DirectoryInfo info = new DirectoryInfo(fPath);
            if (File.Exists(fPath))
            {
                Console.WriteLine($"Directory {newDir} already exist");
            }
            else
            {
                File.Create(fPath);
                Console.WriteLine($"Directory {newDir} creation on {fPath} success");
            }*/
            /*string fPath;
            Console.WriteLine("Enter Directory Path");
            fPath = Console.ReadLine();
            DirectoryInfo info = new DirectoryInfo(fPath);
            foreach (FileInfo fi in info.GetFiles())
            {
                Console.Write("File Name : "+fi.FullName);
                Console.Write("\t FileLength : "+fi.Length);
                Console.Write("\t File Creation Time : "+fi.CreationTime);
                Console.WriteLine();
            }*/
            /*Console.WriteLine("Enter File Path");
            string fPath = Console.ReadLine();
            if (File.Exists(fPath))
            {
                Console.WriteLine("File Already There");
            }
            else
            {
                StreamWriter sw = File.AppendText(fPath);
                sw.WriteLine("Welcome to Stream Writing Example");
                sw.Dispose();
                sw.Close();
                Console.WriteLine("Created and text is written");
            }*/
            /*StreamReader sr;
            try
            {
                string fPath = @"D:\Raven\Practice Exercise\C#\FileOne.txt";
                sr = new StreamReader(fPath);
                string text = "";
                while ((text = sr.ReadLine()) != null)
                {
                    Console.WriteLine(text);
                }
                sr.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }*/
            try
            {
                string path = @"D:\Raven\Practice Exercise\C#\";
                Console.WriteLine("Enter File Name to Read out from");
                string fName = Console.ReadLine();
                string fpath = path + fName;
                if (File.Exists(fpath))
                {
                    string[] lines = File.ReadAllLines(fpath);
                    foreach(string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
                else { Console.WriteLine("File does not exist"); }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
