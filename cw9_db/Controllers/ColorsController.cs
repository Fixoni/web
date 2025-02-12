using cw9_db.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw9_db.Controllers
{
    public class ColorsController : Controller
    {
        // GET: ColorsController
        public ActionResult Show()
        {
             return View(MyColor.GetColors());
        }

    }
}
