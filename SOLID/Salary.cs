using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    //internal class Salary:ISalary
    //{
    //    public string salary {  get; set; }
    //    public string bonus {  get; set; }
    //    public string pension {  get; set; }
    //    public string Pf { get; set; }
    //    public int calcsalary(int number_of_hours)
    //    {

    //        int salary = 1000 * number_of_hours;
    //        return salary;
    //    }  
    //    public int csalary(int number_of_hours)
    //    {
    //        return number_of_hours * 500;
    //    }

    //        //adding a func
    //        //adding  string emptype-violates open closed principle

    //    //adding isalary
    //    //    public int calcsalary(int number_of_hours,string emptype)
    //    //{
    //    //    if (emptype == "f")
    //    //    {
    //    //        int salary = 1000 * number_of_hours;
    //    //        return salary;
    //    //    }
    //    //    else if(emptype == "p") 
    //    //    {
    //    //        int salary = 500 * number_of_hours;
    //    //        return salary;
    //    //    }
    //    //    return 0;
    //    //}
    //}



    //nummber of subjects
    //public class Subjects:Lab
    //{
    //             public int SubjectId { get; set; }
    //             public string SubjectName { get; set; }
    //             public string TeacherName { get; set; }
    //              public int SubjectHours(int hours)
    //              {
    //                  return 1 * hours;
    //              }
    //             public int LabHours(int hours)
    //             {
    //                   return 3 * hours;
    //             }



    //}

    //liskove

    //public interface IFruit
    //{
    //     string color();
    //}

    //interface seggreagtion
    public class Salary :  ISalary //for partimers no need for inteface like bonus and pf
    {
        public int csalary(int hours)
        {
            return 500 * hours;
        }

        //public int Getbonus()
        //{
        //    return 20000;
        //}

        //public int pfbonus()
        //{
        //    return 1000;
        //}
    }
    public class Permanent : ISalary, Ibenefits
    {
        public int csalary(int hours)
        {
            return 1000 * hours;
        }

        public int Getbonus()
        {
            throw new NotImplementedException();
        }

        public int pfbonus()
        {
            throw new NotImplementedException();
        }
    }
        
    
}
