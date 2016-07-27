using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesAdmCL.Entities
{
    public interface IBaseOrdenes<TEntity> where TEntity : class 
    {
        void Agregar(TEntity entity);
        List<TEntity> CargarDatos();
        void Eliminar(TEntity entity);
		bool Modificar(TEntity entity);
		TEntity ObtenerEntidadById(int Id);
		List<TEntity> ObtenerTodos(Expression<Func<TEntity, bool>> expresion);
    }
}
