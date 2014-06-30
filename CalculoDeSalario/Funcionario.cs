using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeSalario
{
    public enum Cargo
    {
        DESENVOLVEDOR,
        DBA,
        TESTADOR
    }

    public  class Funcionario
    {
      public string Nome { get; set; }
      public double Salario { get; set; }
      public Cargo Cargo { get; private set; }
        
       public Funcionario(string nome,double salario,Cargo cargo)
        {
            this.Nome = nome;
            this.Salario = salario;
            this.Cargo = cargo;


        }

    }
}
