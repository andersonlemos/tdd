using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrinhoDeCompras
{
    public class CarrinhoDeCompras
    {

        public IList<Item> Itens { get; private set; }


        public CarrinhoDeCompras()
        {
            this.Itens=new List<Item>();
        }

        public void Adiciona(Item item)
        {
            this.Itens.Add(item);
        }

    }

   
}
