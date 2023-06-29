using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turismul_Durabil.Controllers;
using Turismul_Durabil.Models;

namespace Turismul_Durabil.Panels
{
    internal class PnlRervare:Panel
    {

        Form1 form;
        Utilizator utilizator;
        Vacanta vacanta;

        private System.Windows.Forms.Label lblTara;
        private System.Windows.Forms.Label lblNumele;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNr;
        private System.Windows.Forms.Label lblSumaTotala;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label lblDescriere;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label lblPers;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label lblDataStart;
        private System.Windows.Forms.Label lblDataEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Button btnRevervare;
        PictureBox pictureBox;
        Button btnCancel;

        ControllerReverzari controllerReverzari;
        ControllerVacante controllerVacante;

        double suma;
        int nrDezile;
        int nrPersoane;


        public PnlRervare(Form1 form1,Utilizator utilizator1,Vacanta vacanta1)
        {

            this.form = form1;
            this.utilizator = utilizator1;
            this.vacanta = vacanta1;
            controllerReverzari = new ControllerReverzari();
            controllerVacante = new ControllerVacante();
            nrPersoane = 1;

            this.form.Size = new System.Drawing.Size(1106, 768);
            this.form.MinimumSize = new System.Drawing.Size(1106, 768);
            this.form.MaximumSize = new System.Drawing.Size(1106, 768);

            // MockupRevervare
            this.Size = new System.Drawing.Size(1106, 768);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlRevervare";

            this.lblTara = new System.Windows.Forms.Label();
            this.lblNumele = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNr = new System.Windows.Forms.Label();
            this.lblSumaTotala = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblDescriere = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.lblPers = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblDataStart = new System.Windows.Forms.Label();
            this.lblDataEnd = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.btnRevervare = new System.Windows.Forms.Button();
            pictureBox = new System.Windows.Forms.PictureBox();
            btnCancel = new System.Windows.Forms.Button();

            this.Controls.Add(this.btnRevervare);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.lblDataEnd);
            this.Controls.Add(this.lblDataStart);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.lblPers);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.lblDescriere);
            this.Controls.Add(this.lblSumaTotala);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNr);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.lblNumele);
            this.Controls.Add(this.lblTara);
            this.Controls.Add(pictureBox);
            this.Controls.Add(btnCancel);

            pictureBox.BackColor = ColorTranslator.FromHtml("#001C30");
            pictureBox.Size = new Size(1200,95);
            

            // lblTara
            this.lblTara.AutoSize = true;
            this.lblTara.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.lblTara.Location = new System.Drawing.Point(101, 137);
            this.lblTara.Name = "lblTara";
            this.lblTara.Size = new System.Drawing.Size(162, 32);
            this.lblTara.Text = "Tara vacantei";
             
            // lblNumele
            this.lblNumele.AutoSize = true;
            this.lblNumele.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.lblNumele.Location = new System.Drawing.Point(164, 180);
            this.lblNumele.Name = "lblNumele";
            this.lblNumele.Size = new System.Drawing.Size(28, 32);
            this.lblNumele.Text = vacanta.getnameVacanta();
            
            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20F);
            this.lblTitlu.Location = new System.Drawing.Point(376, 28);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(173, 45);
            this.lblTitlu.Text = "Rezervare";
            this.lblTitlu.BackColor = ColorTranslator.FromHtml("#001C30");
            this.lblTitlu.ForeColor = System.Drawing.Color.White;

            // label2
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.label2.Location = new System.Drawing.Point(729, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 32);
            this.label2.Text = vacanta.getnrLocuri().ToString();
             
            // lblNr
            this.lblNr.AutoSize = true;
            this.lblNr.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.lblNr.Location = new System.Drawing.Point(572, 137);
            this.lblNr.Name = "lblNr";
            this.lblNr.Size = new System.Drawing.Size(339, 32);
            this.lblNr.Text = "Numarul locurilor disponibile";
             
            // lblSumaTotala
            this.lblSumaTotala.AutoSize = true;
            this.lblSumaTotala.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.lblSumaTotala.Location = new System.Drawing.Point(750, 607);
            this.lblSumaTotala.Name = "lblSumaTotala";
            this.lblSumaTotala.Size = new System.Drawing.Size(28, 32);
            suma = vacanta.getPret();
            this.lblSumaTotala.Text = suma.ToString();
             
            // lblSuma
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.lblSuma.Location = new System.Drawing.Point(687, 575);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(152, 32);
            this.lblSuma.Text = "Suma Totala";
            
            // lblDescriere
            this.lblDescriere.AutoSize = true;
            this.lblDescriere.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.lblDescriere.Location = new System.Drawing.Point(207, 237);
            this.lblDescriere.Name = "lblDescriere";
            this.lblDescriere.Size = new System.Drawing.Size(120, 32);
            this.lblDescriere.Text = "Descriere";


            string t = vacanta.getdescriptionVacanta();

            int interval = 38;

            int i = interval;
            while (i < t.Length)
            {
                t = t.Insert(i, "\n");
                i += interval + 1;
            }

            // richTextBox
            this.richTextBox.Location = new System.Drawing.Point(61, 286);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(418, 183);
            this.richTextBox.Text = t;
             
            // lblPers
            this.lblPers.AutoSize = true;
            this.lblPers.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.lblPers.Location = new System.Drawing.Point(610, 223);
            this.lblPers.Name = "lblPers";
            this.lblPers.Size = new System.Drawing.Size(258, 32);
            this.lblPers.Text = "Numarul de persoane";
             
            // numericUpDown
            this.numericUpDown.Location = new System.Drawing.Point(684, 272);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(123, 34);
            this.numericUpDown.Value = 1;
            this.numericUpDown.ValueChanged += new EventHandler(numericUpDown1_ValueChanged);
            this.numericUpDown.Maximum = vacanta.getnrLocuri();
            
            // lblDataStart
            this.lblDataStart.AutoSize = true;
            this.lblDataStart.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.lblDataStart.Location = new System.Drawing.Point(610, 339);
            this.lblDataStart.Name = "lblDataStart";
            this.lblDataStart.Size = new System.Drawing.Size(124, 32);
            this.lblDataStart.Text = "Data Start";
             
            // lblDataEnd
            this.lblDataEnd.AutoSize = true;
            this.lblDataEnd.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.lblDataEnd.Location = new System.Drawing.Point(610, 444);
            this.lblDataEnd.Name = "lblDataEnd";
            this.lblDataEnd.Size = new System.Drawing.Size(116, 32);
            this.lblDataEnd.Text = "Data End";
            
            // dateStart
            this.dateStart.Location = new System.Drawing.Point(616, 374);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(354, 34);
            this.dateStart.ValueChanged += new EventHandler(dateStart_ValueChanged);
             
            // dateEnd
            this.dateEnd.Location = new System.Drawing.Point(616, 479);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(354, 34);
            this.dateEnd.Value = dateStart.Value.AddDays(1);
            this.dateEnd.ValueChanged += new EventHandler(dateEnd_ValueChanged);

            // btnRevervare
            this.btnRevervare.Location = new System.Drawing.Point(169, 554);
            this.btnRevervare.Name = "btnRevervare";
            this.btnRevervare.Size = new System.Drawing.Size(227, 78);
            this.btnRevervare.Text = "Rezervare acum";
            this.btnRevervare.BackColor = ColorTranslator.FromHtml("#64CCC5"); ;
            this.btnRevervare.ForeColor = Color.White;
            this.btnRevervare.Click += new EventHandler(btnRevervare_Click);

            // btnBack
            this.btnCancel.Location = new System.Drawing.Point(169, 640);
            this.btnCancel.Name = "btnRevervare";
            this.btnCancel.Size = new System.Drawing.Size(227, 78);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.BackColor = ColorTranslator.FromHtml("#64CCC5"); ;
            this.btnCancel.ForeColor = Color.White;
            this.btnCancel.Click += new EventHandler(btnCancel_Click);

            DateTime data1 = dateStart.Value;
            DateTime data2 = dateEnd.Value;

            TimeSpan diferenta = data2.Subtract(data1);

            nrDezile = diferenta.Days;

          

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;

            int newValue = (int)numericUpDown.Value;
            nrPersoane = newValue;
            suma = vacanta.getPret() * nrPersoane * nrDezile;
            lblSumaTotala.Text = suma.ToString();
        }

        private void dateStart_ValueChanged(object sender, EventArgs e)
        {


            DateTime data1 = dateStart.Value;
            DateTime data2 = dateEnd.Value;

            TimeSpan diferenta = data2.Subtract(data1);

            nrDezile = diferenta.Days;

            suma = vacanta.getPret() * nrPersoane * nrDezile;
            lblSumaTotala.Text = suma.ToString();
        }

        private void dateEnd_ValueChanged(object sender, EventArgs e)
        {


            DateTime data1 = dateStart.Value;
            DateTime data2 = dateEnd.Value;

            TimeSpan diferenta = data2.Subtract(data1);

            nrDezile = diferenta.Days;

            suma = vacanta.getPret() * nrPersoane * nrDezile;
            lblSumaTotala.Text = suma.ToString();
        }

        private void btnRevervare_Click(object sender, EventArgs e)
        {

            this.form.removePnl("PnlRevervare");
            string textul = controllerReverzari.generareId().ToString() + "|" + utilizator.getIdUtilizator() + "|" + vacanta.getidVacanta() +"|" + dateStart.Value + "|" + dateEnd.Value + "|" + nrPersoane.ToString() + "|" + suma.ToString(); 
            controllerReverzari.save(textul);
            this.form.Controls.Add(new PnlVacanta(form, utilizator));

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.form.removePnl("PnlRevervare");
            this.form.Controls.Add(new PnlVacanta(form,utilizator));

        }

    }
}
