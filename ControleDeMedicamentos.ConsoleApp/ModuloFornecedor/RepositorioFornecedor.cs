using ControleDeMedicamentos.ConsoleApp.Compatilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleApp.ModuloFornecedor
{
    internal class RepositorioFornecedor: RepositorioBase
    {
        public RepositorioFornecedor(List<EntidadeBase> listaDeEntidades)
        {
            this.listaEntidades = listaDeEntidades;
        }
        public override Fornecedor Busca(int id)
        {
            return (Fornecedor)base.Busca(id);
        }
    }
}
