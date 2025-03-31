////Diamond Problem
//using System;
//namespace diamondProblem
//{
//    interface IA
//    {
//        public void Print()
//        {
//            Console.WriteLine("IA");
//        }
//    }
//    interface IB : IA { }
//    interface IC : IA { }
//    class D : IB, IC
//    {
//        public void Print()
//        {
//            Console.WriteLine("Class D"); ;
//        }
//    }
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            D d = new D();
//            d.Print();
//        }
//    }
//}


// Reverse an integer
//using System;
//namespace reverseInteger
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int n = 123;
//            int reversed = 0;
//            while(n > 0)
//            {
//                int reminder = n % 10;
//                reversed = reminder + reversed * 10;
//                n /= 10;
//            }
//            Console.WriteLine(reversed);
//        }

//    }
//}

// Generics 
//using System;
//namespace generics
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the 1st Element :");
//            var ele1 = Console.ReadLine();
//            Console.WriteLine("Enter the 2nd Element");
//            var ele2 = Console.ReadLine();
//            swap(ele1, ele2);
//        }
//        public static void swap<T>(T ele1, T ele2)
//        {
//            var temp = ele1;
//            ele1 = ele2;
//            ele2 = temp;
//            Console.WriteLine($"A: {ele1} B: {ele2}");
//        }
//    }
//}


// 1. WAP to find Second largest element in an array : arr[] = [12, 35, 1, 10, 34, 1, 35], without
// sorting, without using any built-in methods and without deleting duplicate elements. What will be
// the time complexity?
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int[] array = { 12, 35, 1, 10, 34, 1, 35 };
//            int secondLarge = 0;
//            int large = 0;
//            for (int i = 0; i < array.Length; i++)
//            {
//                if (array[i] > large)
//                {
//                    secondLarge = large;
//                    large = array[i];
//                }
//                if (array[i] < large && array[i] > secondLarge)
//                {
//                    secondLarge = array[i];
//                }
//            }
//            Console.WriteLine($" Second Largest Element from array : {secondLarge}");
//        }
//    }
//}


// 2. Swap Values without using any variable a=10, b=12.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int a = 10;
//            int b = 12;

//            a = a + b;
//            b = a - b;
//            a = a - b;

//            Console.WriteLine($"A : {a} B : {b}");
//        }
//    }
//}


// 3. Logic for anagram program with its time complexity. (for large strings).
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            string str1 = "silent";
//            string str2 = "listen";

//            if (isAnagram(str1, str2))
//            {
//                Console.WriteLine("Anagram");
//            }
//            else
//            {
//                Console.WriteLine("Not Anagram");
//            }
//        }
//        public static bool isAnagram(string str1, string str2)
//        {
//            if (str1.Length != str2.Length)
//            {
//                return false;
//            }
//            int[] array = new int[256];
//            for (int i = 0; i < str1.Length; i++)
//            {
//                array[str1[i]]++;
//                array[str2[i]]--;
//            }
//            foreach (int i in array)
//            {
//                if (i != 0)
//                {
//                    return false;
//                }
//            }
//            return true;
//        }
//    }
//}

// 4. Find the reverse of the string.
//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            string str = "Akshay";
//            var rev = str.Reverse();
//            Console.WriteLine(new string(rev.ToArray()));
//        }
//    }
//}

//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            string str = "Akshay";
//            var rev = str.Reverse().ToArray();
//            Console.WriteLine(rev);
//        }
//    }
//}


// 5. WAP to find missing elements from the array?
//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace logicals{
//    class Program{
//        public static void Main(string[] args){
//            int[] array = {1,2,3,5,6,8,7,10};
//            int min = array.Min();
//            int max = array.Max();
//            var list =  new List<int>(array);
//            for(int i = min;i<=max;i++){
//                if( ! list.Contains(i)){
//                    Console.WriteLine(i);
//                }
//            }
//        }
//    }
//}

// 6. WAP to find the given string is Palindrome or not.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            string str = "abbaa";
//            if (isPalindrome(str))
//            {
//                Console.WriteLine("Palindrome");
//            }
//            else
//            {
//                Console.WriteLine("Not Palindrome");
//            }
//        }
//        public static bool isPalindrome(string str)
//        {
//            int left = 0;
//            int right = str.Length - 1;

//            while (left < right)
//            {
//                if (str[left] != str[right])
//                {
//                    return false;
//                }
//                left++;
//                right--;
//            }
//            return true;
//        }
//    }
//}

// 7. WAP to print Fibonacci series with recursion.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number to get the fibonacci series : ");
//            int n = Convert.ToInt32(Console.ReadLine());
//            for (int i = 0; i < n; i++)
//            {
//                Console.Write(fibo(i) + " ");
//            }
//            Console.WriteLine();
//        }
//        public static int fibo(int n)
//        {
//            if (n <= 1) return n;

//            return fibo(n - 1) + fibo(n - 2);
//        }
//    }
//}


// 8. WAP to print Fibonacci series without recursion.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the element to get the fibonacci series : ");
//            int n = Convert.ToInt32(Console.ReadLine());
//            int a = 0;
//            int b = 1;
//            int c = 0;


