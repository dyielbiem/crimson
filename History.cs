using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppDevProj
{
    public partial class History : UserControl
    {
        private string strConnection = "server=localhost; database=appdevproj; uid=root; password=yourMySQLPassword";
        public History()
        {
            this.Visible = false;
            InitializeComponent();

            dataAddItem.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(81, 49, 54);
            dataAddItem.ColumnHeadersDefaultCellStyle.ForeColor = Color.SeaShell;
            dataAddItem.EnableHeadersVisualStyles = false;

        }


        public void readAddItem()
        {
            using (MySqlConnection myConn = new MySqlConnection(strConnection))
            {

                try
                {
                    myConn.Open();
                    using (MySqlCommand myCmd = new MySqlCommand())
                    {
                        myCmd.Connection = myConn;
                        myCmd.CommandText = "Select * FROM tbladditem ORDER BY transdate";
                        MySqlDataReader myRdr = myCmd.ExecuteReader();

                        DataTable sourceTable = new DataTable();
                        sourceTable.Load(myRdr);

                        dataAddItem.DataSource = sourceTable;
                        dataAddItem.Columns[4].Width = 100;
                        dataAddItem.AllowUserToResizeRows = false;
                        dataAddItem.ReadOnly = true;
                        myRdr.Close();



                    }
                }
                catch (Exception eM)
                {
                    MessageBox.Show(eM.ToString());
                }
                finally
                {
                    myConn.Close();
                }
            }

        }

    }


    


}
