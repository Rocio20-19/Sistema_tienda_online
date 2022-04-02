using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
#nullable disable

namespace Sistema_tienda_online.Models
{
    public class Producto
    {
        public Producto()
        {
           
        }
        [Key]
        public int Id_producto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int? Stock { get; set; }
        public int Id_categoria { get; set; }

    }
}
