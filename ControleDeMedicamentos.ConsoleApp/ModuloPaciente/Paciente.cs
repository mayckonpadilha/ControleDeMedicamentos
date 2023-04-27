﻿using ControleDeMedicamentos.ConsoleApp.Compatilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControleDeMedicamentos.ConsoleApp.ModuloPaciente
{
    internal class Paciente : EntidadeBase
    {
        public string nome { get; set; }
        public string CPF { get; set; }
        public string numeroDeTelefone { get; set; }
        public string numeroSUS { get; set; }
        public override void Atualizar(EntidadeBase entidadeAtualizada)
        {
            Paciente paciente = (Paciente)entidadeAtualizada;
            nome = paciente.nome;
            CPF = paciente.CPF;
            numeroDeTelefone = paciente.numeroDeTelefone;
            numeroSUS = paciente.numeroSUS;
        }
    }
}
