using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM_1618_Mark3
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private async void SplashScreen_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 200; i+=2 )
            {
                guna2ProgressBar1.Value = i;
                await Task.Delay(1);
            }
        }
        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {
            if (guna2ProgressBar1.Value == 200)
            {
                App.bookingScreen.Show();
                App.ReadDataFromMemory();
                Room.ReadDataFromMemory();
                this.Hide();
            }
        }
    }
}
