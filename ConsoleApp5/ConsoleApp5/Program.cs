using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Q1: It allows you to define type-safe data structures, without declaring the data type. Helps increase performance.
 * Q2: List<string> listName = new List<string>();
 * Q3: two. Tvalue, Tkey
 * Q4: True
 * Q5: List.Add
 * Q6: remove, pop
 * Q7: You need to define the data type while using class or method. Usually the type is specified by the <T>.
 * Q8: True
 * Q9: True
 * Q10: False
*/
namespace ConsoleApp5
{
    internal class Program
    {
        //Q1
        class MyStack<T>
        {
            T[] stack;
            int top;
            int capacity;
            public int count() { return 100; }

            public T pop()

            {
                T RemovedElement;
                T temp = default(T);
                if (!(top <= 0))
                {
                    RemovedElement = stack[top];
                    top = top - 1;
                    return RemovedElement;
                }
                return temp;
            }

            public void push(T Element)

            {
                top = top + 1;
                stack[top] = Element;

            }
        }

        static void Main(string[] args)
        {
        }
     

    }
}
