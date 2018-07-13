using Estoque.DAO;
using System.Web.Mvc;

namespace Estoque.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Logar(string login, string senha)
        {
            var dao = new UsuariosDAO();
            var usuario = dao.Busca(login, senha);

            if (usuario != null)
            {
                Session["usuarioLogado"] = usuario;
                return RedirectToAction("Index", "Produto");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public ActionResult Logout()
        {
            Session["usuarioLogado"] = null;

            return RedirectToAction("Index");
        }
    }
}