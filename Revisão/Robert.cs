using System;
using System.Collections.Generic;
using System.Text;

namespace Revisão
{
    internal class Robert
    {


        public List<string> Habilidades;
        public int Idade;
        public string nome;

        public void ExibirDados()
        {
            Console.WriteLine($"Minha idade é :{Idade}");
            Console.WriteLine($"Minha nome é :{nome}");
            int contador = 1;
            foreach (string item in Habilidades)
            {
                Console.WriteLine($"{contador}-{item}");
                contador++;
            }
        }
    }
}