//if (n >= 1)
//{
//    Console.Write(a + " "); // Print the first Fibonacci number (0)
//}
//if (n >= 2)
//{
//    Console.Write(b + " "); // Print the second Fibonacci number (1)
//}
//for (int i = 2; i < n; i++)
//{
//    c = a + b;
//    Console.Write(c + " ");

//                a = b;
//                b = c;
//            }
//        }
//    }
//}


// 10. Code to find even numbers in a list
//using System;
//using System.Collections.Generic;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//            foreach (var i in list)
//            {
//                if (i % 2 == 0)
//                {
//                    Console.WriteLine(i);
//                }
//            }
//        }
//    }
//}


// 11. Find prime numbers from 1 ....n
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number to get the prime numbers : ");
//            int n = Convert.ToInt32(Console.ReadLine());
//            for (int i = 3; i < n; i++)
//            {
//                if (isPrime(i))
//                {
//                    Console.WriteLine(i);
//                }
//            }
//        }
//        public static bool isPrime(int n)
//        {
//            if (n <= 1) return false;
//            if (n == 2) return true;
//            if (n % 2 == 0) return false;

//            for (int i = 3; i * i < n; i += 2)
//            {
//                if (n % i == 0)
//                {
//                    return false;
//                }
//            }
//            return true;
//        }
//    }
//}

// ]12. WAP for getting a square root of a given number.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] str)
//        {
//            Console.WriteLine("Enter the number to get the sqrt : ");
//            int n = Convert.ToInt32(Console.ReadLine());
//            var res = Math.Sqrt(n);
//            Console.WriteLine(res);
//        }
//    }
//}

// 13. WAP with 2 different logic, to find all duplicate numbers in an array.
// 2nd approach 
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int[] array = { 1, 2, 1, 1, 3, 4, 4, 5, 6, 7, 8, 9 };
//            for (int i = 0; i < array.Length; i++)
//            {
//                for (int j = i + 1; j < array.Length; j++)
//                {
//                    if (array[i] == array[j])
//                    {
//                        Console.WriteLine(array[i] + " ");
//                    }
//                }
//            }
//        }
//    }
//}

// 19. count lowercase and uppercase
// input = &quot;Hello world!&quot;
// output = uppercase = 1, lowercase = 9
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            string str = "Hello World";
//            int uppercase = 0;
//            int lowercase = 0;
//            foreach (char i in str)
//            {
//                if (char.IsUpper(i))
//                {
//                    uppercase++;
//                }
//                else
//                {
//                    lowercase++;
//                }
//            }
//            Console.WriteLine($"Uppercase Count : {uppercase} & Lowercase Count : {lowercase}");
//        }
//    }
//}

// 14. [80, 60, 10, 50, 30, 100, 0, 50]
// Find pairs whose sum = 100;
// Logic for above problem?
// What will be the complexity for it?
// Any better solution for the above problem
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int[] array = { 80, 60, 10, 50, 30, 100, 0, 50 };
//            int targetSum = 100;
//            for (int i = 0; i < array.Length; i++)
//            {
//                for (int j = i + 1; j < array.Length; j++)
//                {
//                    if (array[i] + array[j] == targetSum)
//                    {
//                        Console.WriteLine(array[i] + " : " + array[j]);
//                    }
//                }
//            }
//        }
//    }
//}

//lambda function
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Func<int, int> square = x => x * x;
//            Console.WriteLine(square(5));
//        }
//    }
//}


//Encapsulation
//using System;
//namespace encapsulation
//{
//    class rectangleArea
//    {
//        public double length;
//        public double width;

//        public double getArea()
//        {
//            return length * width;
//        }

//        public void print()
//        {
//            Console.WriteLine($"Length : {length} and Width : {width}");
//            Console.WriteLine("Area : " + getArea());
//        }
//    }
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            rectangleArea r = new rectangleArea();
//            r.length = 9.0;
//            r.width = 9.0;
//            r.print();
//        }
//    }
//}


//Abstraction
//using System;
//namespace abstraction
//{
//    abstract class Person
//    {
//        public abstract void Print();
//    }
//    class Name : Person
//    {
//        public override void Print()
//        {
//            Console.WriteLine("Hello");
//        }
//    }
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Name n = new Name();
//            n.Print();
//        }
//    }
//}


// Input: arr[] = [1, 2, 0, 4, 3, 0, 5, 0]
// Output: arr[] = [1, 2, 4, 3, 5, 0, 0, 0]
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int[] array = { 1, 2, 0, 4, 3, 0, 5, 0 };
//            int left = 0;
//            int right = array.Length - 1;
//            while (left < right)
//            {
//                if (array[left] == 0 && array[right] != 0)
//                {
//                    int temp = array[left];
//                    array[left] = array[right];
//                    array[right] = temp;
//                    left++;
//                    right--;
//                }
//                if (array[left] != 0)
//                {
//                    left++;
//                }
//                if (array[right] == 0)
//                {
//                    right--;
//                }
//            }
//            foreach (var i in array)
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }
//}

// Fibonacci series
using System;
namespace logicals
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;
            int c = 0;
            Console.Write($"{a} {b} ");
            for (int i = 3; i <= n; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }
    }
}
