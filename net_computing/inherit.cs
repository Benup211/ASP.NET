// using System;

// namespace ConsoleApp{
    
//     public class Animal
//     {
//         string name;
//         int age;
        
//         public Animal(){}
//         public Animal(string n,int a)
//         {
//             this.name=n;
//             this.age=a;
//         }
//         public string Name
//         {
//             get{return name;}
//             set{name=value;}
//         }
//         public int Age
//         {
//             get{ return age;}
//             set{age=value;}
//         }
//         public void getName(){
//             Console.WriteLine("The name of animal is {0}",name);
//         }
//         public void getAge(){
//             Console.WriteLine("The age of animal is {0} years old",age);
//         }
//         public virtual void Speaks()
//         {
//             Console.WriteLine("The animal speaks");
//         }
//     }
//     public class Dog:Animal
//     {
//         public Dog(string n,int a):base(n,a)
//         {}
//         public override void Speaks()
//         {
//             Console.WriteLine("Speaks:Bhow Bhow");
//         }
//     }
//     class Program{
//         static void Main(string[] args)
//         {
//             Dog d1=new Dog("Shino",9);
//             d1.getName();
//             d1.getAge();
//             d1.Speaks();
//         }
//     }
// }