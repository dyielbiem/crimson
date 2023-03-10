using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace AppDevProj
{
    public partial class LedgerEntries : UserControl
    {
        private string strConnection = "server=localhost; database=appdevproj; uid=root; password=yourMySQLPassword";
        public LedgerEntries()
        {
            this.Visible = false;
            InitializeComponent();

            datagrdDefect.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(81, 49, 54);
            datagrdDefect.ColumnHeadersDefaultCellStyle.ForeColor = Color.SeaShell;
            datagrdDefect.EnableHeadersVisualStyles = false;

            datagrdDelivery.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(81, 49, 54);
            datagrdDelivery.ColumnHeadersDefaultCellStyle.ForeColor = Color.SeaShell;
            datagrdDelivery.EnableHeadersVisualStyles = false;

            datagrdStock.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(81, 49, 54);
            datagrdStock.ColumnHeadersDefaultCellStyle.ForeColor = Color.SeaShell;
            datagrdStock.EnableHeadersVisualStyles = false;

            dataStorageMvmnt.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(81, 49, 54);
            dataStorageMvmnt.ColumnHeadersDefaultCellStyle.ForeColor = Color.SeaShell;
            dataStorageMvmnt.EnableHeadersVisualStyles = false;

        }

        private void tabLedgerEntries_Selected(object sender, TabControlEventArgs e)
        {
            readLedgerData();
        }


        public void readLedgerData()
        {
            if (tabLedgerEntries.SelectedTab.Text == "Delivery")
            {
                using (MySqlConnection myConn = new MySqlConnection(strConnection))
                {

                    try
                    {
                        myConn.Open();
                        using (MySqlCommand myCmd = new MySqlCommand())
                        {
                            myCmd.Connection = myConn;
                            myCmd.CommandText = "SELECT tbliteminfo.itemcode, itemname, descrptn, itemctgry, curstockhldr, " +
                                                "curstorage, transdate, qnty, receiver, transtype FROM tbliteminfo, tblentries " +
                                                "WHERE tbliteminfo.itemcode = tblentries.itemcode AND tblentries.transtype = 'Delivery'";
                            MySqlDataReader myRdr = myCmd.ExecuteReader();

                            DataTable tblTemp = new DataTable();
                            tblTemp.Load(myRdr);

                            datagrdDelivery.DataSource = tblTemp;
                            datagrdDelivery.AllowUserToResizeRows = false;
                            datagrdDelivery.ReadOnly = true;
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
            else if (tabLedgerEntries.SelectedTab.Text == "Storage Movement")
            {
                using (MySqlConnection myConn = new MySqlConnection(strConnection))
                {

                    try
                    {
                        myConn.Open();
                        using (MySqlCommand myCmd = new MySqlCommand())
                        {
                            myCmd.Connection = myConn;
                            myCmd.CommandText = "SELECT tbliteminfo.itemcode, itemname, descrptn, itemctgry, curstockhldr, " +
                                                "curstorage, transdate, qnty, newstorage, transtype FROM tbliteminfo, tblentries " +
                                                "WHERE tbliteminfo.itemcode = tblentries.itemcode AND tblentries.transtype = 'Storage Movement'";
                            MySqlDataReader myRdr = myCmd.ExecuteReader();

                            DataTable tblTemp = new DataTable();
                            tblTemp.Load(myRdr);

                            dataStorageMvmnt.DataSource = tblTemp;
                            dataStorageMvmnt.AllowUserToResizeRows = false;
                            dataStorageMvmnt.ReadOnly = true;
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
            else if (tabLedgerEntries.SelectedTab.Text == "Stock Transfer")
            {
                using (MySqlConnection myConn = new MySqlConnection(strConnection))
                {

                    try
                    {
                        myConn.Open();
                        using (MySqlCommand myCmd = new MySqlCommand())
                        {
                            myCmd.Connection = myConn;
                            myCmd.CommandText = "SELECT tbliteminfo.itemcode, itemname, descrptn, itemctgry, curstockhldr, " +
                                                "curstorage, transdate, qnty, newstockhldr, transtype FROM tbliteminfo, tblentries " +
                                                "WHERE tbliteminfo.itemcode = tblentries.itemcode AND tblentries.transtype = 'Stock Transfer'";
                            MySqlDataReader myRdr = myCmd.ExecuteReader();

                            DataTable tblTemp = new DataTable();
                            tblTemp.Load(myRdr);

                            datagrdStock.DataSource = tblTemp;
                            datagrdStock.AllowUserToResizeRows = false;
                            datagrdStock.ReadOnly = true;

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
            else if (tabLedgerEntries.SelectedTab.Text == "Defective Item")
            {
                using (MySqlConnection myConn = new MySqlConnection(strConnection))
                {

                    try
                    {
                        myConn.Open();
                        using (MySqlCommand myCmd = new MySqlCommand())
                        {
                            myCmd.Connection = myConn;
                            myCmd.CommandText = "SELECT tbliteminfo.itemcode, itemname, descrptn, itemctgry, curstockhldr, " +
                                                "curstorage, transdate, qnty FROM tbliteminfo, tblentries " +
                                                "WHERE tbliteminfo.itemcode = tblentries.itemcode AND tblentries.transtype = 'Defective Item'";
                            MySqlDataReader myRdr = myCmd.ExecuteReader();

                            DataTable tblTemp = new DataTable();
                            tblTemp.Load(myRdr);

                            datagrdDefect.DataSource = tblTemp;
                            datagrdDefect.AllowUserToResizeRows = false;
                            datagrdDefect.ReadOnly = true;
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
}
