using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turismul_Durabil.Models
{
    internal class Vacanta
    {

        private int idVacanta;
        private string nameVacanta;
        private string descriptionVacanta;
        private string caleFisier;
        private double pret;
        private int nrLocuri;

        public Vacanta(int idVacanta, string nameVacanta, string descriptionVacanta, string caleFisier, double pret, int nrLocuri)
        {
            this.idVacanta = idVacanta;
            this.nameVacanta = nameVacanta;
            this.descriptionVacanta = descriptionVacanta;
            this.caleFisier = caleFisier;
            this.pret = pret;
            this.nrLocuri = nrLocuri;
        }

        public Vacanta(string text) {

            string[] prop = text.Split('|');

            this.idVacanta = int.Parse(prop[0]);
            this.nameVacanta = prop[1];
            this.descriptionVacanta = prop[2];
            this.caleFisier = prop[3];
            this.pret = double.Parse(prop[4]);
            this.nrLocuri = int.Parse(prop[5]);
        
        }

        public int getidVacanta()
        {
            return this.idVacanta;
        }

        public string getnameVacanta()
        {
            return this.nameVacanta;
        }

        public string getdescriptionVacanta()
        {
            return this.descriptionVacanta;
        }

        public string getcaleFisier()
        {
            return this.caleFisier;
        }

        public double getPret()
        {
            return this.pret;
        }

        public int getnrLocuri()
        {
            return this.nrLocuri;
        }



    }
}
