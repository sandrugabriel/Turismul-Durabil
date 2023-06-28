using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turismul_Durabil.Controllers;

namespace Turismul_Durabil.Panels
{
    internal class PnlStart:Panel
    {

        Form1 form;

        PictureBox pictureBox;
        Label lblEmail;
        TextBox txtEmail;
        TextBox txtParola;
        Label lblParola;
        Button btnInregistrare;
        Button btnAutentificare;

        ControllerUtilizatori controllerUtilizatori;

        public PnlStart(Form1 form1) { 
        
            this.form = form1;
            this.controllerUtilizatori = new ControllerUtilizatori();
            this.form.Size = new System.Drawing.Size(823, 600); 
            this.form.MinimumSize = new System.Drawing.Size(823, 600);
            this.form.MaximumSize = new System.Drawing.Size(823, 600);


            //PnlStart
            this.Size = new System.Drawing.Size(823, 600);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlStart";

            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.btnInregistrare = new System.Windows.Forms.Button();
            this.btnAutentificare = new System.Windows.Forms.Button();

            this.Controls.Add(this.btnAutentificare);
            this.Controls.Add(this.btnInregistrare);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.pictureBox);

            // pictureBox
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(802, 204);
            this.pictureBox.Image = Image.FromFile(Application.StartupPath + @"/Banner.png");
            this.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
             
            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(205, 236);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 30);
            this.lblEmail.Text = "Email";
            
            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(210, 269);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(371, 38);
             
            // txtParola
            this.txtParola.Location = new System.Drawing.Point(210, 386);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(371, 38);
             
            // lblParola
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(205, 353);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(78, 30);
            this.lblParola.Text = "Parola";
             
            // btnInregistrare
            this.btnInregistrare.Location = new System.Drawing.Point(210, 496);
            this.btnInregistrare.Name = "btnInregistrare";
            this.btnInregistrare.Size = new System.Drawing.Size(170, 47);
            this.btnInregistrare.Text = "Inregistrare";
            this.btnInregistrare.BackColor = ColorTranslator.FromHtml("#DAFFFB");
            this.btnInregistrare.Click += new EventHandler(btnInregistrare_Click);
             
            // btnAutentificare
            this.btnAutentificare.Location = new System.Drawing.Point(411, 496);
            this.btnAutentificare.Name = "btnAutentificare";
            this.btnAutentificare.Size = new System.Drawing.Size(170, 47);
            this.btnAutentificare.Text = "Autentificare"; 
            this.btnAutentificare.BackColor = ColorTranslator.FromHtml("#DAFFFB");
            this.btnAutentificare.Click += new EventHandler(btnAutentificare_Click);


        }

        private void btnInregistrare_Click(object sender, EventArgs e)
        {

            this.form.removePnl("PnlStart");
            this.form.Controls.Add(new PnlInregistrare(form));

        }

        private void btnAutentificare_Click(Object sender, EventArgs e) {

            int semn = 0;

            if(txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Nu ai introdus emailul!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                semn = 1;
            }

            if (txtParola.Text.Equals(""))
            {
                MessageBox.Show("Nu ai introdus parola!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                semn = 1;
            }

            if(semn == 0) {

                if (controllerUtilizatori.verifAut(txtEmail.Text, txtParola.Text))
                {
                    this.form.removePnl("PnlStart");

                }
                else
                {
                    MessageBox.Show("Eroare de autentificare!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtParola.Text = "";
                    txtEmail.Text = "";

                }


            }

        }


    }
}
