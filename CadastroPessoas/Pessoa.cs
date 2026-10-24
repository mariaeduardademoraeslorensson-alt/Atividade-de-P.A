using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    public abstract class Pessoa
    {
        public string nome;
        public int idade;

        public void Apresentar()
        {
            Console.WriteLine("nome: " + nome);
            Console.WriteLine("idade: " + idade);
        }
        public CadastroPessoas(string nome, int idade)
        {
            nome = nome;
            idade = idade;
        }
    }
}
