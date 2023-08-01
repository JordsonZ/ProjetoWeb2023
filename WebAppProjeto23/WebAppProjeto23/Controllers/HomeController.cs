using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppProjeto23.Models;
using Modelo.Tabelas;
using Modelo.Cadastros;
using Servico.Cadastros;
using Servico.Tabelas;

namespace WebAppProjeto23.Controllers
{
    public class HomeController : Controller
    {
        //private EFContext context = new EFContext();
        // GET: Home
        private ProdutoServico produtoServico = new ProdutoServico();
        private CategoriaServico categoriaServico = new CategoriaServico();
        private FabricanteServico fabricanteServico = new FabricanteServico();


        public ActionResult Index(long? FabId, long? CatId)
        {
            Home h = new Home();
            h.fabricantes = fabricanteServico.ObterFabricantesClassificadosPorNome();
            h.categorias = categoriaServico.ObterCategoriasClassificadasPorNome();
            if (FabId != null)
            {
                h.filtro = "Fabricante";
                h.produtos = produtoServico.ObterProdutosClassificadosPorNome().Where(p => p.FabricanteId == FabId);
            }

            if (CatId != null)
            {
                h.filtro = "Categoria";
                h.produtos = produtoServico.ObterProdutosClassificadosPorNome().Where(p => p.CategoriaId == CatId);
            }
            return View(h);
        }

    }
}