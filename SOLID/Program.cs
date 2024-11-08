using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            S stands for the Single Responsibility Principle, also known as SRP.This Principle states that each software module or class should have only one reason to change.In other words, each module or class should have only one responsibility.
            //O stands for the Open-Closed Principle, also known as OSP.The Open-Closed Principle states that software entities, such as modules, classes, functions, etc., should be open for extension but closed for modification.
            //L stands for the Liskov Substitution Principle, also known as LSP.This Principle states that the object of a derived class should be able to replace an object of the base class without causing any errors in the system or modifying the behavior of the base class. That means the child class objects should be able to replace parent class objects without changing the correctness or behavior of the program.
            //I stand for the Interface Segregation Principle, also known as ISP.This Principle states that Clients should not be forced to implement any methods they don’t use.Rather than one fat interface, numerous little interfaces are preferred based on groups of methods, with each interface serving one submodule.
            //        D stands for Dependency Inversion Principle, also known as DIP.This Principle states that high-level modules/classes should not depend on low-level modules/classes.Both should depend upon abstractions.Secondly, abstractions should not depend upon details. Details should depend upon abstractions.

            //            //callintg salary
            //            Salary salary = new Salary();
            //        int ans = salary.calcsalary(40);
            //        Console.WriteLine(ans);

            //        Student
            //        Student student = new Student();
            //        Subjects s = new Subjects();
            //        int ans = s.LabHours(3);
            //        Console.WriteLine(ans);
            //        int ans2 = s.SubjectHours(4);
            //        Console.WriteLine(ans2);

            //        LISKOVE
            //        against liskov

            //        Apple A= new Orange();
            //        Console.WriteLine(A.color());

            //        correcting above
            //        IFruit i = new Orange();
            //        Console.WriteLine(i.color());
            //        i = new Apple();
            //        Console.WriteLine(i.color());
            //        Console.ReadLine();

            //        INTERCAE SEGGREGRATION PRINCIPLE


            //SINGLETON

            singleton s = new singleton();
            s.print();

            singleton s2 = new singleton();
            s2.print();
            Console.ReadLine();

        }
    }
}
