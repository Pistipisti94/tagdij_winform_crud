using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tagdij_winform_crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adatMódosításToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ugyfellista.Visible= false;
            befizetett.Visible= false;
            label1.Visible= false;
            label2.Visible= false;
        }

        private void befizetésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ugyfellista.Visible = true;
            befizetett.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }
    }
}
