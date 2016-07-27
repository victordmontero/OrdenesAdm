using OrdenesAdm.Forms;
using OrdenesAdmCL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesAdm.Controladores
{
    public class SuplidorControlador : Controlador
    {
        public SuplidorFrm SuplidorVista { get; set; }

        public void Guardar(string Rnc, string nombre, string vmail, string telefono)
        {
            var suplidor = new Suplidor()
            {
                RNC = Rnc,
                Nombre = nombre,
                VmailEmpresa = vmail,
                TelEmpresa = telefono,
                Estado = true
            };
            UDT.suplidorRepository.Agregar(suplidor);
            UDT.Completar();
        }

        public List<Suplidor> ObtenerTodos()
        {
            return UDT.suplidorRepository.Encontrar(c => c.Estado).ToList();
        }

        public void Eliminar(int id)
        {
            UDT.suplidorRepository.ObtenerUno(id).Estado = false;
            UDT.Completar();
        }
    }
}
