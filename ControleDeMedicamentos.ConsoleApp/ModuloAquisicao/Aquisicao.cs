using ControleDeMedicamentos.ConsoleApp.Compatilhado;
using ControleDeMedicamentos.ConsoleApp.ModuloFornecedor;
using ControleDeMedicamentos.ConsoleApp.ModuloFuncionario;
using ControleDeMedicamentos.ConsoleApp.ModuloMedicamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleApp.ModuloAquisicao
{
    internal class Aquisicao: EntidadeBase
    {
        public Fornecedor fornecedor { get; set; }
        public Medicamento medicamento { get; set; }
        public Funcionario funcionario { get; set; }
        public int quantidadeAdicionada { get; set; }
        public DateTime dataDaRetirada { get; set; }
        public override void Atualizar(EntidadeBase entidadeAtualizada)
        {
            Aquisicao aquisicao = (Aquisicao)entidadeAtualizada;
            fornecedor = aquisicao.fornecedor;
            medicamento = aquisicao.medicamento;
            funcionario = aquisicao.funcionario;

            quantidadeAdicionada = aquisicao.quantidadeAdicionada;
            dataDaRetirada = aquisicao.dataDaRetirada;
        }
    }
}
