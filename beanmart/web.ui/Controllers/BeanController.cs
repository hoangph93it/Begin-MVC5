using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using domain.Abstract;
using domain.Entities;
using web.ui.Models;

namespace web.ui.Controllers
{
    public class BeanController : Controller
    {
        private IBeansRepository repository;
        public int PageSize = 5;
        public BeanController(IBeansRepository beanRepository)
        {
            this.repository = beanRepository;
        }
        public ViewResult ListBean(string category, int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel
            {
                Beans = repository.Beans.Where(b => category == null || b.Category == category).OrderBy(b => b.ID).Skip((page - 1) * PageSize).Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemPerPage = PageSize,
                    TotalItems = category == null ? repository.Beans.Count() : repository.Beans.Where(e => e.Category == category).Count()
                },
                CurrentCategory = category
            };
            return View(model);
        }

    }
}