using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture_CQRS_MediatR.Application.Dto
{
    public class ProductViewDto
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
    }
}
