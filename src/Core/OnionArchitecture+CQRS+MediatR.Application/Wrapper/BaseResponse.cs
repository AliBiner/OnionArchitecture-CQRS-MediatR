using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture_CQRS_MediatR.Application.Wrapper
{
    public class BaseResponse
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
    }
}
