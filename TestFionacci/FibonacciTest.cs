
using SerieFibonacci;
using NUnit.Framework;


namespace TestFionacci

{
    public class FibonacciTest
    {
        [Test]
        public void FibonacciTest1()
        {
            //Arrange

            var fibo = new FiboSerie();

            //Act

            var result = fibo.calculo();

            //Aseert
            Assert.Equals(0,result);
            

        }
    }
}