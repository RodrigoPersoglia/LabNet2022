using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabNet2022.TP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2022.TP2.Tests
{
    [TestClass()]
    public class LabNet2022Tests
    {
        [TestMethod()]
        public void DivisionTest()
        {
            int dividendo = 5;
            int divisor = 2;
            double valorEsperado = 2.5;

            var division = new LabNet2022();
            double resultado = division.Division(dividendo, divisor);
            Assert.AreEqual(valorEsperado, resultado);
        }
    }
}