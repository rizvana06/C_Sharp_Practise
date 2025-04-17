using System;
using System.Collections;
class Sample{
    static void Main(){
    ArrayList a=new ArrayList();
    a.Add(90);
    a.Add("HI");
    a.Add("87.98");
    a.Add(true);
    foreach(object o in a){
        Console.WriteLine(o);
    }
}
}