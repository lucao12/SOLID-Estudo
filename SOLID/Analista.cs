using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class Analista : Funcionario
    {
        public Analista(int id, string nome, int idade, double altura, double salario) : base(id, nome, idade, altura, salario)
        {
        }

        public override string Andar()
        {
            return base.Andar() + " mais lento";
        }
    }
}
