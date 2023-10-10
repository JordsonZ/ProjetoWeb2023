using Modelo.Tabelas;
using Persistencia.DAL.Tabelas;
using System.Linq;

namespace Servico.Tabelas
{
    public class CategoriaServico
    {
        private CategoriaDAL categoriaDAL = new CategoriaDAL();
        public IQueryable<Categoria> ObterCategoriasClassificadasPorNome()
        {
            return categoriaDAL.ObterCategoriasClassificadasPorNome();
        }
        public Categoria ObterCategoriaPorId(long id)
        {
            return categoriaDAL.ObterCategoriaPorId(id);
        }
        public void GravarCategoria(Categoria categoria)
        {
            categoriaDAL.GravarCategoria(categoria);
        }
        public Categoria EliminarCategoriaPorId(long id)
        {
            Categoria categoria = categoriaDAL.ObterCategoriaPorId(id);
            categoriaDAL.EliminarCategoriaPorId(id);
            return categoria;
        }
    }
}
