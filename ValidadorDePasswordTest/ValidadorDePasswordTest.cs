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


    }
}
