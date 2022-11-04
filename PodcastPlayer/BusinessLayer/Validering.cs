using BusinessLayer.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Validering
    {

        public Validering()
        {

        }

        public void isEmpty(string field)
        {
            if (field.Equals("")) 
            {
                throw new EmptyException();
            }
        }

        public void toLong(string field)
        {
            if (field.Length > 25)
            {
                throw new ToLongException();
            }
        }
    }

}
