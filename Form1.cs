using System.Runtime.InteropServices;

namespace CoMo
{
    public partial class Cobra : Form
    {
        bool ButtonFlag = false;
        int frequency = 30000;  //[ms]
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);

        const uint MOUSEEVENTF_MOVE = 0x0001;
        const uint MOUSEEVENTF_ABSOLUTE = 0x8000;

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
                    await MoveMouseSmoothly(Screen.PrimaryScreen.Bounds.Width / 4, Screen.PrimaryScreen.Bounds.Height - 20, 100);
                    await MoveMouseSmoothly(Screen.PrimaryScreen.Bounds.Width / 2 + 50, Screen.PrimaryScreen.Bounds.Height / 2-25,100);
                    await Task.Delay(frequency);
                }
            }
        }

        #region mainForm/Form1
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                ShowInTaskbar = false;
            }
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

        static async Task MoveMouseSmoothly(int targetX, int targetY, int steps)
        {
            int currentX = Cursor.Position.X;
            int currentY = Cursor.Position.Y;

            for (int i = 1; i <= steps; i++)
            {
                double ratio = (double)i / steps;
                int x = (int)(currentX + (targetX - currentX) * ratio);
                int y = (int)(currentY + (targetY - currentY) * ratio);

                MoveMouseTo(x, y);
                await Task.Delay(10); // Czas opoznienia miedzy krokami (mozesz dostosowac)
            }

            // Na koniec ustaw kursor na docelowe wspolrzedne
            MoveMouseTo(targetX, targetY);
        }

        static void MoveMouseTo(int x, int y)
        {
            int absoluteX = (int)((x / (double)Screen.PrimaryScreen.Bounds.Width) * 65535);
            int absoluteY = (int)((y / (double)Screen.PrimaryScreen.Bounds.Height) * 65535);

            uint flags = MOUSEEVENTF_MOVE | MOUSEEVENTF_ABSOLUTE;

            mouse_event(flags, absoluteX, absoluteY, 0, 0);
        }

        private void ShowWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Kliknieto lewym przyciskiem myszy na ikone
                // Minimalizuj lub przywroc okno, w zaleznosci od jego obecnego stanu
                if (!this.Visible)
                {
                    ShowInTaskbar = true;
                    this.Show();
                    WindowState = FormWindowState.Normal;
                    this.StartPosition = FormStartPosition.CenterScreen;
                }
                else
                {
                    ShowInTaskbar = false;
                    this.Hide();
                }

            }
        }

        #endregion

        private void comboBoxFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxFrequency.SelectedIndex)
            {
                case 0:
                    frequency = 59000;
                    break;
                case 1:
                    frequency = 119000;
                    break;
                case 2:
                    frequency = 179000;
                    break;
                case 3:
                    frequency =  2390000;
                    break;
                case 4:
                    frequency = 299000;
                    break;

            }
        }
    }
}