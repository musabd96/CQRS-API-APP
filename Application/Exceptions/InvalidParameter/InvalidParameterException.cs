using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions.InvalidParameter
{
    public class InvalidParameterException : BaseCustomException
    {
        public InvalidParameterException(string parameterName)
            : base($"Invalid parameter {parameterName}.")
        {
        }
    }
}
