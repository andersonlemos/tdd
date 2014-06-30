using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ConversorDeNumeroRomano
{
    [TestFixture]
     public   class TestarNumeroRomano
        {
            [Test]
            public void DeveEntenderOSimboloI()
            {
                var romano = new ConversorDeNumeroRomano();

                int numero = romano.Converte("I");

                Assert.AreEqual(1, numero);

            }
            [Test]
            public void DeveEntenderOSimboloV()
            {
                var romano = new ConversorDeNumeroRomano();

                int numero = romano.Converte("V");

                Assert.AreEqual(5, numero);

            }
            [Test]
            public void DeveEntenderOSimboloX()
            {
                var romano = new ConversorDeNumeroRomano();

                int numero = romano.Converte("X");

                Assert.AreEqual(10, numero);

            }
            [Test]
            public void DeveEntenderOSimboloL()
            {
                var romano = new ConversorDeNumeroRomano();

                int numero = romano.Converte("L");

                Assert.AreEqual(50, numero);

            }
            [Test]
            public void DeveEntenderOSimboloC()
            {
                var romano = new ConversorDeNumeroRomano();

                int numero = romano.Converte("C");

                Assert.AreEqual(100, numero);

            }
            [Test]
            public void DeveEntenderOSimboloD()
            {
                var romano = new ConversorDeNumeroRomano();

                int numero = romano.Converte("D");

                Assert.AreEqual(500, numero);

            }
            [Test]
            public void DeveEntenderOSimboloM()
            {
                var romano = new ConversorDeNumeroRomano();

                int numero = romano.Converte("M");

                Assert.AreEqual(1000, numero);

            }
            [Test]
            public void DeveEntenderOSimboloII()
            {
                var romano = new ConversorDeNumeroRomano();

                int numero = romano.Converte("II");

                Assert.AreEqual(2, numero);

            }
            [Test]
            public void DeveEntenderOSimboloVV()
            {
                var romano = new ConversorDeNumeroRomano();

                int numero = romano.Converte("VV");

                Assert.AreEqual(10, numero);

            }
            [Test]
            public void DeveEntenderOSimboloXX()
            {
                var romano = new ConversorDeNumeroRomano();

                int numero = romano.Converte("XX");

                Assert.AreEqual(20, numero);

            }
            [Test]
            public void DeveEntenderQuatroSimbolosDoisADoisComoXXII()
            {
                var romano = new ConversorDeNumeroRomano();

                int numero = romano.Converte("XXII");

                Assert.AreEqual(22, numero);

            }
            [Test]
            public void DeveEntenderNumerosComoIX()
            {
                var romano = new ConversorDeNumeroRomano();

                int numero = romano.Converte("IX");

                Assert.AreEqual(9, numero);

            }
            [Test]
            public void DeveEntenderNumerosComplexosComoXXIV()
            {
                var romano = new ConversorDeNumeroRomano();

                int numero = romano.Converte("XXIV");

                Assert.AreEqual(24, numero);

            }
        }
}
