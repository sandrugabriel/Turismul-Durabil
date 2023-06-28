using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turismul_Durabil.Models
{
    internal class Rezervare
    {

        private int IdRezervare;
        private int IdUser;
        private DateTime dateStart;
        private DateTime dateEnd;
        private int nrPersoane;
        private double pret;

        public Rezervare(int idRezervare, int idUser, DateTime dateStart, DateTime dateEnd, int nrPersoane, double pret)
        {
            this.IdRezervare = idRezervare;
            this.IdUser = idUser;
            this.dateStart = dateStart;
            this.dateEnd = dateEnd;
            this.nrPersoane = nrPersoane;
            this.pret = pret;
        }

        public Rezervare(string t) {

            string[] prop = t.Split('|');

            this.IdRezervare = int.Parse(prop[0]);
            this.IdUser = int.Parse(prop[1]);
            this.dateStart = DateTime.Parse(prop[2]);
            this.dateEnd = DateTime.Parse(prop[3]);
            this.nrPersoane = int.Parse(prop[4]);
            this.pret = int.Parse(prop[5]);
        
        }

        public int getIdRezervare()
        {
            return this.IdRezervare;
        }

        public int getIdUser()
        {
            return this.IdUser;
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



    }
}
