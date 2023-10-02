namespace CoMo
{
    public partial class Cobra : Form
    {
        bool flag = false;
        public Cobra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                button.BackColor = Color.MediumSeaGreen;
                button.Text = "Start";
                flag = false;
            }
            else
            {
                button.Text = "Stop";
                button.BackColor = Color.LightCoral;
                flag = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}