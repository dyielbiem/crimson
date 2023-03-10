using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppDevProj
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            this.ActiveControl = btnMinimized;
            lblPass.Visible = false;
            lblUser.Visible = false;
        }

        private void LogInWindow_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtBoxPass.Text == "admin" && txtBoxUser.Text == "admin")
            {
                this.Visible = false;
                MainForm mainWindow = new MainForm();
                mainWindow.ShowDialog();

              // String strCommand  = "INSERT INTO trydb.dbtry (wow, ngi) values(14, 'ngi')";



            }
            else
            {
                MessageBox.Show("Invalid User Name or Password!");

                txtBoxPass.Text = "Password";
                txtBoxPass.PasswordChar = '\0';
                txtBoxPass.ForeColor = Color.FromArgb(219, 183, 171);

                txtBoxUser.Text = "User Name";
                txtBoxUser.ForeColor = Color.FromArgb(219, 183, 171);
            }
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        // User Name TextBox Placeholder
        private void txtBoxUser_Enter(object sender, EventArgs e)
        {
            if (txtBoxUser.Text == "User Name")
            {
                txtBoxUser.Text = "";
                txtBoxUser.ForeColor = Color.FromArgb(12, 6, 8);
                lblUser.Visible = true;

            }
        }
        private void txtBoxUser_Leave(object sender, EventArgs e)
        {
            if (txtBoxUser.Text == "")
            {
                txtBoxUser.Text = "User Name";
                txtBoxUser.ForeColor = Color.FromArgb(219, 183, 171);
                lblUser.Visible = false;

            }
        }

        // Password TextBox Placeholder
       
        private void txtBoxPass_Leave(object sender, EventArgs e)
        {
            if (txtBoxPass.Text == "")
            {
                txtBoxPass.Text = "Password";
                txtBoxPass.PasswordChar = '\0';
                txtBoxPass.ForeColor = Color.FromArgb(219, 183, 171);
                lblPass.Visible = false;
            }
        } 

        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxPass_Enter(object sender, EventArgs e)
        {
            if (txtBoxPass.Text == "Password")
            {
                txtBoxPass.Text = "";
                txtBoxPass.PasswordChar = '*';
                txtBoxPass.ForeColor = Color.FromArgb(12, 6, 8);
                lblPass.Visible = true;

            }
        }
    }
}
