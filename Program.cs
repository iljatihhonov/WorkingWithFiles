using System;
using System.IO;

namespace week12_WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryName = "";
            CreateDirectory(directoryName);

            Console.WriteLine("What you want to do with files? (create, delete or move):");
            string type = Console.ReadLine().ToLower();

            if (type != "create" ^ type != "delete" ^ type != "move")
            {
                Console.WriteLine("WRONG!");

                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("And new file name is?");
                string fileName = Console.ReadLine();

                if (type == "create")
                {
                    CreateFile(fileName);
                }
                else if (type == "move")
                {
                    MoveFile(fileName);
                }
                else if (type == "delete")
                {
                    DeleteFile(fileName);
                }
            }

        }
        public static void DeleteFile(string userFile)
        {
            string fileRoot = @"C:\Users\Master\source\repos\WorkingWithFiles\Data\";

            string filePath = fileRoot + userFile + ".txt";

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine($"File {userFile}.txt was deleted");
            }
            else
            {
                Console.WriteLine($"File {userFile}.txt wasn't found in Data");
            }
        }
        public static void MoveFile(string userFile)
        {
            string fileRoot = @"C:\Users\Master\source\repos\WorkingWithFiles\Data\";
            string dest = @"C:\Users\Master\source\repos\WorkingWithFiles\myData\";

            string filePath = fileRoot + userFile + ".txt";

            if (File.Exists(filePath))
            {
                File.Move(filePath, dest + userFile + ".txt");
                Console.WriteLine($"File {userFile}.txt was moved to a myData folder");
            }
            else
            {
                Console.WriteLine($"File {userFile}.txt wasn't found in Data");
            }
        }
        public static void CreateFile(string userFile)
        {
            string fileRoot = @"C:\Users\Master\source\repos\WorkingWithFiles\Data\";
            string filePath = fileRoot + userFile + ".txt";

            if (File.Exists(filePath))
            {
                Console.WriteLine($"File {userFile}.txt already exists in {fileRoot}");
            }
            else
            {
                File.Create(filePath);
                Console.WriteLine($"File {userFile}.txt has been created {fileRoot}");
            }
        }
        public static void CreateDirectory(string userDirectory)
        {
            string rootPath = @"C:\Users\Master\source\repos\WorkingWithFiles\";

            string directoryPath1 = rootPath + "Data";
            string directoryPath2 = rootPath + "myData";

            if (Directory.Exists(directoryPath1))
            {
                Console.WriteLine();
            }
            else if (Directory.Exists(directoryPath2))
            {
                Console.WriteLine();
            }
            else
            {
                Directory.CreateDirectory(directoryPath1);
                Directory.CreateDirectory(directoryPath2);
                Console.WriteLine("Directories Data and myData has been created");
            }
        }
    }
}