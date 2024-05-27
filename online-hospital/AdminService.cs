using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_hospital
{
    public class AdminService
    {
        private List<Admin> _admins;

        public AdminService()
        {
            _admins = new List<Admin>();
            this.LoadData(); 
        }

        public void LoadData()
        {
            try
            {
                using (StreamReader sr = new StreamReader(GetFilePath()))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Admin admin = new Admin(line);
                        _admins.Add(admin);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public string GetFilePath()
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            string folder = Path.Combine(currentDirectory, "data");

            string file = Path.Combine(folder, "admin"); 

            return file;
        }

        public void SaveData()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(GetFilePath()))
                {
                    foreach (Admin admin in _admins)
                    {
                        sw.WriteLine(admin.ToSave());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public void DisplayAdmins()
        {
            foreach (Admin admin in _admins)
            {
                Console.WriteLine(admin.AdminInfo());
            }
        }
    }
}
