﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce
{
    class Product
    {
        //Ürünlere ait hangi bilgilerin gireceği tanımlandı
        public int Id { get; set; }
        public string Category { get; set; }
        public string ProductName { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public int UnitInStock { get; set; }

    }
}
