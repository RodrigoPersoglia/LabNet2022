using System;

namespace LabNet2022.TP7.Domain.Exceptions
{
    public class NoExisteException : Exception
    {
        public NoExisteException(string message) : base(message)
        {

        }
    }
}
