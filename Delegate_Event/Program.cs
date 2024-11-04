using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample4
{
    internal class Program
    {

        //DELEGATE
        public delegate void Addition(int a, int b);
        public delegate int Division(out int a, ref int b);
        //public delegate int add(int a,int b);
        //public delegate void Subtraction(int a, int b);

        //public delegate void Colordisplay(string c);
        static void Main(string[] args)
        {
            // //var keyword
            // var test = "123";
            //// test = 2;//compiler will throw error
            // dynamic b = 1;
            //  b = "norah";//  will not throw error
            // Console.WriteLine(test.GetTypeCode());
            // Console.WriteLine(b.GetTypeCode());


            //passing value to class in function

            //usual way
            //Employee employee = new Employee();
            //employee.Name = "norah";
            //employee.Id = 1;
            //employee.add(employee);

            //way2---anonymous type
            //var test = new { Name = "norah", Id = 1 };
            //Employee.add(test);
            //Console.ReadLine();

            //eg


            //var fruit = new { Name = "Apple", color = "Red" };
            //Fruit.Display(fruit);

            //Console.WriteLine("\n");
            //dynamic fruit2 = new { Name = "Orange", color = "Orange" };
            //Fruit.Display(fruit2);

            //Console.WriteLine("\n");
            //fruit2= new { Name = "Grapes", color = "violet" };
            //Fruit.Display(fruit2);
            ////Console.WriteLine(fruit2.Fruit.color);

            //delegate

            //Employee employee = new Employee();
            ////employee.Add();
            ////employee.Sub();
            //Addition addition = new Addition(employee.Add);
            //addition(50,100);
            //Subtraction subtraction = new Subtraction(employee.Sub);
            //subtraction(100, 50);

            //Employee emp = new Employee();
            //Colordisplay color = new Colordisplay(emp.Color);
            //color("orange")
            //;

            //Employee EMP= new Employee();
            // Addition A = new Addition(EMP.Add);
            // A += EMP.Sub; //this is okay all of the datatypes should be same

            // A(4, 5);

            //Division d = new Division(EMP.division);
            //Console.WriteLine(d(4, 2));

            //using out
            //Division d = new Division(EMP.division);
            //// Declare variables for out parameters
            //int x, y;
            //y = 10;

            //// Call the delegate and capture the return value
            //int result = d(out x, ref y);// to get output we need to pass parameters;

            //Console.WriteLine("Division result: " + result);

            //event
            Employee employee = new Employee();
            //    employee.TestEventHandler += Employee_TestEventHandler;
            //    Console.WriteLine("enter values: ");
            //    int value = 0;
            //    while (value < 6)
            //    {
            //        var result = Console.ReadKey(true).KeyChar;
            //        // Console.WriteLine(result);
            //        value++;
            //        Console.WriteLine(value);

            //    }

            //    Console.ReadLine();


            //public static void Employee_TestEventHandler(object SENDER, EventArgs E)
            //{
            //    Console.WriteLine("THRESHOLD");
            //}

           
            employee.FruitHandler += Employee_FruitEventHandler;
            while (true)
            {
                Console.WriteLine("enter the colors: ");
                string value = Console.ReadLine();
                employee.counter();
                if (value == "red")
                {
                    Console.WriteLine("------------");
                    Console.WriteLine(value);
                  
                    break;
                }
            }
            
            Console.ReadLine();

        } 
        private static void Employee_FruitEventHandler(object sender,EventArgs e)
        {
            Console.WriteLine("maximum value written");
        }


    }
}
