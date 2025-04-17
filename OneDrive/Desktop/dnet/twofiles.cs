using System;
using System.IO;
class Riz{
    static void Main(){
        string path1="C:\\Users\\rizvana\\OneDrive\\Desktop\\Qis.txt";
        string path2="C:\\Users\\rizvana\\OneDrive\\Desktop\\riz.txt";
        using(StreamReader r1=new StreamReader(path1))
        using (StreamReader r2=new StreamReader(path2)){
            string line1,line2;
            while((line1=r1.ReadLine())!=null && (line2=r2.ReadLine())!=null){
                Console.WriteLine(line1);
                Console.WriteLine(line2);
            }
        }
    }
}