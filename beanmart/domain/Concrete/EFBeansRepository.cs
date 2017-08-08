using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domain.Abstract;
using domain.Entities;
namespace domain.Concrete
{
    public class EFBeansRepository : IBeansRepository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Bean> Beans
        {
            get
            {
                return context.Beans;
            }
        }
    }
}
