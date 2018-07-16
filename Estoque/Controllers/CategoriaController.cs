using Estoque.DAO;
using Estoque.Filtros;
using Estoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Estoque.Controllers
{
    [AutorizacaoFilter]
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

        [ValidateAntiForgeryToken]
        public ActionResult Incluir(CategoriaDoProduto categoria)
        {
            CategoriasDAO dao = new CategoriasDAO();
            dao.Adiciona(categoria);

            return RedirectToAction("Index");
        }

        public ActionResult Editar(CategoriaDoProduto categoria)
        {
            return View(categoria);
        }

        [HttpPost]
        public ActionResult EditaCategoria(int id, string name, string descricao)
        {
            var categoria = new CategoriaDoProduto
            {
                Id = id,
                Nome = name,
                Descricao = descricao
            };

            CategoriasDAO dao = new CategoriasDAO();
            dao.Atualiza(categoria);

            return Json(categoria);
        }

        public ActionResult Excluir(CategoriaDoProduto categoria)
        {
            CategoriasDAO dao = new CategoriasDAO();
            dao.Remove(categoria);

            return RedirectToAction("Index");

        }



    }
}