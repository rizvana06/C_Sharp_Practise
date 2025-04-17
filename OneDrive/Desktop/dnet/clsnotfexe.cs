using System;
class Exec{
    public static void Main(){
        try{
            Console.WriteLine("Enter file name:");
            string filename=Console.ReadLine();
            Type t=Type.GetType(filename);
            if(t==null){
                throw new TypeLoadException("Class not preseent");
            }
            Console.WriteLine("class Found");
        }catch(TypeLoadException e){
            Console.WriteLine(e.Message);
        }
    }
}