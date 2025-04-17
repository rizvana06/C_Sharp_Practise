
using System;
class Exe1{
    static  int Display(int num,int n){
        if (num==0){
            throw new DivideByZeroException("num should not be divided  zero");
        }
         return num/n;
        
    }

public static void Main(){
    try{
       Console.WriteLine("enter 1st num:");
       int num=int.Parse(Console.ReadLine());
       Console.WriteLine("enter 2nd num:");
       int n=int.Parse(Console.ReadLine());
       Console.WriteLine("res:"+Display(num,n));
       
    }catch(Exception e){
        if (e is FormatException|| e is ArithematicException){
       Console.WriteLine("caught Exception");
    }else{
        throw;
    }
}

}
}
