
namespace CORPLab3.PlaginMain
{
    partial class FormProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelProviderOne = new System.Windows.Forms.Label();
            this.labelProviderTwo = new System.Windows.Forms.Label();
            this.labelProviderThree = new System.Windows.Forms.Label();
            this.labelUnitMeasurement = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxProviderOne = new System.Windows.Forms.TextBox();
            this.textBoxProviderTwo = new System.Windows.Forms.TextBox();
            this.textBoxProviderThree = new System.Windows.Forms.TextBox();
            this.lipatovTextBoxCountry = new LipatovVisualComponents.LipatovTextBox();
            this.ilbekovComboBoxMeasures = new IlbekovVisualComponents.IlbekovComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(3, 45);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(43, 13);
            this.labelCountry.TabIndex = 1;
            this.labelCountry.Text = "Страна";
            // 
            // labelProviderOne
            // 
            this.labelProviderOne.AutoSize = true;
            this.labelProviderOne.Location = new System.Drawing.Point(3, 90);
            this.labelProviderOne.Name = "labelProviderOne";
            this.labelProviderOne.Size = new System.Drawing.Size(106, 13);
            this.labelProviderOne.TabIndex = 2;
            this.labelProviderOne.Text = "Первый поставщик";
            // 
            // labelProviderTwo
            // 
            this.labelProviderTwo.AutoSize = true;
            this.labelProviderTwo.Location = new System.Drawing.Point(3, 135);
            this.labelProviderTwo.Name = "labelProviderTwo";
            this.labelProviderTwo.Size = new System.Drawing.Size(102, 13);
            this.labelProviderTwo.TabIndex = 3;
            this.labelProviderTwo.Text = "Второй поставщик";
            // 
            // labelProviderThree
            // 
            this.labelProviderThree.AutoSize = true;
            this.labelProviderThree.Location = new System.Drawing.Point(3, 180);
            this.labelProviderThree.Name = "labelProviderThree";
            this.labelProviderThree.Size = new System.Drawing.Size(102, 13);
            this.labelProviderThree.TabIndex = 4;
            this.labelProviderThree.Text = "Третий поставщик";
            // 
            // labelUnitMeasurement
            // 
            this.labelUnitMeasurement.AutoSize = true;
            this.labelUnitMeasurement.Location = new System.Drawing.Point(3, 225);
            this.labelUnitMeasurement.Name = "labelUnitMeasurement";
            this.labelUnitMeasurement.Size = new System.Drawing.Size(111, 13);
            this.labelUnitMeasurement.TabIndex = 5;
            this.labelUnitMeasurement.Text = "Единицы измерения";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.labelUnitMeasurement, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelProviderThree, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelCountry, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelProviderTwo, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelProviderOne, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxProviderOne, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxProviderTwo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxProviderThree, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lipatovTextBoxCountry, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ilbekovComboBoxMeasures, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonSave, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // textBoxName
            // 
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName.Location = new System.Drawing.Point(163, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(634, 20);
            this.textBoxName.TabIndex = 7;
            this.textBoxName.TextChanged += new System.EventHandler(this.SmthChanged);
            // 
            // textBoxProviderOne
            // 
            this.textBoxProviderOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxProviderOne.Location = new System.Drawing.Point(163, 93);
            this.textBoxProviderOne.Name = "textBoxProviderOne";
            this.textBoxProviderOne.Size = new System.Drawing.Size(634, 20);
            this.textBoxProviderOne.TabIndex = 8;
            this.textBoxProviderOne.TextChanged += new System.EventHandler(this.SmthChanged);
            // 
            // textBoxProviderTwo
            // 
            this.textBoxProviderTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxProviderTwo.Location = new System.Drawing.Point(163, 138);
            this.textBoxProviderTwo.Name = "textBoxProviderTwo";
            this.textBoxProviderTwo.Size = new System.Drawing.Size(634, 20);
            this.textBoxProviderTwo.TabIndex = 9;
            this.textBoxProviderTwo.TextChanged += new System.EventHandler(this.SmthChanged);
            // 
            // textBoxProviderThree
            // 
            this.textBoxProviderThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxProviderThree.Location = new System.Drawing.Point(163, 183);
            this.textBoxProviderThree.Name = "textBoxProviderThree";
            this.textBoxProviderThree.Size = new System.Drawing.Size(634, 20);
            this.textBoxProviderThree.TabIndex = 10;
            this.textBoxProviderThree.TextChanged += new System.EventHandler(this.SmthChanged);
            // 
            // lipatovTextBoxCountry
            // 
            this.lipatovTextBoxCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lipatovTextBoxCountry.InputText = null;
            this.lipatovTextBoxCountry.Location = new System.Drawing.Point(163, 48);
            this.lipatovTextBoxCountry.MaxLength = 15;
            this.lipatovTextBoxCountry.MinLength = 10;
            this.lipatovTextBoxCountry.Name = "lipatovTextBoxCountry";
            this.lipatovTextBoxCountry.Size = new System.Drawing.Size(634, 39);
            this.lipatovTextBoxCountry.TabIndex = 11;
            // 
            // ilbekovComboBoxMeasures
            // 
            this.ilbekovComboBoxMeasures.ChoosenItem = "";
            this.ilbekovComboBoxMeasures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ilbekovComboBoxMeasures.Location = new System.Drawing.Point(162, 227);
            this.ilbekovComboBoxMeasures.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ilbekovComboBoxMeasures.Name = "ilbekovComboBoxMeasures";
            this.ilbekovComboBoxMeasures.Size = new System.Drawing.Size(636, 176);
            this.ilbekovComboBoxMeasures.TabIndex = 12;
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.Location = new System.Drawing.Point(3, 408);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(154, 39);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormProduct";
            this.Text = "Продукт";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormProduct_FormClosing);
            this.Load += new System.EventHandler(this.FormProduct_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelProviderOne;
        private System.Windows.Forms.Label labelProviderTwo;
        private System.Windows.Forms.Label labelProviderThree;
        private System.Windows.Forms.Label labelUnitMeasurement;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxProviderOne;
        private System.Windows.Forms.TextBox textBoxProviderTwo;
        private System.Windows.Forms.TextBox textBoxProviderThree;
        private LipatovVisualComponents.LipatovTextBox lipatovTextBoxCountry;
        private IlbekovVisualComponents.IlbekovComboBox ilbekovComboBoxMeasures;
        private System.Windows.Forms.Button buttonSave;
    }
}