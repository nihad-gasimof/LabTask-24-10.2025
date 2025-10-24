using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_24._10._25_
{
    internal abstract class Employee
    {
        public string Name { get; set; }
        public decimal BaseSalary { get; set; }
        public Employee(string name,decimal basesalary) { 
            Name = name;
            BaseSalary = basesalary;
        }
        public abstract void CalculateSalary();
        public abstract void ShowInfo();
    }
}
