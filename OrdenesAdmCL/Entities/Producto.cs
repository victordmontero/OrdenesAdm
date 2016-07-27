using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrdenesAdmCL.Entities;

namespace OrdenesAdmCL.Entities
{
    public class Producto : BaseEntity
    {
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        public int SuplidorId { get; set; }
        public Suplidor Suplidor { get; set; }
    }
}
