using MvcApplication1.Models;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var pessoa = new Pessoa
            {
                PessoaId = 10,
                Nome = "Igor Martinelli",
                Twitter = "@GuiiMartinelli"
            };
            return View(pessoa);
        }
        
        [HttpPost]
        public ActionResult Lista(Pessoa p)
        {
            return View(p);
        }
    }
}
