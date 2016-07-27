using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Util;
using OrdenesAdmCL.Entities;
using OrdenesAdmCL.Repositorios.Interfaces;
using OrdenesAdmCL.Contexto;

namespace OrdenesAdmCL.Repositorios
{
    public class RolRepository:Repository<Rol>,IRolRepository
    {
        public RolRepository(Context contexto):base(contexto)
        {

        }

        public Context Contexto
        {
            get { return base.Contexto as Context; }
        }
    }
}
