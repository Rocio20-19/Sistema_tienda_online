using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
#nullable disable

namespace Sistema_tienda_online.Models
{
    public class Factura
    {
        public Factura()
        {
           
        }
        [Key]
        public int IdFactura { get; set; }
        public int? IdCliente { get; set; }
        public decimal? Precio { get; set; }
        public DateTime? Fecha { get; set; }

    }
}
