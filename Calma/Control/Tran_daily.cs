using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calma.Control
{
    public partial class Tran_daily : UserControl
    {
        public Tran_daily()
        {
            InitializeComponent();
        }

       
        functions fn = new functions();
        String query;
        
        public void loaddata()
        {
            query = "Select * from Transactions where date like'" + DateTime.Now.ToString("dd-MM-yyyy") + "%'";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        private void Tran_daily_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        int amount = 0;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < guna2DataGridView1.Rows.Count)
                    amount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());


            }
            catch
            {


            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker senderObject = (DateTimePicker)sender;
            query = "Select * from Transactions where date like'" + senderObject.Value.ToString("dd-MM-yyyy") + "%'";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        double total;
        private void Print_Click(object sender, EventArgs e)
        {


            DGVPrinter printer1 = new DGVPrinter();
            printer1.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer1.PageNumbers = true;
            printer1.PageNumberInHeader = false;
            printer1.PorportionalColumns = true;
            printer1.HeaderCellAlignment = StringAlignment.Near;
            //printer1.Title ="toral="+.Text;
            printer1.Footer = "Total = " + txttotaltransactions.Text;
            printer1.FooterSpacing = 15;
            printer1.PrintDataGridView(guna2DataGridView1);
            txttotaltransactions.Text = "0";
        }
        int sum = 0;
        int sumIterations = 0;

        private void Seesumbtn_Click(object sender, EventArgs e)
        {

            sum = 0;

            for (int i = 0; i < guna2DataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(guna2DataGridView1.Rows[i].Cells[2].Value);
                sumIterations++;
            }

            txttotaltransactions.Text = sum.ToString();
        }

        private void Dlttrans_Click(object sender, EventArgs e)
        {




            try
            {
                int id = this.guna2DataGridView1.SelectedRows[0].Index;
                int idd = int.Parse(guna2DataGridView1.Rows[id].Cells[0].Value.ToString());
                query = "Delete from Transactions where id = " + idd;
                fn.setData(query);

                if (sum > 0)
                {
                    // id = int.Parse(guna2DataGridView1.Rows[].Cells[0].Value.ToString());
                    guna2DataGridView1.Rows.RemoveAt(id);
                    sum = sum - amount;
                    if (this.guna2DataGridView1.SelectedRows.Count > 0)
                    {
                        int x = this.guna2DataGridView1.SelectedRows[0].Index;

                        amount = int.Parse(guna2DataGridView1.Rows[x].Cells[2].Value.ToString());
                        query = "Delete from Transactions where id = " + x;
                        fn.setData(query);
                    }
                    else
                    {
                        amount = 0;
                    }
                    if (sum < 0)
                    {
                        sum = 0;
                    }
                    Seesumbtn_Click(null, null);
                }




            }
            catch
            {


            }


        }

      

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            DateTimePicker senderObject = (DateTimePicker)sender;
            query = "Select * from Transactions where date like'" + senderObject.Value.ToString("dd-MM-yyyy") + "%'";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2DataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < guna2DataGridView1.Rows.Count)
                    amount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());


            }
            catch
            {


            }

        }

        private void Seesumbtn_Click_1(object sender, EventArgs e)
        {
            sum = 0;

            for (int i = 0; i < guna2DataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(guna2DataGridView1.Rows[i].Cells[2].Value);
                sumIterations++;
            }

            txttotaltransactions.Text = sum.ToString();
        }

        private void Dlttrans_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = this.guna2DataGridView1.SelectedRows[0].Index;
                int idd = int.Parse(guna2DataGridView1.Rows[id].Cells[0].Value.ToString());
                query = "Delete from Transactions where id = " + idd;
                fn.setData(query);

                if (sum > 0)
                {
                    // id = int.Parse(guna2DataGridView1.Rows[].Cells[0].Value.ToString());
                    guna2DataGridView1.Rows.RemoveAt(id);
                    sum = sum - amount;
                    if (this.guna2DataGridView1.SelectedRows.Count > 0)
                    {
                        int x = this.guna2DataGridView1.SelectedRows[0].Index;

                        amount = int.Parse(guna2DataGridView1.Rows[x].Cells[2].Value.ToString());
                        query = "Delete from Transactions where id = " + x;
                        fn.setData(query);
                    }
                    else
                    {
                        amount = 0;
                    }
                    if (sum < 0)
                    {
                        sum = 0;
                    }
                    Seesumbtn_Click(null, null);
                }




            }
            catch
            {


            }

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            LoginPg p = new LoginPg();
            p.Show();
            this.Hide();
        }
    }
}
