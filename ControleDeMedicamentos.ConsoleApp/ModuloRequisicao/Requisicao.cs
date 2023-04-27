using ControleDeMedicamentos.ConsoleApp.Compatilhado;
using ControleDeMedicamentos.ConsoleApp.ModuloFornecedor;
using ControleDeMedicamentos.ConsoleApp.ModuloFuncionario;
using ControleDeMedicamentos.ConsoleApp.ModuloMedicamento;
using ControleDeMedicamentos.ConsoleApp.ModuloPaciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleApp.ModuloRequisicao
{
    internal class Requisicao : EntidadeBase
    {
        public Medicamento medicamento { get; set; }
        public Paciente paciente { get; set; }
        public Funcionario funcionario { get; set; }
        public int quantidadeRetirada { get; set; }
        public DateTime dataDaRetirada { get; set; }

        public override void Atualizar(EntidadeBase entidadeAtualizada)
        {
            Requisicao requisicao = (Requisicao)entidadeAtualizada;
            paciente = requisicao.paciente;
            medicamento = requisicao.medicamento;
            funcionario = requisicao.funcionario;
            quantidadeRetirada = requisicao.quantidadeRetirada;
            dataDaRetirada = requisicao.dataDaRetirada;

        }
    }
}
