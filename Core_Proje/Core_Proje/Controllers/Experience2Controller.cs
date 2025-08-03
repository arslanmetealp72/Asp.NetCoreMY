using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Core_Proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class Experience2Controller : Controller
    {
        ExperienceManager ExperienceManager = new ExperienceManager(new EfExperienceDal());

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListExperience()
        {
            var values = JsonConvert.SerializeObject(ExperienceManager.TGetList());
            return Json(values);
        }
        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            ExperienceManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }
        public IActionResult GetById(int ExperienceId)
        {
            var values = ExperienceManager.TGetById(ExperienceId);
            var values2 = JsonConvert.SerializeObject(values);
            return Json(values2);
        }

        public IActionResult DeleteExperience(int id)
        {
            var values = ExperienceManager.TGetById(id);
            ExperienceManager.TDelete(values);
            return NoContent();
        }
    }
}
