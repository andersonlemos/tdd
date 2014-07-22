using NUnit.Framework;

namespace CarrinhoDeCompras
{
    [TestFixture]
    public class MaiorPrecoTest
    {
        private CarrinhoDeCompras _carrinho;

        [SetUp]
       public void InicializarCarrinho()
        {
            this._carrinho=new CarrinhoDeCompras();
        }


        [Test]
        public void DeveRetornarZeroSeCarrinhoVazio() 
        {

            Assert.AreEqual(0.0,_carrinho.MaiorValor(),0.0000001);

        }

        [Test]
        public void DeveRetornarValorDoItemSeCarrinhoContem1Elemento() 
        {

            _carrinho.Adiciona(new Item("Geladeira",1,900.0));

            Assert.AreEqual(900.0, _carrinho.MaiorValor(), 0.0000001);

        }

        [Test]
        public void DeveRetornarMaiorValorSeCarrinhoContemMuitosElementos()
        {

      
            _carrinho.Adiciona(new Item("Geladeira", 1, 900.0));
            _carrinho.Adiciona(new Item("Fogão", 1, 1500.0));
            _carrinho.Adiciona(new Item("Máquina de Lavar", 1, 750.0));
            
            Assert.AreEqual(1500.0, _carrinho.MaiorValor(), 0.0000001);
        }

    }
}
