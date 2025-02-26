using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FixacaoConceitosBasicos1.Model;

namespace TestesFixacaoConceitosBasicos1
{
    [TestClass]
    public class TesteCalculaAumento
    {
        [TestMethod]
        public void TesteCalculoAumento()
        {
            double salario = 1000;
            double aumento = 0.1;
            double salarioAumentado = salario + (salario * aumento);
            Assert.AreEqual(CalculaAumento.Calcular(salario, aumento), salarioAumentado);
        }
    }
}
