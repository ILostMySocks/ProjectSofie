﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHealthApp.Entities
{
    public class Food : BaseEntity
    {
        public string FoodName { get; set; }
        public int CalorieCount { get; set; }
        public List<Day> Days { get; set; }

    }
}
