using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreProductsDatabaseImplement.Models;
using StoreProductsDatabaseImplement.Logics;
using CORPLab3.Plugins;
using CORPLab3.PlaginMain;

namespace CORPLab3
{
    public partial class FormMain : Form
    {
        private readonly Dictionary<string, IPluginsConvention> _plugins;
        private string _selectedPlugin;
        public FormMain()
        {
            InitializeComponent();
            _plugins = LoadPlugins();
        }
        private Dictionary<string, IPluginsConvention> LoadPlugins()
        {
            // TODO Заполнить IPluginsConvention
            // TODO Заполнить пункт меню "Справочники" на основе IPluginsConvention.PluginName
            // TODO Например, создавать ToolStripMenuItem, привязывать к ним обработку событий и добавлять в menuStrip
            // TODO При выборе пункта меню получать UserControl и заполнять элемент  panelControl этим контролом на всю площадь
            // Пример: panelControl.Controls.Clear(); panelControl.Controls.Add(ctrl);

            var dic = new Dictionary<string, IPluginsConvention>();
            var mainPlugin = new MainPluginConvention();
            dic.Add(mainPlugin.PluginName, mainPlugin);

            System.Windows.Forms.ToolStripItem[] toolStripItems = new System.Windows.Forms.ToolStripItem[2];
            ToolStripMenuItem menuItemProducts = new ToolStripMenuItem();
            menuItemProducts.Text = mainPlugin.PluginName;
            menuItemProducts.Click += MenuItemProducts_Click;
            toolStripItems[0] = menuItemProducts;

            ToolStripMenuItem menuItemUnits = new ToolStripMenuItem();
            menuItemUnits.Text = "Единицы измерения";
            menuItemUnits.Click += MenuItemUnits_Click;
            toolStripItems[1] = menuItemUnits;

            ControlsStripMenuItem.DropDownItems.AddRange(toolStripItems);
            return dic;
        }

        private void MenuItemUnits_Click(object sender, EventArgs e)
        {
            FormUnits formUnits = new FormUnits();
            formUnits.ShowDialog();
        }

        private void MenuItemProducts_Click(object sender, EventArgs e)
        {
            _selectedPlugin = "Продукты";
            panelControl.Controls.Clear();
            panelControl.Controls.Add(_plugins[_selectedPlugin].GetControl);
            panelControl.Controls[0].Dock = DockStyle.Fill;
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedPlugin) ||
           !_plugins.ContainsKey(_selectedPlugin))
            {
                return;
            }
            if (!e.Control)
            {
                return;
            }
            switch (e.KeyCode)
            {
                case Keys.A:
                    AddNewElement();
                    break;
                case Keys.U:
                    UpdateElement();
                    break;
                case Keys.D:
                    DeleteElement();
                    break;
                case Keys.S:
                    CreateSimpleDoc();
                    break;
                case Keys.T:
                    CreateTableDoc();
                    break;
                case Keys.C:
                    CreateChartDoc();
                    break;
            }
        }
        private void AddNewElement()
        {
            var form = _plugins[_selectedPlugin].GetForm(null);
            if (form != null && form.ShowDialog() == DialogResult.OK)
            {
                _plugins[_selectedPlugin].ReloadData();
            }
        }
        private void UpdateElement()
        {
            var element = _plugins[_selectedPlugin].GetElement;
            if (element == null)
            {
                MessageBox.Show("Нет выбранного элемента", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var form = _plugins[_selectedPlugin].GetForm(element);
            if (form != null && form.ShowDialog() == DialogResult.OK)
            {
                _plugins[_selectedPlugin].ReloadData();
            }
        }
        private void DeleteElement()
        {
            if (MessageBox.Show("Удалить выбранный элемент", "Удаление",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            var element = _plugins[_selectedPlugin].GetElement;
            if (element == null)
            {
                MessageBox.Show("Нет выбранного элемента", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_plugins[_selectedPlugin].DeleteElement(element))
            {
                _plugins[_selectedPlugin].ReloadData();
            }
        }
        private void CreateSimpleDoc()
        {
            using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK && _plugins[_selectedPlugin].CreateSimpleDocument(
                    new PluginsConventionSaveDocument()
                    {
                        FileName = dialog.FileName
                    }))
                {
                    MessageBox.Show("Документ сохранен", "Создание документа",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ошибка при создании документа", "Ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CreateTableDoc()
        {
            using (var dialog = new SaveFileDialog { Filter = "pdf|*.pdf" })
            {
                if (dialog.ShowDialog() == DialogResult.OK && _plugins[_selectedPlugin].CreateTableDocument(new
                    PluginsConventionSaveDocument()
                    {
                        FileName = dialog.FileName
                    }))
                {
                    MessageBox.Show("Документ сохранен", "Создание документа",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ошибка при создании документа", "Ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CreateChartDoc()
        {
            using (var dialog = new SaveFileDialog { Filter = "xlsx|*.xls" })
            {
                if (dialog.ShowDialog() == DialogResult.OK && _plugins[_selectedPlugin].CreateChartDocument(new
                    PluginsConventionSaveDocument()
                {
                    FileName = dialog.FileName
                }))
                {
                    MessageBox.Show("Документ сохранен", "Создание документа",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ошибка при создании документа", "Ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void AddElementToolStripMenuItem_Click(object sender, EventArgs e) =>
       AddNewElement();
        private void UpdElementToolStripMenuItem_Click(object sender, EventArgs e) =>
       UpdateElement();
        private void DelElementToolStripMenuItem_Click(object sender, EventArgs e) =>
       DeleteElement();
        private void SimpleDocToolStripMenuItem_Click(object sender, EventArgs e) =>
       CreateSimpleDoc();
        private void TableDocToolStripMenuItem_Click(object sender, EventArgs e) =>
       CreateTableDoc();
        private void ChartDocToolStripMenuItem_Click(object sender, EventArgs e) =>
       CreateChartDoc();

    }
}
