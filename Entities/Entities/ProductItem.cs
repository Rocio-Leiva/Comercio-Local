﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class ProductItem 
    {
        public ProductItem() 
        {
            IsActive = true;
            IsPublic = true;
        }
        public int Id { get; set; }
        public Guid IdWeb { get; set; }
        public string NameProduct { get; set; }
        public string Brand { get; set; }
        public int Weight { get; set; }
        public string Stock { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; private set; }
        public bool IsPublic { get; private set; }
        public decimal RawPrice { get; set; }
    }
}