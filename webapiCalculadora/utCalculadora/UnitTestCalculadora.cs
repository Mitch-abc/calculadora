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
        [TestMethod]
        public void TestAddGet2()
        {
            //Arrange
            CalculatorController calc = new CalculatorController();
            int numa = -3;
            int numb = -4;
            int numres = -7;

            //Act = Ejecucion
            int result = calc.Add(numa, numb);

            //Assert =Verification
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestMultiplyGet3()
        {
            //Arrange
            CalculatorController calc = new CalculatorController();
            int numa = 3;
            int numb = 4;
            int numres = 12;

            //Act = Ejecucion
            int result = calc.Multiply(numa, numb);

            //Assert =Verification
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestMultiplyGet4()
        {
            //Arrange
            CalculatorController calc = new CalculatorController();
            int numa = -3;
            int numb = -4;
            int numres = 12;

            //Act = Ejecucion
            int result = calc.Multiply(numa, numb);

            //Assert =Verification
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestMultiplyGet5()
        {
            //Arrange
            CalculatorController calc = new CalculatorController();
            int numa = -3;
            int numb = -4;
            int numc = -2;
            int numres = 12;

            //Act = Ejecucion
            int result = calc.Multiply(numa, numb, numc);

            //Assert =Verification
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestMultiplyGet6()
        {
            //Arrange
            CalculatorController calc = new CalculatorController();
            int numa = -3;
            int numb = 4;
            int numc = -2;
            int numres = -12;

            //Act = Ejecucion
            int result = calc.Multiply(numa, numb, numc);

            //Assert =Verification
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestAddGet7()
        {
            //Arrange
            CalculatorController calc = new CalculatorController();
            int numa = 3;
            int numb = 4;
            int numc = -2;
            int numres = 7;

            //Act = Ejecucion
            int result = calc.Add(numa, numb, numc);

            //Assert =Verification
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestAddGet8()
        {
            //Arrange
            CalculatorController calc = new CalculatorController();
            int numa = -3;
            int numb = 4;
            int numc = -2;
            int numres = 1;

            //Act = Ejecucion
            int result = calc.Add(numa, numb, numc);

            //Assert =Verification
            Assert.AreEqual(numres, result);
        }

    }
}
