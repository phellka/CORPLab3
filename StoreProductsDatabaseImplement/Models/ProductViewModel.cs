using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace StoreProductsDatabaseImplement.Models
{
    public class ProductViewModel
    {
        [DisplayName("Идентификатор")]
        public int? Id { get; set; }

        [DisplayName("Название продуукта")]
        public string Name { get; set; }

        [DisplayName("Поставщик 1")]
        public string ProviderOne { get; set; }
        [DisplayName("Поставщик 2")]
        public string ProviderTwo { get; set; }
        [DisplayName("Поставщик 3")]
        public string ProviderThree { get; set; }
        [DisplayName("Единица измеренич")]
        public string UnitMeasurement { get; set; }
        [DisplayName("Страна")]
        public string Country { get; set; }
    }
}
