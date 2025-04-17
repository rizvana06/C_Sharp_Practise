//unlike java, c# doesnot have throws keyword so, we use || symbol to handle multiple exceptions.
using System;
class Exe{
    static void Main(){
        try{
            Console.WriteLine("Enter a number:");
            int num=int.Parse(Console.ReadLine());
            int c=10/num;
            Console.WriteLine(c);
        }[System.Serializable]
        public class exeException : System.Execption
        {
            public exeException() { }
            public exeException(string message) : base(message) { }
            public exeException(string message, System.Exception inner) : base(message, inner) { }
            protected exeException(
                System.Runtime.Serialization.SerializationInfo info,
                System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }
        catch(Exception e){
          if (e is FormatException || e is DivideByZeroException){
               Console.WriteLine(e.Message);
            }
            throw;
           
        }
           finally{
            Console.WriteLine("Finally!");
           }
        }
    }

