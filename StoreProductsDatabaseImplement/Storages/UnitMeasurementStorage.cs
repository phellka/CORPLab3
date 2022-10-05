using StoreProductsDatabaseImplement.Models;
using StoreProductsDatabaseImplement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace StoreProductsDatabaseImplement.Storages
{
    public class UnitMeasurementStorage
    {
        public List<UnitMeasurementViewModel> GetFullList()
        {
            using (var context = new StoreProductsDatabase())
            {
                return context.UnitsMeasurement.Select(CreateModel).ToList();
            }
        }
        public UnitMeasurementViewModel GetElement(UnitMeasurementViewModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new StoreProductsDatabase())
            {
                var unitOfMeasurement = context.UnitsMeasurement.FirstOrDefault(rec => rec.Id == model.Id);
                return unitOfMeasurement != null ? CreateModel(unitOfMeasurement) : null;
            }
        }

        public void Insert(UnitMeasurementViewModel model)
        {
            using (var context = new StoreProductsDatabase())
            {
                context.UnitsMeasurement.Add(CreateModel(model, new UnitMeasurement()));
                context.SaveChanges();
            }
        }

        public void Update(UnitMeasurementViewModel model)
        {
            using (var context = new StoreProductsDatabase())
            {
                UnitMeasurement unitMeasurement = context.UnitsMeasurement.FirstOrDefault(rec => rec.Id == model.Id);
                if (unitMeasurement == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, unitMeasurement);
                context.SaveChanges();
            }
        }

        public void Delete(UnitMeasurementViewModel model)
        {
            using (var context = new StoreProductsDatabase())
            {
                UnitMeasurement unitMeasurement = context.UnitsMeasurement.FirstOrDefault(rec => rec.Id == model.Id);
                if (unitMeasurement != null)
                {
                    context.UnitsMeasurement.Remove(unitMeasurement);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }
        private UnitMeasurementViewModel CreateModel(UnitMeasurement unitOfMeasurement)
        {
            return new UnitMeasurementViewModel
            {
                Id = unitOfMeasurement.Id,
                Name = unitOfMeasurement.Name
            };
        }
        private UnitMeasurement CreateModel(UnitMeasurementViewModel model, UnitMeasurement unitOfMeasurement)
        {
            unitOfMeasurement.Name = model.Name;
            return unitOfMeasurement;
        }
    }
}
