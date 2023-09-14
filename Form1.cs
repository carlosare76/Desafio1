using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1
{
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(1);
            if (progressBar1.Value==100)
            {
                timer1.Enabled = false;
                Login form = new Login();
                form.Show();
                this.Hide();
            }
        }

        private void splashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
