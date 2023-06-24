using Microsoft.AspNetCore.Mvc;

namespace ZombieParty.Controllers
{
    public class ZombieTypeController : Controller
    {
        public IActionResult Index()
        {

            this.ViewBag.MaListe = new List<Models.ZombieType>()
    {
            new Models.ZombieType(){TypeName= "Virus", Id=1},
        new Models.ZombieType(){TypeName= "Contact", Id=2}
    };

            return View();
        }
    }
}
