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
    public partial class Update_Item : UserControl
    {
        functions fn=new functions();
        String query;

        public Update_Item()
        {
            InitializeComponent();
        }

        private void Update_Item_Load(object sender, EventArgs e)
        {
            
            loaddata();

        }
        public void loaddata()
        {
            query = "Select * from Items";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtsearcholditem_TextChanged(object sender, EventArgs e)
        {
            query = "Select * from items Where itname like'" + txtsearcholditem.Text + "%'";

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
                            guna2DataGridView1.DataSource = dt.Tables[0];
                        }
                    }
                }
            }
        }

        int id;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < guna2DataGridView1.Rows.Count - 1)
            {
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                String category = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                String itname = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                int price = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                txtcatgolditem.Text = category;
                txtnewitem.Text = itname;
                txtnewitemprice.Text = price.ToString();
            }
           
                
                }

        private void updateitembtn_Click(object sender, EventArgs e)
        {
            query = "Update Items Set itname= '"+txtnewitem.Text+"',category='"+txtcatgolditem.Text+"',price="+txtnewitemprice.Text+" Where id = "+id+"" ;
            fn.setData(query);
            loaddata();
            txtnewitem.Clear();
            txtcatgolditem.Clear();
            txtnewitemprice.Clear();

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
