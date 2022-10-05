using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CORPLab3.Plugins;

namespace CORPLab3.PlaginMain
{
    public class ProductConventionElement : PluginsConventionElement
    {
        public string Name { get; set; }
        public string UnitMeasurement { get; set; }
        public string Country { get; set; }
    }
}
