﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DetailsEmployee.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Qualification { get; set; }
        public string IsEmployeed { get; set; }
        public string NoticePeriod { get; set; }
        public float CurrentCTC { get; set; }
    }
}
