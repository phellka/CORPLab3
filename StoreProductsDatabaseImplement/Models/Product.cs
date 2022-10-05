using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreProductsDatabaseImplement.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ProviderOne { get; set; }
        [Required]
        public string ProviderTwo { get; set; }
        [Required]
        public string ProviderThree { get; set; }

        [Required]
        public string UnitMeasurement { get; set; }

        [Required]
        public string Country { get; set; }
    }
}
