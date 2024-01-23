using FluentValidation;
using Northwind.Bussiness.Abstract;
using Northwind.Bussiness.Utilities;
using Northwind.Bussiness.ValidationRules.FluentValidation;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bussiness.Concrete
{
    public class ProductManager:IProductService //Manager genelde iş katmanları için kullanılan standart bir isimlendirmedir. Değişkenlik gösterebilir. 
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            try //Hata yönetimi bu şekilde bussiness katmanında yapılır. 
            {
                _productDal.Delete(product);

            }
            catch
            {
                throw new Exception("Silme Gerçekleşemedi!");
            }
        }

        public List<Product> GetAll()
        {
            //Bussiness code
            return _productDal.GetAll();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryID == categoryId);
        }

        public List<Product> GetProductsByProductName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
        }

        public void Update(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Update(product);
        }
    }
}
