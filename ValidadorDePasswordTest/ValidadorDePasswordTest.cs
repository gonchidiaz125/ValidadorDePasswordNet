using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorDePasswordTest
{
    [TestClass]
    public class ValidadorDePasswordTest
    {


        [TestMethod]
        public void ValidarLargoMinimo_DebeRetornarTrue()
        {
            var password = "12345";
            var validador = new ValidadorDePassword.ValidadorDePassword();

            var result = validador.ValidarLargoMinimo(password);

            Assert.IsTrue(result);

        }
        [TestMethod]
        public void ValidarLargoMinimo_DebeRetornarFalse()
        {
            var password = "12";
            var validador = new ValidadorDePassword.ValidadorDePassword();

            var result = validador.ValidarLargoMinimo(password);

            Assert.IsFalse(result);

        }
        [TestMethod]
        public void ValidarLargoMaximo_DebeRetornarTrue()
        {
            var password = "01234567890123456789";
            var validador = new ValidadorDePassword.ValidadorDePassword();
            var result = validador.ValidarLargoMaximo(password);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValidarLargoMaximo_DebeRetornarFalse()
        {
            var password = "01234567890123456789000";
            var validador = new ValidadorDePassword.ValidadorDePassword();
            var result = validador.ValidarLargoMaximo(password);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidarDebeContenerAlgunNumero_DebeRetornarTrue()
        {
            var password = "1234";
            var validador = new ValidadorDePassword.ValidadorDePassword();
            var result = validador.ValidarDebeContenerAlgunNumero(password);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValidarDebeContenerAlgunNumero_DebeRetornarFalse()
        {
            var password = "abcd";
            var validador = new ValidadorDePassword.ValidadorDePassword();
            var result = validador.ValidarDebeContenerAlgunNumero(password);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void ValidarDebeContenerAlgunaMinuscula_DebeRetornarTrue()
        {
            var password = "aBCD";
            var validador = new ValidadorDePassword.ValidadorDePassword();
            var result = validador.ValidarDebeContenerAlgunaMinuscula(password);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidarDebeContenerAlgunaMinuscula_DebeRetornarFalse()
        {
            var password = "ABCD";
            var validador = new ValidadorDePassword.ValidadorDePassword();
            var result = validador.ValidarDebeContenerAlgunaMinuscula(password);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void ValidarDebeContenerAlgunaMayuscula_DebeRetornarTrue()
        {
            var password = "ABCD";
            var validador = new ValidadorDePassword.ValidadorDePassword();
            var result = validador.ValidarDebeContenerAlgunaMayuscula(password);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidarDebeContenerAlgunaMayuscula_DebeRetornarFalse()
        {
            var password = "abcd";
            var validador = new ValidadorDePassword.ValidadorDePassword();
            var result = validador.ValidarDebeContenerAlgunaMayuscula(password);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidarDebeContenerAlgunCaracterEspecial_DebeRetornarTrue()
        {
            var password = "abc!!";
            var validador = new ValidadorDePassword.ValidadorDePassword();
            var result = validador.ValidarDebeContenerAlgunCaracterEspecial(password);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidarDebeContenerAlgunCaracterEspecial_DebeRetornarFalse()
        {
            var password = "abcd";
            var validador = new ValidadorDePassword.ValidadorDePassword();
            var result = validador.ValidarDebeContenerAlgunCaracterEspecial(password);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidarPasswordConTodasSusReglas_DebeRetornarTrue()
        {
            var password = "ABCdef1.";
            var validador = new ValidadorDePassword.ValidadorDePassword();
            var result = validador.ValidarPasswordConTodasSusReglas(password);
            Assert.IsTrue(result.Valida);

            // Verificar que cada regla también sea valida

            foreach (var regla in result.Reglas)
            {
                Assert.IsTrue(regla.Valida);
            }
        }

        [TestMethod]
        public void ValidarPasswordConTodasSusReglas_DebeRetornarFalsoPorLargoMinimo()
        {
            //var password = "aB1.";
            var password = "aB1.";
            var validador = new ValidadorDePassword.ValidadorDePassword();
            var result = validador.ValidarPasswordConTodasSusReglas(password);
            Assert.IsFalse(result.Valida);

            // Verificar que cada regla también sea valida

            foreach (var regla in result.Reglas)
            {
                if  (regla.Regla == "El largo de la contraseña debe ser al menos de 5 caracteres")
                {
                    Assert.IsFalse(regla.Valida);
                } 
                else
                {
                    Assert.IsTrue(regla.Valida);
                }
                
            }
        }

        [TestMethod]
        public void ValidarPasswordConTodasSusReglas_DebeRetornarFalsoPorLargoMaximo()
        {
            
            var password = "aB1.01236547890123456";
            var validador = new ValidadorDePassword.ValidadorDePassword();
            var result = validador.ValidarPasswordConTodasSusReglas(password);
            Assert.IsFalse(result.Valida);

            // Verificar que cada regla también sea valida

            foreach (var regla in result.Reglas)
            {
                if (regla.Regla == "El largo de la contraseña debe contener menos de 20 caracteres")
                {
                    Assert.IsFalse(regla.Valida);
                }
                else
                {
                    Assert.IsTrue(regla.Valida);
                }

            }
        }

        [TestMethod]
        public void ValidarPasswordConTodasSusReglas_DebeRetornarFalsoPorFaltaDeCaracterNumerico()
        {

            var password = "aB!bbbbb";
            var validador = new ValidadorDePassword.ValidadorDePassword();
            var result = validador.ValidarPasswordConTodasSusReglas(password);
            Assert.IsFalse(result.Valida);

            // Verificar que cada regla también sea valida

            foreach (var regla in result.Reglas)
            {
                if (regla.Regla == "La contraseña debe contener al menos un caracter numerico")
                {
                    Assert.IsFalse(regla.Valida);
                }
                else
                {
                    Assert.IsTrue(regla.Valida);
                }

            }
        }
        [TestMethod]
        public void ValidarPasswordConTodasSusReglas_DebeRetornarFalsoPorFaltaDeLetraMinuscula()
        {

            var password = "AAABB!!111";
            var validador = new ValidadorDePassword.ValidadorDePassword();
            var result = validador.ValidarPasswordConTodasSusReglas(password);
            Assert.IsFalse(result.Valida);

            // Verificar que cada regla también sea valida

            foreach (var regla in result.Reglas)
            {
                if (regla.Regla == "La contraseña debe contener al menos un caracter letra en minuscula")
                {
                    Assert.IsFalse(regla.Valida);
                }
                else
                {
                    Assert.IsTrue(regla.Valida);
                }

            }
        }

        [TestMethod]
        public void ValidarPasswordConTodasSusReglas_DebeRetornarFalsoPorFaltaDeLetraMayuscula()
        {

            var password = "aaaaaabbb!!111";
            var validador = new ValidadorDePassword.ValidadorDePassword();
            var result = validador.ValidarPasswordConTodasSusReglas(password);
            Assert.IsFalse(result.Valida);

            // Verificar que cada regla también sea valida

            foreach (var regla in result.Reglas)
            {
                if (regla.Regla == "La contraseña debe contener al menos un caracter letra en mayuscula")
                {
                    Assert.IsFalse(regla.Valida);
                }
                else
                {
                    Assert.IsTrue(regla.Valida);
                }

            }
        }

        [TestMethod]
        public void ValidarPasswordConTodasSusReglas_DebeRetornarFalsoPorFaltaDeCaracterEspecial()
        {

            var password = "aaaaaabbbAA111";
            var validador = new ValidadorDePassword.ValidadorDePassword();
            var result = validador.ValidarPasswordConTodasSusReglas(password);
            Assert.IsFalse(result.Valida);

            // Verificar que cada regla también sea valida

            foreach (var regla in result.Reglas)
            {
                if (regla.Regla == "La contraseña debe contener al menos un caracter especial")
                {
                    Assert.IsFalse(regla.Valida);
                }
                else
                {
                    Assert.IsTrue(regla.Valida);
                }

            }
        }


        // Exito: pasa todas las reglas
        // Fracasos: por cada de uno de los motivos -> 
    }
}   

