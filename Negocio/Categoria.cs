﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? Visitas { get; set; }
        public bool Activa { get; set; }
    }
}
