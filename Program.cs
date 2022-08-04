using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Arrays
 * Q1: StringBuilder is present in System.Text namespace and provides better performance for heavy string manipulations,
 *     whereas String is present in System namespace and uses more memory.
 * Q2: Array class
 * Q3: Use Array.sort method
 * Q4: Length properrty.
 * Q5: Yes
 * Q6: Clone method returns a new array object of the same length containing elements if the existing array.
 *     CopyTo copies the element to an exisiting array.
*/

namespace ConsoleApp3
{
    internal class Program
    {
        public static object Length { get; private set; }

        static void Main(string[] args)
        {
            //Q1
            /*
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arr2 = new int[arr1.Length];
            for(int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }
            Console.WriteLine("Array 1: ");
            foreach (int num in arr1)
                Console.Write(num + ", ");
            Console.WriteLine();
            Console.WriteLine("Array 2: ");
            foreach (int num in arr2)
                Console.Write(num + ", ");
            

            //Q2

            string option;
            List<string> items = new List<string>(); 

            Console.WriteLine("Enter command (+ item, - item, or = to clear)): ");
            option = Console.ReadLine();

            while(option.StartsWith("+") || option.StartsWith("-")) 
            {
                if (option.StartsWith("+"))
                    items.Add(option.Substring(2));
                else if(option.StartsWith("-"))
                    items.Remove(option.Substring(2));
                Console.Write("Current list: ");
                foreach (string item in items)
                    Console.Write(item + ", ");
                Console.WriteLine();
                Console.WriteLine("Enter command (+ item, - item, or = to clear)): ");
                option = Console.ReadLine();
            }

            items.Clear();
            Console.Write("Current list: ");
            foreach (string item in items)
                Console.Write(item + ", ");
            Console.WriteLine();
            

            //Q3

            int startNum, endNum, count;
            List<int> arr = new List<int>(); 
            Console.WriteLine("Enter starting number: ");
            startNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ending number: ");
            endNum = Convert.ToInt32(Console.ReadLine());

            for(int i = startNum; i <= endNum; i++)
            {
                count = 0;
                for (int j = 2; j <= i / 2; j++){
                    if(i % j == 0)
                    {
                        count++;                    
                    }
                }

                if (count == 0)
                    arr.Add(i);
        
            }

            Console.WriteLine("Prime Numbers: ");
            foreach(int i in arr)
                Console.Write(i + " ");
            Console.WriteLine();
            

            //Q5

            int[] arr = new[] { 1, 1, 2, 5, 5, 2, 2, 2, 6, 3, 3, 3, 3, 6, 3 };
            int longestNum = arr[0];
            int longestCount = 1;
            int count = 1;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i+1] != arr[i])
                {
                    count = 0;
                }
                count++;
                if (count > longestCount)
                {
                    longestCount = count;
                    longestNum = arr[i];
                }
            }

            for(int i = 0; i < longestCount; i++)
            {
                Console.Write(longestNum + " ");
            }
            Console.WriteLine();

            

            //Q6

            int[] arr = new[] { 1, 1, 2, 5, 5, 2, 2, 2, 6, 3, 3, 3, 3, 6, 3, 2, 2 };
            int longestNum = arr[0];
            int longestCount = 1;
            int count = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = 1; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                        count++;
                }
                if(count > longestCount)
                {
                    longestNum = arr[i];
                }

            }

            Console.WriteLine("Most frequently occuring number: " + longestNum);

            

            //Strings

            //Q1

            string sample;
            Console.WriteLine("Enter string: ");
            sample = Console.ReadLine();

            //Method 1
            char[] charArray = sample.ToCharArray();
            Array.Reverse(charArray);
            sample = new string(charArray);
            Console.WriteLine("Reversed: " + sample);

            //Method 2
            Console.WriteLine("Reversed: ");
            for (int i = sample.Length - 1; i >= 0; i--)
                Console.Write(sample[i]);
            Console.WriteLine();

            

            //Q4

            string url;
            string temp = string.Empty;
            string proto = string.Empty;
            string server = string.Empty;
            string resource = string.Empty;
            int check = 0;
            Console.WriteLine("Enter URL: ");
            url = Console.ReadLine();
            for(int i = 0; i < url.Length; i++)
            {
                if(url[i] == ':')
                {
                    proto = url.Substring(0, i);
                    server = url.Substring(i + 3);
                    for(int j = 0; j < server.Length; j++)
                    {
                        if (server[j] == '/')
                        {
                            server = server.Substring(0, j);
                            resource = server.Substring(j + 1);
                        }
                    }
                    check++;
                }
            }

            if(check == 0)
            {
                server = url.Substring(0);
                for (int i = 0; i < url.Length; i++)
                {
                    if (url[i] == '/')
                    {
                        server = url.Substring(0, i);
                        resource = url.Substring(i + 1);
                    }
                }
            }

            Console.WriteLine("Protocol: " + proto);
            Console.WriteLine("Server: " + server);
            Console.WriteLine("Resource: " + resource);
            
            */
        }
    }
}
