using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrdenesAdmCL.Entities;

namespace OrdenesAdmCL.Entities
{
    public class Categoria : BaseEntity
    {
        public int CategoriaId { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
    }
}
