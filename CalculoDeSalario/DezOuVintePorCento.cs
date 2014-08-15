namespace CalculoDeSalario
{
   public class DezOuVintePorCento:RegraDeCalculo,IRegraDeCalculo
   {
      
       public double Calcula(Funcionario funcionario)
       {
           if (funcionario.Salario > Limite())
           {
               return funcionario.Salario * PorcentagemAcimaDoLimite();
           }

           return funcionario.Salario * PorcentagemBase();
       }
  
       protected override int Limite()
       {
           return 3000;
       }

       protected override double PorcentagemAcimaDoLimite()
       {
           return 0.8;
       }

       protected override double PorcentagemBase()
       {
           return 0.9;
       }

   }
}
