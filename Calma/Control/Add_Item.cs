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
    public partial class Add_Item : UserControl
    {
        functions fn=new functions();
        string query;


        public Add_Item()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine(txtItemName.Text);
            Console.WriteLine(txtCatg.SelectedItem);
            Console.WriteLine(txtItemPrice.Text);
            query = "insert into Items (itname,category,price) values ('" + txtItemName.Text + "','" + txtCatg.Text + "' , '" + txtItemPrice.Text + "')";
            fn.setData(query);

        }
        public void clearAll()
        {
            txtCatg.SelectedIndex = -1;
            txtItemName.Clear();
            txtItemPrice.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
