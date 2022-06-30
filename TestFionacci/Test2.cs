using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerieFibonacci;
using NUnit.Framework;
using System.Linq;

namespace TestFionacci
{
    public class Test2
    {

        [TestCase(0,1)]
        [TestCase(1,1)]
        [TestCase(2,2)]
        [TestCase(3,3)]

        public void Serie_Elemento_IsValue(int n, int expec)
        {
            var seq = new Serie();
            var resultado = seq.ElementAt(n);
            Assert.AreEqual(expec, resultado);
        }


        /*
        [Test]
        public void Serie_FirstElement_IsOne()
        {

            var seq = new Serie();
            var resultado = seq.First();
            Assert.AreEqual(1, resultado);

        }

        [Test]

        public void Serie_SegundoElemento_EsUno()
        {

            var seq = new Serie();
            var resultado = seq.ElementAt(1);
            Assert.AreEqual(1, resultado);

        }

        [Test]
        public void Serie_TercerElemento_Es2()
        {
            var seq = new Serie();
            var resultado = seq.ElementAt(2);
            Assert.AreEqual(2, resultado);
        }


        */



    }
}
