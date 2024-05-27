using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_hospital
{
    public class PatientService
    {
        private List <Patient> _patient;

        public PatientService()
        {
            _patient = new List <Patient>();
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
                        Patient patient = new Patient(line);
                        this._patient.Add(patient);
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
            string currentDictory = Directory.GetCurrentDirectory();

            string folder = Path.Combine(currentDictory, "data");

            string file = Path.Combine(folder, "patient");

            return file;
        }

        public string ToSaveAll()
        {
            String save = "";

            for (int i = 0; i < _patient.Count - 1; i++)
            {
                save += _patient[i].ToSave() + "\n";
            }

            save += _patient[_patient.Count - 1].ToSave();

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

        public void AfisarePatient()
        {
            foreach(Patient x in _patient)
            {
                Console.WriteLine(x.PatientInfo());
            }
        }

        public List<int> SortareaPacientilorTai(int yourId)
        {
            List <int> wantedPacient = new List<int>();

            for(int i = 0; i < _patient.Count; i++)
            {
                if (_patient[i].DoctorForPatient == yourId)
                {
                    wantedPacient.Add(_patient[i].IdPatient);
                }
            }
            return wantedPacient;
        }

        public void AfisareaPacientilorTai(List<int> wantedPacient)
        {
            if (wantedPacient.Count == 0)
            {
                Console.WriteLine("Lista este goala");
                return;
            }

            foreach (int x in wantedPacient)
            {
                Console.WriteLine(x);
            }
        }


    }
}
