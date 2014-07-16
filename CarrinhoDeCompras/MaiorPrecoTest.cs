using NUnit.Framework;

namespace CarrinhoDeCompras
{
    [TestFixture]
    public class MaiorPrecoTest
    {
        [Test]
        public void DeveRetornarZeroSeCarrinhoVazio()
        {

            var carrinho = new CarrinhoDeCompras();

            Assert.AreEqual(0.0,carrinho.MaiorValor(),0.0000001);

        }

        [Test]
        public void DeveRetornarValorDoItemSeCarrinhoContem1Elemento()
        {

            var carrinho = new CarrinhoDeCompras();

            carrinho.Adiciona(new Item("Geladeira",1,900.0));

            Assert.AreEqual(900.0, carrinho.MaiorValor(), 0.0000001);

        }

        [Test]
        public void DeveRetornarMaiorValorSeCarrinhoContemMuitosElementos()
        {

            var carrinho = new CarrinhoDeCompras();

            carrinho.Adiciona(new Item("Geladeira", 1, 900.0));
            carrinho.Adiciona(new Item("Fogão", 1, 1500.0));
            carrinho.Adiciona(new Item("Máquina de Lavar", 1, 750.0));
            
            Assert.AreEqual(1500.0, carrinho.MaiorValor(), 0.0000001);
        }

    }
}
