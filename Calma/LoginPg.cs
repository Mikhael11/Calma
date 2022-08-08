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
            expiry();
        }

        private void backgroundWorker3_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
           /* Dashboard ds = new Dashboard();
            ds.Show();
            this.Hide();*/
             if (txtName.Text == "Calma" && txtPass.Text == "Calma2022")
             {
                 Dashboard ds = new Dashboard();
                 ds.Show();
                 this.Hide();
             }
            else if (txtName.Text == "steven" && txtPass.Text == "steven98")
            {
                Mytransaction my = new Mytransaction();
                my.Show();
                this.Hide();
            }
        }
        private void expiry()
        {
            if (DateTime.Now > new DateTime(2022, 12, 29)) //year, month, day in order
            {
                MessageBox.Show("The form has expired.  Please update");
                Application.Exit();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}