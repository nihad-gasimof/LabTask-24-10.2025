using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_24._10._25_
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public abstract void MakeSound(string name);
    }
}
