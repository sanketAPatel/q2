using System;
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

            //Console.WriteLine("enter three int values 4 Question # 10");
            //int x = Convert.ToInt32(Console.ReadLine());
            //int y = Convert.ToInt32(Console.ReadLine());
            //int z = Convert.ToInt32(Console.ReadLine());
            //bool M10 = Method10(x, y, z);
            //Console.WriteLine(M10);

            //Console.WriteLine("enter size of an array you want for 11");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] array1 = new int[size];
            //Console.WriteLine("enter rotation of an array you want");
            //int rotation = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    array1[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine(string.Join(",", Method11(array1, rotation)));
        }

        public static int[] Method11(int[] array1, int rotation)
        {
            int[] array2 = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                int shift = i - rotation;
                int newRotation = array2.Length + shift;

                if (shift >= 0)
                {
                    array2[shift] = array1[i];
                }
                else
                {
                    array2[newRotation] = array1[i];
                }
            }
            return array2;
        }

        /*Write a C# Sharp program to check whether three given integer values are in the range 20..50 inclusive.
          Return true if 1 or more of them are in the said range otherwise false. 
         *@param int x
         * @param int y
         * @param int z
         * @return boolean
         */
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

        /*Write a C# Sharp program to check if a given string starts with 'C#' or not.
         *@param String s1        
         *@return boolean
         */
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

        /*Write a C# Sharp program to create a new string taking the first 3 characters of a given string and return the string with the 3 characters added at both the front and back. 
          If the given string length is less than 3, use whatever characters are there.
         *@param String s1
         *@return String
         */
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

        /*Write a C# Sharp program to create a new string with the last char added at the front and back of a given string of length 1 or more. 
         *@param String s1
         * @return String
         */
        public static String Method7(String s1)
        {
            String s2 = s1.Substring(s1.Length - 1);
            return String.Concat(s2 + s1 + s2);
        }

        /*Write a C# Sharp program to create a new string which is 4 copies of the 2 front characters of a given string.
          If the given string length is less than 2 return the original string.
         *@param String s1
         *@return String
         */
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

        /*Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
         *@param String s1
         *@return String
         */
        public static void Method5(String s1)
        {
            int len = s1.Length;
            Console.WriteLine(s1[len - 1] + s1.Substring(1, len - 2) + s1[0]);
        }

        /*Write a C# Sharp program to remove the character in a given position of a given string. The given position will be in the range 0.. string length -1 inclusive. 
         *@param String s1
         *@param int n1
         * @return String
         */
        public static String Method4(String s1, int n1)
        {
            String s2 = (s1.Remove(n1));
            return s2;
        }

        /*Write a C# Sharp program to create a new string where 'if' is added to the front of a given string. 
          If the string already begins with 'if', return the string unchanged.
         *@param String s1
         * @return String 
         */
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

        /*Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30. 
         *@param int n
         *@param int n1
         *@return boolean
         */
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

        /*Write a C# Sharp program to compute the sum of the two given integer values. If the two values are the same, then return triple their sum.
         *@param int n
         *@param int n1
         *@return int
         */
        public static int method1(int n, int n1)
        {
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
