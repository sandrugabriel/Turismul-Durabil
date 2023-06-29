using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turismul_Durabil.Controllers;
using Turismul_Durabil.Models;

namespace Turismul_Durabil.Panels
{
    internal class PnlVacanta : Panel
    {

        Form1 form;
        Utilizator utilizator;

        private System.Windows.Forms.Label lblTara;
        private System.Windows.Forms.Label lblDescriere;
        private System.Windows.Forms.Button btnPoster;
        private System.Windows.Forms.Button btnReverza;
        private System.Windows.Forms.Label lblNrLocuri;
        private System.Windows.Forms.PictureBox pctVanacta;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAdmin;
        private System.Windows.Forms.TabPage tabVacMele;
        private System.Windows.Forms.TabPage tabVacante;
        private System.Windows.Forms.TabPage tabEmail;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pctBack;
        private System.Windows.Forms.PictureBox pctNext;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbNume;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbDataStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbDataEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbNrPersoane;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbPret;
        private System.Windows.Forms.DataGridViewButtonColumn cmbStergere;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblAdminNou;
        private System.Windows.Forms.Button btnInregistrare;
        private System.Windows.Forms.Button btnRenunta;
        private System.Windows.Forms.Button btnTranf;
        private System.Windows.Forms.Button btnVacantaNou;
        private System.Windows.Forms.Label lblVancantaNou;
        Timer timer;

