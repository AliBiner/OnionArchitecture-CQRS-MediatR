using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture_CQRS_MediatR.Application.Exceptions
{
    public class ValidationExceptions: Exception
    {
        public ValidationExceptions() : base("Validation error occured")
        {
            
        }

        public ValidationExceptions(String Message) : base(Message)
        {

        }

        public ValidationExceptions(Exception ex): this(ex.Message)
        {
            
        }
    }
}
