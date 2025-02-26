using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FixacaoConceitosBasicos1.Model;

namespace TestesFixacaoConceitosBasicos1
{
    [TestClass]
    public class TesteMetrosMilimetros
    {
        [TestMethod]
        public void TesteConversao()
        {
            double metros = 1;
            double milimetros = metros * 1000;
            Assert.AreEqual(MetrosMilimetros.Converter(metros), milimetros);
        }
    }
}
