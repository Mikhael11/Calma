using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calma
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            dayprint1.Visible=false;
            add_Item1.Visible = false;
            update_Item1.Visible=false;
            remove_Item1.Visible=false;
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            remove_Item1.Visible = true;
            remove_Item1.BringToFront();
        }

        private void Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPg fm=new LoginPg();
            this.Hide();
            fm.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            order_item1.Visible=true;
            order_item1.BringToFront();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add_Item1.Visible = true;
            add_Item1.BringToFront();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update_Item1.Visible=true;
            update_Item1.BringToFront();
        }

        private void Printdaily_Click(object sender, EventArgs e)
        {
            dayprint1.Visible=true;
            dayprint1.loaddata();
            dayprint1.BringToFront();
        }

        private void dayprint1_Load(object sender, EventArgs e)
        {

        }
    }
}
