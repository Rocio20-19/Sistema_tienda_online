using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema_tienda_online.Models
{
    public partial class Producto
    {
        public Producto()
        {
            Detalles = new HashSet<Detalle>();
        }

        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal? Precio { get; set; }
        public int? Stock { get; set; }
        public int? IdCategoria { get; set; }

        public virtual Categorium IdCategoriaNavigation { get; set; }
        public virtual ICollection<Detalle> Detalles { get; set; }
    }
}
