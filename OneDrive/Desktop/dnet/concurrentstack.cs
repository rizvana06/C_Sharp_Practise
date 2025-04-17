using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
class Temp{
    static void Main(){
        ConcurrentStack<int> c1=new ConcurrentStack<int>();
        Parallel.For(0,10,i=>
        {
            c1.Push(i);
            Console.WriteLine(i);
        });//insted of single element 'Parallel.for' is used to push multiple elements at a time.
    Console.WriteLine("Pop elements:");
    while (c1.TryPop(out int result)){
        Console.WriteLine(result);
    }
    }
}