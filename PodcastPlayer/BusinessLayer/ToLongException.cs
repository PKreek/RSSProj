using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ToLongException : Exception
    {
        public ToLongException() : base("Kategorin får inte vara så lång")
        {

        }
        public ToLongException(string message) : base(message)
        {

        }
    }
}
