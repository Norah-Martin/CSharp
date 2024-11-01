using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Sample2.Class1;

namespace Sample2
{
    internal class Program
    {

        //// Use DllImport to import the Win32 MessageBox function.
        //[DllImport("user32.dll", CharSet = CharSet.Unicode)]
        //public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);





        static void Main(string[] args)
        {
            //    //call by value and call by refernce
            //    int a = 100;
            //    Console.WriteLine($"value of a before:{a}");
            //    Console.WriteLine($"value of a after:{add( ref a)}");
            //    Console.WriteLine($"value of a after :{a}");

            //pass by value
            //Area a = new Area();
            //int l = 10, w = 2;
            //Console.WriteLine($"before vales:l={l} and w={w}");
            //Console.WriteLine("\n");
            //int area = a.Calc(l, w);
            //Console.WriteLine($"after vales:l={l} and w={w} and area is {area}");

            //Console.WriteLine("\n");
            //pass by refernce using ref
            //int l = 10, w = 2;
            //Console.WriteLine($"before vales:l={l} and w={w}");
            //Console.WriteLine("\n");
            //int area = a.Calc2(ref l, ref w);
            //Console.WriteLine($"after vales:l={l} and w={w} and area is {area}");

            //pass by refernce using out
            //int l = 10, w = 2;        no use 
            //Console.WriteLine($"before vales:l={l} and w={w}");


            //obselet
            //int l, w;
            //int area1 = Calc(1, 2);
            //Console.WriteLine("Area (obsolete method): " + area1);
            //int area = a.Calc2(out l, out w);
            //Console.WriteLine($"after vales:l={l} and w={w} and area is {area}");

            //enum
            // //months m = new months();
            //foreach (months.days i in Enum.GetValues(typeof(months.days)))
            //{
            //    Console.WriteLine($" {i}: {(int)i}");
            //}

            //indexer

            // Emp e=new Emp();
            //e[1] = 2;
            //e[2] = 13;
            //Console.WriteLine(e[1]+" " + e[2]);
            //Months m=new Months();
            //m[0] = "January";
            //m[1] = "february";
            //m[5] = "june";
            //m[11] = "december";





            Console.ReadLine();
        }

    }

        // public static int add(ref int a)
        //{
        //    a= a+ 5;
        //    Console.WriteLine($"value of a inside add :{a}");
        //    return a; 
        //}

        //tuple-multiple return



        ////obselet
        //[Obsolete("old method", true)]
        //public static oldmethod();
        //    {

        //    }


        //conditonal
        //[Conditional("DEBUG")]
}
 

