using System;
using System.Collections.Generic;

public class Sample{
    static void Main(){
        /*LinkedList<int> l=new LinkedList<int>();
        l.AddLast(10);
         l.AddLast(20);
         l.AddLast(40);
         l.AddLast(50);
         Console.WriteLine(Search(l,20));
         /*IEnumerator<int> e1=l.GetEnumerator();
         while (e1.MoveNext()){
            Console.Write(e1.Current);
         }//
         
         foreach(int a in l){
            Console.Write(a+"->");
         }
    }
     static bool Search(LinkedList<int> list,int value){
        return list.Contains(value);
     }  */
  /*   Stack<int> stack=new Stack<int>();
     stack.Push(1);
   stack.Push(6);
   stack.Push(4);
   stack.Push(9);
   Console.WriteLine("Top element:"+stack.Peek());
   int poppedelement=stack.Pop();
   Console.WriteLine("popped elemnet is:"+poppedelement);
   Display(stack);
   Console.WriteLine("is empty:"+(stack.Count==0));
   stack.Clear();
   Console.WriteLine("Is stack empty after clear"+(stack.Count==0));
    }

    static void Display(Stack <int> stack){
      Console.WriteLine("stack elements:");
      foreach (int item in stack){
         Console.WriteLine(item);
      }*/
      Queue<int> stack=new Queue<int>();
     stack.Enqueue(1);
   stack.Enqueue(6);
   stack.Enqueue(4);
   stack.Enqueue(9);
   Console.WriteLine("Top element:"+stack.Peek());
   int poppedelement=stack.Dequeue();
   Console.WriteLine("popped elemnet is:"+poppedelement);
   Display(stack);
   Console.WriteLine("is empty:"+(stack.Count==0));
   stack.Clear();
   Console.WriteLine("Is stack empty after clear"+(stack.Count==0));
    }

    static void Display(Queue <int> stack){
      Console.WriteLine("stack elements:");
      foreach (int item in stack){
         Console.WriteLine(item);
      }
    }
}

    
