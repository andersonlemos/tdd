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
        //[Test]
        //public void DeveGerarNfComValorDeImpostoDescontado()
        //{
        //    //GeradorDeNotaFiscal gerador=new GeradorDeNotaFiscal();

        //    //Pedido pedido=new Pedido("Mauricio",1000,1);

        //    //NotaFiscal nf = gerador.Gera(pedido);


        //    //Assert.AreEqual(1000 * 0.94,nf.Valor,0.0001);

        //}

        //[Test]
        //public void DevePersistirNotaFiscalGerada()
        //{
        //    //var dao = new Mock<NFDao>();

        //    //GeradorDeNotaFiscal gerador=new GeradorDeNotaFiscal(dao.Object);

        //    //Pedido pedido = new Pedido("Mauricio", 1000, 1);

        //    //NotaFiscal nf = gerador.Gera(pedido);
            
        //    //dao.Verify(t=>t.Persiste(nf));
        
        
        //}


        //[Test]
        //public void DeveEnviarNotaFiscalGeradaParaSAP()
        //{
        //    var dao = new Mock<NFDao>();
        //    var sap = new Mock<SAP>();

        //    GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(dao.Object,sap.Object);

        //    Pedido pedido = new Pedido("Mauricio", 1000, 1);

        //    NotaFiscal nf = gerador.Gera(pedido);

        //    dao.Verify(t => t.Persiste(nf));


        //}

        [Test]
        public void DeveInvocarAcoesPosteriores()
        {
            var acao1 = new Mock<IAcaoAposGerarNota>();
            var acao2 = new Mock<IAcaoAposGerarNota>();

            IList<IAcaoAposGerarNota> acoes = new List<IAcaoAposGerarNota>()
                                                  {
                                                      acao1.Object, 
                                                      acao2.Object
                                                  };

            IRelogio relogio=new RelogioDoSistema();

            GeradorDeNotaFiscal gerador=new GeradorDeNotaFiscal(acoes,relogio);

            Pedido pedido=new Pedido("Mauricio",1000,1);

            NotaFiscal nf = gerador.Gera(pedido);

            acao1.Verify(t=>t.Executa(nf));
            acao2.Verify(t=>t.Executa(nf));
            
        }

    }
}

