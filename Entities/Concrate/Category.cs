﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate
{
    public class Category: IEntitiy
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}
