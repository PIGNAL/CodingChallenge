using CodingChallenge.DataAccess;
using CodingChallenge.BusinessLogic;
using System.Linq;
using System.Web.Mvc;
using CodingChallenge.ClassExtension;

namespace CodingChallenge.Controllers
{
    public class TitlesController : Controller
    {
        TitleHandler titleHandler = new TitleHandler(new TitleRepository());
        public ActionResult Seeker()
        {
            return View();
        }
        public JsonResult GetTitles()
        {
            var titles = titleHandler.ToList();
            var names = titles.Select(x => new { label = x.Name, value = x.TitleId }).ToList();
            return Json(names, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetDetail(int id)
        {
            var title = titleHandler.Search(id);
            return Json(title.ConvertToViewModel(), JsonRequestBehavior.AllowGet);
        }
    }
}