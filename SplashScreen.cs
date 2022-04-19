using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            for (int i = 0; i <= 100; i ++)
            {
                guna2ProgressBar1.Value = i;
                await Task.Delay(10);
            }
        }
        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {
            if (guna2ProgressBar1.Value == 100)
            {
                App.bookingScreen.Show();
                this.Hide();
            }
        }
    }
}
