using System.Diagnostics;
using System.Windows.Forms;

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
                    await MoveMouseAsync(60000);
                }
            }
        }

        #region mainForm/Form1
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        #endregion

        #region LinkLabels & nameLabel

        //otwieranie przegladarki i linku za pomaca consoli
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            try
            {
                System.Diagnostics.Process.Start("cmd", $"/c start https://www.gitify.net");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystapil blad podczas otwierania przegladarki: {ex.Message}", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //mouse leave on nameLabel
        private void ml(object sender, EventArgs e)
        {
            nameLabel.ForeColor = Color.WhiteSmoke;
        }

        //mouse enter on nameLabel
        private void me(object sender, EventArgs e)
        {
            nameLabel.ForeColor = Color.Black;
        }

        #endregion

        #region Utils

        //asynchroniczna metoda przesuwajaca kursor o 10 pixeli w gore i w dol
        //delay w ms
        private async Task MoveMouseAsync(int delay)
        {
            await Task.Delay(delay);

            Point currentPosition = Cursor.Position;
            Cursor.Position = new Point(currentPosition.X, currentPosition.Y - 10);

            await Task.Delay(1000);
            currentPosition = Cursor.Position;

            Cursor.Position = new Point(currentPosition.X, currentPosition.Y + 10);
        }

        #endregion
    }
}