        List<Vacanta> vacante;
        ControllerVacante controllerVacante;
        int index;
        public PnlVacanta(Form1 form1, Utilizator utilizator1)
        {
            this.form = form1;
            this.utilizator = utilizator1;
            controllerVacante = new ControllerVacante();
            vacante = new List<Vacanta>();
            vacante = controllerVacante.getVacante();
            index = 0;
            this.form.Size = new System.Drawing.Size(1028, 790);
            this.form.MinimumSize = new System.Drawing.Size(1028, 790);
            this.form.MaximumSize = new System.Drawing.Size(1028, 790);
            this.form.Location = new System.Drawing.Point(400, 5);


            //PnlVacanta
            this.Size = new System.Drawing.Size(1028, 790);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlVacanta";
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;

            this.lblTara = new System.Windows.Forms.Label();
            this.lblDescriere = new System.Windows.Forms.Label();
            this.btnPoster = new System.Windows.Forms.Button();
            this.btnReverza = new System.Windows.Forms.Button();
            this.lblNrLocuri = new System.Windows.Forms.Label();
            this.pctVanacta = new System.Windows.Forms.PictureBox();
            this.lblPret = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.btnTranf = new System.Windows.Forms.Button();
            this.btnInregistrare = new System.Windows.Forms.Button();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.lblNume = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblAdminNou = new System.Windows.Forms.Label();
            this.tabVacMele = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbNume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbDataStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbDataEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbNrPersoane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbPret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbStergere = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabVacante = new System.Windows.Forms.TabPage();
            this.pctBack = new System.Windows.Forms.PictureBox();
            this.pctNext = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabEmail = new System.Windows.Forms.TabPage();
            this.lblVancantaNou = new System.Windows.Forms.Label();
            this.btnVacantaNou = new System.Windows.Forms.Button();
            this.timer = new Timer();

            this.Controls.Add(this.tabControl);

            timer.Interval = 2000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Stop();
            timer.Enabled = false;


            // lblTara
            this.lblTara.AutoSize = true;
            // this.lblTara.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTara.Location = new System.Drawing.Point(150, 10);
            this.lblTara.Name = "lblTara";
            this.lblTara.Size = new System.Drawing.Size(147, 30);
            this.lblTara.Text = vacante[index].getnameVacanta();

            string t = vacante[index].getdescriptionVacanta();

            int interval = 38;

            int i = interval;
            while (i < t.Length)
            {
                t = t.Insert(i, "\n");
                i += interval + 1;
            }

            // lblDescriere
            this.lblDescriere.AutoSize = true;
            this.lblDescriere.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDescriere.Location = new System.Drawing.Point(30, 210);
            this.lblDescriere.Name = "lblDescriere";
            this.lblDescriere.Size = new System.Drawing.Size(78, 30);
            this.lblDescriere.Text = t;

            // btnPoster
            this.btnPoster.Location = new System.Drawing.Point(120, 620);
            this.btnPoster.Name = "btnPoster";
            this.btnPoster.Size = new System.Drawing.Size(181, 39);
            this.btnPoster.Text = "Poster";
            this.btnPoster.Click += new EventHandler(btnPoster_Click);

            // btnReverza
            this.btnReverza.Location = new System.Drawing.Point(120, 570);
            this.btnReverza.Name = "btnReverza";
            this.btnReverza.Size = new System.Drawing.Size(181, 40);
            this.btnReverza.Text = "Rezerva acum";
            this.btnReverza.Click += new EventHandler(btnReverza_Click);

            // lblNrLocuri
            this.lblNrLocuri.AutoSize = true;
            //this.lblNrLocuri.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNrLocuri.Location = new System.Drawing.Point(30, 136);
            this.lblNrLocuri.Name = "lblNrLocuri";
            this.lblNrLocuri.Size = new System.Drawing.Size(200, 30);
            this.lblNrLocuri.Text = vacante[index].getnrLocuri().ToString() + " locuri";

            // pctVanacta
            this.pctVanacta.Location = new System.Drawing.Point(283, 26);
            this.pctVanacta.Name = "pctVanacta";
            this.pctVanacta.Size = new System.Drawing.Size(377, 669);
            this.pctVanacta.Controls.Add(lblTara);
            this.pctVanacta.Controls.Add(lblPret);
            this.pctVanacta.Controls.Add(lblNrLocuri);
            this.pctVanacta.Controls.Add(lblDescriere);
            this.pctVanacta.Controls.Add(btnPoster);
            this.pctVanacta.Controls.Add(btnReverza);
            this.pctVanacta.Image = Image.FromFile(Application.StartupPath + @"/Imagini/" + vacante[index].getnameVacanta() + ".jpg");
            this.pctVanacta.SizeMode = PictureBoxSizeMode.StretchImage;

            // lblPret
            this.lblPret.AutoSize = true;
            //  this.lblPret.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPret.Location = new System.Drawing.Point(30, 73);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(147, 30);
            this.lblPret.Text = vacante[index].getPret().ToString() + " Lei";

            // tabControl
            this.tabControl.Controls.Add(this.tabAdmin);
            this.tabControl.Controls.Add(this.tabVacMele);
            this.tabControl.Controls.Add(this.tabVacante);
            this.tabControl.Controls.Add(this.tabEmail);
            this.tabControl.Location = new System.Drawing.Point(14, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(992, 825);

            // tabAdmin
            this.tabAdmin.Controls.Add(this.btnVacantaNou);
            this.tabAdmin.Controls.Add(this.lblVancantaNou);
            this.tabAdmin.Controls.Add(this.btnTranf);
            this.tabAdmin.Controls.Add(this.btnInregistrare);
            this.tabAdmin.Controls.Add(this.btnRenunta);
            this.tabAdmin.Controls.Add(this.lblNume);
            this.tabAdmin.Controls.Add(this.comboBox1);
            this.tabAdmin.Controls.Add(this.lblAdminNou);
            this.tabAdmin.Location = new System.Drawing.Point(4, 39);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdmin.Size = new System.Drawing.Size(984, 782);
            this.tabAdmin.Text = "Admin";
            if (utilizator.getTipCont() == 1)
            {
                this.tabControl.TabPages[0].Enabled = false;
                tabControl.SelectedTab = tabControl.TabPages[2];
            }
            else
            {
                this.tabControl.TabPages[0].Enabled = true;
            }


            // btnTranf
            this.btnTranf.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11.8F);
            this.btnTranf.Location = new System.Drawing.Point(610, 214);
            this.btnTranf.Name = "btnTranf";
            this.btnTranf.Size = new System.Drawing.Size(180, 70);
            this.btnTranf.TabIndex = 5;
            this.btnTranf.Text = "Transforma in admin";
            this.btnTranf.UseVisualStyleBackColor = true;

            // btnInregistrare
            this.btnInregistrare.Location = new System.Drawing.Point(400, 213);
            this.btnInregistrare.Name = "btnInregistrare";
            this.btnInregistrare.Size = new System.Drawing.Size(180, 70);
            this.btnInregistrare.TabIndex = 4;
            this.btnInregistrare.Text = "Inregistrare";
            this.btnInregistrare.UseVisualStyleBackColor = true;

            // btnRenunta
            this.btnRenunta.Location = new System.Drawing.Point(191, 214);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(180, 70);
            this.btnRenunta.TabIndex = 3;
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.UseVisualStyleBackColor = true;

            // lblNume
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(258, 127);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(66, 30);
            this.lblNume.TabIndex = 2;
            this.lblNume.Text = "User:";

            // comboBox1
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(330, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(311, 38);
            this.comboBox1.TabIndex = 1;

            // lblAdminNou
            this.lblAdminNou.AutoSize = true;
            this.lblAdminNou.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminNou.Location = new System.Drawing.Point(337, 33);
            this.lblAdminNou.Name = "lblAdminNou";
            this.lblAdminNou.Size = new System.Drawing.Size(267, 36);
            this.lblAdminNou.TabIndex = 0;
            this.lblAdminNou.Text = "Adauga Admin Nou";

            // tabVacMele
            this.tabVacMele.Controls.Add(this.dataGridView1);
            this.tabVacMele.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabVacMele.Location = new System.Drawing.Point(4, 39);
            this.tabVacMele.Name = "tabVacMele";
            this.tabVacMele.Padding = new System.Windows.Forms.Padding(3);
            this.tabVacMele.Size = new System.Drawing.Size(984, 782);
            this.tabVacMele.TabIndex = 1;
            this.tabVacMele.Text = "Vacantele mele";
            this.tabVacMele.UseVisualStyleBackColor = true;

            // dataGridView1
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmbNume,
            this.cmbDataStart,
            this.cmbDataEnd,
            this.cmbNrPersoane,
            this.cmbPret,
            this.cmbStergere});
            this.dataGridView1.Location = new System.Drawing.Point(16, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(950, 384);
            this.dataGridView1.TabIndex = 0;

            // cmbNume
            this.cmbNume.HeaderText = "Vacanta";
            this.cmbNume.MinimumWidth = 6;
            this.cmbNume.Name = "cmbNume";
            this.cmbNume.ReadOnly = true;
            this.cmbNume.Width = 180;

            // cmbDataStart
            this.cmbDataStart.HeaderText = "Data Start";
            this.cmbDataStart.MinimumWidth = 6;
            this.cmbDataStart.Name = "cmbDataStart";
            this.cmbDataStart.ReadOnly = true;
            this.cmbDataStart.Width = 180;

            // cmbDataEnd
            this.cmbDataEnd.HeaderText = "Data End";
            this.cmbDataEnd.MinimumWidth = 6;
            this.cmbDataEnd.Name = "cmbDataEnd";
            this.cmbDataEnd.ReadOnly = true;
            this.cmbDataEnd.Width = 180;

            // cmbNrPersoane
            this.cmbNrPersoane.HeaderText = "Nr persoane";
            this.cmbNrPersoane.MinimumWidth = 6;
            this.cmbNrPersoane.Name = "cmbNrPersoane";
            this.cmbNrPersoane.Width = 125;

            // cmbPret
            this.cmbPret.HeaderText = "Pret";
            this.cmbPret.MinimumWidth = 6;
            this.cmbPret.Name = "cmbPret";
            this.cmbPret.ReadOnly = true;
            this.cmbPret.Width = 110;

            // cmbStergere
            this.cmbStergere.HeaderText = "Stergere";
            this.cmbStergere.MinimumWidth = 6;
            this.cmbStergere.Name = "cmbStergere";
            this.cmbStergere.ReadOnly = true;
            this.cmbStergere.Width = 145;

            // tabVacante
            this.tabVacante.Controls.Add(this.pctBack);
            this.tabVacante.Controls.Add(this.pctNext);
            this.tabVacante.Controls.Add(this.checkBox1);
            this.tabVacante.Controls.Add(this.pctVanacta);
            this.tabVacante.Location = new System.Drawing.Point(4, 39);
            this.tabVacante.Name = "tabVacante";
            this.tabVacante.Size = new System.Drawing.Size(984, 782);
            this.tabVacante.TabIndex = 2;
            this.tabVacante.Text = "Vacante";
            this.tabVacante.UseVisualStyleBackColor = true;

            // pctBack
            this.pctBack.Location = new System.Drawing.Point(192, 306);
            this.pctBack.Name = "pctBack";
            this.pctBack.Size = new System.Drawing.Size(70, 70);
            this.pctBack.Click += new EventHandler(pctBack_Click);
            this.pctBack.Image = Image.FromFile(Application.StartupPath + @"/prev.png");
            this.pctBack.SizeMode = PictureBoxSizeMode.StretchImage;

            // pctNext
            this.pctNext.Location = new System.Drawing.Point(680, 306);
            this.pctNext.Name = "pctNext";
            this.pctNext.Size = new System.Drawing.Size(70, 70);
            this.pctNext.Click += new EventHandler(pctNext_Click);
            this.pctNext.Image = Image.FromFile(Application.StartupPath + @"/next.png");
            this.pctNext.SizeMode = PictureBoxSizeMode.StretchImage;

            // checkBox1
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(826, 660);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 34);
            this.checkBox1.Text = "AutoPlay";
            this.checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);

