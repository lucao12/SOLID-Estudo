using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Interfaces
{
    public interface IRepositorio
    {
        public void Inserir(Funcionario func);
        public void Remover(int id);
        public List<Funcionario> ListarTodosFuncionarios();
    }
}
