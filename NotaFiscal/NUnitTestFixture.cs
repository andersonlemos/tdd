using System;
using System.Collections;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;

namespace NotaFiscal
{
    [TestFixture]
    public class NUnitTestFixture
    {
        [Test]
        public void DeveGerarNfComValorDeImpostoDescontado()
        {
            //GeradorDeNotaFiscal gerador=new GeradorDeNotaFiscal();

            //Pedido pedido=new Pedido("Mauricio",1000,1);

            //NotaFiscal nf = gerador.Gera(pedido);


            //Assert.AreEqual(1000 * 0.94,nf.Valor,0.0001);

        }

        [Test]
        public void DevePersistirNotaFiscalGerada()
        {
            var dao = new Mock<NFDao>();
            GeradorDeNotaFiscal gerador=new GeradorDeNotaFiscal(dao.Object);

            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);


            dao.Verify(t=>t.Persiste(nf));
        }
    }
}

