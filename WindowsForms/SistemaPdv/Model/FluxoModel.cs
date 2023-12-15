﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPdv.Model
{
    internal class FluxoModel
    {
        public int Id { get; set; }
        public decimal SaldoInicial { get; set; }
        public decimal SaldoFinal { get; set; }
        public DateTime DataOpen { get; set; }
        public DateTime DataClose { get; set; }

    }
}
