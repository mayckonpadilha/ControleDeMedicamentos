using ControleDeMedicamentos.ConsoleApp.Compatilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleApp.ModuloRequisicao
{
    internal class RepositorioRequisicao:RepositorioBase
    {
        public RepositorioRequisicao(List<EntidadeBase> listDeEntidades)
        {
            this.listaEntidades = listDeEntidades;
        }

        public override Requisicao Busca(int id)
        {
            return (Requisicao)base.Busca(id);
        }
    }
}
