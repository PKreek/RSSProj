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

        public bool toLong(string field)
        {
            bool result = false;
            if(field.Length > 25)
            {
                result = true;
            }

            return result; 
        }

    }

}
