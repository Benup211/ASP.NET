// using System;

// namespace ConsoleApp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//            IList<string> stringList=new List<string> {
//             "C# Tutorials","VB.NET Tutorials","Learn C++","MVC Tutorials","Java"
//            };
//             var result=from s in stringList where s.Contains("Tutorials") select s;
//             foreach(object str in result){
//                   Console.WriteLine(str);
//             }

//         }
//     }
// }