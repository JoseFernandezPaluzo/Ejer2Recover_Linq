﻿using Ejer3LinqPractice_SecondTry.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3LinqPractice_SecondTry
{
    public class Coche
    {
        public int id { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }
        public int? Year { get; set; }
        public string Color { get; set; }
        public Location Location { get; set; }
    }
}
