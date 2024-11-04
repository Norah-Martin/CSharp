using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample4
{
    //    public class Employee
    //    {
    //        public string Name {  get; set; }
    //        public int Id {  get; set; }
    //        public void add(Employee emp)
    //        {
    //            Console.WriteLine($"{emp.Name}  --{emp.Id}");
    //        }
    //    }


    //way2

    //public static class Employee
    //{
       
    //    public static void add(dynamic emp)
    //    {
    //        Console.WriteLine($"{emp.Name}  --{emp.Id}");
    //    }
    //}

    //eq
    //public static class Fruit
    //{
    //    public static void Display(dynamic f)
    //    {
    //        Console.WriteLine($"{f.Name}---{f.color}");
    //    }
    //}


    //delegate
    //public  class Employee
    //{

    //    public void/*int*/ Add(int a, int b)
    //    {
            
    //        Console.WriteLine("THIS IS ADDITION");
    //        /*return*/
    //    }

    //    public void Sub(int a, int b)
    //    {
    //        Console.WriteLine("SUBTRACTION");
    //    }

    //    public void Color(string color)
    //    {
    //        Console.WriteLine($"color is :{color}");
    //    }
    //    public int division(out int a, ref int b)
    //    {
    //        a = 25;
    //        b = b-5;
    //        return a/b;
    //    }



    //}

    //event
    public class Employee
    {
        //public static int total;
        //public event EventHandler TestEventHandler;

        //public void addition()
        //{
        //    total++;
        //    if(total>5)
        //    {

        //        //invoked here

        //        TestEventHandler?.Invoke(this, EventArgs.Empty);
        //    }
        //}
        public static int count;
        public event EventHandler FruitHandler;
        public void counter()
        {
            count++;
            if(count==3)
            {
                FruitHandler?.Invoke(this, EventArgs.Empty);
            }
        }

    }


}
