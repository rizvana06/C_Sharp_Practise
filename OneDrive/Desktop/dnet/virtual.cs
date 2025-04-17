using System;
class sealed Sealed{
public int a=45;
public virtual void Add(){
a=344;
Console.WriteLine(a);
Console.WriteLine("HELLO");
}
}
class Q5{
Sealed s=new Sealed();
public override void Add(){
Console.WriteLine("hi");
}
static void Main(String[] args){
Q5 q=new Q5();
q.Add();
}
}

