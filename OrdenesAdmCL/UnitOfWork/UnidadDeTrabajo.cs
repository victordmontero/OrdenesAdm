using OrdenesAdmCL.Contexto;
using OrdenesAdmCL.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesAdmCL.UnitOfWork
{
    public class UnidadDeTrabajo : IUnidadDeTrabajo
    {
        public Context Contexto { get; set; }

        public CategoriaRepository categoriaRepository { get; set; }
        public ClienteRepository clienteRepository { get; set; }
        public ProductoRepository productoRepositoty { get; set; }
        public RolRepository rolRepository { get; set; }
        public SuplidorRepository suplidorRepository { get; set; }
        public UsuarioRepository usuarioRepository { get; set; }

        public UnidadDeTrabajo()
        {
            Contexto = new Context();
            categoriaRepository = new CategoriaRepository(Contexto);
            clienteRepository = new ClienteRepository(Contexto);
            productoRepositoty = new ProductoRepository(Contexto);
            rolRepository = new RolRepository(Contexto);
            suplidorRepository = new SuplidorRepository(Contexto);
            usuarioRepository = new UsuarioRepository(Contexto);
        }

        public void Completar()
        {
            categoriaRepository.Contexto.SaveChanges();
            clienteRepository.Contexto.SaveChanges();
            productoRepositoty.Contexto.SaveChanges();
            rolRepository.Contexto.SaveChanges();
            suplidorRepository.Contexto.SaveChanges();
            usuarioRepository.Contexto.SaveChanges();
        }
    }
}
