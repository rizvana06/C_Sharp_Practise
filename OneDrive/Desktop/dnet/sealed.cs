using System;
public sealed class Sample{

    public int Value{get;set;}
    public void Display(){
        Console.WriteLine(Value);
    }
}
public class SampleUser{
    public void UseSample(){
        Sample s=new Sample();
        s.Value=100;
        s.Display();
    }
}
class Program{
    static void Main(string[] args){
        SampleUser u=new SampleUser();
        u.UseSample();
    }
}
