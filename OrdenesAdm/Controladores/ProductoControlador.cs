using OrdenesAdm.Forms;
using OrdenesAdmCL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesAdm.Controladores
{
    public class ProductoControlador : Controlador
    {
        public ProductoFrm ProductoVista { get; set; }

        public void Guardar(int categoriaId, int suplidorId, string descripcion, decimal precio)
        {
            var producto = new Producto()
            {
                Descripcion = descripcion,
                Precio = precio,
                CategoriaId = categoriaId,
                SuplidorId = suplidorId,
                Estado = true
            };
            UDT.productoRepositoty.Agregar(producto);
            UDT.Completar();
        }

        public List<Producto> ObtenerTodos()
        {
            return UDT.productoRepositoty.Encontrar(c => c.Estado).ToList();
        }

        public List<Categoria> ObtenerCategorias()
        {
            return UDT.categoriaRepository.Encontrar(c => c.Estado).ToList();
        }

        public List<Suplidor> ObtenerSuplidores()
        {
            return UDT.suplidorRepository.Encontrar(c => c.Estado).ToList();
        }

        public void Eliminar(int id)
        {
            UDT.productoRepositoty.ObtenerUno(id).Estado = false;
            UDT.Completar();
        }
    }
}
