using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_hospital
{
    public class RegistrationSectionService
    {
        private List<RegistrationSection> _registrations;

        public RegistrationSectionService()
        {
            _registrations = new List<RegistrationSection>();
            this.LoadData();
        }

        public void LoadData()
        {
            try
            {
                using (StreamReader sr = new StreamReader(this.GetFilePath()))
                {
                    string line = " ";
                    while ((line = sr.ReadLine()) != null)
                    {
                        RegistrationSection registrationSection = new RegistrationSection(line);
                        this._registrations.Add(registrationSection);
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public string GetFilePath()
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            string folder = Path.Combine(currentDirectory, "data");

            string file = Path.Combine(folder, "registration");

            return file;
        }

        public string ToSaveAll()
        {
            String save = "";

            for (int i = 0; i < _registrations.Count - 1; i++)
            {
                save += _registrations[i].ToSave() + "\n";
            }

            save += _registrations[_registrations.Count - 1].ToSave();

            return save;
        }

        public void SaveData()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(this.GetFilePath()))
                {
                    sw.Write(ToSaveAll());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        //CRUD

        public void AfisareInregistration()
        {
            foreach(RegistrationSection x in _registrations)
            {
                Console.WriteLine(x.RegistrationInfo());
            }
        }
    }
}
