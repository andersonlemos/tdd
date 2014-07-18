using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace CalculoDeSalario
{
    [TestFixture]
    public class CalculadoraDeSalarioTest
    {
        private CalculadoraDeSalario _calculadora;

        [SetUp]
        void InicializarCalculadoraDeSalario()
        {
            this._calculadora=new CalculadoraDeSalario();
        }

        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAbaixoDoLimite()
        {
          
            Funcionario desenvolvedor = new Funcionario("Mauricio",1500.0,Cargo.DESENVOLVEDOR);

            double salario = _calculadora.CalculaSalario(desenvolvedor);

            Assert.AreEqual(1500.0 * 0.9,salario,0.00001);


        }

        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAcimaDoLimite()
        {
         
            Funcionario desenvolvedor = new Funcionario("Mauricio", 4000.0, Cargo.DESENVOLVEDOR);

            double salario = _calculadora.CalculaSalario(desenvolvedor);

            Assert.AreEqual(4000.0 * 0.8, salario, 0.00001);


        }


        [Test]
        public void DeveCalcularSalarioParaDBAsComSalarioAbaixoDoLimite()
        {
           
            Funcionario dba = new Funcionario("Mauricio", 500.0, Cargo.DBA);

            double salario = _calculadora.CalculaSalario(dba);

            Assert.AreEqual(500.0 * 0.9, salario, 0.00001);


        }
    }

  
}
