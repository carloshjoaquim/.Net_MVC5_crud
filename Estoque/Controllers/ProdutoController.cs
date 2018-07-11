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

            return View(produtos);
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

            var categorias = new CategoriasDAO().Lista();


            if (produto.CategoriaId.Equals(categorias.Where(c =>c.Nome.Equals("Alimentos")).FirstOrDefault().Id) 
                && produto.Preco < 0.10)
            {
                ModelState.AddModelError("alimentos", "O preço de produtos de alimentação devem ser maiores ou iguais a R$ 0.10 !");
            }

            if (ModelState.IsValid)
            {
                ProdutosDAO dao = new ProdutosDAO();
                dao.Adiciona(produto);

                return RedirectToAction("Index");
            }
            else
            {                
                ViewBag.Categorias = categorias;
                ViewBag.Produto = produto;

                return View("Cadastrar");
            }            
        }

        public ActionResult Detalhe(int id)
        {
            var produto = new ProdutosDAO().BuscaPorId(id);
            ViewBag.Produto = produto;

            return View(produto);
        }

    }
}