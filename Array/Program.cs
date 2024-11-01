using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //array
            //int[] number = new int[] { 1, 2, 3, 4, 5 };
            //string[] stringArray = new string[] { "hi", "how" };

            //foreach(int i in number)
            //{
            //    Console.WriteLine(i);
            //}

            //2D ARRAY
            //  int[,] two_dim = new int[,] { { 1, 2 },{ 3, 4 },{ 5, 6 }, { 7, 8 } };

            ////  Console.WriteLine(two_dim); system.int32
            //for(int i=0;i<4;i++)
            //  {
            //      for(int j=0;j<2;j++)
            //      {
            //          Console.WriteLine($"{i}-{j}----{two_dim[i, j]}");
            //      }
            //  }
            //  string[,] strings = new string[,]
            //  {
            //      {"NORAH","martin" },
            //      { "Chelsa","martin"},
            //      {"edvin","tony" }
            //  };
            //  Console.WriteLine("\n");
            //  for(int i=0;i<3;i++)
            //  {
            //      for(int j=0;j<2;j++)
            //      {
            //          Console.WriteLine($"{i}-{j}---{strings[i,j]}");
            //      }
            //  }


            //3d arrray int[,,]

            //jagged array
            //int[][] arr = new int[2][];
            //arr[0]= new int[5] { 1, 2, 3, 4, 5 };
            //arr[1] = new int[2] { 1, 2};

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("\n");
            //    for(int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.WriteLine(arr[i][j] + " ");
            //    }
            //}

            ////matrix addition,multiplication,transpose  //error
            //int[,] arr = new int[,]
            //{
            //    {1,2 },
            //    {2, 3 }
            //};
            //for(int i=0;i<arr.GetLength(0); i++)
            //{
            //    int sum = 0;
            //    for(int j=0;j<arr.GetLength(1); j++)
            //    {
            //        if (i == j)
            //        {
            //            sum += arr[i, j];
            //        }
            //        Console.WriteLine($"{arr[i,j]}={sum}");
            //    }

            //}





            //linear search

            //int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            //int item = 3;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i]==item)
            //    {
            //        Console.WriteLine($"elemnt {item} found at {i}");
            //    }

            //}

            //binary search

            //int[] arr = new int[7] { 2, 67, 6, 89, 1, 13, 7};
            ////sorting first
            //for(int i=0;i<=6; i++)
            //{

            //    for (int j = i + 1; j <= 6; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            int temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //        Console.Write($" ----{arr[j]}");


            //    }
            //    Console.WriteLine("\n");
            //}

            ////sorted array
            //for (int j = 0; j <=6; j++)
            //{
            //    Console.WriteLine($"{ j} ----{ arr[j]}");
            //}Console.WriteLine("\n");
            //int item = 2;
            //int high = 6;
            //int low = 0;



            //while(arr[low]<arr[high])
            //{
            //    int mid =(low+high) / 2;
            //    if (arr[mid]==item)
            //    {
            //        Console.WriteLine($"found at position: {mid}");
            //        break;
            //    }
            //    else if (arr[mid]>item)
            //    {
            //        high = mid;

            //    }
            //    else
            //    {
            //        low = mid+1;
            //    }
            //}


            //string -------manipulation
            // string str = "abcdefghi";
            //Console.WriteLine(str.Length);
            //str = str.Trim(); //removes the white space
            //Console.WriteLine(str.Length);

            //string str2 = "jklmn";
            //Console.WriteLine(str+""+str2);

            //Console.WriteLine(str2.Replace("m", "o"));

            //Console.WriteLine(str2.Substring(3));//FROM 3 TO END


            //how to return constant and vowels

            //string name = "norah";
            //int countc = 0;
            //int countv = 0;
            //name.ToCharArray();

            //for (int i = 0; i < name.Length; i++)
            //{
            //    if (name[i] ="a" || name[i] = "o")
            //    {

            //        countv++;
            //    }
            //    countc++;

            //}
            //Console.WriteLine(countv);
            //Console.WriteLine(countc);


            //second largest number by not using sorting
            

                Console.ReadLine();
        }
    }
}
