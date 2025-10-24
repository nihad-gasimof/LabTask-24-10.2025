using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_24._10._25_
{
    internal class Dog:Animal
    {
        public override void MakeSound(string name)
        {
            Console.WriteLine($"Name:{name} said Hav Hav");
        }
    }
}
