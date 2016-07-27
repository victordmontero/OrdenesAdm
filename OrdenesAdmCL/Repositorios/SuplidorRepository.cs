using OrdenesAdmCL.Contexto;
using OrdenesAdmCL.Entities;
using OrdenesAdmCL.Repositorios.Interfaces;
using Repositorio.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesAdmCL.Repositorios
{
    public class SuplidorRepository:Repository<Suplidor>,ISuplidorRepository
    {
        public SuplidorRepository(Context contexto):base(contexto)
        {

        }

        public Context Contexto
        {
            get { return base.Contexto as Context; }
        }
    }
}
