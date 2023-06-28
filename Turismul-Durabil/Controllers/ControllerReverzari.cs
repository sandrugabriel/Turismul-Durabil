using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turismul_Durabil.Models;

namespace Turismul_Durabil.Controllers
{
    internal class ControllerReverzari
    {

        private List<Rezervare> rezervari;

        public ControllerReverzari()
        {

            rezervari = new List<Rezervare>();

            load();

        }

        public void load()
        {

            string path = Application.StartupPath + @"/data/Rezervari.txt";

            StreamReader streamReader = new StreamReader(path);

            string t;

            while((t = streamReader.ReadLine()) != null)
            {

                Rezervare rezervare = new Rezervare(t);
                rezervari.Add(rezervare);
            }

            streamReader.Close();
        }


    }
}
