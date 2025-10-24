using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_24._10._25_
{
    class Manager : Employee
    {
        public decimal Bonus { get; set; }

        public Manager(string name, decimal baseSalary, decimal bonus)
            : base(name, baseSalary)
        {
            Bonus = bonus;
        }

        public override void CalculateSalary()
        {
            BaseSalary +=  Bonus;
            Console.WriteLine(BaseSalary); ;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Developer: {Name}, Total Salary: {BaseSalary}:C");
        }
    }
}
