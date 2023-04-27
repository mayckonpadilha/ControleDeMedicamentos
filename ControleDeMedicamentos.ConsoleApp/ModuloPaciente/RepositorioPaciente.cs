using ControleDeMedicamentos.ConsoleApp.Compatilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleApp.ModuloPaciente
{
    internal class RepositorioPaciente: RepositorioBase
    {
        public RepositorioPaciente(List<EntidadeBase> listaDeEntidades)
        {
            this.listaEntidades = listaDeEntidades;
        }

        public override Paciente Busca(int id)
        {
            return (Paciente)base.Busca(id);
        }
    }
}
