using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using domain.Entities;

namespace web.ui.Models
{
    public class CardIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}