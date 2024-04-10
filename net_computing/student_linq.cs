// using System;

// namespace ConsoleApp
// {
//     class Program
//     {   
//         public class Student
//         {
//             public int StudentID { get; set; }
//             public string StudentName { get; set; }
//             public int Age { get; set; }
//         }
//         static void Main(string[] args)
//         {
//             IList<Student> studentList=new List<Student>{
//                 new Student(){StudentID=1,StudentName="John",Age=18},
//                 new Student(){StudentID=2,StudentName="Steve",Age=21},
//                 new Student(){StudentID=3,StudentName="Bill",Age=25},
//                 new Student(){StudentID=4,StudentName="Ram",Age=20},
//                 new Student(){StudentID=5,StudentName="Ron",Age=31},
//             };
//             // var teenAgerStudent=from s in studentList where s.Age>12 && s.Age<20 select s;
//             // Another Method
//             var teenAgerStudent=studentList.Where((s=>s.Age>12 && s.Age<20));
//             System.Console.WriteLine("Teen age Students:");
//             foreach(Student std in teenAgerStudent){
//                 System.Console.WriteLine(std.StudentName);
//             }
//         }
//     }
// }