using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class FeatureController : Controller
    {
        FeatureManager FeatureManager = new FeatureManager(new EfFeatureDal());
        [HttpGet]
        public IActionResult Index()
        {
            var values = FeatureManager.TGetById(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            FeatureManager.TUpdate(feature);
            return RedirectToAction("Index","Default");
        }
    }
}
