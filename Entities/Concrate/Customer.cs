using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate
{
    public class Customer: IEntitiy
    {
        //sonradan ekledim
        public int Id { get; set; }

        public string CostumerId{ get; set; }

        public string ContactName { get; set; }

        public string CompanyName { get; set; }

        public string City { get; set; }
    
    }
}
