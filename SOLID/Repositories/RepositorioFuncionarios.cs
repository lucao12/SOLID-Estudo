using SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Repositories
{
    public class RepositorioFuncionarios : IRepositorio
    {
        readonly List<Funcionario> _funcionarios;

        public RepositorioFuncionarios(List<Funcionario> funcionarios)
        {
            _funcionarios = funcionarios;
        }

        public void Inserir(Funcionario func)
        {
            _funcionarios.Add(func);
        }

        public void Remover(int id)
        {
            foreach (var funcionario in _funcionarios)
            {
                if(funcionario.Id == id)
                {
                    _funcionarios.Remove(funcionario);
                    return;
                }
            }
        }

        public List<Funcionario> ListarTodosFuncionarios()
        {
            return _funcionarios;
        }
    }
}
