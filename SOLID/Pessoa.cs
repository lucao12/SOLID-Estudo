using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public abstract class Pessoa
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public double Altura { get; private set; }

        public Pessoa(string nome, int idade, double altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }

        public virtual string Andar()
        {
            return $"{this.Nome} está andando";
        }
    }
}
