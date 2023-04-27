using ControleDeMedicamentos.ConsoleApp.Compatilhado;
using ControleDeMedicamentos.ConsoleApp.ModuloFornecedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ControleDeMedicamentos.ConsoleApp.ModuloMedicamento
{
    internal class TelaMedicamento : TelaBase
    {
        public RepositorioMedicamento repositorioMedicamento;

        public TelaMedicamento(RepositorioMedicamento repositorioMedicamento)
        {
            this.repositorioMedicamento = repositorioMedicamento;
        }

        public void MenuMedicamento(string opcao)
        {
            MenuInicial("Medicamento", opcao);
        }
        public void AdicionarMedicamento()
        {
            Medicamento medicamento = (Medicamento)PegaDadosEntidade();
            Adiciona("Medicamento", medicamento, repositorioMedicamento);
            repositorioMedicamento.listaDeMedicamentos.Add(medicamento);
        }
        public override EntidadeBase PegaDadosEntidade()
        {
            Medicamento medicamento = new Medicamento();
            Console.WriteLine("Nome: ");
            medicamento.nome = Console.ReadLine();
            Console.WriteLine("Descrição");
            medicamento.descricao = Console.ReadLine();
            Console.WriteLine("Quantidade Disponível");
            medicamento.quantidadeDisponivel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bula");
            medicamento.bula = Console.ReadLine();
            return medicamento;
        }
        public void MostraTodosMedicamento()
        {
            MostraTodasEntidade("Medicamento", repositorioMedicamento);
        }
        public void MostraMedicamentoEmFalta()
        {
            RetornaListaDeMedicamentosOrdenadasPorQuantidadeDisponivel("Medicamento", repositorioMedicamento);
        }
        public void MostraMedicamentosMaisRetirados()
        {
            RetornaListaDeMedicamentosOrdenadasPorQuantidadeDeRetiradas("Medicamento", repositorioMedicamento);
        }
        public override void EscreveTodasAsEntidades(EntidadeBase entidade)
        {
            Medicamento f = (Medicamento)entidade;
            Console.WriteLine($"id: {f.id} | nome: {f.nome} | bula: {f.bula} | Quantidade Disponivel: {f.quantidadeDisponivel}| descrição : {f.descricao} | Quantidade de Retiradas : {f.quantidadeDeRetiradas}");
        }
        public void AtualizarMedicamento()
        {
            AtualizarEntidade(repositorioMedicamento);
        }
        public void DeletaMedicamento()
        {
            DeletaEntidade(repositorioMedicamento);
        }
        public override void MenuEntidade(string opcao)
        {
            if (opcao == "1")
            {
                Console.Clear();
                AdicionarMedicamento();
            }
            if (opcao == "2")
            {
                Console.Clear();
                MostraTodosMedicamento();
                Console.ReadKey();
            }
            if (opcao == "3")
            {
                Console.Clear();
                MostraTodosMedicamento();
                AtualizarMedicamento();
            }
            if (opcao == "4")
            {
                Console.Clear();
                MostraTodosMedicamento();
                DeletaMedicamento();
            }
            if (opcao == "5")
            {
                Console.Clear();
                MostraMedicamentoEmFalta();
                Console.ReadKey();
            }
            if (opcao == "6")
            {
                Console.Clear();
                MostraMedicamentosMaisRetirados();
                Console.ReadKey();
            }
        }
        public void RetornaListaDeMedicamentosOrdenadasPorQuantidadeDisponivel(string tipoDeEntidade, RepositorioBase repositorio)
        {
            Console.WriteLine($"{tipoDeEntidade}: ");
            Console.WriteLine("____________________________________________________________________________");
            if (VerificaListasValidas(tipoDeEntidade, repositorio) == true)
            {
                foreach (EntidadeBase a in repositorioMedicamento.RetornarTodosOrdenadosQuantidadeDisponivel())
                {
                    EscreveTodasAsEntidades(a);
                }
            }
        }
        public void RetornaListaDeMedicamentosOrdenadasPorQuantidadeDeRetiradas(string tipoDeEntidade, RepositorioBase repositorio)
        {
            Console.WriteLine($"{tipoDeEntidade}: ");
            Console.WriteLine("____________________________________________________________________________");
            if (VerificaListasValidas(tipoDeEntidade, repositorio) == true)
            {
                foreach (EntidadeBase a in repositorioMedicamento.RetornarTodosOrdenadosPorRetirada())
                {
                    EscreveTodasAsEntidades(a);
                }
            }
        }
        public override void MenuInicial(string nome, string opcao)
        {
            do
            {
                Console.Clear();
                Console.WriteLine($"----Menu {nome}----\n");
                Console.WriteLine($"1- Adicionar {nome} | 2- Ver {nome} | 3- Atualizar {nome} | 4- Deletar {nome} | 5- Mostrar medicamentos em falta | 6- Mostrar medicamentos mais retirados| S- Sair");
                opcao = Console.ReadLine();
                MenuEntidade(opcao);

            }
            while (opcao.ToUpper() != "S");
        }

    }

}
