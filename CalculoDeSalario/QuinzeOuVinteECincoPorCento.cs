
namespace CalculoDeSalario
{
   public class QuinzeOuVinteECincoPorCento:RegraDeCalculo,IRegraDeCalculo
   {
       
       public double Calcula(Funcionario funcionario)
       {
           if (funcionario.Salario < Limite())
           {
               return funcionario.Salario * PorcentagemAcimaDoLimite();
           }

           return funcionario.Salario * PorcentagemBase();
       }

       protected override int Limite()
       {
           return 2500;
       }

       protected override double PorcentagemAcimaDoLimite()
       {
           return 0.85;
       }

       protected override double PorcentagemBase()
       {
           return 0.75;
       }

   }
}
