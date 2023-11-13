﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CarRental.Data.Model
{
    public class CarModel
    {
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public string LicensePlate { get; set; }
        public string Description { get; set; }
        public string Fuel { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public int Status { get; set; }
    }
}