            // tabEmail
            this.tabEmail.Location = new System.Drawing.Point(4, 39);
            this.tabEmail.Name = "tabEmail";
            this.tabEmail.Size = new System.Drawing.Size(984, 782);
            this.tabEmail.Text = utilizator.getEmail();

            // lblVancantaNou
            this.lblVancantaNou.AutoSize = true;
            this.lblVancantaNou.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVancantaNou.Location = new System.Drawing.Point(337, 371);
            this.lblVancantaNou.Name = "lblVancantaNou";
            this.lblVancantaNou.Size = new System.Drawing.Size(300, 36);
            this.lblVancantaNou.Text = "Adauga Vacanta Noua";

            // btnVacantaNou
            this.btnVacantaNou.Location = new System.Drawing.Point(379, 454);
            this.btnVacantaNou.Name = "btnVacantaNou";
            this.btnVacantaNou.Size = new System.Drawing.Size(201, 69);
            this.btnVacantaNou.Text = "Vacanta noua";


        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox.Checked)
            {
                timer.Enabled = true;
                timer.Start();
            }
            else
            {
                timer.Enabled = false;
                timer.Stop();
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {

                index++;
                if (index >= vacante.Count)
                {
                    index = 0;
                }

                this.pctVanacta.Image = Image.FromFile(Application.StartupPath + @"/Imagini/" + vacante[index].getnameVacanta() + ".jpg");

                string t = vacante[index].getdescriptionVacanta();

                int interval = 38;

                int i = interval;
                while (i < t.Length)
                {
                    t = t.Insert(i, "\n");
                    i += interval + 1;
                }

                lblTara.Text = vacante[index].getnameVacanta();
                lblPret.Text = vacante[index].getPret().ToString();
                lblNrLocuri.Text = vacante[index].getnrLocuri().ToString();
                lblDescriere.Text = t;
            }
            else
            {
                timer.Stop();
                timer.Enabled = false;
            }


        }

        private void pctNext_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Checked = false;
            }
            if (index == vacante.Count - 1)
            {
                index = -1;
            }
            index++;
            this.pctVanacta.Image = Image.FromFile(Application.StartupPath + @"/Imagini/" + vacante[index].getnameVacanta() + ".jpg");

            string t = vacante[index].getdescriptionVacanta();

            int interval = 38;

            int i = interval;
            while (i < t.Length)
            {
                t = t.Insert(i, "\n");
                i += interval + 1;
            }

            lblTara.Text = vacante[index].getnameVacanta();
            lblPret.Text = vacante[index].getPret().ToString();
            lblNrLocuri.Text = vacante[index].getnrLocuri().ToString();
            lblDescriere.Text = t;


        }

        private void pctBack_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Checked = false;
            }
            if (index == 0)
            {
                index = vacante.Count;
            }
            index--;
            this.pctVanacta.Image = Image.FromFile(Application.StartupPath + @"/Imagini/" + vacante[index].getnameVacanta() + ".jpg");

            string t = vacante[index].getdescriptionVacanta();

            int interval = 38;

            int i = interval;
            while (i < t.Length)
            {
                t = t.Insert(i, "\n");
                i += interval + 1;
            }

            lblTara.Text = vacante[index].getnameVacanta();
            lblPret.Text = vacante[index].getPret().ToString();
            lblNrLocuri.Text = vacante[index].getnrLocuri().ToString();
            lblDescriere.Text = t;


        }

        private void btnPoster_Click(object sender, EventArgs e)
        {
           
           
           
        }

        private void btnReverza_Click(object sender, EventArgs e)
        {

            Vacanta vacanta = vacante[index];
            this.form.removePnl("PnlVacanta");
            this.form.Controls.Add(new PnlRervare(form, utilizator, vacanta));

        }

    }
}
