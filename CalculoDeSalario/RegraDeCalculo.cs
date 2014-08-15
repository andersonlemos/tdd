using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeSalario
{
    public abstract class RegraDeCalculo
    {
        
        protected abstract int Limite();
        protected abstract double PorcentagemAcimaDoLimite();
        protected abstract double PorcentagemBase();
 
    }
}
