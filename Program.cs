﻿using System;
using System.Xml;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {

            /* Console.WriteLine("Enter a  number n:");
            // int n = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter a  number:n1");
            // int n1 = Convert.ToInt32(Console.ReadLine()); */
            //Console.WriteLine("Enter a  String:");
            // String s1 = Console.ReadLine();
            //Console.WriteLine("Enter a  position you want to remove:n1");
            //int n1 = Convert.ToInt32(Console.ReadLine());

            //* no proper spacing 
            // too many extra lines
            // int a = method1(n, n1);
            // Console.WriteLine(a);
            // bool b = method2(n, n1);
            // Console.WriteLine(b);
            // Console.WriteLine(Method3(s1));
            // Console.WriteLine(Method4(s1, n1));
            // Method5(s1);
            // Console.WriteLine(Method6(s1));
            // Console.WriteLine(Method7(s1));
            //Console.WriteLine(Method8(s1));
            //bool M9 = Method9(s1);
            //Console.WriteLine(M9);


            Console.WriteLine("enter three int values 4 Question # 10")
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            bool M10 = Method10(x, y, z);
            Console.WriteLine(M10);

        }


        public static Boolean Method10(int x, int y, int z)
        {
            if ((x >= 20 && x <= 50) || (y >= 20 && y <= 50) || (z >= 20 && z <= 50))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static Boolean Method9(String s1)
        {


            if ((s1.StartsWith("C#")) || (s1.StartsWith("C# Sharp")))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static String Method8(String s1)
        {
            if (s1.Length > 3)
            {
                String s2 = s1.Substring(0, 3);
                return String.Concat(s2 + s1 + s2);
            }
            else
            {
                return String.Concat(s1 + " " + s1 + " " + s1);
            }
        }

        public static String Method7(String s1)
        {
            String s2 = s1.Substring(s1.Length - 1);
            return String.Concat(s2 + s1 + s2);
        }

        public static String Method6(String s1)
        {
            if (s1.Length > 2)
            {
                String s2 = String.Concat(" ", s1, " ", s1, " ", s1, " ", s1, " ");
                return s2;
            }
            else
            {
                return s1;
            }

        }

        public static void Method5(String s1)
        {
            int len = s1.Length;
            Console.WriteLine(s1[len - 1] + s1.Substring(1, len - 2) + s1[0]);
        }

        public static String Method4(String s1, int n1)
        {
            String s2 = (s1.Remove(n1));
            return s2;
        }
        public static String Method3(String s1)
        {
            if (s1.StartsWith("if"))
            {
                return s1;
            }
            else
            {
                string s2 = string.Concat("if", s1);
                return s2;
            }
        }
        public static Boolean method2(int n, int n1)
        {
            if ((n == 30 || n1 == 30) || (n + n1) == 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int method1(int n, int n1)
        {

            // If and else should be consistent. Either use {} in both or don't.
            if (n == n1)
            {
                return 3 * (n + n1);
            }
            else
            {
                return (n + n1);
            }
        }
    }
}
