using System;

namespace SalesWebMvc.Services.Exception
{
    public class NotFoundException : AccessViolationException
    {
        public NotFoundException(string message) : base(message)
        {
        }
    }
}
