using System;
public delegate void Add(int x,int y);
class Delegates{
public void add(int a,int b){
    Console.WriteLine(a+b);
}
public void mul(int a,int b){
    Console.WriteLine(a*b);
}
public void sub(Add d){
   d(5,4);
}
public static void Main(){
    Delegates d1=new Delegates();

    Add a=d1.add;
   Add b=d1.mul;
    //Add r=d1.add;
    
    d1.sub(a);
    d1.sub(b);
   //a(5,6);
  // r=d.sub;
   // b(5,4);
    
}

}
