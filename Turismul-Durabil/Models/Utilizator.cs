using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Turismul_Durabil.Models
{
    internal class Utilizator
    {

        private int IdUser;
        private string name;
        private string prenume;
        private string email;
        private string password;
        private int tipCont;

        public Utilizator(int idUser, string name, string prenume, string email, string password, int tipCont)
        {
            IdUser = idUser;
            this.name = name;
            this.prenume = prenume;
            this.email = email;
            this.password = password;
            this.tipCont = tipCont;
        
        }

        public Utilizator(string text) {

            string[] prop = text.Split('|');
        
            this.IdUser = int.Parse(prop[0]);
            this.name = prop[1];
            this.prenume = prop[2];
            this.email = prop[3];
            this.password = prop[4];
            this.tipCont = int.Parse(prop[5]);

        }
        
        public int getIdUtilizator()
        {
            return this.IdUser;
        }

        public string getName() {
            return this.name;
        }

        public string getPrenume()
        {
            return this.prenume;
        }

        public string getEmail()
        {
            return this.email;
        }

        public string getPassword()
        {
            return this.password;
        }

        public int getTipCont()
        {
            return this.tipCont;
        }

        public void setTipCont(int tipCont)
        {
            this.tipCont = tipCont;
        }

        public string toSave()
        {
            return IdUser.ToString() +"|"+name+"|"+prenume+"|"+email+"|"+password +"|"+tipCont.ToString();
        }

    }
}
