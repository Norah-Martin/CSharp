using System;
using System.IO;

namespace FileOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //////file operations====1
            ////Console.WriteLine("enter the name ");
            ////string dir_name = Console.ReadLine();

            ////if (dir_name != string.Empty)
            ////{


            ////    //CREATE DIRECTORY
            ////    if (dir_name != string.Empty)
            ////    {
            ////        Directory.CreateDirectory(dir_name);
            ////        if (Directory.Exists(dir_name))
            ////        {
            ////            Console.WriteLine(" name already exist");
            ////        }
            ////        else
            ////        {
            ////            Console.WriteLine("succesful created");

            ////        }
            ////    }

            ////}

            ////fileoperation =====2

            //Console.WriteLine("enter the name ");
            //string dir_name = Console.ReadLine();

            //if (dir_name != string.Empty)
            //{
            //    Console.WriteLine("enter the new name ");
            //    string new_dir_name = Console.ReadLine();

            //    //CREATE DIRECTORY
            //    if (dir_name != string.Empty)
            //    {
            //        Directory.CreateDirectory(new_dir_name);
            //        if (Directory.Exists(new_dir_name))
            //        {
            //            Console.WriteLine("rename successful");
            //        }
            //    }

            //}

            ////3.
            ////file operations
            //Console.WriteLine("enter the name ");
            //string dir_name = Console.ReadLine();

            //if (dir_name != string.Empty)
            //{
            //    //delete directory
            //    if (dir_name != string.Empty)
            //    {
            //        Directory.Delete(dir_name);

            //        if (!Directory.Exists(dir_name))
            //        {
            //            Console.WriteLine("deleted successfully");
            //        }
            //    }

            //}

            ////for file

            //Console.WriteLine("enter the name ");
            //string file_name = Console.ReadLine();

            //if (file_name != string.Empty)
            //{
            //    //create  file
            //    if (file_name != string.Empty)
            //    {
            //        File.Create(file_name);

            //        if (!File.Exists(file_name))
            //        {
            //            Console.WriteLine("deleted successfully");
            //        }
            //        else
            //        {
            //            Console.WriteLine("created successfully");
            //        }
            //    }

            //}

            //delete file
            //Console.WriteLine("enter the name ");
            //string file_name = Console.ReadLine();

            //if (file_name != string.Empty)
            //{
            //    //create  file
            //    if (file_name != string.Empty)
            //    {
            //        File.Delete(file_name);

            //        if (!File.Exists(file_name))
            //        {
            //            Console.WriteLine("deleted successfully");
            //        }

            //    }

            //}

            //file reader
            //FileInfo fileInfo = new FileInfo(@"C:\\Users\\ASUS\\Desktop\\c#.net\\visual studio\\FileOperations\\bin\\Debug\\abc");
            //FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
            //StreamReader streamReader = new StreamReader(fileStream);
            //string filecontent = streamReader.ReadToEnd();
            //streamReader.Close();
            //fileStream.Close();
            //Console.WriteLine(filecontent);

            //file writer
            //FileInfo fileInfo = new FileInfo("");
            //FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
            //StreamWriter streamWriter = new StreamWriter(fileStream);
            //streamWriter.WriteLine("hi how are you?");
            //streamWriter.Close();
            //fileStream.Close();



            Console.ReadLine();
        }
    }
}
