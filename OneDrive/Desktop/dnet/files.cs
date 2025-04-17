using System;
using System.IO;
class Files{
    static void Main()
    {
        try{
            string path="C:\\Users\\rizvana\\OneDrive\\Desktop\\Qis.txt";
            using (StreamWriter w1=new StreamWriter(path)){
            w1.WriteLine("hello");
        }
    }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
         Console.WriteLine("File creatd and text edited");

    }
}