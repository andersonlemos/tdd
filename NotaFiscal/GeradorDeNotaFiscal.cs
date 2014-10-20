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
       private IRelogio relogio;
       private ITabela tabela;

       public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes,ITabela tabela, IRelogio relogio)
       {
           this.relogio = relogio;
           this.tabela = tabela;
           this.acoes = acoes;
       }
     
       public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes,ITabela tabela) :
           this(acoes,tabela, new RelogioDoSistema())
       {

       }

       public NotaFiscal Gera(Pedido pedido)
       {
           
           //return new NotaFiscal(pedido.Cliente,pedido.ValorTotal * 0.94,DateTime.Now);
           NotaFiscal nf = new NotaFiscal(pedido.Cliente, pedido.ValorTotal * tabela.ParaValor(pedido.ValorTotal), relogio.Hoje());

           foreach(var acao in acoes)
           {
               acao.Executa(nf);
           }

           return nf;
       }


    }
}
