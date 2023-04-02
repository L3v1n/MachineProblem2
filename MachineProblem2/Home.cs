//PROGRAMMED BY: ORMIN CARIASO & ELVIN CERVANIA

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineProblem2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit?", "Quit application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnPreDef_Click(object sender, EventArgs e)
        {
            PreDefined f2 = new PreDefined();
            f2.Show();
            this.Hide();
        }
        private void btnUserDef_Click(object sender, EventArgs e)
        {
            UserDefined f3 = new UserDefined();
            f3.Show();
            this.Hide();
        }
    }
}
