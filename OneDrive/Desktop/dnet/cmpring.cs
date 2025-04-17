using System;
class Str2{
string s1="hai";
string s2="hai";
string s3=new string("hai".ToCharArray());
string s4=new string("hai".ToCharArray());
Console.WriteLine(s1.Equals(s2));
Console.WriteLine(s1.CompareTo(s2));
Console.WriteLine(object.ReferenceEquals(s3,s4));
}
}
