using CodingChallenge.BusinessLogic;
using System.Linq;
using System.Web.Mvc;
using CodingChallenge.ClassExtension;

namespace CodingChallenge.Controllers
{
    public class TitlesController : Controller
    {
        TitleHandler titleHandler = new TitleHandler();
        public ActionResult Seeker()
        {
            return View();
        }
        public JsonResult GetTitles()
        {
            var titles = titleHandler.GetTitles();
            var names = titles.Select(x => new { label = x.Descripcion, value = x.Id }).ToList();
            return Json(names, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetDetail(int id)
        {
            var title = titleHandler.Search(id);
            return Json(title.ConvertToViewModel(), JsonRequestBehavior.AllowGet);
        }
    }
}