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
    public partial class ManagerConsole : Form
    {
        public ManagerConsole()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            App.bookingScreen.Show();
        }
        protected override void OnClosed(EventArgs e)
        {
            App.bookingScreen.Show();
            base.OnClosed(e);
        }
    }
}
