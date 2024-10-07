using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.IO.Pipes;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;
using System.CodeDom.Compiler;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 2:
            //lab1----------Multiplication table
            //Console.WriteLine("Enter the number");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 10; i++)
            //{
            //    int ans = i * num;
            //    Console.WriteLine($"{i} * {num} = {ans}");
            //}

            ////lab2------right-anglled triangle pattern
            //Console.WriteLine("Enter the rows: ");
            //int rows = int.Parse(Console.ReadLine());
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write(" * ");
            //    }
            //    Console.WriteLine();
            //}

            //lab3------sum of all even numbers 1 and 100
            //int sum = 0;
            //int i = 1;
            // while(i<=100)
            //{
            //    if(i%2==0)
            //    {
            //        sum = sum + i;
            //    }
            //    i++;
            //}
            //Console.WriteLine($"The sum is: {sum}");


            //lab4--multiplication from 1 to 5;
            //int i = 1;
            //while(i<=5)
            //{
            //    int ans = 0;
            //    int j = 1; //intialize second loop varibale
            //    while(j<=10)
            //    {

            //        ans = i * j;
            //        Console.WriteLine($"{i} *{j} = {ans} ");
            //        j++;

            //    }
            //    Console.WriteLine();
            //    i++;
            //}

            //lab5------print positive number
            //Console.WriteLine("Enter a number:");
            //int num = int.Parse(Console.ReadLine());
            //while (num > 0)
            //{

            //    Console.WriteLine("Enter a number;");
            //    int num2 = int.Parse(Console.ReadLine());
            //    num = num2;

            //}
            //Console.WriteLine(" **END**  ");

            //lab6&12--menu driven calculator using nested do-while;
            //double num1, num2, result;
            //char operation;
            //char continueChoice;

            //do
            //{
            //    Console.WriteLine("Enter the first number:");
            //    num1 = Double.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter the second number:");
            //    num2 = Double.Parse(Console.ReadLine());

            //    do
            //    {
            //        Console.WriteLine("Choose an operation (+, -, *, /):");
            //        operation = Console.ReadKey().KeyChar;
            //        Console.WriteLine(); // Move to the next line

            //        switch (operation)
            //        {
            //            case '+':
            //                result = num1 + num2;
            //                Console.WriteLine($"Result: {num1} + {num2} = {result}");
            //                break;
            //            case '-':
            //                result = num1 - num2;
            //                Console.WriteLine($"Result: {num1} - {num2} = {result}");
            //                break;
            //            case '*':
            //                result = num1 * num2;
            //                Console.WriteLine($"Result: {num1} * {num2} = {result}");
            //                break;
            //            case '/':
            //                if (num2 != 0)
            //                {
            //                    result = num1 / num2;
            //                    Console.WriteLine($"Result: {num1} / {num2} = {result}");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Error: Division by zero is not allowed.");
            //                }
            //                break;
            //            default:
            //                Console.WriteLine("Invalid operation. Please choose a valid operation.");
            //                continue; // Continue asking for a valid operation
            //        }

            //    } while (operation != '+' && operation != '-' && operation != '*' && operation != '/');

            //    Console.WriteLine("Continue (y/n):");
            //    continueChoice = Console.ReadKey().KeyChar;
            //    Console.WriteLine(); // Move to the next line

            //} while (continueChoice == 'y' || continueChoice == 'Y');

            //Console.WriteLine("**END**");

            //lab7------print number from 1 to 100 use of continue and break
            //for(int i=1;i<=100;i++)
            //{
            //    if(i%3==0)
            //    {
            //        continue;
            //    }
            //    if(i>50)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);

            //}
            //Console.WriteLine("End");

            //lab8-------sum of odd numbers
            //int sum = 0;
            //for (int i = 1; i <= 100; i = i + 2)
            //{
            //    sum = sum + i;
            //}

            //Console.WriteLine(sum);

            //lab9-------Factorial Calculation
            //Console.WriteLine("Enter the number: ");
            //int number = int.Parse(Console.ReadLine());
            //int fact = 1;
            //while (number > 0)
            //{
            //    fact = fact * number;
            //    number--;

            //}
            //Console.WriteLine($"The factorial is:{fact}");


            //lab10-------Number Pyramid
            //Console.WriteLine("Enter the rows");
            //int rows = int.Parse(Console.ReadLine());
            //int i = 1;
            //while (i <= rows)
            //{
            //    int j = 1;
            //    while (j <= i)
            //    {

            //        Console.Write(i + " ");
            //        j++;
            //    }
            //    Console.WriteLine();
            //    i++;

            //}

            //lab11--------guess the number
            //char ch;
            //Random rand = new Random();

            //do
            //    {
            //        Console.WriteLine("\nEnter the number");
            //        int num1 = int.Parse(Console.ReadLine());

            //        int num = rand.Next(1,101);
            //        if (num1 > num)
            //        {
            //            Console.WriteLine("**Too High ,Guess LOW **");
            //        }
            //        else if (num1 < num)
            //        {
            //            Console.WriteLine("**Too Low Guess HIGH**");
            //        }
            //        else 
            //        {
            //            Console.WriteLine("** Congratulations,Guessed Right**");
            //        }


            //        Console.WriteLine("Do you wanna continue(y/n)\n");
            //        ch = Console.ReadKey().KeyChar;
            //    } while (ch == 'y' || ch == 'Y');


            //lab13-----------sum of digits using do while
            //Console.WriteLine("Enter the number:");
            //int num = int.Parse(Console.ReadLine());

            //int sum = 0;
            //int rem = 0;
            //do
            //{
            //    rem = num % 10;
            //    sum = sum + rem;
            //    num = num / 10;
            //} while (num > 0);
            //Console.WriteLine($"The sum is:{sum}");

            //lab14------------largest number
            //int[] num = new int[100];
            //Console.WriteLine("How many numbers:");
            //int num2=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the numbers");
            //for(int i=0;i<num2; i++)
            //{
            //num[i]=int.Parse(Console.ReadLine());
            //}
            //int largest;
            //largest = num[0];
            //for(int i=0;i<num2;i++)
            //{
            //    if (largest < num[i])
            //    {
            //        largest = num[i];
            //    }
            //}
            //Console.WriteLine($"The Largest is:{largest}");

            //lab15-------Sum of squares
            //Console.WriteLine("Enter the number:");
            //int num = int.Parse(Console.ReadLine());

            //int i = 1;
            //int sum = 0;
            //while(i<=num)
            //{
            //    int square = 0;

            //    square = i * i;
            //    sum = sum + square;
            //    i++;


            //}
            //Console.WriteLine($"The sum is {sum}");

            //lab16--------countdown timer

            //int num = 10;
            //do
            //{
            //    Console.WriteLine(num);
            //    Thread.Sleep(1000);
            //    num--;


            //} while (num > 0);
            //Console.WriteLine("**End**");

            //lab17-----first five multipleint
            //int[] num = new int[7];
            ////Console.WriteLine("how many numbers:");
            ////int len=int.Parse(Console.ReadLine());
            ////Console.WriteLine("Enter the numbers:");
            ////giving the numbers
            //for (int i = 0; i < num.Length; i++)
            //{
            //    num[i] = int.Parse(Console.ReadLine());
            //}
            //int[] num2 = new int[7];
            //Console.WriteLine("The ans is:");
            //for (int i = 0; i < num.Length; i++)
            //{

            //    if (num[i] % 5 == 0)
            //    { //printing the first 5 multiple
            //        Console.WriteLine(+num[i]);
            //        num2[i] = num[i];           //error
            //    }
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    if (num2[i] % 5 == 0)
            //    {
            //        Console.WriteLine("hi");//to understand its working
            //        break;
            //    }
            //}
            //Console.WriteLine("end");

            //lab18-----continue
            //for(int i=0;i<=20;i++)
            //{
            //    if(i%3==0)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.Write(i+" ");
            //    }
            //}

            //lab19-------palindrome using while loop
            //Console.WriteLine("Enter the number: ");
            //int num = int.Parse(Console.ReadLine());
            //int temp = num;
            //int rem = 0;
            //int rev = 0;
            //while(num>0)
            //{
            //    rem = num % 10;
            //    rev = rev * 10 + rem;
            //    num = num / 10;


            //}
            //if(temp==rev)
            //{
            //    Console.WriteLine("** PALINDROME **");

            //}
            //else
            //{
            //    Console.WriteLine("** Not Palindrome **");
            //}

            //lab20------avg of positive number-do while
            //int count = 0;

            //int sum = 0;
            //do
            //{
            //    Console.WriteLine("Enter the number:");
            //    int num = int.Parse(Console.ReadLine());
            //    if (num > 0)
            //    {
            //        count++;
            //        sum += num;
            //    }
            //    else
            //    {
            //        Console.WriteLine("***");
            //        break;
            //    }

            //} while (true);
            //int avg=sum/count;
            //Console.WriteLine($"The average is{avg}");

            //lab21----------reverse
            //Console.WriteLine("Enter the number:");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int rem = 0;
            //int rev = 0;
            //do
            //{
            //    rem = num % 10;
            //    rev = rev * 10 + rem;
            //    num = num / 10;
            //} while (num > 0);
            //Console.WriteLine($"The reversed number is {rev}");

            ////lab22------------switch
            //Console.WriteLine("Enter string");
            //string str = Console.ReadLine();
            //Console.WriteLine("Choose:" +
            //    "1. Reverse String\n" +
            //    "2.Convert To UPPERCASE\n" +
            //    "3.Convert To lowercase\n" +
            //    "4.Find Length");
            //char num = char.Parse(Console.ReadLine());
            //    switch(num)
            //{


            //    case '1':char[] str2 = str.ToCharArray();
            //        for(int i=0; i<str.Length;i++)

            //        {
            //            str2[i] = str[str.Length-1-i]; //reverse  order input//
            //        }
            //        Console.WriteLine($"The reversed is:{new string(str2)}");
            //        break;


            //    case '2':Console.WriteLine($"To uppercase is:{str.ToUpper()}");
            //        break;
            //    case '3':
            //        Console.WriteLine($"To lowercase is:{str.ToLower()}");
            //        break;
            //    case '4':
            //        Console.WriteLine($" length is:{str.Length}");
            //        break;
            //    default:
            //        Console.WriteLine("Sorry");
            //        break;

            //}

            //lab23------skip multiple of 4
            //for (int i = 0; i <= 50; i++)
            //{
            //    if (i % 4 == 0)
            //    {
            //        continue;
            //    }
            //    else
            //    {


            //        Console.Write(" " + i);
            //    }
            //}

            //lab24---------fibonnaci series...1 1 2 3 5 8 ..
            //int num1 = 1;
            //int num2 = 1;
            //int num3 = 0;
            //Console.Write(num1 + " " + num2);
            //for(int i=0;i<=10;i++)
            //{
            //    num3 = num1 + num2;
            //    Console.Write(" " + num3);
            //    num1 = num2;
            //    num2 = num3;
            //}

            //lab25------armstrong


            //int num = 1;

            //while (num <= 500)
            //{
            //    int sum, temp;

            //    sum = 0;
            //    temp = num;
            //    int rem;


            //    while (temp > 0)
            //    {
            //        rem = temp % 10;
            //        sum += rem * rem * rem;
            //        temp = temp / 10;
            //    }

            //        if (num == sum)
            //        {
            //            Console.WriteLine(" " + num);
            //        }

            //    num++;
            //}



            //26--menu driven






            //lab27-----reverse a string
            //Console.WriteLine("Enter string:");
            //string str = Console.ReadLine();
            //char[] str2 = str.ToCharArray();
            //for (int i = 0; i < str.Length; i++)

            //{
            //    str2[i] = str[str.Length - 1 - i]; //reverse  order input//
            //}
            //Console.WriteLine($"The reversed is:{new string(str2)}");

            //lab28----count vowels and consonants
            //Console.WriteLine("Enter the string");
            //string str = Console.ReadLine();
            //char[] ch = str.ToCharArray();
            //int countv = 0, countc = 0;
            //for(int i=0;i<ch.Length; i++)
            //{
            //    if (ch[i] == 'a' || ch[i] == 'A' ||
            //        ch[i] == 'e' || ch[i] == 'E' ||
            //        ch[i] == 'i' || ch[i] == 'I' ||
            //        ch[i] == 'o' || ch[i] == 'O' ||
            //        ch[i] == 'u' || ch[i] == 'U')
            //    {
            //        countv++;
            //    }
            //    else
            //    {
            //        countc++;
            //    }

            //}
            //Console.WriteLine($"Number of vowels:{countv} and consonants:{countc});

            //lab29----------maximum and minimum
            //int[] arr = new int[5];
            //int max, min;
            //Console.WriteLine("Enter numbers:");
            //for(int i=0;i<arr.Length;i++)
            //{
            //     arr[i] = int.Parse(Console.ReadLine());

            //}
            //max = arr[0];
            //min = arr[0];
            //    for(int i=1;i<arr.Length;i++)
            //{
            //    if (max < arr[i])
            //    {
            //        max = arr[i];

            //    }
            //    if (min > arr[i])
            //    {
            //        min = arr[i];
            //    }
            //}
            //Console.WriteLine($"Maximum is:{max} and minimum is:{min}");

            //lab30------count digits of number using while
            //Console.WriteLine("Enter number:");
            //int num = int.Parse(Console.ReadLine());
            //int count = 0;
            //int rem = 0;
            //while(num>0)
            //{
            //    rem = num % 10;
            //    count++;
            //    num = num / 10;
               
                
            //}

            //Console.WriteLine($"Number of digits is:{count}");

            //26 not finished

            





























                Console.ReadLine();

        }
    }
}
