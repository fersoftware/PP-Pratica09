using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 4 - Escreva um programa em C# que cria um vetor para armazenar 10
 * inteiros. O programa deve solicitar que o usuário digite 10 números,
 * que devem ser armazenados nesse vetor.
 * O programa deverá calcular a média dos números digitados e exibir
 * a média.
 * Depois, deverá imprimir os números que estão no vetor que estão * acima da média.
 */

namespace PP_Pratica09
{
    class Media
    {
        public void Exibir()
        {
            media();
        }

        public void media()
        {
            int[] num1 = new int[10];
            int soma = 0;
            

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um valor: ");
                num1[i] = int.Parse(Console.ReadLine());
                soma += num1[i];
            }

            Console.WriteLine();

            foreach (var item in num1)
            {
                if ((soma / 10 ) < item )
                {
                    Console.WriteLine("A média é {0} e o {1} está acima da média", (soma / 10), item);
                }
            }

        }
    }
}
