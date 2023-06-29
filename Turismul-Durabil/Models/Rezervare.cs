using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Turismul_Durabil.Models
{
    internal class Rezervare
    {

        private int IdRezervare;
        private int IdUser;
        private int IdVacanta;
        private DateTime dateStart;
        private DateTime dateEnd;
        private int nrPersoane;
        private double pret;

        public Rezervare(int idRezervare,int idVacanta, int idUser, DateTime dateStart, DateTime dateEnd, int nrPersoane, double pret)
        {
            this.IdRezervare = idRezervare;
            this.IdUser = idUser;
            this.IdVacanta = idVacanta;
            this.dateStart = dateStart;
            this.dateEnd = dateEnd;
            this.nrPersoane = nrPersoane;
            this.pret = pret;
        }

        public Rezervare(string t) {

            string[] prop = t.Split('|');

            this.IdRezervare = int.Parse(prop[0]);
            this.IdUser = int.Parse(prop[1]);
            this.IdVacanta= int.Parse(prop[2]);
            this.dateStart = DateTime.Parse(prop[3]);
            this.dateEnd = DateTime.Parse(prop[4]);
            this.nrPersoane = int.Parse(prop[5]);
            this.pret = int.Parse(prop[6]);
        
        }

        public int getIdRezervare()
        {
            return this.IdRezervare;
        }

        public int getIdUser()
        {
            return this.IdUser;
        }

        public int getIdVacanta()
        {
            return this.IdVacanta;
        }

        public DateTime getDateStart()
        {
            return this.dateStart;
        }

        public DateTime getDateEnd()
        {
            return this.dateEnd;
        }

        public int getNrPersoane()
        {
            return this.nrPersoane;
        }

        public double getPret()
        {
            return this.pret;
        }

        public string toSave()
        {
            return IdRezervare.ToString()+"|"+IdUser+"|"+IdVacanta+"|"+dateStart+"|"+dateEnd+"|"+nrPersoane.ToString()+"|"+pret.ToString();
        }

    }
}
