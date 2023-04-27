using ControleDeMedicamentos.ConsoleApp.Compatilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleApp.ModuloAquisicao
{
    internal class RepositorioAquisicao:RepositorioBase
    {
        public RepositorioAquisicao(List<EntidadeBase> listaDeEntidades)
        {
            this.listaEntidades = listaDeEntidades;
        }
        public override Aquisicao Busca(int id)
        {
            return (Aquisicao)base.Busca(id);
        }
    }
}
