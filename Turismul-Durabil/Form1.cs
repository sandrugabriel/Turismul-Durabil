using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turismul_Durabil.Models;
using Turismul_Durabil.Panels;

namespace Turismul_Durabil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Utilizator utilizator = new Utilizator("1061485824|Ana|Maria|maria@gmail.com|maria1234|1");
            Utilizator admin = new Utilizator("1|Sandru|Gabriel|gabi@gmail.com|gabi1234|0");
            this.Controls.Add(new PnlVacanta(this,admin));

        }

        public void removePnl(string pnl)
        {

            Control control = null;

            foreach (Control c in this.Controls)
            {

                if (c.Name.Equals(pnl))
                {
                    control = c;
                }

            }

            this.Controls.Remove(control);
        }

    }
}
