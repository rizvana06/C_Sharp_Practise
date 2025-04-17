using System;
using System.IO;
class CopyFiles{
    static void Main(){
        string source="C:\\Users\\rizvana\\OneDrive\\Desktop\\Qis.txt";
        string dest="C:\\Users\\rizvana\\OneDrive\\Desktop\\har.txt";
        //File.Copy(source,dest);
        File.Move(source,dest);
        Console.WriteLine("Sucess");
    }
}