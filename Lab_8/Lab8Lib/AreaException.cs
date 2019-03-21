using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Lib
{
    public class AreaException : Exception
    {
        public AreaException(string message) : base(message) { }
    }

    public class InvalidCountryException : Exception
    {
        public InvalidCountryException() : base("Неправильна країна.") { }
    }

    public class InvalidHeightException : AreaException
    {
        public InvalidHeightException() : base("Неправильна модель процесора.") { }
    }
}