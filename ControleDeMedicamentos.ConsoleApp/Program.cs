
using ControleDeMedicamentos.ConsoleApp.Compatilhado;
using ControleDeMedicamentos.ConsoleApp.ModuloAquisicao;
using ControleDeMedicamentos.ConsoleApp.ModuloFornecedor;
using ControleDeMedicamentos.ConsoleApp.ModuloFuncionario;
using ControleDeMedicamentos.ConsoleApp.ModuloMedicamento;
using ControleDeMedicamentos.ConsoleApp.ModuloPaciente;
using ControleDeMedicamentos.ConsoleApp.ModuloRequisicao;

string opcao = "";
#region DeclaraçãoEConecção
RepositorioFuncionario repositorioDeFuncionario = new RepositorioFuncionario(new List<EntidadeBase>());
TelaFuncionario telaFuncionario = new TelaFuncionario(repositorioDeFuncionario);

RepositorioPaciente repositorioDePaciente = new RepositorioPaciente(new List<EntidadeBase>());
TelaPaciente telaPaciente = new TelaPaciente(repositorioDePaciente);

RepositorioMedicamento repositorioMedicamento = new RepositorioMedicamento(new List<EntidadeBase>());
TelaMedicamento telaMedicamento = new TelaMedicamento(repositorioMedicamento);

RepositorioFornecedor repositorioDeFornecedor = new RepositorioFornecedor(new List<EntidadeBase>());
TelaFornecedor telaFornecedor = new TelaFornecedor(repositorioDeFornecedor, repositorioMedicamento, telaMedicamento);

RepositorioAquisicao repositorioDeAquisicao = new RepositorioAquisicao(new List<EntidadeBase>());
TelaAquisicao telaAquisicao = new TelaAquisicao(repositorioDeAquisicao, repositorioDeFornecedor, repositorioMedicamento, repositorioDeFuncionario, telaFornecedor, telaMedicamento, telaFuncionario);

RepositorioRequisicao repositorioDeRequisicao = new RepositorioRequisicao(new List<EntidadeBase>());
TelaRequisicao telaRequisicao = new TelaRequisicao(repositorioDeRequisicao, repositorioDePaciente, repositorioMedicamento, repositorioDeFuncionario, telaPaciente, telaMedicamento, telaFuncionario);

#endregion

while (opcao.ToUpper() != "S")
{
    Console.Clear();
    Console.WriteLine("1- Menu Funcionario | 2- Menu Paciente | 3- Menu Medicamento | 4- Menu Fornecedor | 5- Menu Aquisição | 6- Menu Requisição");
    opcao = Console.ReadLine();
    if (opcao == "1")
    {
        telaFuncionario.MenuFuncionario(opcao);
    }
    if (opcao == "2")
    {
        telaPaciente.MenuPaciente(opcao);
    }
    if (opcao == "3")
    {
        telaMedicamento.MenuMedicamento(opcao);
    }
    if (opcao == "4")
    {
        telaFornecedor.MenuFornecedor(opcao);
    }
    if (opcao == "5")
    {
        telaAquisicao.MenuAquisicao(opcao);
    }
    if (opcao == "6")
    {
        telaRequisicao.MenuRequisicao(opcao);
    }

}