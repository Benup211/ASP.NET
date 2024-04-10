// using System;
// using System.IO;

// namespace ConsoleApp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string path = "file.txt";
//             string copyPath = "file_copy.txt";
//             if (File.Exists(path))
//             {
//                 System.Console.WriteLine("File exists");
//                 File.Copy(path, copyPath);
//                 System.Console.WriteLine("File copied successfully");
//             }
//             else
//             {
//                 System.Console.WriteLine("File does not exist");
//             }
//         }
//     }
// }