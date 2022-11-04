﻿using embergyar.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace embergyar.Entities
{
    public class CarFactory : IToyFactory
    {
        public Toy CreateNew()
        {
            return new Car();

        }
    }
}
