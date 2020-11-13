using System;
using System.Xml;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a  number n:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a  number:n1");
            int n1 = Convert.ToInt32(Console.ReadLine());


            // no proper spacing 
            // too many extra lines
          //  int a = method1(n, n1);

         //   Console.WriteLine(a);

            bool b = method2(n, n1);
            Console.WriteLine(b);


        }
        public static int method1(int n, int n1)
        {

            // If and else should be consistent. Either use {} in both or don't.
            if (n == n1)
            {
                return 3 * (n + n1);
            }
            else
                return (n + n1);

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
    }
}
