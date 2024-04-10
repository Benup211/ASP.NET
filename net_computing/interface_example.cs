// using System;

// namespace ConsoleApp
// {
//     interface IShapeMethod
//     {
//         void Area();
//         void Perimeter();
//     }
//     public class Shape
//     {
//         string color="";
//         public Shape(){}
//         public Shape(string color)
//         {
//             this.color=color;
//         }
//         public string Color{
//             get{return color;}
//             set{color=value;}
//         }
//         public void getColor(){
//             System.Console.WriteLine("Shape color is:{0}",color);
//         }

//     }
//     public class Circle:Shape,IShapeMethod{
//         double radius=0.0;
//         public Circle(string color,double radius):base(color){
//             this.radius=radius;
//         }
//         public void Area(){
//             System.Console.WriteLine("Area is:{0}",3.14*radius*radius);
//         }
//         public void Perimeter(){
//             System.Console.WriteLine("Perimeter is:{0}",2*3.14*radius);
//         }
//     }
//     class Program{
//         static void Main(string[] args)
//         {
//             Circle c1=new Circle("Red",5);
//             c1.Area();
//             c1.Perimeter();
//             c1.getColor();
//         }
//     }
// }