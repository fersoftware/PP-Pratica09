using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 3 - Escreva um programa em C# que cria um vetor para armazenar 10
 * strings. O programa deve solicitar que o usuário digite 10 nomes,
 * que devem ser armazenados nesse vetor.
 * Depois, o programa deve pedir que se digite um nome qualquer. O
 * programa deverá pesquisar se esse nome está no vetor.
 * Se estiver, deve exibir a sua posição no vetor (índice), senão deve
 * exibir uma mensagem de “Nome inexistente”.
*/

namespace PP_Pratica09
{
    class BuscaNome
    {
        public void exibir()
        {
            buscaNome();
        }

        public void buscaNome()
        {
            string[] s = new string[10];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite uma string: ");
                s[i] = Console.ReadLine();
            }

            Console.WriteLine("Digite o nome a ser pesquisado: ");
            string pesq = Console.ReadLine();

            if(Array.IndexOf(s,pesq)  != -1)
            {
                Console.WriteLine(s[Array.IndexOf(s, pesq)]);
            }
            else
            {
                Console.WriteLine("Este nome não está na lista");
            }
        }
    }
}
