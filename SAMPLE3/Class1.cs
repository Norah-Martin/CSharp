using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMPLE3
{

    //USER DEFINED EXCEPTION
    public class DivideByZero:Exception
    {
        public DivideByZero(Exception e)
        {
            Console.WriteLine("---error---");
            Console.WriteLine(e.StackTrace);
        }

    }
}
