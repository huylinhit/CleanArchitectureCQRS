using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string key, object value) : base($"{key} {value} was not found ")
        { 

        }
    }
}
