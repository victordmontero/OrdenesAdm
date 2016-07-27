using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrdenesAdmCL.Entities;

namespace OrdenesAdmCL.Entities
{
    public class Suplidor : Persona
    {
        public int SuplidorId { get; set; }
        public string Empresa { get; set; }
        public string VmailEmpresa { get; set; }
        public string PagWeb { get; set; }
        public string TelEmpresa { get; set; }
        public string RNC { get; set; }
        public ICollection<Producto> Productos { get; set; }
    }
}
