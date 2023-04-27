using ControleDeMedicamentos.ConsoleApp.Compatilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleApp.ModuloFuncionario
{
    internal class Funcionario : EntidadeBase
    {
        public string nome { get; set; }
        public string CPF { get; set; }
        public string telefone { get; set; }
        public override void Atualizar(EntidadeBase entidadeAtualizada)
        {
            Funcionario funcionario = (Funcionario)entidadeAtualizada;
            nome = funcionario.nome;
            CPF = funcionario.CPF;
            telefone = funcionario.telefone;
        }
    }
}
