namespace tagdij_winform_crud
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ugyfellista = new System.Windows.Forms.ListBox();
            this.befizetett = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.befizetésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adatMódosításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.befizetes_button = new System.Windows.Forms.Button();
            this.nev_textBox1 = new System.Windows.Forms.TextBox();
            this.szuldatum_textBox2 = new System.Windows.Forms.TextBox();
            this.irszam_textBox3 = new System.Windows.Forms.TextBox();
            this.orszag_textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.modositas_button1 = new System.Windows.Forms.Button();
            this.azon_textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.befizetett)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ugyfellista
            // 
            this.ugyfellista.FormattingEnabled = true;
            resources.ApplyResources(this.ugyfellista, "ugyfellista");
            this.ugyfellista.Name = "ugyfellista";
            this.ugyfellista.Click += new System.EventHandler(this.ugyfellista_Click);
            // 
            // befizetett
            // 
            resources.ApplyResources(this.befizetett, "befizetett");
            this.befizetett.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.befizetett.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.befizetett.Name = "befizetett";
            this.befizetett.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.befizetésToolStripMenuItem,
            this.adatMódosításToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // befizetésToolStripMenuItem
            // 
            this.befizetésToolStripMenuItem.Name = "befizetésToolStripMenuItem";
            resources.ApplyResources(this.befizetésToolStripMenuItem, "befizetésToolStripMenuItem");
            this.befizetésToolStripMenuItem.Click += new System.EventHandler(this.befizetésToolStripMenuItem_Click);
            // 
            // adatMódosításToolStripMenuItem
            // 
            this.adatMódosításToolStripMenuItem.Name = "adatMódosításToolStripMenuItem";
            resources.ApplyResources(this.adatMódosításToolStripMenuItem, "adatMódosításToolStripMenuItem");
            this.adatMódosításToolStripMenuItem.Click += new System.EventHandler(this.adatMódosításToolStripMenuItem_Click);
            // 
            // befizetes_button
            // 
            resources.ApplyResources(this.befizetes_button, "befizetes_button");
            this.befizetes_button.Name = "befizetes_button";
            this.befizetes_button.UseVisualStyleBackColor = true;
            this.befizetes_button.Click += new System.EventHandler(this.befizetes_button_Click);
            // 
            // nev_textBox1
            // 
            resources.ApplyResources(this.nev_textBox1, "nev_textBox1");
            this.nev_textBox1.Name = "nev_textBox1";
            // 
            // szuldatum_textBox2
            // 
            resources.ApplyResources(this.szuldatum_textBox2, "szuldatum_textBox2");
            this.szuldatum_textBox2.Name = "szuldatum_textBox2";
            // 
            // irszam_textBox3
            // 
            resources.ApplyResources(this.irszam_textBox3, "irszam_textBox3");
            this.irszam_textBox3.Name = "irszam_textBox3";
            // 
            // orszag_textBox4
            // 
            resources.ApplyResources(this.orszag_textBox4, "orszag_textBox4");
            this.orszag_textBox4.Name = "orszag_textBox4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // modositas_button1
            // 
            resources.ApplyResources(this.modositas_button1, "modositas_button1");
            this.modositas_button1.Name = "modositas_button1";
            this.modositas_button1.UseVisualStyleBackColor = true;
            this.modositas_button1.Click += new System.EventHandler(this.modositas_button1_Click);
            // 
            // azon_textBox1
            // 
            resources.ApplyResources(this.azon_textBox1, "azon_textBox1");
            this.azon_textBox1.Name = "azon_textBox1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.azon_textBox1);
            this.Controls.Add(this.modositas_button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orszag_textBox4);
            this.Controls.Add(this.irszam_textBox3);
            this.Controls.Add(this.szuldatum_textBox2);
            this.Controls.Add(this.nev_textBox1);
            this.Controls.Add(this.befizetes_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.befizetett);
            this.Controls.Add(this.ugyfellista);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.befizetett)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ugyfellista;
        private System.Windows.Forms.NumericUpDown befizetett;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem befizetésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adatMódosításToolStripMenuItem;
        private System.Windows.Forms.Button befizetes_button;
        private System.Windows.Forms.TextBox nev_textBox1;
        private System.Windows.Forms.TextBox szuldatum_textBox2;
        private System.Windows.Forms.TextBox irszam_textBox3;
        private System.Windows.Forms.TextBox orszag_textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button modositas_button1;
        private System.Windows.Forms.TextBox azon_textBox1;
    }
}

