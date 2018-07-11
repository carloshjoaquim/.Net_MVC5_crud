using Estoque.DAO;
using Estoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Estoque.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
            CategoriasDAO categoria = new CategoriasDAO();
            var categorias = categoria.Lista();
            ViewBag.Categorias = categorias;

            return View();
        }

        public ActionResult Cadastrar()
        {

            return View();
        }

        public ActionResult Incluir(CategoriaDoProduto categoria)
        {
            CategoriasDAO dao = new CategoriasDAO();
            dao.Adiciona(categoria);

            return RedirectToAction("Index");
        }
    }
}