using ControleDeMedicamentos.ConsoleApp.Compatilhado;
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
    internal class TelaRequisicao:TelaBase
    {
        public RepositorioRequisicao repositorioRequisicao;
        public RepositorioPaciente repositorioPaciente;
        public RepositorioMedicamento repositorioMedicamento;
        public RepositorioFuncionario repositorioFuncionario;
        public TelaPaciente telaPaciente;
        public TelaMedicamento telaMedicamento;
        public TelaFuncionario telaFuncionario;

        public TelaRequisicao(RepositorioRequisicao repositorioRequisicao, RepositorioPaciente repositorioPaciente, RepositorioMedicamento repositorioMedicamento, RepositorioFuncionario repositorioFuncionario, TelaPaciente telaPaciente, TelaMedicamento telaMedicamento, TelaFuncionario telaFuncionario)
        {
            this.repositorioRequisicao = repositorioRequisicao;
            this.repositorioPaciente = repositorioPaciente;
            this.repositorioMedicamento = repositorioMedicamento;
            this.repositorioFuncionario = repositorioFuncionario;
            this.telaPaciente = telaPaciente;
            this.telaMedicamento = telaMedicamento;
            this.telaFuncionario = telaFuncionario;
        }

        public void MenuRequisicao(string opcao)
        {
            MenuInicial("Requisicao ", opcao);
        }
        public void AdicionarRequisicao()
        {
            Requisicao requisicao = (Requisicao)PegaDadosEntidade();
            Adiciona("Requisição", requisicao, repositorioRequisicao);
        }
        public override EntidadeBase PegaDadosEntidade()
        {
            int idBusca = 0;
            Requisicao requisicao = new Requisicao();

            if (VerificaListasValidas("Paciente", repositorioPaciente) == false)
                return null;
            else
                telaPaciente.MostraTodosPaciente();
            Console.WriteLine("Id do Paciente");
            idBusca = Convert.ToInt32(Console.ReadLine());
            requisicao.paciente = repositorioPaciente.Busca(idBusca);

            Console.Clear();
            if (VerificaListasValidas("Medicamento", repositorioMedicamento) == false)
                return null;
            else
                telaMedicamento.MostraTodosMedicamento();
            Console.WriteLine("Id do Medicamento");
            idBusca = Convert.ToInt32(Console.ReadLine());
            requisicao.medicamento = repositorioMedicamento.Busca(idBusca);

            Console.Clear();
            if (VerificaListasValidas("Funcionario", repositorioFuncionario) == false)
                return null;
            else
                telaFuncionario.MostraTodosFuncionarios();
            Console.WriteLine("Id do Funcionario");
            idBusca = Convert.ToInt32(Console.ReadLine());
            requisicao.funcionario = repositorioFuncionario.Busca(idBusca);

            Console.Clear();
            Console.WriteLine("Quantidade Retirada");
            requisicao.quantidadeRetirada = Convert.ToInt32(Console.ReadLine());
            if (requisicao.medicamento.quantidadeDisponivel < requisicao.quantidadeRetirada)
            {
                ApresentaMensagem("Quantidade indisponível", ConsoleColor.DarkYellow);
                return null;
            }
            else
                requisicao.medicamento.quantidadeDisponivel -= requisicao.quantidadeRetirada;

            Console.WriteLine("Data da Retirada");
            requisicao.dataDaRetirada = Convert.ToDateTime(Console.ReadLine());
            requisicao.medicamento.quantidadeDeRetiradas++;

            return requisicao;
        }
        public void MostraTodosRequisicao()
        {
            MostraTodasEntidade("Requisicao", repositorioRequisicao);
        }
        public override void EscreveTodasAsEntidades(EntidadeBase entidade)
        {
            Requisicao f = (Requisicao)entidade;
            Console.WriteLine($"id: {f.id} | Paciente: {f.paciente.nome} | Medicamento: {f.medicamento.nome} | Funcionário: {f.funcionario.nome} | Data da Retirada: {f.dataDaRetirada.ToString("dd/MMM/yyyy")}  | Quantidade Retirada: {f.quantidadeRetirada}");
        }
        public void AtualizarRequisicao()
        {
            AtualizarEntidade(repositorioRequisicao);
        }
        public void DeletaRequisicao()
        {
            DeletaEntidade(repositorioRequisicao);
        }
        public override void MenuEntidade(string opcao)
        {
            if (opcao == "1")
            {
                Console.Clear();
                AdicionarRequisicao();
            }
            if (opcao == "2")
            {
                Console.Clear();
                MostraTodosRequisicao();
                Console.ReadKey();
            }
            if (opcao == "3")
            {
                Console.Clear();
                MostraTodosRequisicao();
                AtualizarRequisicao();
            }
            if (opcao == "4")
            {
                Console.Clear();
                MostraTodosRequisicao();
                DeletaRequisicao();
            }
        }
    }
}
