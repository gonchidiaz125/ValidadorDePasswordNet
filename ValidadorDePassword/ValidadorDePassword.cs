using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorDePassword
{
    public class ValidadorDePassword
    {

        public class ResultadoDeRegla
        {
            public string Regla { get; set; }
            public bool Valida { get; set; }

            public int NumeroRegla { get; set; }
        }

        public class ResultadoValidacion
        {
            public bool Valida { get; set; }

            public List<ResultadoDeRegla> Reglas { get; set; }

            public ResultadoValidacion()
            {
                Reglas = new List<ResultadoDeRegla>();
            }
        }

        public bool ValidarLargoMinimo(string password)
            {
            var largoMinimo = 5;
            if (password.Length >= largoMinimo)
            {
            return true;
            }
            else
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
        
        public bool ValidarDebeContenerAlgunNumero(string password) 
        {
            foreach (var c in password) 
            {
                if (char.IsDigit(c))
                {
                    return true; 
                }
            }
            return false;
        }

        public bool ValidarDebeContenerAlgunaMinuscula(string password)
        {
            foreach (var c in password) 
            {
                if (char.IsLower(c))
                { 
                    return true; 
                }
            }
            return false;
        }

        public bool ValidarDebeContenerAlgunaMayuscula(string password)
        {
            foreach(var c in password)
            { if (char.IsUpper(c))
                { 
                    return true; 
                }
            }
            return false;
        }

        public bool ValidarDebeContenerAlgunCaracterEspecial(string password)
        {
            foreach (var c in password) 
            {
                if (char.IsLetterOrDigit(c) == false)
                { 
                    return true; 
                }
            }
            return false;
        }

        public ResultadoValidacion ValidarPasswordConTodasSusReglas(string password)
        {
            var resLargoMinimo = ValidarLargoMinimo(password);
            var resLargoMaximo = ValidarLargoMaximo(password);
            var resContieneNumero = ValidarDebeContenerAlgunNumero(password);
            var resContieneMinuscula = ValidarDebeContenerAlgunaMinuscula(password);
            var resContieneMayuscula = ValidarDebeContenerAlgunaMayuscula(password);
            var resContieneCaracterEspecial = ValidarDebeContenerAlgunCaracterEspecial(password);

            bool resultadoFinal;
            if(resLargoMinimo && resLargoMaximo && resContieneNumero && resContieneMinuscula && resContieneMayuscula && resContieneCaracterEspecial )
            {
                resultadoFinal = true;
            }else
            {
                resultadoFinal=false;
            }

            var resultadoDeValidacion = new ResultadoValidacion();
            resultadoDeValidacion.Valida = resultadoFinal;

            var reglaLargoMinimo = new ResultadoDeRegla() { Regla = "El largo de la contraseña debe ser al menos de 5 caracteres", Valida = resLargoMinimo, NumeroRegla = 0};
            resultadoDeValidacion.Reglas.Add(reglaLargoMinimo);
            var reglaLargoMaximo = new ResultadoDeRegla() { Regla = "El largo de la contraseña debe contener menos de 20 caracteres", Valida = resLargoMaximo, NumeroRegla = 1 };
            resultadoDeValidacion.Reglas.Add(reglaLargoMaximo);
            var reglaContieneNumero = new ResultadoDeRegla() { Regla = "La contraseña debe contener al menos un caracter numerico", Valida = resContieneNumero, NumeroRegla = 2 };
            resultadoDeValidacion.Reglas.Add(reglaContieneNumero);
            var reglaContieneMinuscula = new ResultadoDeRegla() { Regla = "La contraseña debe contener al menos un caracter letra en minuscula", Valida = resContieneMinuscula, NumeroRegla = 3 };
            resultadoDeValidacion.Reglas.Add(reglaContieneMinuscula);
            var reglaContieneMayuscula = new ResultadoDeRegla() { Regla = "La contraseña debe contener al menos un caracter letra en mayuscula", Valida = resContieneMayuscula, NumeroRegla = 4 };
            resultadoDeValidacion.Reglas.Add(reglaContieneMayuscula);
            var reglaContieneCaracterEspecial = new ResultadoDeRegla() { Regla = "La contraseña debe contener al menos un caracter especial", Valida = resContieneCaracterEspecial, NumeroRegla = 5 };
            resultadoDeValidacion.Reglas.Add(reglaContieneCaracterEspecial);

            return resultadoDeValidacion;

        }


    }


}
