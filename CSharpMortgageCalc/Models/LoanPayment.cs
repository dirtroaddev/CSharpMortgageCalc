﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpMortgageCalc.Models
{
    public class LoanPayment
    {

        public int Month { get; set; }
        public decimal Payment { get; set; }
        public decimal MonthlyPrinciple { get; set; }
        public decimal MonthlyInterest { get; set; }
        public decimal  TotalInterest { get; set; }
        public decimal Balance { get; set; }

    }
}
