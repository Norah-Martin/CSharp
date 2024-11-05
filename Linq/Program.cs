using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employee=
            {
                new Employee() { Id = 1, Name = "norah", Age = 21 },
                new Employee() { Id = 2, Name = "CHELSA", Age = 25 },
                new Employee() { Id = 3, Name = "MARTIN", Age = 38 },
                new Employee() { Id = 4, Name = "TONY", Age = 48},


            };

            //we can give input like this
            //Employee employee1 = new Employee();
            //employee1.Name = "TONY";
            //employee1.Id = 4 ;
            //employee1.Age = 35;

            //Employee[3] = employee1;

            //to check age >21 retrun name
            ////for(int i=0; i<employee.Length; i++)
            ////{
            ////    if(employee[i].Age >31)
            ////    {
            ////        Console.WriteLine(employee[i].Name);
            ////    }
            ////}
            ///

            //instead of for loop-linq statment
            Console.WriteLine();
            var employees = employee.Where(x => x.Age > 41).ToArray(); //.to array to convrert to array
            Console.WriteLine(employees[0].Name);

            Console.WriteLine("\n");
            Employee[] emp = employee.Where(x => x.Id > 0 && x.Id < 4).ToArray();  //IF x.id= 3 we bneed to use x.id==3 //error as cannot convert int to bool...
            //display details
            foreach (var e in emp)
            {
                Console.WriteLine(e.Name);
            }


            //FIRST AND FIRSTDEFAULT
            // var emp1 = employee.Where(x => x.Name == "Norah").First();
            var EMP2 = employee.Where(x => x.Name == "Norah").FirstOrDefault();
            Console.WriteLine(EMP2);

            //another method to write ling 
            // var RESULT = from x in employees where x.Id == 1;

            //ORDERBY
           var  result=employee.OrderBy(x => x.Age).ToList();
            foreach (var e in result)
            {
                Console.WriteLine($"ID: {e.Id}, Name: {e.Name}, Age: {e.Age}");
            }
            //var result=from x in employee orderby


            Console.WriteLine("\n");
            //any keyword return true or false
            bool result1 = employee.Any(x => x.Name == "Norah");
            Console.WriteLine(result1);
            Console.WriteLine("\n");


            //AVERAGE
            var result2=employee.Average(x => x.Age);
            Console.WriteLine(result2);
            Console.WriteLine("\n");


            //COUNT
            var result3 = employee.Count(x => x.Age > 21);
            Console.WriteLine(result3);
            Console.WriteLine("\n");

            //SUM
            var result4=employee.Sum(x => x.Age);
            Console.WriteLine (result4);
            Console.ReadLine();
        }
    }
    public class Employee

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
