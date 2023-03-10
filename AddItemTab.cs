using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppDevProj
{
    public partial class AddItemTab : UserControl
    {
        private string strConnection = "server=localhost; database=appdevproj; uid=root; password=yourMySQLPassword";
        public AddItemTab()
        {
            InitializeComponent();
            
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrEmpty(txtBoxItemCode.Text)&&!String.IsNullOrEmpty(txtBoxItemName.Text) && !String.IsNullOrEmpty(txtBoxDescription.Text)
                && !String.IsNullOrEmpty(txtBoxCategory.Text)&& !String.IsNullOrEmpty(txtBoxQnty.Text) && !String.IsNullOrEmpty(txtBoxStockOwner.Text) 
                && !String.IsNullOrEmpty(txtBoxStorage.Text))
            {
                using(MySqlConnection myConn = new MySqlConnection(strConnection))
                {
                    try
                    {

                        myConn.Open();
                        using(MySqlCommand myCmd = new MySqlCommand()) 
                        {
                          
                            myCmd.Connection = myConn;
                            myCmd.Parameters.AddWithValue("@itemcode", txtBoxItemCode.Text.Trim());                                                  
                            myCmd.Parameters.AddWithValue("@itemname", txtBoxItemName.Text.Trim());
                            myCmd.Parameters.AddWithValue("@itemctgry", txtBoxCategory.Text.Trim());
                            myCmd.Parameters.AddWithValue("@descrptn", txtBoxDescription.Text.Trim());
                            myCmd.Parameters.AddWithValue("@transdate", dateTransaction.Value.ToString("yyyy-MM-dd"));
                            myCmd.Parameters.AddWithValue("@storageloc", txtBoxStorage.Text.Trim());
                            myCmd.Parameters.AddWithValue("@stockhldr", txtBoxStockOwner.Text.Trim());
                            myCmd.Parameters.AddWithValue("@qnty", txtBoxQnty.Text.Trim());
                            //
                            //add quantity of a item
                            //
                            myCmd.CommandText = "SELECT COUNT(*) " +
                                                "FROM tbladditem " +
                                                "WHERE itemcode = @itemcode AND transdate = @transdate AND " +
                                                "storageloc = @storageloc AND stockhldr = @stockhldr";
                            
                            int qntyCount = Int32.Parse(myCmd.ExecuteScalar().ToString());
                            if(qntyCount == 0)
                            {

                                myCmd.CommandText = "INSERT INTO tbladditem (itemcode, transdate, storageloc, stockhldr, qnty) " +
                                                    "VALUES (@itemcode, @transdate, @storageloc, @stockhldr, @qnty)";
                                myCmd.ExecuteNonQuery();
                                

                                myCmd.CommandText = "SELECT COUNT(*) FROM tbltotalqnty WHERE itemcode = @itemcode " +
                                                    "AND storageloc = @storageloc AND stockhldr = @stockhldr";
                                int totalCount = Int32.Parse(myCmd.ExecuteScalar().ToString());

                                if (totalCount == 0)
                                {
                                    myCmd.CommandText = "INSERT INTO tbltotalqnty (itemcode, stockhldr, storageloc, totalqnty) " +
                                                        "VALUES (@itemcode,  @stockhldr, @storageloc, @qnty)";
                                    myCmd.ExecuteNonQuery();
                                }
                                else
                                {
                                    myCmd.CommandText = "UPDATE tbltotalqnty SET totalqnty = totalqnty + @qnty " +
                                                        "WHERE itemcode = @itemcode AND stockhldr = @stockhldr AND storageloc = @storageloc";
                                    myCmd.ExecuteNonQuery();
                                }

                                //
                                //Add new item info
                                //
                                myCmd.CommandText = "SELECT COUNT(*) FROM tbliteminfo WHERE itemcode = @itemcode";
                                int infoCount = Int32.Parse(myCmd.ExecuteScalar().ToString());
                                if (infoCount == 0)
                                {
                                    myCmd.CommandText = "INSERT INTO tbliteminfo (itemcode, itemname, itemctgry, descrptn) " +
                                                        "VALUES (@itemcode, @itemname, @itemctgry, @descrptn)";

                                    myCmd.ExecuteNonQuery();
                                }
                                

                                MessageBox.Show("Item record is added successfully!");
                                clrAddItem();




                            }
                            else
                            {
                                MessageBox.Show("Item record is already exists!");
                            }

                        }

                    }
                    catch(Exception eM)
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
                MessageBox.Show("Please complete the needed information!");
            }
                        
        }

        public void clrAddItem()
        {
            txtBoxItemCode.Clear();
            txtBoxItemName.Clear();
            txtBoxDescription.Clear();
            txtBoxCategory.Clear();
            txtBoxQnty.Clear();
            txtBoxStockOwner.Clear();
            txtBoxStorage.Clear();
            dateTransaction.ResetText();
        }

    }
}
