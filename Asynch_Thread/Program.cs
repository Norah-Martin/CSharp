using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sample5
{
    public class Program
    {

        //asynchronous task


        //    public static /*async Task */void Main(string[] args)
        //    {
        //      /*await */ common(); //if await not given result is there ,if await given aync task;
        //      Console.ReadLine();


        //        //Method1();
        //        //Method2();

        //        //Task<string> task=Fruits();
        //        //Console.WriteLine($"-----------------{task}--------");
        //        //string result=await task;  //since awit expect static so write this in static ain
        //        //Color();
        //        //Console.ReadLine();
        //    }

        ////       public static async void Method1()

        ////        {
        ////            await Task.Run(() =>
        ////            {
        ////        for (int i = 0; i < 100; i++)
        ////        {
        ////            Console.WriteLine(i);
        ////            Task.Delay(100).Wait();
        ////        }
        ////    });
        ////        }

        ////public static void Method2()
        ////{

        ////    for (int i = 0; i < 100; i++)
        ////    {
        ////        Console.WriteLine(i);
        ////        Task.Delay(100).Wait();
        ////    }
        ////}

        //    public static async void common()
        //    {
        //        Task<string> task = Fruits();
        //        Console.WriteLine($"-----------------{task.Result}------------");
        //        string result = await task;  //since awit expect static so write this in static ain
        //        Console.WriteLine($"----------{result}------------");
        //        Color();

        //    }

        //    public static async Task<string> Fruits() //return of asyn must be void
        //    {
        //        await Task.Run(() =>
        //        {
        //            for (int i = 0; i < 5; i++)
        //            {
        //                Console.WriteLine("Apple");
        //                Task.Delay(100).Wait();

        //            }
        //        });
        //        return "apple";
        //    }

        //    public static void Color()

        //    {
        //        for(int i=0;i<5;i++)
        //        {
        //            Console.WriteLine("red");
        //        }
        //    }
        //}



        //thread
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Fruits));
            t1.Start();
            Thread t2=new Thread(new ThreadStart(Color));
            t2.Start();
            Console.ReadLine();
        }

        public static void Fruits() 
        {
           for (int i = 0; i < 5; i++)
           {
                    Console.WriteLine("Apple");
                    Task.Delay(100).Wait();
            }
            
        }

        public static void Color()

        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("red");
            }
        }
    }




}



