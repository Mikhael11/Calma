namespace Calma
{
    public partial class LoginPg : Form
    {
        public LoginPg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker3_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.Show();
            this.Hide();
            /* if (txtName.Text == "Calma" && txtPass.Text == "Calma2022")
             {
                 Dashboard ds = new Dashboard();
                 ds.Show();
                 this.Hide();
             }*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}