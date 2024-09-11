namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lbmOutput.Text = "7 of Clubs";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            lbmOutput.Text = "King of Hearts";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lbmOutput.Text = "Jack of hearts";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            lbmOutput.Text = "Diamond 8";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            lbmOutput.Text = "Ace of Diamonds";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
