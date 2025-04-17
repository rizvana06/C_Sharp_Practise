using System;
class Jaag{
static void Main(){
int[][] a=new int[3][];
int a[0]=new int[]{1,2,3,4};
int a[1]=new int[]{5,6,7,8};
for(int i=0;i<a.Length;i++){
Console.Write("element {0}:",i);
for(int j=0;i<a[i].Length;j++){
Console.Write(a[i][j]+" ");
}
Console.WriteLine();
}
}
}