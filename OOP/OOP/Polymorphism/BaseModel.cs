﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    public class BaseModel
    {
        public virtual void Print()
        {
            Console.WriteLine("Called BaseModel");
        }
    }
}
