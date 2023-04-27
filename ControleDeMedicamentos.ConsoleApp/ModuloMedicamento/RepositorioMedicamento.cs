using ControleDeMedicamentos.ConsoleApp.Compatilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleApp.ModuloMedicamento
{
    internal class RepositorioMedicamento: RepositorioBase
    {
        public List<Medicamento> listaDeMedicamentos = new List<Medicamento>();

        public RepositorioMedicamento(List<EntidadeBase> listaDeEntidades)
        {
            this.listaEntidades = listaDeEntidades;
        }

        public override Medicamento Busca(int id)
        {
            return (Medicamento)base.Busca(id);
        }
        public List<Medicamento> RetornarTodosOrdenadosQuantidadeDisponivel()
        {
            List<Medicamento> objetoOrdenados = listaDeMedicamentos.OrderBy(x => x.quantidadeDisponivel).ToList();
            return objetoOrdenados;
        }
        public List<Medicamento> RetornarTodosOrdenadosPorRetirada()
        {
            List<Medicamento> objetoOrdenados = listaDeMedicamentos.OrderByDescending(x => x.quantidadeDeRetiradas).ToList();
            return objetoOrdenados;
        }
    }
}
