using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using domain.Abstract;
namespace web.ui.Controllers
{
    public class NavController : Controller
    {
        private IBeansRepository repository;
        public NavController(IBeansRepository repo)
        {
            repository = repo;
        }
        public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;
            IEnumerable<string> categories = repository.Beans.Select(c => c.Category).Distinct().OrderBy(c => c);
            return PartialView(categories);
        }
    }
}