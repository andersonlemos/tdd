using NUnit.Framework;

namespace CarrinhoDeCompras
{
    [TestFixture]
    public class MaiorPrecoTest
    {
        [Test]
        public void DeveRetornarZeroSeCarrinhoVazio()
        {

            CarrinhoDeCompras carrinho=new CarrinhoDeCompras();

            MaiorPreco algoritmo= new MaiorPreco();

            double valor = algoritmo.Encotra(carrinho);

            Assert.AreEqual(0.0,valor,0.0000001);

        }
    }
}
