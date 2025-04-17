using System;
class Riz{
static void Main(){
int[] a={5,8,4,9,5};
Console.WriteLine("originsl Array:"+string.Join(",",a));
Array.Clear(a,1,3); 
Console.WriteLine("After clear:"+string.Join(",",a));
int[] copyArray=new int[3];
Array.Copy(a,copyArray,3);
Console.WriteLine("copy Array:"+string.Join(",",copyArray));
int copyto[]=new int[7];
a.CopyTo(copyto,0)
Console.WriteLine("copied array is "+string.Join(",",copyto));
Console.WriteLine(Array.IndexOf(a,5));
Console.WriteLine(Array.Sort(a));
Array.Resize(ref numbers,10);
Console.WriteLine(string.Join(",",a);
Array.Reverse(a);
Console.WriteLine("array is "+string.Join(",",a));
}
}