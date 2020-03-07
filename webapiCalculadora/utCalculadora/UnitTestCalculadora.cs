using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using webapiCalculadora.Controllers;

namespace utCalculadora
{
    [TestClass]
    public class UnitTestCalculadora
    {
        [TestMethod]
        public void TestAddGet1()
        {
            //Arrange
            CalculatorController calc = new CalculatorController();
            int numa = 3;
            int numb = 4;
            int numres = 7;

            //Act = Ejecucion
            int result = calc.Add(numa, numb);

            //Assert =Verification
            Assert.AreEqual(numres, result);
        }
    }
}
