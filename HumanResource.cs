using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class HumanResource : Employee
    {

        public double gratuty { get; set; }
        public HumanResource()
        {

        }
        public HumanResource(string name, int id, double basic, int hra, int da,double gratuty) : base(name, id, basic, hra, da)
        {
            this.gratuty = gratuty;
        }
        public override void CalculateSalary()
        {
            this.HrSalary = this.Basic + this.Hra + this.Da + this.gratuty;
        }
    }
}
