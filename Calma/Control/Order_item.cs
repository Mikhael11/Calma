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

            using (SqlConnection con = new SqlConnection("data source =MIKHAEL-PC\\SQLEXPRESS;database = CalmaDb; integrated security =True"))
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
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex < guna2DataGridView1.Rows.Count-1)
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
            }
            catch
            {

            }
            total -= amount;
            txtTotalPrice.Text = + Math.Ceiling(total + (total * 0.12)) + " LE";

        }

        private void Print_Click(object sender, EventArgs e)
        {
            if(total > 0)
            {
                string date = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "Egypt Standard Time").ToString("dd-MM-yyyy hh:mm tt");

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source =DESKTOP-B73FHQT;database = CalmaDb; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandText = "INSERT INTO Transactions (date, totalPrice) VALUES ('" + date + "', " + Math.Ceiling(total + (total * 0.12)) + ")";
                cmd.ExecuteNonQuery();
                conn.Close();
                total = 0;
                amount = 0;
                guna2DataGridView1.Rows.Clear();
                txtTotalPrice.Text = "LE";
                numorder.Value = 0;
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                txtTotalPrice.Text = + Math.Ceiling(total + (total*0.12)) + "LE";
            }
            else
            {
                MessageBox.Show("Minimum quantity need to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
