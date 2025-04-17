using System;
class RizException:Exception{
    public RizException(string message):base(message){

    }
}//user defined exception
class Exe3{
    public void Agecheck(int age){
        if (age <18){
            throw new RizException("age is not valid");
        }else{
        Console.WriteLine("Eligible");
    }
    }
    public static void Main(){
        try{
            Console.WriteLine("Enter age:");
            int age=int.Parse(Console.ReadLine());
            Exe3 e3=new Exe3();
            e3.Agecheck(age);
        }catch(RizException e){
            Console.WriteLine(e.Message);
        }
    }
}