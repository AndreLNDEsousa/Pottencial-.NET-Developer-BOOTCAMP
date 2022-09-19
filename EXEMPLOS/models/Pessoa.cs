using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXEMPLOS.Models
{

    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string NomeRepresentanteLegalDaPessoaFisica { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}, e tenho {Idade} anos.");
        }
    }

}