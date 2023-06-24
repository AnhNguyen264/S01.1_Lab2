using Microsoft.AspNetCore.Mvc;


namespace ZombieParty.Controllers
{
    public class ZombieController : Controller
    {
        public IActionResult Index()
        {

            this.ViewBag.MaListe = new List<Models.Zombie>()
            {
                new Models.Zombie(){Name= "LeChuck", Point=5, Type="Fiction",},
                new Models.Zombie(){Name= "Lenore", Point=4, Type="Fiction",},
                new Models.Zombie(){Name= "Draugr", Point=2, Type="Légendaire",},
                new Models.Zombie(){Name= "Ragamuffin", Point=5, Type="Légendaire",},
                new Models.Zombie(){Name= "Taxidermy", Point=1, Type="Légendaire",},
                new Models.Zombie(){Name= "chien de l'enfer", Point=7, Type="Fiction",},
                new Models.Zombie(){Name= "Avogadro", Point=9, Type="Fiction",}
            };

            return View();
        }
    }
}
