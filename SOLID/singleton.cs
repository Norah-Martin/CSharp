using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    //design pattern
    public sealed class singleton
    {

        public void print()
        {
            Console.WriteLine("print--");
        }
        public static singleton s = null;
        public static singleton instance()
        {
            if (s == null)
            {
                s = new singleton();
            }
            return s;
        }

      

    }
    //main
    public class Main
    {
         static void main(string[] args)
        {
            singleton s = new singleton();
            s.print();

            singleton s2 = new singleton();
            s2.print();

        }
    }



}
