using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 2 - Escreva um programa em C# que leia 10 números e armazene-os
 * em um vetor. Depois, ele deve ler mais 10 números e armazená-los em
 * um segundo vetor. O programa deverá imprimir o conteúdo desses
 * vetores, e depois gerar e imprimir um terceiro vetor, contendo a soma
 * dos 2 vetores.
 * Por exemplo, suponha que os vetores se chamem a, b e c.
 * Então, c[0] deve ser igual a a[0] + b[0], c[1] deve ser igual a a[1] +b[1],
 * c[2] deve ser igual a a[2] + b[2], e assim por diante. 
*/

namespace PP_Pratica09
{
    class SomaVetor
    {
        public void Exibir()
        {
            somaVetor();
        }

        public void somaVetor()
        {
            int[] num1 = new int[10];
            int[] num2 = new int[10];
            int[] num3 = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um valor: ");
                num1[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine();


            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um valor: ");
                num2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < num1.Length; i++)
            {
                num3[i] = num1[i] + num2[i];
            }

            foreach (var item in num3)
            {
                Console.WriteLine("Soma é {0}", item);
            }
        }
    }
}
