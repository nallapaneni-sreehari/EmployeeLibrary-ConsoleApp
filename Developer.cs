using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Developer: Employee
    {

        public double incentive { get; set; }
        public Developer()
        {

        }
        public Developer(string name, int id, double basic, int hra, int da,double incentive)
            :base(name, id, basic, hra, da)
        {
            this.incentive = incentive;
        }
        public override void CalculateSalary()
        {
            this.DeveloperSalary = this.Basic + this.Hra + this.Da + this.incentive;
        }
    }
}
