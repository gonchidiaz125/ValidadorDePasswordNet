using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorDePassword
{
    public class ValidadorDePassword
    {
        public bool ValidarLargoMinimo(string password) 
        {
            var largoMinimo = 3;
            if (password.Length >= largoMinimo)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
