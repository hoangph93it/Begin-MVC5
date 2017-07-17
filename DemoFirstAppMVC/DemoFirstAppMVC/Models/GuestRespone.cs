using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoFirstAppMVC.Models
{
    public class GuestRespone
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? WillAtend { get; set; }
    }
}