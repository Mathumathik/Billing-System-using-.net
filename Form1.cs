using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mini_project
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"data source=MATHUMATHIK\SQLEXPRESS; initial catalog = Billing; integrated security=true ");
        public int Total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        //public string GetInvoiceNo()
        //{
        //    if(con.State.ToString() != "Open")
        //    {
        //        con.Open();
        //    }
            
        //    SqlCommand cmd = new SqlCommand("SELECT Top 1 InvoiceNo FROM InvoiceDetails ORDER BY InvoiceNo DESC", con);
        //    SqlDataReader sdr = cmd.ExecuteReader();
        //    int ino = 0;
        //    if(sdr.Read())
        //    {
        //         ino = int.Parse(sdr["InvoiceNo"].ToString())+1;               
        //    }
        //    con.Close();
        //    return ino.ToString();
            
        //}
      public void ShowDtails()
        {
            
            SqlDataAdapter sda = new SqlDataAdapter("Select BillDate,ProductId,ProductName,ProductQuantity,Price,Total from BillDetail where PrintStatus='N'", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
    
         }

        public void FieldEmpty()
        {
            txt_ProductID.Text = " ";
            txt_ProductName.Text = " ";
            txt_Price.Text = " ";
            comb_Quantity.Text = " ";
            dataGridView1.Text = " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             FieldEmpty();
            
        }

      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_ProductID_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PRODUCTDETAILS WHERE PRODUCTID = "+txt_ProductID.Text,con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if(sdr.Read())
                {
                    txt_ProductID.Text = sdr["ProductId"].ToString();
                    txt_ProductName.Text = sdr["ProductName"].ToString();
                    txt_Price.Text = Math.Round(Convert.ToDouble(sdr["Price"])).ToString();
                }
                else
                {
                    MessageBox.Show(" No data found");
                }
                con.Close();
            }
            catch (SqlException sqlE)
            {
                MessageBox.Show(sqlE.ToString());
            }
            

            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_ProductID.Text == " ")
            {
                MessageBox.Show("Please enter Product ID");
            }
            else if(comb_Quantity.Text ==" ")
            {
                MessageBox.Show("Please Select the Quatity");
            }
            else
            {
                try
                {
                    con.Open();

                    DateTime dateTime = DateTime.UtcNow.Date;
                    string getdate = dateTime.ToString("yyyy/MM/dd");
                    int total = int.Parse(txt_Price.Text) * int.Parse(comb_Quantity.Text);
                    SqlCommand cmd = new SqlCommand("INSERT INTO BillDetail(BillDate,ProductId,ProductName,ProductQuantity,Price,PrintStatus,Total) VALUES('" + getdate + "'," + txt_ProductID.Text + ", ' " + txt_ProductName.Text + " '," + comb_Quantity.Text + "," + txt_Price.Text + ",'N'," + total + ")", con);
                    Total += int.Parse(txt_Price.Text) * int.Parse(comb_Quantity.Text);
                    label_Total.Text = Total.ToString();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {

                        MessageBox.Show("Product Added Sucessfully");
                        ShowDtails();
                        FieldEmpty();
                    }
                    else
                    {
                        MessageBox.Show(" Product Not Added");
                    }
                    con.Close();
                }
                catch (SqlException sqlE)
                {
                    MessageBox.Show(sqlE.ToString());
                }
            }
            //FieldEmpty();
            
        }

        private void btn_Get_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
            SqlCommand cmd= new SqlCommand("select * from BillDetail where ProductId = " +dataGridView1.CurrentCell.Value +" ",con);
            SqlDataReader sdr = cmd.ExecuteReader();
            
                if (sdr.Read())
                {
                    txt_ProductID.Text = sdr["ProductId"].ToString();
                    txt_ProductName.Text = sdr["ProductName"].ToString();
                    txt_Price.Text = Math.Round(Convert.ToDouble(sdr["Price"])).ToString();
                   
                }
                else
                {
                    MessageBox.Show("No data found");
                }
                con.Close();
            }
            catch (SqlException sqlE)
            {
                MessageBox.Show(sqlE.ToString());
            }
            

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from BillDetail where ProductId = " + txt_ProductID.Text + " ", con);
                int d = cmd.ExecuteNonQuery();
                if (d > 0)
                {
                    MessageBox.Show("Deleted");
                    ShowDtails();
                }
                else
                {
                    MessageBox.Show("Can't Deleted");
                }
                con.Close();
            }
            catch (SqlException sqlE)
            {
                MessageBox.Show(sqlE.ToString());
            }
           


        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update BillDetail set ProductQuantity =" +comb_Quantity.Text + " where ProductId= " + txt_ProductID.Text + " ", con);
                int res = cmd.ExecuteNonQuery();
                if(res > 0)
                {
                    MessageBox.Show("Updated");                    
                    ShowDtails();
                }
                else
                {
                    MessageBox.Show("Can't Update");
                }
                con.Close();
            }
            catch (SqlException sqlE)
            {
                MessageBox.Show(sqlE.ToString());
            }
        
           
        }

         private void btn_View_Click(object sender, EventArgs e)
         {
             try
             {
                con.Open();
                 SqlDataAdapter sda = new SqlDataAdapter("Select BillDate,ProductId,ProductName,ProductQuantity,Price,Total from BillDetail", con);
                 DataSet ds = new DataSet();
                 sda.Fill(ds);
                 dataGridView1.DataSource = ds.Tables[0];
                con.Close();
             }
             catch (SqlException sqlE)
             {
                 MessageBox.Show(sqlE.ToString());
             }

            

    }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
                           
                txt_ProductID.Text = " ";
                txt_ProductName.Text = " ";
                txt_Price.Text = " ";
                comb_Quantity.Text = " ";
                        
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
          
            if (cmd_Pmode.Text != "")
            {
                
                Form3 t3 = new Form3();
                t3.Show();
                con.Open();               
                MessageBox.Show("Printed Successfully");
                ShowDtails();
                label_Total.Text = "";
                SqlCommand cmd = new SqlCommand("update BillDetail set PrintStatus ='Y'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                ShowDtails();


            }
            else
            {
                MessageBox.Show("Please select Payment Mode");
            }
           
            
           
            
           
            con.Close();
        }

        
    }
}

