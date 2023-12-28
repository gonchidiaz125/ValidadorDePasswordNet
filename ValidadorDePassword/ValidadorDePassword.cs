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
        
        public bool ValidarLargoMaximo(string password)
        {
            var largoMaximo = 20;
            if (password.Length <= largoMaximo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }


}
