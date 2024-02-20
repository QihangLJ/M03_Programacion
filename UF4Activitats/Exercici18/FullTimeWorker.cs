﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObject
{
    public class FullTimeWorker : AWorker
    {
        private int hoursWorked;

        public int HoursWorked { get; set; }

        public FullTimeWorker(string name, double salaryRate, int hoursWorked) : base(name, salaryRate) 
        {
            HoursWorked = hoursWorked;
        
        }

        public override double ComputePay()
        {
            return HoursWorked * SalaryRate;
        }
    }
}
