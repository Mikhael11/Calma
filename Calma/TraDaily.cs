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
    public partial class TraDaily : Form
    {
        public TraDaily()
        {
            InitializeComponent();
        }

        private void tran_daily1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            LoginPg lg = new LoginPg();
            lg.Show();
            this.Hide();
        }
    }
}
