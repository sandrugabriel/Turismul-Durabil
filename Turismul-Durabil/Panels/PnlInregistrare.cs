using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turismul_Durabil.Controllers;
using Turismul_Durabil.Models;

namespace Turismul_Durabil.Panels
{
    internal class PnlInregistrare : Panel
    {

        Form1 form;

        PictureBox pictureBox;
        Label lblEmail;
        TextBox txtEmail;
        TextBox txtParola;
        Label lblParola;
        Button btnInregistrare;
        Button btnRenunta;
        TextBox txtPrenume;
        Label lblPrenume;
        TextBox txtNume;
        Label lblNume;
        TextBox txtReParola;
        Label lblReParola;
        PictureBox pctCod;
        TextBox txtCod;
        Label lblCod;

        ControllerUtilizatori controllerUtilizatori;

        List<string> listCoduri;

        List<string> listErrors;

        public PnlInregistrare(Form1 form1)
        {

            this.form = form1;
            listCoduri = new List<string>();
            listErrors = new List<string>();
            this.controllerUtilizatori = new ControllerUtilizatori();
            this.form.Size = new System.Drawing.Size(900, 860);
            this.form.MinimumSize = new System.Drawing.Size(900, 860);
            this.form.MaximumSize = new System.Drawing.Size(900, 860);
            this.form.Location = new System.Drawing.Point(250, 0);
            this.form.AutoScroll = true;

            //PnlInregistrare
            this.Size = new System.Drawing.Size(892, 860);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlInregistrare";

            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.btnInregistrare = new System.Windows.Forms.Button();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.txtReParola = new System.Windows.Forms.TextBox();
            this.lblReParola = new System.Windows.Forms.Label();
            this.pctCod = new System.Windows.Forms.PictureBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();

            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.pctCod);
            this.Controls.Add(this.txtReParola);
            this.Controls.Add(this.lblReParola);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.btnInregistrare);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.pictureBox);

            // pictureBox
            this.pictureBox.Location = new System.Drawing.Point(0, -1);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(891, 127);
            this.pictureBox.Image = Image.FromFile(Application.StartupPath + @"/Banner.png");
            this.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(239, 385);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 30);
            this.lblEmail.Text = "Email";

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(244, 418);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(371, 38);

            // txtParola
            this.txtParola.Location = new System.Drawing.Point(477, 189);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(371, 38);

            // lblParola
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(472, 156);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(78, 30);
            this.lblParola.Text = "Parola";

            // btnInregistrare
            this.btnInregistrare.Location = new System.Drawing.Point(477, 741);
            this.btnInregistrare.Name = "btnInregistrare";
            this.btnInregistrare.Size = new System.Drawing.Size(185, 66);
            this.btnInregistrare.Text = "Inregistrare";
            this.btnInregistrare.BackColor = ColorTranslator.FromHtml("#DAFFFB");
            this.btnInregistrare.Click += new EventHandler(btnInregistrare_Click);

            // btnRenunta
            this.btnRenunta.Location = new System.Drawing.Point(170, 741);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(185, 66);
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.BackColor = ColorTranslator.FromHtml("#DAFFFB");
            this.btnRenunta.Click += new EventHandler(btnRenunta_Click);

            // txtPrenume
            this.txtPrenume.Location = new System.Drawing.Point(36, 306);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(371, 38);

            // lblPrenume
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(31, 273);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(107, 30);
            this.lblPrenume.Text = "Prenume";

            // txtNume
            this.txtNume.Location = new System.Drawing.Point(36, 189);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(371, 38);

            // lblNume
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(31, 156);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(77, 30);
            this.lblNume.Text = "Nume";

            // txtReParola
            this.txtReParola.Location = new System.Drawing.Point(477, 306);
            this.txtReParola.Name = "txtReParola";
            this.txtReParola.Size = new System.Drawing.Size(371, 38);

            // lblReParola
            this.lblReParola.AutoSize = true;
            this.lblReParola.Location = new System.Drawing.Point(472, 273);
            this.lblReParola.Name = "lblReParola";
            this.lblReParola.Size = new System.Drawing.Size(200, 30);
            this.lblReParola.Text = "Confirmare parola";

            // pctCod
            this.pctCod.Location = new System.Drawing.Point(291, 501);
            this.pctCod.Size = new System.Drawing.Size(278, 102);

            addList();

            Random random = new Random();

            int index = random.Next(0,23);

            this.pctCod.Name = listCoduri[index];
            this.pctCod.Image = Image.FromFile(Application.StartupPath+@"/Logare/"+listCoduri[index]+".png");

            // txtCod
            this.txtCod.Location = new System.Drawing.Point(244, 671);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(371, 38);

            // lblCod
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(364, 638);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(143, 30);
            this.lblCod.Text = "Cod captcha";


        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {

            this.form.removePnl("PnlInregistrare");
            this.form.Controls.Add(new PnlStart(this.form));

        }


        public void addList()
        {

            string path = Application.StartupPath + @"/Logare/";

            string[] imageFile = Directory.GetFiles(path, "*.png");

            for (int i = 0; i < imageFile.Length; i++)
            {
                string image = imageFile[i].Remove(0, 68);
                image = image.Remove(image.Length - 4, 4);
                listCoduri.Add(image);
            }


        }

        public void errors()
        {

            listErrors.Clear();

            if (txtNume.Text.Equals(""))
            {
                listErrors.Add("Nu ati introdus numele!!");
            }

            if (txtPrenume.Text.Equals(""))
            {
                listErrors.Add("Nu ati introdus prenumele!!");
            }

            if (txtEmail.Text.Equals(""))
            {
                listErrors.Add("Nu ati introdus emailul!!");
            }

            if (txtParola.Text.Equals(""))
            {
                listErrors.Add("Nu ati introdus parola!!");
            }
            else
            {

                if (!txtParola.Text.Equals(txtReParola.Text))
                {
                    listErrors.Add("Parolele nu se potrivesc!");
                    txtReParola.Text = "";
                }

            }


        }

        private void btnInregistrare_Click(object sender, EventArgs e)
        {
            errors();
            if (listErrors.Count > 0)
            {
                for(int i=0;i<listErrors.Count;i++)
                {
                    MessageBox.Show(listErrors[i],"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                if (txtCod.Text != pctCod.Name)
                {
                    MessageBox.Show("Nu ai scris corect codul cartcha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Random random = new Random();
                    int i = random.Next(0, 23);
                    this.pctCod.Name = listCoduri[i];
                    this.pctCod.Image = Image.FromFile(Application.StartupPath + @"/Logare/" + listCoduri[i] + ".png");
                    txtCod.Text = "";
                    return;
                }
                else
                {

                    this.form.removePnl("PnlInregistrare");

                    string text = controllerUtilizatori.generareId() + "|" + txtNume.Text + "|" + txtPrenume.Text + "|" + txtEmail.Text + "|" + txtParola.Text + "|" + 1;
                    controllerUtilizatori.saveNewClient(text);
                    Utilizator utilizator = new Utilizator(text);

                }


            }



        }


    }
}
