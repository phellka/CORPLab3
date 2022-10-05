using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreProductsDatabaseImplement.Logics;
using StoreProductsDatabaseImplement.Models;

namespace CORPLab3.PlaginMain
{
    public partial class FormProduct : Form
    {
        public int Id { set { id = value; } }
        private int? id;
        private ProductLogic productLogic = new ProductLogic();
        private UnitMeasurementLogic unitMeasurementLogic = new UnitMeasurementLogic();
        private bool flagChanges = false;
        public FormProduct()
        {
            InitializeComponent();
            lipatovTextBoxCountry.minLength = 10;
            lipatovTextBoxCountry.maxLength = 50;
            var units = unitMeasurementLogic.Read(null);
            for (int i = 0; i < units.Count; ++i)
            {
                ilbekovComboBoxMeasures.AddItem(units[i].Name);
            }
            ilbekovComboBoxMeasures.SelectedIndexChanged += SmthChanged;
            lipatovTextBoxCountry.CheckedTextBoxChanged += SmthChanged;
        }
        private void FormProduct_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    var view = productLogic.Read(new ProductViewModel { Id = id })?[0];
                    if (view != null)
                    {
                        textBoxName.Text = view.Name;
                        textBoxProviderOne.Text = view.ProviderOne;
                        textBoxProviderTwo.Text = view.ProviderTwo;
                        textBoxProviderThree.Text = view.ProviderThree;
                        lipatovTextBoxCountry.InputText = view.Country;
                        ilbekovComboBoxMeasures.ChoosenItem = view.UnitMeasurement;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
            flagChanges = false;
        }

        private void SmthChanged(object sender, EventArgs e)
        {
            flagChanges = true;
        }

        private void FormProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flagChanges)
            {
                if (MessageBox.Show("Сохранить изменения перед закрытием?", "Закрыть", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    save();
                }
            }
        }
        private void save()
        {
            if (textBoxName.Text != "" && ilbekovComboBoxMeasures.ChoosenItem != "" && lipatovTextBoxCountry.InputText != null)
            {
                flagChanges = false;
                if (id != null)
                {
                    productLogic.Update(new ProductViewModel()
                    {
                        Id = id,
                        Name = textBoxName.Text,
                        Country = lipatovTextBoxCountry.InputText,
                        ProviderOne = textBoxProviderOne.Text,
                        ProviderTwo = textBoxProviderTwo.Text,
                        ProviderThree = textBoxProviderThree.Text,
                        UnitMeasurement = ilbekovComboBoxMeasures.ChoosenItem
                    });
                }
                else
                {
                    productLogic.Create(new ProductViewModel()
                    {
                        Name = textBoxName.Text,
                        Country = lipatovTextBoxCountry.InputText,
                        ProviderOne = textBoxProviderOne.Text,
                        ProviderTwo = textBoxProviderTwo.Text,
                        ProviderThree = textBoxProviderThree.Text,
                        UnitMeasurement = ilbekovComboBoxMeasures.ChoosenItem
                    });
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Все пооля кроме поставщиков обязательны к заполнению");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            save();
        }
    }
}
