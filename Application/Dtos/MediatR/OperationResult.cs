using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.MediatR
{
    public class OperationResult<T>
    {
        public T? Result { get; set; }
        public required bool IsSuccess { get; set; }
        public string? ErrorMessage { get; set; }
    }
}
