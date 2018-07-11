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
            ViewBag.Produto = new Produto();
            ViewBag.Categorias = dao.Lista();

            return View();
        }

        [HttpPost]
        public ActionResult Incluir(Produto produto)
        {
            if (ModelState.IsValid)
            {
                ProdutosDAO dao = new ProdutosDAO();
                dao.Adiciona(produto);

                return RedirectToAction("Index");
            }
            else
            {                
                CategoriasDAO categoriasDao = new CategoriasDAO();
                ViewBag.Categorias = categoriasDao.Lista();
                ViewBag.Produto = produto;

                return View("Cadastrar");
            }            
        }
    }
}