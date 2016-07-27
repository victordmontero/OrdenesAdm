using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrdenesAdmCL.Entities;

namespace OrdenesAdmCL.Entities
{
    public class Rol : BaseEntity
    {
        public int RolId { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
