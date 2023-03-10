using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppDevProj
{
    public partial class ItemTransaction : UserControl
    {
        private string strConnection = "server=localhost; database=appdevproj; uid=root; password=yourMySQLPassword";
        private List<string> listDescription = new List<string>();
        private List<string> listCategory = new List<string>();
        private List<string> listDlvryStockHldr = new List<string>();
        private List<string> listDlvryStorage = new List<string>();

        

        public ItemTransaction()
        {
           
            InitializeComponent();
            startupItemTrans();
            
        }

        

        private void startupItemTrans()
        {
            this.Hide();
            lblReceiver.Hide();
            lblCurStockHldr.Hide();
            lblCurStorage.Hide();
            txtBoxReceiver.Hide();
            cmbCurStockHldr.Hide();
            cmbCurStorage.Hide();
            txtBoxQnty.Hide();
            lblQnty.Hide();
            lblNewStockHldr.Hide();
            lblNewStorage.Hide();
            cmbNewStockHldr.Hide();
            cmbNewStorage.Hide();
            lblTransDate.Hide();
            dateTransaction.Hide();
            lblStockNum.Hide();
            txtBoxStockNum.Hide();
            btnEnter.Hide();
            lblDlvryStockHldr.Hide();
            cmbDlvryStockHldr.Hide();
            lblDlvryStorage.Hide();
            cmbDlvryStorage.Hide();
            cmbFrmStock.Hide();
            lblFrmStock.Hide();
            cmbFrmStorage.Hide();
            lblFrmStorageLoc.Hide();
        }


     

        private string transtype;
        private void btnDelivery_Click(object sender, EventArgs e)
        {


            cmbCurStockHldr.SelectedItem = null;
            cmbNewStockHldr.SelectedItem = null;
            cmbFrmStorage.SelectedItem = null;
            cmbCurStorage.SelectedItem = null;
            cmbNewStorage.SelectedItem = null;
            cmbFrmStock.SelectedItem = null;
            txtBoxReceiver.Clear();
            txtBoxQnty.Clear();
            txtBoxStockNum.Clear();


            btnStorageMvmnt.BackColor = Color.FromArgb(81, 49, 54);
            btnStorageMvmnt.ForeColor = Color.SeaShell;
            btnStockTrnsfr.BackColor = Color.FromArgb(81, 49, 54);
            btnStockTrnsfr.ForeColor = Color.SeaShell;
            btnDefectItem.BackColor = Color.FromArgb(81, 49, 54);
            btnDefectItem.ForeColor = Color.SeaShell;

            btnDelivery.BackColor = Color.FromArgb(55, 31, 37);
            btnDelivery.ForeColor = Color.FromArgb(219, 183, 171);


            lblNewStockHldr.Hide();
            lblNewStorage.Hide();
            cmbNewStockHldr.Hide();
            cmbNewStorage.Hide();            
            lblCurStockHldr.Hide();
            lblCurStorage.Hide();
            cmbCurStockHldr.Hide();
            cmbCurStorage.Hide();
            cmbFrmStock.Hide();
            lblFrmStock.Hide();
            cmbFrmStorage.Hide();
            lblFrmStorageLoc.Hide();

            lblStockNum.Show();
            txtBoxStockNum.Show();
            lblTransDate.Show();
            dateTransaction.Show();
            txtBoxQnty.Show();
            lblQnty.Show();
            txtBoxReceiver.Show();
            lblReceiver.Show();
            btnEnter.Show();
            lblDlvryStockHldr.Show();
            cmbDlvryStockHldr.Show();
            lblDlvryStorage.Show();
            cmbDlvryStorage.Show();
            

            transtype = "Delivery";

            
            
        }

      

        private void btnStorageMvmnt_Click(object sender, EventArgs e)
        {
            cmbCurStockHldr.SelectedItem = null;
            cmbNewStockHldr.SelectedItem = null;
            cmbNewStorage.SelectedItem = null;
            cmbFrmStock.SelectedItem = null;
            cmbDlvryStockHldr.SelectedItem = null;
            cmbDlvryStorage.SelectedItem = null;
            txtBoxReceiver.Clear();
            txtBoxQnty.Clear();
            txtBoxStockNum.Clear();

            btnStockTrnsfr.BackColor = Color.FromArgb(81, 49, 54);
            btnStockTrnsfr.ForeColor = Color.SeaShell;
            btnDefectItem.BackColor = Color.FromArgb(81, 49, 54);
            btnDefectItem.ForeColor = Color.SeaShell;
            btnDelivery.BackColor = Color.FromArgb(81, 49, 54);
            btnDelivery.ForeColor = Color.SeaShell;

            btnStorageMvmnt.BackColor = Color.FromArgb(55, 31, 37);
            btnStorageMvmnt.ForeColor = Color.FromArgb(219, 183, 171);




            txtBoxReceiver.Hide();
            cmbCurStockHldr.Hide();
            cmbNewStockHldr.Hide();
            lblCurStockHldr.Hide();
            cmbNewStockHldr.Hide();
            lblNewStockHldr.Hide();
            lblReceiver.Hide();
            txtBoxReceiver.Hide();
            lblDlvryStockHldr.Hide();
            cmbDlvryStockHldr.Hide();
            lblDlvryStorage.Hide();
            cmbDlvryStorage.Hide();
            cmbFrmStorage.Hide();
            lblFrmStorageLoc.Hide();
            


            cmbNewStorage.Show();
            lblNewStorage.Show();
            lblStockNum.Show();
            txtBoxStockNum.Show();
            lblTransDate.Show();
            dateTransaction.Show();

            cmbCurStorage.Show();
            lblCurStorage.Show();

            txtBoxQnty.Show();
            lblQnty.Show();


            btnEnter.Show();
            cmbFrmStock.Show();
            lblFrmStock.Show();
          
            

            transtype = "Storage Movement";

        }

        private void btnStockTrnsfr_Click(object sender, EventArgs e)
        {

            cmbFrmStorage.SelectedItem = null;
            cmbCurStorage.SelectedItem = null;
            cmbNewStorage.SelectedItem = null;
            cmbFrmStock.SelectedItem = null;
            cmbDlvryStockHldr.SelectedItem = null;
            cmbDlvryStorage.SelectedItem = null;
            txtBoxReceiver.Clear();
            txtBoxQnty.Clear();
            txtBoxStockNum.Clear();

            btnDefectItem.BackColor = Color.FromArgb(81, 49, 54);
            btnDefectItem.ForeColor = Color.SeaShell;
            btnDelivery.BackColor = Color.FromArgb(81, 49, 54);
            btnDelivery.ForeColor = Color.SeaShell;
            btnStorageMvmnt.BackColor = Color.FromArgb(81, 49, 54);
            btnStorageMvmnt.ForeColor = Color.SeaShell;

            btnStockTrnsfr.BackColor = Color.FromArgb(55, 31, 37);
            btnStockTrnsfr.ForeColor = Color.FromArgb(219, 183, 171);

            cmbNewStorage.Hide();
            lblNewStorage.Hide();
            cmbCurStorage.Hide();
            lblCurStorage.Hide();

            lblReceiver.Hide();
            txtBoxReceiver.Hide();

            lblCurStorage.Hide();
            cmbCurStorage.Hide();
            lblDlvryStockHldr.Hide();
            cmbDlvryStockHldr.Hide();
            lblDlvryStorage.Hide();
            cmbDlvryStorage.Hide();
            cmbFrmStock.Hide();
            lblFrmStock.Hide();

            lblStockNum.Show();
            txtBoxStockNum.Show();
            cmbCurStockHldr.Show();
            lblCurStockHldr.Show();
            cmbNewStockHldr.Show();
            lblNewStockHldr.Show();
            txtBoxQnty.Show();
            lblQnty.Show();
            lblTransDate.Show();
            dateTransaction.Show();
            btnEnter.Show();
            cmbFrmStorage.Show();
            lblFrmStorageLoc.Show();

            transtype = "Stock Transfer";
        }

        private void btnDefectItem_Click(object sender, EventArgs e)
        {

            cmbCurStockHldr.SelectedItem = null;
            cmbNewStockHldr.SelectedItem = null;
            cmbFrmStorage.SelectedItem = null;
            cmbCurStorage.SelectedItem = null;
            cmbNewStorage.SelectedItem = null;
            cmbFrmStock.SelectedItem = null;
            txtBoxReceiver.Clear();
            txtBoxQnty.Clear();
            txtBoxStockNum.Clear();

            btnDelivery.BackColor = Color.FromArgb(81, 49, 54);
            btnDelivery.ForeColor = Color.SeaShell;
            btnStorageMvmnt.BackColor = Color.FromArgb(81, 49, 54);
            btnStorageMvmnt.ForeColor = Color.SeaShell;
            btnStockTrnsfr.BackColor = Color.FromArgb(81, 49, 54);
            btnStockTrnsfr.ForeColor = Color.SeaShell;

            btnDefectItem.BackColor = Color.FromArgb(55, 31, 37);
            btnDefectItem.ForeColor = Color.FromArgb(219, 183, 171);

            lblNewStockHldr.Hide();
            cmbNewStockHldr.Hide();
            lblNewStorage.Hide();
            cmbNewStorage.Hide();

            lblReceiver.Hide();
            txtBoxReceiver.Hide();

            lblCurStockHldr.Hide();
            lblCurStorage.Hide();
            cmbCurStockHldr.Hide();
            cmbCurStorage.Hide();
            cmbFrmStock.Hide();
            lblFrmStock.Hide();
            cmbFrmStorage.Hide();
            lblFrmStorageLoc.Hide();

            lblStockNum.Show();
            txtBoxStockNum.Show();
            txtBoxQnty.Show();
            lblQnty.Show();
            btnEnter.Show();
            lblTransDate.Show();
            dateTransaction.Show();
            lblDlvryStockHldr.Show();
            cmbDlvryStockHldr.Show();
            lblDlvryStorage.Show();
            cmbDlvryStorage.Show();

            transtype = "Defective Item";

        }

        

        private void cmbItemCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbItemName.SelectedIndex = cmbItemCode.SelectedIndex;
            cmbDlvryStockHldr.Items.Clear();
            cmbDlvryStorage.Items.Clear();
            listDlvryStockHldr.Clear();
            listDlvryStorage.Clear();

            using (MySqlConnection myConn = new MySqlConnection(strConnection))
            {

                try
                {

                    myConn.Open();
                    using (MySqlCommand myCmd = new MySqlCommand())
                    {
                        if (!string.IsNullOrEmpty(cmbItemCode.Text))
                        {
                            myCmd.Connection = myConn;
                            myCmd.Parameters.AddWithValue("@itemcode", cmbItemCode.Text);
                            myCmd.CommandText = "SELECT * FROM tbltotalqnty WHERE itemcode = @itemcode " +
                                                "GROUP BY stockhldr";
                            MySqlDataReader myRdr = myCmd.ExecuteReader();


                            while (myRdr.Read())
                            {
                                listDlvryStockHldr.Add((string)myRdr["stockhldr"]);
                            }
                            myRdr.Close();

                            foreach (string dlvryStockHldr in listDlvryStockHldr)
                            {
                                cmbDlvryStockHldr.Items.Add(dlvryStockHldr);
                            }


                            myCmd.CommandText = "SELECT * FROM tbltotalqnty WHERE itemcode = @itemcode " +
                                                "GROUP BY storageloc";
                            myRdr = myCmd.ExecuteReader();


                            while (myRdr.Read())
                            {
                                listDlvryStorage.Add((string)myRdr["storageloc"]);
                            }
                            myRdr.Close();

                            foreach (string dlvryStorage in listDlvryStorage)
                            {
                                cmbDlvryStorage.Items.Add(dlvryStorage);
                            }
                        }

                    }

                    cmbDlvryStorage.Enabled = false;
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




            getStock();

        }

        private void cmbItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbItemCode.SelectedIndex = cmbItemName.SelectedIndex;

            using (MySqlConnection myConn = new MySqlConnection(strConnection))
            {

                try
                {
                    myConn.Open();
                    using (MySqlCommand myCmd = new MySqlCommand())
                    {
                        if (!string.IsNullOrEmpty(cmbItemCode.Text))
                        {
                            myCmd.Connection = myConn;
                            myCmd.Parameters.AddWithValue("@itemcode", cmbItemCode.SelectedItem);
                            myCmd.CommandText = "SELECT itemctgry FROM tbliteminfo WHERE itemcode = @itemcode " +
                                                "GROUP BY itemcode";
                            txtBoxCtgry.Text = myCmd.ExecuteScalar().ToString();

                            myCmd.CommandText = "SELECT descrptn FROM tbliteminfo WHERE itemcode = @itemcode " +
                                                "GROUP BY itemcode";
                            txtBoxDesc.Text = myCmd.ExecuteScalar().ToString();
                        }

                       

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

        

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbItemCode.Text))
            {
                using (MySqlConnection myConn = new MySqlConnection(strConnection))
                {
                    
                    try
                    {
                        myConn.Open();
                        using (MySqlCommand myCmd = new MySqlCommand())
                        {
                            myCmd.Connection = myConn;

                            myCmd.Parameters.AddWithValue("@qnty", txtBoxQnty.Text);
                            myCmd.Parameters.AddWithValue("@itemcode", cmbItemCode.Text);
                            myCmd.Parameters.AddWithValue("@transtype", transtype);
                            myCmd.Parameters.AddWithValue("@transdate", dateTransaction.Value.ToString("yyyy-MM-dd"));
                            myCmd.Parameters.AddWithValue("@receiver", txtBoxReceiver.Text);
                            myCmd.Parameters.AddWithValue("@curstorage", cmbDlvryStorage.SelectedItem);
                            myCmd.Parameters.AddWithValue("@curstockhldr", cmbDlvryStockHldr.SelectedItem);

                            myCmd.Parameters.AddWithValue("@curstoragemv", cmbCurStorage.SelectedItem);
                            myCmd.Parameters.AddWithValue("@curstockhldrmv", cmbFrmStock.SelectedItem);
                            myCmd.Parameters.AddWithValue("@newstoragemv", cmbNewStorage.SelectedItem);

                            myCmd.Parameters.AddWithValue("@curstockhldrtf", cmbCurStockHldr.SelectedItem);
                            myCmd.Parameters.AddWithValue("@curstoragetf", cmbFrmStorage.SelectedItem);
                            myCmd.Parameters.AddWithValue("@newstockhldrtf", cmbNewStockHldr.SelectedItem);

                            if (!string.IsNullOrEmpty(txtBoxStockNum.Text))
                            {
                                if (!string.IsNullOrEmpty(txtBoxQnty.Text) && Int32.Parse(txtBoxQnty.Text) > 0)
                                {
                                    if (Int32.Parse(txtBoxQnty.Text) <= Int32.Parse(txtBoxStockNum.Text))
                                    {
                                        if (transtype == "Delivery")
                                        {
                                            if (!string.IsNullOrEmpty(txtBoxReceiver.Text) && !string.IsNullOrEmpty(cmbDlvryStockHldr.Text) && !string.IsNullOrEmpty(cmbDlvryStorage.Text) && !string.IsNullOrEmpty(txtBoxStockNum.Text))
                                            {


                                                myCmd.CommandText = "INSERT INTO tblentries (curstockhldr, curstorage, itemcode, transtype, transdate, qnty, receiver) " +
                                                                    "VALUES (@curstockhldr, @curstorage, @itemcode, @transtype, @transdate, @qnty, @receiver)";
                                                myCmd.ExecuteNonQuery();


                                                myCmd.CommandText = "UPDATE tbltotalqnty SET totalqnty = totalqnty - @qnty " +
                                                                    "WHERE itemcode = @itemcode AND stockhldr = @curstockhldr AND storageloc = @curstorage";

                                                myCmd.ExecuteNonQuery();

                                                MessageBox.Show("Delivery Transaction Successful!");
                                                clearItemTrans();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please complete the information needed!");
                                            }

                                        }
                                        else if (transtype == "Storage Movement")
                                        {
                                            if (!string.IsNullOrEmpty(cmbCurStorage.Text) && !string.IsNullOrEmpty(cmbFrmStock.Text) && !string.IsNullOrEmpty(cmbNewStorage.Text))
                                            {
                                                myCmd.CommandText = "INSERT INTO tblentries (curstockhldr, curstorage, newstorage, itemcode, transtype, transdate, qnty) " +
                                                                   "VALUES (@curstockhldrmv, @curstoragemv, @newstoragemv, @itemcode, @transtype, @transdate, @qnty)";
                                                myCmd.ExecuteNonQuery();

                                                myCmd.CommandText = "UPDATE tbltotalqnty SET totalqnty = totalqnty - @qnty " +
                                                                        "WHERE itemcode = @itemcode AND stockhldr = @curstockhldrmv AND storageloc = @curstoragemv";

                                                myCmd.ExecuteNonQuery();

                                                myCmd.CommandText = "SELECT COUNT(*) FROM tbltotalqnty " +
                                                                    "WHERE itemcode = @itemcode AND stockhldr = @curstockhldrmv AND storageloc = @newstoragemv";

                                                int storageCount = Int32.Parse(myCmd.ExecuteScalar().ToString());

                                                if (storageCount == 0)
                                                {
                                                    myCmd.CommandText = "INSERT INTO tbltotalqnty (itemcode, stockhldr, storageloc, totalqnty) " +
                                                                       "VALUES (@itemcode, @curstockhldrmv, @newstoragemv, @qnty)";
                                                    myCmd.ExecuteNonQuery();
                                                }
                                                else
                                                {
                                                    myCmd.CommandText = "UPDATE tbltotalqnty SET totalqnty = totalqnty + @qnty " +
                                                                        "WHERE itemcode = @itemcode AND stockhldr = @curstockhldrmv AND storageloc = @newstoragemv";
                                                    myCmd.ExecuteNonQuery();
                                                }

                                                MessageBox.Show("Storage Movement Transaction Successful!");
                                                clearItemTrans();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please complete the information needed!");
                                            }


                                            


                                        }
                                        else if (transtype == "Stock Transfer")
                                        {
                                            if (!string.IsNullOrEmpty(cmbCurStockHldr.Text) && !string.IsNullOrEmpty(cmbFrmStorage.Text) && !string.IsNullOrEmpty(cmbNewStockHldr.Text))
                                            {
                                                myCmd.CommandText = "INSERT INTO tblentries (curstockhldr, curstorage, newstockhldr, itemcode, transtype, transdate, qnty) " +
                                                                   "VALUES (@curstockhldrtf, @curstoragetf, @newstockhldrtf, @itemcode, @transtype, @transdate, @qnty)";
                                                myCmd.ExecuteNonQuery();

                                                myCmd.CommandText = "UPDATE tbltotalqnty SET totalqnty = totalqnty - @qnty " +
                                                                        "WHERE itemcode = @itemcode AND stockhldr = @curstockhldrtf AND storageloc = @curstoragetf";

                                                myCmd.ExecuteNonQuery();

                                                myCmd.CommandText = "SELECT COUNT(*) FROM tbltotalqnty " +
                                                                    "WHERE itemcode = @itemcode AND stockhldr = @newstockhldrtf AND storageloc = @curstoragetf";

                                                int storageCount = Int32.Parse(myCmd.ExecuteScalar().ToString());

                                                if (storageCount == 0)
                                                {
                                                    myCmd.CommandText = "INSERT INTO tbltotalqnty (itemcode, storageloc, stockhldr, totalqnty) " +
                                                                       "VALUES (@itemcode, @curstoragetf, @newstockhldrtf, @qnty)";
                                                    myCmd.ExecuteNonQuery();
                                                }
                                                else
                                                {
                                                    myCmd.CommandText = "UPDATE tbltotalqnty SET totalqnty = totalqnty + @qnty " +
                                                                        "WHERE itemcode = @itemcode AND stockhldr = @newstockhldrtf AND storageloc = @curstoragetf";
                                                    myCmd.ExecuteNonQuery();
                                                }

                                                MessageBox.Show("Stock Transfer Transaction Successful!");
                                                clearItemTrans();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please complete the information needed!");
                                            }

                                            
                                        }
                                        else if (transtype == "Defective Item")
                                        {
                                            if (!string.IsNullOrEmpty(cmbDlvryStockHldr.Text) && !string.IsNullOrEmpty(cmbDlvryStorage.Text) && !string.IsNullOrEmpty(txtBoxStockNum.Text))
                                            {
                                                myCmd.CommandText = "INSERT INTO tblentries (curstockhldr, curstorage, itemcode, transtype, transdate, qnty) " +
                                                                  "VALUES (@curstockhldr, @curstorage, @itemcode, @transtype, @transdate, @qnty)";
                                                myCmd.ExecuteNonQuery();


                                                myCmd.CommandText = "UPDATE tbltotalqnty SET totalqnty = totalqnty - @qnty " +
                                                                    "WHERE itemcode = @itemcode AND stockhldr = @curstockhldr AND storageloc = @curstorage";

                                                myCmd.ExecuteNonQuery();

                                                MessageBox.Show("Defective Item Report Transaction Successful!");
                                                clearItemTrans();
                                            }
                                            else
                                            {
                                                 MessageBox.Show("Please complete the information needed!");
                                            }


                                        }
                                    }
                                    else
                                    {


                                        MessageBox.Show("Insufficient stock!");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Please enter a valid quantity!");

                                }

                                


                            }
                            else
                            {
                                MessageBox.Show("Complete the needed information!");
                            }

                            

                            
                            
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
            else
            {
                MessageBox.Show("Complete the needed information!");
            }

            
        }


        //
        //Reset Delivery Trans
        //
        private void cmbDlvryStockHldr_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDlvryStorage.Items.Clear();
            listDlvryStorage.Clear();
            using (MySqlConnection myConn = new MySqlConnection(strConnection))
            {
                try
                {

                    myConn.Open();
                    using (MySqlCommand myCmd = new MySqlCommand())
                    {
                        listDlvryStorage.Clear();
                        myCmd.Connection = myConn;
                        myCmd.Parameters.AddWithValue("@stockhldr", cmbDlvryStockHldr.SelectedItem);
                        myCmd.Parameters.AddWithValue("@itemcode", cmbItemCode.SelectedItem);
                        myCmd.CommandText = "SELECT * FROM tbltotalqnty WHERE stockhldr = @stockhldr AND itemcode = @itemcode";
                        MySqlDataReader myRdr = myCmd.ExecuteReader();

                        while (myRdr.Read())
                        {
                            listDlvryStorage.Add((string)myRdr["storageloc"]);
                        }

                        foreach (string dlvryStorage in listDlvryStorage)
                        {
                            cmbDlvryStorage.Items.Add(dlvryStorage);
                        }
                        myRdr.Close();
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


        private void cmbDlvryStockHldr_DropDown(object sender, EventArgs e)
        {
            cmbDlvryStockHldr.Text = null;
            getStock();
            
        }
        private void cmbDlvryStockHldr_DropDownClosed(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbDlvryStockHldr.Text))
            {
                cmbDlvryStorage.Enabled = true;
            }
            else
            {
                cmbDlvryStorage.Enabled = false;
                cmbCurStockHldr.Text = null;
                txtBoxQnty.Clear();
                txtBoxStockNum.Clear();

            }
        }

        private void getStock()
        {
            
            using (MySqlConnection myConn = new MySqlConnection(strConnection))
            {

                try
                {
                    myConn.Open();
                    using (MySqlCommand myCmd = new MySqlCommand())
                    {
                        if(!string.IsNullOrEmpty(cmbDlvryStockHldr.Text) && !string.IsNullOrEmpty(cmbDlvryStorage.Text) &&
                            !string.IsNullOrEmpty(cmbItemCode.Text))
                        {
                            myCmd.Connection = myConn;
                            myCmd.Parameters.AddWithValue("@stockhldr", cmbDlvryStockHldr.SelectedItem);
                            myCmd.Parameters.AddWithValue("@storageloc", cmbDlvryStorage.SelectedItem);
                            myCmd.Parameters.AddWithValue("@itemcode", cmbItemCode.SelectedItem);
                            myCmd.CommandText = "SELECT totalqnty FROM tbltotalqnty " +
                                                "WHERE itemcode = @itemcode AND stockhldr = @stockhldr AND storageloc = @storageloc";

                            txtBoxStockNum.Text = myCmd.ExecuteScalar().ToString();
                        }
                        

                       

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

        private void cmbDlvryStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            getStock();
        }


        private void cmbItemCode_DropDown(object sender, EventArgs e)
        {

            using (MySqlConnection myConn = new MySqlConnection(strConnection))
            {

                try
                {
                    myConn.Open();
                    using (MySqlCommand myCmd = new MySqlCommand())
                    {
                        cmbItemCode.Items.Clear();
                        cmbItemName.Items.Clear();
                        myCmd.Connection = myConn;
                        myCmd.CommandText = "SELECT * FROM tbliteminfo GROUP BY itemcode";
                        MySqlDataReader myRdr = myCmd.ExecuteReader();

                        while (myRdr.Read())
                        {
                            cmbItemCode.Items.Add((string)myRdr["itemcode"]);
                            cmbItemName.Items.Add((string)myRdr["itemname"]);
                            listDescription.Add((string)myRdr["descrptn"]);
                            listCategory.Add((string)myRdr["itemctgry"]);
                        }

                        myRdr.Close();

                        

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

        private void cmbItemName_DropDown(object sender, EventArgs e)
        {
            using (MySqlConnection myConn = new MySqlConnection(strConnection))
            {

                try
                {
                    myConn.Open();
                    using (MySqlCommand myCmd = new MySqlCommand())
                    {
                        cmbItemCode.Items.Clear();
                        cmbItemName.Items.Clear();
                        myCmd.Connection = myConn;
                        myCmd.CommandText = "SELECT * FROM tbliteminfo GROUP BY itemname";
                        MySqlDataReader myRdr = myCmd.ExecuteReader();

                        while (myRdr.Read())
                        {
                            cmbItemCode.Items.Add((string)myRdr["itemcode"]);
                            cmbItemName.Items.Add((string)myRdr["itemname"]);
                        }

                        myRdr.Close();



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

        private void cmbItemCode_DropDownClosed(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbItemCode.Text))
            {
                clearCntnt();
            }
        }

        private void cmbItemName_DropDownClosed(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbItemCode.Text))
            {
                clearCntnt();
            }
        }

        public void clearItemTrans()
        {
            cmbItemCode.Text = null;
            clearCntnt();
        }

        private void clearCntnt()
        {
            txtBoxCtgry.Clear();
            txtBoxDesc.Clear();
            cmbDlvryStorage.Items.Clear();
            cmbDlvryStockHldr.Items.Clear();
            cmbCurStorage.Items.Clear();
            cmbFrmStock.Items.Clear();
            cmbNewStorage.Items.Clear();
            cmbFrmStorage.Items.Clear();
            cmbCurStockHldr.Items.Clear();
            txtBoxReceiver.Clear();
            txtBoxQnty.Clear();
            txtBoxStockNum.Clear();
            cmbNewStockHldr.Items.Clear();

            dateTransaction.ResetText();
        }

        private void cmbCurStorage_DropDown(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(cmbItemCode.Text))
            {
                using (MySqlConnection myConn = new MySqlConnection(strConnection))
                {
                    cmbCurStorage.Items.Clear();

                    try
                    {
                        myConn.Open();
                        using (MySqlCommand myCmd = new MySqlCommand())
                        {
                            myCmd.Connection = myConn;
                            myCmd.Parameters.AddWithValue("@itemcode", cmbItemCode.SelectedItem);
                            myCmd.CommandText = "SELECT * FROM tbltotalqnty " +
                                                "WHERE itemcode = @itemcode GROUP BY storageloc ";
                            MySqlDataReader myRdr = myCmd.ExecuteReader();

                            while (myRdr.Read())
                            {
                                cmbCurStorage.Items.Add((string)myRdr["storageloc"]);
                            }

                            myRdr.Close();
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

        private void cmbFrmStock_DropDown(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbCurStorage.Text))
            {
                cmbFrmStock.Items.Clear();
                using (MySqlConnection myConn = new MySqlConnection(strConnection))
                {

                    try
                    {
                        myConn.Open();
                        using (MySqlCommand myCmd = new MySqlCommand())
                        {
                            myCmd.Connection = myConn;
                            myCmd.Parameters.AddWithValue("@itemcode", cmbItemCode.SelectedItem);
                            myCmd.Parameters.AddWithValue("@storageloc", cmbCurStorage.SelectedItem);
                            myCmd.CommandText = "SELECT stockhldr FROM tbltotalqnty " +
                                                "WHERE itemcode = @itemcode and storageloc = @storageloc";
                            MySqlDataReader myRdr = myCmd.ExecuteReader();

                            while (myRdr.Read())
                            {
                                cmbFrmStock.Items.Add((string)myRdr["stockhldr"]);

                            }

                            myRdr.Close();
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


        private void cmbCurStorage_DropDownClosed(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbCurStorage.Text))
            {
                cmbFrmStock.Enabled = true;
            }
            else
            {
                cmbFrmStock.Enabled = false;
                cmbFrmStock.Text = null;
                txtBoxStockNum.Text = null;
                cmbNewStorage.Text = null;
                txtBoxQnty.Clear();

            }
        }

        private void cmbFrmStock_DropDownClosed(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(cmbFrmStock.Text))
            {
                cmbNewStorage.Items.Clear();
                using (MySqlConnection myConn = new MySqlConnection(strConnection))
                {

                    try
                    {
                        myConn.Open();
                        using (MySqlCommand myCmd = new MySqlCommand())
                        {
                            myCmd.Connection = myConn;
                            myCmd.CommandText = "SELECT * FROM tbltotalqnty GROUP BY storageloc";
                            MySqlDataReader myRdr = myCmd.ExecuteReader();

                            while (myRdr.Read())
                            {
                                cmbNewStorage.Items.Add((string)myRdr["storageloc"]);

                            }

                            myRdr.Close();


                            if(!string.IsNullOrEmpty(cmbFrmStock.Text) && !string.IsNullOrEmpty(cmbCurStorage.Text) && !string.IsNullOrEmpty(cmbItemCode.Text))
                            {
                                myCmd.Parameters.AddWithValue("@stockhldr",  cmbFrmStock.SelectedItem);
                                myCmd.Parameters.AddWithValue("@storageloc", cmbCurStorage.SelectedItem);
                                myCmd.Parameters.AddWithValue("@itemcode", cmbItemCode.SelectedItem);
                                myCmd.CommandText = "SELECT  totalqnty FROM tbltotalqnty WHERE itemcode = @itemcode AND stockhldr = @stockhldr AND " +
                                                    "storageloc = @storageloc";

                                txtBoxStockNum.Text = myCmd.ExecuteScalar().ToString();
                            }
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
            else
            {
                cmbNewStorage.Items.Clear();
                txtBoxStockNum.Clear();
                txtBoxQnty.Clear();
            }
        }

        private void cmbCurStockHldr_DropDown(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbItemCode.Text))
            {
                using (MySqlConnection myConn = new MySqlConnection(strConnection))
                {
                    cmbCurStockHldr.Items.Clear();

                    try
                    {
                        myConn.Open();
                        using (MySqlCommand myCmd = new MySqlCommand())
                        {
                            myCmd.Connection = myConn;
                            myCmd.Parameters.AddWithValue("@itemcode", cmbItemCode.SelectedItem);
                            myCmd.CommandText = "SELECT * FROM tbltotalqnty " +
                                                "WHERE itemcode = @itemcode GROUP BY stockhldr ";
                            MySqlDataReader myRdr = myCmd.ExecuteReader();

                            while (myRdr.Read())
                            {
                                cmbCurStockHldr.Items.Add((string)myRdr["stockhldr"]);
                            }

                            myRdr.Close();
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

        private void cmbCurStockHldr_DropDownClosed(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbCurStockHldr.Text))
            {
                cmbFrmStorage.Enabled = false;
                cmbFrmStorage.Items.Clear();
                cmbFrmStock.Text = null;
                txtBoxStockNum.Text = null;
                cmbNewStockHldr.Text = null;
                txtBoxQnty.Clear();
            }
            else
            {
                cmbFrmStorage.Enabled = true;
                
                
            }
        }

        private void cmbFrmStorage_DropDown(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(cmbCurStockHldr.Text))
            {
                cmbFrmStorage.Items.Clear();
                using (MySqlConnection myConn = new MySqlConnection(strConnection))
                {

                    try
                    {
                        myConn.Open();
                        using (MySqlCommand myCmd = new MySqlCommand())
                        {
                            myCmd.Connection = myConn;
                            myCmd.Parameters.AddWithValue("@itemcode", cmbItemCode.SelectedItem);
                            myCmd.Parameters.AddWithValue("@stockhldr", cmbCurStockHldr.SelectedItem);
                            myCmd.CommandText = "SELECT storageloc FROM tbltotalqnty " +
                                                "WHERE itemcode = @itemcode and stockhldr = @stockhldr";
                            MySqlDataReader myRdr = myCmd.ExecuteReader();

                            while (myRdr.Read())
                            {
                                cmbFrmStorage.Items.Add((string)myRdr["storageloc"]);

                            }

                            myRdr.Close();
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

        private void cmbFrmStorage_DropDownClosed(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(cmbFrmStorage.Text))
            {
                cmbNewStockHldr.Items.Clear();
                using (MySqlConnection myConn = new MySqlConnection(strConnection))
                {

                    try
                    {
                        myConn.Open();
                        using (MySqlCommand myCmd = new MySqlCommand())
                        {
                            myCmd.Connection = myConn;
                            myCmd.CommandText = "SELECT * FROM tbltotalqnty GROUP BY stockhldr";
                            MySqlDataReader myRdr = myCmd.ExecuteReader();

                            while (myRdr.Read())
                            {
                                cmbNewStockHldr.Items.Add((string)myRdr["stockhldr"]);

                            }

                            myRdr.Close();


                            if (!string.IsNullOrEmpty(cmbCurStockHldr.Text) && !string.IsNullOrEmpty(cmbFrmStorage.Text) && !string.IsNullOrEmpty(cmbItemCode.Text))
                            {
                                myCmd.Parameters.AddWithValue("@stockhldr", cmbCurStockHldr.SelectedItem);
                                myCmd.Parameters.AddWithValue("@storageloc", cmbFrmStorage.SelectedItem);
                                myCmd.Parameters.AddWithValue("@itemcode", cmbItemCode.SelectedItem);
                                myCmd.CommandText = "SELECT  totalqnty FROM tbltotalqnty WHERE itemcode = @itemcode AND stockhldr = @stockhldr AND " +
                                                    "storageloc = @storageloc";

                                txtBoxStockNum.Text = myCmd.ExecuteScalar().ToString();
                            }
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
            else
            {
                cmbNewStockHldr.Items.Clear();
                txtBoxStockNum.Clear();
                txtBoxQnty.Clear();
            }

        }

        private void cmbDlvryStorage_DropDownClosed(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbDlvryStorage.Text))
            {
                txtBoxStockNum.Clear();
            }
        }
    }
}
