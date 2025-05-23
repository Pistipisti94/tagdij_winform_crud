﻿using System;
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
        List<Ugyfel> ugyfels = new List<Ugyfel>();

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
            ugyfels = Adatbazis.GetAllugyfel();
            foreach (var item in ugyfels)
            {
                ugyfellista.Items.Add(item);                    
            }
        }


        private void ugyfellista_Click(object sender, EventArgs e)
        {
            string selectedItem = ugyfellista.SelectedItem.ToString();
            string[] parts = selectedItem.Split(';');
            if (parts.Length >= 5)
            {
                azon_textBox1.Text = parts[0];
                nev_textBox1.Text = parts[1];
                szuldatum_textBox2.Text = parts[2];
                irszam_textBox3.Text = parts[3];
                orszag_textBox4.Text = parts[4];
            }
            else
            {
                MessageBox.Show("A kiválasztott sor nem tartalmaz elegendő adatot.");
            }            
        }

        private void befizetes_button_Click(object sender, EventArgs e)
        {
            try
            {
                Adatbazis.Create(Convert.ToInt32(azon_textBox1.Text), Convert.ToInt32(befizetett.Value));
            }
            catch (Exception)
            {

                MessageBox.Show("Nincs ügyfél kiválasztva");
            }
        }

        private void modositas_button1_Click(object sender, EventArgs e)
        {
            try
            {
                Adatbazis.Modosit(Convert.ToInt32(azon_textBox1.Text),nev_textBox1.Text,Convert.ToDateTime(szuldatum_textBox2.Text), Convert.ToInt32(irszam_textBox3.Text),orszag_textBox4.Text);
                ugyfellista.Items.Clear();
                LoadUgyfel();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
