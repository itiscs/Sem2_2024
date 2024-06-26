﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeApp
{
    public class Product
    {

        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public DateTime Date1 { get; set; }
        public bool Own { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            return $"Товар {ProductId} - {Name} {Price} {Count} {Own} {Date1}";
        }

    }
}
