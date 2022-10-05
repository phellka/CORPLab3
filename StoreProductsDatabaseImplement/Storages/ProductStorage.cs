using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreProductsDatabaseImplement.Models;
using StoreProductsDatabaseImplement;

namespace StoreProductsDatabaseImplement.Storages
{
    public class ProductStorage
    {
        public List<ProductViewModel> GetFullList()
        {
            using (var context = new StoreProductsDatabase())
            {
                return context.Products.Select(CreateModel).ToList();
            }
        }

        public ProductViewModel GetElement(ProductViewModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new StoreProductsDatabase())
            {
                var product = context.Products.FirstOrDefault(rec => rec.Id == model.Id);
                return product != null ? CreateModel(product) : null;
            }
        }

        public void Insert(ProductViewModel model)
        {
            using (var context = new StoreProductsDatabase())
            {
                context.Products.Add(CreateModel(model, new Product()));
                context.SaveChanges();
            }
        }

        public void Update(ProductViewModel model)
        {
            using (var context = new StoreProductsDatabase())
            {
                Product product = context.Products.FirstOrDefault(rec => rec.Id == model.Id);
                if (product == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, product);
                context.SaveChanges();
            }
        }

        public void Delete(ProductViewModel model)
        {
            using (var context = new StoreProductsDatabase())
            {
                Product product = context.Products.FirstOrDefault(rec => rec.Id == model.Id);
                if (product != null)
                {
                    context.Products.Remove(product);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        private ProductViewModel CreateModel(Product product)
        {
            return new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                UnitMeasurement = product.UnitMeasurement,
                Country = product.Country,
                ProviderOne = product.ProviderOne,
                ProviderTwo = product.ProviderTwo,
                ProviderThree = product.ProviderThree,
            };
        }

        private Product CreateModel(ProductViewModel model, Product product)
        {
            product.Name = model.Name;
            product.UnitMeasurement = model.UnitMeasurement;
            product.Country = model.Country;
            product.ProviderOne = model.ProviderOne;
            product.ProviderTwo = model.ProviderTwo;
            product.ProviderThree = model.ProviderThree;
            return product;
        }
    }
}
