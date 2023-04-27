using ControleDeMedicamentos.ConsoleApp.Compatilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleApp.ModuloFuncionario
{
    internal class TelaFuncionario:TelaBase
    {
        public RepositorioFuncionario repositorioFuncionario;

        public TelaFuncionario(RepositorioFuncionario repositorioFuncionario)
        {
            this.repositorioFuncionario = repositorioFuncionario;
        }

        public void MenuFuncionario(string opcao)
        {
            MenuInicial("Funcionario", opcao);
        }
        public void AdicionarFuncionario()
        {
            Funcionario funcionario = (Funcionario)PegaDadosEntidade();
            Adiciona("Funcionário", funcionario, repositorioFuncionario);
        }
        public override EntidadeBase PegaDadosEntidade()
        {
            Funcionario funcionario = new Funcionario();
            Console.WriteLine("Nome");
            funcionario.nome = Console.ReadLine();
            Console.WriteLine("CPF");
            funcionario.CPF = Console.ReadLine();
            Console.WriteLine("Telefone");
            funcionario.telefone = Console.ReadLine();
            return funcionario;
        }
        public void MostraTodosFuncionarios()
        {
            MostraTodasEntidade("Funcionario", repositorioFuncionario);
        }
        public override void EscreveTodasAsEntidades(EntidadeBase entidade)
        {
            Funcionario f = (Funcionario)entidade;
            Console.WriteLine($"id: {f.id} | nome: {f.nome} | CPF: {f.CPF} | telefone: {f.telefone}");
        }
        public void AtualizarFuncionario()
        {
            AtualizarEntidade(repositorioFuncionario);
        }
        public void DeletaFuncionario()
        {
            DeletaEntidade(repositorioFuncionario);
        }
        public override void MenuEntidade(string opcao)
        {
            if (opcao == "1")
            {
                Console.Clear();
                AdicionarFuncionario();
            }
            if (opcao == "2")
            {
                Console.Clear();
                MostraTodosFuncionarios();
                Console.ReadKey();
            }
            if (opcao == "3")
            {
                Console.Clear();
                MostraTodosFuncionarios();
                AtualizarFuncionario();
            }
            if (opcao == "4")
            {
                Console.Clear();
                MostraTodosFuncionarios();
                DeletaFuncionario();
            }
        }
    }
}
