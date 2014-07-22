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

        private ConversorDeNumeroRomano romano;

        [SetUp]
       public void InicializarNumeroRomano()
        {
            this.romano=new ConversorDeNumeroRomano();
        }

        [Test]
            public void DeveEntenderOSimboloI()
            {
            
                Assert.AreEqual(1,  romano.Converte("I"));

            }
            [Test]
            public void DeveEntenderOSimboloV()
            {
                
              Assert.AreEqual(5, romano.Converte("V"));

            }
            [Test]
            public void DeveEntenderOSimboloX()
            {
              
                Assert.AreEqual(10, romano.Converte("X"));

            }
            [Test]
            public void DeveEntenderOSimboloL()
            {
            
                Assert.AreEqual(50, romano.Converte("L"));

            }
            [Test]
            public void DeveEntenderOSimboloC()
            {
             
             Assert.AreEqual(100,  romano.Converte("C"));

            }
            [Test]
            public void DeveEntenderOSimboloD()
            {
               
                Assert.AreEqual(500, romano.Converte("D"));

            }
            [Test]
            public void DeveEntenderOSimboloM()
            {
              
              Assert.AreEqual(1000, romano.Converte("M"));

            }
            [Test]
            public void DeveEntenderOSimboloII()
            {
               
                Assert.AreEqual(2, romano.Converte("II"));

            }
            [Test]
            public void DeveEntenderOSimboloVV()
            {
               
              Assert.AreEqual(10, romano.Converte("VV"));

            }
            [Test]
            public void DeveEntenderOSimboloXX()
            {
               
               
                Assert.AreEqual(20,  romano.Converte("XX"));

            }
            [Test]
            public void DeveEntenderQuatroSimbolosDoisADoisComoXXII()
            {
              
                Assert.AreEqual(22, romano.Converte("XXII"));

            }
            [Test]
            public void DeveEntenderNumerosComoIX()
            {
              
                Assert.AreEqual(9, romano.Converte("IX"));

            }
            [Test]
            public void DeveEntenderNumerosComplexosComoXXIV()
            {
               
              Assert.AreEqual(24, romano.Converte("XXIV"));

            }
        }
}
