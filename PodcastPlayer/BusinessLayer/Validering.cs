using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class Validering
    {

        public Validering()
        {

        }

        public bool isEmpty(string field)
        {


            bool result = false;

            if (field == null)
            {
                result = true;
            }

            return result;
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
