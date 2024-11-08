using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    //public interface ISalary
    //{
    //    int csalary(int hours);
       
    //}

        //public interface Lab
        // {
        // int LabHours(int hours);
        // }


     //interface seggregration

    public interface ISalary
    {
        int csalary(int hours);
       // int Getbonus();
        //int pfbonus();
    }
    public interface Ibenefits
    {
        int Getbonus();
        int pfbonus();

    }
    
}
