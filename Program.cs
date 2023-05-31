
using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //printing values of differen data types
           int p = 1;
           char x = 'a';
           double u = 2.3;
           string y = "hello";
           bool z = true;
          
            Console.WriteLine(p);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(p +""+ x);
            Console.WriteLine(p +""+ p);

           // calculation of these variables
          // *********************************************** 
            int o = 4; int c = 5;
            int d = 6; int e = 7;
            int f = 8;
            int g =  p - o * c + d;
            
            Console.WriteLine(g);
            int h = g - f;
            Console.WriteLine(h);

            // taking values from the user
            // *************************************************
            
            Console.WriteLine("Enter the first number: ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(b - a);
            Console.WriteLine(a / b);
            Console.WriteLine(b / a);
            Console.WriteLine(a * b);
            Console.WriteLine(a % b);
            Console.WriteLine(b % a);


            // Swaping values of variables
            // ******************************************************
            int i = 0;
            int j = 1;
            int temp = i;
            i = j;
            j = temp;
            string s = "hello";
            string t = "world";
            string temp2 = s;
            s = t;
            t = temp2;
            Console.WriteLine("i = " + i);
            Console.WriteLine("j = " + j);

            Console.WriteLine("s = " + s);
            Console.WriteLine("t = " + t);



        }
    }
}