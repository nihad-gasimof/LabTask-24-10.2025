using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_24._10._25_
{
    class Developer : Employee
    {
        public int CompletedProjects { get; set; }
        public decimal PaymentPerProject { get; set; }

        public Developer(string name, decimal baseSalary, int completedProjects, decimal paymentPerProject)
            : base(name, baseSalary)
        {
            CompletedProjects = completedProjects;
            PaymentPerProject = paymentPerProject;
        }

        public override void CalculateSalary()
        {
          BaseSalary+= (CompletedProjects * PaymentPerProject);
            Console.WriteLine(BaseSalary); ;


        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Developer: {Name}, Total Salary: {BaseSalary}:C");
        }
    }
}
