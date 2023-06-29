using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turismul_Durabil.Controllers;
using Turismul_Durabil.Models;

namespace Turismul_Durabil.Panels
{
    internal class PnlAddVacanta:Panel
    {

        Form1 form;
        Utilizator utilizator;

        private System.Windows.Forms.Label lblTara;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblNr;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label lblDescriere;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button btnAddVacanta;
        private System.Windows.Forms.TextBox txtTara;
        private System.Windows.Forms.NumericUpDown numericNrLocuri;
        private System.Windows.Forms.TextBox txtSuma;

        ControllerVacante controllerVacante;

        List<string> errori;

        public PnlAddVacanta(Form1 form1,Utilizator utilizator1)
        {
            this.form = form1;
            this.utilizator = utilizator1;
            this.controllerVacante = new ControllerVacante();
            this.form.Size = new System.Drawing.Size(1006, 575);
            this.form.MinimumSize = new System.Drawing.Size(1006, 575);
            this.form.MaximumSize = new System.Drawing.Size(1006, 575);

            errori = new List<string>();

            //PnlAddVacanta
            this.Size = new System.Drawing.Size(1006, 575);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlAddVacanta";

            this.lblTara = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblNr = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblDescriere = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.btnAddVacanta = new System.Windows.Forms.Button();
            this.txtTara = new System.Windows.Forms.TextBox();
            this.numericNrLocuri = new System.Windows.Forms.NumericUpDown();
            this.txtSuma = new System.Windows.Forms.TextBox();

            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.numericNrLocuri);
            this.Controls.Add(this.txtTara);
            this.Controls.Add(this.btnAddVacanta);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.lblDescriere);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.lblNr);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.lblTara);

            // lblTara
            this.lblTara.AutoSize = true;
            this.lblTara.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.lblTara.Location = new System.Drawing.Point(165, 111);
            this.lblTara.Name = "lblTara";
            this.lblTara.Size = new System.Drawing.Size(162, 32);
            this.lblTara.Text = "Tara vacantei";
             
            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20F);
            this.lblTitlu.Location = new System.Drawing.Point(343, 18);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(305, 45);
            this.lblTitlu.Text = "Adaugare Vacanta";
             
            // lblNr
            this.lblNr.AutoSize = true;
            this.lblNr.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.lblNr.Location = new System.Drawing.Point(581, 111);
            this.lblNr.Name = "lblNr";
            this.lblNr.Size = new System.Drawing.Size(339, 32);
            this.lblNr.Text = "Numarul locurilor disponibile";
             
            // lblSuma
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.lblSuma.Location = new System.Drawing.Point(667, 257);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(152, 32);
            this.lblSuma.Text = "Suma Totala";
             
            // lblDescriere
            this.lblDescriere.AutoSize = true;
            this.lblDescriere.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.lblDescriere.Location = new System.Drawing.Point(188, 257);
            this.lblDescriere.Name = "lblDescriere";
            this.lblDescriere.Size = new System.Drawing.Size(120, 32);
            this.lblDescriere.Text = "Descriere";
             
            // richTextBox
            this.richTextBox.Location = new System.Drawing.Point(60, 304);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(418, 183);
            this.richTextBox.Text = "";
             
            // btnAddVacanta
            this.btnAddVacanta.Location = new System.Drawing.Point(635, 420);
            this.btnAddVacanta.Name = "btnAddVacanta";
            this.btnAddVacanta.Size = new System.Drawing.Size(213, 67);
            this.btnAddVacanta.Text = "Add Vacanta";
            this.btnAddVacanta.Click += new EventHandler(btnAddVacanta_Click);
            
            // txtTara
            this.txtTara.Location = new System.Drawing.Point(127, 146);
            this.txtTara.Name = "txtTara";
            this.txtTara.Size = new System.Drawing.Size(266, 34);
             
            // numericNrLocuri
            this.numericNrLocuri.Location = new System.Drawing.Point(686, 146);
            this.numericNrLocuri.Name = "numericNrLocuri";
            this.numericNrLocuri.Size = new System.Drawing.Size(123, 34);
             
            // txtSuma
            this.txtSuma.Location = new System.Drawing.Point(643, 292);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(205, 34);

        }

        public void verificare()
        {
            errori.Clear();

            if (txtTara.Text.Equals(""))
            {
                errori.Add("Nu ai introdus numele excursiei!");
            }

            if (txtSuma.Text.Equals(""))
            {
                errori.Add("Nu ai introdus suma!");
            }

            if (richTextBox.Text.Equals(""))
            {
                errori.Add("Nu ai introdus descrierea!");
            }

            if (numericNrLocuri.Value == 0)
            {
                errori.Add("Nu ai introdus numarul de locuri!");
            }

        }

        private void btnAddVacanta_Click(object sender, EventArgs e)
        {
            verificare();
            if (errori.Count > 0)
            {

                for (int i = 0; i < errori.Count; i++)
                {
                    MessageBox.Show(errori[i], "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                string text = controllerVacante.generareId() + "|" + txtTara.Text + "|" + richTextBox.Text + "|" + txtSuma.Text + "|" + numericNrLocuri.Text;
                controllerVacante.save(text);
                this.form.removePnl("PnlAddVacanta");
                this.form.Controls.Add(new PnlVacanta(form, utilizator));
            }
          
        }


    }
}
