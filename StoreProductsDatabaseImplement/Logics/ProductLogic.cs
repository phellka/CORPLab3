using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreProductsDatabaseImplement.Models;
using StoreProductsDatabaseImplement.Storages;

namespace StoreProductsDatabaseImplement.Logics
{
    public class ProductLogic
    {
        private readonly ProductStorage productStorage = new ProductStorage();
        public ProductLogic() { }

        public List<ProductViewModel> Read(ProductViewModel model)
        {
            if (model == null)
            {
                return productStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<ProductViewModel> { productStorage.GetElement(model) };
            }
            return null;
        }

        public void Create(ProductViewModel model)
        {
            productStorage.Insert(model);
        }

        public void Update(ProductViewModel model)
        {
            var element = productStorage.GetElement(model);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            productStorage.Update(model);
        }

        public void Delete(ProductViewModel model)
        {
            var element = productStorage.GetElement(model);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            productStorage.Delete(model);
        }
    }
}
