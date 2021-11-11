using System;

namespace EmployeeLibrary
{
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Basic { get; set; }
        public int Hra { get; set; }
        public int Da { get; set; }
        public double Salary { get; private set; }
        public double HrSalary { get; set; }
        public double DeveloperSalary { get; set; }

        public Employee()
        {

        }
        public Employee(string name, int id, double basic, int hra, int da)
        {
            this.Name = name;
            this.Id = id;
            this.Basic = basic;
            this.Hra = hra;
            this.Da = da;
            //Console.WriteLine($"name:: {name}");

        }

        public virtual void CalculateSalary()
        {
            this.Salary = this.Basic + this.Hra + this.Da;
        }

    }

}
