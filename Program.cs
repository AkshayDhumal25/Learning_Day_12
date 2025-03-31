﻿////Diamond Problem
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
using System;
namespace logicals
{
    class Program
    {
        public static void Main(string[] args)
        {
            string str = "abbaa";
            if (isPalindrome(str))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
        public static bool isPalindrome(string str)
        {
            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}