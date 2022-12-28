using System.Media;
namespace Calma
{
    public partial class LoginPg : Form
    {
        private SoundPlayer sound,sound1;
        public LoginPg()
        {
            InitializeComponent();
            sound = new SoundPlayer(@"C:\lempy.wav");
            sound1 = new SoundPlayer(@"C:\ahln.wav");
            //sound.Play;
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
                 sound1.Play();
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
            else if (txtName.Text == "tra" && txtPass.Text == "tra2022")
            {
                TraDaily tr = new TraDaily();
                tr.Show();
                this.Hide();
            }
            else
            {
                sound.Play();
                MessageBox.Show("Wrong Password or UserName, Aren't you From Calma cafe ?");
                //SoundPlayer sound = new SoundPlayer(@"C:\lempy.mp3");
                
            }
             
        }
        private void expiry()
        {
            if (DateTime.Now > new DateTime(2025, 5, 30)) //year, month, day in order
            {
                MessageBox.Show("The System coding has expired.  Please update");
                Application.Exit();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}