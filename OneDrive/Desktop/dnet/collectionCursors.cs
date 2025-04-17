using System;
using System.Collections.Generic;
using System.Linq;
class Sample{
    //iterating through object s done using 3 ways 1.foreach 2.Ienumerator 3.Linq
    static void Main(){
        List<string> s=new List<string>{"red","blue","green"};
        /* 1 .foreach (string i in s){
            Console.WriteLine(i);
        }*/
      /* 2. IEnumerator<string> e=s.GetEnumerator();
      while(e.MoveNext()){//iEnumerator is a class and GetEnumertaor ,Movenext,Current are methods in it.
        Console.WriteLine(e.Current);
      }  */
      var v=s.Where(n=>n.StartsWith("r"));
      foreach(var x in v){//3. Linq.
        Console.WriteLine(x);
      }
    }
}