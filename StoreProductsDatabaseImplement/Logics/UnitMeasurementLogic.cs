using StoreProductsDatabaseImplement.Models;
using StoreProductsDatabaseImplement.Storages;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreProductsDatabaseImplement.Logics
{
    public class UnitMeasurementLogic
    {
        private readonly UnitMeasurementStorage measurementStorage = new UnitMeasurementStorage();
        public UnitMeasurementLogic(){}

        public List<UnitMeasurementViewModel> Read(UnitMeasurementViewModel model)
        {
            if (model == null)
            {
                return measurementStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<UnitMeasurementViewModel> { measurementStorage.GetElement(model) };
            }
            return null;
        }

        public void Create(UnitMeasurementViewModel model)
        {
            measurementStorage.Insert(model);
        }

        public void Update(UnitMeasurementViewModel model)
        {
            var element = measurementStorage.GetElement(model);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            measurementStorage.Update(model);
        }

        public void Delete(UnitMeasurementViewModel model)
        {
            var element = measurementStorage.GetElement(model);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            measurementStorage.Delete(model);
        }
    }
}
