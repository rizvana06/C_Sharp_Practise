using System;
class Exe{//lambda functions are only applicable for anonymous methods.
    public delegate void show(string message);
    public delegate int display(int x,int y);//anonymous method
    static void Main(){
       show s1=x=>Console.WriteLine(x);//lambda for printing message
       // display d1=delegate(int x,int y){
          //  Console.WriteLine(x+y);
        //};//anonymous method for adding 2 numbers
        display d1=(a,b)=>a+b;//lambda for adding 2 numbers
        int result=d1(10,30);
        Console.WriteLine(result);
       s1("HEllowww");
       // d1(10,20);
    }
}
    
