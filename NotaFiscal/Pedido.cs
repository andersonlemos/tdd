using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaFiscal
{
  public  class Pedido
    {

      public string Cliente { get; private set; }
      public double ValorTotal { get; private set; }
      public int QuantidadeItens{get;private set;}
      
      public Pedido(string cliente,double valorTotal,int quantidadeItens)
      {
          this.Cliente = cliente;
          this.ValorTotal = valorTotal;
          this.QuantidadeItens = quantidadeItens;
          
      }
      

    }
}
