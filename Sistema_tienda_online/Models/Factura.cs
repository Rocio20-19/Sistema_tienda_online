using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema_tienda_online.Models
{
    public partial class Factura
    {
        public Factura()
        {
            Detalles = new HashSet<Detalle>();
        }

        public int IdFactura { get; set; }
        public int? IdCliente { get; set; }
        public decimal? Precio { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual Usuario IdClienteNavigation { get; set; }
        public virtual ICollection<Detalle> Detalles { get; set; }
    }
}
