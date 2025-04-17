using System;
using Riz;
namespace Riz{
    public partial class Person{
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public void Display(){
            Console.WriteLine("Full name:"+FirstName+" "+LastName);
        }
    }
    public partial class Person{
        public int Age{get;set;}
        public void Displayage(){
            Console.WriteLine("Age:"+Age);
        }
    }
}
class Program{
    static void Main(string[] args){
        Person p=new Person{
            FirstName="shaik",
            LastName="Rizvana",
            Age=20
        };
        p.Display();
        p.Displayage();
    }
}

