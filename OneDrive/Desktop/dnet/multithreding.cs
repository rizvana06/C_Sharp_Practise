using System;
using System.Threading;
class Riz{
    static void M1(){
        for(int i=0;i<5;i++){
            if (i==3){
                Thread.Sleep(10000);
            }
            Console.WriteLine("Good Morning");
        }
    }
   /* static void M2(){
        for(int i=0;i<5;i++){
            Console.WriteLine("Good Afternoon");
        }
    static void M3(){
        for(int i=0;i<5;i++){
            Console.WriteLine("Good Night");
        }
    }*/
    static void Main(){
        Thread t1=new Thread(M1);
        t1.Start();
        t1.Join();
        Console.WriteLine("ThreadFinished");
        //M2();
       // M3();
    }
    
}