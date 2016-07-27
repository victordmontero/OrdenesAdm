using OrdenesAdmCL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesAdm.Controladores
{
    public class Controlador
    {
        private UnidadDeTrabajo udt;
        public UnidadDeTrabajo UDT 
        {
            get { return udt = udt ?? new UnidadDeTrabajo(); }
            set { this.udt = value; }
        }
    }
}
