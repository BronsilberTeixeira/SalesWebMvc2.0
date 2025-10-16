using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class DbCourrencyException : ApplicationException
    {
        public DbCourrencyException(string message) : base(message)
        {
        }
    }
}
