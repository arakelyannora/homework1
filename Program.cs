using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication132
{
    class Program
    {
        static int[] newArray()
        {
            Console.Write("Please insert count of Array = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }

        static bool IsPrime(int number)
        {
            if (number == 0 || number == 1)
                return false;
            bool prime = true;
            for (int j = 2; j <= number / 2; j++)
            {
                if (number % j == 0)
                    prime = false;
            }
            return prime;
        }
        static void PrimeToZero(int[] arr)
        {          
            for (int i = 0; i < arr.Length; i++)          
             if (IsPrime(arr[i])) arr[i] = 0;      
        }
        static int MaxMember(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }
        static int MinMember(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
        }
        static void printArray(int []arr)
        {
            Console.WriteLine("array");
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine($"arr[{i}] = {arr[i]}");
              
          }
        static void Main(string[] args)
        {
           
            int[] arr = newArray();
           
            int min = MinMember(arr);
            int max = MaxMember(arr);
            Console.WriteLine($"Min + Max = {min + max}");
            PrimeToZero(arr);
            printArray(arr);
            
        }
    }
}
