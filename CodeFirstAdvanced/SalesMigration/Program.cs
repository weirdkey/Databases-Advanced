﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesMigration
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SalesContext();
            context.Database.Initialize(true);
        }
    }
}
