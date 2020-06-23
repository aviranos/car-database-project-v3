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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void carsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carsBindingSource.EndEdit();
          //  this.tableAdapterManager.UpdateAll(this.dataBase_Car_TabelDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
        }
    }
}
