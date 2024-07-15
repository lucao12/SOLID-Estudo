using SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public abstract class Funcionario : Pessoa, IContrato
    {
        public int Id { get; private set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, int idade, double altura, double salario) : base (nome, idade, altura)
        {
            Id = id;
            Salario = salario;
        }

        public string Almocar()
        {
            return $"{this.Nome} está almoçando";
        }
        public string BaterPonto()
        {
            return $"{this.Nome} bateu o ponto";
        }
        public string Trabalhar()
        {
            return $"{this.Nome} está trabalhando";
        }
    }
}
