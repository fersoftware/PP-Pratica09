using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Pratica09
{
    class DiadoAno
    {
        public void Exibir()
        {
            Console.Write("Digite o dia: ");
            int dia = int.Parse(Console.ReadLine());

            Console.Write("Agora digite o mês: ");
            int mes = int.Parse(Console.ReadLine());

            Console.WriteLine("O dia {0}/{1} corresponde ao dia {2} do ano. ", dia, mes, ExibirDiasdoMes(dia, mes) );
        }

        public int ExibirDiasdoMes(int dia, int mes_)
        {
            DateTime ultimoDiaDoMes = new DateTime(2016, 05, DateTime.DaysInMonth(2016, 05));

            int[] mes = new int[13];
            mes[0] = 0;

            for (int i = 1; i <=12; i++)
            {
                ultimoDiaDoMes = new DateTime(2016, i, DateTime.DaysInMonth(2016, i));
                mes[i] = int.Parse(ultimoDiaDoMes.Day.ToString());
            }

            if(x == 1)
            {
                return x;
            }
            else
            {
                return mes[x-1];
            }

            
        }
    }
}
