using Ninject.Modules;
using Northwind.Bussiness.Abstract;
using Northwind.Bussiness.Concrete;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bussiness.DependencyResolvers.Ninject
{
    public class BussinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>();
            Bind<IProductDal>().To<EfProductDal>();

            Bind<ICategoryService>().To<CategoryManager>();
            Bind<ICategoryDal>().To<EfCategoryDal>();
        }
    }
}
