using OrdenesAdmCL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesAdmCL.Entities
{
    public abstract class Persona : BaseEntity
    {
        public TipoPersona TipoPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
    }

    
}
