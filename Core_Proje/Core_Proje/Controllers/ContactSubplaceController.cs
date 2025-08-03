using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ContactSubplaceController : Controller
    {
        ContactManager ContactManager = new ContactManager(new EfContactDal());

        [HttpGet]
        public IActionResult Index()
        {
            var values = ContactManager.TGetById(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            ContactManager.TUpdate(contact);
            return RedirectToAction("Index","Default");
        }
    }
}
