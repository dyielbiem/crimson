
namespace AppDevProj
{
    partial class LedgerEntries
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabLedgerEntries = new System.Windows.Forms.TabControl();
            this.tabDelivery = new System.Windows.Forms.TabPage();
            this.datagrdDelivery = new System.Windows.Forms.DataGridView();
            this.tabStorage = new System.Windows.Forms.TabPage();
            this.dataStorageMvmnt = new System.Windows.Forms.DataGridView();
            this.tabStocktrnsfr = new System.Windows.Forms.TabPage();
            this.datagrdStock = new System.Windows.Forms.DataGridView();
            this.tabDefective = new System.Windows.Forms.TabPage();
            this.datagrdDefect = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabLedgerEntries.SuspendLayout();
            this.tabDelivery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdDelivery)).BeginInit();
            this.tabStorage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStorageMvmnt)).BeginInit();
            this.tabStocktrnsfr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdStock)).BeginInit();
            this.tabDefective.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdDefect)).BeginInit();
            this.SuspendLayout();
            // 
            // tabLedgerEntries
            // 
            this.tabLedgerEntries.Controls.Add(this.tabDelivery);
            this.tabLedgerEntries.Controls.Add(this.tabStorage);
            this.tabLedgerEntries.Controls.Add(this.tabStocktrnsfr);
            this.tabLedgerEntries.Controls.Add(this.tabDefective);
            this.tabLedgerEntries.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLedgerEntries.Location = new System.Drawing.Point(43, 105);
            this.tabLedgerEntries.Name = "tabLedgerEntries";
            this.tabLedgerEntries.SelectedIndex = 0;
            this.tabLedgerEntries.Size = new System.Drawing.Size(561, 319);
            this.tabLedgerEntries.TabIndex = 1;
            this.tabLedgerEntries.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabLedgerEntries_Selected);
            // 
            // tabDelivery
            // 
            this.tabDelivery.BackColor = System.Drawing.Color.White;
            this.tabDelivery.Controls.Add(this.datagrdDelivery);
            this.tabDelivery.Location = new System.Drawing.Point(4, 27);
            this.tabDelivery.Name = "tabDelivery";
            this.tabDelivery.Padding = new System.Windows.Forms.Padding(3);
            this.tabDelivery.Size = new System.Drawing.Size(553, 288);
            this.tabDelivery.TabIndex = 0;
            this.tabDelivery.Text = "Delivery";
            // 
            // datagrdDelivery
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrdDelivery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrdDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrdDelivery.Dock = System.Windows.Forms.DockStyle.Top;
            this.datagrdDelivery.Location = new System.Drawing.Point(3, 3);
            this.datagrdDelivery.Name = "datagrdDelivery";
            this.datagrdDelivery.Size = new System.Drawing.Size(547, 290);
            this.datagrdDelivery.TabIndex = 0;
            // 
            // tabStorage
            // 
            this.tabStorage.BackColor = System.Drawing.Color.White;
            this.tabStorage.Controls.Add(this.dataStorageMvmnt);
            this.tabStorage.Location = new System.Drawing.Point(4, 27);
            this.tabStorage.Margin = new System.Windows.Forms.Padding(0);
            this.tabStorage.Name = "tabStorage";
            this.tabStorage.Padding = new System.Windows.Forms.Padding(3);
            this.tabStorage.Size = new System.Drawing.Size(553, 288);
            this.tabStorage.TabIndex = 1;
            this.tabStorage.Text = "Storage Movement";
            // 
            // dataStorageMvmnt
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataStorageMvmnt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataStorageMvmnt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStorageMvmnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataStorageMvmnt.Location = new System.Drawing.Point(3, 3);
            this.dataStorageMvmnt.Name = "dataStorageMvmnt";
            this.dataStorageMvmnt.Size = new System.Drawing.Size(547, 282);
            this.dataStorageMvmnt.TabIndex = 2;
            // 
            // tabStocktrnsfr
            // 
            this.tabStocktrnsfr.Controls.Add(this.datagrdStock);
            this.tabStocktrnsfr.Location = new System.Drawing.Point(4, 27);
            this.tabStocktrnsfr.Name = "tabStocktrnsfr";
            this.tabStocktrnsfr.Padding = new System.Windows.Forms.Padding(3);
            this.tabStocktrnsfr.Size = new System.Drawing.Size(553, 288);
            this.tabStocktrnsfr.TabIndex = 2;
            this.tabStocktrnsfr.Text = "Stock Transfer";
            this.tabStocktrnsfr.UseVisualStyleBackColor = true;
            // 
            // datagrdStock
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrdStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagrdStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrdStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagrdStock.Location = new System.Drawing.Point(3, 3);
            this.datagrdStock.Name = "datagrdStock";
            this.datagrdStock.Size = new System.Drawing.Size(547, 282);
            this.datagrdStock.TabIndex = 3;
            // 
            // tabDefective
            // 
            this.tabDefective.Controls.Add(this.datagrdDefect);
            this.tabDefective.Location = new System.Drawing.Point(4, 27);
            this.tabDefective.Name = "tabDefective";
            this.tabDefective.Padding = new System.Windows.Forms.Padding(3);
            this.tabDefective.Size = new System.Drawing.Size(553, 288);
            this.tabDefective.TabIndex = 3;
            this.tabDefective.Text = "Defective Item";
            this.tabDefective.UseVisualStyleBackColor = true;
            // 
            // datagrdDefect
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrdDefect.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagrdDefect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrdDefect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagrdDefect.Location = new System.Drawing.Point(3, 3);
            this.datagrdDefect.Name = "datagrdDefect";
            this.datagrdDefect.Size = new System.Drawing.Size(547, 282);
            this.datagrdDefect.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 43);
            this.label1.TabIndex = 98;
            this.label1.Text = "Transaction History";
            // 
            // LedgerEntries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabLedgerEntries);
            this.Name = "LedgerEntries";
            this.Size = new System.Drawing.Size(723, 490);
            this.tabLedgerEntries.ResumeLayout(false);
            this.tabDelivery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrdDelivery)).EndInit();
            this.tabStorage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataStorageMvmnt)).EndInit();
            this.tabStocktrnsfr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrdStock)).EndInit();
            this.tabDefective.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrdDefect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabLedgerEntries;
        private System.Windows.Forms.TabPage tabDelivery;
        private System.Windows.Forms.DataGridView datagrdDelivery;
        private System.Windows.Forms.TabPage tabStorage;
        private System.Windows.Forms.DataGridView dataStorageMvmnt;
        private System.Windows.Forms.TabPage tabStocktrnsfr;
        private System.Windows.Forms.TabPage tabDefective;
        private System.Windows.Forms.DataGridView datagrdDefect;
        private System.Windows.Forms.DataGridView datagrdStock;
        private System.Windows.Forms.Label label1;
    }
}
