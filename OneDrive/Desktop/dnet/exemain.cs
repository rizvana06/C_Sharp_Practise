//error in user-Defines method handling in main method
using System;
class Exe1{
    public void Display(int num){//if this method is static no need for object
        if (num==0){
            throw new DivideByZeroException("num should not be zero");
        }
        int res=10/num;
        
   Console.WriteLine(res);
    }

public static void Main(){
    Exe1 n=new Exe1();
    try{
        n.Display(0);//no need for object reference just Display(num)
    }catch(DivideByZeroException e){
        Console.WriteLine(e.Message);
    }
}

}
