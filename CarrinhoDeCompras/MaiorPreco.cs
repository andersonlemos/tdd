using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrinhoDeCompras
{
   public  class MaiorPreco
    {

       public double Encontra(CarrinhoDeCompras carrinho)
       {
         if(carrinho.Itens.Count == 0)
         {
             return 0;
         }
           
          double maior= carrinho.Itens[0].ValorTotal;
          
           foreach(var item in carrinho.Itens)
           {
               if(maior < item.ValorTotal)
               {
                   maior  = item.ValorTotal;
               }

           }

           return maior;

       }



    }
}
