using NUnit.Framework;
namespace CalculoDeSalario
{
    [TestFixture]
    public class CalculadoraDeSalarioTest
    {
        private CalculadoraDeSalario _calculadora;

        [SetUp]
        public  void InicializarCalculadoraDeSalario()
        {
            _calculadora=new CalculadoraDeSalario();
        }

        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAbaixoDoLimite()
        {
          
            var desenvolvedor = new Funcionario("Mauricio",1500.0,Cargo.DESENVOLVEDOR);

            double salario = _calculadora.CalculaSalario(desenvolvedor);

            Assert.AreEqual(1500.0 * 0.9,salario,0.00001);


        }

        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAcimaDoLimite()
        {
         
            var desenvolvedor = new Funcionario("Mauricio", 4000.0, Cargo.DESENVOLVEDOR);

            double salario = _calculadora.CalculaSalario(desenvolvedor);

            Assert.AreEqual(4000.0 * 0.8, salario, 0.00001);


        }

        [Test]
        public void DeveCalcularSalarioParaDBAsComSalarioAbaixoDoLimite()
        {
           
            Funcionario dba = new Funcionario("Mauricio", 500.0, Cargo.DBA);

            double salario = _calculadora.CalculaSalario(dba);

            Assert.AreEqual(500.0 * 0.85, salario, 0.00001);


        }

        [Test]
        public void DeveCalcularSalarioParaDBAsComSalarioAcimaDoLimite()
        {

            Funcionario dba = new Funcionario("Mauricio", 4500.0, Cargo.DBA);

            double salario = _calculadora.CalculaSalario(dba);

            Assert.AreEqual(4500.0 * 0.75, salario, 0.00001);


        }

        [Test]
        public void DeveCalcularSalarioParaTestadoresComSalarioAbaixoDoLimite()
        {

            var testador = new Funcionario("Mauricio", 500.0, Cargo.TESTADOR);

            double salario = _calculadora.CalculaSalario(testador);

            Assert.AreEqual(500.0 * 0.85, salario, 0.00001);

        }
        
        [Test]
        public void DeveCalcularSalarioParaTestadoresComSalarioAcimaDoLimite()
        {

            var testador = new Funcionario("Mauricio", 4500.0, Cargo.TESTADOR);

            double salario = _calculadora.CalculaSalario(testador);

            Assert.AreEqual(4500.0 * 0.75, salario, 0.00001);

        }

    }
    
}
