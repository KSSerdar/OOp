using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    public class ClassB : BaseModel
    {
        public override void Print()
        {
            Console.WriteLine("Called ClassB");
        }
    }
}
