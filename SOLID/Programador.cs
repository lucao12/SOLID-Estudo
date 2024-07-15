using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Programador : Funcionario
    {
        public string Tecnologia { get; set; }

        public Programador(int id, string nome, int idade, double altura, double salario, string tecnologia) : base(id, nome, idade, altura, salario)
        {
            Tecnologia = tecnologia;
        }

        public override string Andar()
        {
            return base.Andar() + " rápido";
        }
    }
}
