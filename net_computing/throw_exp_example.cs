// using System;

// namespace ConsoleApp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             try
//             {
//                 throw new DivideByZeroException("Invalid Exception");
//             }
//             catch (DivideByZeroException e1)
//             {
//                 System.Console.WriteLine("Error is:{0}",e1.ToString());
//             }
//             finally
//             {
//                 System.Console.WriteLine("Final block");
//             }
//         }
//     }
// }