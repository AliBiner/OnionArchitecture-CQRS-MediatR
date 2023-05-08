using OnionArchitecture_CQRS_MediatR.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture_CQRS_MediatR.Domain.Entities
{
    public class Product: BaseEntity
    {
        public String Name { get; set; }
        public decimal Value { get; set; }
        public int Quantity { get; set; }
    }
}
