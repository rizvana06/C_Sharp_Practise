using System;//base keyword
public class Sample{
    public int a=10;
    public Sample(){
        Console.WriteLine("HIII");
    }
    public void Show(){
        Console.WriteLine("Parent class Method");
    }
}
public class Exec:Sample{
    public Exec():base(){
        Console.WriteLine("this is child ");
    }
    public void Display(){
        base.Show();
        Console.WriteLine(base.a);
        Console.WriteLine("Child method");
    }
    static void Main(){
        Exec e=new Exec();
        e.Display();
    }
}