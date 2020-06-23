using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_last_and_the_only
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       Form2 mainmenu = new Form2();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            mainmenu.ShowDialog();
            this.Hide();

        }
    }
}
