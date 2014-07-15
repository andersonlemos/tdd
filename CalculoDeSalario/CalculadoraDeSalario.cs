using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeSalario
{
    public class CalculadoraDeSalario
    {
        public double CalculaSalario(Funcionario funcionario)
        {
            
                if (funcionario.Salario > 3000)
                {
                    return funcionario.Salario * 0.8;
                }

            return funcionario.Salario * 0.9;
        }

    }
}
