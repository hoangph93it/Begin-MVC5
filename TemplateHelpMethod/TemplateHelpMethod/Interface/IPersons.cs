using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TemplateHelpMethod.Models;

namespace TemplateHelpMethod.Interface
{
    public interface IPersons
    {
        IList<Models.Person> GetAllPersons();
    }
}