using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using client.localhost;


namespace LemonWay_Challenge.Tests
{
    [TestClass()]
    public class WebServiceLemonwayTests
    {
        [TestMethod()]
        public void FibonacciTest1()
        {

            //Arrange
            string expected = "-1";
            long input = -1;

            //Act
            WebServiceLemonway obj = new WebServiceLemonway();
            string actuel = obj.Fibonacci(input);

            //Assert
            Assert.AreEqual(expected, actuel);

        }
        [TestMethod()]
        public void FibonacciTest2()
        {

            //Arrange
            string expected = "-1";
            long input = 0;

            //Act
            WebServiceLemonway obj = new WebServiceLemonway();
            string actuel = obj.Fibonacci(input);

            //Assert
            Assert.AreEqual(expected, actuel);

        }

        [TestMethod()]
        public void FibonacciTest3()
        {

            //Arrange
            string expected = "218922995834555169026";
            long input = 99;

            //Act
            WebServiceLemonway obj = new WebServiceLemonway();
            string actuel = obj.Fibonacci(input);

            //Assert
            Assert.AreEqual(expected, actuel);

        }
        [TestMethod()]
        public void FibonacciTest4()
        {

            //Arrange
            string expected = "12586269025";
            long input = 50;

            //Act
            WebServiceLemonway obj = new WebServiceLemonway();
            string actuel = obj.Fibonacci(input);

            //Assert
            Assert.AreEqual(expected, actuel);

        }
        [TestMethod()]
        public void FibonacciTest5()
        {

            //Arrange
            string expected = "-1";
            long input = 101;

            //Act
            WebServiceLemonway obj = new WebServiceLemonway();
            string actuel = obj.Fibonacci(input);

            //Assert
            Assert.AreEqual(expected, actuel);

        }
        [TestMethod()]
        public void XmlToJasonTest()
        {

            //Arrange
            string expected = "{\"foo\":\"bar\"}";
            string input = ("<foo>bar</foo>");

            //Act
            WebServiceLemonway obj = new WebServiceLemonway();
            string actuel = obj.XmlToJson(input);

            //Assert
            Assert.AreEqual(expected, actuel);

        }

        [TestMethod()]
        public void XmlToJasonWarningTest()
        {

            //Arrange
            string expected = "Bad Xml format";
            string input = ("<foo>hello</bar>");

            //Act
            WebServiceLemonway obj = new WebServiceLemonway();
            string actuel = obj.XmlToJson(input);

            //Assert
            Assert.AreEqual(expected, actuel);

        }
    }
}