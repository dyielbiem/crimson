using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace AppDevProj
{
    public partial class InventoryReports : UserControl
    {
        private string strConnection = "server=localhost; database=appdevproj; uid=root; password=yourMySQLPassword";
        public InventoryReports()
        {
            this.Visible = false;
            InitializeComponent();

            datagrdCount.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(81, 49, 54);
            datagrdCount.ColumnHeadersDefaultCellStyle.ForeColor = Color.SeaShell;
            datagrdCount.EnableHeadersVisualStyles = false;

            datagrdDefect.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(81, 49, 54);
            datagrdDefect.ColumnHeadersDefaultCellStyle.ForeColor = Color.SeaShell;
            datagrdDefect.EnableHeadersVisualStyles = false;

            datagrdDelivery.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(81, 49, 54);
            datagrdDelivery.ColumnHeadersDefaultCellStyle.ForeColor = Color.SeaShell;
            datagrdDelivery.EnableHeadersVisualStyles = false;

            datagrdDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(81, 49, 54);
            datagrdDetails.ColumnHeadersDefaultCellStyle.ForeColor = Color.SeaShell;
            datagrdDetails.EnableHeadersVisualStyles = false;

        }


        private void tabReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            readCount();
        }

        public void readCount()
        {
            if (tabReports.SelectedTab.Text == "Item Details")
            {
                using (MySqlConnection myConn = new MySqlConnection(strConnection))
                {

                    try
                    {
                        myConn.Open();
                        using (MySqlCommand myCmd = new MySqlCommand())
                        {
                            myCmd.Connection = myConn;
                            myCmd.CommandText = "SELECT * FROM tbliteminfo";
                            MySqlDataReader myRdr = myCmd.ExecuteReader();

                            DataTable tblTemp = new DataTable();
                            tblTemp.Load(myRdr);

                            datagrdDetails.DataSource = tblTemp;

                            datagrdDetails.DataSource = tblTemp;
                            datagrdDetails.Columns[0].Width = 122;
                            datagrdDetails.Columns[1].Width = 122;
                            datagrdDetails.Columns[2].Width = 122;
                            datagrdDetails.Columns[3].Width = 122;
                            datagrdDetails.ReadOnly = true;
                            datagrdDetails.AllowUserToResizeRows = false;
                        }
                    }
                    catch (Exception eM)
                    {
                        MessageBox.Show(eM.Message);
                    }
                    finally
                    {
                        myConn.Close();
                    }
                }
            }
            else if (tabReports.SelectedTab.Text == "Item Physical Count")
            {
                using (MySqlConnection myConn = new MySqlConnection(strConnection))
                {

                    try
                    {
                        myConn.Open();
                        using (MySqlCommand myCmd = new MySqlCommand())
                        {
                            myCmd.Connection = myConn;
                            myCmd.CommandText = "SELECT tbliteminfo.itemcode, itemname, SUM(totalqnty) " +
                                                "FROM tbliteminfo, tbltotalqnty " +
                                                "WHERE  tbliteminfo.itemcode =  tbltotalqnty.itemcode " +
                                                "GROUP BY  tbliteminfo.itemcode";
                            MySqlDataReader myRdr = myCmd.ExecuteReader();

                            DataTable tblTemp = new DataTable();
                            tblTemp.Load(myRdr);

                            datagrdCount.DataSource = tblTemp;
                            datagrdCount.Columns[0].Width = 163;
                            datagrdCount.Columns[1].Width = 163;
                            datagrdCount.Columns[2].Width = 163;
                            datagrdCount.Columns[2].HeaderText = "quantity";
                            datagrdCount.ReadOnly = true;
                            datagrdCount.AllowUserToResizeRows = false;
                        }
                    }
                    catch (Exception eM)
                    {
                        MessageBox.Show(eM.Message);
                    }
                    finally
                    {
                        myConn.Close();
                    }
                }
            }
            else if (tabReports.SelectedTab.Text == "Defective Items")
            {
                using (MySqlConnection myConn = new MySqlConnection(strConnection))
                {

                    try
                    {
                        myConn.Open();
                        using (MySqlCommand myCmd = new MySqlCommand())
                        {
                            myCmd.Connection = myConn;
                            myCmd.CommandText = "SELECT tbliteminfo.itemcode, itemname, SUM(qnty) " +
                                                "FROM tbliteminfo, tblentries " +
                                                "WHERE  tbliteminfo.itemcode =  tblentries.itemcode AND transtype = 'Defective Item' " +
                                                "GROUP BY  tbliteminfo.itemcode";
                            MySqlDataReader myRdr = myCmd.ExecuteReader();

                            DataTable tblTemp = new DataTable();
                            tblTemp.Load(myRdr);

                            datagrdDefect.DataSource = tblTemp;
                            datagrdDefect.Columns[0].Width = 163;
                            datagrdDefect.Columns[1].Width = 163;
                            datagrdDefect.Columns[2].Width = 163;
                            datagrdDefect.Columns[2].HeaderText = "quantity";
                            datagrdDefect.AllowUserToResizeRows = false;
                            datagrdDefect.ReadOnly = true;
                        }
                    }
                    catch (Exception eM)
                    {
                        MessageBox.Show(eM.Message);
                    }
                    finally
                    {
                        myConn.Close();
                    }
                }
            }
            else if (tabReports.SelectedTab.Text == "Delivery Items")
            {
                using (MySqlConnection myConn = new MySqlConnection(strConnection))
                {

                    try
                    {
                        myConn.Open();
                        using (MySqlCommand myCmd = new MySqlCommand())
                        {
                            myCmd.Connection = myConn;
                            myCmd.CommandText = "SELECT tbliteminfo.itemcode, itemname, SUM(qnty) " +
                                                "FROM tbliteminfo, tblentries " +
                                                "WHERE  tbliteminfo.itemcode =  tblentries.itemcode AND transtype = 'Delivery' " +
                                                "GROUP BY  tbliteminfo.itemcode";
                            MySqlDataReader myRdr = myCmd.ExecuteReader();

                            DataTable tblTemp = new DataTable();
                            tblTemp.Load(myRdr);

                            datagrdDelivery.DataSource = tblTemp;
                            datagrdDelivery.Columns[0].Width = 163;
                            datagrdDelivery.Columns[1].Width = 163;
                            datagrdDelivery.Columns[2].Width = 163;
                            datagrdDelivery.Columns[2].HeaderText = "quantity";
                            datagrdDelivery.AllowUserToResizeRows = false;
                             datagrdDelivery.ReadOnly = true;
                        }
                    }
                    catch (Exception eM)
                    {
                        MessageBox.Show(eM.Message);
                    }
                    finally
                    {
                        myConn.Close();
                    }
                }
            }
        }
    }
}
