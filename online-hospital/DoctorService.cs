using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_hospital
{
    public class DoctorService
    {
        private List<Doctor> _doctor;

        public DoctorService()
        {
            _doctor = new List<Doctor>();
            this.LoadData();
        }

        public void LoadData()
        {
            try
            {
                using(StreamReader sr = new StreamReader(this.GetFilePath()))
                {
                    string line = " ";
                    while((line = sr.ReadLine()) != null)
                    {
                        Doctor doctor = new Doctor(line);
                        this._doctor.Add(doctor);
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public string GetFilePath()
        {
            string currentDictory = Directory.GetCurrentDirectory();

            string folder = Path.Combine(currentDictory, "data");

            string file = Path.Combine(folder, "doctor");

            return file;
        }

        public string ToSaveAll()
        {
            String save = "";

            for (int i = 0; i < _doctor.Count - 1; i++)
            {
                save += _doctor[i].ToSave() + "\n";
            }

            save += _doctor[_doctor.Count - 1].ToSave();

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

        public void AfisareDoctor()
        {
            foreach (Doctor x in _doctor)
            {
                Console.WriteLine(x.DoctorInfo());
            }
        }

    }
}
