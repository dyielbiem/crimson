
namespace AppDevProj
{
    partial class MainForm
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
            this.btnLedgerPanel = new System.Windows.Forms.Button();
            this.btHistoryPanel = new System.Windows.Forms.Button();
            this.btnInputPanel = new System.Windows.Forms.Button();
            this.btnRepPanel = new System.Windows.Forms.Button();
            this.btnMinimized = new System.Windows.Forms.Button();
            this.btnEsc = new System.Windows.Forms.Button();
            this.pnlBack = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.inventoryReports = new AppDevProj.InventoryReports();
            this.itemTransaction = new AppDevProj.ItemTransaction();
            this.addItem = new AppDevProj.AddItemTab();
            this.history = new AppDevProj.History();
            this.ledgerEntries = new AppDevProj.LedgerEntries();
            this.pnlFeatures = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnItemTrans = new System.Windows.Forms.Button();
            this.pnlBack.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlFeatures.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLedgerPanel
            // 
            this.btnLedgerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnLedgerPanel.FlatAppearance.BorderSize = 0;
            this.btnLedgerPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLedgerPanel.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLedgerPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(143)))), ((int)(((byte)(136)))));
            this.btnLedgerPanel.Location = new System.Drawing.Point(-7, 308);
            this.btnLedgerPanel.Name = "btnLedgerPanel";
            this.btnLedgerPanel.Size = new System.Drawing.Size(228, 35);
            this.btnLedgerPanel.TabIndex = 2;
            this.btnLedgerPanel.Text = "Transaction History";
            this.btnLedgerPanel.UseVisualStyleBackColor = false;
            this.btnLedgerPanel.Click += new System.EventHandler(this.btnLedgerPanel_Click);
            // 
            // btHistoryPanel
            // 
            this.btHistoryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btHistoryPanel.FlatAppearance.BorderSize = 0;
            this.btHistoryPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHistoryPanel.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHistoryPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(143)))), ((int)(((byte)(136)))));
            this.btHistoryPanel.Location = new System.Drawing.Point(-7, 261);
            this.btHistoryPanel.Name = "btHistoryPanel";
            this.btHistoryPanel.Size = new System.Drawing.Size(228, 35);
            this.btHistoryPanel.TabIndex = 1;
            this.btHistoryPanel.Text = "Ledger Entries";
            this.btHistoryPanel.UseVisualStyleBackColor = false;
            this.btHistoryPanel.BindingContextChanged += new System.EventHandler(this.btHistoryPanel_BindingContextChanged);
            this.btHistoryPanel.Click += new System.EventHandler(this.btnHistoryPanel_Click);
            // 
            // btnInputPanel
            // 
            this.btnInputPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.btnInputPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInputPanel.FlatAppearance.BorderSize = 0;
            this.btnInputPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInputPanel.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputPanel.ForeColor = System.Drawing.Color.SeaShell;
            this.btnInputPanel.Location = new System.Drawing.Point(-7, 167);
            this.btnInputPanel.Name = "btnInputPanel";
            this.btnInputPanel.Size = new System.Drawing.Size(228, 35);
            this.btnInputPanel.TabIndex = 0;
            this.btnInputPanel.Text = "Add Item";
            this.btnInputPanel.UseVisualStyleBackColor = false;
            this.btnInputPanel.Click += new System.EventHandler(this.btnInputPanel_Click);
            // 
            // btnRepPanel
            // 
            this.btnRepPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnRepPanel.FlatAppearance.BorderSize = 0;
            this.btnRepPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepPanel.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(143)))), ((int)(((byte)(136)))));
            this.btnRepPanel.Location = new System.Drawing.Point(-7, 357);
            this.btnRepPanel.Name = "btnRepPanel";
            this.btnRepPanel.Size = new System.Drawing.Size(228, 35);
            this.btnRepPanel.TabIndex = 3;
            this.btnRepPanel.Text = "Inventory Reports";
            this.btnRepPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRepPanel.UseVisualStyleBackColor = false;
            this.btnRepPanel.Click += new System.EventHandler(this.btnRepPanel_Click);
            // 
            // btnMinimized
            // 
            this.btnMinimized.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimized.FlatAppearance.BorderSize = 0;
            this.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimized.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnMinimized.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(183)))), ((int)(((byte)(171)))));
            this.btnMinimized.Location = new System.Drawing.Point(0, -4);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(35, 28);
            this.btnMinimized.TabIndex = 1;
            this.btnMinimized.Text = "__";
            this.btnMinimized.UseVisualStyleBackColor = false;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // btnEsc
            // 
            this.btnEsc.FlatAppearance.BorderSize = 0;
            this.btnEsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsc.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.btnEsc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(183)))), ((int)(((byte)(171)))));
            this.btnEsc.Location = new System.Drawing.Point(30, 0);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(32, 23);
            this.btnEsc.TabIndex = 0;
            this.btnEsc.Text = "X";
            this.btnEsc.UseVisualStyleBackColor = true;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // pnlBack
            // 
            this.pnlBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.pnlBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlBack.Controls.Add(this.pnlButtons);
            this.pnlBack.Controls.Add(this.inventoryReports);
            this.pnlBack.Controls.Add(this.itemTransaction);
            this.pnlBack.Controls.Add(this.addItem);
            this.pnlBack.Controls.Add(this.history);
            this.pnlBack.Controls.Add(this.ledgerEntries);
            this.pnlBack.Location = new System.Drawing.Point(219, -9);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(668, 542);
            this.pnlBack.TabIndex = 6;
            this.pnlBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.pnlBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.pnlBack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_Event);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.pnlButtons.Controls.Add(this.btnEsc);
            this.pnlButtons.Controls.Add(this.btnMinimized);
            this.pnlButtons.Location = new System.Drawing.Point(577, 8);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(61, 25);
            this.pnlButtons.TabIndex = 36;
            // 
            // inventoryReports
            // 
            this.inventoryReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.inventoryReports.Location = new System.Drawing.Point(7, 71);
            this.inventoryReports.Name = "inventoryReports";
            this.inventoryReports.Size = new System.Drawing.Size(652, 451);
            this.inventoryReports.TabIndex = 39;
            this.inventoryReports.Visible = false;
            // 
            // itemTransaction
            // 
            this.itemTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.itemTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.itemTransaction.Location = new System.Drawing.Point(0, 38);
            this.itemTransaction.Name = "itemTransaction";
            this.itemTransaction.Size = new System.Drawing.Size(652, 483);
            this.itemTransaction.TabIndex = 38;
            this.itemTransaction.Visible = false;
            this.itemTransaction.Load += new System.EventHandler(this.itemTransaction_Load);
            // 
            // addItem
            // 
            this.addItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.addItem.Location = new System.Drawing.Point(0, 65);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(652, 398);
            this.addItem.TabIndex = 37;
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.history.Location = new System.Drawing.Point(8, 32);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(652, 489);
            this.history.TabIndex = 41;
            this.history.Visible = false;
            // 
            // ledgerEntries
            // 
            this.ledgerEntries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.ledgerEntries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ledgerEntries.Location = new System.Drawing.Point(0, 49);
            this.ledgerEntries.Name = "ledgerEntries";
            this.ledgerEntries.Size = new System.Drawing.Size(650, 493);
            this.ledgerEntries.TabIndex = 40;
            this.ledgerEntries.Visible = false;
            this.ledgerEntries.Load += new System.EventHandler(this.ledgerEntries1_Load);
            // 
            // pnlFeatures
            // 
            this.pnlFeatures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.pnlFeatures.Controls.Add(this.label2);
            this.pnlFeatures.Controls.Add(this.button1);
            this.pnlFeatures.Controls.Add(this.btnItemTrans);
            this.pnlFeatures.Location = new System.Drawing.Point(-2, -2);
            this.pnlFeatures.Name = "pnlFeatures";
            this.pnlFeatures.Size = new System.Drawing.Size(222, 525);
            this.pnlFeatures.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Old Style", 36F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MistyRose;
            this.label2.Location = new System.Drawing.Point(14, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 55);
            this.label2.TabIndex = 43;
            this.label2.Text = "crIMSon";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(143)))), ((int)(((byte)(136)))));
            this.button1.Location = new System.Drawing.Point(-20, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 35);
            this.button1.TabIndex = 38;
            this.button1.Text = " Log Out";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnItemTrans
            // 
            this.btnItemTrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnItemTrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnItemTrans.FlatAppearance.BorderSize = 0;
            this.btnItemTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemTrans.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemTrans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(143)))), ((int)(((byte)(136)))));
            this.btnItemTrans.Location = new System.Drawing.Point(-5, 215);
            this.btnItemTrans.Name = "btnItemTrans";
            this.btnItemTrans.Size = new System.Drawing.Size(228, 35);
            this.btnItemTrans.TabIndex = 38;
            this.btnItemTrans.Text = "Item Transaction";
            this.btnItemTrans.UseVisualStyleBackColor = false;
            this.btnItemTrans.Click += new System.EventHandler(this.btnItemTrans_Click);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(872, 525);
            this.Controls.Add(this.pnlBack);
            this.Controls.Add(this.btHistoryPanel);
            this.Controls.Add(this.btnLedgerPanel);
            this.Controls.Add(this.btnRepPanel);
            this.Controls.Add(this.btnInputPanel);
            this.Controls.Add(this.pnlFeatures);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_Event);
            this.pnlBack.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlFeatures.ResumeLayout(false);
            this.pnlFeatures.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLedgerPanel;
        private System.Windows.Forms.Button btHistoryPanel;
        private System.Windows.Forms.Button btnInputPanel;
        private System.Windows.Forms.Button btnRepPanel;
        private System.Windows.Forms.Button btnEsc;
        private System.Windows.Forms.Button btnMinimized;
        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlFeatures;
        private AddItemTab addItem;
        private System.Windows.Forms.Button btnItemTrans;
        private ItemTransaction itemTransaction;
        private InventoryReports inventoryReports;
        private LedgerEntries ledgerEntries;
        private History history;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

