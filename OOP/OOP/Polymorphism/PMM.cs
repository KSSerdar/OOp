using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    public class PMM:BaseModel
    {
        public override void Print()
        {
            Console.WriteLine("Called PMM");
        }
    }
}
