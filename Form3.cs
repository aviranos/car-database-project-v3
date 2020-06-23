using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_last_and_the_only
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.BringToFront();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
