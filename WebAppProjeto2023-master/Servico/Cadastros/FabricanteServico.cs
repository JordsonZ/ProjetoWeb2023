using Modelo.Cadastros;
using Persistencia.DAL.Cadastros;
using System.Linq;

namespace Servico.Cadastros
{
    public class FabricanteServico
    {
        private FabricanteDAL fabricanteDAL = new FabricanteDAL();
        public IQueryable<Fabricante> ObterFabricantesClassificadosPorNome()
        {
            return fabricanteDAL.ObterFabricantesClassificadosPorNome();
        }
        public Fabricante ObterFabricantePorId(long id)
        {
            return fabricanteDAL.ObterFabricantePorId(id);
        }
        public void GravarFabricante(Fabricante fabricante)
        {
            fabricanteDAL.GravarFabricante(fabricante);
        }
        public Fabricante EliminarFabricantePorId(long id)
        {
            Fabricante fabricante = fabricanteDAL.ObterFabricantePorId(id);
            fabricanteDAL.EliminarFabricantePorId(id);
            return fabricante;
        }
    }
}
