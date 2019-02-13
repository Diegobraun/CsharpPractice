using Microsoft.VisualStudio.TestTools.UnitTesting;
using RefactoringANDTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringANDTests.Tests
{
    [TestClass()]
    public class CalcTests
    {
        [TestMethod()]
        public void SomarTest()
        {
            var c = new Calc();
            var x = 10;
            var y = 20;
            var esperado = 30;
            var atual = c.Somar(x, y);
            Assert.AreEqual(atual, esperado);
        }
    }
}