using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    /*
     * Q1: 
     *  - Private: objects are accessible only inside the class/struct.
     *  - Protected: objects are accessible inside the class and all derived classes.
     *  - Public: objects are accessbile from anywhere in the program.
     *  - Private-Protected: access members inside the containing class or in a class that derives from a containing class, but 
     *      only in the same project.
     *  - Internal: objects accessible only to classes defined within the current project.
     *  - Protected-Internal: accessible to classes defined within the current project and other derived classes.
     * Q2: Static members can only be accessed by static functions, const type members are declared as constant, and readonly 
     *      can only be assigned once after decleration.
     * Q3: It is a special method that initializes a new object of that type.
     * Q4: It indicates that other parts of the class or struct can be defined in the namespace. This is helpful when working on a big 
     *      project to split files over classes.
     * Q5: Tuple is a data structure that contains a sequence of elements of different data types.
     * Q6: It defines a reference type that provides builtin functionality for data encapsulation.
     * Q7: Overloading: when two or more methods in the same class have same name but different parameters.
     *      Overriding: when two methods have same name and same parameters, but one method is in the parent class, other in child class.
     * Q8: Field: variable declared directly in a class.
     *      Property: member that provides a flexible mechanism to read, write, or compute the value of a private field.
     * Q9: -use parameter arrays -use optionalatrribute -default parameter -method overloading.
     * Q10: Interface: it only allows you to define functionality, not implement it. 
     *      Abtract: helps create functionality that subclasses can implement or override.
     * 
     * Q11: Public
     * Q12: True
     * Q13: True
     * Q14: False
     * Q15: False
     * Q16: False
     * Q17: True
     * Q18: True
     * Q19: False
     * Q20: False
     * Q21: True
     * Q22: False (C#)
     * Q23: True
    */
    internal class Program
    {
        //Q1
        /*
        public static int[] GenerateNumbers()
        {
            int[] num = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            return num;
        }

        public static int[] Reverse(int[] numbers)
        {
            int[] result = new int[numbers.Length];
            int i, j;
            for(i = 0; i < numbers.Length/2 ; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = temp;
            }
            return numbers;
        }

        public static void PrintNumbers(int[] numbers)
        {
            foreach (int number in numbers)
                Console.Write(number + " ");
        }
        static void Main(string[] args)
        {

            int[] numbers = GenerateNumbers();
            Reverse(numbers);
            PrintNumbers(numbers);
        }
        

        //Q2
        public static int Fibonacci(int x)
        {
            int result, a = 1, b = 1, c = 0;
            if (x == 1 || x == 2)
            {
                result = 1;
            }
            else
            {
                for (int i = 3; i <= x; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                result = c;
            }
            return result;
        }
        static void Main(string[] args)
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
        }

        

        //Q3
        public abstract class Person
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }

            public Person(){}

        }

        public class Instructor : Person
        {
            public Instructor(){}
        }

        public class Student : Person
        {
            public Student(){}
        }

        public class Course : Student
        {
            public Course(){}
        }

        public class Department : Instructor
        {
            public Department(){}
        }
        

        //Q4
        public abstract class Color
        {
            private int red, green, blue, alpha;
            public Color(int r, int g, int b, int a)
            {
                red = r;
                green = g;
                blue = b;
                alpha = a;
            }

            public Color(int r, int g, int b)
            {
                red = r;
                green = g;
                blue = b;
                alpha = 255;
            }

            public int setColor
            {
                get; set;
            }

            public int getGrayscale()
            {
                return (red + green + blue) / 3;
            }
        }

        public class Ball : Color
        {
            private int size, Color, numThrown;

            public Ball()
            {
                size = 1;
                Color = Color;
                numThrown = 0;
            }

            public void Pop()
            {
                size = 0;
            }

            public void Throw()
            {
                if (size != 0)
                    numThrown++;
            }

            public int timesThrown()
            {
                return numThrown;
            }

        }

        */

    }
