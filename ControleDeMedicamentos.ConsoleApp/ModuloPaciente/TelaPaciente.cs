using ControleDeMedicamentos.ConsoleApp.Compatilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleApp.ModuloPaciente
{
    internal class TelaPaciente : TelaBase
    {

        public RepositorioPaciente repositorioPaciente;

        public TelaPaciente(RepositorioPaciente repositorioPaciente)
        {
            this.repositorioPaciente = repositorioPaciente;
        }

        public void MenuPaciente(string opcao)
        {
            MenuInicial("Paciente", opcao);
        }
        public void AdicionarPaciente()
        {
            Paciente paciente = (Paciente)PegaDadosEntidade();
            Adiciona("Paciente", paciente, repositorioPaciente);
        }
        public override EntidadeBase PegaDadosEntidade()
        {
            Paciente paciente = new Paciente();
            Console.WriteLine("Nome");
            paciente.nome = Console.ReadLine();
            Console.WriteLine("CPF");
            paciente.CPF = Console.ReadLine();
            Console.WriteLine("Telefone");
            paciente.numeroDeTelefone = Console.ReadLine();
            Console.WriteLine("numero do SUS");
            paciente.numeroSUS = Console.ReadLine();
            return paciente;
        }
        public void MostraTodosPaciente()
        {
            MostraTodasEntidade("Paciente", repositorioPaciente);
        }
        public override void EscreveTodasAsEntidades(EntidadeBase entidade)
        {
            Paciente f = (Paciente)entidade;
            Console.WriteLine($"id: {f.id} | nome: {f.nome} | CPF: {f.CPF} | telefone: {f.numeroDeTelefone}| numero do SUS: {f.numeroSUS}");
        }
        public void AtualizarPaciente()
        {
            AtualizarEntidade(repositorioPaciente);
        }
        public void DeletaPaciente()
        {
            DeletaEntidade(repositorioPaciente);
        }
        public override void MenuEntidade(string opcao)
        {
            if (opcao == "1")
            {
                Console.Clear();
                AdicionarPaciente();
            }
            if (opcao == "2")
            {
                Console.Clear();
                MostraTodosPaciente();
                Console.ReadKey();
            }
            if (opcao == "3")
            {
                Console.Clear();
                MostraTodosPaciente();
                AtualizarPaciente();
            }
            if (opcao == "4")
            {
                Console.Clear();
                MostraTodosPaciente();
                DeletaPaciente();
            }
        }
    }
}
