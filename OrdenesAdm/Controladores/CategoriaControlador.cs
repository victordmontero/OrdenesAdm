using OrdenesAdm.Forms;
using OrdenesAdmCL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesAdm.Controladores
{
    public class CategoriaControlador : Controlador
    {
        public CategoriaFrm CategoriaVista { get; set; }

        public void Guardar(string descripcion)
        {
            var cate = new Categoria()
            {
                Descripcion = descripcion,
                Estado = true
            };

            UDT.categoriaRepository.Agregar(cate);
            UDT.Completar();
        }

        public List<Categoria> ObtenerTodos()
        {
            return UDT.categoriaRepository.Encontrar(c => c.Estado).ToList();
        }

        public void Eliminar(int id)
        {
            UDT.categoriaRepository.ObtenerUno(id).Estado = false;
            UDT.Completar();
        }
    }
}
