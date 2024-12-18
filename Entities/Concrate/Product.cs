﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate
{
    public class Product: IEntitiy
    {
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public string ProductName { get; set; }

        //ismini güncelledim
        public short UnitsInStock { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
