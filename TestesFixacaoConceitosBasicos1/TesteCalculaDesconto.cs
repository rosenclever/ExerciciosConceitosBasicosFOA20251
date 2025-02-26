using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FixacaoConceitosBasicos1.Model;

namespace TestesFixacaoConceitosBasicos1
{
    [TestClass]
    public class TesteCalculaDesconto
    {
        [TestMethod]
        public void TesteCalculoDesconto()
        {
            double valor = 100;
            double desconto = 0.1;
            double valorComDesconto = valor - (valor * desconto);
            Assert.AreEqual(CalculaDesconto.Calcular(valor, desconto), valorComDesconto);
        }
    }
}
