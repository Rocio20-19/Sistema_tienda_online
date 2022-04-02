using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
#nullable disable

namespace Sistema_tienda_online.Models
{
    public class Detalle
    {
        [Key]
        public int IdDetalle { get; set; }
        public int IdFactura { get; set; }
        public int? IdProducto { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Precio { get; set; }

    }
}
