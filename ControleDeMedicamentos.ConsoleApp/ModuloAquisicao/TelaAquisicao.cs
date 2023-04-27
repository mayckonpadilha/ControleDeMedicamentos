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
    internal class TelaAquisicao:TelaBase
    {
        public RepositorioAquisicao repositorioAquisicao;
        public RepositorioFornecedor repositorioFornecedor;
        public RepositorioMedicamento repositorioMedicamento;
        public RepositorioFuncionario repositorioFuncionario;
        public TelaFornecedor telaFornecedor;
        public TelaMedicamento telaMedicamento;
        public TelaFuncionario telaFuncionario;

        public TelaAquisicao (RepositorioAquisicao repositorioAquisicao, RepositorioFornecedor repositorioFornecedor, RepositorioMedicamento repositorioMedicamento, RepositorioFuncionario repositorioFuncionario, TelaFornecedor telaFornecedor, TelaMedicamento telaMedicamento, TelaFuncionario telaFuncionario)
        {
            this.repositorioAquisicao = repositorioAquisicao;
            this.repositorioFornecedor = repositorioFornecedor;
            this.repositorioMedicamento = repositorioMedicamento;
            this.repositorioFuncionario = repositorioFuncionario;
            this.telaFornecedor = telaFornecedor;
            this.telaMedicamento = telaMedicamento;
            this.telaFuncionario = telaFuncionario;
        }

        public void MenuAquisicao(string opcao)
        {
            MenuInicial("Aquisição", opcao);
        }
        public void AdicionaAquisicao()
        {
            Aquisicao aquisicao = (Aquisicao)PegaDadosEntidade();
            Adiciona("Aquisição", aquisicao, repositorioAquisicao);

        }
        public override EntidadeBase PegaDadosEntidade()
        {
            int idBusca = 0;
            Aquisicao aquisicao = new Aquisicao();

            if (VerificaListasValidas("fornecedor", repositorioFornecedor) == false)
                return null;
            else
                telaFornecedor.MostraTodosFornecedor();
            Console.WriteLine("Id do Fornecedor");
            idBusca = Convert.ToInt32(Console.ReadLine());
            aquisicao.fornecedor = repositorioFornecedor.Busca(idBusca);

            Console.Clear();
            if (VerificaListasValidas("medicamento", repositorioMedicamento) == false)
                return null;
            else
                telaMedicamento.MostraTodosMedicamento();
            Console.WriteLine("Id do Medicamento");
            idBusca = Convert.ToInt32(Console.ReadLine());
            aquisicao.medicamento = repositorioMedicamento.Busca(idBusca);
            Console.WriteLine();
            Console.WriteLine("Quantidade do Pedido");
            aquisicao.quantidadeAdicionada = Convert.ToInt32(Console.ReadLine());
            aquisicao.medicamento.quantidadeDisponivel += aquisicao.quantidadeAdicionada;

            Console.Clear();
            if (VerificaListasValidas("funcionario", repositorioFuncionario) == false)
                return null;
            else
                telaFuncionario.MostraTodosFuncionarios();
            Console.WriteLine("Id do Funcionario");
            idBusca = Convert.ToInt32(Console.ReadLine());
            aquisicao.funcionario = repositorioFuncionario.Busca(idBusca);

            Console.Clear();

            Console.WriteLine("Data da Retirada");
            aquisicao.dataDaRetirada = Convert.ToDateTime(Console.ReadLine());

            return aquisicao;
        }
        public void MostraTodosAquisicao()
        {
            MostraTodasEntidade("Aquisicao", repositorioAquisicao);
        }
        public override void EscreveTodasAsEntidades(EntidadeBase entidade)
        {
            Aquisicao f = (Aquisicao)entidade;
            Console.WriteLine($"id: {f.id} | Fornecedor: {f.fornecedor.nome} | Medicamento: {f.medicamento.nome} | Funcionário: {f.funcionario.nome} | Data da Retirada: {f.dataDaRetirada.ToString("dd/MMM/yyyy")}  | Quantidade Retirada: {f.quantidadeAdicionada}  ");

        }
        public void AtualizarAquisicao()
        {
            AtualizarEntidade(repositorioAquisicao);
        }
        public void DeletaAquisicao()
        {
            DeletaEntidade(repositorioAquisicao);
        }
        public override void MenuEntidade(string opcao)
        {
            if (opcao == "1")
            {
                Console.Clear();
                AdicionaAquisicao();
            }
            if (opcao == "2")
            {
                Console.Clear();
                MostraTodosAquisicao();
                Console.ReadKey();
            }
            if (opcao == "3")
            {
                Console.Clear();
                MostraTodosAquisicao();
                AtualizarAquisicao();
            }
            if (opcao == "4")
            {
                Console.Clear();
                MostraTodosAquisicao();
                DeletaAquisicao();
            }
        }
    }
}
