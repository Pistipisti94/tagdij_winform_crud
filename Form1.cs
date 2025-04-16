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
        Adatbazis Adatbazis = new Adatbazis();
        List<Ugyfel> futars = new List<Ugyfel>();

        private void adatMódosításToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //befizetés menü adatok eltüntetése
            ugyfellista.Visible= false;
            befizetett.Visible= false;
            label1.Visible= false;
            label2.Visible= false;
            befizetes_button.Visible= false;
            //adatmódosítás menü adatok megjelenítése
            label3.Visible= true;
            nev_textBox1.Visible= true;
            label4.Visible= true;
            szuldatum_textBox2.Visible= true;
            label5.Visible= true;
            irszam_textBox3.Visible= true;
            label6.Visible= true;
            orszag_textBox4.Visible= true;
            modositas_button1.Visible= true;

        }

        private void befizetésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //adatmódosítás menü adatok megjelenítése
            label3.Visible = false;
            nev_textBox1.Visible = false;
            label4.Visible = false;
            szuldatum_textBox2.Visible = false;
            label5.Visible = false;
            irszam_textBox3.Visible = false;
            label6.Visible = false;
            orszag_textBox4.Visible = false;
            modositas_button1.Visible= false;
            //befizetés menü adatok megjelenítése
            ugyfellista.Visible = true;
            befizetett.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            befizetes_button.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUgyfel();
        }
        private void LoadUgyfel()
        {
            futars = Adatbazis.GetAllugyfel();
            foreach (var item in futars)
            {
                ugyfellista.Items.Add(item);                    
            }
        }
    }
}
