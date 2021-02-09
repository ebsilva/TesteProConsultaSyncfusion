﻿
using System;
using System.Collections.Generic;

namespace Core.Entities
{

    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public DateTime DataAtualizacao { get; set; } = DateTime.Now;
        public int ModificadoPor { get; set; } = 0;
        public bool Ativo { get; set; } = true;
    }
}