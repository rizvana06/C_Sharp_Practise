using System;
class Practise{
    static void Main(){
        Display();
    }
    public static void Display(){
        int[] arr=new int[]{2,6,1,4,8};
         string riz=string.Concat(arr);
            string riz2=string.Join(",",arr);
            string str="riz,vana,shaik,csharp";
            string[] res=str.Split(',');
            Array.ForEach (res, x=>Console.WriteLine(x));

         Console.WriteLine(riz);
         Console.WriteLine(riz2);

    
    }
}