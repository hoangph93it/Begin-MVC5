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
    public class CardController : Controller
    {
        private IBeansRepository repository;
        public CardController(IBeansRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index(string returnUrl)
        {
            return View(new CardIndexViewModel
            {
                Cart = GetCard(),
                ReturnUrl = returnUrl
            });
        }
        public RedirectToRouteResult AddToCard(System.Int32 productId, string returnUrl)
        {
            Bean bean = repository.Beans.FirstOrDefault(b => b.ID == productId);
            if (bean != null)
            {
                GetCard().AddItem(bean, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        public RedirectToRouteResult RemoveFromCard(int productId, string returnUrl)
        {
            Bean bean = repository.Beans.FirstOrDefault(b => b.ID == productId);
            if (bean != null)
            {
                GetCard().RemoveLine(bean);
            }
            return RedirectToAction("Index", new { returnUrl });
        }


        private Cart GetCard()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }
    }
}