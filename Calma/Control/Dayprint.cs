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
    public partial class Dayprint : UserControl
    {
        functions fn = new functions();
        String query;
        public Dayprint()
        {
            InitializeComponent();
        }
        public void loaddata()
        {
            query = "Select * from Transactions where date like'" + DateTime.Now.ToString("dd-MM-yyyy") + "%'";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dayprint_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            // = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //String time = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //int price = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
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
            
            DGVPrinter printer = new DGVPrinter();
            printer.PrintDataGridView(guna2DataGridView1);
            printer.Footer = "total cost in the day = " + txttotaltransactions;
        }

        private void Seesumbtn_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < guna2DataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(guna2DataGridView1.Rows[i].Cells[2].Value);
            }
            txttotaltransactions.Text = sum.ToString();
        }
    }
}
