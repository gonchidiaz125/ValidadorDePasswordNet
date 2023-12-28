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
            var password = "123";
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
    }
}
