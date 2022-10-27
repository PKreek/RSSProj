using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Controllers
{
    public class EmptyException : Exception
    {
        public EmptyException() : base("Rutan kan inte vara tooooom")
        {

        }
        public EmptyException(string message) : base(message)
        {

        }

    }
}
