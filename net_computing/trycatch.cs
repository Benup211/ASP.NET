// using System;

// namespace ConsoleApp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             try
//             {
//                 int a=10;
//                 int b=0;
//                 int c=a/b;
//                 Console.WriteLine(c);
                
//             }
//             catch(DivideByZeroException e1)
//             {
//                 Console.WriteLine(e1.ToString());
//             }
//             try{
//                 int[] arr={10,20,30};
//                 Console.WriteLine(arr[5]);
//             }
//             catch(IndexOutOfRangeException e2)
//             {
//                 Console.WriteLine("Array index problem:{0}",e2.ToString());
//             }
//             finally
//             {
//                 System.Console.WriteLine("This is executed in final");
//             }
//         }
//     }
// }