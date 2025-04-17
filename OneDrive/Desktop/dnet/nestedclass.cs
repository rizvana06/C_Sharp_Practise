using System;
sealed class Sample{//can be sealed
    public void Add(){//cannot be sealed
        Console.WriteLine("outer class,Sample1");
    }
    public sealed class Sample2{//can be sealed
       public  void Show(){//cannot be sealed
            Console.WriteLine("Inner class");
        }
    }
}
public class Riz{
    static void Main(){
    Sample.Sample2 s=new Sample.Sample2();
     s.Show();
     Sample r=new Sample();
     r.Add();
    }
}