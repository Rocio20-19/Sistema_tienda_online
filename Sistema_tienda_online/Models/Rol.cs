using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
#nullable disable

namespace Sistema_tienda_online.Models
{
    public class Rol
    {
        public Rol()
        {      
        }
        [Key]
        public int IdRol { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

    }
}
