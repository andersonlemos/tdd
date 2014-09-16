using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaFiscal
{
   public class GeradorDeNotaFiscal
   {

     
       private IList<IAcaoAposGerarNota> acoes;

       public GeradorDeNotaFiscal( IList<IAcaoAposGerarNota> acoes)
       {
           this.acoes = acoes;
       }
       
       public NotaFiscal Gera(Pedido pedido)
       {
           
           //return new NotaFiscal(pedido.Cliente,pedido.ValorTotal * 0.94,DateTime.Now);
           NotaFiscal nf = new NotaFiscal(pedido.Cliente, pedido.ValorTotal * 0.94, DateTime.Now);

           foreach(var acao in acoes)
           {
               acao.Executa(nf);
           }

           return nf;
       }


    }
}
