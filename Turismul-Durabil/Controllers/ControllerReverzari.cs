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

        public Rezervare getByid(int id)
        {

            for (int i = 0; i < rezervari.Count; i++)
            {
                if (id == rezervari[i].getIdRezervare())
                {
                    return rezervari[i];
                }
            }

            return null;
        }

        public int generareId()
        {

            Random random = new Random();

            int id = random.Next();

            while (this.getByid(id) != null)
            {

                id = random.Next();


            }

            return id;
        }

        public void save(string textul)
        {

            string path = Application.StartupPath + @"/data/Rezervari.txt";

            File.AppendAllText(path, textul + "\n");


        }

        public List<Rezervare> getRezervarileMele(int idUtilizator)
        {

            List<Rezervare> list = new List<Rezervare>();

            for(int i=0;i<rezervari.Count;i++)
            {
                if (rezervari[i].getIdUser() == idUtilizator)
                {
                    list.Add(rezervari[i]);
                }
            }

            return list;
        }

        public int pozID(int id)
        {

            for (int i = 0; i < rezervari.Count; i++)
            {
                if (rezervari[i].getIdRezervare() == id)
                {
                    return i;
                }
            }

            return -1;
        }

        public void stergere(int id)
        {
            int p = pozID(id);
            if (p == pozID(id))
                rezervari.RemoveAt(p);

        }

        public string toSaveFisier()
        {

            string t = "";

            for (int i = 0; i < rezervari.Count; i++)
            {
                t += rezervari[i].toSave() + "\n";
            }

            return t;
        }

        public void delete(int id)
        {
            this.stergere(id);

            string path = Application.StartupPath + @"/data/Rezervari.txt";
            StreamWriter stream = new StreamWriter(path);

            stream.Write(this.toSaveFisier());

            stream.Close();
        }

    }
}
