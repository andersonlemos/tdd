using System;
using System.Collections.Generic;


namespace ConversorDeNumeroRomano
{

   public class ConversorDeNumeroRomano
   {
       private static readonly Dictionary<string, int> tabela = new Dictionary<string, int>()
                                                    {
                                                        {"I",1},
                                                        {"V",5},
                                                        {"X",10},
                                                        {"L",50},
                                                        {"C",100},
                                                        {"D",500},
                                                        {"M",1000}
                                                    };
       public int Converte(string numeroEmRomano)
       {
           int acumulador = 0;
           int ultimoVizinhoDaDireita = 0;

           for (int i = numeroEmRomano.Length - 1; i >= 0 ; i--)
           {
               int atual = tabela[numeroEmRomano[i].ToString()];

               int multiplicador = 1;

               if (atual < ultimoVizinhoDaDireita)
                   multiplicador = -1;

               acumulador += atual * multiplicador;


               ultimoVizinhoDaDireita = atual;
           }

           return acumulador;

       }
    }
}
