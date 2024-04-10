// using System;
// using System.Collections;
// using System.Collections.Generic;

// namespace ConsoleApp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             List<string> names=new List<string>();
//             names.Add("Hari");
//             names.Add("Sita");
//             names.Add("Gita");
//             System.Console.WriteLine(names.IndexOf("Sita"));//-1 if not found
//             System.Console.WriteLine(names.Count);
//             names.RemoveAt(1);
//             System.Console.WriteLine(names.Remove("Git"));//gives 0 if false
//             foreach(string s in names)
//             {
//                 System.Console.WriteLine(s);
//             }
//         }
//     }
// }