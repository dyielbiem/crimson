using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppDevProj
{
    public partial class MainForm : Form
    {
        private bool mouseDown;
        private Point cursorLastPos;


        public MainForm()
        {
            InitializeComponent();
        }

       
        private void mouseDown_Event (object sender, MouseEventArgs e)
        {
            cursorLastPos = e.Location;
            mouseDown = true;
        }

        private void mouseMove_Event(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                this.Location = new Point((this.Location.X - cursorLastPos.X) + e.X, (this.Location.Y - cursorLastPos.Y) + e.Y);
                this.Update();

            }
        }

        private void mouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }




        private void btnInputPanel_Click(object sender, EventArgs e)
        {
            itemTransaction.Visible = false;            
            addItem.Visible = true;
            inventoryReports.Visible = false;
            ledgerEntries.Visible = false;
            history.Visible = false;
            itemTransaction.clearItemTrans();


            btnInputPanel.BackColor = Color.FromArgb(46, 26, 31);
            btnInputPanel.ForeColor = Color.SeaShell;

            btnItemTrans.BackColor = Color.FromArgb(81, 49, 54); 
            btnItemTrans.ForeColor = Color.FromArgb(184, 143, 136);
            btHistoryPanel.BackColor = Color.FromArgb(81, 49, 54); 
            btHistoryPanel.ForeColor = Color.FromArgb(184, 143, 136);
            btnLedgerPanel.BackColor = Color.FromArgb(81, 49, 54);
            btnLedgerPanel.ForeColor = Color.FromArgb(184, 143, 136);
            btnRepPanel.BackColor = Color.FromArgb(81, 49, 54);
            btnRepPanel.ForeColor = Color.FromArgb(184, 143, 136);
        }

        private void btnItemTrans_Click(object sender, EventArgs e)
        {
            addItem.Visible = false;
            itemTransaction.Visible = true;
            inventoryReports.Visible = false;
            ledgerEntries.Visible = false;
            history.Visible = false;
            addItem.clrAddItem();

            btnItemTrans.BackColor = Color.FromArgb(46, 26, 31);
            btnItemTrans.ForeColor = Color.SeaShell;

            btHistoryPanel.BackColor = Color.FromArgb(81, 49, 54);
            btHistoryPanel.ForeColor = Color.FromArgb(184, 143, 136);
            btnLedgerPanel.BackColor = Color.FromArgb(81, 49, 54);
            btnLedgerPanel.ForeColor = Color.FromArgb(184, 143, 136);
            btnRepPanel.BackColor = Color.FromArgb(81, 49, 54);
            btnRepPanel.ForeColor = Color.FromArgb(184, 143, 136);
            btnInputPanel.BackColor = Color.FromArgb(81, 49, 54);
            btnInputPanel.ForeColor = Color.FromArgb(184, 143, 136);

        }

        private void btnHistoryPanel_Click(object sender, EventArgs e)
        {
            addItem.Visible = false;
            itemTransaction.Visible = false;
            ledgerEntries.Visible = false;
            inventoryReports.Visible = false;
            history.Visible = true;            
            history.readAddItem();

            btHistoryPanel.BackColor = Color.FromArgb(46, 26, 31);
            btHistoryPanel.ForeColor = Color.SeaShell;

            btnLedgerPanel.BackColor = Color.FromArgb(81, 49, 54);
            btnLedgerPanel.ForeColor = Color.FromArgb(184, 143, 136);
            btnRepPanel.BackColor = Color.FromArgb(81, 49, 54);
            btnRepPanel.ForeColor = Color.FromArgb(184, 143, 136);
            btnInputPanel.BackColor = Color.FromArgb(81, 49, 54);
            btnInputPanel.ForeColor = Color.FromArgb(184, 143, 136);
            btnItemTrans.BackColor = Color.FromArgb(81, 49, 54);
            btnItemTrans.ForeColor = Color.FromArgb(184, 143, 136);


        }

        private void btnLedgerPanel_Click(object sender, EventArgs e)
        {
            addItem.Visible = false;
            itemTransaction.Visible = false;
            ledgerEntries.Visible = true;
            ledgerEntries.readLedgerData();
            inventoryReports.Visible = false;
            history.Visible = false;

            btnLedgerPanel.BackColor = Color.FromArgb(46, 26, 31);
            btnLedgerPanel.ForeColor = Color.SeaShell;

            btnRepPanel.BackColor = Color.FromArgb(81, 49, 54);
            btnRepPanel.ForeColor = Color.FromArgb(184, 143, 136);
            btnInputPanel.BackColor = Color.FromArgb(81, 49, 54);
            btnInputPanel.ForeColor = Color.FromArgb(184, 143, 136);
            btnItemTrans.BackColor = Color.FromArgb(81, 49, 54);
            btnItemTrans.ForeColor = Color.FromArgb(184, 143, 136);
            btHistoryPanel.BackColor = Color.FromArgb(81, 49, 54);
            btHistoryPanel.ForeColor = Color.FromArgb(184, 143, 136);



        }


        private void btnRepPanel_Click(object sender, EventArgs e)
        {
            addItem.Visible = false;
            itemTransaction.Visible = false;
            ledgerEntries.Visible = false;
            history.Visible = false;
            inventoryReports.Visible = true;
            inventoryReports.readCount();

            btnRepPanel.BackColor = Color.FromArgb(46, 26, 31);
            btnRepPanel.ForeColor = Color.SeaShell;

            btnInputPanel.BackColor = Color.FromArgb(81, 49, 54);
            btnInputPanel.ForeColor = Color.FromArgb(184, 143, 136);
            btnItemTrans.BackColor = Color.FromArgb(81, 49, 54);
            btnItemTrans.ForeColor = Color.FromArgb(184, 143, 136);
            btHistoryPanel.BackColor = Color.FromArgb(81, 49, 54);
            btHistoryPanel.ForeColor = Color.FromArgb(184, 143, 136);
            btnLedgerPanel.BackColor = Color.FromArgb(81, 49, 54);
            btnLedgerPanel.ForeColor = Color.FromArgb(184, 143, 136);

        }


        private void btnEsc_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void signUpWindow1_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void itemTransaction_Load(object sender, EventArgs e)
        {

        }

        private void ledgerEntries1_Load(object sender, EventArgs e)
        {

        }

        private void btHistoryPanel_BindingContextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            LogInForm loginWindow = new LogInForm();
            loginWindow.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


      
    }
}
