using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class Stask_T
    {
        public void StaskCollection()
        {
            Stack<string>stack = new Stack<string>();
            stack.Push("Bill");
            stack.Push("John");
            stack.Push("Jack");

            for (int i = 0; i < stack.Count; i++)
            {
                Console.WriteLine(stack.Pop());
            }

           
        }
    }
}
