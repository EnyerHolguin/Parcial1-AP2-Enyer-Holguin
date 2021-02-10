﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1_AP2_Enyer_Holguin.Models
{
    public class Articulos
    {
        [Key]
        public int ArticuloId { get; set; }
        public string Descripcion { get; set; }
        public int Exitencia { get; set; }
        public double Costo { get; set; }
        public double ValorInventario { get; set; }


    }
}
