using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
#nullable disable

namespace Sistema_tienda_online.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            
        }
        [Key]
        public int IdUsuario { get; set; }
        public int? IdRol { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime? FechaNac { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

    }
}
