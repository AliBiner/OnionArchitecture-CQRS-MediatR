using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture_CQRS_MediatR.Application.Wrapper
{
    public class PagedResponse<T>: ServiceResponse<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public PagedResponse(T value, int pagenumber, int pagesize): base(value)
        {
            PageNumber= pagenumber;
            PageSize=pagesize;
        }
        
    }
}
