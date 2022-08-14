using DGVPrinterHelper;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
//using Startup useLegacyV2RuntimeActivationPolicy = "true"; 

namespace Calma.Control
{
    public partial class Order_item : UserControl
    {
        functions fn = new functions();
        String query;
        public Order_item()
        {
            InitializeComponent();
        }

        private void combocatg_SelectedIndexChanged(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            String category = combocatg.Text;
            query = "Select itname from items Where category = '" + category + "'";
            showItemList(query);
            /* DataSet ds = fn.GetData(query);
             System.Data.SqlClient.SqlDataAdapter da = new SqlDataAdapter();
             //da.Fill(ds);    
             int i;
             for (i = 0; i < ds.Tables[0].Rows.Count; i++)
             {
                 listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
             }*/
        }

        private void txtSrch_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            String category = combocatg.Text;
            query = "Select itname from items Where category = '" + category + "' and itname like'" + txtSrch.Text + "%'";

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet dt = new DataSet())
                        {
                            sda.Fill(dt);
                            int i;
                            for (i = 0; i < dt.Tables[0].Rows.Count; i++)
                            {
                                listBox1.Items.Add(dt.Tables[0].Rows[i][0].ToString());
                            }
                        }
                    }
                }
            }
        }
        private void showItemList(String query)
        {
            DataSet ds = fn.GetData(query);
            int i;
            for (i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            numorder.ResetText();
            texttotalorder.Clear();
            String text = listBox1.GetItemText(listBox1.SelectedItem);
            textnameorder.Text = text;
            query = "Select price from Items Where itname= '" + text + "'";
            DataSet ds = fn.GetData(query);
            try
            {
                textpriceorder.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch { }
        }

        private void texttotalorder_TextChanged(object sender, EventArgs e)
        {

        }

        private void numorder_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(numorder.Value.ToString());
            Int64 price = Int64.Parse(textpriceorder.Text);
            texttotalorder.Text = (quan * price).ToString();
        }
        protected double total = 0;
        protected int n;

        int amount;
        private System.Drawing.Printing.PrintPageEventArgs ee;

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < guna2DataGridView1.Rows.Count - 1)
                    amount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch
            {

            }

        }

        private void Rmvdata_Click(object sender, EventArgs e)
        {
            
                try
            {
                
                
                    guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
                

                if (total > 0)
                {
                    total = total - amount;
                }
            }
            catch
            {

            }
            txtTotalPrice.Text = + Math.Ceiling(total + (total * 0.12)) + "";
            txtPrice.Text = +Math.Ceiling(total) + "";
            txtService.Text = +Math.Ceiling(total * 0.12) + "";

        }
        
        private void Print_Click(object sender, EventArgs e)
        {
            
            
            
            //printer.Footer = "Total " + txtTotalPrice;
            // System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\\your_path_here\\sample.txt");
            string date1 = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "Egypt Standard Time").ToString("dd-MM-yyyy_hh-mm-ss_tt");
            string pa = ($"C:\\printer\\files\\{date1}.txt");
            query = "Select count(*) as count from Transactions where date like '" + date1.Split('_')[0] +"%'";
            var ds = fn.GetData(query);
            var countOfItems = ds.Tables[0].Rows[0][0].ToString();
            countOfItems = int.Parse(countOfItems) + 1 + "";
            using (FileStream fs = File.Create(pa))
            {
                using (TextWriter tw = new StreamWriter(fs))
                {
                    for (int i = 0; i < guna2DataGridView1.Rows.Count - 1; i++)
                    {
                        //for (int j = 0; j < guna2DataGridView1.Columns.Count; j++)
                        //{
                        tw.WriteLine($"{guna2DataGridView1.Rows[i].Cells[0].Value.ToString()},{guna2DataGridView1.Rows[i].Cells[1].Value.ToString()},{guna2DataGridView1.Rows[i].Cells[2].Value.ToString()},{guna2DataGridView1.Rows[i].Cells[3].Value.ToString()}");

                        //}
                        //tw.WriteLine("\n");
                    }
                    tw.WriteLine(countOfItems+','+txtPrice.Text);
                }
            }
            if (total > 0)
            {
                string date = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "Egypt Standard Time").ToString("dd-MM-yyyy hh:mm:ss tt");

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                SqlCommand cmd2 = new SqlCommand();
                cmd.Connection = conn;
                cmd2.Connection = conn;
                conn.Open();
                cmd.CommandText = "INSERT INTO Transactions (date, totalPrice) VALUES ('" + date + "', " + Math.Ceiling(total + (total * 0.12)) + ")";
                cmd2.CommandText = "INSERT INTO T3 (date, totalPrice) VALUES ('" + date + "', " + Math.Ceiling(total + (total * 0.12)) + ")";
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                conn.Close();
                total = 0;
                amount = 0;
                guna2DataGridView1.Rows.Clear();
                txtTotalPrice.Text = "LE";
                txtPrice.Text = "LE";
                txtService.Text = "LE";
                textnameorder.Text = "";
                textpriceorder.Text = "0";
                numorder.Value = 0;
            }
        }

      

        private void addphoto(object o, PrintPageEventArgs e)
        {
            /*DGVPrinter printer = new DGVPrinter();
             DGVPrinter.ImbeddedImage img1 = new DGVPrinter.ImbeddedImage();
             Bitmap bitmap1 = new Bitmap(@"D:\Calma Final\Calma\Calma.JPG");
             ee.Graphics.DrawImage(bitmap1, 50, 20, bitmap1.Width, bitmap1.Height);
             img1.theImage = bitmap1; img1.ImageX = 0; img1.ImageY = 10;
             img1.ImageAlignment = DGVPrinter.Alignment.NotSet;
             img1.ImageLocation = DGVPrinter.Location.Header;
             printer.ImbeddedImageList.Add(img1);*/
            System.Drawing.Image img = System.Drawing.Image.FromFile("D:\\Calma Final\\Calma\\Calma.JPG");
            Point pt = new Point(2, 1);
            e.Graphics.DrawImage(img, pt);
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < guna2DataGridView1.Rows.Count - 1)
            {
                amount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
        }

        private void Order_item_Load(object sender, EventArgs e)
        {

        }

        private void textpriceorder_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalPrice_Click(object sender, EventArgs e)
        {

        }
        ReportDataSource rds = new ReportDataSource();
       

        private void btnCard_Click(object sender, EventArgs e)
        {
            if (texttotalorder.Text != "0" && texttotalorder.Text != "")
            {
                n = guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[n].Cells[0].Value = textnameorder.Text;
                guna2DataGridView1.Rows[n].Cells[1].Value = textpriceorder.Text;
                guna2DataGridView1.Rows[n].Cells[2].Value = numorder.Text;
                guna2DataGridView1.Rows[n].Cells[3].Value = texttotalorder.Text;

                total += int.Parse(texttotalorder.Text);
                txtTotalPrice.Text = +Math.Ceiling(total + (total * 0.12)) + "";
                txtPrice.Text = +Math.Ceiling(total) + "";
                txtService.Text = +Math.Ceiling(total * 0.12) + "";
                
                /* ReportDataSource rds = new ReportDataSource();
                 rds.Name = "DataSet1";
                 rds.Value = guna2DataGridView1.DataSource;
                 ReportViewer rv = new ReportViewer();
                 Form frm = new Form();
                 rv.LocalReport.DataSources.Add(rds);
                 rv.LocalReport.ReportEmbeddedResource = "Calma.Report1.rdlc";
                 */
                //CrystalReport1 rpt = new CrystalReport1();
                //rpt.SetDataSource(guna2DataGridView1.DataSource);

                numorder.Value = 0;   
                textnameorder.Text = "";
                textpriceorder.Text = "0";
            }
            else
            {
                MessageBox.Show("Minimum quantity need to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtTotalPrice_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Reportbtn_Click(object sender, EventArgs e)
        {
        
        }

        private void txtService_Click(object sender, EventArgs e)
        {

        }
    }
}
