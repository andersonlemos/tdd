using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaFiscal
{
   public class GeradorDeNotaFiscal
    {
       public NotaFiscal Gera(Pedido pedido)
       {
           
           return new NotaFiscal(pedido.Cliente,pedido.ValorTotal * 0.94,DateTime.Now);

       }


    }
}
