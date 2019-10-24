using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class Stack
    {
       private string[] Buffer;
       private int Top;
       public Stack(int size)
       {
           
           this.Buffer = new string[size];
           this.Top = -1;
       }
       public Stack(int size)
       {

           Buffer = new string[1000];
           Top = -1;
       }
       public void Push(string value)
        {
            Buffer[Top +1] = value;
            Top++;
            
        }
       public int Pop()
       {
           string value = Buffer[Top];
              Top--;
           return 0;
       }
       public int Peek()
       {
           return Buffer[Top];
       }
       public int Count()
       {
           return Top + 1;
       }
       public void Clear()
       {
           Top = -1;
       }
    }
}
