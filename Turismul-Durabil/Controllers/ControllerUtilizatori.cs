using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turismul_Durabil.Models;

namespace Turismul_Durabil.Controllers
{
    internal class ControllerUtilizatori
    {

        private List<Utilizator> utilizatori;


        public ControllerUtilizatori()
        {

            utilizatori = new List<Utilizator>();

            load();

        }

        public void load()
        {

            string path = Application.StartupPath + @"/data/Utilizatori.txt";

            StreamReader streamReader = new StreamReader(path);

            string t;

            while((t = streamReader.ReadLine()) != null)
            {

                Utilizator utilizator = new Utilizator(t);
                utilizatori.Add(utilizator);

            }

            streamReader.Close();
        }


        public bool verifEmail(string email)
        {

            for (int i = 0; i < utilizatori.Count; i++)
            {

                if (utilizatori[i].getEmail() == email)
                {
                    return false;
                }

            }

            return true;
        }

        public void saveNewClient(string textul)
        {

            string path = Application.StartupPath + @"/data/Utilizatori.txt";

            File.AppendAllText(path, textul + "\n");


        }

        public Utilizator getByid(int id)
        {

            for (int i = 0; i < utilizatori.Count; i++)
            {
                if (id == utilizatori[i].getIdUtilizator())
                {
                    return utilizatori[i];
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

        public bool verifAut(string email, string parola)
        {

            for (int i = 0; i < utilizatori.Count; i++)
            {

                if (utilizatori[i].getEmail() == email && utilizatori[i].getPassword() == parola)
                {
                    return true;
                }

            }

            return false;

        }

        public Utilizator ClientByEmaiParo(string email, string parola)
        {

            for (int i = 0; i < utilizatori.Count; i++)
            {

                if (utilizatori[i].getEmail() == email && utilizatori[i].getPassword() == parola)
                {
                    return utilizatori[i];
                }

            }

            return null;

        }

        public List<Utilizator> getUtilizators()
        {
            List<Utilizator> list = new List<Utilizator>();

            for(int i = 0; i < utilizatori.Count; i++)
            {
                if (utilizatori[i].getTipCont() != 0)
                {
                    list.Add(utilizatori[i]);
                }
            }

            return list;
        }

        public string toSaveFisier()
        {

            string t = "";

            for (int i = 0; i < utilizatori.Count; i++)
            {
                t += utilizatori[i].toSave() + "\n";
            }

            return t;
        }

        public void setTipCont(int id,int tip)
        {

            for(int i = 0; i < utilizatori.Count; i++)
            {
                if (utilizatori[i].getIdUtilizator() == id)
                {
                    utilizatori[i].setTipCont(tip);
                }
            }

        }

        public void update()
        {
            String path = Application.StartupPath + @"/data/Utilizatori.txt";
            StreamWriter streamWriter = new StreamWriter(path);

            streamWriter.Write(this.toSaveFisier());

            streamWriter.Close();
        }

        public int getIdByEmail(String email)
        {

            for(int i = 0; i < utilizatori.Count; i++)
            {
                if (utilizatori[i].getEmail().Equals(email))
                {
                    return utilizatori[i].getIdUtilizator();
                }
            }

            return -1;
        }

    }
}
