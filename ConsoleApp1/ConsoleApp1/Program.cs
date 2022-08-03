using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Q1: string, decimal, int, string, decimal, long, decimal, float, long, string, int
 * Q2: value type: directly holds the value, stored in stack memory, not collected by garbage collector, cannot accept null value.
 * Q2: refernce type: holds memory address or reference for value, stored in heap, collecte by garbage collector, accepts null value.
 * Q2: boxing: convert value type to reference type ; unboxing: convert reference type to valur type.
 * Q3: managed resource: resources that can be freed by garbage collector.
 * Q3: unmanaged resource: resourced that cannot be freed by garbage collector (need destructor).
 * Q4: The garbage collector manages the allocation and release of memory for an application.
 */

/*
 * Control Flow
 * Q1: WE get an exception error. DividebyZero exception.
 * Q2: We get infinity as the answer.
 * Q3: You get an incorrect negative number.
 * Q4: y++ is post increment, which happens after assignment, whereas ++y is pre increment, which happens before assignment.
 * Q5: break helps exit the current loop, continue helps terminate the current iteration, and moves to the next one, and 
 *     return helps return a value from the function.
 * Q6: Initialization (required), Condition(required), Iterator
 * Q7: '=' is an assignment operator, '==' checks the equality of the two operands.
 * Q8: Yes
 * Q9: It replaces the default keyword to handle any int value that doesnt match with any expression.
 * Q10: IEnumerable Interface
 */


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            //Q1
            /*
            string c, a, n;
            Console.WriteLine("Enter color");
            c = Console.ReadLine();
            Console.WriteLine("Enter Astology Sign");
            a = Console.ReadLine();
            Console.WriteLine("Enter Number");
            n = Console.ReadLine();
            Console.WriteLine("Hacker Name: ");
            Console.WriteLine(c + a + n);
            int x = sizeof(char);
            

            //Q2
            Console.WriteLine("Sbyte    : {0}", sizeof(sbyte));
            Console.WriteLine("Byte     : {0}", sizeof(byte));
            Console.WriteLine("Short   : {0}", sizeof(short));
            Console.WriteLine("Ushort   : {0}", sizeof(ushort));
            Console.WriteLine("int      : {0}", sizeof(int));
            Console.WriteLine("uint      : {0}", sizeof(uint));
            Console.WriteLine("long     : {0}", sizeof(long));
            Console.WriteLine("ulong     : {0}", sizeof(ulong));
            Console.WriteLine("float    : {0}", sizeof(float));
            Console.WriteLine("double   : {0}", sizeof(double));
            Console.WriteLine("decimal   : {0}", sizeof(decimal));
        
            //Q3

            Console.WriteLine("Input: ");
            string x;
            x = Console.ReadLine();
            int num = Convert.ToInt32(x);

            Console.WriteLine("Output: ");
            Console.WriteLine(num + " Centuries");
            Console.WriteLine(num * 100 + " Years");
            Console.WriteLine(num * 36500 + " Days");
            Console.WriteLine(num * 876000 + " Hours");
            Console.WriteLine(num * 52560000 + " Seconds");
            

            //Loops

            //Q1

            for(int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    if (i % 5 == 0)
                        Console.WriteLine("FizzBuzz");
                    else
                        Console.WriteLine("Fizz");
                }
                else if(i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
         
            //Q2
            //Infinite Loop. 

            int max = 500;
            for (byte i = 0; i < max; i++)
            {
                Console.WriteLine(i);
            }
           
            //Q3
            int correctNumber = new Random().Next(3) + 1;
            Console.WriteLine("Enter your answer (1-3): ");
            string y = Console.ReadLine();
            int guessedNumber = Convert.ToInt32(y);

            if (guessedNumber == correctNumber)
                Console.WriteLine("Correct Answer");
            else if (guessedNumber > correctNumber && guessedNumber < 4)
                Console.WriteLine("Guessed number is higher than correct number");
            else if (guessedNumber < correctNumber && guessedNumber > 0)
                Console.WriteLine("Guessed Number is lower than correct number");
            else Console.WriteLine("Number out of bounds");
            

            //Q4

            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5-i ; j++)
                {
                    Console.Write(" ");
                }
                for (int z = 1; z < i; z++)
                {
                    Console.Write("*");
                }
                for (int z = i; z > 0; z--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

     
            //Q6

            DateTime x = DateTime.Now;

            Console.WriteLine(x.ToString());
        
            int presentHr = x.Hour;

            if (presentHr >= 6 && presentHr < 12)
            {
                Console.WriteLine("Good morning!");
            }

            ;
            if (presentHr >= 12 && presentHr < 16)
            {
                Console.WriteLine("Good Afternoon!");
            }

            ;
            if (presentHr >= 16 && presentHr < 20)
            {
                Console.WriteLine("Good Evening!");
            }

            ;
            if (presentHr >= 20 || presentHr < 6)
            {
                Console.WriteLine("Good Night!");
            }
            

            //Q7

            int incr = 1;

            for(int i = 0; i < 4; i = i + 1)
            {
                for(int j = 0; j < 25; j = j + incr)
                {
                    if(j == 24)
                        Console.Write(j);
                    else
                        Console.Write(j + ", ");
                }
                incr++;
                Console.WriteLine();
            }

            */

        }
    }
}
