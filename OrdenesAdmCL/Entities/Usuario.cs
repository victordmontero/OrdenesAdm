using OrdenesAdmCL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesAdmCL.Entities
{
    public class Usuario : Persona
    {
        public int UsuarioId { get; set; }
        public int RolId { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
