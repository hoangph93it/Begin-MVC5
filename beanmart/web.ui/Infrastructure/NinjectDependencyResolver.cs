using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using Moq;
using domain.Entities;
using domain.Abstract;
using domain.Concrete;
namespace web.ui.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            //Mock<IBeansRepository> mock = new Mock<IBeansRepository>();
            //mock.Setup(m => m.Beans).Returns(new List<Bean>
            //{
            //   new Bean {Name="Đậu rùa nướng", Price=1000 },
            //   new Bean {Name="Đậu rùa trắng", Price=800 },
            //   new Bean {Name="Đậu trắng thường", Price=500 }
            //});
            kernel.Bind<IBeansRepository>().To<EFBeansRepository>();
        }
    }
}