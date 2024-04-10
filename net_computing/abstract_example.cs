// using System;

// namespace ConsoleApp{
//     abstract class AbsClass{
//             abstract public void AbsMethod();
//             public void NonAbsMethod(){
//                 System.Console.WriteLine("This is abstract class");
//             }
//         }
//         class Derived:AbsClass{
//             public override void AbsMethod(){
//                 System.Console.WriteLine("Bye");
//             }
//         }
//     class Program{
//         static void Main(string[] args){
//             Derived d=new Derived();
//             d.NonAbsMethod();
//             d.AbsMethod();
//         }
//     }
// }