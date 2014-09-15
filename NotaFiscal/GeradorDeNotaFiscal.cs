using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaFiscal
{
   public class GeradorDeNotaFiscal
   {

       private NFDao dao;


       public GeradorDeNotaFiscal(NFDao dao)
       {
           this.dao = dao;
       }



       public NotaFiscal Gera(Pedido pedido)
       {
           
           //return new NotaFiscal(pedido.Cliente,pedido.ValorTotal * 0.94,DateTime.Now);
           NotaFiscal nf = new NotaFiscal(pedido.Cliente, pedido.ValorTotal * 0.94, DateTime.Now);

           dao.Persiste(nf);

           return nf;
       }


    }
}
