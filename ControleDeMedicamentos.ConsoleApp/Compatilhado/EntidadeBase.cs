﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleApp.Compatilhado
{
    internal abstract class EntidadeBase
    {
        public int id { get; set; }
        public abstract void Atualizar(EntidadeBase entidadeAtualizada);
    }
}
