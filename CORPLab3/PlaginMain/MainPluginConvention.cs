using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CORPLab3.Plugins;
using MadyshevVisualComponents;
using StoreProductsDatabaseImplement.Logics;
using MadyshevVisualComponents.models;
using StoreProductsDatabaseImplement.Models;
using MadyshevUnvisualComponents;
using MadyshevUnvisualComponents.Models;

namespace CORPLab3.PlaginMain
{
    public class MainPluginConvention : IPluginsConvention
    {
        private MadyshevDataGridView dataGridView = new MadyshevDataGridView();
        private ProductLogic productLogic = new ProductLogic();
        public MainPluginConvention()
        {
            dataGridView.AddColumns(new List<TableData>() {
                new TableData() { Header = "Country", PropertyName = "Country", Visible = true, Width = 250},
                new TableData() { Header = "Id", PropertyName = "Id", Visible = true, Width = 150},
                new TableData() { Header = "Name", PropertyName = "Name", Visible = true, Width = 300},
                new TableData() { Header = "UnitMeasurement", PropertyName = "UnitMeasurement", Visible = true, Width = 220 } });
            ReloadData();
        }
        public string PluginName
        {
            get
            {
                return "Продукты";
            }
        }
        public UserControl GetControl
        {
            get
            {
                return dataGridView;
            }
        }

        public PluginsConventionElement GetElement
        {
            get
            {
                return dataGridView.GetSelectedObjectIntoRow<PluginsConventionElement>();
            }
        }
        public bool DeleteElement(PluginsConventionElement element)
        {
            try
            {
                productLogic.Delete(new ProductViewModel() { Id = element.Id });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public void ReloadData()
        {
            dataGridView.ClearRows();
            var rows = productLogic.Read(null);
            for (int i = 0; i < rows.Count(); ++i)
            {
                dataGridView.AddRow<ProductConventionElement>(new ProductConventionElement()
                {
                    Country = rows[i].Country,
                    Name = rows[i].Name,
                    UnitMeasurement = rows[i].UnitMeasurement,
                    Id = (int)rows[i].Id
                });
            }
        }
        public Form GetForm(PluginsConventionElement element)
        {
            FormProduct formProduct = new FormProduct();
            if (element != null)
            {
                formProduct.Id = element.Id;
            }
            return formProduct;
        }
        public bool CreateChartDocument(PluginsConventionSaveDocument saveDocument)
        {
            throw new NotImplementedException();
        }
        public bool CreateSimpleDocument(PluginsConventionSaveDocument saveDocument)
        {
            try
            {
                MadyshevDocTablesComponent tablesComponent = new MadyshevDocTablesComponent();
                var products = productLogic.Read(null);
                string[,] strings = new string[products.Count + 1, 3];
                strings[0, 0] = "Поставщик 1";
                strings[0, 1] = "Поставщик 2";
                strings[0, 2] = "Поставщик 3";
                for (int i = 0; i < products.Count; ++i)
                {
                    strings[i + 1, 0] = products[i].ProviderOne;
                    strings[i + 1, 1] = products[i].ProviderTwo;
                    strings[i + 1, 2] = products[i].ProviderThree;
                }
                tablesComponent.CreateDoc(saveDocument.FileName, "Поставщики", new List<string[,]>() { strings });
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
        public bool CreateTableDocument(PluginsConventionSaveDocument saveDocument)
        {
            throw new NotImplementedException();
        }
    }
}
