using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_hospital
{
    public class SectionService
    {
        private List <Section> _sections;

        public SectionService()
        {
            _sections = new List<Section>();
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
                        Section sectionService = new Section(line);
                        this._sections.Add(sectionService);
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

            string file = Path.Combine(folder, "section");

            return file;
        }

        public string ToSaveAll()
        {
            String save = "";

            for (int i = 0; i < _sections.Count - 1; i++)
            {
                save += _sections[i].ToSave() + "\n";
            }

            save += _sections[_sections.Count - 1].ToSave();

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

        public void AfisareSection()
        {
            foreach(Section x in _sections)
            {
                Console.WriteLine(x.SectionInfo());
            }
        }
    }
}
