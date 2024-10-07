using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Assignment11
{
    internal class Program
    {
        static void Main(string[] args)
        { /*
            //hello world
            Console.WriteLine("Hello,World!");

            //name and greet
            Console.WriteLine("Name:");
            string name=Console.ReadLine();
            Console.WriteLine("Hello " +name);
            Console.ReadLine();*/

            //Input and Output
            //Console.WriteLine("Your Name and age");
            //string name = Console.ReadLine();
            //string age = Console.ReadLine();
            //Console.WriteLine($"Hello,{name}!.You are { age}years old.");

            ////color
            //Console.WriteLine("\nFavourite Color?");
            //string color = Console.ReadLine();
            //Console.WriteLine($"Hello,{ name }.\nYour favourite color is  { color}");

            ////aritmetic operation
            //int num1, num2;
            //int sum = 0, diff = 0, multi = 0, div = 0;
            //Console.WriteLine("Enter the Numbers:");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //num2 = Convert.ToInt32(Console.ReadLine());
            //sum = num1 + num2;
            //diff = num1 - num2;
            //multi = num1 * num2;

            ////div by 0
            //Console.WriteLine($"\nsum is {sum}\n" +
            //    $"difference is{diff}\n" +
            //    $"multiplication is {multi}\n");
            //if (num2 != 0)
            //{
            //    div = num1 / num2;
            //    Console.WriteLine($"division is {div}");

            //}
            //else { Console.WriteLine("Not Possible"); }


            //temperature
            //Console.WriteLine("Enter Temperature:");
            //double temp;
            //temp = Double.Parse(Console.ReadLine());
            //double Fahren;
            //Fahren =( ((temp * 9) / 5)+ 32);

            //Console.WriteLine($"The Fahrenheit is{Fahren}");

            //lab5-------Simple interest
            //Console.WriteLine("Enter the value for P, R, T");
            //double P, R, T;
            //P = Convert.ToDouble(Console.ReadLine());
            //R = Convert.ToDouble(Console.ReadLine());
            //T = Convert.ToDouble(Console.ReadLine());
            //double si = 0;
            //si = (P * R * T) / 100;
            //Console.WriteLine($"The simple interst is :{si}");


            // //lab 6---------area of a circle
            // Console.WriteLine("Enter the radius ");
            // double radius;
            //// const double PI = 3.12;
            // radius = Convert.ToDouble(Console.ReadLine());
            // double area =Math.PI * radius * radius;
            // Console.WriteLine($"\n area of circle is{area}");

            ////lab 7------time calculation
            //Console.WriteLine("Enter the time in seconds:");
            //int seconds = int.Parse(Console.ReadLine());
            //int hours;
            //hours = seconds / 3600;
            //int remsec = seconds % 3600;
            //int minutes = remsec / 60;
            //int secondsec = seconds % 60;
            //Console.WriteLine($"{hours}:{minutes}:{secondsec}");

            //lab8-------String Length and Character Count

            //Console.WriteLine("Enter the line:");
            //String str;
            //str=Console.ReadLine();
            //char [] chars = str.ToCharArray();
            //int count = 0;
            //for (int i = 0; i < chars.Length; ++i)
            //{
            //    if (chars[i] == ' ')
            //    {
            //        count++;

            //    }C
            //}
            //        Console.WriteLine($"length is {chars.Length-count}");

            //lab9----------------Body Mass Index
            //Console.WriteLine("Enter the Height(m) and Weight(kg)");

            //double height = double.Parse(Console.ReadLine());
            //double weight = double.Parse(Console.ReadLine());
            //double BMI = 0;
            //BMI = weight / (height * height);
            //Console.WriteLine($"The BMI is {BMI}");

            ////lab10---------------Variables and Constants
            //int num1 = 10;
            //Console.WriteLine($"{num1} ---- {num1.GetTypeCode()}");
            //float num2 = 52.3f;
            //Console.WriteLine($"{num2}----{num2.GetTypeCode()}");
            //double num3 = 56.48;
            //Console.WriteLine($"{num3}----{num3.GetTypeCode()}");
            //char ch = 'a';
            //Console.WriteLine($"{ch}------{ch.GetTypeCode()}");
            //string str = "Norah";
            //Console.WriteLine($"{str}----{str.GetTypeCode()}");
            //bool myBOOL = true;
            //Console.WriteLine($"{myBOOL}----{myBOOL.GetTypeCode()}");

            //lab11--------------area of rectangle and circle
            //double length, breadth, radius;
            //Console.WriteLine("enter the length and breadth\n");
            //length = double.Parse(Console.ReadLine());
            //breadth = double.Parse(Console.ReadLine());
            //Console.WriteLine($"The area of rectangle is:{length * breadth}cm.");
            //Console.WriteLine("Enter radius:");
            //radius = double.Parse(Console.ReadLine());
            //Console.WriteLine($"The area of circle is: {Math.PI*radius*radius}cm.");

            ////lab12-------------circumference of circle
            //const double PI = 3.14159;
            //const int DAYS_IN_WEEK = 7;
            //double radius;
            //Console.WriteLine("enter the radius");
            //radius = double.Parse(Console.ReadLine());
            //Console.WriteLine($"Circumference is {2*PI*radius} and {DAYS_IN_WEEK}");

            ////lab13----------------area of rectangle
            //double length, breadth;
            //Console.WriteLine("enter the leangth and breadth(in inches)");
            //length = double.Parse(Console.ReadLine());
            //breadth = double.Parse(Console.ReadLine());
            //Console.WriteLine($"in square inches{length * breadth}");
            //const double INCH = 2.54;
            ////converting inches to cm by mulitpying 2.54 or 
            //length *= INCH;
            //breadth *= INCH;
            //Console.WriteLine($"in square centimeters:{length * breadth}");

            //lab14----------------name age salary of employee
            //Console.WriteLine("Enter Name: ");
            //String str = Console.ReadLine();
            //Console.WriteLine("Enter Age: ");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Salary: ");
            //double salary = double.Parse(Console.ReadLine());
            //Console.WriteLine("***THE DETAILS ARE***");
            //Console.WriteLine($"NAME------{str}");
            //Console.WriteLine($"AGE-------{age}");
            //Console.WriteLine($"SALARY----{salary}");

            //lab 15-----------standards
            /*    class program
            {
                static void main()
                {
                    int first_number = 5;
                    int second_number = 3;
                    Console.WriteLine(first_number + second_number);
                    Console.ReadLine();
                }
            }
            */

            //lab16------------assignment operator
            //int number = 123;
            //Console.WriteLine(number);


            ////lab17----------Power
            //double number;
            //Console.WriteLine("Enter the number");
            //number=double.Parse(Console.ReadLine());
            //Console.WriteLine($"Square is  :{Math.Pow(number, 2)}");


            //lab18--------------Voting
            //Console.WriteLine("Enter age and citizenship please:");
            //string citizen;

            //int age = int.Parse(Console.ReadLine());
            //citizen = Console.ReadLine();

            //if((age>=18) && (citizen.ToLower()=="indian"))
            //{
            //    Console.WriteLine("**Elgible to Vote**");

            //}
            //else { Console.WriteLine("**Not Eligible**"); }


            //lab19-------------Loan eligible
            //Console.WriteLine("Enter age:");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter income in:");
            //double income = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Loan status(yes/no):");
            //string loan = Console.ReadLine();
            //if ((age >= 21) && (income >= 30000) && (loan.ToLower() == "no")) 
            //{
            //    Console.WriteLine("**Eligible For Loan **");
            //}

            //else{
            //    Console.WriteLine("Not Eligible");

            //}

            //lab 20-------------Job Eligible
            //Console.WriteLine("Enter age: ");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Work Experience:");
            //double exp = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter college degree(yes/no)");
            //string degr = Console.ReadLine();
            //if(age>=18 && age<=35)
            //{
            //    if(exp>=2)
            //    {
            //        if(degr.ToLower()=="yes" || exp>=5)
            //        {
            //            Console.WriteLine("**Congragulations, You are Eligibe**");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("**Sorry,Experience required**");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("**Better Luck Next Time**");
            //}

            //lab21----------------character vowel or consonants
            //Console.WriteLine("Enter the charcater");
            //string str = Console.ReadLine();

            //if (str.ToLower() == "a" || str.ToLower() == "a" || str.ToLower() == "e" || str.ToLower() == "i" || str.ToLower() == "o" || str.ToLower() == "u")
            //{
            //    Console.WriteLine("Vowel");
            //}
            //else
            //{
            //    Console.WriteLine("Consonant");
            //}


            //lab22------------number postive negative or zero
            //Console.WriteLine("Enter the number: ");
            //int num = int.Parse(Console.ReadLine());
            //if(num>0)
            //{
            //    Console.WriteLine("**Positive Number**");
            //}
            //else if(num<0)
            //{
            //    Console.WriteLine("**Negative Number**");

            //}
            //else
            //{
            //    Console.WriteLine("**Zero**");
            //}

            ////lab23------------check number divisble by 5 and 11
            //Console.WriteLine("Enter the number:");
            //int num = int.Parse(Console.ReadLine());
            //if((num%5==0) &&(num%11==0))
            //{
            //    Console.WriteLine("**  Divsible by 5 and 11  **");
            //}
            //else
            //{
            //    Console.WriteLine("**  Not Divisible  **");
            //}


            //lab24-----------calculator
            //Console.WriteLine("Enter the Numbers:");
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Operation: (+, -, *, /) ");
            //string str = Console.ReadLine();
            //if (str == "+")
            //{
            //    int sum = 0;
            //    sum = num1 + num2;
            //    Console.WriteLine($"The sum is: {sum}");
            //}
            //else if (str == "-")
            //{
            //    int diff = 0;
            //    diff = num1 - num2;
            //    Console.WriteLine($"The differnce is: {diff}");
            //}
            //else if(str=="*")
            //{
            //    int mult = 0;
            //    mult = num1 * num2;
            //    Console.WriteLine($"The product is: {mult}");
            //}
            //else if(str=="/")
            //{
            //    int div = 0;
            //    div = num1 / num2;
            //    Console.WriteLine($"The quotient is:{div}");

            //}
            //else
            //{
            //    Console.WriteLine("**Sorry,ERROR**");
            //}

            //lab25-------grading system
            //Console.WriteLine("Enter the marks: (out of 100)");
            //double marks = double.Parse(Console.ReadLine());
            //if(marks>=90)
            //{
            //    Console.WriteLine("**  Grade=\"A\"   **");
            //}
            //else if(marks>=80 && marks<=89)
            //{
            //    Console.WriteLine("**  Grade=\"B\"  **");
            //}
            //else if (marks >= 70 && marks <= 79)
            //{
            //    Console.WriteLine("**  Grade=\"C\"  **");
            //}
            //else if (marks >= 60 && marks <= 69)
            //{
            //    Console.WriteLine("**  Grade=\"D\"  **");
            //}
            //else
            //{
            //    Console.WriteLine("**  Grade=\"F\"  **");
            //}


            //lab26----------swap two values
            //using a third variable
            //Console.WriteLine("Enter the numbers: ");
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"The number are---{num1}  {num2}");
            ////int temp;
            ////temp = num1;
            ////num1 = num2;
            ////num2 = temp;
            ////Console.WriteLine($"The swapped numbers-{num1} {num2}");

            ////without third variable
            //num1 = num1 + num2;
            //num2 = num1 - num2;
            //num1 = num1 - num2;
            //Console.WriteLine($"The swapped numbers-{num1} {num2}");


            //lab27--------perform arithmetic operation
            //Console.WriteLine("Enter the numbers:");
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int sum = 0, diff = 0, prod = 0, quot = 0;
            //sum = num1 + num2;
            //diff = num1 - num2;
            //prod = num1 * num2;
            //quot = num1 / num2;
            //Console.WriteLine($"sum={sum}\ndiff={diff}\nprod={prod}\nquotient={quot}");
            //num1++;
            //num2++;
            //Console.WriteLine($"The number is:{num1},{num2}");
            //num1--;
            //num2--;
            //Console.WriteLine($"The number is:{num1},{num2}");


            //lab28--------average of three numbers
            //Console.WriteLine("Enter the three numbers: ");
            //double num1 = double.Parse(Console.ReadLine());
            //double num2 = double.Parse(Console.ReadLine());
            //double num3 = double.Parse(Console.ReadLine());
            //double avg = 0;
            //avg = (num1 + num2 + num3) / 3;
            //Console.WriteLine($"The average is  {avg:f2}");

            //lab 29----------currencyconversion
            //Console.WriteLine("Enter the amount:(in USD)");
            //double usd = double.Parse(Console.ReadLine());
            //usd = usd * 0.85;
            //Console.WriteLine($"The amount in EUR is {usd}");

            //lab30---------input within range and odd or even
            //Console.WriteLine("Enter the number");
            //int num = int.Parse(Console.ReadLine());
            //if(num>=1 && num<=100)
            //{
            //    if(num%2==0)
            //    {
            //        Console.WriteLine("The number within range and **EVEN** number");

            //    }
            //    else
            //    {
            //        Console.WriteLine("The number is within range and **ODD** number");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("**Sorry**");
            //}


            //lab31------dib by 3 and 5
            //Console.WriteLine("Enter the number:");
            //int num = int.Parse(Console.ReadLine());
            //if ((num % 3 == 0) && (num % 5 == 0))
            //{
            //    Console.WriteLine("**  Divsible by 3 and 5  **");
            //}
            //else
            //{
            //    Console.WriteLine("**  Not Divisible  **");
            //}

            //lab32-----------leap year
            //Console.WriteLine("Enter the year: ");
            //int year = int.Parse(Console.ReadLine());
            //if((year%4==0 && year%100!=0) ||year%400==0)
            //{
            //    Console.WriteLine("** Leap Year **");

            //}
            //else
            //{
            //    Console.WriteLine("** Not Leap Year **");
            //}


            //lab33-------------postive,even >50 using nested if
            //Console.WriteLine("Enter the number: ");
            //int num = int.Parse(Console.ReadLine());
            //if(num>0)
            //{
            //    if(num%2==0)
            //    {
            //        if(num>50)
            //        {
            //            Console.WriteLine(" Number is POSITIVE, EVEN, >50 ");

            //        }
            //        else
            //        {
            //            Console.WriteLine(" not greater,FAILED ");

            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine(" not even ,FAILED");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(" Condition Failed ");
            //}

            //lab34---------calculate student grade
            //Console.WriteLine("Enter the marks of first subject: ");
            //int marks = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the marks of second subject: ");
            //int marks1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the marks of third subject: ");
            //int marks2 = int.Parse(Console.ReadLine());
            //int count = 0;
            //int avg = 0;
            //avg=(marks+marks1+marks2)/3;
            //if (marks <40)
            //{
            //    count++;
            //}
            //if(marks1 <40)
            //{
            //    count++;
            //}
            //if(marks2<40)
            //{
            //    count++;
            //}
            //if(avg>=70)
            //    {
            //        Console.WriteLine("** DISTINCTION **");

            //    }
            //else if (count <= 3)
            //{
            //    Console.WriteLine($"** FAILED : {count} subject **");
            //}
            //else
            //{
            //    Console.WriteLine("** PASSED **");
            //}


            //lab35----------salary and tax calculation
            //Console.WriteLine("Enter the salary:");
            //double sal = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the age: ");
            //int age = int.Parse(Console.ReadLine());
            //double tax;
            //if (sal < 10000)
            //{
            //    Console.WriteLine("**No Tax**");

            //}
            //else if (sal >= 10000 && sal <= 50000)
            //{
            //    if (age >= 60)
            //    {
            //        tax = (sal * .01) - 5000;
            //        Console.WriteLine($"Tax is: {tax}");
            //    }
            //    else
            //    {
            //        tax = sal * .01;
            //        Console.WriteLine($"Tax is: {tax}");


            //    }
            //}
            //else if (sal >= 50000)
            //{
            //    if (age >= 60)
            //    {
            //        tax = (sal * .02) - 5000;
            //        Console.WriteLine($"Tax is: {tax}");
            //    }
            //    else
            //    {
            //        tax = sal * .02;
            //        Console.WriteLine($"Tax is: {tax}");


            //    }

            //}

           




















            Console.ReadLine();

        
        }
    }
}
