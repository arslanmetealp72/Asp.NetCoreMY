using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ServiceController : Controller
    {
        ServiceManager ServiceManager = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
            var values = ServiceManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            ServiceManager.TAdd(service);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteService(int id)
        {
            var value = ServiceManager.TGetById(id);
            ServiceManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditService(int id)
        {
            var value = ServiceManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditService(Service service)
        {
            ServiceManager.TUpdate(service);
            return RedirectToAction("Index");
        }
    }
}
