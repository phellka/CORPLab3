
namespace CORPLab3.PlaginMain
{
    partial class FormUnits
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
            this.dataGridViewUnits = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUnits
            // 
            this.dataGridViewUnits.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUnits.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUnits.Name = "dataGridViewUnits";
            this.dataGridViewUnits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUnits.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewUnits.TabIndex = 0;
            this.dataGridViewUnits.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUnits_CellEndEdit);
            this.dataGridViewUnits.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewUnits_KeyDown);
            // 
            // FormUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewUnits);
            this.Name = "FormUnits";
            this.Text = "Единицы измерения";
            this.Load += new System.EventHandler(this.FormUnits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUnits;
    }
}