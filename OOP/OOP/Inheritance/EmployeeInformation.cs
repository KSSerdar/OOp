using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class EmployeeInformation:BaseModel
    {
        public EmployeeInformation(string description,int id,string name)
        {
            Description = description;
            ID= id;
            Name= name;
        }

        public string Description { get; set; }
        public void Print()
        {
            Console.WriteLine(Name+" "+ID+" "+Description);
        }
    }
}
