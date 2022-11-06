using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juroscompostosformula
{
    internal class Program
    {
        public static void Main()
        {
            // FORMULA JUROS SEM APORTES MENSAIS.

         

            double Capital = 200000;   //Capital Aportado Inicial.
            double TaxaDeJuros = 13.75 / 100; //Taxa de Juros (ANUAL)
            double tempo = 15; //Tempo da Aplicação (ANOS)


            double ConstanteComJuros = (1 + TaxaDeJuros);
            double ElevadoaoTempo = Math.Pow(ConstanteComJuros, tempo);
            double MontanteSemAportesMensais = (Capital * ElevadoaoTempo);

            Console.WriteLine("JUROS COMPOSTOS SEM APORTES MENSAIS.");
            Console.WriteLine(MontanteSemAportesMensais);

            // FORMULA JUROS COM APORTES MENSAIS.

            //

            double InvestimentoInicialP = 100000;
            double InvestimentoMensalR = 700;
            double IncisaoDosJurosC = 12;
            double NumeroDeAnosN = 180 / 12; //Colocar em meses.
            
            double ITaxadejuros1 = (1 * 12);  //Colocar em meses.
            double TaxaJurosAnualI = ITaxadejuros1 / 100;

            double JurosDivididoIncisao = TaxaJurosAnualI / IncisaoDosJurosC; 
            double ConstanteMaisJurosDividido = 1 + JurosDivididoIncisao; 
            double NvezesC = NumeroDeAnosN * IncisaoDosJurosC; 
            double InternoUm = Math.Pow(ConstanteMaisJurosDividido, NvezesC); // 1+ I/C ELEVADO 

            double Parteum = InvestimentoInicialP * InternoUm; // P* 1+ I/C ELEVADO 

            double Internodois = InternoUm - 1; 
            double Internotres = Internodois / JurosDivididoIncisao; 
            double Internoquatro = InvestimentoMensalR * Internotres; 
            double Final = Parteum + Internoquatro;


            Console.WriteLine("JUROS COMPOSTOS COM APORTES MENSAIS.");
            Console.WriteLine(Final);
            


           
            

       












        }
    }
}
