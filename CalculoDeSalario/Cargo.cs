using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeSalario
{
   public class Cargo
    {
    
       public static Cargo DESENVOLVEDOR{get{return new Cargo(new DezOuVintePorCento());}}
       public static Cargo DBA { get { return new Cargo(new QuinzeOuVinteECincoPorCento());}}
       public static Cargo TESTADOR { get { return new Cargo(new QuinzeOuVinteECincoPorCento());}}

       public IRegraDeCalculo Regra { get; private set; }

       private Cargo(IRegraDeCalculo regra)
       {
           this.Regra = regra;
       }

    }
}
