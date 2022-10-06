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
    public partial class FormUnits : Form
    {
        UnitMeasurementLogic unitMeasurementLogic = new UnitMeasurementLogic();
        List<UnitMeasurementViewModel> list;
        public FormUnits()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                list = unitMeasurementLogic.Read(null);
                if (list != null)
                {
                    dataGridViewUnits.DataSource = list;
                    dataGridViewUnits.Columns[0].Visible = false;
                    dataGridViewUnits.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormUnits_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridViewUnits_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var typeName = (string)dataGridViewUnits.CurrentRow.Cells[1].Value;
            if (!string.IsNullOrEmpty(typeName))
            {
                if (dataGridViewUnits.CurrentRow.Cells[0].Value != null)
                {
                    unitMeasurementLogic.Update(new UnitMeasurementViewModel()
                    {
                        Id = Convert.ToInt32(dataGridViewUnits.CurrentRow.Cells[0].Value),
                        Name = (string)dataGridViewUnits.CurrentRow.Cells[1].EditedFormattedValue
                    });
                }
                else
                {
                    unitMeasurementLogic.Create(new UnitMeasurementViewModel()
                    {
                        Name = (string)dataGridViewUnits.CurrentRow.Cells[1].EditedFormattedValue
                    });
                }
            }
            else
            {
                MessageBox.Show("Введена пустая строка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void dataGridViewUnits_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Insert)
            {
                if (dataGridViewUnits.Rows.Count == 0)
                {
                    list.Add(new UnitMeasurementViewModel());
                    dataGridViewUnits.DataSource = new List<UnitMeasurementViewModel>(list);
                    dataGridViewUnits.CurrentCell = dataGridViewUnits.Rows[0].Cells[1];
                    return;
                }
                if (dataGridViewUnits.Rows[dataGridViewUnits.Rows.Count - 1].Cells[1].Value != null)
                {
                    list.Add(new UnitMeasurementViewModel());
                    dataGridViewUnits.DataSource = new List<UnitMeasurementViewModel>(list);
                    dataGridViewUnits.CurrentCell = dataGridViewUnits.Rows[dataGridViewUnits.Rows.Count - 1].Cells[1];
                    return;
                }
            }
            if (e.KeyData == Keys.Delete)
            {
                if (MessageBox.Show("Удалить выбранный элемент", "Удаление",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    unitMeasurementLogic.Delete(new UnitMeasurementViewModel() { Id = (int)dataGridViewUnits.CurrentRow.Cells[0].Value });
                    LoadData();
                }
            }
        }
    }
}
