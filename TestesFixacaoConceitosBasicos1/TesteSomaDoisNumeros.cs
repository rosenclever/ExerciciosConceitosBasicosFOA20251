using FixacaoConceitosBasicos1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesFixacaoConceitosBasicos1
{
    [TestClass]
    public class TesteSomaDoisNumeros
    {
        [TestMethod]
        private void TesteSoma()
        {
            int a = 1;
            int b = 2;
            int resultado = a + b;
            Assert.AreEqual(SomaDoisNumeros.Somar(a, b), resultado);
        }
    }
}
