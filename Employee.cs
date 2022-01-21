using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class Employee : Person
    {
        public String Department { get; set; }
        public String Location { get; set; }
        public double BasicSalary { get; set; }
        public double DailyAllowance { get; set; }

        public Employee(String Fname, String Lname, String Email, String Contact, String Dept, String loc, double bSal, double DA):base(Fname, Lname, Email, Contact)
        {
            this.Department = Dept;
            this.Location = loc;
            this.BasicSalary = bSal;
            this.DailyAllowance = DA;
        }

        
        //virtual allows to implement method as well as allow overriding in derived class 
        public virtual double ComputePay()
        {
            return BasicSalary + DailyAllowance * 30;
        }

        public override string ToString()
        {
            return base.ToString()+"Department: "+this.Department+"Location: "+this.Location;
        }
    }
}
