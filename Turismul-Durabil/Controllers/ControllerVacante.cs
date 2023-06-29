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
    internal class ControllerVacante
    {

        private List<Vacanta> vacante;

        public ControllerVacante()
        {

            vacante = new List<Vacanta>();

            load();

        }

        public void load() {

            string path = Application.StartupPath + @"/data/Vacante.txt";
        
            StreamReader streamReader = new StreamReader(path);

            string t;

            while((t = streamReader.ReadLine()) != null)
            {

                Vacanta vacanta = new Vacanta(t);
                vacante.Add(vacanta);
                
            }

            streamReader.Close();

        }

        public List<Vacanta> getVacante()
        {
            return vacante;
        }

        public string getNumeleVacantei(int id)
        {

            for(int i=0; i<vacante.Count; i++)
            {
                if (vacante[i].getidVacanta() == id)
                {
                    return vacante[i].getnameVacanta();
                }
            }

            return null;
        }

    }
}
