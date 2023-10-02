namespace CoMo
{
    public partial class Cobra : Form
    {
        bool ButtonFlag = false;

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Cobra()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (ButtonFlag)
            {
                button.BackColor = Color.MediumSeaGreen;
                button.Text = "Start";
                ButtonFlag = false;
            }
            else //kod dla startu
            {
                button.Text = "Stop";
                button.BackColor = Color.LightCoral;
                ButtonFlag = true;


                while (ButtonFlag)
                {
                    await Task.Delay(60000);
                    await MoveMouseAsync();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async Task MoveMouseAsync()
        {
            Point currentPosition = Cursor.Position;
            Cursor.Position = new Point(currentPosition.X, currentPosition.Y - 10);

            await Task.Delay(1000);
            currentPosition = Cursor.Position;

            Cursor.Position = new Point(currentPosition.X, currentPosition.Y + 10);
        }
    }
}