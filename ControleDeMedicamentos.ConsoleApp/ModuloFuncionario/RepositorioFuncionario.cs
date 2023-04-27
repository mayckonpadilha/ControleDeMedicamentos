using ControleDeMedicamentos.ConsoleApp.Compatilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleApp.ModuloFuncionario
{
    internal class RepositorioFuncionario: RepositorioBase
    {
        public RepositorioFuncionario(List<EntidadeBase> listaDeEntidades)
        {
            this.listaEntidades = listaDeEntidades;
        }
        public override Funcionario Busca(int id)
        {
            return (Funcionario)base.Busca(id);
        }
    }
}
