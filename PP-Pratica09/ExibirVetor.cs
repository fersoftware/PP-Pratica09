using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 1 - Escreva um programa em C# que leia 7 números e armazene-os em
 * um vetor. Depois, o programa deve percorrer o vetor imprimindo os
 * números na ordem em que foram inseridos. E depois, deve percorrer o
 * vetor de trás para frente, imprimindo os números na ordem inversa em
 * que foram inseridos (dica: utilize o for ao contrário). 
 */

namespace PP_Pratica09
{
    class ExibirVetor
    {
        public void exibir()
        {
            exibirVetor();
        }

        public void exibirVetor()
        {
            int[] n = new int[7];

            for (int i = 0; i < 7; i++)
            {
                Console.Write("{0} - Digite um número: ", i+1);
                n[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            foreach (var item in n)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            for (int i = n.Length -1 ; i >= 0 ; i--)
            {
                Console.WriteLine(n[i]);
            }
        }
    }
}
