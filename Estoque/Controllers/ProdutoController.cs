using Estoque.DAO;
using Estoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaelumEstoque.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            var produtosDAO = new ProdutosDAO();
            var produtos = produtosDAO.Lista();
            ViewBag.Produtos = produtos;

            return View();
        }

        public ActionResult Cadastrar()
        {
            CategoriasDAO dao = new CategoriasDAO();
            var categorias = dao.Lista();
            ViewBag.Categorias = categorias;

            return View();
        }

        [HttpPost]
        public ActionResult Incluir(Produto produto)
        {
            ProdutosDAO dao = new ProdutosDAO();
            dao.Adiciona(produto);

            return RedirectToAction("Index");
        }
    }
}