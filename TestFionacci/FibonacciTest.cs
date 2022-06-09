using Xunit;
using SerieFibonacci;


namespace TestFionacci

{
    public class FibonacciTest
    {
        [Fact]
        public void FibonacciTest1()
        {
            var fibo = new FiboSerie();

            //Act

            var result = fibo.calculo();

            //Aseert
            Assert.Equal(0,result);
            

        }
    }
}