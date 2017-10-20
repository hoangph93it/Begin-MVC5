using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TemplateHelpMethod.Interface;
using TemplateHelpMethod.Models;

namespace TemplateHelpMethod.Implement
{
    public class EPersons : IPersons
    {
        private List<Person> listPersons = new List<Person>()
        {
           new Person()
           {
               PersonID=1,
               FirstName="Phan Huu",
               LastName="Hoang",
               DOB= "18/08/1993",
               //HomeAddress= {
               //  Line1="So 40, Thon Phu Chinh, Xa Tuan Chinh, Huyen Vinh Tuong, Tinh Vinh Phuc",
               //  Line2="So 28, Ngo 1, duong Van Tien Dung, Phuong Phuc Dien, Quan Nam Tu Liem, Tp.Ha Noi",
               //  City="Ha Noi",
               //  Country="Viet Nam"
               //},
               Role= Roles.Admin
           },
           new Person()
           {
               PersonID=1,
               FirstName="Tran Kim",
               LastName="Phuoc",
               DOB= "27/01/1997",
               //HomeAddress= {
               //  Line1="So 40, Thon Phu Chinh, Xa Tuan Chinh, Huyen Vinh Tuong, Tinh Vinh Phuc",
               //  Line2="So 28, Ngo 1, duong Van Tien Dung, Phuong Phuc Dien, Quan Nam Tu Liem, Tp.Ha Noi",
               //  City="Ha Noi",
               //  Country="Viet Nam"
               //},
               Role= Roles.User
           }
        };

        public IList<Person> GetAllPersons()
        {
            var persons = this.listPersons.Select(p => p);
            return persons.ToList();
        }
    }
}