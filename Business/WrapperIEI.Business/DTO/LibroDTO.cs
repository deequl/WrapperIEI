﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrapperIEI.DTO
{
    public class LibroDTO
    {
        public string Provider { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
    }
}
