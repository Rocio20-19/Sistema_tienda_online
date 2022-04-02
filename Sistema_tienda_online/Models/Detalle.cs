using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema_tienda_online.Models
{
    public partial class Detalle
    {
        public int IdDetalle { get; set; }
        public int IdFactura { get; set; }
        public int? IdProducto { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Precio { get; set; }

        public virtual Factura IdFacturaNavigation { get; set; }
        public virtual Producto IdProductoNavigation { get; set; }
    }
}
